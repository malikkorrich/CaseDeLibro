<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionCobro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionCobro))
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbCobrado = New System.Windows.Forms.Label()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label_numDevolver = New System.Windows.Forms.Label()
        Me.Label_devolver = New System.Windows.Forms.Label()
        Me.btn_ponerPunto = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox_importe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_finalizarImprimir = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxSocio = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\Tomás\Desktop\GitHubProyecto\ProyectoD\Colchonería CuestaV0.2\Colchonerí" &
    "a Cuesta\Colchonería Cuesta\Resources\ayuda.txt"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Método de pago:"
        '
        'lbCobrado
        '
        Me.lbCobrado.AutoSize = True
        Me.lbCobrado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbCobrado.Location = New System.Drawing.Point(191, 32)
        Me.lbCobrado.Name = "lbCobrado"
        Me.lbCobrado.Size = New System.Drawing.Size(39, 13)
        Me.lbCobrado.TabIndex = 45
        Me.lbCobrado.Text = "Label3"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenúToolStripMenuItem.Text = "Menú"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(124, 388)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label_numDevolver
        '
        Me.Label_numDevolver.AutoSize = True
        Me.Label_numDevolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_numDevolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label_numDevolver.Location = New System.Drawing.Point(132, 213)
        Me.Label_numDevolver.Name = "Label_numDevolver"
        Me.Label_numDevolver.Size = New System.Drawing.Size(0, 24)
        Me.Label_numDevolver.TabIndex = 43
        Me.Label_numDevolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_devolver
        '
        Me.Label_devolver.AutoSize = True
        Me.Label_devolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_devolver.Location = New System.Drawing.Point(3, 213)
        Me.Label_devolver.Name = "Label_devolver"
        Me.Label_devolver.Size = New System.Drawing.Size(95, 20)
        Me.Label_devolver.TabIndex = 42
        Me.Label_devolver.Text = "A devolver ="
        '
        'btn_ponerPunto
        '
        Me.btn_ponerPunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ponerPunto.Location = New System.Drawing.Point(618, 263)
        Me.btn_ponerPunto.Name = "btn_ponerPunto"
        Me.btn_ponerPunto.Size = New System.Drawing.Size(72, 58)
        Me.btn_ponerPunto.TabIndex = 41
        Me.btn_ponerPunto.Text = "&."
        Me.btn_ponerPunto.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(452, 263)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(156, 58)
        Me.btn0.TabIndex = 40
        Me.btn0.Text = "&0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_borrar.Location = New System.Drawing.Point(699, 71)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(59, 250)
        Me.btn_borrar.TabIndex = 39
        Me.btn_borrar.Text = "&Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(618, 71)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(72, 58)
        Me.btn9.TabIndex = 38
        Me.btn9.Text = "&9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(536, 71)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(72, 58)
        Me.btn8.TabIndex = 37
        Me.btn8.Text = "&8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(452, 71)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(72, 58)
        Me.btn7.TabIndex = 36
        Me.btn7.Text = "&7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(618, 135)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(72, 58)
        Me.btn6.TabIndex = 35
        Me.btn6.Text = "&6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(536, 135)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(72, 58)
        Me.btn5.TabIndex = 34
        Me.btn5.Text = "&5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(452, 135)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(72, 58)
        Me.btn4.TabIndex = 33
        Me.btn4.Text = "&4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(536, 199)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(72, 58)
        Me.btn3.TabIndex = 32
        Me.btn3.Text = "&3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(618, 199)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(72, 58)
        Me.btn2.TabIndex = 31
        Me.btn2.Text = "&2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(452, 199)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(72, 58)
        Me.btn1.TabIndex = 30
        Me.btn1.Text = "&1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Tarjeta", "Efectivo"})
        Me.ComboBox1.Location = New System.Drawing.Point(185, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'TextBox_importe
        '
        Me.TextBox_importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_importe.Location = New System.Drawing.Point(185, 113)
        Me.TextBox_importe.MaxLength = 8
        Me.TextBox_importe.Name = "TextBox_importe"
        Me.TextBox_importe.Size = New System.Drawing.Size(100, 24)
        Me.TextBox_importe.TabIndex = 28
        Me.TextBox_importe.Text = "0"
        Me.TextBox_importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Importe ="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Total a pagar ="
        '
        'btn_finalizarImprimir
        '
        Me.btn_finalizarImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalizarImprimir.Location = New System.Drawing.Point(448, 344)
        Me.btn_finalizarImprimir.Name = "btn_finalizarImprimir"
        Me.btn_finalizarImprimir.Size = New System.Drawing.Size(310, 51)
        Me.btn_finalizarImprimir.TabIndex = 25
        Me.btn_finalizarImprimir.Text = "&Finalizar e imprimir recibo"
        Me.btn_finalizarImprimir.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbxSocio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbCobrado)
        Me.Panel1.Controls.Add(Me.TextBox_importe)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label_numDevolver)
        Me.Panel1.Controls.Add(Me.Label_devolver)
        Me.Panel1.Location = New System.Drawing.Point(12, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 250)
        Me.Panel1.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Socio"
        '
        'cbxSocio
        '
        Me.cbxSocio.AutoSize = True
        Me.cbxSocio.Location = New System.Drawing.Point(342, 220)
        Me.cbxSocio.Name = "cbxSocio"
        Me.cbxSocio.Size = New System.Drawing.Size(15, 14)
        Me.cbxSocio.TabIndex = 47
        Me.cbxSocio.UseVisualStyleBackColor = True
        '
        'GestionCobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_ponerPunto)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn_finalizarImprimir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionCobro"
        Me.Text = "GestionCobro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label4 As Label
    Friend WithEvents lbCobrado As Label
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_numDevolver As Label
    Friend WithEvents Label_devolver As Label
    Friend WithEvents btn_ponerPunto As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn_borrar As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox_importe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_finalizarImprimir As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxSocio As CheckBox
End Class
