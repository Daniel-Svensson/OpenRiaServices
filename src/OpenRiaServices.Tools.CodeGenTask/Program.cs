using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Spectre.Console.Cli;

namespace OpenRiaServices.Tools.CodeGenTask;

static class Program
{

    static int Main(string[] args)
    {
        // TODO: Remove dependency on MSBuild and then remove any PackageReferences to MSBuild and MSBuildLocator
        // * This will require splitting "OpenRiaServices.Tools" into 2 separate projects, one with MSbuild tasks and one without (just code generation)
        // For now register the most recent version of MSBuild
        Microsoft.Build.Locator.MSBuildLocator.RegisterInstance(Microsoft.Build.Locator.MSBuildLocator.QueryVisualStudioInstances().OrderByDescending(
           instance => instance.Version).First());

        if (args.Length == 1 && args[0].StartsWith('@'))
        {
            args = File.ReadAllLines(args[0].Substring(1));

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith('"') && args[i].EndsWith('"'))
                    args[i] = args[i].Substring(1, args[i].Length - 2);
            }
        }

        var app = new CommandApp<CodeGenerationCommand>();
        return app.Run(args);

        
    }

    class CodeGenerationCommand : Command<CodeGenerationCommand.CodeGenerationSettings>
    {
        public class CodeGenerationSettings : CommandSettings
        {
            [CommandOption("--language <LANGUAGE>")]
            public string Language { get; set; }

            [CommandOption("--clientFrameworkPath <CLIENT_FRAMEWORK_PATH>")]
            public string ClientFrameworkPath { get; set; }

            [CommandOption("--serverProjectPath <SERVER_PROJECT_PATH>")]
            public string ServerProjectPath { get; set; }
            [CommandOption("--clientProjectPath <SERVER_PROJECT_PATH>")]
            public string ClientProjectPath { get; set; }

            [CommandOption("--clientRootNamespace")]
            public string clientRootNamespace { get; set; }
            [CommandOption("--serverRootNamespace")]
            public string serverRootNamespace { get; set; }
            [CommandOption("--isApplicationContextGenerationEnabled")]
            public bool isApplicationContextGenerationEnabled { get; set; }
            [CommandOption("--clientProjectTargetPlatform")]
            public TargetPlatform clientProjectTargetPlatform { get; set; }
            [CommandOption("--useFullTypeNames")]
            public bool useFullTypeNames { get; set; }

            [CommandOption("--codeGeneratorName")]
            public string codeGeneratorName { get; set; }
            [CommandOption("--generatedFileName")]
            public string generatedFileName { get; set; }

            [CommandOption("--sharedSourceFiles")]
            public string[] sharedSourceFiles { get; set; }

            [CommandOption("--symbolSearchPaths")]
            public string[] symbolSearchPaths { get; set; }

            [CommandOption("--serverAssemblies")]
            public string[] serverAssemblies { get; set; }

            [CommandOption("--clientAssemblies")]
            public string[] clientAssemblies { get; set; }

            [CommandOption("--clientAssemblyPathsNormalized")]
            public string[] clientAssemblyPathsNormalized { get; set; }

            [CommandOption("--loggingPipe")]
            public string LoggingPipe { get; set; }

            public ClientCodeGenerationOptions GetCodeGenerationOptions()
            {
                return new ClientCodeGenerationOptions
                {
                    Language = Language,
                    ClientFrameworkPath = ClientFrameworkPath,
                    ServerProjectPath = ServerProjectPath,
                    ClientProjectPath = ClientProjectPath,
                    ClientRootNamespace = clientRootNamespace,
                    ServerRootNamespace = serverRootNamespace,
                    IsApplicationContextGenerationEnabled = isApplicationContextGenerationEnabled,
                    ClientProjectTargetPlatform = clientProjectTargetPlatform,
                    UseFullTypeNames = useFullTypeNames,
                };
            }

            public SharedCodeServiceParameters GetSharedCodeServiceParameters()
            {
                return new SharedCodeServiceParameters
                {
                    // TODO: should we use default names such as "--shared-source-files" 
                    SharedSourceFiles = sharedSourceFiles,
                    SymbolSearchPaths = symbolSearchPaths,
                    ServerAssemblies = serverAssemblies,
                    ClientAssemblies = clientAssemblies,
                    ClientAssemblyPathsNormalized = clientAssemblyPathsNormalized,
                };
            }
        }

        public override int Execute(CommandContext context, CodeGenerationSettings settings)
        {
            ILoggingService log = string.IsNullOrEmpty(settings.LoggingPipe)
                ? new ConsoleLogger() : new OpenRiaServices.Tools.Logging.CrossProcessLoggingWriter(settings.LoggingPipe);

            try
            {
                log.LogMessage($"OpenRiaServices CodeGen running on {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}");

                var clientCodeGenerationOptions = settings.GetCodeGenerationOptions();
                var sharedServiceParameters = settings.GetSharedCodeServiceParameters();

                SetupAppConfig(clientCodeGenerationOptions);
                RiaClientFilesTaskHelpers.CodeGenForNet6(settings.generatedFileName, clientCodeGenerationOptions, log, sharedServiceParameters, settings.codeGeneratorName);
                log.LogMessage("Code generation succeeded");

                // Success
                return 0;
            }
            catch (Exception ex)
            {
                log.LogException(ex);
                return -1;
            }
            finally
            {
                (log as IDisposable)?.Dispose();
            }
        }

        // Find app.config/web.config based on https://stackoverflow.com/questions/4738/using-configurationmanager-to-load-config-from-an-arbitrary-location/14246260#14246260
        // Note: This just looks for "app.config" in the root, we might want to be smarter when searching for them.
        // Note: Prefer web.config if running on NETFRAMEWORK
        // Note we probably want to change this to a recursive search
        // (using glob pattern to ignore bin/obj folders)
        private static void SetupAppConfig(ClientCodeGenerationOptions clientCodeGenerationOption)
        {
            var serverProjectPath = Path.GetDirectoryName(clientCodeGenerationOption.ServerProjectPath);

            var configFiles = Directory.GetFiles(serverProjectPath, "*.config");
            var configFile = configFiles.FirstOrDefault(f => f.EndsWith("app.config", StringComparison.InvariantCultureIgnoreCase));
            if (configFile != null)
            {
                AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", configFile);
            }
        }
    }
}
