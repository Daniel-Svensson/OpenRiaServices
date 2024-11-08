//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFCoreModels.Scenarios.OwnedTypes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Threading.Tasks;
    using OpenRiaServices;
    using OpenRiaServices.Client;
    using OpenRiaServices.Client.Authentication;
    
    
    /// <summary>
    /// The 'Address' class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/EFCoreModels.Scenarios.OwnedTypes")]
    public sealed partial class Address : ComplexObject
    {
        
        private string _addressLine;
        
        private string _city;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnAddressLineChanging(string value);
        partial void OnAddressLineChanged();
        partial void OnCityChanging(string value);
        partial void OnCityChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'AddressLine' value.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(100)]
        public string AddressLine
        {
            get
            {
                return this._addressLine;
            }
            set
            {
                if ((this._addressLine != value))
                {
                    this.OnAddressLineChanging(value);
                    this.RaiseDataMemberChanging("AddressLine");
                    this.ValidateProperty("AddressLine", value);
                    this._addressLine = value;
                    this.RaiseDataMemberChanged("AddressLine");
                    this.OnAddressLineChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'City' value.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(50)]
        public string City
        {
            get
            {
                return this._city;
            }
            set
            {
                if ((this._city != value))
                {
                    this.OnCityChanging(value);
                    this.RaiseDataMemberChanging("City");
                    this.ValidateProperty("City", value);
                    this._city = value;
                    this.RaiseDataMemberChanged("City");
                    this.OnCityChanged();
                }
            }
        }
    }
    
    /// <summary>
    /// The 'ContactInfo' class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/EFCoreModels.Scenarios.OwnedTypes")]
    public sealed partial class ContactInfo : ComplexObject
    {
        
        private Address _address;
        
        private string _homePhone;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnAddressChanging(Address value);
        partial void OnAddressChanged();
        partial void OnHomePhoneChanging(string value);
        partial void OnHomePhoneChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactInfo"/> class.
        /// </summary>
        public ContactInfo()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'Address' value.
        /// </summary>
        [DataMember()]
        [Display(AutoGenerateField=false)]
        public Address Address
        {
            get
            {
                return this._address;
            }
            set
            {
                if ((this._address != value))
                {
                    this.OnAddressChanging(value);
                    this.RaiseDataMemberChanging("Address");
                    this.ValidateProperty("Address", value);
                    this._address = value;
                    this.RaiseDataMemberChanged("Address");
                    this.OnAddressChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'HomePhone' value.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(24)]
        public string HomePhone
        {
            get
            {
                return this._homePhone;
            }
            set
            {
                if ((this._homePhone != value))
                {
                    this.OnHomePhoneChanging(value);
                    this.RaiseDataMemberChanging("HomePhone");
                    this.ValidateProperty("HomePhone", value);
                    this._homePhone = value;
                    this.RaiseDataMemberChanged("HomePhone");
                    this.OnHomePhoneChanged();
                }
            }
        }
    }
    
    /// <summary>
    /// The 'Employee' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/EFCoreModels.Scenarios.OwnedTypes")]
    public sealed partial class Employee : Entity
    {
        
        private ContactInfo _contactInfo;
        
        private int _employeeId;
        
        private OwnedEntityWithBackNavigation _ownedEntityWithBackNavigation;
        
        private EntityRef<OwnedEntityWithExplicitId> _ownedEntityWithExplicitId;
        
        private EntityRef<OwnedEntityWithExplicitIdAndBackNavigation> _ownedEntityWithExplicitIdAndBackNavigation;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnContactInfoChanging(ContactInfo value);
        partial void OnContactInfoChanged();
        partial void OnEmployeeIdChanging(int value);
        partial void OnEmployeeIdChanged();
        partial void OnOwnedEntityWithBackNavigationChanging(OwnedEntityWithBackNavigation value);
        partial void OnOwnedEntityWithBackNavigationChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        public Employee()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'ContactInfo' value.
        /// </summary>
        [DataMember()]
        [Display(AutoGenerateField=false)]
        public ContactInfo ContactInfo
        {
            get
            {
                return this._contactInfo;
            }
            set
            {
                if ((this._contactInfo != value))
                {
                    this.OnContactInfoChanging(value);
                    this.RaiseDataMemberChanging("ContactInfo");
                    this.ValidateProperty("ContactInfo", value);
                    this._contactInfo = value;
                    this.RaiseDataMemberChanged("ContactInfo");
                    this.OnContactInfoChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'EmployeeId' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public int EmployeeId
        {
            get
            {
                return this._employeeId;
            }
            set
            {
                if ((this._employeeId != value))
                {
                    this.OnEmployeeIdChanging(value);
                    this.ValidateProperty("EmployeeId", value);
                    this._employeeId = value;
                    this.RaisePropertyChanged("EmployeeId");
                    this.OnEmployeeIdChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'OwnedEntityWithBackNavigation' value.
        /// </summary>
        [DataMember()]
        [Display(AutoGenerateField=false)]
        public OwnedEntityWithBackNavigation OwnedEntityWithBackNavigation
        {
            get
            {
                return this._ownedEntityWithBackNavigation;
            }
            set
            {
                if ((this._ownedEntityWithBackNavigation != value))
                {
                    this.OnOwnedEntityWithBackNavigationChanging(value);
                    this.RaiseDataMemberChanging("OwnedEntityWithBackNavigation");
                    this.ValidateProperty("OwnedEntityWithBackNavigation", value);
                    this._ownedEntityWithBackNavigation = value;
                    this.RaiseDataMemberChanged("OwnedEntityWithBackNavigation");
                    this.OnOwnedEntityWithBackNavigationChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the associated <see cref="OwnedEntityWithExplicitId"/> entity.
        /// </summary>
        [Composition()]
        [EntityAssociation("FK_Employees_Employees_EmployeeId|owns:OwnedEntityWithExplicitId", "EmployeeId", "EmployeeId")]
        public OwnedEntityWithExplicitId OwnedEntityWithExplicitId
        {
            get
            {
                if ((this._ownedEntityWithExplicitId == null))
                {
                    this._ownedEntityWithExplicitId = new EntityRef<OwnedEntityWithExplicitId>(this, "OwnedEntityWithExplicitId", this.FilterOwnedEntityWithExplicitId);
                }
                return this._ownedEntityWithExplicitId.Entity;
            }
            set
            {
                OwnedEntityWithExplicitId previous = this.OwnedEntityWithExplicitId;
                if ((previous != value))
                {
                    this.ValidateProperty("OwnedEntityWithExplicitId", value);
                    this._ownedEntityWithExplicitId.Entity = value;
                    this.RaisePropertyChanged("OwnedEntityWithExplicitId");
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the associated <see cref="OwnedEntityWithExplicitIdAndBackNavigation"/> entity.
        /// </summary>
        [Composition()]
        [EntityAssociation("FK_Employees_Employees_EmployeeId|owns:OwnedEntityWithExplicitIdAndBackNavigation" +
            "", "EmployeeId", "EmployeeId")]
        public OwnedEntityWithExplicitIdAndBackNavigation OwnedEntityWithExplicitIdAndBackNavigation
        {
            get
            {
                if ((this._ownedEntityWithExplicitIdAndBackNavigation == null))
                {
                    this._ownedEntityWithExplicitIdAndBackNavigation = new EntityRef<OwnedEntityWithExplicitIdAndBackNavigation>(this, "OwnedEntityWithExplicitIdAndBackNavigation", this.FilterOwnedEntityWithExplicitIdAndBackNavigation);
                }
                return this._ownedEntityWithExplicitIdAndBackNavigation.Entity;
            }
            set
            {
                OwnedEntityWithExplicitIdAndBackNavigation previous = this.OwnedEntityWithExplicitIdAndBackNavigation;
                if ((previous != value))
                {
                    this.ValidateProperty("OwnedEntityWithExplicitIdAndBackNavigation", value);
                    this._ownedEntityWithExplicitIdAndBackNavigation.Entity = value;
                    this.RaisePropertyChanged("OwnedEntityWithExplicitIdAndBackNavigation");
                }
            }
        }
        
        private bool FilterOwnedEntityWithExplicitId(OwnedEntityWithExplicitId entity)
        {
            return (entity.EmployeeId == this.EmployeeId);
        }
        
        private bool FilterOwnedEntityWithExplicitIdAndBackNavigation(OwnedEntityWithExplicitIdAndBackNavigation entity)
        {
            return (entity.EmployeeId == this.EmployeeId);
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._employeeId;
        }
    }
    
    /// <summary>
    /// The 'OwnedEntityWithBackNavigation' class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/EFCoreModels.Scenarios.OwnedTypes")]
    public sealed partial class OwnedEntityWithBackNavigation : ComplexObject
    {
        
        private string _description;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="OwnedEntityWithBackNavigation"/> class.
        /// </summary>
        public OwnedEntityWithBackNavigation()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'Description' value.
        /// </summary>
        [DataMember()]
        [Required()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((this._description != value))
                {
                    this.OnDescriptionChanging(value);
                    this.RaiseDataMemberChanging("Description");
                    this.ValidateProperty("Description", value);
                    this._description = value;
                    this.RaiseDataMemberChanged("Description");
                    this.OnDescriptionChanged();
                }
            }
        }
    }
    
    /// <summary>
    /// The 'OwnedEntityWithExplicitId' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/EFCoreModels.Scenarios.OwnedTypes")]
    public sealed partial class OwnedEntityWithExplicitId : Entity
    {
        
        private string _description;
        
        private int _employeeId;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        partial void OnEmployeeIdChanging(int value);
        partial void OnEmployeeIdChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="OwnedEntityWithExplicitId"/> class.
        /// </summary>
        public OwnedEntityWithExplicitId()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'Description' value.
        /// </summary>
        [DataMember()]
        [Required()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((this._description != value))
                {
                    this.OnDescriptionChanging(value);
                    this.RaiseDataMemberChanging("Description");
                    this.ValidateProperty("Description", value);
                    this._description = value;
                    this.RaiseDataMemberChanged("Description");
                    this.OnDescriptionChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'EmployeeId' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public int EmployeeId
        {
            get
            {
                return this._employeeId;
            }
            set
            {
                if ((this._employeeId != value))
                {
                    this.OnEmployeeIdChanging(value);
                    this.ValidateProperty("EmployeeId", value);
                    this._employeeId = value;
                    this.RaisePropertyChanged("EmployeeId");
                    this.OnEmployeeIdChanged();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._employeeId;
        }
    }
    
    /// <summary>
    /// The 'OwnedEntityWithExplicitIdAndBackNavigation' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/EFCoreModels.Scenarios.OwnedTypes")]
    public sealed partial class OwnedEntityWithExplicitIdAndBackNavigation : Entity
    {
        
        private string _description;
        
        private EntityRef<Employee> _employee;
        
        private int _employeeId;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        partial void OnEmployeeIdChanging(int value);
        partial void OnEmployeeIdChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="OwnedEntityWithExplicitIdAndBackNavigation"/> class.
        /// </summary>
        public OwnedEntityWithExplicitIdAndBackNavigation()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'Description' value.
        /// </summary>
        [DataMember()]
        [Required()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((this._description != value))
                {
                    this.OnDescriptionChanging(value);
                    this.RaiseDataMemberChanging("Description");
                    this.ValidateProperty("Description", value);
                    this._description = value;
                    this.RaiseDataMemberChanged("Description");
                    this.OnDescriptionChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the associated <see cref="Employee"/> entity.
        /// </summary>
        [EntityAssociation("FK_Employees_Employees_EmployeeId", "EmployeeId", "EmployeeId", IsForeignKey=true)]
        public Employee Employee
        {
            get
            {
                if ((this._employee == null))
                {
                    this._employee = new EntityRef<Employee>(this, "Employee", this.FilterEmployee);
                }
                return this._employee.Entity;
            }
            set
            {
                Employee previous = this.Employee;
                if ((previous != value))
                {
                    this.ValidateProperty("Employee", value);
                    if ((value != null))
                    {
                        this.EmployeeId = value.EmployeeId;
                    }
                    else
                    {
                        this.EmployeeId = default(int);
                    }
                    this._employee.Entity = value;
                    this.RaisePropertyChanged("Employee");
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'EmployeeId' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public int EmployeeId
        {
            get
            {
                return this._employeeId;
            }
            set
            {
                if ((this._employeeId != value))
                {
                    this.OnEmployeeIdChanging(value);
                    this.ValidateProperty("EmployeeId", value);
                    this._employeeId = value;
                    this.RaisePropertyChanged("EmployeeId");
                    this.OnEmployeeIdChanged();
                }
            }
        }
        
        private bool FilterEmployee(Employee entity)
        {
            return (entity.EmployeeId == this.EmployeeId);
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._employeeId;
        }
    }
}
namespace OpenRiaServices.Tools.Test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel;
    using System.Threading.Tasks;
    using EFCoreModels.Scenarios.OwnedTypes;
    using OpenRiaServices;
    using OpenRiaServices.Client;
    using OpenRiaServices.Client.Authentication;
    
    
    /// <summary>
    /// The DomainContext corresponding to the 'EFCoreComplexTypesService' DomainService.
    /// </summary>
    public sealed partial class EFCoreComplexTypesContext : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EFCoreComplexTypesContext"/> class.
        /// </summary>
        public EFCoreComplexTypesContext() : 
                this(new Uri("OpenRiaServices-Tools-Test-EFCoreComplexTypesService.svc", UriKind.Relative))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EFCoreComplexTypesContext"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The EFCoreComplexTypesService service URI.</param>
        public EFCoreComplexTypesContext(Uri serviceUri) : 
                this(DomainContext.CreateDomainClient(typeof(IEFCoreComplexTypesServiceContract), serviceUri, false))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EFCoreComplexTypesContext"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public EFCoreComplexTypesContext(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="Employee"/> entity instances that have been loaded into this <see cref="EFCoreComplexTypesContext"/> instance.
        /// </summary>
        public EntitySet<Employee> Employees
        {
            get
            {
                return base.EntityContainer.GetEntitySet<Employee>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="Employee"/> entity instances using the 'GetCustomers' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="Employee"/> entity instances.</returns>
        public EntityQuery<Employee> GetCustomersQuery()
        {
            this.ValidateMethod("GetCustomersQuery", null);
            return base.CreateQuery<Employee>("GetCustomers", null, false, true);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new EFCoreComplexTypesContextEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'EFCoreComplexTypesService' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface IEFCoreComplexTypesServiceContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetCustomers' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(false)]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/EFCoreComplexTypesService/GetCustomers", ReplyAction="http://tempuri.org/EFCoreComplexTypesService/GetCustomersResponse")]
            IAsyncResult BeginGetCustomers(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetCustomers'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetCustomers'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetCustomers' operation.</returns>
            QueryResult<Employee> EndGetCustomers(IAsyncResult result);
        }
        
        internal sealed class EFCoreComplexTypesContextEntityContainer : EntityContainer
        {
            
            public EFCoreComplexTypesContextEntityContainer()
            {
                this.CreateEntitySet<Employee>(EntitySetOperations.None);
                this.CreateEntitySet<OwnedEntityWithExplicitId>(EntitySetOperations.None);
                this.CreateEntitySet<OwnedEntityWithExplicitIdAndBackNavigation>(EntitySetOperations.None);
            }
        }
    }
}