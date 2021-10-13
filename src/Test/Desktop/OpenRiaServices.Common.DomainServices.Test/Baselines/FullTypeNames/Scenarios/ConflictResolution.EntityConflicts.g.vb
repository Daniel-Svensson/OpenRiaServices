'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Compare Binary
Option Infer On
Option Strict On
Option Explicit On


Namespace TestDomainServices.TypeNameConflictResolution
    
    ''' <summary>
    ''' The DomainContext corresponding to the 'BaseTypeConflicts' DomainService.
    ''' </summary>
    Partial Public NotInheritable Class BaseTypeConflicts
        Inherits Global.OpenRiaServices.Client.DomainContext
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="BaseTypeConflicts"/> class.
        ''' </summary>
        Public Sub New()
            Me.New(New Global.System.Uri("TestDomainServices-TypeNameConflictResolution-BaseTypeConflicts.svc", Global.System.UriKind.Relative))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="BaseTypeConflicts"/> class with the specified service URI.
        ''' </summary>
        ''' <param name="serviceUri">The BaseTypeConflicts service URI.</param>
        Public Sub New(ByVal serviceUri As Global.System.Uri)
            Me.New(Global.OpenRiaServices.Client.DomainContext.CreateDomainClient(GetType(Global.TestDomainServices.TypeNameConflictResolution.BaseTypeConflicts.IBaseTypeConflictsContract), serviceUri, false))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="BaseTypeConflicts"/> class with the specified <paramref name="domainClient"/>.
        ''' </summary>
        ''' <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        Public Sub New(ByVal domainClient As Global.OpenRiaServices.Client.DomainClient)
            MyBase.New(domainClient)
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets the set of <see cref="DomainContext"/> entity instances that have been loaded into this <see cref="BaseTypeConflicts"/> instance.
        ''' </summary>
        Public ReadOnly Property DomainContexts() As Global.OpenRiaServices.Client.EntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.DomainContext)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.DomainContext)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the set of <see cref="Entity"/> entity instances that have been loaded into this <see cref="BaseTypeConflicts"/> instance.
        ''' </summary>
        Public ReadOnly Property Entities() As Global.OpenRiaServices.Client.EntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.Entity)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.Entity)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="DomainContext"/> entity instances using the 'GetDataContexts' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="DomainContext"/> entity instances.</returns>
        Public Function GetDataContextsQuery() As Global.OpenRiaServices.Client.EntityQuery(Of Global.TestDomainServices.TypeNameConflictResolution.DomainContext)
            Me.ValidateMethod("GetDataContextsQuery", Nothing)
            Return MyBase.CreateQuery(Of Global.TestDomainServices.TypeNameConflictResolution.DomainContext)("GetDataContexts", Nothing, false, true)
        End Function
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="Entity"/> entity instances using the 'GetEntities' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="Entity"/> entity instances.</returns>
        Public Function GetEntitiesQuery() As Global.OpenRiaServices.Client.EntityQuery(Of Global.TestDomainServices.TypeNameConflictResolution.Entity)
            Me.ValidateMethod("GetEntitiesQuery", Nothing)
            Return MyBase.CreateQuery(Of Global.TestDomainServices.TypeNameConflictResolution.Entity)("GetEntities", Nothing, false, true)
        End Function
        
        ''' <summary>
        ''' Creates a new EntityContainer for this DomainContext's EntitySets.
        ''' </summary>
        ''' <returns>A new container instance.</returns>
        Protected Overrides Function CreateEntityContainer() As Global.OpenRiaServices.Client.EntityContainer
            Return New Global.TestDomainServices.TypeNameConflictResolution.BaseTypeConflicts.BaseTypeConflictsEntityContainer()
        End Function
        
        ''' <summary>
        ''' Service contract for the 'BaseTypeConflicts' DomainService.
        ''' </summary>
        <Global.System.ServiceModel.ServiceContractAttribute()>  _
        Public Interface IBaseTypeConflictsContract
            
            ''' <summary>
            ''' Asynchronously invokes the 'GetDataContexts' operation.
            ''' </summary>
            ''' <returns>The 'QueryResult' returned from the 'GetDataContexts' operation.</returns>
            <Global.OpenRiaServices.Client.HasSideEffects(false),  _
             Global.System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/BaseTypeConflicts/GetDataContexts", ReplyAction:="http://tempuri.org/BaseTypeConflicts/GetDataContextsResponse")>  _
            Function GetDataContexts() As Global.System.Threading.Tasks.Task(Of Global.OpenRiaServices.Client.QueryResult(Of Global.TestDomainServices.TypeNameConflictResolution.DomainContext))
            
            ''' <summary>
            ''' Asynchronously invokes the 'GetEntities' operation.
            ''' </summary>
            ''' <returns>The 'QueryResult' returned from the 'GetEntities' operation.</returns>
            <Global.OpenRiaServices.Client.HasSideEffects(false),  _
             Global.System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/BaseTypeConflicts/GetEntities", ReplyAction:="http://tempuri.org/BaseTypeConflicts/GetEntitiesResponse")>  _
            Function GetEntities() As Global.System.Threading.Tasks.Task(Of Global.OpenRiaServices.Client.QueryResult(Of Global.TestDomainServices.TypeNameConflictResolution.Entity))
        End Interface
        
        Friend NotInheritable Class BaseTypeConflictsEntityContainer
            Inherits Global.OpenRiaServices.Client.EntityContainer
            
            Public Sub New()
                MyBase.New
                Me.CreateEntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.DomainContext)(Global.OpenRiaServices.Client.EntitySetOperations.None)
                Me.CreateEntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.Entity)(Global.OpenRiaServices.Client.EntitySetOperations.None)
            End Sub
        End Class
    End Class
    
    ''' <summary>
    ''' The 'DomainContext' entity class.
    ''' </summary>
    <Global.System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/TestDomainServices.TypeNameConflictResolu"& _ 
        "tion")>  _
    Partial Public NotInheritable Class DomainContext
        Inherits Global.OpenRiaServices.Client.Entity
        
        Private _dataContextID As Integer
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub
        Private Partial Sub OnDataContextIDChanging(ByVal value As Integer)
        End Sub
        Private Partial Sub OnDataContextIDChanged()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="DomainContext"/> class.
        ''' </summary>
        Public Sub New()
            MyBase.New
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets or sets the 'DataContextID' value.
        ''' </summary>
        <Global.System.ComponentModel.DataAnnotations.EditableAttribute(false, AllowInitialValue:=true),  _
         Global.System.ComponentModel.DataAnnotations.KeyAttribute(),  _
         Global.System.ComponentModel.DataAnnotations.RoundtripOriginalAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property DataContextID() As Integer
            Get
                Return Me._dataContextID
            End Get
            Set
                If ((Me._dataContextID = value)  _
                            = false) Then
                    Me.OnDataContextIDChanging(value)
                    Me.ValidateProperty("DataContextID", value)
                    Me._dataContextID = value
                    Me.RaisePropertyChanged("DataContextID")
                    Me.OnDataContextIDChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._dataContextID
        End Function
    End Class
    
    ''' <summary>
    ''' The 'Entity' entity class.
    ''' </summary>
    <Global.System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/TestDomainServices.TypeNameConflictResolu"& _ 
        "tion")>  _
    Partial Public NotInheritable Class Entity
        Inherits Global.OpenRiaServices.Client.Entity
        
        Private _name As String
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub
        Private Partial Sub OnNameChanging(ByVal value As String)
        End Sub
        Private Partial Sub OnNameChanged()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="Entity"/> class.
        ''' </summary>
        Public Sub New()
            MyBase.New
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets or sets the 'Name' value.
        ''' </summary>
        <Global.System.ComponentModel.DataAnnotations.EditableAttribute(false, AllowInitialValue:=true),  _
         Global.System.ComponentModel.DataAnnotations.KeyAttribute(),  _
         Global.System.ComponentModel.DataAnnotations.RoundtripOriginalAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Name() As String
            Get
                Return Me._name
            End Get
            Set
                If (String.Equals(Me._name, value) = false) Then
                    Me.OnNameChanging(value)
                    Me.ValidateProperty("Name", value)
                    Me._name = value
                    Me.RaisePropertyChanged("Name")
                    Me.OnNameChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._name
        End Function
    End Class
End Namespace

Namespace TestDomainServices.TypeNameConflictResolution.ExternalConflicts
    
    ''' <summary>
    ''' The DomainContext corresponding to the 'DomainServiceScenario1' DomainService.
    ''' </summary>
    Partial Public NotInheritable Class DomainServiceScenario1
        Inherits Global.OpenRiaServices.Client.DomainContext
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="DomainServiceScenario1"/> class.
        ''' </summary>
        Public Sub New()
            Me.New(New Global.System.Uri("TestDomainServices-TypeNameConflictResolution-ExternalConflicts-DomainServiceScen"& _ 
                        "ario1.svc", Global.System.UriKind.Relative))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="DomainServiceScenario1"/> class with the specified service URI.
        ''' </summary>
        ''' <param name="serviceUri">The DomainServiceScenario1 service URI.</param>
        Public Sub New(ByVal serviceUri As Global.System.Uri)
            Me.New(Global.OpenRiaServices.Client.DomainContext.CreateDomainClient(GetType(Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.DomainServiceScenario1.IDomainServiceScenario1Contract), serviceUri, false))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="DomainServiceScenario1"/> class with the specified <paramref name="domainClient"/>.
        ''' </summary>
        ''' <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        Public Sub New(ByVal domainClient As Global.OpenRiaServices.Client.DomainClient)
            MyBase.New(domainClient)
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets the set of <see cref="MockEntity1"/> entity instances that have been loaded into this <see cref="DomainServiceScenario1"/> instance.
        ''' </summary>
        Public ReadOnly Property MockEntity1s() As Global.OpenRiaServices.Client.EntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1.MockEntity1)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1.MockEntity1)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the set of <see cref="MockEntity2"/> entity instances that have been loaded into this <see cref="DomainServiceScenario1"/> instance.
        ''' </summary>
        Public ReadOnly Property MockEntity2s() As Global.OpenRiaServices.Client.EntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity2)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity2)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="MockEntity1"/> entity instances using the 'GetTEntity1' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="MockEntity1"/> entity instances.</returns>
        Public Function GetTEntity1Query() As Global.OpenRiaServices.Client.EntityQuery(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1.MockEntity1)
            Me.ValidateMethod("GetTEntity1Query", Nothing)
            Return MyBase.CreateQuery(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1.MockEntity1)("GetTEntity1", Nothing, false, true)
        End Function
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="MockEntity2"/> entity instances using the 'GetTEntity2' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="MockEntity2"/> entity instances.</returns>
        Public Function GetTEntity2Query() As Global.OpenRiaServices.Client.EntityQuery(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity2)
            Me.ValidateMethod("GetTEntity2Query", Nothing)
            Return MyBase.CreateQuery(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity2)("GetTEntity2", Nothing, false, true)
        End Function
        
        ''' <summary>
        ''' Creates a new EntityContainer for this DomainContext's EntitySets.
        ''' </summary>
        ''' <returns>A new container instance.</returns>
        Protected Overrides Function CreateEntityContainer() As Global.OpenRiaServices.Client.EntityContainer
            Return New Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.DomainServiceScenario1.DomainServiceScenario1EntityContainer()
        End Function
        
        ''' <summary>
        ''' Service contract for the 'DomainServiceScenario1' DomainService.
        ''' </summary>
        <Global.System.ServiceModel.ServiceContractAttribute()>  _
        Public Interface IDomainServiceScenario1Contract
            
            ''' <summary>
            ''' Asynchronously invokes the 'GetTEntity1' operation.
            ''' </summary>
            ''' <returns>The 'QueryResult' returned from the 'GetTEntity1' operation.</returns>
            <Global.OpenRiaServices.Client.HasSideEffects(false),  _
             Global.System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/DomainServiceScenario1/GetTEntity1", ReplyAction:="http://tempuri.org/DomainServiceScenario1/GetTEntity1Response")>  _
            Function GetTEntity1() As Global.System.Threading.Tasks.Task(Of Global.OpenRiaServices.Client.QueryResult(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1.MockEntity1))
            
            ''' <summary>
            ''' Asynchronously invokes the 'GetTEntity2' operation.
            ''' </summary>
            ''' <returns>The 'QueryResult' returned from the 'GetTEntity2' operation.</returns>
            <Global.OpenRiaServices.Client.HasSideEffects(false),  _
             Global.System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/DomainServiceScenario1/GetTEntity2", ReplyAction:="http://tempuri.org/DomainServiceScenario1/GetTEntity2Response")>  _
            Function GetTEntity2() As Global.System.Threading.Tasks.Task(Of Global.OpenRiaServices.Client.QueryResult(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity2))
        End Interface
        
        Friend NotInheritable Class DomainServiceScenario1EntityContainer
            Inherits Global.OpenRiaServices.Client.EntityContainer
            
            Public Sub New()
                MyBase.New
                Me.CreateEntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1.MockEntity1)(Global.OpenRiaServices.Client.EntitySetOperations.None)
                Me.CreateEntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity2)(Global.OpenRiaServices.Client.EntitySetOperations.None)
            End Sub
        End Class
    End Class
    
    ''' <summary>
    ''' The DomainContext corresponding to the 'DomainServiceScenario2' DomainService.
    ''' </summary>
    Partial Public NotInheritable Class DomainServiceScenario2
        Inherits Global.OpenRiaServices.Client.DomainContext
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="DomainServiceScenario2"/> class.
        ''' </summary>
        Public Sub New()
            Me.New(New Global.System.Uri("TestDomainServices-TypeNameConflictResolution-ExternalConflicts-DomainServiceScen"& _ 
                        "ario2.svc", Global.System.UriKind.Relative))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="DomainServiceScenario2"/> class with the specified service URI.
        ''' </summary>
        ''' <param name="serviceUri">The DomainServiceScenario2 service URI.</param>
        Public Sub New(ByVal serviceUri As Global.System.Uri)
            Me.New(Global.OpenRiaServices.Client.DomainContext.CreateDomainClient(GetType(Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.DomainServiceScenario2.IDomainServiceScenario2Contract), serviceUri, false))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="DomainServiceScenario2"/> class with the specified <paramref name="domainClient"/>.
        ''' </summary>
        ''' <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        Public Sub New(ByVal domainClient As Global.OpenRiaServices.Client.DomainClient)
            MyBase.New(domainClient)
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets the set of <see cref="MockEntity1"/> entity instances that have been loaded into this <see cref="DomainServiceScenario2"/> instance.
        ''' </summary>
        Public ReadOnly Property MockEntity1s() As Global.OpenRiaServices.Client.EntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity1)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity1)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the set of <see cref="MockEntity2"/> entity instances that have been loaded into this <see cref="DomainServiceScenario2"/> instance.
        ''' </summary>
        Public ReadOnly Property MockEntity2s() As Global.OpenRiaServices.Client.EntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1.MockEntity2)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1.MockEntity2)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="MockEntity1"/> entity instances using the 'GetTEntity1' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="MockEntity1"/> entity instances.</returns>
        Public Function GetTEntity1Query() As Global.OpenRiaServices.Client.EntityQuery(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity1)
            Me.ValidateMethod("GetTEntity1Query", Nothing)
            Return MyBase.CreateQuery(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity1)("GetTEntity1", Nothing, false, true)
        End Function
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="MockEntity2"/> entity instances using the 'GetTEntity2' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="MockEntity2"/> entity instances.</returns>
        Public Function GetTEntity2Query() As Global.OpenRiaServices.Client.EntityQuery(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1.MockEntity2)
            Me.ValidateMethod("GetTEntity2Query", Nothing)
            Return MyBase.CreateQuery(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1.MockEntity2)("GetTEntity2", Nothing, false, true)
        End Function
        
        ''' <summary>
        ''' Creates a new EntityContainer for this DomainContext's EntitySets.
        ''' </summary>
        ''' <returns>A new container instance.</returns>
        Protected Overrides Function CreateEntityContainer() As Global.OpenRiaServices.Client.EntityContainer
            Return New Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.DomainServiceScenario2.DomainServiceScenario2EntityContainer()
        End Function
        
        ''' <summary>
        ''' Service contract for the 'DomainServiceScenario2' DomainService.
        ''' </summary>
        <Global.System.ServiceModel.ServiceContractAttribute()>  _
        Public Interface IDomainServiceScenario2Contract
            
            ''' <summary>
            ''' Asynchronously invokes the 'GetTEntity1' operation.
            ''' </summary>
            ''' <returns>The 'QueryResult' returned from the 'GetTEntity1' operation.</returns>
            <Global.OpenRiaServices.Client.HasSideEffects(false),  _
             Global.System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/DomainServiceScenario2/GetTEntity1", ReplyAction:="http://tempuri.org/DomainServiceScenario2/GetTEntity1Response")>  _
            Function GetTEntity1() As Global.System.Threading.Tasks.Task(Of Global.OpenRiaServices.Client.QueryResult(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity1))
            
            ''' <summary>
            ''' Asynchronously invokes the 'GetTEntity2' operation.
            ''' </summary>
            ''' <returns>The 'QueryResult' returned from the 'GetTEntity2' operation.</returns>
            <Global.OpenRiaServices.Client.HasSideEffects(false),  _
             Global.System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/DomainServiceScenario2/GetTEntity2", ReplyAction:="http://tempuri.org/DomainServiceScenario2/GetTEntity2Response")>  _
            Function GetTEntity2() As Global.System.Threading.Tasks.Task(Of Global.OpenRiaServices.Client.QueryResult(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1.MockEntity2))
        End Interface
        
        Friend NotInheritable Class DomainServiceScenario2EntityContainer
            Inherits Global.OpenRiaServices.Client.EntityContainer
            
            Public Sub New()
                MyBase.New
                Me.CreateEntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1.MockEntity2)(Global.OpenRiaServices.Client.EntitySetOperations.None)
                Me.CreateEntitySet(Of Global.TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2.MockEntity1)(Global.OpenRiaServices.Client.EntitySetOperations.None)
            End Sub
        End Class
    End Class
End Namespace

Namespace TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace1
    
    ''' <summary>
    ''' The 'MockEntity1' entity class.
    ''' </summary>
    <Global.System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/TestDomainServices.TypeNameConflictResolu"& _ 
        "tion.ExternalConflicts.Namespace1")>  _
    Partial Public NotInheritable Class MockEntity1
        Inherits Global.OpenRiaServices.Client.Entity
        
        Private _entityID As Integer
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub
        Private Partial Sub OnEntityIDChanging(ByVal value As Integer)
        End Sub
        Private Partial Sub OnEntityIDChanged()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="MockEntity1"/> class.
        ''' </summary>
        Public Sub New()
            MyBase.New
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets or sets the 'EntityID' value.
        ''' </summary>
        <Global.System.ComponentModel.DataAnnotations.EditableAttribute(false, AllowInitialValue:=true),  _
         Global.System.ComponentModel.DataAnnotations.KeyAttribute(),  _
         Global.System.ComponentModel.DataAnnotations.RoundtripOriginalAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property EntityID() As Integer
            Get
                Return Me._entityID
            End Get
            Set
                If ((Me._entityID = value)  _
                            = false) Then
                    Me.OnEntityIDChanging(value)
                    Me.ValidateProperty("EntityID", value)
                    Me._entityID = value
                    Me.RaisePropertyChanged("EntityID")
                    Me.OnEntityIDChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._entityID
        End Function
    End Class
    
    ''' <summary>
    ''' The 'MockEntity2' entity class.
    ''' </summary>
    <Global.System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/TestDomainServices.TypeNameConflictResolu"& _ 
        "tion.ExternalConflicts.Namespace1")>  _
    Partial Public NotInheritable Class MockEntity2
        Inherits Global.OpenRiaServices.Client.Entity
        
        Private _entityID As Integer
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub
        Private Partial Sub OnEntityIDChanging(ByVal value As Integer)
        End Sub
        Private Partial Sub OnEntityIDChanged()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="MockEntity2"/> class.
        ''' </summary>
        Public Sub New()
            MyBase.New
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets or sets the 'EntityID' value.
        ''' </summary>
        <Global.System.ComponentModel.DataAnnotations.EditableAttribute(false, AllowInitialValue:=true),  _
         Global.System.ComponentModel.DataAnnotations.KeyAttribute(),  _
         Global.System.ComponentModel.DataAnnotations.RoundtripOriginalAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property EntityID() As Integer
            Get
                Return Me._entityID
            End Get
            Set
                If ((Me._entityID = value)  _
                            = false) Then
                    Me.OnEntityIDChanging(value)
                    Me.ValidateProperty("EntityID", value)
                    Me._entityID = value
                    Me.RaisePropertyChanged("EntityID")
                    Me.OnEntityIDChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._entityID
        End Function
    End Class
End Namespace

Namespace TestDomainServices.TypeNameConflictResolution.ExternalConflicts.Namespace2
    
    ''' <summary>
    ''' The 'MockEntity1' entity class.
    ''' </summary>
    <Global.System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/TestDomainServices.TypeNameConflictResolu"& _ 
        "tion.ExternalConflicts.Namespace2")>  _
    Partial Public NotInheritable Class MockEntity1
        Inherits Global.OpenRiaServices.Client.Entity
        
        Private _entityID As Integer
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub
        Private Partial Sub OnEntityIDChanging(ByVal value As Integer)
        End Sub
        Private Partial Sub OnEntityIDChanged()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="MockEntity1"/> class.
        ''' </summary>
        Public Sub New()
            MyBase.New
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets or sets the 'EntityID' value.
        ''' </summary>
        <Global.System.ComponentModel.DataAnnotations.EditableAttribute(false, AllowInitialValue:=true),  _
         Global.System.ComponentModel.DataAnnotations.KeyAttribute(),  _
         Global.System.ComponentModel.DataAnnotations.RoundtripOriginalAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property EntityID() As Integer
            Get
                Return Me._entityID
            End Get
            Set
                If ((Me._entityID = value)  _
                            = false) Then
                    Me.OnEntityIDChanging(value)
                    Me.ValidateProperty("EntityID", value)
                    Me._entityID = value
                    Me.RaisePropertyChanged("EntityID")
                    Me.OnEntityIDChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._entityID
        End Function
    End Class
    
    ''' <summary>
    ''' The 'MockEntity2' entity class.
    ''' </summary>
    <Global.System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/TestDomainServices.TypeNameConflictResolu"& _ 
        "tion.ExternalConflicts.Namespace2")>  _
    Partial Public NotInheritable Class MockEntity2
        Inherits Global.OpenRiaServices.Client.Entity
        
        Private _entityID As Integer
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub
        Private Partial Sub OnEntityIDChanging(ByVal value As Integer)
        End Sub
        Private Partial Sub OnEntityIDChanged()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="MockEntity2"/> class.
        ''' </summary>
        Public Sub New()
            MyBase.New
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets or sets the 'EntityID' value.
        ''' </summary>
        <Global.System.ComponentModel.DataAnnotations.EditableAttribute(false, AllowInitialValue:=true),  _
         Global.System.ComponentModel.DataAnnotations.KeyAttribute(),  _
         Global.System.ComponentModel.DataAnnotations.RoundtripOriginalAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property EntityID() As Integer
            Get
                Return Me._entityID
            End Get
            Set
                If ((Me._entityID = value)  _
                            = false) Then
                    Me.OnEntityIDChanging(value)
                    Me.ValidateProperty("EntityID", value)
                    Me._entityID = value
                    Me.RaisePropertyChanged("EntityID")
                    Me.OnEntityIDChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._entityID
        End Function
    End Class
End Namespace
