﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using Mono.Cecil;

namespace OpenRiaServices.DomainServices.Tools.SharedTypes
{

    /// <summary>
    /// Internal class to maintain a set of known assemblies
    /// and allow clients to ask whether types or methods are
    /// in that set.
    /// </summary>
    internal sealed class SharedAssembliesCecil : ISharedAssemblies, IDisposable
    {
        private readonly string[] _assemblySearchPaths;
        private readonly Dictionary<string, TypeInfo> _sharedTypeByName;
        private readonly CustomAssemblyResolver _resolver;

        class TypeInfo
        {
            public TypeDefinition TypeDefinition { get; }

            public ModuleDefinition ModuleDefinition { get; }

            public TypeInfo(TypeDefinition t, ModuleDefinition m)
            {
                TypeDefinition = t;
                ModuleDefinition = m;
            }

            public HashSet<string> Properties;
            public TypeInfo BaseType;
        };

        private readonly ILogger _logger;

        class CustomAssemblyResolver : DefaultAssemblyResolver
        {
            public CustomAssemblyResolver(IEnumerable<string> assemblySearchPaths)
            {
                foreach (var dir in base.GetSearchDirectories())
                    base.RemoveSearchDirectory(dir);

                foreach (var dir in assemblySearchPaths)
                    base.AddSearchDirectory(dir);
            }

            public AssemblyDefinition LoadAssembly(string path)
            {
                AssemblyDefinition a = AssemblyDefinition.ReadAssembly(File.OpenRead(path), 
                    new ReaderParameters()
                    {
                         AssemblyResolver = this
                    });
                base.RegisterAssembly(a);
                return a;
            }
        }
        /// <summary>
        /// Creates a new instance of this type.
        /// </summary>
        /// <param name="assemblyFileNames">The set of assemblies to use</param>
        /// <param name="assemblySearchPaths">Optional set of paths to search for referenced assemblies.</param>
        /// <param name="logger">Optional logger to use to report errors or warnings</param>
        public SharedAssembliesCecil(IEnumerable<string> assemblyFileNames, IEnumerable<string> assemblySearchPaths, ILogger logger)
        {
            if (assemblyFileNames == null)
            {
                throw new ArgumentNullException("assemblyFileNames");
            }
            this._logger = logger;
            this._assemblySearchPaths = assemblySearchPaths?.ToArray() ?? new string[0];
            this._sharedTypeByName = new Dictionary<string, TypeInfo>(StringComparer.Ordinal);

            // TODO: Add dispose method
            this._resolver = new CustomAssemblyResolver(_assemblySearchPaths);
            this._resolver.ResolveFailure += _resolver_ResolveFailure;
            LoadAssemblies(assemblyFileNames, logger);
        }

        private AssemblyDefinition _resolver_ResolveFailure(object sender, AssemblyNameReference reference)
        {
            _logger.LogMessage(string.Format(CultureInfo.CurrentCulture, Resource.ClientCodeGen_Assembly_Load_Error, reference.FullName, string.Empty));
            return null;
        }

