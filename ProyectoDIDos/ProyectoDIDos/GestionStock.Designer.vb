<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionStock
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionStock))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnModificarStock = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBusTitulo = New System.Windows.Forms.TextBox()
        Me.txtBusID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBusISBN = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiete = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PantallaPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeLibrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeBusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeUsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TPVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenúPrincipaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(507, 521)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnModificarStock
        '
        Me.btnModificarStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnModificarStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarStock.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificarStock.Location = New System.Drawing.Point(175, 287)
        Me.btnModificarStock.Name = "btnModificarStock"
        Me.btnModificarStock.Size = New System.Drawing.Size(208, 46)
        Me.btnModificarStock.TabIndex = 12
        Me.btnModificarStock.Text = "Modificar El Stock"
        Me.ToolTip1.SetToolTip(Me.btnModificarStock, "El Button Modificar El stock permite de modificar el stock del libro seleccionado" &
        " ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnModificarStock.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(547, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(854, 201)
        Me.Panel1.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TrackBar1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtStock)
        Me.GroupBox2.Location = New System.Drawing.Point(520, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(331, 126)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestion de Stock"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(297, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "100"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(267, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "90"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "80"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(207, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "70"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(171, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "60"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(136, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "50"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(111, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "40"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(76, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "30"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "20"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "10"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(6, 75)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 10
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(316, 45)
        Me.TrackBar1.SmallChange = 10
        Me.TrackBar1.TabIndex = 8
        Me.TrackBar1.TickFrequency = 10
        Me.ToolTip1.SetToolTip(Me.TrackBar1, "El Control Trackbar permite de definir el stock de un libro moviendo indicador." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
        "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.TrackBar1.Value = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Stock:"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(59, 36)
        Me.txtStock.MaxLength = 4
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(108, 20)
        Me.txtStock.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtStock, "El campo stock permite de mostrar el stock de libro y definir nuevo stock .")
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLimpiar.Location = New System.Drawing.Point(300, 147)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(112, 46)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        Me.ToolTip1.SetToolTip(Me.btnLimpiar, "El Button Limpiar permite de limpiar todos los campos del forumulario")
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBusTitulo)
        Me.GroupBox1.Controls.Add(Me.txtBusID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBusISBN)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 126)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Id:"
        '
        'txtBusTitulo
        '
        Me.txtBusTitulo.Location = New System.Drawing.Point(376, 42)
        Me.txtBusTitulo.Name = "txtBusTitulo"
        Me.txtBusTitulo.Size = New System.Drawing.Size(108, 20)
        Me.txtBusTitulo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtBusTitulo, "El campo Titulo  permite de buscar un Libro  por caracteres .")
        '
        'txtBusID
        '
        Me.txtBusID.Location = New System.Drawing.Point(48, 42)
        Me.txtBusID.Name = "txtBusID"
        Me.txtBusID.Size = New System.Drawing.Size(108, 20)
        Me.txtBusID.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(323, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Titulo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ISBN:"
        '
        'txtBusISBN
        '
        Me.txtBusISBN.Location = New System.Drawing.Point(203, 42)
        Me.txtBusISBN.Name = "txtBusISBN"
        Me.txtBusISBN.Size = New System.Drawing.Size(108, 20)
        Me.txtBusISBN.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtBusISBN, "El campo ISBN  permite de buscar un Libro  por caracteres .")
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Controls.Add(Me.btnModificarStock)
        Me.Panel4.Location = New System.Drawing.Point(623, 262)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(565, 336)
        Me.Panel4.TabIndex = 14
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.lblNumero)
        Me.Panel5.Controls.Add(Me.btnPrimero)
        Me.Panel5.Controls.Add(Me.btnAnterior)
        Me.Panel5.Controls.Add(Me.btnSiguiete)
        Me.Panel5.Controls.Add(Me.btnUltimo)
        Me.Panel5.Location = New System.Drawing.Point(97, 218)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(370, 54)
        Me.Panel5.TabIndex = 19
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(154, 22)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(0, 13)
        Me.lblNumero.TabIndex = 17
        '
        'btnPrimero
        '
        Me.btnPrimero.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.Location = New System.Drawing.Point(8, 17)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(55, 23)
        Me.btnPrimero.TabIndex = 3
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(69, 17)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(55, 23)
        Me.btnAnterior.TabIndex = 2
        Me.btnAnterior.Text = "<<"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnSiguiete
        '
        Me.btnSiguiete.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSiguiete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSiguiete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiete.Location = New System.Drawing.Point(231, 17)
        Me.btnSiguiete.Name = "btnSiguiete"
        Me.btnSiguiete.Size = New System.Drawing.Size(55, 23)
        Me.btnSiguiete.TabIndex = 1
        Me.btnSiguiete.Text = ">>"
        Me.btnSiguiete.UseVisualStyleBackColor = False
        '
        'btnUltimo
        '
        Me.btnUltimo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(294, 17)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(55, 23)
        Me.btnUltimo.TabIndex = 0
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(560, 209)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PantallaPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PantallaPrincipalToolStripMenuItem
        '
        Me.PantallaPrincipalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeLibrosToolStripMenuItem1, Me.GestionDeBusquedaToolStripMenuItem, Me.GestionEmpleadosToolStripMenuItem, Me.GestionDeUsuariosToolStripMenuItem1, Me.GestionDeClientesToolStripMenuItem1, Me.GestiónProductosToolStripMenuItem, Me.TPVToolStripMenuItem, Me.ToolStripSeparator1, Me.MenúPrincipaToolStripMenuItem})
        Me.PantallaPrincipalToolStripMenuItem.Name = "PantallaPrincipalToolStripMenuItem"
        Me.PantallaPrincipalToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PantallaPrincipalToolStripMenuItem.Text = "Pantallas"
        '
        'GestionDeLibrosToolStripMenuItem1
        '
        Me.GestionDeLibrosToolStripMenuItem1.Image = CType(resources.GetObject("GestionDeLibrosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.GestionDeLibrosToolStripMenuItem1.Name = "GestionDeLibrosToolStripMenuItem1"
        Me.GestionDeLibrosToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.GestionDeLibrosToolStripMenuItem1.Text = "Gestion de Libros"
        '
        'GestionDeBusquedaToolStripMenuItem
        '
        Me.GestionDeBusquedaToolStripMenuItem.Image = CType(resources.GetObject("GestionDeBusquedaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestionDeBusquedaToolStripMenuItem.Name = "GestionDeBusquedaToolStripMenuItem"
        Me.GestionDeBusquedaToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.GestionDeBusquedaToolStripMenuItem.Text = "Gestion de Búsqueda"
        '
        'GestionEmpleadosToolStripMenuItem
        '
        Me.GestionEmpleadosToolStripMenuItem.Image = CType(resources.GetObject("GestionEmpleadosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestionEmpleadosToolStripMenuItem.Name = "GestionEmpleadosToolStripMenuItem"
        Me.GestionEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.GestionEmpleadosToolStripMenuItem.Text = "Gestion Empleados"
        '
        'GestionDeUsuariosToolStripMenuItem1
        '
        Me.GestionDeUsuariosToolStripMenuItem1.Image = CType(resources.GetObject("GestionDeUsuariosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.GestionDeUsuariosToolStripMenuItem1.Name = "GestionDeUsuariosToolStripMenuItem1"
        Me.GestionDeUsuariosToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.GestionDeUsuariosToolStripMenuItem1.Text = "Gestion de Usuarios"
        '
        'GestionDeClientesToolStripMenuItem1
        '
        Me.GestionDeClientesToolStripMenuItem1.Image = CType(resources.GetObject("GestionDeClientesToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.GestionDeClientesToolStripMenuItem1.Name = "GestionDeClientesToolStripMenuItem1"
        Me.GestionDeClientesToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.GestionDeClientesToolStripMenuItem1.Text = "Gestion de Clientes"
        '
        'GestiónProductosToolStripMenuItem
        '
        Me.GestiónProductosToolStripMenuItem.Image = CType(resources.GetObject("GestiónProductosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestiónProductosToolStripMenuItem.Name = "GestiónProductosToolStripMenuItem"
        Me.GestiónProductosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.GestiónProductosToolStripMenuItem.Text = "Gestión Productos"
        '
        'TPVToolStripMenuItem
        '
        Me.TPVToolStripMenuItem.Image = CType(resources.GetObject("TPVToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TPVToolStripMenuItem.Name = "TPVToolStripMenuItem"
        Me.TPVToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.TPVToolStripMenuItem.Text = "TPV"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(182, 6)
        '
        'MenúPrincipaToolStripMenuItem
        '
        Me.MenúPrincipaToolStripMenuItem.Image = CType(resources.GetObject("MenúPrincipaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenúPrincipaToolStripMenuItem.Name = "MenúPrincipaToolStripMenuItem"
        Me.MenúPrincipaToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.MenúPrincipaToolStripMenuItem.Text = "Menú principal"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 676)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1362, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'Timer1
        '
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\Tomás\Desktop\ProyectoDIDos\Repo_ProyectDIDos\ProyectoDIDos\ProyectoDIDo" &
    "s\bin\Debug\Ayuda software Casa del Libro.chm"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Gestion de Stock"
        '
        'GestionStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 698)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionStock"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Stock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnModificarStock As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PantallaPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeLibrosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionDeUsuariosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionDeClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenúPrincipaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBusTitulo As TextBox
    Friend WithEvents txtBusID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBusISBN As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblNumero As Label
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiete As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GestionDeBusquedaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GestiónProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TPVToolStripMenuItem As ToolStripMenuItem
End Class
