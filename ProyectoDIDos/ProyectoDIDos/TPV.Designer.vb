<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TPV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TPV))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxProductos = New System.Windows.Forms.ComboBox()
        Me.lbxCarrito = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAnadirproducto = New System.Windows.Forms.Button()
        Me.btnQuitarProducto = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbPrecioTotalText = New System.Windows.Forms.Label()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PantallaPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeLibrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeBusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeUsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenúPrincipaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(683, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 220)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Location = New System.Drawing.Point(255, 285)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(519, 349)
        Me.Panel4.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(516, 346)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(368, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Productos :"
        '
        'cbxProductos
        '
        Me.cbxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProductos.FormattingEnabled = True
        Me.cbxProductos.Items.AddRange(New Object() {"Libros", "Gafas"})
        Me.cbxProductos.Location = New System.Drawing.Point(448, 247)
        Me.cbxProductos.Name = "cbxProductos"
        Me.cbxProductos.Size = New System.Drawing.Size(152, 21)
        Me.cbxProductos.TabIndex = 17
        '
        'lbxCarrito
        '
        Me.lbxCarrito.FormattingEnabled = True
        Me.lbxCarrito.Location = New System.Drawing.Point(831, 356)
        Me.lbxCarrito.Name = "lbxCarrito"
        Me.lbxCarrito.Size = New System.Drawing.Size(519, 173)
        Me.lbxCarrito.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(149, 719)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Carrito :"
        '
        'btnAnadirproducto
        '
        Me.btnAnadirproducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnAnadirproducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnadirproducto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAnadirproducto.Location = New System.Drawing.Point(317, 653)
        Me.btnAnadirproducto.Name = "btnAnadirproducto"
        Me.btnAnadirproducto.Size = New System.Drawing.Size(112, 46)
        Me.btnAnadirproducto.TabIndex = 22
        Me.btnAnadirproducto.Text = "Añadir"
        Me.btnAnadirproducto.UseVisualStyleBackColor = False
        '
        'btnQuitarProducto
        '
        Me.btnQuitarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnQuitarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuitarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnQuitarProducto.Location = New System.Drawing.Point(530, 653)
        Me.btnQuitarProducto.Name = "btnQuitarProducto"
        Me.btnQuitarProducto.Size = New System.Drawing.Size(112, 46)
        Me.btnQuitarProducto.TabIndex = 23
        Me.btnQuitarProducto.Text = "Quitar"
        Me.btnQuitarProducto.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(828, 547)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Precio Total  :"
        '
        'lbPrecioTotalText
        '
        Me.lbPrecioTotalText.AutoSize = True
        Me.lbPrecioTotalText.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbPrecioTotalText.Location = New System.Drawing.Point(907, 547)
        Me.lbPrecioTotalText.Name = "lbPrecioTotalText"
        Me.lbPrecioTotalText.Size = New System.Drawing.Size(19, 13)
        Me.lbPrecioTotalText.TabIndex = 25
        Me.lbPrecioTotalText.Text = "----"
        '
        'btnCobrar
        '
        Me.btnCobrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCobrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCobrar.Location = New System.Drawing.Point(1014, 564)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(186, 46)
        Me.btnCobrar.TabIndex = 26
        Me.btnCobrar.Text = "Proceder a realizar pago"
        Me.btnCobrar.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PantallaPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PantallaPrincipalToolStripMenuItem
        '
        Me.PantallaPrincipalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeLibrosToolStripMenuItem1, Me.GestionDeBusquedaToolStripMenuItem, Me.GestionEmpleadosToolStripMenuItem, Me.GestionDeUsuariosToolStripMenuItem1, Me.GestionDeClientesToolStripMenuItem1, Me.GestiónProductosToolStripMenuItem, Me.GestiónDeStockToolStripMenuItem, Me.ToolStripSeparator1, Me.MenúPrincipaToolStripMenuItem})
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
        'GestiónDeStockToolStripMenuItem
        '
        Me.GestiónDeStockToolStripMenuItem.Image = CType(resources.GetObject("GestiónDeStockToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestiónDeStockToolStripMenuItem.Name = "GestiónDeStockToolStripMenuItem"
        Me.GestiónDeStockToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.GestiónDeStockToolStripMenuItem.Text = "Gestión de Stock"
        '
        'TPV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.lbPrecioTotalText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnQuitarProducto)
        Me.Controls.Add(Me.btnAnadirproducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbxCarrito)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxProductos)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TPV"
        Me.Text = "TPUV Casa de Libro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxProductos As ComboBox
    Friend WithEvents lbxCarrito As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAnadirproducto As Button
    Friend WithEvents btnQuitarProducto As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbPrecioTotalText As Label
    Friend WithEvents btnCobrar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PantallaPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeLibrosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionDeBusquedaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeUsuariosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionDeClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestiónProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MenúPrincipaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónDeStockToolStripMenuItem As ToolStripMenuItem
End Class
