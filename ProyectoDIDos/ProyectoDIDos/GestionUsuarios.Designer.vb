<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionUsuarios))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PantallaPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeLibrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeBusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TPVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenúPrincipaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolsbtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.toolsbtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.toolsbtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.cbxRol = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cbxEmpleados = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiete = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.btnVolverMenu = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PantallaPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PantallaPrincipalToolStripMenuItem
        '
        Me.PantallaPrincipalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeLibrosToolStripMenuItem1, Me.GestionDeBusquedaToolStripMenuItem, Me.GestionDeStockToolStripMenuItem, Me.GestionDeEmpleadosToolStripMenuItem, Me.GestionDeClientesToolStripMenuItem1, Me.GestiónProductosToolStripMenuItem, Me.TPVToolStripMenuItem, Me.ToolStripSeparator1, Me.MenúPrincipaToolStripMenuItem})
        Me.PantallaPrincipalToolStripMenuItem.Name = "PantallaPrincipalToolStripMenuItem"
        Me.PantallaPrincipalToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PantallaPrincipalToolStripMenuItem.Text = "Pantallas"
        '
        'GestionDeLibrosToolStripMenuItem1
        '
        Me.GestionDeLibrosToolStripMenuItem1.Image = CType(resources.GetObject("GestionDeLibrosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.GestionDeLibrosToolStripMenuItem1.Name = "GestionDeLibrosToolStripMenuItem1"
        Me.GestionDeLibrosToolStripMenuItem1.Size = New System.Drawing.Size(191, 22)
        Me.GestionDeLibrosToolStripMenuItem1.Text = "Gestion de Libros"
        '
        'GestionDeBusquedaToolStripMenuItem
        '
        Me.GestionDeBusquedaToolStripMenuItem.Image = CType(resources.GetObject("GestionDeBusquedaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestionDeBusquedaToolStripMenuItem.Name = "GestionDeBusquedaToolStripMenuItem"
        Me.GestionDeBusquedaToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.GestionDeBusquedaToolStripMenuItem.Text = "Gestion de Búsqueda"
        '
        'GestionDeStockToolStripMenuItem
        '
        Me.GestionDeStockToolStripMenuItem.Image = CType(resources.GetObject("GestionDeStockToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestionDeStockToolStripMenuItem.Name = "GestionDeStockToolStripMenuItem"
        Me.GestionDeStockToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.GestionDeStockToolStripMenuItem.Text = "Gestion de Stock"
        '
        'GestionDeEmpleadosToolStripMenuItem
        '
        Me.GestionDeEmpleadosToolStripMenuItem.Image = CType(resources.GetObject("GestionDeEmpleadosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestionDeEmpleadosToolStripMenuItem.Name = "GestionDeEmpleadosToolStripMenuItem"
        Me.GestionDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.GestionDeEmpleadosToolStripMenuItem.Text = "Gestion de Empleados"
        '
        'GestionDeClientesToolStripMenuItem1
        '
        Me.GestionDeClientesToolStripMenuItem1.Image = CType(resources.GetObject("GestionDeClientesToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.GestionDeClientesToolStripMenuItem1.Name = "GestionDeClientesToolStripMenuItem1"
        Me.GestionDeClientesToolStripMenuItem1.Size = New System.Drawing.Size(191, 22)
        Me.GestionDeClientesToolStripMenuItem1.Text = "Gestion de Clientes"
        '
        'GestiónProductosToolStripMenuItem
        '
        Me.GestiónProductosToolStripMenuItem.Image = CType(resources.GetObject("GestiónProductosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestiónProductosToolStripMenuItem.Name = "GestiónProductosToolStripMenuItem"
        Me.GestiónProductosToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.GestiónProductosToolStripMenuItem.Text = "Gestión Productos"
        '
        'TPVToolStripMenuItem
        '
        Me.TPVToolStripMenuItem.Image = CType(resources.GetObject("TPVToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TPVToolStripMenuItem.Name = "TPVToolStripMenuItem"
        Me.TPVToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.TPVToolStripMenuItem.Text = "TPV"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'MenúPrincipaToolStripMenuItem
        '
        Me.MenúPrincipaToolStripMenuItem.Image = CType(resources.GetObject("MenúPrincipaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenúPrincipaToolStripMenuItem.Name = "MenúPrincipaToolStripMenuItem"
        Me.MenúPrincipaToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.MenúPrincipaToolStripMenuItem.Text = "Menú principal"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolsbtnNuevo, Me.toolsbtnGuardar, Me.toolsbtnEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1362, 25)
        Me.ToolStrip1.TabIndex = 24
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(83, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(4, 166)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(312, 337)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Clave:"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(131, 129)
        Me.txtClave.MaxLength = 6
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(108, 20)
        Me.txtClave.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtClave, "El campo Clave  o contraseña de usuario accepta solamente digitos." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(113, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Gestion Usuarios"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(84, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Usuario:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(131, 93)
        Me.txtUsuario.MaxLength = 10
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(108, 20)
        Me.txtUsuario.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtUsuario, "El campo Usuario  es un identificador unico para los usuarios accepta solamente c" &
        "racteres." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'cbxRol
        '
        Me.cbxRol.FormattingEnabled = True
        Me.cbxRol.Items.AddRange(New Object() {"Administrador", "Usuario", "Guest"})
        Me.cbxRol.Location = New System.Drawing.Point(131, 166)
        Me.cbxRol.Name = "cbxRol"
        Me.cbxRol.Size = New System.Drawing.Size(109, 21)
        Me.cbxRol.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.cbxRol, "La Categoria Rol los roles que puede tener un usuario ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Rol:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(106, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Id:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(132, 58)
        Me.txtID.MaxLength = 7
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(108, 20)
        Me.txtID.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtID, "El campo ID  es un identificador unico para los usuarios accepta solamente digito" &
        "s.")
        '
        'cbxEmpleados
        '
        Me.cbxEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEmpleados.FormattingEnabled = True
        Me.cbxEmpleados.Items.AddRange(New Object() {"Administrador", "Usuario", "Guest"})
        Me.cbxEmpleados.Location = New System.Drawing.Point(130, 204)
        Me.cbxEmpleados.Name = "cbxEmpleados"
        Me.cbxEmpleados.Size = New System.Drawing.Size(109, 21)
        Me.cbxEmpleados.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.cbxEmpleados, "La Categoria Empleado los empleados que han sido dado de alta.")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Empleados:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cbxEmpleados)
        Me.Panel3.Controls.Add(Me.txtID)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.cbxRol)
        Me.Panel3.Controls.Add(Me.txtUsuario)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtClave)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(328, 132)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(370, 324)
        Me.Panel3.TabIndex = 12
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAlta.Location = New System.Drawing.Point(31, 36)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(112, 46)
        Me.btnAlta.TabIndex = 5
        Me.btnAlta.Text = "Alta"
        Me.ToolTip1.SetToolTip(Me.btnAlta, "El Button Alta permite de dar alta a un usuario asignando un rol a empleado selec" &
        "cionado de la categoria empleados.")
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLimpiar.Location = New System.Drawing.Point(31, 131)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(112, 46)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.ToolTip1.SetToolTip(Me.btnLimpiar, "El Button Limpiar permite de limpiar todos los campos del forumulario")
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificar.Location = New System.Drawing.Point(31, 216)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(112, 46)
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "Modificar"
        Me.ToolTip1.SetToolTip(Me.btnModificar, "El Button Modificar permite de modificar un usuario .")
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminar.Location = New System.Drawing.Point(31, 297)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(112, 46)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "El Button Eliminar permite de eliminar un usuario eliminando empleado asignado.")
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.btnAlta)
        Me.Panel2.Location = New System.Drawing.Point(723, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(171, 374)
        Me.Panel2.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(634, 315)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Location = New System.Drawing.Point(921, 132)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(646, 321)
        Me.Panel4.TabIndex = 14
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
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(154, 22)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(0, 13)
        Me.lblNumero.TabIndex = 17
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.lblNumero)
        Me.Panel5.Controls.Add(Me.btnPrimero)
        Me.Panel5.Controls.Add(Me.btnAnterior)
        Me.Panel5.Controls.Add(Me.btnSiguiete)
        Me.Panel5.Controls.Add(Me.btnUltimo)
        Me.Panel5.Location = New System.Drawing.Point(328, 399)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(370, 54)
        Me.Panel5.TabIndex = 23
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 613)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1362, 22)
        Me.StatusStrip1.TabIndex = 25
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
        'btnVolverMenu
        '
        Me.btnVolverMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnVolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolverMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolverMenu.Location = New System.Drawing.Point(723, 482)
        Me.btnVolverMenu.Name = "btnVolverMenu"
        Me.btnVolverMenu.Size = New System.Drawing.Size(171, 80)
        Me.btnVolverMenu.TabIndex = 9
        Me.btnVolverMenu.Text = "Menú principal"
        Me.ToolTip1.SetToolTip(Me.btnVolverMenu, "El Button Menu Principal permite de volver a la pantalla principal de la aplicaci" &
        "on ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnVolverMenu.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Gestion de Usuarios"
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 635)
        Me.Controls.Add(Me.btnVolverMenu)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionUsuarios"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Usuarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PantallaPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeLibrosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionDeClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenúPrincipaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents toolsbtnNuevo As ToolStripButton
    Friend WithEvents toolsbtnGuardar As ToolStripButton
    Friend WithEvents toolsbtnEliminar As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtClave As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents cbxRol As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents cbxEmpleados As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiete As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents lblNumero As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GestionDeStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeBusquedaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents btnVolverMenu As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GestiónProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TPVToolStripMenuItem As ToolStripMenuItem
End Class