        private void LoadAssemblies(IEnumerable<string> assemblyFileNames, ILogger logger)
        {
            foreach (var assembly in assemblyFileNames)
            {
                try
                {
                    AssemblyDefinition a = _resolver.LoadAssembly(assembly);
                    IEnumerable<ModuleDefinition> ms = a.Modules;
                    foreach (ModuleDefinition m in ms)
                    {
                        foreach (var t in m.Types)
                        {
                            if (t.IsPublic)
                            {
                                _sharedTypeByName[t.FullName] = new TypeInfo(t, m);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Some common exceptions log a warning and keep running
                    if (ex is System.IO.FileNotFoundException ||
                        ex is System.IO.FileLoadException ||
                        ex is System.IO.PathTooLongException ||
                        ex is System.Security.SecurityException)
                    {
                        if (logger != null)
                        {
                            logger.LogMessage(string.Format(CultureInfo.CurrentCulture, Resource.ClientCodeGen_Assembly_Load_Error, assembly, ex.Message));
                        }
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }

        TypeInfo GetBaseType(TypeInfo typeInfo)
        {
            if (typeInfo.BaseType == null
                && typeInfo.TypeDefinition.BaseType != null)
            {
                var type = typeInfo.TypeDefinition.BaseType.Resolve();
                typeInfo.BaseType = new TypeInfo(type, type.Module);
            }

            return typeInfo.BaseType;
        }

        TypeInfo HasProperty(TypeInfo type, string name)
        {
            while(type != null)
            {
                // Get or Initialize Property collection
                if (type.Properties == null)
                {
                    type.Properties = new HashSet<string>();
                    foreach (var property in type.TypeDefinition.Properties)
                        type.Properties.Add(property.Name);
                }

                if (type.Properties.Contains(name))
                    return type;

                type = GetBaseType(type);
            }

            return null;
        }


        /// <summary>
        /// Returns the location of the shared assembly containing the
        /// code member described by <paramref name="key"/>.
        /// </summary>
        /// <param name="key">The description of the code element.</param>
        /// <returns>The location of the assembly that contains it or <c>null</c> if it is not in a shared assembly.</returns>
        public string GetSharedAssemblyPath(CodeMemberKey key)
        {
            Debug.Assert(key != null, "key cannot be null");
            string location = null;

            TypeInfo typeInfo;
            if (this.TryGetSharedType(key.TypeName, out typeInfo))
            {
                switch (key.KeyKind)
                {
                    case CodeMemberKey.CodeMemberKeyKind.TypeKey:
                        location = typeInfo.ModuleDefinition.Assembly.Name.Name;
                        break;

                    case CodeMemberKey.CodeMemberKeyKind.PropertyKey:
                        location = HasProperty(typeInfo, key.MemberName)?.ModuleDefinition.Assembly.Name.Name;
                        break;

                    case CodeMemberKey.CodeMemberKeyKind.MethodKey:
                        /*       Type[] parameterTypes = this.GetSharedTypes(key.ParameterTypeNames);
                               if (parameterTypes != null)
                               {
                                   MethodBase methodBase = this.FindSharedMethodOrConstructor(type, key);
                                   if (methodBase != null)
                                   {
                                       location = methodBase.DeclaringType.Assembly.Location;
                                   }
                               }
                          */
                        break;

                    default:
                        Debug.Fail("unsupported key kind");
                        break;
                }
            }
            return location;
        }

        /// <summary>
        /// Locates the <see cref="MethodBase"/> in the set of shared assemblies that
        /// corresponds to the method described by <paramref name="key"/>.
        /// </summary>
        /// <param name="sharedType">The <see cref="Type"/> we have already located in our set of shared assemblies.</param>
        /// <param name="key">The key describing the method to find.</param>
        /// <returns>The matching <see cref="MethodBase"/> or <c>null</c> if no match is found.</returns>
        /*private MethodBase FindSharedMethodOrConstructor(Type sharedType, CodeMemberKey key)
        {
            Type[] parameterTypes = this.GetSharedTypes(key.ParameterTypeNames);
            if (parameterTypes == null)
            {
                return null;
            }
            bool isConstructor = key.IsConstructor;
            IEnumerable<MethodBase> methods = isConstructor ? sharedType.GetConstructors().Cast<MethodBase>() : sharedType.GetMethods().Cast<MethodBase>();
            foreach (MethodBase method in methods)
            {
                if (!isConstructor && !string.Equals(method.Name, key.MemberName, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
                ParameterInfo[] parameterInfos = method.GetParameters();
                if (parameterInfos.Length != parameterTypes.Length)
                {
                    continue;
                }
                int matchedParameters = 0;
                for (int i = 0; i < parameterInfos.Length; ++i)
                {
                    if (string.Equals(parameterInfos[i].ParameterType.FullName, parameterTypes[i].FullName, StringComparison.OrdinalIgnoreCase))
                    {
                        ++matchedParameters;
                    }
                    else
                    {
                        break;
                    }
                }

                if (matchedParameters == parameterInfos.Length)
                {
                    return method;
                }
            }
            return null;
        }*/

        /// <summary>
        /// Given a collection of <see cref="Type"/> names, this method returns
        /// an array of all those types from the set of shared assemblies.
        /// </summary>
        /// <param name="typeNames">The collection of type names.  It can be null.</param>
        /// <returns>The collection of types in the shared assemblies.
        /// A <c>null</c> means one or more types in the list were not shared.</returns>
        TypeInfo[] GetSharedTypes(IEnumerable<string> typeNames)
        {
            if (typeNames == null)
                return Array.Empty<TypeInfo>();

            List<TypeInfo> types = new List<TypeInfo>();
            foreach (string typeName in typeNames)
            {
                TypeInfo typeInfo = default;
                if (!this.TryGetSharedType(typeName, out typeInfo))
                {
                    return null;
                }
                types.Add(typeInfo);
            }
            return types.ToArray();
        }

        /// <summary>
        /// Returns the <see cref="Type"/> from the set of shared assemblies of the given name.
        /// </summary>
        /// <param name="typeName">The fully qualified type name.</param>
        /// <returns>The <see cref="Type"/> from the shared assemblies if it exists, otherwise <c>null</c>.</returns>
        private bool TryGetSharedType(string typeName, out TypeInfo typeInfo)
        {
            if (!_sharedTypeByName.TryGetValue(typeName, out typeInfo))
            {
                bool found = false;
                // Check if typename is assembly qualified, and try resolving without assembly qualified name
                int assemblyNameStart = typeName.IndexOf(',', 0);
                if (assemblyNameStart != -1)
                {
                    var shortTypeName = typeName.Substring(0, assemblyNameStart);
                    found = TryGetSharedType(shortTypeName, out typeInfo);
                }

                if (!found)
                {
                    // TODO: extra case
                    // Try resolving type using universe, but fallback to old mscorlib special case
                    // sharedType = _universe.GetType(typeName, throwOnError: false);
                }

                _sharedTypeByName.Add(typeName, typeInfo);
            }

            return typeInfo != null;
        }

        public void Dispose()
        {
            _resolver.Dispose();
        }

        /// <summary>
        /// Attempts to load the specified <paramref name="assemblyName"/> by searching through
        /// the specified <paramref name="assemblySearchPaths"/>. The first successful load is returned.
        /// </summary>
        /// <param name="assemblyName">The assembly to locate.</param>
        /// <param name="assemblySearchPaths">List of full paths to folders to search.</param>
        /// <returns><c>null</c> for failure, else the first assembly loaded.</returns>
        /*
         * internal Assembly ReflectionOnlyLoadFromSearchPaths(AssemblyName assemblyName, IEnumerable<string> assemblySearchPaths)
        {
            string baseName = assemblyName.Name;
            foreach (string path in assemblySearchPaths)
            {
                string fullPath = Path.Combine(path, baseName) + ".dll";
                if (File.Exists(fullPath))
                {
                    Assembly assembly = ReflectionOnlyLoadFrom(fullPath, null);
                    if (assembly != null)
                    {
                        return assembly;
                    }
                }
            }
            return null;
        }
        */
    }
}
