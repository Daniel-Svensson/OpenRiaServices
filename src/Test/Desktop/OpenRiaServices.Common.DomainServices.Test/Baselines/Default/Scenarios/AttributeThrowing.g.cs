//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestDomainServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Threading;
    using System.Threading.Tasks;
    using OpenRiaServices;
    using OpenRiaServices.Client;
    using OpenRiaServices.Client.Authentication;
    
    
    /// <summary>
    /// The DomainContext corresponding to the 'AttributeThrowingDomainService' DomainService.
    /// </summary>
    // The following attributes were not generated:
    // 
    // - An exception occurred generating the 'ThrowingServiceAttributeProperty' property on attribute of type 'TestDomainServices.ThrowingServiceAttribute'.
    // 
    public sealed partial class AttributeThrowingDomainContext : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeThrowingDomainContext"/> class.
        /// </summary>
        public AttributeThrowingDomainContext() : 
                this(new Uri("TestDomainServices-AttributeThrowingDomainService.svc", UriKind.Relative))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeThrowingDomainContext"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The AttributeThrowingDomainService service URI.</param>
        public AttributeThrowingDomainContext(Uri serviceUri) : 
                this(DomainContext.CreateDomainClient(typeof(IAttributeThrowingDomainServiceContract), serviceUri, false))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeThrowingDomainContext"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public AttributeThrowingDomainContext(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="AttributeThrowingEntity"/> entity instances that have been loaded into this <see cref="AttributeThrowingDomainContext"/> instance.
        /// </summary>
        public EntitySet<AttributeThrowingEntity> AttributeThrowingEntities
        {
            get
            {
                return base.EntityContainer.GetEntitySet<AttributeThrowingEntity>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="AttributeThrowingEntity"/> entity instances using the 'GetThrowing' query.
        /// </summary>
        /// <param name="throwingQueryParam">The value for the 'throwingQueryParam' parameter of the query.</param>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="AttributeThrowingEntity"/> entity instances.</returns>
        // The following attributes were not generated:
        // 
        // - An exception occurred generating the 'ThrowingQueryMethodProperty' property on attribute of type 'TestDomainServices.ThrowingQueryMethodAttribute'.
        // 
        // Unable to generate the following attributes for parameter 'throwingQueryParam' due to the following errors:
        // 
        // - An exception occurred generating the 'ThrowingQueryMethodParameterProperty' property on attribute of type 'TestDomainServices.ThrowingQueryMethodParameterAttribute'.
        // 
        public EntityQuery<AttributeThrowingEntity> GetThrowingQuery(int throwingQueryParam)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("throwingQueryParam", throwingQueryParam);
            this.ValidateMethod("GetThrowingQuery", parameters);
            return base.CreateQuery<AttributeThrowingEntity>("GetThrowing", parameters, false, true);
        }
        
        /// <summary>
        /// Invokes the 'UpdateThrowing' method of the specified <see cref="AttributeThrowingEntity"/> entity.
        /// </summary>
        /// <param name="toUpdate">The <see cref="AttributeThrowingEntity"/> entity instance.</param>
        /// <param name="throwingUpdateParam">The value for the 'throwingUpdateParam' parameter for this action.</param>
        public void UpdateThrowing(AttributeThrowingEntity toUpdate, int throwingUpdateParam)
        {
            toUpdate.UpdateThrowing(throwingUpdateParam);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'InvokeThrowing' method of the DomainService.
        /// </summary>
        /// <param name="throwingInvokeParam">The value for the 'throwingInvokeParam' parameter of this action.</param>
        /// <param name="callback">Callback to invoke when the operation completes.</param>
        /// <param name="userState">Value to pass to the callback.  It can be <c>null</c>.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        // The following attributes were not generated:
        // 
        // - An exception occurred generating the 'ThrowingInvokeMethodProperty' property on attribute of type 'TestDomainServices.ThrowingInvokeMethodAttribute'.
        // 
        // Unable to generate the following attributes for parameter 'throwingInvokeParam' due to the following errors:
        // 
        // - An exception occurred generating the 'ThrowingInvokeMethodParameterProperty' property on attribute of type 'TestDomainServices.ThrowingInvokeMethodParameterAttribute'.
        // 
        public InvokeOperation<bool> InvokeThrowing(int throwingInvokeParam, Action<InvokeOperation<bool>> callback, object userState)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("throwingInvokeParam", throwingInvokeParam);
            this.ValidateMethod("InvokeThrowing", parameters);
            return this.InvokeOperation<bool>("InvokeThrowing", typeof(bool), parameters, true, callback, userState);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'InvokeThrowing' method of the DomainService.
        /// </summary>
        /// <param name="throwingInvokeParam">The value for the 'throwingInvokeParam' parameter of this action.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        // The following attributes were not generated:
        // 
        // - An exception occurred generating the 'ThrowingInvokeMethodProperty' property on attribute of type 'TestDomainServices.ThrowingInvokeMethodAttribute'.
        // 
        // Unable to generate the following attributes for parameter 'throwingInvokeParam' due to the following errors:
        // 
        // - An exception occurred generating the 'ThrowingInvokeMethodParameterProperty' property on attribute of type 'TestDomainServices.ThrowingInvokeMethodParameterAttribute'.
        // 
        public InvokeOperation<bool> InvokeThrowing(int throwingInvokeParam)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("throwingInvokeParam", throwingInvokeParam);
            this.ValidateMethod("InvokeThrowing", parameters);
            return this.InvokeOperation<bool>("InvokeThrowing", typeof(bool), parameters, true, null, null);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'InvokeThrowing' method of the DomainService.
        /// </summary>
        /// <param name="throwingInvokeParam">The value for the 'throwingInvokeParam' parameter of this action.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the work</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        // The following attributes were not generated:
        // 
        // - An exception occurred generating the 'ThrowingInvokeMethodProperty' property on attribute of type 'TestDomainServices.ThrowingInvokeMethodAttribute'.
        // 
        // Unable to generate the following attributes for parameter 'throwingInvokeParam' due to the following errors:
        // 
        // - An exception occurred generating the 'ThrowingInvokeMethodParameterProperty' property on attribute of type 'TestDomainServices.ThrowingInvokeMethodParameterAttribute'.
        // 
        public System.Threading.Tasks.Task<InvokeResult<bool>> InvokeThrowingAsync(int throwingInvokeParam, CancellationToken cancellationToken = default(CancellationToken))
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("throwingInvokeParam", throwingInvokeParam);
            this.ValidateMethod("InvokeThrowing", parameters);
            return this.InvokeOperationAsync<bool>("InvokeThrowing", parameters, true, cancellationToken);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new AttributeThrowingDomainContextEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'AttributeThrowingDomainService' DomainService.
        /// </summary>
        public interface IAttributeThrowingDomainServiceContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetThrowing' operation.
            /// </summary>
            /// <param name="throwingQueryParam">The value for the 'throwingQueryParam' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(false)]
            IAsyncResult BeginGetThrowing(int throwingQueryParam, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetThrowing'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetThrowing'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetThrowing' operation.</returns>
            QueryResult<AttributeThrowingEntity> EndGetThrowing(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'InvokeThrowing' operation.
            /// </summary>
            /// <param name="throwingInvokeParam">The value for the 'throwingInvokeParam' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(true)]
            IAsyncResult BeginInvokeThrowing(int throwingInvokeParam, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginInvokeThrowing'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginInvokeThrowing'.</param>
            /// <returns>The 'Boolean' returned from the 'InvokeThrowing' operation.</returns>
            bool EndInvokeThrowing(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'SubmitChanges' operation.
            /// </summary>
            /// <param name="changeSet">The change-set to submit.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            IAsyncResult BeginSubmitChanges(IEnumerable<ChangeSetEntry> changeSet, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            /// <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            IEnumerable<ChangeSetEntry> EndSubmitChanges(IAsyncResult result);
        }
        
        internal sealed class AttributeThrowingDomainContextEntityContainer : EntityContainer
        {
            
            public AttributeThrowingDomainContextEntityContainer()
            {
                this.CreateEntitySet<AttributeThrowingEntity>(EntitySetOperations.Edit);
            }
        }
    }
    
    /// <summary>
    /// The 'AttributeThrowingEntity' entity class.
    /// </summary>
    // The following attributes were not generated:
    // 
    // - An exception occurred generating the 'ThrowingEntityAttributeProperty' property on attribute of type 'TestDomainServices.ThrowingEntityAttribute'.
    // 
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/TestDomainServices")]
    public sealed partial class AttributeThrowingEntity : Entity
    {
        
        private string _nonThrowingProperty;
        
        private EntityRef<AttributeThrowingEntity> _throwingAssociation;
        
        private EntityCollection<AttributeThrowingEntity> _throwingAssociationCollection;
        
        private string _throwingProperty;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnNonThrowingPropertyChanging(string value);
        partial void OnNonThrowingPropertyChanged();
        partial void OnThrowingPropertyChanging(string value);
        partial void OnThrowingPropertyChanged();
        partial void OnUpdateThrowingInvoking(int throwingUpdateParam);
        partial void OnUpdateThrowingInvoked();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeThrowingEntity"/> class.
        /// </summary>
        public AttributeThrowingEntity()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'NonThrowingProperty' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public string NonThrowingProperty
        {
            get
            {
                return this._nonThrowingProperty;
            }
            set
            {
                if ((this._nonThrowingProperty != value))
                {
                    this.OnNonThrowingPropertyChanging(value);
                    this.ValidateProperty("NonThrowingProperty", value);
                    this._nonThrowingProperty = value;
                    this.RaisePropertyChanged("NonThrowingProperty");
                    this.OnNonThrowingPropertyChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the associated <see cref="AttributeThrowingEntity"/> entity.
        /// </summary>
        // The following attributes were not generated:
        // 
        // - An exception occurred generating the 'ThrowingEntityAssociationAttributeProperty' property on attribute of type 'TestDomainServices.ThrowingEntityAssociationAttribute'.
        // 
        [EntityAssociation("Association", "ThrowingProperty", "NonThrowingProperty", IsForeignKey=true)]
        public AttributeThrowingEntity ThrowingAssociation
        {
            get
            {
                if ((this._throwingAssociation == null))
                {
                    this._throwingAssociation = new EntityRef<AttributeThrowingEntity>(this, "ThrowingAssociation", this.FilterThrowingAssociation);
                }
                return this._throwingAssociation.Entity;
            }
            set
            {
                AttributeThrowingEntity previous = this.ThrowingAssociation;
                if ((previous != value))
                {
                    this.ValidateProperty("ThrowingAssociation", value);
                    if ((value != null))
                    {
                        this.ThrowingProperty = value.NonThrowingProperty;
                    }
                    else
                    {
                        this.ThrowingProperty = default(string);
                    }
                    this._throwingAssociation.Entity = value;
                    this.RaisePropertyChanged("ThrowingAssociation");
                }
            }
        }
        
        /// <summary>
        /// Gets the collection of associated <see cref="AttributeThrowingEntity"/> entity instances.
        /// </summary>
        // The following attributes were not generated:
        // 
        // - An exception occurred generating the 'ThrowingEntityAssociationCollectionAttributeProperty' property on attribute of type 'TestDomainServices.ThrowingEntityAssociationCollectionAttribute'.
        // 
        [EntityAssociation("AssociationCollection", "NonThrowingProperty", "ThrowingProperty")]
        public EntityCollection<AttributeThrowingEntity> ThrowingAssociationCollection
        {
            get
            {
                if ((this._throwingAssociationCollection == null))
                {
                    this._throwingAssociationCollection = new EntityCollection<AttributeThrowingEntity>(this, "ThrowingAssociationCollection", this.FilterThrowingAssociationCollection);
                }
                return this._throwingAssociationCollection;
            }
        }
        
        /// <summary>
        /// Gets or sets the 'ThrowingProperty' value.
        /// </summary>
        // The following attributes were not generated:
        // 
        // - An exception occurred generating the 'ThrowingEntityPropertyAttributeProperty' property on attribute of type 'TestDomainServices.ThrowingEntityPropertyAttribute'.
        // 
        [DataMember()]
        [RoundtripOriginal()]
        public string ThrowingProperty
        {
            get
            {
                return this._throwingProperty;
            }
            set
            {
                if ((this._throwingProperty != value))
                {
                    this.OnThrowingPropertyChanging(value);
                    this.RaiseDataMemberChanging("ThrowingProperty");
                    this.ValidateProperty("ThrowingProperty", value);
                    this._throwingProperty = value;
                    this.RaiseDataMemberChanged("ThrowingProperty");
                    this.OnThrowingPropertyChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the 'UpdateThrowing' action has been invoked on this entity.
        /// </summary>
        [Display(AutoGenerateField=false)]
        public bool IsUpdateThrowingInvoked
        {
            get
            {
                return base.IsActionInvoked("UpdateThrowing");
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the 'UpdateThrowing' method can be invoked on this entity.
        /// </summary>
        [Display(AutoGenerateField=false)]
        public bool CanUpdateThrowing
        {
            get
            {
                return base.CanInvokeAction("UpdateThrowing");
            }
        }
        
        private bool FilterThrowingAssociation(AttributeThrowingEntity entity)
        {
            return (entity.NonThrowingProperty == this.ThrowingProperty);
        }
        
        private bool FilterThrowingAssociationCollection(AttributeThrowingEntity entity)
        {
            return (entity.ThrowingProperty == this.NonThrowingProperty);
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._nonThrowingProperty;
        }
        
        /// <summary>
        /// Invokes the 'UpdateThrowing' action on this entity.
        /// </summary>
        /// <param name="throwingUpdateParam">The value to pass to the server method's 'throwingUpdateParam' parameter.</param>
        // The following attributes were not generated:
        // 
        // - An exception occurred generating the 'ThrowingUpdateMethodProperty' property on attribute of type 'TestDomainServices.ThrowingUpdateMethodAttribute'.
        // 
        // Unable to generate the following attributes for parameter 'throwingUpdateParam' due to the following errors:
        // 
        // - An exception occurred generating the 'ThrowingUpdateMethodParameterProperty' property on attribute of type 'TestDomainServices.ThrowingUpdateMethodParameterAttribute'.
        // 
        [EntityAction("UpdateThrowing", AllowMultipleInvocations=false)]
        public void UpdateThrowing(int throwingUpdateParam)
        {
            this.OnUpdateThrowingInvoking(throwingUpdateParam);
            base.InvokeAction("UpdateThrowing", throwingUpdateParam);
            this.OnUpdateThrowingInvoked();
        }
    }
}
