<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblNumTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTonkistu = New System.Windows.Forms.Label()
        Me.lblshoyu = New System.Windows.Forms.Label()
        Me.lblmiso = New System.Windows.Forms.Label()
        Me.lblshio = New System.Windows.Forms.Label()
        Me.NumerTonkotsu = New System.Windows.Forms.NumericUpDown()
        Me.NumerShoyu = New System.Windows.Forms.NumericUpDown()
        Me.NumerMiso = New System.Windows.Forms.NumericUpDown()
        Me.NumerShio = New System.Windows.Forms.NumericUpDown()
        Me.orderno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.cardNo = New System.Windows.Forms.TextBox()
        Me.lblcardbo = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Date1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Database1DataSet = New Ramen_Billling_System.Database1DataSet()
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mobno = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblname1 = New System.Windows.Forms.Label()
        Me.name1 = New System.Windows.Forms.TextBox()
        Me.cvv = New System.Windows.Forms.TextBox()
        Me.lblcvv = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.NumerTonkotsu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumerShoyu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumerMiso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumerShio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(299, 741)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(118, 46)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Panel7)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.lblNumTotal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblTonkistu)
        Me.GroupBox1.Controls.Add(Me.lblshoyu)
        Me.GroupBox1.Controls.Add(Me.lblmiso)
        Me.GroupBox1.Controls.Add(Me.lblshio)
        Me.GroupBox1.Controls.Add(Me.NumerTonkotsu)
        Me.GroupBox1.Controls.Add(Me.NumerShoyu)
        Me.GroupBox1.Controls.Add(Me.NumerMiso)
        Me.GroupBox1.Controls.Add(Me.NumerShio)
        Me.GroupBox1.Location = New System.Drawing.Point(103, 126)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(517, 454)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label17)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Location = New System.Drawing.Point(0, 102)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(526, 33)
        Me.Panel7.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(121, 20)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Ramen Name"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(155, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 23)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Number of Items"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(352, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 23)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Cost of Items"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Location = New System.Drawing.Point(0, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(526, 78)
        Me.Panel4.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(135, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(366, 52)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Phones"
        '
        'lblNumTotal
        '
        Me.lblNumTotal.BackColor = System.Drawing.Color.White
        Me.lblNumTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumTotal.Location = New System.Drawing.Point(155, 363)
        Me.lblNumTotal.Name = "lblNumTotal"
        Me.lblNumTotal.Size = New System.Drawing.Size(84, 23)
        Me.lblNumTotal.TabIndex = 4
        Me.lblNumTotal.Text = "0"
        Me.lblNumTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 364)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 301)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 23)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Realme"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 250)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 23)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Xoami"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(356, 363)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "$0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 23)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Apple"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 23)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Samsung"
        '
        'lblTonkistu
        '
        Me.lblTonkistu.BackColor = System.Drawing.Color.White
        Me.lblTonkistu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTonkistu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTonkistu.Location = New System.Drawing.Point(356, 301)
        Me.lblTonkistu.Name = "lblTonkistu"
        Me.lblTonkistu.Size = New System.Drawing.Size(100, 23)
        Me.lblTonkistu.TabIndex = 19
        Me.lblTonkistu.Text = "$0.00"
        Me.lblTonkistu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblshoyu
        '
        Me.lblshoyu.BackColor = System.Drawing.Color.White
        Me.lblshoyu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblshoyu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshoyu.Location = New System.Drawing.Point(356, 250)
        Me.lblshoyu.Name = "lblshoyu"
        Me.lblshoyu.Size = New System.Drawing.Size(100, 23)
        Me.lblshoyu.TabIndex = 18
        Me.lblshoyu.Text = "$0.00"
        Me.lblshoyu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmiso
        '
        Me.lblmiso.BackColor = System.Drawing.Color.White
        Me.lblmiso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblmiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmiso.Location = New System.Drawing.Point(356, 192)
        Me.lblmiso.Name = "lblmiso"
        Me.lblmiso.Size = New System.Drawing.Size(100, 23)
        Me.lblmiso.TabIndex = 17
        Me.lblmiso.Text = "$0.00"
        Me.lblmiso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblshio
        '
        Me.lblshio.BackColor = System.Drawing.Color.White
        Me.lblshio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblshio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshio.Location = New System.Drawing.Point(356, 143)
        Me.lblshio.Name = "lblshio"
        Me.lblshio.Size = New System.Drawing.Size(100, 23)
        Me.lblshio.TabIndex = 16
        Me.lblshio.Text = "$0.00"
        Me.lblshio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumerTonkotsu
        '
        Me.NumerTonkotsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumerTonkotsu.Location = New System.Drawing.Point(155, 299)
        Me.NumerTonkotsu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumerTonkotsu.Name = "NumerTonkotsu"
        Me.NumerTonkotsu.Size = New System.Drawing.Size(83, 22)
        Me.NumerTonkotsu.TabIndex = 3
        Me.NumerTonkotsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumerShoyu
        '
        Me.NumerShoyu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumerShoyu.Location = New System.Drawing.Point(155, 247)
        Me.NumerShoyu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumerShoyu.Name = "NumerShoyu"
        Me.NumerShoyu.Size = New System.Drawing.Size(84, 22)
        Me.NumerShoyu.TabIndex = 2
        Me.NumerShoyu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumerMiso
        '
        Me.NumerMiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumerMiso.Location = New System.Drawing.Point(156, 191)
        Me.NumerMiso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumerMiso.Name = "NumerMiso"
        Me.NumerMiso.Size = New System.Drawing.Size(83, 22)
        Me.NumerMiso.TabIndex = 1
        Me.NumerMiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumerShio
        '
        Me.NumerShio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumerShio.Location = New System.Drawing.Point(155, 143)
        Me.NumerShio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumerShio.Name = "NumerShio"
        Me.NumerShio.Size = New System.Drawing.Size(84, 22)
        Me.NumerShio.TabIndex = 0
        Me.NumerShio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'orderno
        '
        Me.orderno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderno.Location = New System.Drawing.Point(195, 252)
        Me.orderno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.orderno.Name = "orderno"
        Me.orderno.Size = New System.Drawing.Size(162, 27)
        Me.orderno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 27)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Order Number"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(29, 79)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(68, 22)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Cash"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(249, 79)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(65, 22)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Card"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'cardNo
        '
        Me.cardNo.Location = New System.Drawing.Point(260, 109)
        Me.cardNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cardNo.Name = "cardNo"
        Me.cardNo.Size = New System.Drawing.Size(153, 24)
        Me.cardNo.TabIndex = 2
        '
        'lblcardbo
        '
        Me.lblcardbo.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcardbo.Location = New System.Drawing.Point(134, 111)
        Me.lblcardbo.Name = "lblcardbo"
        Me.lblcardbo.Size = New System.Drawing.Size(120, 20)
        Me.lblcardbo.TabIndex = 13
        Me.lblcardbo.Text = "Card Number"
        '
        'btnTotal
        '
        Me.btnTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTotal.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(123, 741)
        Me.btnTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(112, 46)
        Me.btnTotal.TabIndex = 0
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'Logout
        '
        Me.Logout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Logout.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.Location = New System.Drawing.Point(497, 741)
        Me.Logout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(116, 46)
        Me.Logout.TabIndex = 16
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(868, 741)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Payment"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Date1
        '
        Me.Date1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date1.Location = New System.Drawing.Point(905, 99)
        Me.Date1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Date1.Name = "Date1"
        Me.Date1.Size = New System.Drawing.Size(178, 22)
        Me.Date1.TabIndex = 18
        Me.Date1.Value = New Date(2021, 1, 6, 0, 0, 0, 0)
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1139, 90)
        Me.Panel1.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(338, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(652, 57)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Phone Billing System"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Database1DataSetBindingSource
        '
        Me.Database1DataSetBindingSource.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource.Position = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 33)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "First Name"
        '
        'fname
        '
        Me.fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname.Location = New System.Drawing.Point(195, 108)
        Me.fname.Margin = New System.Windows.Forms.Padding(4)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(165, 28)
        Me.fname.TabIndex = 0
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(23, 203)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(115, 25)
        Me.label6.TabIndex = 22
        Me.label6.Text = "Mobile No."
        '
        'lname
        '
        Me.lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lname.Location = New System.Drawing.Point(195, 154)
        Me.lname.Margin = New System.Windows.Forms.Padding(4)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(162, 28)
        Me.lname.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 154)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 25)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Last Name"
        '
        'mobno
        '
        Me.mobno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobno.Location = New System.Drawing.Point(195, 203)
        Me.mobno.Margin = New System.Windows.Forms.Padding(4)
        Me.mobno.Name = "mobno"
        Me.mobno.Size = New System.Drawing.Size(162, 28)
        Me.mobno.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.orderno)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.fname)
        Me.Panel2.Controls.Add(Me.lname)
        Me.Panel2.Controls.Add(Me.mobno)
        Me.Panel2.Controls.Add(Me.label6)
        Me.Panel2.Location = New System.Drawing.Point(644, 126)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(430, 321)
        Me.Panel2.TabIndex = 26
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(495, 69)
        Me.Panel3.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(53, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(366, 52)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Customer Details"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Location = New System.Drawing.Point(-1, -1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(439, 75)
        Me.Panel5.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(137, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(176, 40)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Payment"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lblname1)
        Me.Panel6.Controls.Add(Me.name1)
        Me.Panel6.Controls.Add(Me.cvv)
        Me.Panel6.Controls.Add(Me.lblcvv)
        Me.Panel6.Controls.Add(Me.cardNo)
        Me.Panel6.Controls.Add(Me.RadioButton2)
        Me.Panel6.Controls.Add(Me.RadioButton1)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.lblcardbo)
        Me.Panel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(644, 453)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(430, 250)
        Me.Panel6.TabIndex = 29
        '
        'lblname1
        '
        Me.lblname1.AutoSize = True
        Me.lblname1.Location = New System.Drawing.Point(140, 197)
        Me.lblname1.Name = "lblname1"
        Me.lblname1.Size = New System.Drawing.Size(52, 18)
        Me.lblname1.TabIndex = 32
        Me.lblname1.Text = "Name"
        '
        'name1
        '
        Me.name1.Location = New System.Drawing.Point(260, 194)
        Me.name1.Name = "name1"
        Me.name1.Size = New System.Drawing.Size(160, 24)
        Me.name1.TabIndex = 31
        '
        'cvv
        '
        Me.cvv.Location = New System.Drawing.Point(260, 156)
        Me.cvv.Name = "cvv"
        Me.cvv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cvv.Size = New System.Drawing.Size(153, 24)
        Me.cvv.TabIndex = 30
        '
        'lblcvv
        '
        Me.lblcvv.AutoSize = True
        Me.lblcvv.Location = New System.Drawing.Point(140, 156)
        Me.lblcvv.Name = "lblcvv"
        Me.lblcvv.Size = New System.Drawing.Size(40, 18)
        Me.lblcvv.TabIndex = 29
        Me.lblcvv.Text = "CVV"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(669, 741)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 46)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Check"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1138, 884)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Date1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReset)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(699, 710)
        Me.Name = "Form2"
        Me.Text = "Billing System"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.NumerTonkotsu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumerShoyu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumerMiso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumerShio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents NumerTonkotsu As NumericUpDown
    Friend WithEvents NumerShoyu As NumericUpDown
    Friend WithEvents NumerMiso As NumericUpDown
    Friend WithEvents NumerShio As NumericUpDown
    Friend WithEvents lblshio As Label
    Friend WithEvents lblTonkistu As Label
    Friend WithEvents lblshoyu As Label
    Friend WithEvents lblmiso As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnTotal As Button
    Friend WithEvents lblNumTotal As Label
    Friend WithEvents lblcardbo As Label
    Friend WithEvents cardNo As TextBox
    Friend WithEvents Logout As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents orderno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Date1 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Database1DataSetBindingSource As BindingSource
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents Label4 As Label
    Friend WithEvents fname As TextBox
    Friend WithEvents label6 As Label
    Friend WithEvents lname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mobno As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents lblname1 As Label
    Friend WithEvents name1 As TextBox
    Friend WithEvents cvv As TextBox
    Friend WithEvents lblcvv As Label
End Class
