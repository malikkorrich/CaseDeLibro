<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionEmpleados))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PantallaPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeLibrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeBusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeStoclToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeUsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TPVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenúPrincipaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolsbtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.toolsbtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.toolsbtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiete = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBusNombre = New System.Windows.Forms.TextBox()
        Me.txtBusID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBusDni = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PantallaPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1285, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PantallaPrincipalToolStripMenuItem
        '
        Me.PantallaPrincipalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeLibrosToolStripMenuItem1, Me.GestionDeBusquedaToolStripMenuItem, Me.GestionDeStoclToolStripMenuItem, Me.GestionDeClientesToolStripMenuItem1, Me.GestionDeUsuariosToolStripMenuItem1, Me.GestiónProductosToolStripMenuItem, Me.TPVToolStripMenuItem, Me.ToolStripSeparator1, Me.MenúPrincipaToolStripMenuItem})
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
        'GestionDeStoclToolStripMenuItem
        '
        Me.GestionDeStoclToolStripMenuItem.Image = CType(resources.GetObject("GestionDeStoclToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestionDeStoclToolStripMenuItem.Name = "GestionDeStoclToolStripMenuItem"
        Me.GestionDeStoclToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.GestionDeStoclToolStripMenuItem.Text = "Gestion de Stock"
        '
        'GestionDeClientesToolStripMenuItem1
        '
        Me.GestionDeClientesToolStripMenuItem1.Image = CType(resources.GetObject("GestionDeClientesToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.GestionDeClientesToolStripMenuItem1.Name = "GestionDeClientesToolStripMenuItem1"
        Me.GestionDeClientesToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.GestionDeClientesToolStripMenuItem1.Text = "Gestion de Clientes"
        '
        'GestionDeUsuariosToolStripMenuItem1
        '
        Me.GestionDeUsuariosToolStripMenuItem1.Image = CType(resources.GetObject("GestionDeUsuariosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.GestionDeUsuariosToolStripMenuItem1.Name = "GestionDeUsuariosToolStripMenuItem1"
        Me.GestionDeUsuariosToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.GestionDeUsuariosToolStripMenuItem1.Text = "Gestion de Usuarios"
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolsbtnNuevo, Me.toolsbtnGuardar, Me.toolsbtnEliminar, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1285, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolsbtnNuevo
        '
        Me.toolsbtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolsbtnNuevo.Image = CType(resources.GetObject("toolsbtnNuevo.Image"), System.Drawing.Image)
        Me.toolsbtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolsbtnNuevo.Name = "toolsbtnNuevo"
        Me.toolsbtnNuevo.Size = New System.Drawing.Size(23, 22)
        Me.toolsbtnNuevo.Text = "Limpiar campos"
        '
        'toolsbtnGuardar
        '
        Me.toolsbtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolsbtnGuardar.Image = CType(resources.GetObject("toolsbtnGuardar.Image"), System.Drawing.Image)
        Me.toolsbtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolsbtnGuardar.Name = "toolsbtnGuardar"
        Me.toolsbtnGuardar.Size = New System.Drawing.Size(23, 22)
        Me.toolsbtnGuardar.Text = "Dar de alta"
        '
        'toolsbtnEliminar
        '
        Me.toolsbtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolsbtnEliminar.Image = CType(resources.GetObject("toolsbtnEliminar.Image"), System.Drawing.Image)
        Me.toolsbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolsbtnEliminar.Name = "toolsbtnEliminar"
        Me.toolsbtnEliminar.Size = New System.Drawing.Size(23, 22)
        Me.toolsbtnEliminar.Text = "Eliminar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Generar informe"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1285, 587)
        Me.SplitContainer1.SplitterDistance = 588
        Me.SplitContainer1.TabIndex = 10
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.lblNumero)
        Me.Panel5.Controls.Add(Me.btnPrimero)
        Me.Panel5.Controls.Add(Me.btnAnterior)
        Me.Panel5.Controls.Add(Me.btnSiguiete)
        Me.Panel5.Controls.Add(Me.btnUltimo)
        Me.Panel5.Location = New System.Drawing.Point(22, 469)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(370, 54)
        Me.Panel5.TabIndex = 24
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Controls.Add(Me.txtID)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtTelefono)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtApellidos)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtNombre)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtDni)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(22, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(370, 404)
        Me.Panel3.TabIndex = 21
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(131, 64)
        Me.txtID.MaxLength = 7
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(108, 20)
        Me.txtID.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtID, "El campo id es un identificador unico para los empleados accepta solamente digito" &
        "s")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(99, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(113, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Gestion Empleados"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(131, 245)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(108, 20)
        Me.txtTelefono.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtTelefono, "El campo Telefono accepta solamente digitos ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Telefono:"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(131, 203)
        Me.txtApellidos.MaxLength = 30
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(108, 20)
        Me.txtApellidos.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtApellidos, "El campo Apellidos accepta solamente caracteres ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Apellidos:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(131, 151)
        Me.txtNombre.MaxLength = 25
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(108, 20)
        Me.txtNombre.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtNombre, "El campo Nombre accepta solamente caracteres .")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nombre:"
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(131, 106)
        Me.txtDni.MaxLength = 9
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(108, 20)
        Me.txtDni.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtDni, "El campo Dni es un identificador unico para los empleados accepta solamente carac" &
        "teres y digito")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dni:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btnAlta)
        Me.Panel2.Location = New System.Drawing.Point(410, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(171, 323)
        Me.Panel2.TabIndex = 20
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminar.Location = New System.Drawing.Point(29, 211)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(112, 46)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "El Button Eliminar permite de eliminar un empleado .")
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificar.Location = New System.Drawing.Point(29, 130)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(112, 46)
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "Modificar"
        Me.ToolTip1.SetToolTip(Me.btnModificar, "El Button Modificar permite de modificar un empleado .")
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAlta.Location = New System.Drawing.Point(29, 44)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(112, 46)
        Me.btnAlta.TabIndex = 5
        Me.btnAlta.Text = "Alta"
        Me.ToolTip1.SetToolTip(Me.btnAlta, "El Button Alta permite de dar alta o añadir un empleado .")
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(63, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 241)
        Me.Panel1.TabIndex = 19
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscar.Location = New System.Drawing.Point(116, 160)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 46)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "El Button Buscar permite de buscar un empleado por id .")
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLimpiar.Location = New System.Drawing.Point(356, 160)
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
        Me.GroupBox1.Controls.Add(Me.txtBusNombre)
        Me.GroupBox1.Controls.Add(Me.txtBusID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBusDni)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 126)
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
        'txtBusNombre
        '
        Me.txtBusNombre.Location = New System.Drawing.Point(405, 42)
        Me.txtBusNombre.Name = "txtBusNombre"
        Me.txtBusNombre.Size = New System.Drawing.Size(108, 20)
        Me.txtBusNombre.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txtBusNombre, "El campo Nombre permite de buscar un empleado por caracteres ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'txtBusID
        '
        Me.txtBusID.Location = New System.Drawing.Point(48, 42)
        Me.txtBusID.Name = "txtBusID"
        Me.txtBusID.Size = New System.Drawing.Size(108, 20)
        Me.txtBusID.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(352, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dni:"
        '
        'txtBusDni
        '
        Me.txtBusDni.Location = New System.Drawing.Point(215, 42)
        Me.txtBusDni.Name = "txtBusDni"
        Me.txtBusDni.Size = New System.Drawing.Size(108, 20)
        Me.txtBusDni.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtBusDni, "El campo Dni permite de buscar un empleado por caracteres ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Location = New System.Drawing.Point(60, 292)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(566, 271)
        Me.Panel4.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(563, 271)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 614)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1285, 22)
        Me.StatusStrip1.TabIndex = 11
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
        Me.ToolTip1.ToolTipTitle = "Gestion Empleados"
        '
        'GestionEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1285, 636)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionEmpleados"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PantallaPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeLibrosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionDeUsuariosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionDeClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenúPrincipaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents toolsbtnNuevo As ToolStripButton
    Friend WithEvents toolsbtnGuardar As ToolStripButton
    Friend WithEvents toolsbtnEliminar As ToolStripButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblNumero As Label
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiete As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBusNombre As TextBox
    Friend WithEvents txtBusID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBusDni As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GestionDeBusquedaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeStoclToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GestiónProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TPVToolStripMenuItem As ToolStripMenuItem
End Class
