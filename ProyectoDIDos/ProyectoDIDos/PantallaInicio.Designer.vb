<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaInicio))
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbClave = New System.Windows.Forms.Label()
        Me.PanelPeque = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelGrande = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAccederBackdoor = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelPeque.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGrande.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.HelpProvider1.SetHelpString(Me.txtUsuario, "Introduzca hasta 10 caracteres (solo minúsculas, no letras).")
        Me.txtUsuario.Location = New System.Drawing.Point(100, 34)
        Me.txtUsuario.Name = "txtUsuario"
        Me.HelpProvider1.SetShowHelp(Me.txtUsuario, True)
        Me.txtUsuario.Size = New System.Drawing.Size(145, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(100, 62)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(145, 20)
        Me.txtClave.TabIndex = 3
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.Location = New System.Drawing.Point(21, 34)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(76, 20)
        Me.lbUsuario.TabIndex = 4
        Me.lbUsuario.Text = "Usuario:"
        '
        'lbClave
        '
        Me.lbClave.AutoSize = True
        Me.lbClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbClave.Location = New System.Drawing.Point(36, 64)
        Me.lbClave.Name = "lbClave"
        Me.lbClave.Size = New System.Drawing.Size(55, 18)
        Me.lbClave.TabIndex = 5
        Me.lbClave.Text = "Clave:"
        '
        'PanelPeque
        '
        Me.PanelPeque.BackColor = System.Drawing.Color.DarkGray
        Me.PanelPeque.Controls.Add(Me.ProgressBar1)
        Me.PanelPeque.Controls.Add(Me.btnAcceder)
        Me.PanelPeque.Controls.Add(Me.lbUsuario)
        Me.PanelPeque.Controls.Add(Me.lbClave)
        Me.PanelPeque.Controls.Add(Me.txtUsuario)
        Me.PanelPeque.Controls.Add(Me.txtClave)
        Me.PanelPeque.Location = New System.Drawing.Point(526, 357)
        Me.PanelPeque.Name = "PanelPeque"
        Me.PanelPeque.Size = New System.Drawing.Size(300, 198)
        Me.PanelPeque.TabIndex = 6
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 175)
        Me.ProgressBar1.Maximum = 10000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(294, 23)
        Me.ProgressBar1.TabIndex = 8
        '
        'btnAcceder
        '
        Me.btnAcceder.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAcceder.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAcceder.Location = New System.Drawing.Point(100, 101)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(102, 38)
        Me.btnAcceder.TabIndex = 10
        Me.btnAcceder.Text = "Acceder"
        Me.btnAcceder.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(626, 561)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 38)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Contacta con nosotros"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(227, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PanelGrande
        '
        Me.PanelGrande.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PanelGrande.Controls.Add(Me.Panel1)
        Me.PanelGrande.Controls.Add(Me.Button1)
        Me.PanelGrande.Controls.Add(Me.PanelPeque)
        Me.PanelGrande.Controls.Add(Me.btnAccederBackdoor)
        Me.PanelGrande.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrande.Location = New System.Drawing.Point(0, 0)
        Me.PanelGrande.Name = "PanelGrande"
        Me.PanelGrande.Size = New System.Drawing.Size(1273, 602)
        Me.PanelGrande.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(338, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(674, 320)
        Me.Panel1.TabIndex = 12
        '
        'btnAccederBackdoor
        '
        Me.btnAccederBackdoor.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnAccederBackdoor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAccederBackdoor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAccederBackdoor.Location = New System.Drawing.Point(734, 458)
        Me.btnAccederBackdoor.Name = "btnAccederBackdoor"
        Me.btnAccederBackdoor.Size = New System.Drawing.Size(89, 38)
        Me.btnAccederBackdoor.TabIndex = 11
        Me.btnAccederBackdoor.Text = "&Acceder"
        Me.btnAccederBackdoor.UseVisualStyleBackColor = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\Tomás\Desktop\ProyectoDIDos\Repo_ProyectDIDos\ProyectoDIDos\ProyectoDIDo" &
    "s\bin\Debug\Ayuda software Casa del Libro.chm"
        '
        'PantallaInicio
        '
        Me.AcceptButton = Me.btnAcceder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1273, 602)
        Me.Controls.Add(Me.PanelGrande)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PantallaInicio"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelPeque.ResumeLayout(False)
        Me.PanelPeque.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGrande.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtClave As TextBox
    Friend WithEvents lbUsuario As Label
    Friend WithEvents lbClave As Label
    Friend WithEvents PanelPeque As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelGrande As Panel
    Friend WithEvents btnAcceder As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents btnAccederBackdoor As Button
End Class
