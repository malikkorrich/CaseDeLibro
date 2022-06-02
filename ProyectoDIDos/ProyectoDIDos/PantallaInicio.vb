Imports libValidacionDatos.Validacion
' Vamos a usar esta librería para validar datos (usuarios, nombres de empleados, libros, etc.)
Imports LibConexion
Imports System.IO

Public Class PantallaInicio
    Dim validador As New libValidacionDatos.Validacion
    Dim queryAdaptador As String = "SELECT * FROM Usuarios"
    Dim datasetTableName As String = "Usuarios"
    Dim validCon As New LibConexion.GestionConexion(queryAdaptador, datasetTableName)
    ' Se usara en todos los formularios para saber con qué rol se ha accedido.


    ' Cada vez que cambia el texto del campo de usuario se ejecuta este método.
    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        Try
            ProgressBar1.Visible = False

            ' Si se recibe 0, se está recibiendo que se va a validar un usuario. máximo 10 caracteres (minuscula, sin tildes, etc)
            ' Si es 1, es nombre.
            ' Si es 2 es apellido.
            ' Si es 3 es dirección.
            If validador.validarUsuario(txtUsuario.Text, 0) Then

            Else
                MsgBox("Ha introducido carácter no válido o se ha excedido en la longitud.")
                txtUsuario.Clear()

            End If


        Catch ex As Exception

            validCon.mensajeErrorDatos()
            validCon.errorLogWrite()
        End Try

    End Sub



    ' Cada vez que cambia el texto del campo de clave se ejecuta este método.
    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged

        ' Si se recibe 0 se está validando contraseña en inicio de sesión. (se permiten 6 dígitos)
        ' Las dos lineas de abajo cambiarán porque lo que está es del proyecto anterior.
        ' Si se recibe 1 se está validando teléfono. (se permite 9 dígitos).
        ' Si se recibe 2 se está validando precios en productos
        Try
            If validador.validarCodigo(txtClave.Text, 0) Then

            Else
                MsgBox("Ha introducido carácter no válido o se ha excedido en la longitud.")
                txtClave.Clear()

            End If

        Catch ex As Exception

            validCon.mensajeErrorDatos()
        validCon.errorLogWrite()
        End Try
    End Sub

    ' Botón acceder
    ' Cuando se pulsa el botón acceder se comprobará si los datos existen en la base de datos
    ' y si se corresponden con los datos introducidos.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Dim queRol As Integer
        Try
            If Not txtUsuario.Text = "" And Not txtClave.Text = "" Then


                ' Ralizamos query para ver si existen estos datos. Se pasan como parámetros los valores de los textBox
                ' Solo si se encuentra una fila se procederá a ver si el usuario encontrado es admin, usuario, etc...
                If validCon.selectDosWhere("*", "usuarios", "usuario", txtUsuario.Text, "clave", txtClave.Text) Then
                    queRol = validCon.getRol("usuario", txtUsuario.Text, "clave", txtClave.Text)
                    ' Controlar con otra query si el rol es admin o usuario.
                    ' Entramos como Admin
                    If queRol = 1 Then
                        MsgBox("Bienvenido Admin", 64, "Acceso")
                        iniciarProgessBar()
                        PantallaPrincipal.Show()
                        Me.Hide()
                        PantallaPrincipal.lbtxtRol.Text = "Administrador"

                        ' Guardamos la hora de acceso del usuario (con sus datos):
                        Try
                            Dim datosAcceso As New FileStream("logAcceso.txt", FileMode.Append, FileAccess.Write)
                            Dim sw As New StreamWriter(datosAcceso)
                            sw.WriteLine("El usuario:" & txtUsuario.Text)
                            sw.WriteLine("La clave:" & txtClave.Text)
                            sw.WriteLine("Acceso en fecha: " & Now)

                            ' Cerramos los flujos para escribir en el log de acceso.
                            sw.Close()
                            datosAcceso.Close()
                        Catch ex As Exception
                            validador.mensajeErrorDatos()
                            validador.errorLogWrite()
                        End Try
                        ' Entramos como Usuario 


                    ElseIf queRol = 2 Then
                        MsgBox("Bienvenido Usuario", 64, "Acceso")
                        iniciarProgessBar()
                        PantallaPrincipal.Show()
                        Me.Hide()
                        PantallaPrincipal.lbtxtRol.Text = "Usuario"

                        ' Podemos decidir: según el formulario vamos poniendo qué permisos hay segun el contenido del label
                        ' ponemos aqui qué accesos tiene cada rol.
                        ' Aquí tiene la ventaja de que está todo en el mismo sitio, mientras que comprobar el label
                        ' en cada formulario requiere justamente eso, ir form por form viendo qué está deshabilitado
                        ' según el contenido del label. (Admin, usuario, etc).
                        ' Vamos a probar la solución de Malik y a poner todo aquí de una:
                        'PantallaPrincipal.picUsuarios.Enabled = False
                        'PantallaPrincipal.picEmple.Enabled = False
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


                        ' Guardamos la hora de acceso del usuario (con sus datos):
                        Try
                            Dim datosAcceso As New FileStream("logAcceso.txt", FileMode.Append, FileAccess.Write)
                            Dim sw As New StreamWriter(datosAcceso)
                            sw.WriteLine("El usuario:" & txtUsuario.Text)
                            sw.WriteLine("La clave:" & txtClave.Text)
                            sw.WriteLine("Acceso en fecha: " & Now)

                            ' Cerramos los flujos para escribir en el log de acceso.
                            sw.Close()
                            datosAcceso.Close()
                        Catch ex As Exception
                            validador.mensajeErrorDatos()
                            validador.errorLogWrite()
                        End Try
                        ' Se entra como Guest /invitado.
                    ElseIf queRol = 3 Then
                        MsgBox("Bienvenido Guest", 64, "Acceso")
                        PantallaPrincipal.lbtxtRol.Text = "Guest"

                        iniciarProgessBar()
                        PantallaPrincipal.Show()
                        Me.Hide()

                        ' Al guest solo se le permite buscar libros/realizar consultas.

                        'PantallaPrincipal.picUsuarios.Enabled = False
                        'PantallaPrincipal.picEmple.Enabled = False
                        'PantallaPrincipal.picStock.Enabled = False
                        'PantallaPrincipal.picSocios.Enabled = False
                        'PantallaPrincipal.btnGestionLibros.Enabled = False
                        GestionBusqueda.GestionDeClientesToolStripMenuItem1.Enabled = False
                        GestionBusqueda.GestionEmpleadosToolStripMenuItem.Enabled = False
                        GestionBusqueda.GestionDeUsuariosToolStripMenuItem1.Enabled = False
                        GestionBusqueda.GestiónProductosToolStripMenuItem.Enabled = False
                        GestionBusqueda.GestionDeLibrosToolStripMenuItem1.Enabled = False
                        GestionBusqueda.GestionDeStockToolStripMenuItem.Enabled = False
                        ' Guardamos la hora de acceso del usuario (con sus datos):
                        Try
                            Dim datosAcceso As New FileStream("logAcceso.txt", FileMode.Append, FileAccess.Write)
                            Dim sw As New StreamWriter(datosAcceso)
                            sw.WriteLine("El usuario:" & txtUsuario.Text)
                            sw.WriteLine("La clave:" & txtClave.Text)
                            sw.WriteLine("Acceso en fecha: " & Now)

                            ' Cerramos los flujos para escribir en el log de acceso.
                            sw.Close()
                            datosAcceso.Close()
                        Catch ex As Exception
                            validador.mensajeErrorDatos()
                            validador.errorLogWrite()
                        End Try
                    End If

                End If
            Else
                MsgBox("Por favor, rellene los campos antes de intentar acceder a la aplicación.", 64, "Ausencia de datos.")
            End If

        Catch ex As Exception

            validCon.mensajeErrorDatos()
            validCon.errorLogWrite()
        End Try
    End Sub


    ' metodo para iniciar el progressbar  primero se hace visible y luego se comprueba su valor 
    'luego se incrementa valor de progressbar con un boucle
    Public Sub iniciarProgessBar()
        Try
            ProgressBar1.Visible = True
            If ProgressBar1.Value >= 10000 Then
                ProgressBar1.Value = 0
            Else
                For i = 1 To 10000
                    ProgressBar1.Value = i
                Next

                ProgressBar1.Visible = False
                ProgressBar1.Value = ProgressBar1.Minimum
            End If

        Catch ex As Exception

            validCon.mensajeErrorDatos()
        validCon.errorLogWrite()
        End Try
    End Sub

    'Metodo que responde al evento click del linklabel contacto
    Private Sub linkContacto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("https://www.casadellibro.com/atencion-al-clienteNF/consulta-dudas")
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://www.casadellibro.com/atencion-al-clienteNF/consulta-dudas")
    End Sub

    Private Sub PantallaInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'definir la ruta del  fichiero help
        HelpProvider1.HelpNamespace = System.Environment.CurrentDirectory & "\\Ayuda software Casa del Libro.chm"
    End Sub



    Private Sub btnAccederBackdoor_Click(sender As Object, e As EventArgs) Handles btnAccederBackdoor.Click
        PantallaPrincipal.Show()
        PantallaPrincipal.lbtxtRol.Text = "Administrador"
    End Sub


End Class
