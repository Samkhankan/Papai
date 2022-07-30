
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Form1
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



    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents Button37 As System.Windows.Forms.Button

    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Sonf4 As System.Windows.Forms.Button
    Friend WithEvents Sonf3 As System.Windows.Forms.Button
    Friend WithEvents Sonf2 As System.Windows.Forms.Button
    Friend WithEvents Sonf1 As System.Windows.Forms.Button
    Friend WithEvents Sonf8 As System.Windows.Forms.Button
    Friend WithEvents Sonf7 As System.Windows.Forms.Button
    Friend WithEvents Sonf6 As System.Windows.Forms.Button
    Friend WithEvents Sonf5 As System.Windows.Forms.Button
    Friend WithEvents Sonf12 As System.Windows.Forms.Button
    Friend WithEvents Sonf11 As System.Windows.Forms.Button
    Friend WithEvents Sonf10 As System.Windows.Forms.Button
    Friend WithEvents Sonf9 As System.Windows.Forms.Button
    Friend WithEvents Sonf16 As System.Windows.Forms.Button
    Friend WithEvents Sonf15 As System.Windows.Forms.Button
    Friend WithEvents Sonf14 As System.Windows.Forms.Button
    Friend WithEvents Sonf13 As System.Windows.Forms.Button
    Friend WithEvents Sonf20 As System.Windows.Forms.Button
    Friend WithEvents Sonf19 As System.Windows.Forms.Button
    Friend WithEvents Sonf18 As System.Windows.Forms.Button
    Friend WithEvents Sonf17 As System.Windows.Forms.Button
    Friend WithEvents Price4 As System.Windows.Forms.Label
    Friend WithEvents Price3 As System.Windows.Forms.Label
    Friend WithEvents Price2 As System.Windows.Forms.Label
    Friend WithEvents Price1 As System.Windows.Forms.Label
    Friend WithEvents Price8 As System.Windows.Forms.Label
    Friend WithEvents Price7 As System.Windows.Forms.Label
    Friend WithEvents Price6 As System.Windows.Forms.Label
    Friend WithEvents Price5 As System.Windows.Forms.Label
    Friend WithEvents Price12 As System.Windows.Forms.Label
    Friend WithEvents Price11 As System.Windows.Forms.Label
    Friend WithEvents Price10 As System.Windows.Forms.Label
    Friend WithEvents Price9 As System.Windows.Forms.Label
    Friend WithEvents Price16 As System.Windows.Forms.Label
    Friend WithEvents Price15 As System.Windows.Forms.Label
    Friend WithEvents Price14 As System.Windows.Forms.Label
    Friend WithEvents Price13 As System.Windows.Forms.Label
    Friend WithEvents Price20 As System.Windows.Forms.Label
    Friend WithEvents Price19 As System.Windows.Forms.Label
    Friend WithEvents Price18 As System.Windows.Forms.Label
    Friend WithEvents Price17 As System.Windows.Forms.Label

    Friend WithEvents Calc As System.Windows.Forms.Label
    Friend WithEvents TableNo As System.Windows.Forms.Label

    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn

    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSet11 As WindowsApplication1.DataSet1
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OleDbCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button41 As System.Windows.Forms.Button
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet21 As WindowsApplication1.DataSet2
    Friend WithEvents kitchen1 As WindowsApplication1.Kitchen
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents OleDbDataAdapter3 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet31 As WindowsApplication1.DataSet3
    Friend WithEvents OleDbCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter4 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet41 As WindowsApplication1.DataSet4
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Cost1 As System.Windows.Forms.Label
    Friend WithEvents Cost2 As System.Windows.Forms.Label
    Friend WithEvents Cost3 As System.Windows.Forms.Label
    Friend WithEvents Cost4 As System.Windows.Forms.Label
    Friend WithEvents Cost5 As System.Windows.Forms.Label
    Friend WithEvents Cost6 As System.Windows.Forms.Label
    Friend WithEvents Cost7 As System.Windows.Forms.Label
    Friend WithEvents Cost8 As System.Windows.Forms.Label
    Friend WithEvents Cost9 As System.Windows.Forms.Label
    Friend WithEvents Cost10 As System.Windows.Forms.Label
    Friend WithEvents Cost11 As System.Windows.Forms.Label
    Friend WithEvents Cost12 As System.Windows.Forms.Label
    Friend WithEvents Cost13 As System.Windows.Forms.Label
    Friend WithEvents Cost14 As System.Windows.Forms.Label
    Friend WithEvents Cost15 As System.Windows.Forms.Label
    Friend WithEvents Cost16 As System.Windows.Forms.Label
    Friend WithEvents Cost17 As System.Windows.Forms.Label
    Friend WithEvents Cost18 As System.Windows.Forms.Label
    Friend WithEvents Cost19 As System.Windows.Forms.Label
    Friend WithEvents Cost20 As System.Windows.Forms.Label
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button42 As System.Windows.Forms.Button
    Friend WithEvents Button45 As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button38 As System.Windows.Forms.Button
    Friend WithEvents Button39 As System.Windows.Forms.Button
    Friend WithEvents Button40 As System.Windows.Forms.Button
    Friend WithEvents Button43 As System.Windows.Forms.Button
    Friend WithEvents Button44 As System.Windows.Forms.Button
    Friend WithEvents Button46 As System.Windows.Forms.Button


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button46 = New System.Windows.Forms.Button
        Me.Button44 = New System.Windows.Forms.Button
        Me.Button43 = New System.Windows.Forms.Button
        Me.Button40 = New System.Windows.Forms.Button
        Me.Button39 = New System.Windows.Forms.Button
        Me.Button38 = New System.Windows.Forms.Button
        Me.Button34 = New System.Windows.Forms.Button
        Me.Button33 = New System.Windows.Forms.Button
        Me.Button32 = New System.Windows.Forms.Button
        Me.Button31 = New System.Windows.Forms.Button
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Button45 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Button41 = New System.Windows.Forms.Button
        Me.Button26 = New System.Windows.Forms.Button
        Me.Button27 = New System.Windows.Forms.Button
        Me.Button28 = New System.Windows.Forms.Button
        Me.Button29 = New System.Windows.Forms.Button
        Me.Button30 = New System.Windows.Forms.Button
        Me.Button25 = New System.Windows.Forms.Button
        Me.Button24 = New System.Windows.Forms.Button
        Me.Button23 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button35 = New System.Windows.Forms.Button
        Me.Button36 = New System.Windows.Forms.Button
        Me.Button37 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button17 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button18 = New System.Windows.Forms.Button
        Me.Button19 = New System.Windows.Forms.Button
        Me.Button20 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button21 = New System.Windows.Forms.Button
        Me.Button22 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Sonf4 = New System.Windows.Forms.Button
        Me.Sonf3 = New System.Windows.Forms.Button
        Me.Sonf2 = New System.Windows.Forms.Button
        Me.Sonf1 = New System.Windows.Forms.Button
        Me.Sonf8 = New System.Windows.Forms.Button
        Me.Sonf7 = New System.Windows.Forms.Button
        Me.Sonf6 = New System.Windows.Forms.Button
        Me.Sonf5 = New System.Windows.Forms.Button
        Me.Sonf12 = New System.Windows.Forms.Button
        Me.Sonf11 = New System.Windows.Forms.Button
        Me.Sonf10 = New System.Windows.Forms.Button
        Me.Sonf9 = New System.Windows.Forms.Button
        Me.Sonf16 = New System.Windows.Forms.Button
        Me.Sonf15 = New System.Windows.Forms.Button
        Me.Sonf14 = New System.Windows.Forms.Button
        Me.Sonf13 = New System.Windows.Forms.Button
        Me.Sonf20 = New System.Windows.Forms.Button
        Me.Sonf19 = New System.Windows.Forms.Button
        Me.Sonf18 = New System.Windows.Forms.Button
        Me.Sonf17 = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Price4 = New System.Windows.Forms.Label
        Me.Price3 = New System.Windows.Forms.Label
        Me.Price2 = New System.Windows.Forms.Label
        Me.Price1 = New System.Windows.Forms.Label
        Me.Price8 = New System.Windows.Forms.Label
        Me.Price7 = New System.Windows.Forms.Label
        Me.Price6 = New System.Windows.Forms.Label
        Me.Price5 = New System.Windows.Forms.Label
        Me.Price12 = New System.Windows.Forms.Label
        Me.Price11 = New System.Windows.Forms.Label
        Me.Price10 = New System.Windows.Forms.Label
        Me.Price9 = New System.Windows.Forms.Label
        Me.Price16 = New System.Windows.Forms.Label
        Me.Price15 = New System.Windows.Forms.Label
        Me.Price14 = New System.Windows.Forms.Label
        Me.Price13 = New System.Windows.Forms.Label
        Me.Price20 = New System.Windows.Forms.Label
        Me.Price19 = New System.Windows.Forms.Label
        Me.Price18 = New System.Windows.Forms.Label
        Me.Price17 = New System.Windows.Forms.Label
        Me.Calc = New System.Windows.Forms.Label
        Me.TableNo = New System.Windows.Forms.Label
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataSet11 = New WindowsApplication1.DataSet1
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.OleDbCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.DataSet21 = New WindowsApplication1.DataSet2
        Me.kitchen1 = New WindowsApplication1.Kitchen
        Me.OleDbDataAdapter3 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        Me.DataSet31 = New WindowsApplication1.DataSet3
        Me.OleDbCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter4 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand4 = New System.Data.OleDb.OleDbCommand
        Me.DataSet41 = New WindowsApplication1.DataSet4
        Me.Cost1 = New System.Windows.Forms.Label
        Me.Cost2 = New System.Windows.Forms.Label
        Me.Cost3 = New System.Windows.Forms.Label
        Me.Cost4 = New System.Windows.Forms.Label
        Me.Cost5 = New System.Windows.Forms.Label
        Me.Cost6 = New System.Windows.Forms.Label
        Me.Cost7 = New System.Windows.Forms.Label
        Me.Cost8 = New System.Windows.Forms.Label
        Me.Cost9 = New System.Windows.Forms.Label
        Me.Cost10 = New System.Windows.Forms.Label
        Me.Cost11 = New System.Windows.Forms.Label
        Me.Cost12 = New System.Windows.Forms.Label
        Me.Cost13 = New System.Windows.Forms.Label
        Me.Cost14 = New System.Windows.Forms.Label
        Me.Cost15 = New System.Windows.Forms.Label
        Me.Cost16 = New System.Windows.Forms.Label
        Me.Cost17 = New System.Windows.Forms.Label
        Me.Cost18 = New System.Windows.Forms.Label
        Me.Cost19 = New System.Windows.Forms.Label
        Me.Cost20 = New System.Windows.Forms.Label
        Me.OleDbCommand5 = New System.Data.OleDb.OleDbCommand
        Me.Button42 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet41, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PapayaWhip
        Me.GroupBox1.Controls.Add(Me.Button46)
        Me.GroupBox1.Controls.Add(Me.Button44)
        Me.GroupBox1.Controls.Add(Me.Button43)
        Me.GroupBox1.Controls.Add(Me.Button40)
        Me.GroupBox1.Controls.Add(Me.Button39)
        Me.GroupBox1.Controls.Add(Me.Button38)
        Me.GroupBox1.Controls.Add(Me.Button34)
        Me.GroupBox1.Controls.Add(Me.Button33)
        Me.GroupBox1.Controls.Add(Me.Button32)
        Me.GroupBox1.Controls.Add(Me.Button31)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.Button45)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.CrystalReportViewer1)
        Me.GroupBox1.Controls.Add(Me.Button41)
        Me.GroupBox1.Controls.Add(Me.Button26)
        Me.GroupBox1.Controls.Add(Me.Button27)
        Me.GroupBox1.Controls.Add(Me.Button28)
        Me.GroupBox1.Controls.Add(Me.Button29)
        Me.GroupBox1.Controls.Add(Me.Button30)
        Me.GroupBox1.Controls.Add(Me.Button25)
        Me.GroupBox1.Controls.Add(Me.Button24)
        Me.GroupBox1.Controls.Add(Me.Button23)
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1280, 776)
        Me.GroupBox1.TabIndex = 155
        Me.GroupBox1.TabStop = False
        '
        'Button46
        '
        Me.Button46.BackColor = System.Drawing.Color.Orange
        Me.Button46.Font = New System.Drawing.Font("Segoe Script", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button46.ForeColor = System.Drawing.Color.Firebrick
        Me.Button46.Location = New System.Drawing.Point(296, 200)
        Me.Button46.Name = "Button46"
        Me.Button46.Size = New System.Drawing.Size(248, 80)
        Me.Button46.TabIndex = 40
        Me.Button46.Text = "Take Away 2"
        '
        'Button44
        '
        Me.Button44.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button44.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button44.Location = New System.Drawing.Point(944, 576)
        Me.Button44.Name = "Button44"
        Me.Button44.Size = New System.Drawing.Size(144, 88)
        Me.Button44.TabIndex = 39
        Me.Button44.Text = "Table 19"
        '
        'Button43
        '
        Me.Button43.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button43.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button43.Location = New System.Drawing.Point(760, 576)
        Me.Button43.Name = "Button43"
        Me.Button43.Size = New System.Drawing.Size(152, 88)
        Me.Button43.TabIndex = 38
        Me.Button43.Text = "Table 18"
        '
        'Button40
        '
        Me.Button40.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button40.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button40.Location = New System.Drawing.Point(576, 576)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(152, 88)
        Me.Button40.TabIndex = 37
        Me.Button40.Text = "Table 17"
        '
        'Button39
        '
        Me.Button39.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button39.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button39.Location = New System.Drawing.Point(392, 576)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(152, 88)
        Me.Button39.TabIndex = 36
        Me.Button39.Text = "Table 16"
        '
        'Button38
        '
        Me.Button38.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button38.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button38.Location = New System.Drawing.Point(208, 576)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(152, 88)
        Me.Button38.TabIndex = 35
        Me.Button38.Text = "Table 15"
        '
        'Button34
        '
        Me.Button34.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button34.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button34.Location = New System.Drawing.Point(1120, 440)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(144, 88)
        Me.Button34.TabIndex = 34
        Me.Button34.Text = "Table 14"
        '
        'Button33
        '
        Me.Button33.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button33.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button33.Location = New System.Drawing.Point(944, 440)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(144, 88)
        Me.Button33.TabIndex = 33
        Me.Button33.Text = "Table 13"
        '
        'Button32
        '
        Me.Button32.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button32.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button32.Location = New System.Drawing.Point(760, 440)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(144, 88)
        Me.Button32.TabIndex = 32
        Me.Button32.Text = "Table 12"
        '
        'Button31
        '
        Me.Button31.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button31.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button31.Location = New System.Drawing.Point(576, 440)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(152, 88)
        Me.Button31.TabIndex = 31
        Me.Button31.Text = "Table 11"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1280, 176)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 30
        Me.PictureBox4.TabStop = False
        '
        'Button45
        '
        Me.Button45.BackColor = System.Drawing.Color.Orange
        Me.Button45.Font = New System.Drawing.Font("Segoe Script", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button45.ForeColor = System.Drawing.Color.Firebrick
        Me.Button45.Location = New System.Drawing.Point(1216, 208)
        Me.Button45.Name = "Button45"
        Me.Button45.Size = New System.Drawing.Size(48, 48)
        Me.Button45.TabIndex = 29
        Me.Button45.Text = "X"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-8, 728)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 32)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Hussam"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(40, 672)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(56, 56)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(40, 392)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(136, 128)
        Me.CrystalReportViewer1.TabIndex = 22
        Me.CrystalReportViewer1.Visible = False
        '
        'Button41
        '
        Me.Button41.BackColor = System.Drawing.Color.Orange
        Me.Button41.Font = New System.Drawing.Font("Segoe Script", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button41.ForeColor = System.Drawing.Color.Firebrick
        Me.Button41.Location = New System.Drawing.Point(16, 200)
        Me.Button41.Name = "Button41"
        Me.Button41.Size = New System.Drawing.Size(248, 80)
        Me.Button41.TabIndex = 20
        Me.Button41.Text = "Take Away 1"
        '
        'Button26
        '
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button26.Location = New System.Drawing.Point(392, 440)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(152, 88)
        Me.Button26.TabIndex = 9
        Me.Button26.Text = "Table 10"
        '
        'Button27
        '
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button27.Location = New System.Drawing.Point(208, 440)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(152, 88)
        Me.Button27.TabIndex = 8
        Me.Button27.Text = "Table 9"
        '
        'Button28
        '
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button28.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button28.Location = New System.Drawing.Point(24, 440)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(152, 88)
        Me.Button28.TabIndex = 7
        Me.Button28.Text = "Table 8"
        '
        'Button29
        '
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button29.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button29.Location = New System.Drawing.Point(1120, 312)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(152, 88)
        Me.Button29.TabIndex = 6
        Me.Button29.Text = "Table 7"
        '
        'Button30
        '
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button30.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button30.Location = New System.Drawing.Point(944, 312)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(144, 88)
        Me.Button30.TabIndex = 5
        Me.Button30.Text = "Table 6"
        '
        'Button25
        '
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button25.Location = New System.Drawing.Point(760, 312)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(152, 88)
        Me.Button25.TabIndex = 4
        Me.Button25.Text = "Table 5"
        '
        'Button24
        '
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button24.Location = New System.Drawing.Point(576, 312)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(152, 88)
        Me.Button24.TabIndex = 3
        Me.Button24.Text = "Table 4"
        '
        'Button23
        '
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button23.Location = New System.Drawing.Point(392, 312)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(152, 88)
        Me.Button23.TabIndex = 2
        Me.Button23.Text = "Table 3"
        '
        'Button13
        '
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button13.Location = New System.Drawing.Point(208, 312)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(152, 88)
        Me.Button13.TabIndex = 1
        Me.Button13.Text = "Table 2"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(24, 312)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(152, 88)
        Me.Button10.TabIndex = 0
        Me.Button10.Text = "Table 1"
        '
        'Button35
        '
        Me.Button35.BackColor = System.Drawing.Color.Peru
        Me.Button35.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button35.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button35.Location = New System.Drawing.Point(384, 32)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(176, 64)
        Me.Button35.TabIndex = 177
        Me.Button35.Text = "Appetizers"
        '
        'Button36
        '
        Me.Button36.BackColor = System.Drawing.Color.Peru
        Me.Button36.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button36.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button36.Location = New System.Drawing.Point(384, 608)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(176, 64)
        Me.Button36.TabIndex = 178
        Me.Button36.Text = "Juice"
        '
        'Button37
        '
        Me.Button37.BackColor = System.Drawing.Color.OrangeRed
        Me.Button37.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button37.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button37.Location = New System.Drawing.Point(384, 512)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(176, 80)
        Me.Button37.TabIndex = 179
        Me.Button37.Text = "COMBO"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OliveDrab
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(48, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(232, 64)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Table Number:"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button17.Font = New System.Drawing.Font("Arial", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button17.ForeColor = System.Drawing.SystemColors.Info
        Me.Button17.Location = New System.Drawing.Point(8, 608)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(128, 40)
        Me.Button17.TabIndex = 90
        Me.Button17.Text = "Mistake"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button9.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.Info
        Me.Button9.Location = New System.Drawing.Point(48, 240)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(72, 64)
        Me.Button9.TabIndex = 87
        Me.Button9.Text = "1"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button8.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.Info
        Me.Button8.Location = New System.Drawing.Point(128, 240)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(72, 64)
        Me.Button8.TabIndex = 86
        Me.Button8.Text = "2"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button7.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.Info
        Me.Button7.Location = New System.Drawing.Point(208, 240)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(72, 64)
        Me.Button7.TabIndex = 85
        Me.Button7.Text = "3"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button6.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.Info
        Me.Button6.Location = New System.Drawing.Point(48, 160)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 64)
        Me.Button6.TabIndex = 84
        Me.Button6.Text = "4"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button11.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button11.ForeColor = System.Drawing.SystemColors.Info
        Me.Button11.Location = New System.Drawing.Point(128, 160)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(72, 64)
        Me.Button11.TabIndex = 83
        Me.Button11.Text = "5"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button12.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button12.ForeColor = System.Drawing.SystemColors.Info
        Me.Button12.Location = New System.Drawing.Point(208, 160)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(72, 64)
        Me.Button12.TabIndex = 82
        Me.Button12.Text = "6"
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button14.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button14.ForeColor = System.Drawing.SystemColors.Info
        Me.Button14.Location = New System.Drawing.Point(48, 80)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(72, 64)
        Me.Button14.TabIndex = 81
        Me.Button14.Text = "7"
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button15.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button15.ForeColor = System.Drawing.SystemColors.Info
        Me.Button15.Location = New System.Drawing.Point(128, 80)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(72, 64)
        Me.Button15.TabIndex = 80
        Me.Button15.Text = "8"
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button16.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button16.ForeColor = System.Drawing.SystemColors.Info
        Me.Button16.Location = New System.Drawing.Point(208, 80)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(72, 64)
        Me.Button16.TabIndex = 79
        Me.Button16.Text = "9"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Peru
        Me.Button2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(384, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 64)
        Me.Button2.TabIndex = 92
        Me.Button2.Text = "Shawrma"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Peru
        Me.Button3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(384, 352)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(176, 64)
        Me.Button3.TabIndex = 93
        Me.Button3.Text = "Burger-Pizza"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Peru
        Me.Button4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(384, 272)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(176, 64)
        Me.Button4.TabIndex = 94
        Me.Button4.Text = "Meals"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Peru
        Me.Button5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(384, 192)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(176, 64)
        Me.Button5.TabIndex = 95
        Me.Button5.Text = "Sandwich"
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Peru
        Me.Button18.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button18.Location = New System.Drawing.Point(384, 432)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(176, 64)
        Me.Button18.TabIndex = 96
        Me.Button18.Text = "Main Course"
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.Peru
        Me.Button19.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button19.Location = New System.Drawing.Point(384, 688)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(176, 64)
        Me.Button19.TabIndex = 97
        Me.Button19.Text = "Drinks"
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.Peru
        Me.Button20.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button20.Location = New System.Drawing.Point(296, 688)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(48, 16)
        Me.Button20.TabIndex = 98
        Me.Button20.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(184, 608)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 32)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "TOTAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(264, 608)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 32)
        Me.Label2.TabIndex = 100
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.Yellow
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button21.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button21.Location = New System.Drawing.Point(24, 688)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(104, 64)
        Me.Button21.TabIndex = 101
        Me.Button21.Text = "Kitchen"
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.Red
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button22.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button22.Location = New System.Drawing.Point(192, 688)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(104, 64)
        Me.Button22.TabIndex = 102
        Me.Button22.Text = "Bill"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(568, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(720, 776)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        '
        'Sonf4
        '
        Me.Sonf4.BackColor = System.Drawing.Color.Purple
        Me.Sonf4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf4.ForeColor = System.Drawing.Color.Gold
        Me.Sonf4.Location = New System.Drawing.Point(1080, 112)
        Me.Sonf4.Name = "Sonf4"
        Me.Sonf4.Size = New System.Drawing.Size(136, 72)
        Me.Sonf4.TabIndex = 111
        '
        'Sonf3
        '
        Me.Sonf3.BackColor = System.Drawing.Color.Purple
        Me.Sonf3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf3.ForeColor = System.Drawing.Color.Gold
        Me.Sonf3.Location = New System.Drawing.Point(928, 112)
        Me.Sonf3.Name = "Sonf3"
        Me.Sonf3.Size = New System.Drawing.Size(136, 72)
        Me.Sonf3.TabIndex = 110
        '
        'Sonf2
        '
        Me.Sonf2.BackColor = System.Drawing.Color.Purple
        Me.Sonf2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf2.ForeColor = System.Drawing.Color.Gold
        Me.Sonf2.Location = New System.Drawing.Point(776, 112)
        Me.Sonf2.Name = "Sonf2"
        Me.Sonf2.Size = New System.Drawing.Size(136, 72)
        Me.Sonf2.TabIndex = 109
        '
        'Sonf1
        '
        Me.Sonf1.BackColor = System.Drawing.Color.Purple
        Me.Sonf1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf1.ForeColor = System.Drawing.Color.Gold
        Me.Sonf1.Location = New System.Drawing.Point(624, 112)
        Me.Sonf1.Name = "Sonf1"
        Me.Sonf1.Size = New System.Drawing.Size(136, 72)
        Me.Sonf1.TabIndex = 108
        '
        'Sonf8
        '
        Me.Sonf8.BackColor = System.Drawing.Color.Purple
        Me.Sonf8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf8.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf8.ForeColor = System.Drawing.Color.Gold
        Me.Sonf8.Location = New System.Drawing.Point(1104, 232)
        Me.Sonf8.Name = "Sonf8"
        Me.Sonf8.Size = New System.Drawing.Size(136, 72)
        Me.Sonf8.TabIndex = 115
        '
        'Sonf7
        '
        Me.Sonf7.BackColor = System.Drawing.Color.Purple
        Me.Sonf7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf7.ForeColor = System.Drawing.Color.Gold
        Me.Sonf7.Location = New System.Drawing.Point(952, 232)
        Me.Sonf7.Name = "Sonf7"
        Me.Sonf7.Size = New System.Drawing.Size(136, 72)
        Me.Sonf7.TabIndex = 114
        '
        'Sonf6
        '
        Me.Sonf6.BackColor = System.Drawing.Color.Purple
        Me.Sonf6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf6.ForeColor = System.Drawing.Color.Gold
        Me.Sonf6.Location = New System.Drawing.Point(792, 232)
        Me.Sonf6.Name = "Sonf6"
        Me.Sonf6.Size = New System.Drawing.Size(136, 72)
        Me.Sonf6.TabIndex = 113
        '
        'Sonf5
        '
        Me.Sonf5.BackColor = System.Drawing.Color.Purple
        Me.Sonf5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf5.ForeColor = System.Drawing.Color.Gold
        Me.Sonf5.Location = New System.Drawing.Point(640, 232)
        Me.Sonf5.Name = "Sonf5"
        Me.Sonf5.Size = New System.Drawing.Size(136, 72)
        Me.Sonf5.TabIndex = 112
        '
        'Sonf12
        '
        Me.Sonf12.BackColor = System.Drawing.Color.Purple
        Me.Sonf12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf12.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf12.ForeColor = System.Drawing.Color.Gold
        Me.Sonf12.Location = New System.Drawing.Point(1104, 352)
        Me.Sonf12.Name = "Sonf12"
        Me.Sonf12.Size = New System.Drawing.Size(136, 72)
        Me.Sonf12.TabIndex = 119
        '
        'Sonf11
        '
        Me.Sonf11.BackColor = System.Drawing.Color.Purple
        Me.Sonf11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf11.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf11.ForeColor = System.Drawing.Color.Gold
        Me.Sonf11.Location = New System.Drawing.Point(952, 352)
        Me.Sonf11.Name = "Sonf11"
        Me.Sonf11.Size = New System.Drawing.Size(136, 72)
        Me.Sonf11.TabIndex = 118
        '
        'Sonf10
        '
        Me.Sonf10.BackColor = System.Drawing.Color.Purple
        Me.Sonf10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf10.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf10.ForeColor = System.Drawing.Color.Gold
        Me.Sonf10.Location = New System.Drawing.Point(792, 352)
        Me.Sonf10.Name = "Sonf10"
        Me.Sonf10.Size = New System.Drawing.Size(136, 72)
        Me.Sonf10.TabIndex = 117
        '
        'Sonf9
        '
        Me.Sonf9.BackColor = System.Drawing.Color.Purple
        Me.Sonf9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf9.ForeColor = System.Drawing.Color.Gold
        Me.Sonf9.Location = New System.Drawing.Point(640, 352)
        Me.Sonf9.Name = "Sonf9"
        Me.Sonf9.Size = New System.Drawing.Size(136, 72)
        Me.Sonf9.TabIndex = 116
        '
        'Sonf16
        '
        Me.Sonf16.BackColor = System.Drawing.Color.Purple
        Me.Sonf16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf16.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf16.ForeColor = System.Drawing.Color.Gold
        Me.Sonf16.Location = New System.Drawing.Point(1112, 472)
        Me.Sonf16.Name = "Sonf16"
        Me.Sonf16.Size = New System.Drawing.Size(136, 72)
        Me.Sonf16.TabIndex = 123
        '
        'Sonf15
        '
        Me.Sonf15.BackColor = System.Drawing.Color.Purple
        Me.Sonf15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf15.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf15.ForeColor = System.Drawing.Color.Gold
        Me.Sonf15.Location = New System.Drawing.Point(960, 472)
        Me.Sonf15.Name = "Sonf15"
        Me.Sonf15.Size = New System.Drawing.Size(136, 72)
        Me.Sonf15.TabIndex = 122
        '
        'Sonf14
        '
        Me.Sonf14.BackColor = System.Drawing.Color.Purple
        Me.Sonf14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf14.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf14.ForeColor = System.Drawing.Color.Gold
        Me.Sonf14.Location = New System.Drawing.Point(800, 472)
        Me.Sonf14.Name = "Sonf14"
        Me.Sonf14.Size = New System.Drawing.Size(136, 72)
        Me.Sonf14.TabIndex = 121
        '
        'Sonf13
        '
        Me.Sonf13.BackColor = System.Drawing.Color.Purple
        Me.Sonf13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf13.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf13.ForeColor = System.Drawing.Color.Gold
        Me.Sonf13.Location = New System.Drawing.Point(648, 472)
        Me.Sonf13.Name = "Sonf13"
        Me.Sonf13.Size = New System.Drawing.Size(136, 72)
        Me.Sonf13.TabIndex = 120
        '
        'Sonf20
        '
        Me.Sonf20.BackColor = System.Drawing.Color.Purple
        Me.Sonf20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf20.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf20.ForeColor = System.Drawing.Color.Gold
        Me.Sonf20.Location = New System.Drawing.Point(1112, 600)
        Me.Sonf20.Name = "Sonf20"
        Me.Sonf20.Size = New System.Drawing.Size(136, 72)
        Me.Sonf20.TabIndex = 127
        '
        'Sonf19
        '
        Me.Sonf19.BackColor = System.Drawing.Color.Purple
        Me.Sonf19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf19.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf19.ForeColor = System.Drawing.Color.Gold
        Me.Sonf19.Location = New System.Drawing.Point(960, 600)
        Me.Sonf19.Name = "Sonf19"
        Me.Sonf19.Size = New System.Drawing.Size(136, 72)
        Me.Sonf19.TabIndex = 126
        '
        'Sonf18
        '
        Me.Sonf18.BackColor = System.Drawing.Color.Purple
        Me.Sonf18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf18.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf18.ForeColor = System.Drawing.Color.Gold
        Me.Sonf18.Location = New System.Drawing.Point(800, 600)
        Me.Sonf18.Name = "Sonf18"
        Me.Sonf18.Size = New System.Drawing.Size(136, 72)
        Me.Sonf18.TabIndex = 125
        '
        'Sonf17
        '
        Me.Sonf17.BackColor = System.Drawing.Color.Purple
        Me.Sonf17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sonf17.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sonf17.ForeColor = System.Drawing.Color.Gold
        Me.Sonf17.Location = New System.Drawing.Point(648, 600)
        Me.Sonf17.Name = "Sonf17"
        Me.Sonf17.Size = New System.Drawing.Size(136, 72)
        Me.Sonf17.TabIndex = 124
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(792, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(248, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 128
        Me.PictureBox2.TabStop = False
        '
        'Price4
        '
        Me.Price4.Location = New System.Drawing.Point(1112, 184)
        Me.Price4.Name = "Price4"
        Me.Price4.Size = New System.Drawing.Size(32, 23)
        Me.Price4.TabIndex = 129
        Me.Price4.Text = "1"
        Me.Price4.Visible = False
        '
        'Price3
        '
        Me.Price3.Location = New System.Drawing.Point(968, 184)
        Me.Price3.Name = "Price3"
        Me.Price3.Size = New System.Drawing.Size(32, 23)
        Me.Price3.TabIndex = 130
        Me.Price3.Text = "2"
        Me.Price3.Visible = False
        '
        'Price2
        '
        Me.Price2.Location = New System.Drawing.Point(816, 184)
        Me.Price2.Name = "Price2"
        Me.Price2.Size = New System.Drawing.Size(32, 23)
        Me.Price2.TabIndex = 131
        Me.Price2.Text = "10"
        Me.Price2.Visible = False
        '
        'Price1
        '
        Me.Price1.Location = New System.Drawing.Point(680, 184)
        Me.Price1.Name = "Price1"
        Me.Price1.Size = New System.Drawing.Size(32, 23)
        Me.Price1.TabIndex = 132
        Me.Price1.Text = "5"
        Me.Price1.Visible = False
        '
        'Price8
        '
        Me.Price8.Location = New System.Drawing.Point(1152, 304)
        Me.Price8.Name = "Price8"
        Me.Price8.Size = New System.Drawing.Size(32, 23)
        Me.Price8.TabIndex = 133
        Me.Price8.Text = "1"
        Me.Price8.Visible = False
        '
        'Price7
        '
        Me.Price7.Location = New System.Drawing.Point(1000, 304)
        Me.Price7.Name = "Price7"
        Me.Price7.Size = New System.Drawing.Size(32, 23)
        Me.Price7.TabIndex = 134
        Me.Price7.Text = "1"
        Me.Price7.Visible = False
        '
        'Price6
        '
        Me.Price6.Location = New System.Drawing.Point(848, 304)
        Me.Price6.Name = "Price6"
        Me.Price6.Size = New System.Drawing.Size(32, 23)
        Me.Price6.TabIndex = 135
        Me.Price6.Text = "1"
        Me.Price6.Visible = False
        '
        'Price5
        '
        Me.Price5.Location = New System.Drawing.Point(696, 304)
        Me.Price5.Name = "Price5"
        Me.Price5.Size = New System.Drawing.Size(32, 23)
        Me.Price5.TabIndex = 136
        Me.Price5.Text = "1"
        Me.Price5.Visible = False
        '
        'Price12
        '
        Me.Price12.Location = New System.Drawing.Point(1152, 424)
        Me.Price12.Name = "Price12"
        Me.Price12.Size = New System.Drawing.Size(32, 23)
        Me.Price12.TabIndex = 137
        Me.Price12.Text = "1"
        Me.Price12.Visible = False
        '
        'Price11
        '
        Me.Price11.Location = New System.Drawing.Point(1000, 424)
        Me.Price11.Name = "Price11"
        Me.Price11.Size = New System.Drawing.Size(32, 23)
        Me.Price11.TabIndex = 138
        Me.Price11.Text = "1"
        Me.Price11.Visible = False
        '
        'Price10
        '
        Me.Price10.Location = New System.Drawing.Point(848, 424)
        Me.Price10.Name = "Price10"
        Me.Price10.Size = New System.Drawing.Size(32, 23)
        Me.Price10.TabIndex = 139
        Me.Price10.Text = "1"
        Me.Price10.Visible = False
        '
        'Price9
        '
        Me.Price9.Location = New System.Drawing.Point(688, 424)
        Me.Price9.Name = "Price9"
        Me.Price9.Size = New System.Drawing.Size(32, 23)
        Me.Price9.TabIndex = 140
        Me.Price9.Text = "1"
        Me.Price9.Visible = False
        '
        'Price16
        '
        Me.Price16.Location = New System.Drawing.Point(1160, 544)
        Me.Price16.Name = "Price16"
        Me.Price16.Size = New System.Drawing.Size(32, 23)
        Me.Price16.TabIndex = 141
        Me.Price16.Text = "1"
        Me.Price16.Visible = False
        '
        'Price15
        '
        Me.Price15.Location = New System.Drawing.Point(1016, 544)
        Me.Price15.Name = "Price15"
        Me.Price15.Size = New System.Drawing.Size(32, 23)
        Me.Price15.TabIndex = 142
        Me.Price15.Text = "1"
        Me.Price15.Visible = False
        '
        'Price14
        '
        Me.Price14.Location = New System.Drawing.Point(856, 544)
        Me.Price14.Name = "Price14"
        Me.Price14.Size = New System.Drawing.Size(32, 23)
        Me.Price14.TabIndex = 143
        Me.Price14.Text = "1"
        Me.Price14.Visible = False
        '
        'Price13
        '
        Me.Price13.Location = New System.Drawing.Point(704, 544)
        Me.Price13.Name = "Price13"
        Me.Price13.Size = New System.Drawing.Size(32, 23)
        Me.Price13.TabIndex = 144
        Me.Price13.Text = "1"
        Me.Price13.Visible = False
        '
        'Price20
        '
        Me.Price20.Location = New System.Drawing.Point(1160, 680)
        Me.Price20.Name = "Price20"
        Me.Price20.Size = New System.Drawing.Size(32, 23)
        Me.Price20.TabIndex = 145
        Me.Price20.Text = "1"
        Me.Price20.Visible = False
        '
        'Price19
        '
        Me.Price19.Location = New System.Drawing.Point(1008, 680)
        Me.Price19.Name = "Price19"
        Me.Price19.Size = New System.Drawing.Size(32, 23)
        Me.Price19.TabIndex = 146
        Me.Price19.Text = "1"
        Me.Price19.Visible = False
        '
        'Price18
        '
        Me.Price18.Location = New System.Drawing.Point(848, 680)
        Me.Price18.Name = "Price18"
        Me.Price18.Size = New System.Drawing.Size(32, 23)
        Me.Price18.TabIndex = 147
        Me.Price18.Text = "1"
        Me.Price18.Visible = False
        '
        'Price17
        '
        Me.Price17.Location = New System.Drawing.Point(704, 680)
        Me.Price17.Name = "Price17"
        Me.Price17.Size = New System.Drawing.Size(32, 23)
        Me.Price17.TabIndex = 148
        Me.Price17.Text = "1"
        Me.Price17.Visible = False
        '
        'Calc
        '
        Me.Calc.Location = New System.Drawing.Point(8, 184)
        Me.Calc.Name = "Calc"
        Me.Calc.Size = New System.Drawing.Size(32, 23)
        Me.Calc.TabIndex = 149
        Me.Calc.Text = "1"
        Me.Calc.Visible = False
        '
        'TableNo
        '
        Me.TableNo.BackColor = System.Drawing.Color.OliveDrab
        Me.TableNo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TableNo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TableNo.Location = New System.Drawing.Point(224, 16)
        Me.TableNo.Name = "TableNo"
        Me.TableNo.Size = New System.Drawing.Size(48, 24)
        Me.TableNo.TabIndex = 150
        Me.TableNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "Order"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.MappingName = "Expr1001"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.MappingName = "Price"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.CausesValidation = False
        Me.DataGrid1.ColumnHeadersVisible = False
        Me.DataGrid1.DataMember = "order"
        Me.DataGrid1.DataSource = Me.DataSet11
        Me.DataGrid1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 328)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(352, 280)
        Me.DataGrid1.TabIndex = 151
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Order"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.MappingName = "Order"
        Me.DataGridTextBoxColumn4.Width = 200
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "OrderQ"
        Me.DataGridTextBoxColumn5.Width = 60
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.MappingName = "Price"
        Me.DataGridTextBoxColumn6.Width = 60
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Order", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Order", "Order"), New System.Data.Common.DataColumnMapping("OrderQ", "OrderQ"), New System.Data.Common.DataColumnMapping("Price", "Price"), New System.Data.Common.DataColumnMapping("TableNo", "TableNo"), New System.Data.Common.DataColumnMapping("Cost", "Cost")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [Order] WHERE (ID = ?) AND (Cost = ? OR ? IS NULL AND Cost IS NULL) A" & _
        "ND ([Order] = ? OR ? IS NULL AND [Order] IS NULL) AND (OrderQ = ? OR ? IS NULL A" & _
        "ND OrderQ IS NULL) AND (Price = ? OR ? IS NULL AND Price IS NULL) AND (TableNo =" & _
        " ? OR ? IS NULL AND TableNo IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Order", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Order", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Order1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Order", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderQ", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderQ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderQ1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderQ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Price", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Price1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Price", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [Order] ([Order], OrderQ, Price, TableNo, Cost) VALUES (?, ?, ?, ?, ?" & _
        ")"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Order", System.Data.OleDb.OleDbType.VarWChar, 255, "Order"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderQ", System.Data.OleDb.OleDbType.Integer, 0, "OrderQ"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Integer, 0, "Price"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, "TableNo"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.Integer, 0, "Cost"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ID, [Order], OrderQ, Price, TableNo, Cost FROM [Order]"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [Order] SET [Order] = ?, OrderQ = ?, Price = ?, TableNo = ?, Cost = ? WHER" & _
        "E (ID = ?) AND (Cost = ? OR ? IS NULL AND Cost IS NULL) AND ([Order] = ? OR ? IS" & _
        " NULL AND [Order] IS NULL) AND (OrderQ = ? OR ? IS NULL AND OrderQ IS NULL) AND " & _
        "(Price = ? OR ? IS NULL AND Price IS NULL) AND (TableNo = ? OR ? IS NULL AND Tab" & _
        "leNo IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Order", System.Data.OleDb.OleDbType.VarWChar, 255, "Order"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderQ", System.Data.OleDb.OleDbType.Integer, 0, "OrderQ"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Integer, 0, "Price"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, "TableNo"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.Integer, 0, "Cost"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Order", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Order", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Order1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Order", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderQ", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderQ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderQ1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderQ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Price", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Price1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Price", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT [Order].* FROM [Order] WHERE (TableNo = ?)"
        Me.OleDbCommand1.Connection = Me.OleDbConnection1
        Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, "TableNo"))
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(64, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Item"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(192, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Quantity"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(272, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Price"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OleDbCommand2
        '
        Me.OleDbCommand2.CommandText = "SELECT SUM(Price) AS Expr1 FROM [Order] WHERE (TableNo = ?)"
        Me.OleDbCommand2.Connection = Me.OleDbConnection1
        Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, "TableNo"))
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Order", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Order", "Order"), New System.Data.Common.DataColumnMapping("OrderQ", "OrderQ"), New System.Data.Common.DataColumnMapping("Price", "Price"), New System.Data.Common.DataColumnMapping("TableNo", "TableNo"), New System.Data.Common.DataColumnMapping("Cost", "Cost")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM [Order] WHERE (ID = ?) AND (Cost = ? OR ? IS NULL AND Cost IS NULL) A" & _
        "ND ([Order] = ? OR ? IS NULL AND [Order] IS NULL) AND (OrderQ = ? OR ? IS NULL A" & _
        "ND OrderQ IS NULL) AND (Price = ? OR ? IS NULL AND Price IS NULL) AND (TableNo =" & _
        " ? OR ? IS NULL AND TableNo IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Order", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Order", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Order1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Order", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderQ", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderQ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderQ1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderQ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Price", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Price1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Price", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO [Order] ([Order], OrderQ, Price, TableNo, Cost) VALUES (?, ?, ?, ?, ?" & _
        ")"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Order", System.Data.OleDb.OleDbType.VarWChar, 255, "Order"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderQ", System.Data.OleDb.OleDbType.Integer, 0, "OrderQ"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Integer, 0, "Price"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, "TableNo"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.Integer, 0, "Cost"))
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT ID, [Order], OrderQ, Price, TableNo, Cost FROM [Order]"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE [Order] SET [Order] = ?, OrderQ = ?, Price = ?, TableNo = ?, Cost = ? WHER" & _
        "E (ID = ?) AND (Cost = ? OR ? IS NULL AND Cost IS NULL) AND ([Order] = ? OR ? IS" & _
        " NULL AND [Order] IS NULL) AND (OrderQ = ? OR ? IS NULL AND OrderQ IS NULL) AND " & _
        "(Price = ? OR ? IS NULL AND Price IS NULL) AND (TableNo = ? OR ? IS NULL AND Tab" & _
        "leNo IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Order", System.Data.OleDb.OleDbType.VarWChar, 255, "Order"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderQ", System.Data.OleDb.OleDbType.Integer, 0, "OrderQ"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Integer, 0, "Price"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, "TableNo"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.Integer, 0, "Cost"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Order", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Order", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Order1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Order", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderQ", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderQ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderQ1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderQ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Price", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Price1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Price", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        '
        'DataSet21
        '
        Me.DataSet21.DataSetName = "DataSet2"
        Me.DataSet21.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'kitchen1
        '
        Me.kitchen1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
        Me.kitchen1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        Me.kitchen1.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Upper
        Me.kitchen1.PrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
        '
        'OleDbDataAdapter3
        '
        Me.OleDbDataAdapter3.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapter3.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapter3.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cash", "Cash"), New System.Data.Common.DataColumnMapping("Cashier", "Cashier"), New System.Data.Common.DataColumnMapping("DateofBill", "DateofBill"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("TableNo", "TableNo"), New System.Data.Common.DataColumnMapping("TimeofBill", "TimeofBill"), New System.Data.Common.DataColumnMapping("Cost", "Cost")})})
        Me.OleDbDataAdapter3.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM Account WHERE (ID = ?) AND (Cash = ? OR ? IS NULL AND Cash IS NULL) A" & _
        "ND (Cashier = ? OR ? IS NULL AND Cashier IS NULL) AND (Cost = ? OR ? IS NULL AND" & _
        " Cost IS NULL) AND (DateofBill = ? OR ? IS NULL AND DateofBill IS NULL) AND (Tab" & _
        "leNo = ? OR ? IS NULL AND TableNo IS NULL) AND (TimeofBill = ? OR ? IS NULL AND " & _
        "TimeofBill IS NULL)"
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cash", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cash", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cash1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cash", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cashier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cashier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cashier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cashier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateofBill", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateofBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateofBill1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateofBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeofBill", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeofBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeofBill1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeofBill", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO Account(Cash, Cashier, DateofBill, TableNo, TimeofBill, Cost) VALUES " & _
        "(?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cash", System.Data.OleDb.OleDbType.Integer, 0, "Cash"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cashier", System.Data.OleDb.OleDbType.VarWChar, 255, "Cashier"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateofBill", System.Data.OleDb.OleDbType.DBDate, 0, "DateofBill"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, "TableNo"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeofBill", System.Data.OleDb.OleDbType.VarWChar, 255, "TimeofBill"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.Integer, 0, "Cost"))
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT Cash, Cashier, DateofBill, ID, TableNo, TimeofBill, Cost FROM Account"
        Me.OleDbSelectCommand3.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE Account SET Cash = ?, Cashier = ?, DateofBill = ?, TableNo = ?, TimeofBill" & _
        " = ?, Cost = ? WHERE (ID = ?) AND (Cash = ? OR ? IS NULL AND Cash IS NULL) AND (" & _
        "Cashier = ? OR ? IS NULL AND Cashier IS NULL) AND (Cost = ? OR ? IS NULL AND Cos" & _
        "t IS NULL) AND (DateofBill = ? OR ? IS NULL AND DateofBill IS NULL) AND (TableNo" & _
        " = ? OR ? IS NULL AND TableNo IS NULL) AND (TimeofBill = ? OR ? IS NULL AND Time" & _
        "ofBill IS NULL)"
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cash", System.Data.OleDb.OleDbType.Integer, 0, "Cash"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cashier", System.Data.OleDb.OleDbType.VarWChar, 255, "Cashier"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateofBill", System.Data.OleDb.OleDbType.DBDate, 0, "DateofBill"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, "TableNo"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeofBill", System.Data.OleDb.OleDbType.VarWChar, 255, "TimeofBill"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.Integer, 0, "Cost"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cash", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cash", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cash1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cash", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cashier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cashier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cashier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cashier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateofBill", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateofBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateofBill1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateofBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeofBill", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeofBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeofBill1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeofBill", System.Data.DataRowVersion.Original, Nothing))
        '
        'DataSet31
        '
        Me.DataSet31.DataSetName = "DataSet3"
        Me.DataSet31.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OleDbCommand4
        '
        Me.OleDbCommand4.CommandText = "DELETE FROM [Order] WHERE (TableNo = ?)"
        Me.OleDbCommand4.Connection = Me.OleDbConnection1
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter4
        '
        Me.OleDbDataAdapter4.DeleteCommand = Me.OleDbDeleteCommand4
        Me.OleDbDataAdapter4.InsertCommand = Me.OleDbInsertCommand4
        Me.OleDbDataAdapter4.SelectCommand = Me.OleDbSelectCommand4
        Me.OleDbDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "History", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cost", "Cost"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Order", "Order"), New System.Data.Common.DataColumnMapping("OrderQ", "OrderQ"), New System.Data.Common.DataColumnMapping("Price", "Price"), New System.Data.Common.DataColumnMapping("TableNo", "TableNo"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate")})})
        Me.OleDbDataAdapter4.UpdateCommand = Me.OleDbUpdateCommand4
        '
        'OleDbDeleteCommand4
        '
        Me.OleDbDeleteCommand4.CommandText = "DELETE FROM History WHERE (ID = ?) AND (Cost = ? OR ? IS NULL AND Cost IS NULL) A" & _
        "ND ([Order] = ? OR ? IS NULL AND [Order] IS NULL) AND (OrderDate = ? OR ? IS NUL" & _
        "L AND OrderDate IS NULL) AND (OrderQ = ? OR ? IS NULL AND OrderQ IS NULL) AND (P" & _
        "rice = ? OR ? IS NULL AND Price IS NULL) AND (TableNo = ? OR ? IS NULL AND Table" & _
        "No IS NULL)"
        Me.OleDbDeleteCommand4.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Order", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Order", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Order1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Order", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderQ", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderQ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderQ1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderQ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Price", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Price1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Price", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand4
        '
        Me.OleDbInsertCommand4.CommandText = "INSERT INTO History(Cost, [Order], OrderQ, Price, TableNo, OrderDate) VALUES (?, " & _
        "?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand4.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.Integer, 0, "Cost"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Order", System.Data.OleDb.OleDbType.VarWChar, 255, "Order"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderQ", System.Data.OleDb.OleDbType.Integer, 0, "OrderQ"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Integer, 0, "Price"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, "TableNo"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"))
        '
        'OleDbSelectCommand4
        '
        Me.OleDbSelectCommand4.CommandText = "SELECT Cost, ID, [Order], OrderQ, Price, TableNo, OrderDate FROM History"
        Me.OleDbSelectCommand4.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand4
        '
        Me.OleDbUpdateCommand4.CommandText = "UPDATE History SET Cost = ?, [Order] = ?, OrderQ = ?, Price = ?, TableNo = ?, Ord" & _
        "erDate = ? WHERE (ID = ?) AND (Cost = ? OR ? IS NULL AND Cost IS NULL) AND ([Ord" & _
        "er] = ? OR ? IS NULL AND [Order] IS NULL) AND (OrderDate = ? OR ? IS NULL AND Or" & _
        "derDate IS NULL) AND (OrderQ = ? OR ? IS NULL AND OrderQ IS NULL) AND (Price = ?" & _
        " OR ? IS NULL AND Price IS NULL) AND (TableNo = ? OR ? IS NULL AND TableNo IS NU" & _
        "LL)"
        Me.OleDbUpdateCommand4.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.Integer, 0, "Cost"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Order", System.Data.OleDb.OleDbType.VarWChar, 255, "Order"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderQ", System.Data.OleDb.OleDbType.Integer, 0, "OrderQ"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Integer, 0, "Price"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, "TableNo"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cost1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Order", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Order", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Order1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Order", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderQ", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderQ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderQ1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderQ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Price", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Price1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Price", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TableNo1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TableNo", System.Data.DataRowVersion.Original, Nothing))
        '
        'DataSet41
        '
        Me.DataSet41.DataSetName = "DataSet4"
        Me.DataSet41.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Cost1
        '
        Me.Cost1.Location = New System.Drawing.Point(704, 184)
        Me.Cost1.Name = "Cost1"
        Me.Cost1.Size = New System.Drawing.Size(22, 23)
        Me.Cost1.TabIndex = 156
        Me.Cost1.Text = "2"
        Me.Cost1.Visible = False
        '
        'Cost2
        '
        Me.Cost2.Location = New System.Drawing.Point(848, 184)
        Me.Cost2.Name = "Cost2"
        Me.Cost2.Size = New System.Drawing.Size(22, 23)
        Me.Cost2.TabIndex = 157
        Me.Cost2.Text = "3"
        Me.Cost2.Visible = False
        '
        'Cost3
        '
        Me.Cost3.Location = New System.Drawing.Point(992, 184)
        Me.Cost3.Name = "Cost3"
        Me.Cost3.Size = New System.Drawing.Size(22, 23)
        Me.Cost3.TabIndex = 158
        Me.Cost3.Text = "1"
        Me.Cost3.Visible = False
        '
        'Cost4
        '
        Me.Cost4.Location = New System.Drawing.Point(1136, 184)
        Me.Cost4.Name = "Cost4"
        Me.Cost4.Size = New System.Drawing.Size(22, 23)
        Me.Cost4.TabIndex = 159
        Me.Cost4.Text = "1"
        Me.Cost4.Visible = False
        '
        'Cost5
        '
        Me.Cost5.Location = New System.Drawing.Point(720, 304)
        Me.Cost5.Name = "Cost5"
        Me.Cost5.Size = New System.Drawing.Size(22, 23)
        Me.Cost5.TabIndex = 160
        Me.Cost5.Text = "1"
        Me.Cost5.Visible = False
        '
        'Cost6
        '
        Me.Cost6.Location = New System.Drawing.Point(880, 304)
        Me.Cost6.Name = "Cost6"
        Me.Cost6.Size = New System.Drawing.Size(22, 23)
        Me.Cost6.TabIndex = 161
        Me.Cost6.Text = "1"
        Me.Cost6.Visible = False
        '
        'Cost7
        '
        Me.Cost7.Location = New System.Drawing.Point(1040, 304)
        Me.Cost7.Name = "Cost7"
        Me.Cost7.Size = New System.Drawing.Size(22, 23)
        Me.Cost7.TabIndex = 162
        Me.Cost7.Text = "1"
        Me.Cost7.Visible = False
        '
        'Cost8
        '
        Me.Cost8.Location = New System.Drawing.Point(1184, 304)
        Me.Cost8.Name = "Cost8"
        Me.Cost8.Size = New System.Drawing.Size(16, 23)
        Me.Cost8.TabIndex = 163
        Me.Cost8.Text = "1"
        Me.Cost8.Visible = False
        '
        'Cost9
        '
        Me.Cost9.Location = New System.Drawing.Point(728, 424)
        Me.Cost9.Name = "Cost9"
        Me.Cost9.Size = New System.Drawing.Size(22, 23)
        Me.Cost9.TabIndex = 164
        Me.Cost9.Text = "1"
        Me.Cost9.Visible = False
        '
        'Cost10
        '
        Me.Cost10.Location = New System.Drawing.Point(872, 424)
        Me.Cost10.Name = "Cost10"
        Me.Cost10.Size = New System.Drawing.Size(22, 23)
        Me.Cost10.TabIndex = 165
        Me.Cost10.Text = "1"
        Me.Cost10.Visible = False
        '
        'Cost11
        '
        Me.Cost11.Location = New System.Drawing.Point(1032, 424)
        Me.Cost11.Name = "Cost11"
        Me.Cost11.Size = New System.Drawing.Size(22, 23)
        Me.Cost11.TabIndex = 166
        Me.Cost11.Text = "1"
        Me.Cost11.Visible = False
        '
        'Cost12
        '
        Me.Cost12.Location = New System.Drawing.Point(1184, 424)
        Me.Cost12.Name = "Cost12"
        Me.Cost12.Size = New System.Drawing.Size(22, 23)
        Me.Cost12.TabIndex = 167
        Me.Cost12.Text = "1"
        Me.Cost12.Visible = False
        '
        'Cost13
        '
        Me.Cost13.Location = New System.Drawing.Point(736, 544)
        Me.Cost13.Name = "Cost13"
        Me.Cost13.Size = New System.Drawing.Size(22, 23)
        Me.Cost13.TabIndex = 168
        Me.Cost13.Text = "1"
        Me.Cost13.Visible = False
        '
        'Cost14
        '
        Me.Cost14.Location = New System.Drawing.Point(880, 544)
        Me.Cost14.Name = "Cost14"
        Me.Cost14.Size = New System.Drawing.Size(22, 23)
        Me.Cost14.TabIndex = 169
        Me.Cost14.Text = "1"
        Me.Cost14.Visible = False
        '
        'Cost15
        '
        Me.Cost15.Location = New System.Drawing.Point(1048, 544)
        Me.Cost15.Name = "Cost15"
        Me.Cost15.Size = New System.Drawing.Size(22, 23)
        Me.Cost15.TabIndex = 170
        Me.Cost15.Text = "1"
        Me.Cost15.Visible = False
        '
        'Cost16
        '
        Me.Cost16.Location = New System.Drawing.Point(1192, 544)
        Me.Cost16.Name = "Cost16"
        Me.Cost16.Size = New System.Drawing.Size(22, 23)
        Me.Cost16.TabIndex = 171
        Me.Cost16.Text = "1"
        Me.Cost16.Visible = False
        '
        'Cost17
        '
        Me.Cost17.Location = New System.Drawing.Point(728, 680)
        Me.Cost17.Name = "Cost17"
        Me.Cost17.Size = New System.Drawing.Size(22, 23)
        Me.Cost17.TabIndex = 172
        Me.Cost17.Text = "1"
        Me.Cost17.Visible = False
        '
        'Cost18
        '
        Me.Cost18.Location = New System.Drawing.Point(880, 680)
        Me.Cost18.Name = "Cost18"
        Me.Cost18.Size = New System.Drawing.Size(22, 23)
        Me.Cost18.TabIndex = 173
        Me.Cost18.Text = "1"
        Me.Cost18.Visible = False
        '
        'Cost19
        '
        Me.Cost19.Location = New System.Drawing.Point(1048, 680)
        Me.Cost19.Name = "Cost19"
        Me.Cost19.Size = New System.Drawing.Size(22, 23)
        Me.Cost19.TabIndex = 174
        Me.Cost19.Text = "1"
        Me.Cost19.Visible = False
        '
        'Cost20
        '
        Me.Cost20.Location = New System.Drawing.Point(1184, 680)
        Me.Cost20.Name = "Cost20"
        Me.Cost20.Size = New System.Drawing.Size(22, 23)
        Me.Cost20.TabIndex = 175
        Me.Cost20.Text = "1"
        Me.Cost20.Visible = False
        '
        'OleDbCommand5
        '
        Me.OleDbCommand5.CommandText = "SELECT SUM(Cost) AS Expr1 FROM [Order] WHERE (TableNo = ?)"
        Me.OleDbCommand5.Connection = Me.OleDbConnection1
        Me.OleDbCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TableNo", System.Data.OleDb.OleDbType.VarWChar, 255, "TableNo"))
        '
        'Button42
        '
        Me.Button42.BackColor = System.Drawing.Color.Peru
        Me.Button42.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button42.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button42.Location = New System.Drawing.Point(296, 720)
        Me.Button42.Name = "Button42"
        Me.Button42.Size = New System.Drawing.Size(48, 16)
        Me.Button42.TabIndex = 176
        Me.Button42.Visible = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1292, 788)
        Me.Controls.Add(Me.Cost20)
        Me.Controls.Add(Me.Cost19)
        Me.Controls.Add(Me.Cost18)
        Me.Controls.Add(Me.Cost17)
        Me.Controls.Add(Me.Cost16)
        Me.Controls.Add(Me.Cost15)
        Me.Controls.Add(Me.Cost14)
        Me.Controls.Add(Me.Cost13)
        Me.Controls.Add(Me.Cost12)
        Me.Controls.Add(Me.Cost11)
        Me.Controls.Add(Me.Cost10)
        Me.Controls.Add(Me.Cost9)
        Me.Controls.Add(Me.Cost8)
        Me.Controls.Add(Me.Cost7)
        Me.Controls.Add(Me.Cost6)
        Me.Controls.Add(Me.Cost5)
        Me.Controls.Add(Me.Cost4)
        Me.Controls.Add(Me.Cost3)
        Me.Controls.Add(Me.Cost2)
        Me.Controls.Add(Me.Cost1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button35)
        Me.Controls.Add(Me.Button37)
        Me.Controls.Add(Me.Button36)
        Me.Controls.Add(Me.Button42)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.TableNo)
        Me.Controls.Add(Me.Calc)
        Me.Controls.Add(Me.Price17)
        Me.Controls.Add(Me.Price18)
        Me.Controls.Add(Me.Price19)
        Me.Controls.Add(Me.Price20)
        Me.Controls.Add(Me.Price13)
        Me.Controls.Add(Me.Price14)
        Me.Controls.Add(Me.Price15)
        Me.Controls.Add(Me.Price16)
        Me.Controls.Add(Me.Price9)
        Me.Controls.Add(Me.Price10)
        Me.Controls.Add(Me.Price11)
        Me.Controls.Add(Me.Price12)
        Me.Controls.Add(Me.Price5)
        Me.Controls.Add(Me.Price6)
        Me.Controls.Add(Me.Price7)
        Me.Controls.Add(Me.Price8)
        Me.Controls.Add(Me.Price1)
        Me.Controls.Add(Me.Price2)
        Me.Controls.Add(Me.Price3)
        Me.Controls.Add(Me.Price4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Sonf20)
        Me.Controls.Add(Me.Sonf19)
        Me.Controls.Add(Me.Sonf18)
        Me.Controls.Add(Me.Sonf17)
        Me.Controls.Add(Me.Sonf16)
        Me.Controls.Add(Me.Sonf15)
        Me.Controls.Add(Me.Sonf14)
        Me.Controls.Add(Me.Sonf13)
        Me.Controls.Add(Me.Sonf12)
        Me.Controls.Add(Me.Sonf11)
        Me.Controls.Add(Me.Sonf10)
        Me.Controls.Add(Me.Sonf9)
        Me.Controls.Add(Me.Sonf8)
        Me.Controls.Add(Me.Sonf7)
        Me.Controls.Add(Me.Sonf6)
        Me.Controls.Add(Me.Sonf5)
        Me.Controls.Add(Me.Sonf4)
        Me.Controls.Add(Me.Sonf3)
        Me.Controls.Add(Me.Sonf2)
        Me.Controls.Add(Me.Sonf1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet41, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Declare Function Beep Lib "kernel32" (ByVal soundf As Int32, ByVal soundd As Int32) As Int32


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tableColor()
        Shawrma()

    End Sub

    Sub buttoncolor()
        Me.Button9.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button8.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button7.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button11.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button12.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button14.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button15.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button16.BackColor = System.Drawing.Color.RoyalBlue

    End Sub


    Sub tableColor()
        Try

            Me.DataSet21.Clear()

            Me.OleDbDataAdapter2.Fill(Me.DataSet21)
            Dim x As DataRow()
            x = Me.DataSet21.Order.Select("TableNo='1'")
            If x.Length > 0 Then
                Me.Button10.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button10.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='2'")
            If x.Length > 0 Then
                Me.Button13.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button13.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='3'")
            If x.Length > 0 Then
                Me.Button23.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button23.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='4'")
            If x.Length > 0 Then
                Me.Button24.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button24.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='5'")
            If x.Length > 0 Then
                Me.Button25.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button25.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='6'")
            If x.Length > 0 Then
                Me.Button30.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button30.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='7'")
            If x.Length > 0 Then
                Me.Button29.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button29.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='8'")
            If x.Length > 0 Then
                Me.Button28.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button28.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='9'")
            If x.Length > 0 Then
                Me.Button27.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button27.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='10'")
            If x.Length > 0 Then
                Me.Button26.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button26.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='11'")
            If x.Length > 0 Then
                Me.Button31.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button31.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='12'")
            If x.Length > 0 Then
                Me.Button32.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button32.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='13'")
            If x.Length > 0 Then
                Me.Button33.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button33.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='14'")
            If x.Length > 0 Then
                Me.Button34.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button34.BackColor = System.Drawing.Color.PapayaWhip
            End If

            x = Me.DataSet21.Order.Select("TableNo='15'")
            If x.Length > 0 Then
                Me.Button38.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button38.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='16'")
            If x.Length > 0 Then
                Me.Button39.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button39.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='17'")
            If x.Length > 0 Then
                Me.Button40.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button40.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='18'")
            If x.Length > 0 Then
                Me.Button43.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button43.BackColor = System.Drawing.Color.PapayaWhip
            End If
            x = Me.DataSet21.Order.Select("TableNo='19'")
            If x.Length > 0 Then
                Me.Button44.BackColor = System.Drawing.Color.DeepPink
            Else
                Me.Button44.BackColor = System.Drawing.Color.PapayaWhip
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub data()

        Try

            Dim x As String = Me.TableNo.Text

            Me.OleDbConnection1.Open()

            Me.OleDbCommand1.Parameters(0).Value = x

            Me.OleDbDataAdapter1.SelectCommand = Me.OleDbCommand1
            Me.OleDbCommand1.ExecuteScalar()

            Me.OleDbDataAdapter1.Fill(Me.DataSet11)
            Me.OleDbConnection1.Close()

            total()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Me.GroupBox1.Visible = False Then

            Me.GroupBox1.Visible = True
            tableColor()
            Shawrma()


        Else
            tableColor()

        End If


    End Sub

    Sub total()

        Try
            Me.OleDbConnection1.Open()
            Me.OleDbCommand2.Parameters(0).Value = Me.TableNo.Text
            Me.Label2.Text = Me.OleDbCommand2.ExecuteScalar.ToString
            Me.OleDbConnection1.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'System.Drawing.Color.RoyalBlue()
        Me.Calc.Text = Me.Button9.Text
        buttoncolor()
        Me.Button9.BackColor = System.Drawing.Color.Red

    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Calc.Text = Me.Button8.Text
        buttoncolor()
        Me.Button8.BackColor = System.Drawing.Color.Red

    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Calc.Text = Me.Button7.Text
        buttoncolor()
        Me.Button7.BackColor = System.Drawing.Color.Red
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Calc.Text = Me.Button6.Text
        buttoncolor()
        Me.Button6.BackColor = System.Drawing.Color.Red
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Calc.Text = Me.Button11.Text
        buttoncolor()
        Me.Button11.BackColor = System.Drawing.Color.Red
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Calc.Text = Me.Button12.Text
        buttoncolor()
        Me.Button12.BackColor = System.Drawing.Color.Red
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Me.Calc.Text = Me.Button14.Text
        buttoncolor()
        Me.Button14.BackColor = System.Drawing.Color.Red
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Me.Calc.Text = Me.Button15.Text
        buttoncolor()
        Me.Button15.BackColor = System.Drawing.Color.Red
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Me.Calc.Text = Me.Button16.Text
        buttoncolor()
        Me.Button16.BackColor = System.Drawing.Color.Red
    End Sub

    Private Sub Sonf1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf1.Click
        Try

            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf1.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price1.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost1.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"

    End Sub

    Private Sub Sonf2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf2.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf2.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price2.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost2.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf3.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf3.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price3.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost3.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf4.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf4.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price4.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost4.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf5.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf5.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price5.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost5.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf6.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf6.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price6.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost6.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf7.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf7.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price7.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost7.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf8.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf8.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price8.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost8.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf9.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf9.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price9.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost9.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf10.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf10.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price10.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost10.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf11.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf11.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price11.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost11.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf12.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf12.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price12.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost12.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf13.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf13.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price13.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost13.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf14.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf14.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price14.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost14.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf15.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf15.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price15.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost15.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf16.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf16.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price16.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost16.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf17.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf17.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price17.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost17.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf18.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf18.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price18.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost18.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf19.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf19.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price19.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost19.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Sonf20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sonf20.Click
        Try
            Me.DataSet11.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSet11)

            Dim row As DataRow = Me.DataSet11.Order.NewRow()
            row(1) = Me.Sonf20.Text
            row(2) = Me.Calc.Text
            row(3) = Me.Calc.Text.ToString * Me.Price20.Text.ToString
            row(4) = Me.TableNo.Text
            row(5) = Me.Calc.Text.ToString * Me.Cost20.Text.ToString
            Me.DataSet11.Order.Rows.Add(row)

            Me.OleDbDataAdapter1.Update(Me.DataSet11)
            total()
            buttoncolor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Calc.Text = "1"
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        'Try
        '    Me.DataSet11.Clear()
        '    data()
        '    Me.BindingContext(DataSet11, "order").RemoveAt(Me.DataSet11.Order.Count - 1)
        '    Me.OleDbDataAdapter1.Update(Me.DataSet11)
        '    total()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        Try
            If Me.DataSet11.Order.Rows.Count > 0 Then
                Dim cryRpt As New ReportDocument
                cryRpt.Load("D:\papai project\Bill.rpt")

                Dim crParameterFieldDefinitions As ParameterFieldDefinitions
                Dim crParameterFieldDefinition As ParameterFieldDefinition
                Dim crParameterValues As New ParameterValues
                Dim crParameterDiscreteValue As New ParameterDiscreteValue

                crParameterDiscreteValue.Value = Me.TableNo.Text
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields()
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("Table")
                crParameterValues = crParameterFieldDefinition.CurrentValues

                crParameterValues.Clear()
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                CrystalReportViewer1.ReportSource = cryRpt
                CrystalReportViewer1.Refresh()
                cryRpt.PrintToPrinter(1, True, 0, 0)


                'Close Table:

                'Send Summary to Account
                Me.OleDbConnection1.Open()
                Me.OleDbCommand5.Parameters(0).Value = Me.TableNo.Text
                Dim totalcost As Integer
                totalcost = Me.OleDbCommand5.ExecuteScalar()
                Me.OleDbConnection1.Close()

                Me.OleDbDataAdapter3.Fill(Me.DataSet31)
                Dim roww As DataRow = Me.DataSet31.Account.NewRow()
                roww(0) = Me.Label2.Text
                roww(2) = Now.Date
                roww(4) = Me.TableNo.Text
                roww(5) = Now.TimeOfDay.Hours & ":" & Now.TimeOfDay.Minutes
                roww(6) = totalcost
                Me.DataSet31.Account.Rows.Add(roww)
                Me.OleDbDataAdapter3.Update(Me.DataSet31)



                'Move records to History
                'Me.OleDbDataAdapter4.Fill(Me.DataSet41)
                'Dim dr As DataRow
                'For Each dr In Me.DataSet11.Order.Rows
                '    Dim row As DataRow = Me.DataSet41.History.NewRow()
                '    row(2) = dr(1)
                '    row(3) = dr(2)
                '    row(4) = dr(3)
                '    row(5) = dr(4)
                '    row(6) = Now.Date
                '    row(0) = dr(5)
                '    Me.DataSet41.History.Rows.Add(row)
                'Next
                'Me.OleDbDataAdapter4.Update(Me.DataSet41)


                'Delete Table records
                Me.OleDbConnection1.Open()
                Me.OleDbCommand4.Parameters(0).Value = Me.TableNo.Text
                Me.OleDbCommand4.ExecuteScalar()
                Me.OleDbConnection1.Close()
                Me.OleDbDataAdapter1.Update(Me.DataSet11)
                Me.GroupBox1.Visible = True
                tableColor()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try






    End Sub




    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.TableNo.Text = "1"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()


    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.TableNo.Text = "2"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Me.TableNo.Text = "3"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Me.TableNo.Text = "4"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Me.TableNo.Text = "5"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Me.TableNo.Text = "6"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Me.TableNo.Text = "7"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Me.TableNo.Text = "8"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Me.TableNo.Text = "9"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Me.TableNo.Text = "10"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    


    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        Me.TableNo.Text = "Out"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Try


            If Me.DataSet11.Order.Rows.Count > 0 Then

                Dim cryRpt As New ReportDocument
                cryRpt.Load("D:\papai project\Kitchen.rpt")

                Dim crParameterFieldDefinitions As ParameterFieldDefinitions
                Dim crParameterFieldDefinition As ParameterFieldDefinition
                Dim crParameterValues As New ParameterValues
                Dim crParameterDiscreteValue As New ParameterDiscreteValue

                crParameterDiscreteValue.Value = Me.TableNo.Text
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields()
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("Table")
                crParameterValues = crParameterFieldDefinition.CurrentValues

                crParameterValues.Clear()
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                CrystalReportViewer1.ReportSource = cryRpt
                CrystalReportViewer1.Refresh()

                cryRpt.PrintToPrinter(1, True, 0, 0)
                'Me.GroupBox1.Visible = True
                ' tableColor()
                ' Beep(1000, 800)
                '  Beep(1000, 800)


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Try
            If Me.DataSet11.Order.Rows.Count > 0 Then
                Dim cryRpt As New ReportDocument
                cryRpt.Load("D:\papai project\Bill.rpt")

                Dim crParameterFieldDefinitions As ParameterFieldDefinitions
                Dim crParameterFieldDefinition As ParameterFieldDefinition
                Dim crParameterValues As New ParameterValues
                Dim crParameterDiscreteValue As New ParameterDiscreteValue

                crParameterDiscreteValue.Value = Me.TableNo.Text
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields()
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("Table")
                crParameterValues = crParameterFieldDefinition.CurrentValues

                crParameterValues.Clear()
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                CrystalReportViewer1.ReportSource = cryRpt
                CrystalReportViewer1.Refresh()
                cryRpt.PrintToPrinter(1, True, 0, 0)


                'Close Table:

                'Send Summary to Account
                Me.OleDbConnection1.Open()
                Me.OleDbCommand5.Parameters(0).Value = Me.TableNo.Text
                Dim totalcost As Integer
                totalcost = Me.OleDbCommand5.ExecuteScalar()
                Me.OleDbConnection1.Close()

                Me.OleDbDataAdapter3.Fill(Me.DataSet31)
                Dim roww As DataRow = Me.DataSet31.Account.NewRow()
                roww(0) = Me.Label2.Text
                roww(2) = Now.Date
                roww(4) = Me.TableNo.Text
                roww(5) = Now.TimeOfDay.Hours & ":" & Now.TimeOfDay.Minutes
                roww(6) = totalcost
                Me.DataSet31.Account.Rows.Add(roww)
                Me.OleDbDataAdapter3.Update(Me.DataSet31)



                'Move records to History
                Me.OleDbDataAdapter4.Fill(Me.DataSet41)
                Dim dr As DataRow
                For Each dr In Me.DataSet11.Order.Rows
                    Dim row As DataRow = Me.DataSet41.History.NewRow()
                    row(2) = dr(1)
                    row(3) = dr(2)
                    row(4) = dr(3)
                    row(5) = dr(4)
                    row(6) = Now.Date
                    row(0) = dr(5)
                    Me.DataSet41.History.Rows.Add(row)
                Next
                Me.OleDbDataAdapter4.Update(Me.DataSet41)


                'Delete Table records
                Me.OleDbConnection1.Open()
                Me.OleDbCommand4.Parameters(0).Value = Me.TableNo.Text
                Me.OleDbCommand4.ExecuteScalar()
                Me.OleDbConnection1.Close()
                Me.OleDbDataAdapter1.Update(Me.DataSet11)
                Me.GroupBox1.Visible = True
                tableColor()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If InputBox("Security Password", "Stop", "#") = "opp" Then
            Dim x As New Accounts
            x.Show()
        End If
    End Sub

    Sub Shawrma()
        Try
            Me.Sonf1.Text = "Small-Shawrma"
            Me.Price1.Text = "5"
            Me.Cost1.Text = "0"

            Me.Sonf2.Text = "Arabian-Shawrma"
            Me.Price2.Text = "15"
            Me.Cost2.Text = "0"

            Me.Sonf3.Text = "French-Shawrma"
            Me.Price3.Text = "10"
            Me.Cost3.Text = "0"

            Me.Sonf4.Text = "Papai-Shawrma"
            Me.Price4.Text = "12"
            Me.Cost4.Text = "0"

            Me.Sonf5.Text = "Paratha-Shawrma"
            Me.Price5.Text = "7"
            Me.Cost5.Text = "0"

            Me.Sonf6.Text = "Shawrma Platter"
            Me.Price6.Text = "20"
            Me.Cost6.Text = "0"

            Me.Sonf7.Text = "Shawrma Humus"
            Me.Price7.Text = "25"
            Me.Cost7.Text = "0"

            Me.Sonf8.Text = ""
            Me.Price8.Text = ""
            Me.Cost8.Text = "0"

            Me.Sonf9.Text = ""
            Me.Price9.Text = ""
            Me.Cost9.Text = "0"

            Me.Sonf10.Text = ""
            Me.Price10.Text = ""
            Me.Cost10.Text = "0"

            Me.Sonf11.Text = ""
            Me.Price11.Text = ""
            Me.Cost11.Text = "0"

            Me.Sonf12.Text = ""
            Me.Price12.Text = ""
            Me.Cost12.Text = ""

            Me.Sonf13.Text = ""
            Me.Price13.Text = ""
            Me.Cost13.Text = ""

            Me.Sonf14.Text = ""
            Me.Price14.Text = ""
            Me.Cost14.Text = ""

            Me.Sonf15.Text = ""
            Me.Price15.Text = ""
            Me.Cost15.Text = ""

            Me.Sonf16.Text = ""
            Me.Price16.Text = ""
            Me.Cost16.Text = ""

            Me.Sonf17.Text = ""
            Me.Price17.Text = ""
            Me.Cost17.Text = ""

            Me.Sonf18.Text = ""
            Me.Price18.Text = ""
            Me.Cost18.Text = ""

            Me.Sonf19.Text = ""
            Me.Price19.Text = ""
            Me.Cost19.Text = ""

            Me.Sonf20.Text = ""
            Me.Price20.Text = ""
            Me.Cost20.Text = ""

            Me.Sonf1.Visible = True
            Me.Sonf2.Visible = True
            Me.Sonf3.Visible = True
            Me.Sonf4.Visible = True
            Me.Sonf5.Visible = True
            Me.Sonf6.Visible = True
            Me.Sonf7.Visible = True
            Me.Sonf8.Visible = False
            Me.Sonf9.Visible = False
            Me.Sonf10.Visible = False
            Me.Sonf11.Visible = False
            Me.Sonf12.Visible = False
            Me.Sonf13.Visible = False
            Me.Sonf14.Visible = False
            Me.Sonf15.Visible = False
            Me.Sonf16.Visible = False
            Me.Sonf17.Visible = False
            Me.Sonf18.Visible = False
            Me.Sonf19.Visible = False
            Me.Sonf20.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Shawrma()

    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        Me.Close()

    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Me.Sonf1.Text = "Ch-Burger"
            Me.Price1.Text = "8"
            Me.Cost1.Text = "0"

            Me.Sonf2.Text = "Beef-Burger"
            Me.Price2.Text = "9"
            Me.Cost2.Text = "0"


            Me.Sonf3.Text = "Mushroom BBQ"
            Me.Price3.Text = "12"
            Me.Cost3.Text = "0"

            Me.Sonf4.Text = "Papai-Burger"
            Me.Price4.Text = "15"
            Me.Cost4.Text = "0"


            Me.Sonf5.Text = "Arabica Burger"
            Me.Price5.Text = "13"
            Me.Cost5.Text = "0"


            ''


            Me.Sonf6.Text = ""
            Me.Price6.Text = ""
            Me.Cost6.Text = "0"

            Me.Sonf7.Text = ""
            Me.Price7.Text = ""
            Me.Cost7.Text = "0"

            Me.Sonf8.Text = ""
            Me.Price8.Text = ""
            Me.Cost8.Text = "0"

            Me.Sonf9.Text = "Peporoni-Pizza"
            Me.Price9.Text = "25"
            Me.Cost9.Text = "0"

            Me.Sonf10.Text = "Shawrma-Pizza"
            Me.Price10.Text = "25"
            Me.Cost10.Text = "0"

            Me.Sonf11.Text = "Veg-Pizza"
            Me.Price11.Text = "25"
            Me.Cost11.Text = "0"

            Me.Sonf12.Text = "4season-Pizza"
            Me.Price12.Text = "25"
            Me.Cost12.Text = "0"

            Me.Sonf13.Text = ""
            Me.Price13.Text = ""
            Me.Cost13.Text = "0"

            Me.Sonf14.Text = ""
            Me.Price14.Text = ""
            Me.Cost14.Text = "0"

            Me.Sonf15.Text = ""
            Me.Price15.Text = ""
            Me.Cost15.Text = "0"

            Me.Sonf16.Text = ""
            Me.Price16.Text = ""
            Me.Cost16.Text = "0"

            Me.Sonf17.Text = ""
            Me.Price17.Text = ""
            Me.Cost17.Text = ""

            Me.Sonf18.Text = ""
            Me.Price18.Text = ""
            Me.Cost18.Text = ""

            Me.Sonf19.Text = ""
            Me.Price19.Text = ""
            Me.Cost19.Text = ""

            Me.Sonf20.Text = ""
            Me.Price20.Text = ""
            Me.Cost20.Text = ""

            Me.Sonf1.Visible = True
            Me.Sonf2.Visible = True
            Me.Sonf3.Visible = True
            Me.Sonf4.Visible = True
            Me.Sonf5.Visible = True
            Me.Sonf6.Visible = False
            Me.Sonf7.Visible = False
            Me.Sonf8.Visible = False
            Me.Sonf9.Visible = True
            Me.Sonf10.Visible = True
            Me.Sonf11.Visible = True
            Me.Sonf12.Visible = True
            Me.Sonf13.Visible = False
            Me.Sonf14.Visible = False
            Me.Sonf15.Visible = False
            Me.Sonf16.Visible = False
            Me.Sonf17.Visible = False
            Me.Sonf18.Visible = False
            Me.Sonf19.Visible = False
            Me.Sonf20.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Me.Sonf1.Text = "Ch-Machine"
            Me.Price1.Text = "28"
            Me.Cost1.Text = "0"

            Me.Sonf2.Text = "1/2 Ch-Machine"
            Me.Price2.Text = "15"
            Me.Cost2.Text = "0"

            Me.Sonf3.Text = "Rice Ch-Machine"
            Me.Price3.Text = "32"
            Me.Cost3.Text = "0"

            Me.Sonf4.Text = "Fajita Meal"
            Me.Price4.Text = "16"
            Me.Cost4.Text = "0"

            Me.Sonf5.Text = "Mexicano Meal"
            Me.Price5.Text = "16"
            Me.Cost5.Text = "0"

            Me.Sonf6.Text = "Escallop Meal"
            Me.Price6.Text = "15"
            Me.Cost6.Text = "0"

            Me.Sonf7.Text = ""
            Me.Price7.Text = ""
            Me.Cost7.Text = "0"

            Me.Sonf8.Text = ""
            Me.Price8.Text = "0"
            Me.Cost8.Text = "0"

            Me.Sonf9.Text = ""
            Me.Price9.Text = "0"
            Me.Cost9.Text = "0"

            Me.Sonf10.Text = ""
            Me.Price10.Text = "0"
            Me.Cost10.Text = "0"

            Me.Sonf11.Text = ""
            Me.Price11.Text = ""
            Me.Cost11.Text = "0"

            Me.Sonf12.Text = ""
            Me.Price12.Text = ""
            Me.Cost12.Text = ""

            Me.Sonf13.Text = ""
            Me.Price13.Text = ""
            Me.Cost13.Text = ""

            Me.Sonf14.Text = ""
            Me.Price14.Text = ""
            Me.Cost14.Text = ""

            Me.Sonf15.Text = ""
            Me.Price15.Text = ""
            Me.Cost15.Text = ""

            Me.Sonf16.Text = ""
            Me.Price16.Text = ""
            Me.Cost16.Text = ""

            Me.Sonf17.Text = ""
            Me.Price17.Text = ""
            Me.Cost17.Text = ""

            Me.Sonf18.Text = ""
            Me.Price18.Text = ""
            Me.Cost18.Text = ""

            Me.Sonf19.Text = ""
            Me.Price19.Text = ""
            Me.Cost19.Text = ""

            Me.Sonf20.Text = ""
            Me.Price20.Text = ""
            Me.Cost20.Text = ""

            Me.Sonf1.Visible = True
            Me.Sonf2.Visible = True
            Me.Sonf3.Visible = True
            Me.Sonf4.Visible = True
            Me.Sonf5.Visible = True
            Me.Sonf6.Visible = True
            Me.Sonf7.Visible = False
            Me.Sonf8.Visible = False
            Me.Sonf9.Visible = False
            Me.Sonf10.Visible = False
            Me.Sonf11.Visible = False
            Me.Sonf12.Visible = False
            Me.Sonf13.Visible = False
            Me.Sonf14.Visible = False
            Me.Sonf15.Visible = False
            Me.Sonf16.Visible = False
            Me.Sonf17.Visible = False
            Me.Sonf18.Visible = False
            Me.Sonf19.Visible = False
            Me.Sonf20.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Me.Sonf1.Text = "Falafil"
            Me.Price1.Text = "5"
            Me.Cost1.Text = "0"

            Me.Sonf2.Text = "Paratha"
            Me.Price2.Text = "1"
            Me.Cost2.Text = "0"

            Me.Sonf3.Text = "Omelet"
            Me.Price3.Text = "4"
            Me.Cost3.Text = "0"

            Me.Sonf4.Text = "Fajita"
            Me.Price4.Text = "12"
            Me.Cost4.Text = "0"

            Me.Sonf5.Text = "Mexicano"
            Me.Price5.Text = "12"
            Me.Cost5.Text = "0"

            Me.Sonf6.Text = "Chicken Bomb"
            Me.Price6.Text = "10"
            Me.Cost6.Text = "0"

            Me.Sonf7.Text = "Nugget Sanwich"
            Me.Price7.Text = "8"
            Me.Cost7.Text = "0"

            Me.Sonf8.Text = "Chicken Fillet"
            Me.Price8.Text = "9"
            Me.Cost8.Text = "0"

            Me.Sonf9.Text = "Kabab"
            Me.Price9.Text = "10"
            Me.Cost9.Text = "0"

            Me.Sonf10.Text = "Fries + Pepsi"
            Me.Price10.Text = "5"
            Me.Cost10.Text = "0"

            Me.Sonf11.Text = ""
            Me.Price11.Text = ""
            Me.Cost11.Text = "0"

            Me.Sonf12.Text = ""
            Me.Price12.Text = ""
            Me.Cost12.Text = "0"

            Me.Sonf13.Text = ""
            Me.Price13.Text = ""
            Me.Cost13.Text = "0"

            Me.Sonf14.Text = ""
            Me.Price14.Text = ""
            Me.Cost14.Text = "0"

            Me.Sonf15.Text = ""
            Me.Price15.Text = ""
            Me.Cost15.Text = "0"

            Me.Sonf16.Text = ""
            Me.Price16.Text = ""
            Me.Cost16.Text = "0"

            Me.Sonf17.Text = ""
            Me.Price17.Text = ""
            Me.Cost17.Text = ""

            Me.Sonf18.Text = ""
            Me.Price18.Text = ""
            Me.Cost18.Text = ""

            Me.Sonf19.Text = ""
            Me.Price19.Text = ""
            Me.Cost19.Text = ""

            Me.Sonf20.Text = ""
            Me.Price20.Text = ""
            Me.Cost20.Text = ""

            Me.Sonf1.Visible = True
            Me.Sonf2.Visible = True
            Me.Sonf3.Visible = True
            Me.Sonf4.Visible = True
            Me.Sonf5.Visible = True
            Me.Sonf6.Visible = True
            Me.Sonf7.Visible = True
            Me.Sonf8.Visible = True
            Me.Sonf9.Visible = True
            Me.Sonf10.Visible = True
            Me.Sonf11.Visible = False
            Me.Sonf12.Visible = False
            Me.Sonf13.Visible = False
            Me.Sonf14.Visible = False
            Me.Sonf15.Visible = False
            Me.Sonf16.Visible = False
            Me.Sonf17.Visible = False
            Me.Sonf18.Visible = False
            Me.Sonf19.Visible = False
            Me.Sonf20.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Try
            Me.Sonf1.Text = "Biryani Ch"
            Me.Price1.Text = "12"
            Me.Cost1.Text = "0"

            Me.Sonf2.Text = "Biryani Mutton"
            Me.Price2.Text = "15"
            Me.Cost2.Text = "0"

            Me.Sonf3.Text = "Biryani Veg"
            Me.Price3.Text = "10"
            Me.Cost3.Text = "0"

            Me.Sonf4.Text = "Fried Rice Ch"
            Me.Price4.Text = "12"
            Me.Cost4.Text = "0"

            Me.Sonf5.Text = "Fried Rice Veg"
            Me.Price5.Text = "10"
            Me.Cost5.Text = "0"

            Me.Sonf6.Text = "Manchurian Ch"
            Me.Price6.Text = "20"
            Me.Cost6.Text = "0"

            Me.Sonf7.Text = "Manchurian Veg"
            Me.Price7.Text = "18"
            Me.Cost7.Text = "0"

            Me.Sonf8.Text = "Butter Chicken"
            Me.Price8.Text = "15"
            Me.Cost8.Text = "0"

            Me.Sonf9.Text = "Dal/Rice"
            Me.Price9.Text = "10"
            Me.Cost9.Text = "0"

            Me.Sonf10.Text = "Dal Roti"
            Me.Price10.Text = "8"
            Me.Cost10.Text = "0"

            Me.Sonf11.Text = "Mutton Karahi"
            Me.Price11.Text = "15"
            Me.Cost11.Text = "0"

            Me.Sonf12.Text = "Aloo Keema"
            Me.Price12.Text = "15"
            Me.Cost12.Text = "0"

            Me.Sonf13.Text = "Shami Kabab"
            Me.Price13.Text = "10"
            Me.Cost13.Text = "0"

            Me.Sonf14.Text = "Jeera Rice"
            Me.Price14.Text = "8"
            Me.Cost14.Text = "0"

            Me.Sonf15.Text = "Noodles"
            Me.Price15.Text = "6"
            Me.Cost15.Text = "0"

            Me.Sonf16.Text = "Ch Karahi"
            Me.Price16.Text = "15"
            Me.Cost16.Text = "0"

            Me.Sonf17.Text = ""
            Me.Price17.Text = ""
            Me.Cost17.Text = ""

            Me.Sonf18.Text = ""
            Me.Price18.Text = ""
            Me.Cost18.Text = ""

            Me.Sonf19.Text = ""
            Me.Price19.Text = ""
            Me.Cost19.Text = ""

            Me.Sonf20.Text = ""
            Me.Price20.Text = ""
            Me.Cost20.Text = ""

            Me.Sonf1.Visible = True
            Me.Sonf2.Visible = True
            Me.Sonf3.Visible = True
            Me.Sonf4.Visible = True
            Me.Sonf5.Visible = True
            Me.Sonf6.Visible = True
            Me.Sonf7.Visible = True
            Me.Sonf8.Visible = True
            Me.Sonf9.Visible = True
            Me.Sonf10.Visible = True
            Me.Sonf11.Visible = True
            Me.Sonf12.Visible = True
            Me.Sonf13.Visible = True
            Me.Sonf14.Visible = True
            Me.Sonf15.Visible = True
            Me.Sonf16.Visible = True
            Me.Sonf17.Visible = False
            Me.Sonf18.Visible = False
            Me.Sonf19.Visible = False
            Me.Sonf20.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Try
            Me.Sonf1.Text = "Karak"
            Me.Price1.Text = "4"
            Me.Cost1.Text = "0"

            Me.Sonf2.Text = "Tea"
            Me.Price2.Text = "4"
            Me.Cost2.Text = "0"

            Me.Sonf3.Text = "Turkish Coffee"
            Me.Price3.Text = "7"
            Me.Cost3.Text = "0"

            Me.Sonf4.Text = "Cappuccino"
            Me.Price4.Text = "7"
            Me.Cost4.Text = "0"

            Me.Sonf5.Text = "Coffee latte"
            Me.Price5.Text = "7"
            Me.Cost5.Text = "0"

            Me.Sonf6.Text = "Mocha"
            Me.Price6.Text = "7"
            Me.Cost6.Text = "0"

            Me.Sonf7.Text = "3*1"
            Me.Price7.Text = "6"
            Me.Cost7.Text = "0"

            Me.Sonf8.Text = "Milk Coffee"
            Me.Price8.Text = "10"
            Me.Cost8.Text = "0"

            Me.Sonf9.Text = "Hot Chocolate"
            Me.Price9.Text = "10"
            Me.Cost9.Text = "0"

            Me.Sonf10.Text = "Ice Coffee"
            Me.Price10.Text = "10"
            Me.Cost10.Text = "0"

            Me.Sonf11.Text = "Ice Chocolate"
            Me.Price11.Text = "10"
            Me.Cost11.Text = "0"

            Me.Sonf12.Text = "Ayran / Lassi"
            Me.Price12.Text = "8"
            Me.Cost12.Text = "0"

            Me.Sonf13.Text = "Pepsi"
            Me.Price13.Text = "2"
            Me.Cost13.Text = "0"

            Me.Sonf14.Text = "Small Water"
            Me.Price14.Text = "2"
            Me.Cost14.Text = "0"

            Me.Sonf15.Text = "Big Water"
            Me.Price15.Text = "3"
            Me.Cost15.Text = "0"

            Me.Sonf16.Text = ""
            Me.Price16.Text = "8"
            Me.Cost16.Text = "0"

            Me.Sonf17.Text = ""
            Me.Price17.Text = "8"
            Me.Cost17.Text = "0"

            Me.Sonf18.Text = ""
            Me.Price18.Text = "8"
            Me.Cost18.Text = "0"

            Me.Sonf19.Text = ""
            Me.Price19.Text = "12"
            Me.Cost19.Text = "0"

            Me.Sonf20.Text = ""
            Me.Price20.Text = "10"
            Me.Cost20.Text = "0"

            Me.Sonf1.Visible = True
            Me.Sonf2.Visible = True
            Me.Sonf3.Visible = True
            Me.Sonf4.Visible = True
            Me.Sonf5.Visible = True
            Me.Sonf6.Visible = True
            Me.Sonf7.Visible = True
            Me.Sonf8.Visible = True
            Me.Sonf9.Visible = True
            Me.Sonf10.Visible = True
            Me.Sonf11.Visible = True
            Me.Sonf12.Visible = True
            Me.Sonf13.Visible = True
            Me.Sonf14.Visible = True
            Me.Sonf15.Visible = True
            Me.Sonf16.Visible = False
            Me.Sonf17.Visible = False
            Me.Sonf18.Visible = False
            Me.Sonf19.Visible = False
            Me.Sonf20.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Try
            Me.Sonf1.Text = "Mango"
            Me.Price1.Text = "12"
            Me.Cost1.Text = "0"

            Me.Sonf2.Text = "Orange"
            Me.Price2.Text = "10"
            Me.Cost2.Text = "0"

            Me.Sonf3.Text = "Lemonade"
            Me.Price3.Text = "10"
            Me.Cost3.Text = "0"

            Me.Sonf4.Text = "Avocado"
            Me.Price4.Text = "13"
            Me.Cost4.Text = "0"

            Me.Sonf5.Text = "Strawberry"
            Me.Price5.Text = "12"
            Me.Cost5.Text = "0"

            Me.Sonf6.Text = "Watrmelon"
            Me.Price6.Text = "10"
            Me.Cost6.Text = "0"

            Me.Sonf7.Text = "Carrot"
            Me.Price7.Text = "10"
            Me.Cost7.Text = "0"

            Me.Sonf8.Text = "Banana Shake"
            Me.Price8.Text = "10"
            Me.Cost8.Text = "0"

            Me.Sonf9.Text = "Strawbery Shake"
            Me.Price9.Text = "12"
            Me.Cost9.Text = "0"

            Me.Sonf10.Text = "Chocolate Shake"
            Me.Price10.Text = "10"
            Me.Cost10.Text = "0"

            Me.Sonf11.Text = ""
            Me.Price11.Text = ""
            Me.Cost11.Text = ""

            Me.Sonf12.Text = ""
            Me.Price12.Text = ""
            Me.Cost12.Text = ""

            Me.Sonf13.Text = ""
            Me.Price13.Text = ""
            Me.Cost13.Text = ""

            Me.Sonf14.Text = ""
            Me.Price14.Text = ""
            Me.Cost14.Text = ""

            Me.Sonf15.Text = ""
            Me.Price15.Text = ""
            Me.Cost15.Text = ""

            Me.Sonf16.Text = ""
            Me.Price16.Text = ""
            Me.Cost16.Text = ""

            Me.Sonf17.Text = ""
            Me.Price17.Text = ""
            Me.Cost17.Text = ""

            Me.Sonf18.Text = ""
            Me.Price18.Text = ""
            Me.Cost18.Text = ""

            Me.Sonf19.Text = ""
            Me.Price19.Text = ""
            Me.Cost19.Text = ""

            Me.Sonf20.Text = ""
            Me.Price20.Text = ""
            Me.Cost20.Text = ""

            Me.Sonf1.Visible = True
            Me.Sonf2.Visible = True
            Me.Sonf3.Visible = True
            Me.Sonf4.Visible = True
            Me.Sonf5.Visible = True
            Me.Sonf6.Visible = True
            Me.Sonf7.Visible = True
            Me.Sonf8.Visible = True
            Me.Sonf9.Visible = True
            Me.Sonf10.Visible = True
            Me.Sonf11.Visible = False
            Me.Sonf12.Visible = False
            Me.Sonf13.Visible = False
            Me.Sonf14.Visible = False
            Me.Sonf15.Visible = False
            Me.Sonf16.Visible = False
            Me.Sonf17.Visible = False
            Me.Sonf18.Visible = False
            Me.Sonf19.Visible = False
            Me.Sonf20.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        Try
            Me.Sonf1.Text = "Mohalabiia"
            Me.Price1.Text = "7"
            Me.Cost1.Text = "0"

            Me.Sonf2.Text = "Rice Pudding"
            Me.Price2.Text = "7"
            Me.Cost2.Text = "0"

            Me.Sonf3.Text = "Custard"
            Me.Price3.Text = "7"
            Me.Cost3.Text = "0"

            Me.Sonf4.Text = "Knafa"
            Me.Price4.Text = "10"
            Me.Cost4.Text = "0"

            Me.Sonf5.Text = ""
            Me.Price5.Text = ""
            Me.Cost5.Text = ""

            Me.Sonf6.Text = ""
            Me.Price6.Text = ""
            Me.Cost6.Text = ""

            Me.Sonf7.Text = ""
            Me.Price7.Text = ""
            Me.Cost7.Text = ""

            Me.Sonf8.Text = ""
            Me.Price8.Text = ""
            Me.Cost8.Text = ""

            Me.Sonf9.Text = ""
            Me.Price9.Text = ""
            Me.Cost9.Text = ""

            Me.Sonf10.Text = ""
            Me.Price10.Text = ""
            Me.Cost10.Text = ""

            Me.Sonf11.Text = ""
            Me.Price11.Text = ""
            Me.Cost11.Text = ""

            Me.Sonf12.Text = ""
            Me.Price12.Text = ""
            Me.Cost12.Text = ""

            Me.Sonf13.Text = ""
            Me.Price13.Text = ""
            Me.Cost13.Text = ""

            Me.Sonf14.Text = ""
            Me.Price14.Text = ""
            Me.Cost14.Text = ""

            Me.Sonf15.Text = ""
            Me.Price15.Text = ""
            Me.Cost15.Text = ""

            Me.Sonf16.Text = ""
            Me.Price16.Text = ""
            Me.Cost16.Text = ""

            Me.Sonf17.Text = ""
            Me.Price17.Text = ""
            Me.Cost17.Text = ""

            Me.Sonf18.Text = ""
            Me.Price18.Text = ""
            Me.Cost18.Text = ""

            Me.Sonf19.Text = ""
            Me.Price19.Text = ""
            Me.Cost19.Text = ""

            Me.Sonf20.Text = ""
            Me.Price20.Text = ""
            Me.Cost20.Text = ""

            Me.Sonf1.Visible = True
            Me.Sonf2.Visible = True
            Me.Sonf3.Visible = True
            Me.Sonf4.Visible = True
            Me.Sonf5.Visible = False
            Me.Sonf6.Visible = False
            Me.Sonf7.Visible = False
            Me.Sonf8.Visible = False
            Me.Sonf9.Visible = False
            Me.Sonf10.Visible = False
            Me.Sonf11.Visible = False
            Me.Sonf12.Visible = False
            Me.Sonf13.Visible = False
            Me.Sonf14.Visible = False
            Me.Sonf15.Visible = False
            Me.Sonf16.Visible = False
            Me.Sonf17.Visible = False
            Me.Sonf18.Visible = False
            Me.Sonf19.Visible = False
            Me.Sonf20.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
       
    End Sub


    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        Me.TableNo.Text = "11"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        Me.TableNo.Text = "12"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        Me.TableNo.Text = "13"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        Me.TableNo.Text = "14"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        Try
            Me.Sonf1.Text = "Hummus"
            Me.Price1.Text = "5"
            Me.Cost1.Text = "0"

            Me.Sonf2.Text = "Falafil Plate"
            Me.Price2.Text = "10"
            Me.Cost2.Text = "0"

            Me.Sonf3.Text = "Garlic Sause"
            Me.Price3.Text = "5"
            Me.Cost3.Text = "0"

            Me.Sonf4.Text = "Mix Salad"
            Me.Price4.Text = "8"
            Me.Cost4.Text = "0"

            Me.Sonf5.Text = "Coleslaw"
            Me.Price5.Text = "6"
            Me.Cost5.Text = "0"

            Me.Sonf6.Text = "French Fries"
            Me.Price6.Text = "5"
            Me.Cost6.Text = "0"

            Me.Sonf7.Text = "Soup"
            Me.Price7.Text = "6"
            Me.Cost7.Text = "0"

            Me.Sonf8.Text = "Spring Roll"
            Me.Price8.Text = "1"
            Me.Cost8.Text = "0"

            Me.Sonf9.Text = "Samosa"
            Me.Price9.Text = "1"
            Me.Cost9.Text = "0"

            Me.Sonf10.Text = "Roti"
            Me.Price10.Text = "2"
            Me.Cost10.Text = "0"

            Me.Sonf11.Text = "Fried-Ch B"
            Me.Price11.Text = "5"
            Me.Cost11.Text = "0"

            Me.Sonf12.Text = "Falafil B"
            Me.Price12.Text = "1"
            Me.Cost12.Text = "0"

            Me.Sonf13.Text = "Rice"
            Me.Price13.Text = "5"
            Me.Cost13.Text = "0"

            Me.Sonf14.Text = "Biryani Rice"
            Me.Price14.Text = "8"
            Me.Cost14.Text = "0"

            Me.Sonf15.Text = "Raita"
            Me.Price15.Text = "2"
            Me.Cost15.Text = "0"

            Me.Sonf16.Text = "Extra 5"
            Me.Price16.Text = "5"
            Me.Cost16.Text = "0"

            Me.Sonf17.Text = "Ice"
            Me.Price17.Text = "2"
            Me.Cost17.Text = "0"

            Me.Sonf18.Text = "Bread 1"
            Me.Price18.Text = "1"
            Me.Cost18.Text = "0"

            Me.Sonf19.Text = "Bread 2"
            Me.Price19.Text = "2"
            Me.Cost19.Text = "0"

            Me.Sonf20.Text = ""
            Me.Price20.Text = ""
            Me.Cost20.Text = ""

            Me.Sonf1.Visible = True
            Me.Sonf2.Visible = True
            Me.Sonf3.Visible = True
            Me.Sonf4.Visible = True
            Me.Sonf5.Visible = True
            Me.Sonf6.Visible = True
            Me.Sonf7.Visible = True
            Me.Sonf8.Visible = True
            Me.Sonf9.Visible = True
            Me.Sonf10.Visible = True
            Me.Sonf11.Visible = True
            Me.Sonf12.Visible = True
            Me.Sonf13.Visible = True
            Me.Sonf14.Visible = True
            Me.Sonf15.Visible = True
            Me.Sonf16.Visible = True
            Me.Sonf17.Visible = True
            Me.Sonf18.Visible = True
            Me.Sonf19.Visible = True
            Me.Sonf20.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        Try
            Me.Sonf1.Text = "Orange"
            Me.Price1.Text = "7"
            Me.Cost1.Text = "0"

            Me.Sonf2.Text = "Pinaple"
            Me.Price2.Text = "8"
            Me.Cost2.Text = "0"

            Me.Sonf3.Text = "Lemonade"
            Me.Price3.Text = "8"
            Me.Cost3.Text = "0"

            Me.Sonf4.Text = "Mint Lemonade"
            Me.Price4.Text = "9"
            Me.Cost4.Text = "0"

            Me.Sonf5.Text = "Avocado"
            Me.Price5.Text = "9"
            Me.Cost5.Text = "0"

            Me.Sonf6.Text = "Banana Shake"
            Me.Price6.Text = "10"
            Me.Cost6.Text = "0"

            Me.Sonf7.Text = "Fruit Shake"
            Me.Price7.Text = "10"
            Me.Cost7.Text = "0"

            Me.Sonf8.Text = "Pina Colada"
            Me.Price8.Text = "10"
            Me.Cost8.Text = "0"

            Me.Sonf9.Text = "Mojito"
            Me.Price9.Text = "12"
            Me.Cost9.Text = "0"

            Me.Sonf10.Text = "Mango"
            Me.Price10.Text = "10"
            Me.Cost10.Text = "0"

            Me.Sonf11.Text = "Ice Cream"
            Me.Price11.Text = "6"
            Me.Cost11.Text = "0"

            Me.Sonf12.Text = ""
            Me.Price12.Text = ""
            Me.Cost12.Text = "0"

            Me.Sonf13.Text = ""
            Me.Price13.Text = ""
            Me.Cost13.Text = "0"

            Me.Sonf14.Text = ""
            Me.Price14.Text = ""
            Me.Cost14.Text = "0"

            Me.Sonf15.Text = ""
            Me.Price15.Text = ""
            Me.Cost15.Text = "0"

            Me.Sonf16.Text = ""
            Me.Price16.Text = ""
            Me.Cost16.Text = "0"

            Me.Sonf17.Text = ""
            Me.Price17.Text = ""
            Me.Cost17.Text = "0"

            Me.Sonf18.Text = ""
            Me.Price18.Text = ""
            Me.Cost18.Text = "0"

            Me.Sonf19.Text = ""
            Me.Price19.Text = ""
            Me.Cost19.Text = "0"

            Me.Sonf20.Text = ""
            Me.Price20.Text = ""
            Me.Cost20.Text = "0"

            Me.Sonf1.Visible = True
            Me.Sonf2.Visible = True
            Me.Sonf3.Visible = True
            Me.Sonf4.Visible = True
            Me.Sonf5.Visible = True
            Me.Sonf6.Visible = True
            Me.Sonf7.Visible = True
            Me.Sonf8.Visible = True
            Me.Sonf9.Visible = True
            Me.Sonf10.Visible = True
            Me.Sonf11.Visible = True
            Me.Sonf12.Visible = False
            Me.Sonf13.Visible = False
            Me.Sonf14.Visible = False
            Me.Sonf15.Visible = False
            Me.Sonf16.Visible = False
            Me.Sonf17.Visible = False
            Me.Sonf18.Visible = False
            Me.Sonf19.Visible = False
            Me.Sonf20.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        Try
            Me.Sonf1.Text = "Biryani Combo"
            Me.Price1.Text = "15"
            Me.Cost1.Text = "0"

            Me.Sonf2.Text = "P-Shawrma Combo"
            Me.Price2.Text = "18"
            Me.Cost2.Text = "0"

            Me.Sonf3.Text = "Pasta Combo"
            Me.Price3.Text = "10"
            Me.Cost3.Text = "0"

            Me.Sonf4.Text = "Fried Ch Snack"
            Me.Price4.Text = "16"
            Me.Cost4.Text = "0"

            Me.Sonf5.Text = "Bir-Kar Combo"
            Me.Price5.Text = "29"
            Me.Cost5.Text = "0"

            Me.Sonf6.Text = "Cheesy Fries"
            Me.Price6.Text = "10"
            Me.Cost6.Text = "0"

            Me.Sonf7.Text = "Nuggets Combo"
            Me.Price7.Text = "10"
            Me.Cost7.Text = "0"

            Me.Sonf8.Text = "Dal Combo"
            Me.Price8.Text = "17"
            Me.Cost8.Text = "0"

            Me.Sonf9.Text = "2 Pizza Combo"
            Me.Price9.Text = "48"
            Me.Cost9.Text = "0"

            Me.Sonf10.Text = "SpringRoll Combo"
            Me.Price10.Text = "8"
            Me.Cost10.Text = "0"

            Me.Sonf11.Text = "P-Burger Combo"
            Me.Price11.Text = "20"
            Me.Cost11.Text = "0"

            Me.Sonf12.Text = "Fried Ch Meal"
            Me.Price12.Text = "32"
            Me.Cost12.Text = "0"

            Me.Sonf13.Text = "Fried Ch Jumbo"
            Me.Price13.Text = "52"
            Me.Cost13.Text = "0"

            Me.Sonf14.Text = ""
            Me.Price14.Text = ""
            Me.Cost14.Text = "0"

            Me.Sonf15.Text = ""
            Me.Price15.Text = ""
            Me.Cost15.Text = "0"

            Me.Sonf16.Text = ""
            Me.Price16.Text = "8"
            Me.Cost16.Text = "0"

            Me.Sonf17.Text = ""
            Me.Price17.Text = "8"
            Me.Cost17.Text = "0"

            Me.Sonf18.Text = ""
            Me.Price18.Text = "8"
            Me.Cost18.Text = "0"

            Me.Sonf19.Text = ""
            Me.Price19.Text = "12"
            Me.Cost19.Text = "0"

            Me.Sonf20.Text = ""
            Me.Price20.Text = "10"
            Me.Cost20.Text = "0"

            Me.Sonf1.Visible = True
            Me.Sonf2.Visible = True
            Me.Sonf3.Visible = True
            Me.Sonf4.Visible = True
            Me.Sonf5.Visible = True
            Me.Sonf6.Visible = True
            Me.Sonf7.Visible = True
            Me.Sonf8.Visible = True
            Me.Sonf9.Visible = True
            Me.Sonf10.Visible = True
            Me.Sonf11.Visible = True
            Me.Sonf12.Visible = True
            Me.Sonf13.Visible = True
            Me.Sonf14.Visible = False
            Me.Sonf15.Visible = False
            Me.Sonf16.Visible = False
            Me.Sonf17.Visible = False
            Me.Sonf18.Visible = False
            Me.Sonf19.Visible = False
            Me.Sonf20.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        Me.TableNo.Text = "15"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        Me.TableNo.Text = "16"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        Me.TableNo.Text = "17"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        Me.TableNo.Text = "18"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        Me.TableNo.Text = "19"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        Me.TableNo.Text = "Out+"
        Me.DataSet11.Clear()
        Me.GroupBox1.Visible = False
        data()
    End Sub
End Class
