Public Class PantallaPrincipal

    ' Ir a gestion libros.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGestionLibros.Click
        If Me.lbtxtRol.Text.Equals("Guest") Then
            MsgBox("No tiene los permisos necesarios. Por favor, acceda con otro usuario que tenga un rol que le permita gestionar libros.", 64, "Falta de permisos.")
        Else
            Me.Hide()
            GestionLibro.Show()
        End If

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        MsgBox("Cerrando sesión", 64, "Cierre de sesion.")
        Me.Close()
        PantallaInicio.Show()
    End Sub

    Private Sub btnGestionEmpleados_Click(sender As Object, e As EventArgs)
        GestionEmpleados.Show()
        Me.Hide()

    End Sub

    Private Sub btnGestionBusqueda_Click(sender As Object, e As EventArgs) Handles btnGestionBusqueda.Click
        Me.Hide()
        GestionBusqueda.Show()

    End Sub

    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'iniciar notifyIcon
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.BalloonTipTitle = "Pantalla Principal"
        NotifyIcon1.BalloonTipText = "Inicio de Aplicacion Casa de Libro"
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.ShowBalloonTip(1000)



        'añadir la fecha en status label
        ToolStripStatusLabel1.Text = DateTime.Now.ToLongDateString.ToString

        'definir la ruta del  fichiero help
        HelpProvider1.HelpNamespace = System.Environment.CurrentDirectory & "\\Ayuda software Casa del Libro.chm"
    End Sub


    Private Sub btnStock_Click(sender As Object, e As EventArgs)
        Me.Hide()
        GestionStock.Show()
    End Sub

    Private Sub lbGestionStock_Click(sender As Object, e As EventArgs) Handles lbGestionStock.Click

    End Sub

    Private Sub lbGestionEmpleados_Click(sender As Object, e As EventArgs) Handles lbGestionEmpleados.Click

    End Sub

    Private Sub btnSocios_Click(sender As Object, e As EventArgs)
        Me.Hide()
        GestionClienteSocio.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picSocios.Click

        If Me.lbtxtRol.Text.Equals("Administrador") Or Me.lbtxtRol.Text.Equals("Usuario") Then
            Me.Hide()
            GestionClienteSocio.Show()

        Else
            MsgBox("No tiene los permisos necesarios. Por favor, acceda con otro usuario que tenga un rol que le permita gestionar usuarios.", 64, "Falta de permisos.")
        End If

    End Sub

    Private Sub PicEmple_Click(sender As Object, e As EventArgs) Handles picUsuarios.Click
        If Me.lbtxtRol.Text.Equals("Administrador") Then
            GestionUsuarios.Show()
            Me.Hide()

        Else
            MsgBox("No tiene los permisos necesarios. Por favor, acceda con otro usuario que tenga un rol que le permita gestionar usuarios.", 64, "Falta de permisos.")
        End If

    End Sub

    Private Sub picStock_Click(sender As Object, e As EventArgs) Handles picStock.Click
        If lbtxtRol.Text.Equals("Administrador") Or lbtxtRol.Text.Equals("Usuario") Then
            Me.Hide()
            GestionStock.Show()

        Else
            MsgBox("No tiene los permisos necesarios. Por favor, acceda con otro usuario que tenga un rol que le permita gestionar stock.", 64, "Falta de permisos.")
        End If

    End Sub

    Private Sub picUsuarios_Click(sender As Object, e As EventArgs) Handles picEmple.Click
        If Me.lbtxtRol.Text.Equals("Administrador") Then

            Me.Hide()
            GestionEmpleados.Show()

        Else
            MsgBox("No tiene los permisos necesarios. Por favor, acceda con otro usuario que tenga un rol que le permita gestionar empleados.", 64, "Falta de permisos.")
        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MessageBox.Show("¿Está seguro que desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No) Then

        Else
            Me.Close()
            PantallaInicio.Close()
        End If


    End Sub



    'Metodo de evento cerrando fourmulario 
    Private Sub Form1_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PantallaInicio.Show()
        Me.Dispose()
    End Sub

    Private Sub picProductos_Click(sender As Object, e As EventArgs) Handles picProductos.Click
        If Me.lbtxtRol.Text.Equals("Administrador") Or Me.lbtxtRol.Text.Equals("Usuario") Then
            Me.Hide()
            GestionProductos.Show()

        Else
            MsgBox("No tiene los permisos necesarios. Por favor, acceda con otro usuario que tenga un rol que le permita gestionar usuarios.", 64, "Falta de permisos.")
        End If
    End Sub

    ' Método llamado desde el evento load de los formularios para saber
    ' qué botones están disponibles, según el rol de la persona que accedió.
    Public Sub darPermisos()
        ' Comprobarmos permisos
        If lbtxtRol.Text.Equals("Usuario") Then

            GestionBusqueda.GestionDeUsuariosToolStripMenuItem1.Enabled = False
            GestionBusqueda.GestionEmpleadosToolStripMenuItem.Enabled = False
            GestionLibro.GestionDeEmpleadosToolStripMenuItem.Enabled = False
            GestionLibro.GestionDeUsuariosToolStripMenuItem1.Enabled = False
            GestionClienteSocio.GestionDeUsuariosToolStripMenuItem1.Enabled = False
            GestionClienteSocio.GestionDeEmpleadosToolStripMenuItem1.Enabled = False
            GestionProductos.GestionDeUsuariosToolStripMenuItem1.Enabled = False
            GestionProductos.GestionEmpleadosToolStripMenuItem.Enabled = False
            GestionStock.GestionEmpleadosToolStripMenuItem.Enabled = False
            GestionStock.GestionDeUsuariosToolStripMenuItem1.Enabled = False
            TPV.GestionDeUsuariosToolStripMenuItem1.Enabled = False
            TPV.GestionEmpleadosToolStripMenuItem.Enabled = False

            ' Se entra como Guest /invitado.
        ElseIf lbtxtRol.Text.Equals("Guest") Then


            GestionBusqueda.GestionDeClientesToolStripMenuItem1.Enabled = False
            GestionBusqueda.GestionEmpleadosToolStripMenuItem.Enabled = False
            GestionBusqueda.GestionDeUsuariosToolStripMenuItem1.Enabled = False
            GestionBusqueda.GestiónProductosToolStripMenuItem.Enabled = False
            GestionBusqueda.GestionDeLibrosToolStripMenuItem1.Enabled = False
            GestionBusqueda.GestionDeStockToolStripMenuItem.Enabled = False
            GestionBusqueda.TPVToolStripMenuItem.Enabled = False

        End If

    End Sub

    Private Sub picTPV_Click(sender As Object, e As EventArgs) Handles picTPV.Click

        If Me.lbtxtRol.Text.Equals("Administrador") Or Me.lbtxtRol.Text.Equals("Usuario") Then
            Me.Hide()
            TPV.Show()

        Else
            MsgBox("No tiene los permisos necesarios. Por favor, acceda con otro usuario que tenga un rol que le permita gestionar usuarios.", 64, "Falta de permisos.")
        End If

    End Sub
End Class