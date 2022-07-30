Public Class Accounts
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSet51 As WindowsApplication1.DataSet5
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents OleDbCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet61 As WindowsApplication1.DataSet6
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents OleDbCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Cost As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents OleDbCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OleDbCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand6 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand7 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Profit As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents OleDbDataAdapter3 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DataSet71 As WindowsApplication1.DataSet7
    Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DataSet81 As WindowsApplication1.DataSet8
    Friend WithEvents OleDbCommand8 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand9 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand10 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand11 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter4 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DataSet91 As WindowsApplication1.DataSet9
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGrid4 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DataSet51 = New WindowsApplication1.DataSet5
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Total = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.OleDbCommand2 = New System.Data.OleDb.OleDbCommand
        Me.Button1 = New System.Windows.Forms.Button
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.DataSet61 = New WindowsApplication1.DataSet6
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.OleDbCommand3 = New System.Data.OleDb.OleDbCommand
        Me.Cost = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.OleDbCommand4 = New System.Data.OleDb.OleDbCommand
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.OleDbCommand5 = New System.Data.OleDb.OleDbCommand
        Me.OleDbCommand6 = New System.Data.OleDb.OleDbCommand
        Me.OleDbCommand7 = New System.Data.OleDb.OleDbCommand
        Me.Profit = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.OleDbDataAdapter3 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.DataSet71 = New WindowsApplication1.DataSet7
        Me.DataGrid3 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataSet81 = New WindowsApplication1.DataSet8
        Me.OleDbCommand8 = New System.Data.OleDb.OleDbCommand
        Me.OleDbCommand9 = New System.Data.OleDb.OleDbCommand
        Me.OleDbCommand10 = New System.Data.OleDb.OleDbCommand
        Me.OleDbCommand11 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter4 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        Me.DataSet91 = New WindowsApplication1.DataSet9
        Me.Button3 = New System.Windows.Forms.Button
        Me.DataGrid4 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.DataSet51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cash", "Cash"), New System.Data.Common.DataColumnMapping("Cashier", "Cashier"), New System.Data.Common.DataColumnMapping("Cost", "Cost"), New System.Data.Common.DataColumnMapping("DateofBill", "DateofBill"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("TableNo", "TableNo"), New System.Data.Common.DataColumnMapping("TimeofBill", "TimeofBill"), New System.Data.Common.DataColumnMapping("CashChecked", "CashChecked")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Account WHERE (ID = ?) AND (Cash = ? OR ? IS NULL AND Cash IS NULL) A" & _
        "ND (CashChecked = ? OR ? IS NULL AND CashChecked IS NULL) AND (Cashier = ? OR ? " & _
        "IS NULL AND Cashier IS NULL) AND (Cost = ? OR ? IS NULL AND Cost IS NULL) AND (D" & _
        "ateofBill = ? OR ? IS NULL AND DateofBill IS NULL) AND (TableNo = ? OR ? IS NULL" & _
        " AND TableNo IS NULL) AND (TimeofBill = ? OR ? IS NULL AND TimeofBill IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cash", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cash", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cash1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cash", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CashChecked", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CashChecked", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CashChecked1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CashChecked", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cashier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cashier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cashier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cashier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateofBill", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateofBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateofBill1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateofBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeofBill", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeofBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeofBill1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeofBill", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""D:\Database\Rest db.mdb""" & _
        ";Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System dat" & _
        "abase=;Jet OLEDB:SFP=False;Jet OLEDB:Global Bulk Transactions=1;Mode=Share Deny " & _
        "None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet" & _
        " OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repa" & _
        "ir=False;User ID=Admin;Jet OLEDB:Encrypt Database=False"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Account(Cash, Cashier, Cost, DateofBill, TableNo, TimeofBill, CashChe" & _
        "cked) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cash", System.Data.OleDb.OleDbType.Integer, 0, "Cash"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cashier", System.Data.OleDb.OleDbType.VarWChar, 255, "Cashier"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.Integer, 0, "Cost"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateofBill", System.Data.OleDb.OleDbType.DBDate, 0, "DateofBill"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, "TableNo"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeofBill", System.Data.OleDb.OleDbType.VarWChar, 255, "TimeofBill"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CashChecked", System.Data.OleDb.OleDbType.Integer, 0, "CashChecked"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Cash, Cashier, Cost, DateofBill, ID, TableNo, TimeofBill, CashChecked FROM" & _
        " Account"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Account SET Cash = ?, Cashier = ?, Cost = ?, DateofBill = ?, TableNo = ?, " & _
        "TimeofBill = ?, CashChecked = ? WHERE (ID = ?) AND (Cash = ? OR ? IS NULL AND Ca" & _
        "sh IS NULL) AND (CashChecked = ? OR ? IS NULL AND CashChecked IS NULL) AND (Cash" & _
        "ier = ? OR ? IS NULL AND Cashier IS NULL) AND (Cost = ? OR ? IS NULL AND Cost IS" & _
        " NULL) AND (DateofBill = ? OR ? IS NULL AND DateofBill IS NULL) AND (TableNo = ?" & _
        " OR ? IS NULL AND TableNo IS NULL) AND (TimeofBill = ? OR ? IS NULL AND TimeofBi" & _
        "ll IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cash", System.Data.OleDb.OleDbType.Integer, 0, "Cash"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cashier", System.Data.OleDb.OleDbType.VarWChar, 255, "Cashier"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.Integer, 0, "Cost"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateofBill", System.Data.OleDb.OleDbType.DBDate, 0, "DateofBill"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, "TableNo"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeofBill", System.Data.OleDb.OleDbType.VarWChar, 255, "TimeofBill"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CashChecked", System.Data.OleDb.OleDbType.Integer, 0, "CashChecked"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cash", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cash", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cash1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cash", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CashChecked", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CashChecked", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CashChecked1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CashChecked", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cashier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cashier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cashier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cashier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateofBill", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateofBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateofBill1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateofBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeofBill", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeofBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeofBill1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeofBill", System.Data.DataRowVersion.Original, Nothing))
        '
        'DataSet51
        '
        Me.DataSet51.DataSetName = "DataSet5"
        Me.DataSet51.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.CausesValidation = False
        Me.DataGrid1.ColumnHeadersVisible = False
        Me.DataGrid1.DataMember = "Account"
        Me.DataGrid1.DataSource = Me.DataSet51
        Me.DataGrid1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(688, 120)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGrid1.RowHeadersVisible = False
        Me.DataGrid1.Size = New System.Drawing.Size(584, 512)
        Me.DataGrid1.TabIndex = 152
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "Account"
        Me.DataGridTableStyle2.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "TableNo"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.MappingName = "Cash"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.MappingName = "DateofBill"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 130
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.MappingName = "TimeofBill"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "Cost"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.MappingName = "Cashier"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LinkLabel3.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel3.Location = New System.Drawing.Point(784, 32)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(184, 23)
        Me.LinkLabel3.TabIndex = 225
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "»ÕÀ Õ”» «· «—ÌŒ"
        Me.LinkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel1.Location = New System.Drawing.Point(1064, 32)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(136, 23)
        Me.LinkLabel1.TabIndex = 226
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "„·Œ’ «·ÌÊ„"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(1024, 680)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 32)
        Me.Label2.TabIndex = 228
        Me.Label2.Text = "TOTAL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Total
        '
        Me.Total.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Total.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Total.ForeColor = System.Drawing.Color.Red
        Me.Total.Location = New System.Drawing.Point(1144, 680)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(120, 32)
        Me.Total.TabIndex = 229
        Me.Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(1200, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 231
        Me.Label4.Text = "«·ÿ«Ê·…"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(1128, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 24)
        Me.Label5.TabIndex = 232
        Me.Label5.Text = "«·„»·€"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(1024, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 24)
        Me.Label6.TabIndex = 233
        Me.Label6.Text = "«· «—ÌŒ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(920, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 24)
        Me.Label7.TabIndex = 234
        Me.Label7.Text = "«·Êﬁ "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(848, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 24)
        Me.Label8.TabIndex = 235
        Me.Label8.Text = "«·ﬂ·›…"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(760, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 24)
        Me.Label9.TabIndex = 236
        Me.Label9.Text = "«·ﬂ«‘Ì—"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT Account.* FROM Account WHERE (CashChecked IS NULL)"
        Me.OleDbCommand1.Connection = Me.OleDbConnection1
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(784, 56)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 238
        Me.MonthCalendar1.Visible = False
        '
        'OleDbCommand2
        '
        Me.OleDbCommand2.CommandText = "SELECT Account.* FROM Account WHERE (DateofBill = ?)"
        Me.OleDbCommand2.Connection = Me.OleDbConnection1
        Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateofBill", System.Data.OleDb.OleDbType.DBDate, 0, "DateofBill"))
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(776, 672)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 48)
        Me.Button1.TabIndex = 239
        Me.Button1.Text = "«€·«ﬁ Õ”«» «·ÌÊ„"
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Costs", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Amount", "Amount"), New System.Data.Common.DataColumnMapping("Cost", "Cost"), New System.Data.Common.DataColumnMapping("CostDate", "CostDate"), New System.Data.Common.DataColumnMapping("ID", "ID")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM Costs WHERE (ID = ?) AND (Amount = ? OR ? IS NULL AND Amount IS NULL)" & _
        " AND (Cost = ? OR ? IS NULL AND Cost IS NULL) AND (CostDate = ? OR ? IS NULL AND" & _
        " CostDate IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Amount1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CostDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CostDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostDate", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO Costs(Amount, Cost, CostDate) VALUES (?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Integer, 0, "Amount"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.VarWChar, 255, "Cost"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CostDate", System.Data.OleDb.OleDbType.DBDate, 0, "CostDate"))
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT Amount, Cost, CostDate, ID FROM Costs ORDER BY CostDate"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE Costs SET Amount = ?, Cost = ?, CostDate = ? WHERE (ID = ?) AND (Amount = " & _
        "? OR ? IS NULL AND Amount IS NULL) AND (Cost = ? OR ? IS NULL AND Cost IS NULL) " & _
        "AND (CostDate = ? OR ? IS NULL AND CostDate IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Integer, 0, "Amount"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.VarWChar, 255, "Cost"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CostDate", System.Data.OleDb.OleDbType.DBDate, 0, "CostDate"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Amount1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CostDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CostDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostDate", System.Data.DataRowVersion.Original, Nothing))
        '
        'DataSet61
        '
        Me.DataSet61.DataSetName = "DataSet6"
        Me.DataSet61.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGrid2
        '
        Me.DataGrid2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGrid2.CaptionVisible = False
        Me.DataGrid2.CausesValidation = False
        Me.DataGrid2.ColumnHeadersVisible = False
        Me.DataGrid2.DataMember = "Costs"
        Me.DataGrid2.DataSource = Me.DataSet61
        Me.DataGrid2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(80, 120)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGrid2.Size = New System.Drawing.Size(496, 352)
        Me.DataGrid2.TabIndex = 240
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid2
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Costs"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "Cost"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 250
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.MappingName = "Amount"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "CostDate"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 130
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(424, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 241
        Me.Label1.Text = "«·»Ì«‰"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(256, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 24)
        Me.Label10.TabIndex = 242
        Me.Label10.Text = "«·„»·€"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(152, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 24)
        Me.Label11.TabIndex = 243
        Me.Label11.Text = "«· «—ÌŒ"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OleDbCommand3
        '
        Me.OleDbCommand3.CommandText = "SELECT Costs.* FROM Costs WHERE (CostDate = ?)"
        Me.OleDbCommand3.Connection = Me.OleDbConnection1
        Me.OleDbCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CostDate", System.Data.OleDb.OleDbType.DBDate, 0, "CostDate"))
        '
        'Cost
        '
        Me.Cost.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cost.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Cost.ForeColor = System.Drawing.Color.Red
        Me.Cost.Location = New System.Drawing.Point(328, 496)
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(120, 32)
        Me.Cost.TabIndex = 245
        Me.Cost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(208, 496)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 32)
        Me.Label13.TabIndex = 244
        Me.Label13.Text = "TOTAL"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OleDbCommand4
        '
        Me.OleDbCommand4.CommandText = "SELECT SUM(Cost) AS Expr1 FROM Account WHERE (CashChecked IS NULL)"
        Me.OleDbCommand4.Connection = Me.OleDbConnection1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 352)
        Me.GroupBox1.TabIndex = 246
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.GroupBox1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(200, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 40)
        Me.Button2.TabIndex = 251
        Me.Button2.Text = "«÷«›…"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(288, 184)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(104, 29)
        Me.TextBox3.TabIndex = 250
        Me.TextBox3.Text = ""
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(288, 120)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(104, 29)
        Me.TextBox2.TabIndex = 249
        Me.TextBox2.Text = ""
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(48, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 29)
        Me.TextBox1.TabIndex = 248
        Me.TextBox1.Text = ""
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(408, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 32)
        Me.Label14.TabIndex = 243
        Me.Label14.Text = "«·„»·€"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(408, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 32)
        Me.Label12.TabIndex = 242
        Me.Label12.Text = "«·»Ì«‰"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Yellow
        Me.Label15.Location = New System.Drawing.Point(408, 184)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 32)
        Me.Label15.TabIndex = 247
        Me.Label15.Text = "«· «—ÌŒ"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel2.Location = New System.Drawing.Point(248, 24)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(128, 32)
        Me.LinkLabel2.TabIndex = 251
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "«· ﬂ«·Ì›"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(464, 584)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 40)
        Me.Label3.TabIndex = 254
        Me.Label3.Text = "⁄œœ «·ÿ·»« "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OleDbCommand5
        '
        Me.OleDbCommand5.CommandText = "SELECT SUM(OrderQ) AS Expr1 FROM History WHERE ([Order] = ?) AND (OrderDate = ?)"
        Me.OleDbCommand5.Connection = Me.OleDbConnection1
        Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Order", System.Data.OleDb.OleDbType.VarWChar, 255, "Order"))
        Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"))
        '
        'OleDbCommand6
        '
        Me.OleDbCommand6.CommandText = "SELECT SUM(Amount) AS Expr1 FROM Costs WHERE (CostDate BETWEEN #1/1/2017# AND #1/" & _
        "31/2017#)"
        Me.OleDbCommand6.Connection = Me.OleDbConnection1
        '
        'OleDbCommand7
        '
        Me.OleDbCommand7.CommandText = "SELECT SUM(Cash) AS Expr1 FROM Account WHERE (DateofBill BETWEEN #1/1/2017# AND #" & _
        "1/31/2017#)"
        Me.OleDbCommand7.Connection = Me.OleDbConnection1
        '
        'Profit
        '
        Me.Profit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Profit.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Profit.ForeColor = System.Drawing.Color.Red
        Me.Profit.Location = New System.Drawing.Point(304, 664)
        Me.Profit.Name = "Profit"
        Me.Profit.Size = New System.Drawing.Size(120, 32)
        Me.Profit.TabIndex = 257
        Me.Profit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label18.Location = New System.Drawing.Point(200, 528)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 32)
        Me.Label18.TabIndex = 258
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label19.Location = New System.Drawing.Point(1016, 712)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 32)
        Me.Label19.TabIndex = 259
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OleDbDataAdapter3
        '
        Me.OleDbDataAdapter3.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "History", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Order", "Order"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1")})})
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT [Order], SUM(OrderQ) AS Expr1 FROM History WHERE (OrderDate = ?) GROUP BY " & _
        "[Order] ORDER BY SUM(OrderQ) DESC"
        Me.OleDbSelectCommand3.Connection = Me.OleDbConnection1
        Me.OleDbSelectCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"))
        '
        'DataSet71
        '
        Me.DataSet71.DataSetName = "DataSet7"
        Me.DataSet71.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGrid3
        '
        Me.DataGrid3.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGrid3.CaptionVisible = False
        Me.DataGrid3.ColumnHeadersVisible = False
        Me.DataGrid3.DataMember = "History"
        Me.DataGrid3.DataSource = Me.DataSet71
        Me.DataGrid3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid3.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid3.Name = "DataGrid3"
        Me.DataGrid3.RowHeadersVisible = False
        Me.DataGrid3.Size = New System.Drawing.Size(240, 472)
        Me.DataGrid3.TabIndex = 260
        Me.DataGrid3.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        Me.DataGrid3.Visible = False
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.ColumnHeadersVisible = False
        Me.DataGridTableStyle3.DataGrid = Me.DataGrid3
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "History"
        Me.DataGridTableStyle3.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.MappingName = "Order"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 188
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "Expr1"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 30
        '
        'DataSet81
        '
        Me.DataSet81.DataSetName = "DataSet8"
        Me.DataSet81.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OleDbCommand8
        '
        Me.OleDbCommand8.CommandText = "SELECT SUM(OrderQ) AS Expr1 FROM History WHERE ([Order] IN ('Pepsi', 'Pasta Combo" & _
        "', 'Cheesy Fries', 'Fried Ch Snack', 'Nuggets Combo', 'Fried Ch Meal', 'P-Burger" & _
        " Combo', 'Dal Combo', 'Fried Ch Jumbo', 'Fries + Pepsi')) AND (OrderDate = ?)"
        Me.OleDbCommand8.Connection = Me.OleDbConnection1
        Me.OleDbCommand8.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"))
        '
        'OleDbCommand9
        '
        Me.OleDbCommand9.CommandText = "SELECT SUM(OrderQ) AS Expr1 FROM History WHERE ([Order] IN ('Bir-Kar Combo', '2 P" & _
        "izza Combo')) AND (OrderDate = ?)"
        Me.OleDbCommand9.Connection = Me.OleDbConnection1
        Me.OleDbCommand9.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"))
        '
        'OleDbCommand10
        '
        Me.OleDbCommand10.CommandText = "SELECT SUM(OrderQ) AS Expr1 FROM History WHERE ([Order] = 'Big Water') AND (Order" & _
        "Date = ?)"
        Me.OleDbCommand10.Connection = Me.OleDbConnection1
        Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"))
        '
        'OleDbCommand11
        '
        Me.OleDbCommand11.CommandText = "SELECT SUM(OrderQ) AS Expr1 FROM History WHERE ([Order] = 'Small Water') AND (Ord" & _
        "erDate = ?)"
        Me.OleDbCommand11.Connection = Me.OleDbConnection1
        Me.OleDbCommand11.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"))
        '
        'OleDbDataAdapter4
        '
        Me.OleDbDataAdapter4.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapter4.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapter4.SelectCommand = Me.OleDbSelectCommand4
        Me.OleDbDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Counting", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Bwater", "Bwater"), New System.Data.Common.DataColumnMapping("DateStart", "DateStart"), New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("One Pepsi", "One Pepsi"), New System.Data.Common.DataColumnMapping("Swater", "Swater"), New System.Data.Common.DataColumnMapping("Two Pepsi", "Two Pepsi")})})
        Me.OleDbDataAdapter4.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM Counting WHERE (id = ?) AND (Bwater = ? OR ? IS NULL AND Bwater IS NU" & _
        "LL) AND (DateStart = ? OR ? IS NULL AND DateStart IS NULL) AND ([One Pepsi] = ? " & _
        "OR ? IS NULL AND [One Pepsi] IS NULL) AND (Swater = ? OR ? IS NULL AND Swater IS" & _
        " NULL) AND ([Two Pepsi] = ? OR ? IS NULL AND [Two Pepsi] IS NULL)"
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Bwater", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Bwater", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Bwater1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Bwater", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateStart", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateStart", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateStart1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateStart", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_One_Pepsi", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "One Pepsi", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_One_Pepsi1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "One Pepsi", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Swater", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Swater", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Swater1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Swater", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Two_Pepsi", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Two Pepsi", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Two_Pepsi1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Two Pepsi", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO Counting(Bwater, DateStart, [One Pepsi], Swater, [Two Pepsi]) VALUES " & _
        "(?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Bwater", System.Data.OleDb.OleDbType.Integer, 0, "Bwater"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateStart", System.Data.OleDb.OleDbType.DBDate, 0, "DateStart"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("One_Pepsi", System.Data.OleDb.OleDbType.Integer, 0, "One Pepsi"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Swater", System.Data.OleDb.OleDbType.Integer, 0, "Swater"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Two_Pepsi", System.Data.OleDb.OleDbType.Integer, 0, "Two Pepsi"))
        '
        'OleDbSelectCommand4
        '
        Me.OleDbSelectCommand4.CommandText = "SELECT Bwater, DateStart, id, [One Pepsi], Swater, [Two Pepsi] FROM Counting"
        Me.OleDbSelectCommand4.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE Counting SET Bwater = ?, DateStart = ?, [One Pepsi] = ?, Swater = ?, [Two " & _
        "Pepsi] = ? WHERE (id = ?) AND (Bwater = ? OR ? IS NULL AND Bwater IS NULL) AND (" & _
        "DateStart = ? OR ? IS NULL AND DateStart IS NULL) AND ([One Pepsi] = ? OR ? IS N" & _
        "ULL AND [One Pepsi] IS NULL) AND (Swater = ? OR ? IS NULL AND Swater IS NULL) AN" & _
        "D ([Two Pepsi] = ? OR ? IS NULL AND [Two Pepsi] IS NULL)"
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Bwater", System.Data.OleDb.OleDbType.Integer, 0, "Bwater"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateStart", System.Data.OleDb.OleDbType.DBDate, 0, "DateStart"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("One_Pepsi", System.Data.OleDb.OleDbType.Integer, 0, "One Pepsi"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Swater", System.Data.OleDb.OleDbType.Integer, 0, "Swater"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Two_Pepsi", System.Data.OleDb.OleDbType.Integer, 0, "Two Pepsi"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Bwater", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Bwater", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Bwater1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Bwater", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateStart", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateStart", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateStart1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateStart", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_One_Pepsi", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "One Pepsi", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_One_Pepsi1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "One Pepsi", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Swater", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Swater", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Swater1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Swater", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Two_Pepsi", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Two Pepsi", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Two_Pepsi1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Two Pepsi", System.Data.DataRowVersion.Original, Nothing))
        '
        'DataSet91
        '
        Me.DataSet91.DataSetName = "DataSet9"
        Me.DataSet91.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Yellow
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(616, 672)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 48)
        Me.Button3.TabIndex = 261
        Me.Button3.Text = "«·⁄œ«œ"
        '
        'DataGrid4
        '
        Me.DataGrid4.CaptionVisible = False
        Me.DataGrid4.DataMember = "Counting"
        Me.DataGrid4.DataSource = Me.DataSet91
        Me.DataGrid4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid4.Location = New System.Drawing.Point(176, 568)
        Me.DataGrid4.Name = "DataGrid4"
        Me.DataGrid4.Size = New System.Drawing.Size(248, 72)
        Me.DataGrid4.TabIndex = 262
        Me.DataGrid4.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.DataGrid = Me.DataGrid4
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle4.GridLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridTableStyle4.HeaderBackColor = System.Drawing.Color.Yellow
        Me.DataGridTableStyle4.HeaderFont = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "Counting"
        Me.DataGridTableStyle4.RowHeadersVisible = False
        Me.DataGridTableStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Pepsi"
        Me.DataGridTextBoxColumn12.MappingName = "One Pepsi"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 75
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "SWater"
        Me.DataGridTextBoxColumn13.MappingName = "Swater"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 75
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "BWater"
        Me.DataGridTextBoxColumn14.MappingName = "Bwater"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'Accounts
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(1284, 749)
        Me.Controls.Add(Me.DataGrid4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGrid3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Profit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cost)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Accounts"
        Me.Text = "Accounts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSet51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Accounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.OleDbDataAdapter1.Fill(Me.DataSet51)
            Me.Total.Text = Me.DataSet51.Account.Compute("SUM(Cash)", String.Empty).ToString

            Me.OleDbDataAdapter2.Fill(Me.DataSet61)
            Me.Cost.Text = Me.DataSet61.Costs.Compute("SUM(Amount)", String.Empty).ToString

            Dim x As Integer
            Dim y As Integer

            Me.OleDbConnection1.Open()
            x = Me.OleDbCommand6.ExecuteScalar
            Me.Label18.Text = x
            y = Me.OleDbCommand7.ExecuteScalar
            Me.Label19.Text = y
            Me.Profit.Text = y - x



            Me.OleDbConnection1.Close()



            'Counting
            Me.OleDbDataAdapter4.Fill(Me.DataSet91)
            If Me.DataSet91.Counting.Rows(0).Item(1) = Now.AddDays(-1).ToShortDateString Then
                Me.Button3.Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Me.DataSet51.Clear()
            Me.OleDbConnection1.Open()
            Me.OleDbDataAdapter1.SelectCommand = Me.OleDbCommand1
            Me.OleDbCommand1.ExecuteScalar()
            Me.OleDbDataAdapter1.Fill(Me.DataSet51)
            Me.OleDbConnection1.Close()
            Me.Total.Text = Me.DataSet51.Account.Compute("SUM(Cash)", String.Empty).ToString

            'Costs
            Me.DataSet61.Clear()
            Me.OleDbConnection1.Open()
            Me.OleDbCommand3.Parameters(0).Value = Now.Date
            Me.OleDbDataAdapter2.SelectCommand = Me.OleDbCommand3
            Me.OleDbCommand3.ExecuteScalar()
            Me.OleDbDataAdapter2.Fill(Me.DataSet61)
            Me.OleDbConnection1.Close()
            Me.Cost.Text = Me.DataSet61.Costs.Compute("SUM(Amount)", String.Empty).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

  

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged

        Try
            Me.DataSet51.Clear()
            Me.OleDbConnection1.Open()
            Me.OleDbCommand2.Parameters(0).Value = Me.MonthCalendar1.SelectionEnd
            Me.OleDbDataAdapter1.SelectCommand = Me.OleDbCommand2
            Me.OleDbCommand2.ExecuteScalar()
            Me.OleDbDataAdapter1.Fill(Me.DataSet51)
            Me.OleDbConnection1.Close()
            Me.MonthCalendar1.Visible = False
            Me.Total.Text = Me.DataSet51.Account.Compute("SUM(Cash)", String.Empty).ToString

            'Costs
            Me.DataSet61.Clear()
            Me.OleDbConnection1.Open()
            Me.OleDbCommand3.Parameters(0).Value = Me.MonthCalendar1.SelectionEnd
            Me.OleDbDataAdapter2.SelectCommand = Me.OleDbCommand3
            Me.OleDbCommand3.ExecuteScalar()
            Me.OleDbDataAdapter2.Fill(Me.DataSet61)
            Me.OleDbConnection1.Close()
            Me.Cost.Text = Me.DataSet61.Costs.Compute("SUM(Amount)", String.Empty).ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.MonthCalendar1.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Me.DataSet51.Clear()
            Me.OleDbConnection1.Open()
            Me.OleDbDataAdapter1.SelectCommand = Me.OleDbCommand1
            Me.OleDbCommand1.ExecuteScalar()
            '
            Dim totalcost As Integer = Me.OleDbCommand4.ExecuteScalar
            Me.OleDbConnection1.Close()
            '
            Me.OleDbDataAdapter1.Fill(Me.DataSet51)


            'Move summary to Costs
            'Me.OleDbDataAdapter2.Fill(Me.DataSet61)
            'Dim row As DataRow = Me.DataSet61.Costs.NewRow()
            'row(0) = totalcost
            'row(1) = " ﬂ·›… „Ê«œ"
            'row(2) = Now.Date
            'Me.DataSet61.Costs.Rows.Add(row)
            'Me.OleDbDataAdapter2.Update(Me.DataSet61)
            'Me.Button1.Enabled = False


            'Finish Today Account
            Dim dr As DataRow
            For Each dr In Me.DataSet51.Account.Rows
                dr(7) = 0
            Next
            Me.OleDbDataAdapter1.Update(Me.DataSet51)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.GroupBox1.Visible = True
        Me.TextBox3.Text = Now.Date

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.OleDbDataAdapter2.Fill(Me.DataSet61)
            Dim row As DataRow = Me.DataSet61.Costs.NewRow()
            row(0) = Me.TextBox2.Text
            row(1) = Me.TextBox1.Text
            row(2) = Me.TextBox3.Text
            Me.DataSet61.Costs.Rows.Add(row)
            Me.OleDbDataAdapter2.Update(Me.DataSet61)
            Me.GroupBox1.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Try

            Me.DataSet71.Clear()

        Me.DataGrid3.Visible = True

        Me.OleDbDataAdapter3.SelectCommand.Parameters(0).Value = Me.MonthCalendar1.SelectionEnd

            Me.OleDbDataAdapter3.Fill(Me.DataSet71)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            Me.DataSet91.Clear()
            Me.OleDbDataAdapter4.Fill(Me.DataSet91)

            Dim x1 As Integer = Me.DataSet91.Counting.Rows(0).Item(3)
            Dim x2 As Integer = Me.DataSet91.Counting.Rows(0).Item(5)
            Dim x3 As Integer = Me.DataSet91.Counting.Rows(0).Item(4)
            Dim x4 As Integer = Me.DataSet91.Counting.Rows(0).Item(0)
            Dim x5 As Date = Me.DataSet91.Counting.Rows(0).Item(1)


            Dim y1 As Integer
            Dim y2 As Integer
            Dim y3 As Integer
            Dim y4 As Integer


            Me.OleDbConnection1.Open()

            'Pepsi and Two Pepsi
            Me.OleDbCommand8.Parameters(0).Value = Now.AddDays(-1)
            Me.OleDbCommand9.Parameters(0).Value = Now.AddDays(-1)

            If Me.OleDbCommand8.ExecuteScalar.ToString Is "" Then
                y1 = 0
            Else
                y1 = Me.OleDbCommand8.ExecuteScalar
            End If
            If Me.OleDbCommand9.ExecuteScalar.ToString Is "" Then
                y2 = 0
            Else
                y2 = Me.OleDbCommand9.ExecuteScalar
                y2 = y2 * 2
            End If
            Dim Sumpepsi As Integer = y1 + y2
            Me.DataSet91.Counting.Rows(0).Item(3) = x1 - Sumpepsi
            Me.OleDbDataAdapter4.Update(Me.DataSet91)



            'Small Water
            Me.OleDbCommand11.Parameters(0).Value = Now.AddDays(-1)
            If Me.OleDbCommand11.ExecuteScalar.ToString Is "" Then
            Else
                y3 = Me.OleDbCommand11.ExecuteScalar
                Me.DataSet91.Counting.Rows(0).Item(4) = x3 - y3
                Me.OleDbDataAdapter4.Update(Me.DataSet91)
            End If


            'Big Water
            Me.OleDbCommand10.Parameters(0).Value = Now.AddDays(-1)
            If Me.OleDbCommand10.ExecuteScalar.ToString Is "" Then
            Else
                y4 = Me.OleDbCommand10.ExecuteScalar
                Me.DataSet91.Counting.Rows(0).Item(0) = x4 - y4
                Me.OleDbDataAdapter4.Update(Me.DataSet91)
            End If

            'Date updating
            Me.DataSet91.Counting.Rows(0).Item(1) = Now.AddDays(-1)
            Me.OleDbDataAdapter4.Update(Me.DataSet91)

            Me.OleDbConnection1.Close()

            Me.Button3.Visible = False
            MsgBox("OK")



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

  
   
End Class
