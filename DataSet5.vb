﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class DataSet5
    Inherits DataSet
    
    Private tableAccount As AccountDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Account")) Is Nothing) Then
                Me.Tables.Add(New AccountDataTable(ds.Tables("Account")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Account As AccountDataTable
        Get
            Return Me.tableAccount
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DataSet5 = CType(MyBase.Clone,DataSet5)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Account")) Is Nothing) Then
            Me.Tables.Add(New AccountDataTable(ds.Tables("Account")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableAccount = CType(Me.Tables("Account"),AccountDataTable)
        If (Not (Me.tableAccount) Is Nothing) Then
            Me.tableAccount.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DataSet5"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DataSet5.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableAccount = New AccountDataTable
        Me.Tables.Add(Me.tableAccount)
    End Sub
    
    Private Function ShouldSerializeAccount() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub AccountRowChangeEventHandler(ByVal sender As Object, ByVal e As AccountRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AccountDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCash As DataColumn
        
        Private columnCashier As DataColumn
        
        Private columnCost As DataColumn
        
        Private columnDateofBill As DataColumn
        
        Private columnID As DataColumn
        
        Private columnTableNo As DataColumn
        
        Private columnTimeofBill As DataColumn
        
        Private columnCashChecked As DataColumn
        
        Friend Sub New()
            MyBase.New("Account")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property CashColumn As DataColumn
            Get
                Return Me.columnCash
            End Get
        End Property
        
        Friend ReadOnly Property CashierColumn As DataColumn
            Get
                Return Me.columnCashier
            End Get
        End Property
        
        Friend ReadOnly Property CostColumn As DataColumn
            Get
                Return Me.columnCost
            End Get
        End Property
        
        Friend ReadOnly Property DateofBillColumn As DataColumn
            Get
                Return Me.columnDateofBill
            End Get
        End Property
        
        Friend ReadOnly Property IDColumn As DataColumn
            Get
                Return Me.columnID
            End Get
        End Property
        
        Friend ReadOnly Property TableNoColumn As DataColumn
            Get
                Return Me.columnTableNo
            End Get
        End Property
        
        Friend ReadOnly Property TimeofBillColumn As DataColumn
            Get
                Return Me.columnTimeofBill
            End Get
        End Property
        
        Friend ReadOnly Property CashCheckedColumn As DataColumn
            Get
                Return Me.columnCashChecked
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As AccountRow
            Get
                Return CType(Me.Rows(index),AccountRow)
            End Get
        End Property
        
        Public Event AccountRowChanged As AccountRowChangeEventHandler
        
        Public Event AccountRowChanging As AccountRowChangeEventHandler
        
        Public Event AccountRowDeleted As AccountRowChangeEventHandler
        
        Public Event AccountRowDeleting As AccountRowChangeEventHandler
        
        Public Overloads Sub AddAccountRow(ByVal row As AccountRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddAccountRow(ByVal Cash As Integer, ByVal Cashier As String, ByVal Cost As Integer, ByVal DateofBill As Date, ByVal TableNo As String, ByVal TimeofBill As String, ByVal CashChecked As Integer) As AccountRow
            Dim rowAccountRow As AccountRow = CType(Me.NewRow,AccountRow)
            rowAccountRow.ItemArray = New Object() {Cash, Cashier, Cost, DateofBill, Nothing, TableNo, TimeofBill, CashChecked}
            Me.Rows.Add(rowAccountRow)
            Return rowAccountRow
        End Function
        
        Public Function FindByID(ByVal ID As Integer) As AccountRow
            Return CType(Me.Rows.Find(New Object() {ID}),AccountRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As AccountDataTable = CType(MyBase.Clone,AccountDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New AccountDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnCash = Me.Columns("Cash")
            Me.columnCashier = Me.Columns("Cashier")
            Me.columnCost = Me.Columns("Cost")
            Me.columnDateofBill = Me.Columns("DateofBill")
            Me.columnID = Me.Columns("ID")
            Me.columnTableNo = Me.Columns("TableNo")
            Me.columnTimeofBill = Me.Columns("TimeofBill")
            Me.columnCashChecked = Me.Columns("CashChecked")
        End Sub
        
        Private Sub InitClass()
            Me.columnCash = New DataColumn("Cash", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCash)
            Me.columnCashier = New DataColumn("Cashier", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCashier)
            Me.columnCost = New DataColumn("Cost", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCost)
            Me.columnDateofBill = New DataColumn("DateofBill", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDateofBill)
            Me.columnID = New DataColumn("ID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnID)
            Me.columnTableNo = New DataColumn("TableNo", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTableNo)
            Me.columnTimeofBill = New DataColumn("TimeofBill", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTimeofBill)
            Me.columnCashChecked = New DataColumn("CashChecked", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCashChecked)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnID}, true))
            Me.columnID.AutoIncrement = true
            Me.columnID.AllowDBNull = false
            Me.columnID.Unique = true
        End Sub
        
        Public Function NewAccountRow() As AccountRow
            Return CType(Me.NewRow,AccountRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New AccountRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(AccountRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.AccountRowChangedEvent) Is Nothing) Then
                RaiseEvent AccountRowChanged(Me, New AccountRowChangeEvent(CType(e.Row,AccountRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.AccountRowChangingEvent) Is Nothing) Then
                RaiseEvent AccountRowChanging(Me, New AccountRowChangeEvent(CType(e.Row,AccountRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.AccountRowDeletedEvent) Is Nothing) Then
                RaiseEvent AccountRowDeleted(Me, New AccountRowChangeEvent(CType(e.Row,AccountRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.AccountRowDeletingEvent) Is Nothing) Then
                RaiseEvent AccountRowDeleting(Me, New AccountRowChangeEvent(CType(e.Row,AccountRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveAccountRow(ByVal row As AccountRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AccountRow
        Inherits DataRow
        
        Private tableAccount As AccountDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableAccount = CType(Me.Table,AccountDataTable)
        End Sub
        
        Public Property Cash As Integer
            Get
                Try 
                    Return CType(Me(Me.tableAccount.CashColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccount.CashColumn) = value
            End Set
        End Property
        
        Public Property Cashier As String
            Get
                Try 
                    Return CType(Me(Me.tableAccount.CashierColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccount.CashierColumn) = value
            End Set
        End Property
        
        Public Property Cost As Integer
            Get
                Try 
                    Return CType(Me(Me.tableAccount.CostColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccount.CostColumn) = value
            End Set
        End Property
        
        Public Property DateofBill As Date
            Get
                Try 
                    Return CType(Me(Me.tableAccount.DateofBillColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccount.DateofBillColumn) = value
            End Set
        End Property
        
        Public Property ID As Integer
            Get
                Return CType(Me(Me.tableAccount.IDColumn),Integer)
            End Get
            Set
                Me(Me.tableAccount.IDColumn) = value
            End Set
        End Property
        
        Public Property TableNo As String
            Get
                Try 
                    Return CType(Me(Me.tableAccount.TableNoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccount.TableNoColumn) = value
            End Set
        End Property
        
        Public Property TimeofBill As String
            Get
                Try 
                    Return CType(Me(Me.tableAccount.TimeofBillColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccount.TimeofBillColumn) = value
            End Set
        End Property
        
        Public Property CashChecked As Integer
            Get
                Try 
                    Return CType(Me(Me.tableAccount.CashCheckedColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccount.CashCheckedColumn) = value
            End Set
        End Property
        
        Public Function IsCashNull() As Boolean
            Return Me.IsNull(Me.tableAccount.CashColumn)
        End Function
        
        Public Sub SetCashNull()
            Me(Me.tableAccount.CashColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCashierNull() As Boolean
            Return Me.IsNull(Me.tableAccount.CashierColumn)
        End Function
        
        Public Sub SetCashierNull()
            Me(Me.tableAccount.CashierColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCostNull() As Boolean
            Return Me.IsNull(Me.tableAccount.CostColumn)
        End Function
        
        Public Sub SetCostNull()
            Me(Me.tableAccount.CostColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDateofBillNull() As Boolean
            Return Me.IsNull(Me.tableAccount.DateofBillColumn)
        End Function
        
        Public Sub SetDateofBillNull()
            Me(Me.tableAccount.DateofBillColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTableNoNull() As Boolean
            Return Me.IsNull(Me.tableAccount.TableNoColumn)
        End Function
        
        Public Sub SetTableNoNull()
            Me(Me.tableAccount.TableNoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTimeofBillNull() As Boolean
            Return Me.IsNull(Me.tableAccount.TimeofBillColumn)
        End Function
        
        Public Sub SetTimeofBillNull()
            Me(Me.tableAccount.TimeofBillColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCashCheckedNull() As Boolean
            Return Me.IsNull(Me.tableAccount.CashCheckedColumn)
        End Function
        
        Public Sub SetCashCheckedNull()
            Me(Me.tableAccount.CashCheckedColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AccountRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As AccountRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As AccountRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As AccountRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
