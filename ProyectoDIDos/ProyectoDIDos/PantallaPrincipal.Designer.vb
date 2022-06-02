<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGestionLibros = New System.Windows.Forms.Button()
        Me.lbGestionLibros = New System.Windows.Forms.Label()
        Me.lbGestionEmpleados = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbtxtRol = New System.Windows.Forms.Label()
        Me.lbRol = New System.Windows.Forms.Label()
        Me.lbSocios = New System.Windows.Forms.Label()
        Me.lbGestionStock = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.picSocios = New System.Windows.Forms.PictureBox()
        Me.picUsuarios = New System.Windows.Forms.PictureBox()
        Me.picStock = New System.Windows.Forms.PictureBox()
        Me.picEmple = New System.Windows.Forms.PictureBox()
        Me.lbUsuarios = New System.Windows.Forms.Label()
        Me.lbConsultas = New System.Windows.Forms.Label()
        Me.btnGestionBusqueda = New System.Windows.Forms.Button()
        Me.picYellowCircleBack = New System.Windows.Forms.PictureBox()
        Me.picYellowCircleBackOutLine = New System.Windows.Forms.PictureBox()
        Me.picProductos = New System.Windows.Forms.PictureBox()
        Me.lbProductos = New System.Windows.Forms.Label()
        Me.picTPV = New System.Windows.Forms.PictureBox()
        Me.lbTPV = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picSocios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEmple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYellowCircleBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYellowCircleBackOutLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTPV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1273, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Image = CType(resources.GetObject("CerrarSesiónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SalirToolStripMenuItem.Text = "Cerrar sesión y salir"
        '
        'btnGestionLibros
        '
        Me.btnGestionLibros.BackColor = System.Drawing.Color.DarkGray
        Me.btnGestionLibros.Image = CType(resources.GetObject("btnGestionLibros.Image"), System.Drawing.Image)
        Me.btnGestionLibros.Location = New System.Drawing.Point(162, 188)
        Me.btnGestionLibros.Name = "btnGestionLibros"
        Me.btnGestionLibros.Size = New System.Drawing.Size(269, 146)
        Me.btnGestionLibros.TabIndex = 2
        Me.btnGestionLibros.UseVisualStyleBackColor = False
        '
        'lbGestionLibros
        '
        Me.lbGestionLibros.AutoSize = True
        Me.lbGestionLibros.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lbGestionLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGestionLibros.Location = New System.Drawing.Point(157, 160)
        Me.lbGestionLibros.Name = "lbGestionLibros"
        Me.lbGestionLibros.Size = New System.Drawing.Size(165, 25)
        Me.lbGestionLibros.TabIndex = 4
        Me.lbGestionLibros.Text = "Gestión Libros"
        '
        'lbGestionEmpleados
        '
        Me.lbGestionEmpleados.AutoSize = True
        Me.lbGestionEmpleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lbGestionEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGestionEmpleados.Location = New System.Drawing.Point(796, 511)
        Me.lbGestionEmpleados.Name = "lbGestionEmpleados"
        Me.lbGestionEmpleados.Size = New System.Drawing.Size(105, 25)
        Me.lbGestionEmpleados.TabIndex = 7
        Me.lbGestionEmpleados.Text = "Personal"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 719)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1273, 22)
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
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbtxtRol)
        Me.Panel1.Controls.Add(Me.lbRol)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1273, 27)
        Me.Panel1.TabIndex = 13
        '
        'lbtxtRol
        '
        Me.lbtxtRol.AutoSize = True
        Me.lbtxtRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtxtRol.Location = New System.Drawing.Point(138, 11)
        Me.lbtxtRol.Name = "lbtxtRol"
        Me.lbtxtRol.Size = New System.Drawing.Size(32, 16)
        Me.lbtxtRol.TabIndex = 26
        Me.lbtxtRol.Text = "Rol"
        '
        'lbRol
        '
        Me.lbRol.AutoSize = True
        Me.lbRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRol.Location = New System.Drawing.Point(3, 11)
        Me.lbRol.Name = "lbRol"
        Me.lbRol.Size = New System.Drawing.Size(129, 16)
        Me.lbRol.TabIndex = 25
        Me.lbRol.Text = "Conectado como:"
        '
        'lbSocios
        '
        Me.lbSocios.AutoSize = True
        Me.lbSocios.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lbSocios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSocios.Location = New System.Drawing.Point(1, 609)
        Me.lbSocios.Name = "lbSocios"
        Me.lbSocios.Size = New System.Drawing.Size(83, 25)
        Me.lbSocios.TabIndex = 16
        Me.lbSocios.Text = "Socios"
        '
        'lbGestionStock
        '
        Me.lbGestionStock.AutoSize = True
        Me.lbGestionStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lbGestionStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGestionStock.Location = New System.Drawing.Point(1176, 160)
        Me.lbGestionStock.Name = "lbGestionStock"
        Me.lbGestionStock.Size = New System.Drawing.Size(71, 25)
        Me.lbGestionStock.TabIndex = 17
        Me.lbGestionStock.Text = "Stock"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\Tomás\Desktop\ProyectoDIDos\Repo_ProyectDIDos\ProyectoDIDos\ProyectoDIDo" &
    "s\bin\Debug\Ayuda software Casa del Libro.chm"
        '
        'picSocios
        '
        Me.picSocios.Image = CType(resources.GetObject("picSocios.Image"), System.Drawing.Image)
        Me.picSocios.Location = New System.Drawing.Point(0, 637)
        Me.picSocios.Name = "picSocios"
        Me.picSocios.Size = New System.Drawing.Size(281, 79)
        Me.picSocios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSocios.TabIndex = 20
        Me.picSocios.TabStop = False
        '
        'picUsuarios
        '
        Me.picUsuarios.Image = CType(resources.GetObject("picUsuarios.Image"), System.Drawing.Image)
        Me.picUsuarios.Location = New System.Drawing.Point(470, 526)
        Me.picUsuarios.Name = "picUsuarios"
        Me.picUsuarios.Size = New System.Drawing.Size(158, 166)
        Me.picUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUsuarios.TabIndex = 21
        Me.picUsuarios.TabStop = False
        '
        'picStock
        '
        Me.picStock.Image = CType(resources.GetObject("picStock.Image"), System.Drawing.Image)
        Me.picStock.Location = New System.Drawing.Point(978, 188)
        Me.picStock.Name = "picStock"
        Me.picStock.Size = New System.Drawing.Size(269, 146)
        Me.picStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStock.TabIndex = 22
        Me.picStock.TabStop = False
        '
        'picEmple
        '
        Me.picEmple.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.picEmple.Image = CType(resources.GetObject("picEmple.Image"), System.Drawing.Image)
        Me.picEmple.Location = New System.Drawing.Point(769, 539)
        Me.picEmple.Name = "picEmple"
        Me.picEmple.Size = New System.Drawing.Size(169, 153)
        Me.picEmple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmple.TabIndex = 23
        Me.picEmple.TabStop = False
        '
        'lbUsuarios
        '
        Me.lbUsuarios.AutoSize = True
        Me.lbUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lbUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuarios.Location = New System.Drawing.Point(501, 511)
        Me.lbUsuarios.Name = "lbUsuarios"
        Me.lbUsuarios.Size = New System.Drawing.Size(105, 25)
        Me.lbUsuarios.TabIndex = 24
        Me.lbUsuarios.Text = "Usuarios"
        '
        'lbConsultas
        '
        Me.lbConsultas.AutoSize = True
        Me.lbConsultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lbConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConsultas.Location = New System.Drawing.Point(642, 410)
        Me.lbConsultas.Name = "lbConsultas"
        Me.lbConsultas.Size = New System.Drawing.Size(117, 25)
        Me.lbConsultas.TabIndex = 5
        Me.lbConsultas.Text = "Consultas"
        '
        'btnGestionBusqueda
        '
        Me.btnGestionBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGestionBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGestionBusqueda.Image = CType(resources.GetObject("btnGestionBusqueda.Image"), System.Drawing.Image)
        Me.btnGestionBusqueda.Location = New System.Drawing.Point(603, 163)
        Me.btnGestionBusqueda.Name = "btnGestionBusqueda"
        Me.btnGestionBusqueda.Size = New System.Drawing.Size(218, 196)
        Me.btnGestionBusqueda.TabIndex = 3
        Me.btnGestionBusqueda.UseVisualStyleBackColor = False
        '
        'picYellowCircleBack
        '
        Me.picYellowCircleBack.Image = CType(resources.GetObject("picYellowCircleBack.Image"), System.Drawing.Image)
        Me.picYellowCircleBack.Location = New System.Drawing.Point(470, 57)
        Me.picYellowCircleBack.Name = "picYellowCircleBack"
        Me.picYellowCircleBack.Size = New System.Drawing.Size(468, 443)
        Me.picYellowCircleBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picYellowCircleBack.TabIndex = 25
        Me.picYellowCircleBack.TabStop = False
        '
        'picYellowCircleBackOutLine
        '
        Me.picYellowCircleBackOutLine.Image = CType(resources.GetObject("picYellowCircleBackOutLine.Image"), System.Drawing.Image)
        Me.picYellowCircleBackOutLine.Location = New System.Drawing.Point(194, -84)
        Me.picYellowCircleBackOutLine.Name = "picYellowCircleBackOutLine"
        Me.picYellowCircleBackOutLine.Size = New System.Drawing.Size(1092, 655)
        Me.picYellowCircleBackOutLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picYellowCircleBackOutLine.TabIndex = 26
        Me.picYellowCircleBackOutLine.TabStop = False
        '
        'picProductos
        '
        Me.picProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.picProductos.Image = CType(resources.GetObject("picProductos.Image"), System.Drawing.Image)
        Me.picProductos.Location = New System.Drawing.Point(1166, 637)
        Me.picProductos.Name = "picProductos"
        Me.picProductos.Size = New System.Drawing.Size(95, 79)
        Me.picProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProductos.TabIndex = 27
        Me.picProductos.TabStop = False
        '
        'lbProductos
        '
        Me.lbProductos.AutoSize = True
        Me.lbProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lbProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProductos.Location = New System.Drawing.Point(1155, 609)
        Me.lbProductos.Name = "lbProductos"
        Me.lbProductos.Size = New System.Drawing.Size(118, 25)
        Me.lbProductos.TabIndex = 28
        Me.lbProductos.Text = "Productos"
        '
        'picTPV
        '
        Me.picTPV.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.picTPV.Image = CType(resources.GetObject("picTPV.Image"), System.Drawing.Image)
        Me.picTPV.Location = New System.Drawing.Point(1174, 478)
        Me.picTPV.Name = "picTPV"
        Me.picTPV.Size = New System.Drawing.Size(99, 79)
        Me.picTPV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTPV.TabIndex = 29
        Me.picTPV.TabStop = False
        '
        'lbTPV
        '
        Me.lbTPV.AutoSize = True
        Me.lbTPV.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lbTPV.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTPV.Location = New System.Drawing.Point(1097, 450)
        Me.lbTPV.Name = "lbTPV"
        Me.lbTPV.Size = New System.Drawing.Size(204, 25)
        Me.lbTPV.TabIndex = 30
        Me.lbTPV.Text = "Terminal de Venta"
        '
        'PantallaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1273, 741)
        Me.Controls.Add(Me.lbTPV)
        Me.Controls.Add(Me.picTPV)
        Me.Controls.Add(Me.lbProductos)
        Me.Controls.Add(Me.picProductos)
        Me.Controls.Add(Me.btnGestionBusqueda)
        Me.Controls.Add(Me.lbUsuarios)
        Me.Controls.Add(Me.lbConsultas)
        Me.Controls.Add(Me.picStock)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbGestionStock)
        Me.Controls.Add(Me.lbSocios)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbGestionEmpleados)
        Me.Controls.Add(Me.lbGestionLibros)
        Me.Controls.Add(Me.btnGestionLibros)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.picUsuarios)
        Me.Controls.Add(Me.picSocios)
        Me.Controls.Add(Me.picEmple)
        Me.Controls.Add(Me.picYellowCircleBack)
        Me.Controls.Add(Me.picYellowCircleBackOutLine)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PantallaPrincipal"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pantalla Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picSocios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEmple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYellowCircleBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYellowCircleBackOutLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTPV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnGestionLibros As Button
    Friend WithEvents lbGestionLibros As Label
    Friend WithEvents lbGestionEmpleados As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbSocios As Label
    Friend WithEvents lbGestionStock As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents picSocios As PictureBox
    Friend WithEvents picUsuarios As PictureBox
    Friend WithEvents picStock As PictureBox
    Friend WithEvents picEmple As PictureBox
    Friend WithEvents lbUsuarios As Label
    Friend WithEvents lbRol As Label
    Friend WithEvents lbtxtRol As Label
    Friend WithEvents lbConsultas As Label
    Friend WithEvents btnGestionBusqueda As Button
    Friend WithEvents picYellowCircleBack As PictureBox
    Friend WithEvents picYellowCircleBackOutLine As PictureBox
    Friend WithEvents picProductos As PictureBox
    Friend WithEvents lbProductos As Label
    Friend WithEvents picTPV As PictureBox
    Friend WithEvents lbTPV As Label
End Class
