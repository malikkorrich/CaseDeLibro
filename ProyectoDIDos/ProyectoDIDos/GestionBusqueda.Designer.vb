<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionBusqueda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionBusqueda))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PantallaPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeLibrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeUsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenúPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbxIdioma = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbxEstado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxCategorias = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBusAutor = New System.Windows.Forms.TextBox()
        Me.txtBusGenero = New System.Windows.Forms.TextBox()
        Me.lbGenero = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBusEditorial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBusISBN = New System.Windows.Forms.TextBox()
        Me.txtBusID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBusTitulo = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TPVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PantallaPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PantallaPrincipalToolStripMenuItem
        '
        Me.PantallaPrincipalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeLibrosToolStripMenuItem1, Me.GestionDeStockToolStripMenuItem, Me.GestionEmpleadosToolStripMenuItem, Me.GestionDeUsuariosToolStripMenuItem1, Me.GestionDeClientesToolStripMenuItem1, Me.GestiónProductosToolStripMenuItem, Me.TPVToolStripMenuItem, Me.ToolStripSeparator1, Me.MenúPrincipalToolStripMenuItem})
        Me.PantallaPrincipalToolStripMenuItem.Name = "PantallaPrincipalToolStripMenuItem"
        Me.PantallaPrincipalToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PantallaPrincipalToolStripMenuItem.Text = "Pantallas"
        '
        'GestionDeLibrosToolStripMenuItem1
        '
        Me.GestionDeLibrosToolStripMenuItem1.Image = CType(resources.GetObject("GestionDeLibrosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.GestionDeLibrosToolStripMenuItem1.Name = "GestionDeLibrosToolStripMenuItem1"
        Me.GestionDeLibrosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.GestionDeLibrosToolStripMenuItem1.Text = "Gestion de Libros"
        '
        'GestionDeStockToolStripMenuItem
        '
        Me.GestionDeStockToolStripMenuItem.Image = CType(resources.GetObject("GestionDeStockToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestionDeStockToolStripMenuItem.Name = "GestionDeStockToolStripMenuItem"
        Me.GestionDeStockToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GestionDeStockToolStripMenuItem.Text = "Gestion de Stock"
        '
        'GestionEmpleadosToolStripMenuItem
        '
        Me.GestionEmpleadosToolStripMenuItem.Image = CType(resources.GetObject("GestionEmpleadosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestionEmpleadosToolStripMenuItem.Name = "GestionEmpleadosToolStripMenuItem"
        Me.GestionEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GestionEmpleadosToolStripMenuItem.Text = "Gestion Empleados"
        '
        'GestionDeUsuariosToolStripMenuItem1
        '
        Me.GestionDeUsuariosToolStripMenuItem1.Image = CType(resources.GetObject("GestionDeUsuariosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.GestionDeUsuariosToolStripMenuItem1.Name = "GestionDeUsuariosToolStripMenuItem1"
        Me.GestionDeUsuariosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.GestionDeUsuariosToolStripMenuItem1.Text = "Gestion de Usuarios"
        '
        'GestionDeClientesToolStripMenuItem1
        '
        Me.GestionDeClientesToolStripMenuItem1.Image = CType(resources.GetObject("GestionDeClientesToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.GestionDeClientesToolStripMenuItem1.Name = "GestionDeClientesToolStripMenuItem1"
        Me.GestionDeClientesToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.GestionDeClientesToolStripMenuItem1.Text = "Gestion de Clientes"
        '
        'GestiónProductosToolStripMenuItem
        '
        Me.GestiónProductosToolStripMenuItem.Image = CType(resources.GetObject("GestiónProductosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestiónProductosToolStripMenuItem.Name = "GestiónProductosToolStripMenuItem"
        Me.GestiónProductosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GestiónProductosToolStripMenuItem.Text = "Gestión Productos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'MenúPrincipalToolStripMenuItem
        '
        Me.MenúPrincipalToolStripMenuItem.Image = CType(resources.GetObject("MenúPrincipalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenúPrincipalToolStripMenuItem.Name = "MenúPrincipalToolStripMenuItem"
        Me.MenúPrincipalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MenúPrincipalToolStripMenuItem.Text = "Menú principal"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1362, 674)
        Me.SplitContainer1.SplitterDistance = 315
        Me.SplitContainer1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(65, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 132)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Menú principal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(354, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 241)
        Me.Panel1.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscar.Location = New System.Drawing.Point(196, 178)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 46)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "El Button Buscar permite de buscar un libro por id .")
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLimpiar.Location = New System.Drawing.Point(436, 178)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(112, 46)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        Me.ToolTip1.SetToolTip(Me.btnLimpiar, "El Button Limpiar permite de limpiar todos los campos del forumulario")
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cbxIdioma)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cbxEstado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbxCategorias)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBusAutor)
        Me.GroupBox1.Controls.Add(Me.txtBusGenero)
        Me.GroupBox1.Controls.Add(Me.lbGenero)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtBusEditorial)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBusISBN)
        Me.GroupBox1.Controls.Add(Me.txtBusID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBusTitulo)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(747, 157)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Idioma:"
        '
        'cbxIdioma
        '
        Me.cbxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxIdioma.FormattingEnabled = True
        Me.cbxIdioma.Items.AddRange(New Object() {"Español", "Catalán", "Inglés"})
        Me.cbxIdioma.Location = New System.Drawing.Point(54, 119)
        Me.cbxIdioma.Name = "cbxIdioma"
        Me.cbxIdioma.Size = New System.Drawing.Size(109, 21)
        Me.cbxIdioma.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.cbxIdioma, "La Categoria Idioma permite de buscar un Libro  por su idioma")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(533, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Estado:"
        '
        'cbxEstado
        '
        Me.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEstado.FormattingEnabled = True
        Me.cbxEstado.Items.AddRange(New Object() {"Muy bueno", "Bueno", "Como nuevo", "Descatalogado", "Nuevo"})
        Me.cbxEstado.Location = New System.Drawing.Point(590, 78)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.Size = New System.Drawing.Size(109, 21)
        Me.cbxEstado.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.cbxEstado, "La Categoria Estado permite de buscar un Libro  por su estado")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(523, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Categorias:"
        '
        'cbxCategorias
        '
        Me.cbxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategorias.FormattingEnabled = True
        Me.cbxCategorias.Items.AddRange(New Object() {"Medicina", "Libro antiguo y de ocasion", "Infantil", "Literatura", "Novela contemporanea", "Salud y dietas", "Autoayuda y espiritualidad", "Historia", "Ebooks", "Arte", "Filologia", "Idiomas", "Narrativa historica", "Empresa", "Ciencias humanas", "Fotografia", "Accesorios de escritorio", "Psicologia y pedagogia", "Ciencias", "Romantica y erotica", "Novela negra", "Comics"})
        Me.cbxCategorias.Location = New System.Drawing.Point(590, 46)
        Me.cbxCategorias.Name = "cbxCategorias"
        Me.cbxCategorias.Size = New System.Drawing.Size(109, 21)
        Me.cbxCategorias.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.cbxCategorias, "Categorias permite de buscar un Libro  por una categoria")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(352, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Autor:"
        '
        'txtBusAutor
        '
        Me.txtBusAutor.Location = New System.Drawing.Point(394, 83)
        Me.txtBusAutor.Name = "txtBusAutor"
        Me.txtBusAutor.Size = New System.Drawing.Size(108, 20)
        Me.txtBusAutor.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtBusAutor, "El campo Autor  permite de buscar un Libro  por caracteres ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'txtBusGenero
        '
        Me.txtBusGenero.Location = New System.Drawing.Point(224, 86)
        Me.txtBusGenero.Name = "txtBusGenero"
        Me.txtBusGenero.Size = New System.Drawing.Size(108, 20)
        Me.txtBusGenero.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txtBusGenero, "El campo Genero  permite de buscar un Libro  por caracteres ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'lbGenero
        '
        Me.lbGenero.AutoSize = True
        Me.lbGenero.Location = New System.Drawing.Point(174, 93)
        Me.lbGenero.Name = "lbGenero"
        Me.lbGenero.Size = New System.Drawing.Size(45, 13)
        Me.lbGenero.TabIndex = 8
        Me.lbGenero.Text = "Género:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Editorial:"
        '
        'txtBusEditorial
        '
        Me.txtBusEditorial.Location = New System.Drawing.Point(54, 86)
        Me.txtBusEditorial.Name = "txtBusEditorial"
        Me.txtBusEditorial.Size = New System.Drawing.Size(113, 20)
        Me.txtBusEditorial.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtBusEditorial, "El campo Editorial  permite de buscar un Libro  por caracteres ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Id:"
        '
        'txtBusISBN
        '
        Me.txtBusISBN.Location = New System.Drawing.Point(224, 42)
        Me.txtBusISBN.Name = "txtBusISBN"
        Me.txtBusISBN.Size = New System.Drawing.Size(108, 20)
        Me.txtBusISBN.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtBusISBN, "El campo ISBN  permite de buscar un Libro  por caracteres .")
        '
        'txtBusID
        '
        Me.txtBusID.Location = New System.Drawing.Point(54, 42)
        Me.txtBusID.Name = "txtBusID"
        Me.txtBusID.Size = New System.Drawing.Size(111, 20)
        Me.txtBusID.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ISBN:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(352, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Titulo:"
        '
        'txtBusTitulo
        '
        Me.txtBusTitulo.Location = New System.Drawing.Point(394, 42)
        Me.txtBusTitulo.Name = "txtBusTitulo"
        Me.txtBusTitulo.Size = New System.Drawing.Size(108, 20)
        Me.txtBusTitulo.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtBusTitulo, "El campo Titulo  permite de buscar un Libro  por caracteres ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 329)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1358, 22)
        Me.StatusStrip1.TabIndex = 12
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Location = New System.Drawing.Point(30, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1378, 323)
        Me.Panel4.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 200
        Me.DataGridView1.Size = New System.Drawing.Size(1369, 317)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\Tomás\Desktop\ProyectoDIDos\Repo_ProyectDIDos\ProyectoDIDos\ProyectoDIDo" &
    "s\bin\Debug\Ayuda software Casa del Libro.chm"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Gestion de Busqueda"
        '
        'TPVToolStripMenuItem
        '
        Me.TPVToolStripMenuItem.Image = CType(resources.GetObject("TPVToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TPVToolStripMenuItem.Name = "TPVToolStripMenuItem"
        Me.TPVToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TPVToolStripMenuItem.Text = "TPV"
        '
        'GestionBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 698)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionBusqueda"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Busqueda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PantallaPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeLibrosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionDeUsuariosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionDeClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenúPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBusAutor As TextBox
    Friend WithEvents txtBusGenero As TextBox
    Friend WithEvents lbGenero As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBusEditorial As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBusISBN As TextBox
    Friend WithEvents txtBusID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBusTitulo As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents GestionDeStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxCategorias As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbxEstado As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbxIdioma As ComboBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GestiónProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TPVToolStripMenuItem As ToolStripMenuItem
End Class
