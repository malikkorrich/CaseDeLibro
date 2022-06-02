' No hace falta, en principio, importar la librería porque está en la carpeta del proyecto
' pero por las dudas, dejamos al línea.
Imports libValidacionDatos

Public Class GestionClienteSocio
    'aqui se crea  un objeto de la clase GestionConexion de la liberia 

    Dim queryAdaptador As String = "SELECT * FROM ClientesSocios"
    Dim datasetTableName As String = "ClientesSocios"

    Dim gestion As New LibConexion.GestionConexion(queryAdaptador, datasetTableName)
    Public datatable As New DataTable
    Public getIdFila As String

    ' vvv Variables para la validación de datos vvvv
    Dim validDatos As New libValidacionDatos.Validacion

    Private Sub GestionClienteSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' releacionar los campos de la tabla con los textbox se usando DataBindi    txtID.DataBindings.Add("text", gestion.getDataSet, "ClientesSocios.id")
            txtID.DataBindings.Add("text", gestion.getDataSet, "ClientesSocios.Id")
            txtNombre.DataBindings.Add("text", gestion.getDataSet, "ClientesSocios.Nombre")
            txtApellidos.DataBindings.Add("text", gestion.getDataSet, "ClientesSocios.Apellidos")
            txtTelefono.DataBindings.Add("text", gestion.getDataSet, "ClientesSocios.Telefono")
            txtEmail.DataBindings.Add("text", gestion.getDataSet, "ClientesSocios.Email")
            fechaAlta.DataBindings.Add("text", gestion.getDataSet, "ClientesSocios.FechaAlta")
            checkSocio.DataBindings.Add("checked", gestion.getDataSet, "ClientesSocios.Socio", True)

            cargarPantalla()
            'metodo para mostrar  donde esta cursor y en datagridview del total de la filas
            getNumeroRegistros()


            'añadir la fecha en status label
            ToolStripStatusLabel1.Text = DateTime.Now.ToLongDateString.ToString


            ' Llamamos al método para ver qué botones de la barra de herramientas están disponibles para
            ' este usuario.
            PantallaPrincipal.darPermisos()

            'definir la ruta del  fichiero help
            HelpProvider1.HelpNamespace = System.Environment.CurrentDirectory & "\\Ayuda software Casa del Libro.chm"

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try





    End Sub

    Private Sub MenúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúPrincipalToolStripMenuItem.Click
        Me.Close()
        PantallaPrincipal.Show()

    End Sub


    ' Alta de cliente/socio
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Try
            Timer1.Enabled = True
            If (txtID.Text = "" Or txtNombre.Text = "" Or txtApellidos.Text = "" Or txtTelefono.Text = "" Or txtEmail.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Clientes Socios")
            Else
                If fechaAlta.Value = Now.Date Then

                    ' Validamos el correo
                    If (validDatos.validarEmail(txtEmail.Text)) Then
                        ' Si es correcto seguimos con los insert
                        If gestion.insertClienteSocio(CInt(txtID.Text), txtNombre.Text, txtApellidos.Text, CInt(txtTelefono.Text), txtEmail.Text, fechaAlta.Value.ToShortDateString, Convert.ToBoolean(checkSocio.CheckState)) Then
                            cargarPantalla()
                            MsgBox("Cliente Insertado con éxito . ", 64, "Gestion Clientes Socios")
                            llimpiarPantalla()
                            cargarPantalla()
                            getNumeroRegistros()
                        Else
                            cargarPantalla()
                            MsgBox("Error Cliente no Insertado  . ", MsgBoxStyle.Exclamation, "Gestion Clientes Socios")
                        End If
                    Else
                        ' El correo no es válido y hay que cambiarlo.
                        txtEmail.Clear()
                        MsgBox(validDatos.mensajeInfoDatoInvalido("Correo electrónico"), 64, "Datos")


                    End If

                Else
                    MsgBox("Por favor seleccione una fecha valida  . ", 64, "Gestion Clientes Socios")
                End If

            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    'ojo todavia falta Arreglarla
    'En el evento buttonBuscar busca por id es por 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            'buscar por id 
            If txtBusID.Text = "" Then

                MsgBox("Por favor rellene El campo id . ", 64, "Gestion Clientes Socios")
            Else

                Dim pos As Integer = gestion.buscarPorCadena(txtBusID.Text, "clientessocios", " id")

                If pos <> -1 Then
                    DataGridView1.Rows(pos).Selected = True
                End If



            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    'En el evento textChange del campo txtBusNombre se busca por caracter 
    'se usa el metodo buscarporCaracter() que recibe dos parametros la caracter y nombre de la columna correspondiente en la tabla 
    Private Sub txtBusNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBusNombre.TextChanged
        Try
            gestion.buscarporCaracter(txtBusNombre.Text, "clientessocios", " nombre", "clientessocios")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView1.DataSource = gestion.getDataSet
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    Private Sub txtBusID_TextChanged(sender As Object, e As EventArgs) Handles txtBusID.TextChanged
        Try
            If (validDatos.validarCodigo(txtBusID.Text, 3)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("ID"), 64, "Datos")
                txtBusID.Clear()
            End If
        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    'En el evento textChange del campo txtBusNombre se busca por caracter 
    'se usa el metodo buscarporCaracter() que recibe dos parametros la caracter y nombre de la columna correspondiente en la tabla 
    Private Sub txtBusApellidos_TextChanged(sender As Object, e As EventArgs) Handles txtBusApellidos.TextChanged
        Try
            gestion.buscarporCaracter(txtBusApellidos.Text, "clientessocios", " apellidos", "clientessocios")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView1.DataSource = gestion.getDataSet
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub



    'En el evento button Modificar para modifica  una fila
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If (txtID.Text = "" Or txtNombre.Text = "" Or txtApellidos.Text = "" Or txtTelefono.Text = "" Or txtEmail.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Clientes Socios")
            Else
                'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
                ' y una vez seleccionda se recupera el id de la tabla para poder modifcar la fila 
                If DataGridView1.SelectedCells.Count > 0 Then
                    Dim valor As Integer = MsgBox("¿Esta seguro de que desea Modificar Cliente?", 36, "Gestion Clientes Socios")
                    If valor = MsgBoxResult.Yes Then
                        ' MsgBox(getIdFila)
                        Timer1.Enabled = True

                        If fechaAlta.Value > Now.Date Then
                            MsgBox("Por favor seleccione una fecha valida  . ", 64, "Gestion Clientes Socios")
                        Else

                            If gestion.modificarCliente(getIdFila, txtNombre.Text, txtApellidos.Text, txtTelefono.Text, txtEmail.Text, fechaAlta.Value.ToShortDateString, Convert.ToBoolean(checkSocio.CheckState), " ClientesSocios ", " id ") Then
                                MsgBox("Cliente Modificao con éxito . ", 64, "Gestion Clientes Socios")
                                cargarPantalla()
                            Else
                                MsgBox("Error Cliente no modificado  . ", MsgBoxStyle.Exclamation, "Gestion Clientes Socios")
                                'aqui se deselecta las celdas de datagridview
                                cargarPantalla()

                            End If
                        End If


                    End If

                Else
                    MsgBox("Por favor seleccione   un cliente . ", 64, "Gestion Clientes Socios")
                End If
            End If
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    'En el evento button Eliminar para eliminar una fila
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
        ' y una vez seleccionda se recupera el id de la tabla para poder eliminar la fila 
        Try
            If DataGridView1.SelectedCells.Count > 0 Then


                Dim valor As Integer = MsgBox("¿Esta seguro de que desea Elminar Cliente?", 36, "Gestion Clientes Socios")
                If valor = MsgBoxResult.Yes Then
                    Timer1.Enabled = True
                    ' MsgBox(getIdFila)

                    If gestion.eliminarFila(getIdFila, " clientessocios ", " id ") Then
                        MsgBox("Cliente Eliminado con éxito . ", 64, "Gestion Clientes Socios")
                        llimpiarPantalla()
                        cargarPantalla()
                        getNumeroRegistros()
                    Else
                        MsgBox("Error Cliente no Eliminado  . ", MsgBoxStyle.Exclamation, "Gestion Clientes Socios")
                        'aqui se deselecta las celdas de datagridview
                        cargarPantalla()

                    End If
                End If

            Else
                MsgBox("Por favor seleccione  un cliente . ", 64, "Gestion Clientes Socios")
            End If
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub




    'metodo para Actualizar y cargar los datos en data grid view
    Private Sub cargarPantalla()
        Try
            gestion.getDataSet.Clear()
            gestion.getAdapter.Fill(gestion.getDataSet, "ClientesSocios")
            'aqui se carga el DatagridView
            DataGridView1.DataSource = gestion.getDataSet
            DataGridView1.DataMember = "ClientesSocios"
            DataGridView1.ClearSelection()
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub



    'Metodo para limpiar los campos del formulario
    Private Sub llimpiarPantalla()
        txtID.Clear()
        txtNombre.Clear()
        txtApellidos.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        checkSocio.Checked = False
        'campos de busqueda
        txtBusID.Clear()
        txtBusNombre.Clear()


    End Sub


    'metodo para obtener elemento seleccionado del datagridview para poder programar el metodo Eliminar sin necesitar al biding
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'aqui se declara una var de tipo entero que va guardar el indice de la fila seleccionada usando evento e.RowIndex
        Try
            Dim indice As Integer
            indice = e.RowIndex
            'aqui se crea un objeto de la clase DataGridViewRow que nos va permitir obtener el valor 
            Dim selectedFila As DataGridViewRow

            'aqui se obtiene la fila pasandole el indice 
            Try
                selectedFila = DataGridView1.Rows(indice)
                getIdFila = selectedFila.Cells(0).Value.ToString

                'actualizar datagrid view
                cargarPantalla()
            Catch ex As Exception
                MsgBox("Por favor selecciona una fila valida")
            End Try

            'MsgBox(getIdFila)
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try

    End Sub



    ' ------------------------------ VALIDACIÓN DE CAMPOS -------------------------------------------------------------

    ' Validación del textbox ID.
    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        Try
            ' Si se recibe 0 se está validando contraseña en inicio de sesión. (se permiten 6 dígitos)
            ' Si se recibe 1 se está validando teléfono. (se permite 9 dígitos).
            ' Si se recibe 2 se está validando precios en productos
            ' Si recibe 3 es Id de cliente.
            If (validDatos.validarCodigo(txtID.Text, 3)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("ID"), 64, "Datos")
                txtID.Clear()
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    ' Validación tel textbox Nombre.
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        ' Si es 0, se está recibiendo que se va a validar un usuario.
        ' Si es 1, es nombre.
        ' Si es 2 es apellido.
        ' Si es 3 es dirección. -> Ejemmplo
        ' Ejemplos abajo
        ' 4 
        ' 5 
        ' 6 etc...
        ' Pasamos el valor 1 porque es un nombre
        Try
            If (validDatos.validarUsuario(txtNombre.Text, 1)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("Nombre"), 64, "Datos")
                txtNombre.Clear()
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    ' Validar apellidos
    Private Sub txtApellidos_TextChanged(sender As Object, e As EventArgs) Handles txtApellidos.TextChanged
        ' Si es 0, se está recibiendo que se va a validar un usuario.
        ' Si es 1, es nombre.
        ' Si es 2 es apellido.
        ' Si es 3 es dirección. -> Ejemmplo
        ' Ejemplos abajo
        ' 4 
        ' 5 
        ' 6 etc...
        ' Pasamos el valor 1 porque es un nombre
        Try
            If (validDatos.validarUsuario(txtApellidos.Text, 2)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("Apellidos"), 64, "Datos")
                txtApellidos.Clear()
            End If
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    ' Validar teléfono
    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged
        ' Si se recibe 0 se está validando contraseña en inicio de sesión. (se permiten 6 dígitos)
        ' Si se recibe 1 se está validando teléfono. (se permite 9 dígitos).
        ' Si se recibe 2 se está validando precios en productos
        ' vvv validaciones en proyecto Casa del libro:
        ' Si se recibe 3 se está validando un ID.
        Try
            If (validDatos.validarCodigo(txtTelefono.Text, 1)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("Teléfono"), 64, "Datos")
                txtTelefono.Clear()
            End If
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub



    'metodo para mostrar  donde esta cursor y en datagridview del total de la filas
    Private Sub getNumeroRegistros()
        Try
            lblNumero.Text = (BindingContext(gestion.getDataSet, "ClientesSocios").Position + 1).ToString + " de " +
            (BindingContext(gestion.getDataSet, "ClientesSocios").Count).ToString
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        'BindingContext(midataset, "Tabla").Position = DataGridView1.RowCount - 1
        Try
            BindingContext(gestion.getDataSet, "ClientesSocios").Position = BindingContext(gestion.getDataSet, "ClientesSocios").Count - 1
            btnUltimo.Enabled = False
            btnSiguiete.Enabled = False
            btnPrimero.Enabled = True
            btnAnterior.Enabled = True

            'llamar al metodo
            getNumeroRegistros()
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub btnSiguiete_Click(sender As Object, e As EventArgs) Handles btnSiguiete.Click
        'colacrtese con bindingContext en la dataset dandlole nombre en la posicion
        Try
            BindingContext(gestion.getDataSet, "ClientesSocios").Position += 1

            'llamar al metodo
            getNumeroRegistros()
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        'colacrtese con bindingContext en la dataset dandlole nombre en la posicion
        Try
            BindingContext(gestion.getDataSet, "ClientesSocios").Position -= 1
            btnSiguiete.Enabled = True
            btnUltimo.Enabled = True

            'llamar al metodo
            getNumeroRegistros()
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        Try
            BindingContext(gestion.getDataSet, "ClientesSocios").Position = 0
            btnPrimero.Enabled = False
            btnAnterior.Enabled = False
            btnUltimo.Enabled = True
            btnSiguiete.Enabled = True
            'llamar al metodo
            getNumeroRegistros()
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    ' Guardar/alta
    ' Mismo código que botón alta
    Private Sub toolsbtnGuardar_Click(sender As Object, e As EventArgs) Handles toolsbtnGuardar.Click
        Try
            If (txtID.Text = "" Or txtNombre.Text = "" Or txtApellidos.Text = "" Or txtTelefono.Text = "" Or txtEmail.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Clientes Socios")
            Else
                ' Validamos el correo
                If (validDatos.validarEmail(txtEmail.Text)) Then
                    ' Si es correcto seguimos con los insert
                    If gestion.insertClienteSocio(CInt(txtID.Text), txtNombre.Text, txtApellidos.Text, CInt(txtTelefono.Text), txtEmail.Text, fechaAlta.Value.ToShortDateString, Convert.ToBoolean(checkSocio.CheckState)) Then
                        cargarPantalla()
                        MsgBox("Cliente Insertado con éxito . ", 64, "Gestion Clientes Socios")
                        llimpiarPantalla()
                        cargarPantalla()
                        getNumeroRegistros()
                    Else
                        cargarPantalla()
                        MsgBox("Error Cliente no Insertado  . ", MsgBoxStyle.Exclamation, "Gestion Clientes Socios")
                    End If
                Else
                    ' El correo no es válido y hay que cambiarlo.
                    txtEmail.Clear()
                    MsgBox(validDatos.mensajeInfoDatoInvalido("Correo electrónico"), 64, "Datos")


                End If
            End If
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    ' Toolstrip Eliminar
    ' Misma función que botón eliminar.
    Private Sub toolsbtnEliminar_Click(sender As Object, e As EventArgs) Handles toolsbtnEliminar.Click
        'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
        ' y una vez seleccionda se recupera el id de la tabla para poder eliminar la fila 
        Try
            If DataGridView1.SelectedCells.Count > 0 Then


                Dim valor As Integer = MsgBox("¿Esta seguro de que desea Elminar Cliente?", 36, "Gestion Clientes Socios")
                If valor = MsgBoxResult.Yes Then
                    ' MsgBox(getIdFila)

                    If gestion.eliminarFila(getIdFila, " clientessocios ", " id ") Then
                        MsgBox("Cliente Eliminado con éxito . ", 64, "Gestion Clientes Socios")
                        llimpiarPantalla()
                        cargarPantalla()
                        getNumeroRegistros()
                    Else
                        MsgBox("Error Cliente no Eliminado  . ", MsgBoxStyle.Exclamation, "Gestion Clientes Socios")
                        'aqui se deselecta las celdas de datagridview
                        cargarPantalla()

                    End If
                End If

            Else
                MsgBox("Por favor seleccione  un cliente . ", 64, "Gestion Clientes Socios")
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        llimpiarPantalla()
    End Sub

    Private Sub toolsbtnNuevo_Click(sender As Object, e As EventArgs) Handles toolsbtnNuevo.Click
        llimpiarPantalla()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        FormRepSocios.Show()

    End Sub



    'metodo timer 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If ToolStripProgressBar1.Value <= ToolStripProgressBar1.Maximum - 1 Then
                ToolStripProgressBar1.Value = ToolStripProgressBar1.Value + 50

            Else
                Timer1.Enabled = False
                ToolStripProgressBar1.Value = 0
            End If
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub GestionDeLibrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestionDeLibrosToolStripMenuItem1.Click
        Me.Close()
        GestionLibro.Show()
    End Sub

    Private Sub GestionDeUsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestionDeUsuariosToolStripMenuItem1.Click
        Me.Close()
        GestionUsuarios.Show()
    End Sub

    Private Sub GestionDeBusquedaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeBusquedaToolStripMenuItem.Click
        Me.Close()
        GestionBusqueda.Show()

    End Sub

    Private Sub GestionDeClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem1.Click
        Me.Close()
        GestionEmpleados.Show()

    End Sub



    Private Sub MenúPrincipaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        PantallaPrincipal.Show()

    End Sub

    Private Sub GestionDeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeStockToolStripMenuItem.Click
        Me.Close()
        GestionStock.Show()

    End Sub


    'Metodo de evento cerrando fourmulario 
    Private Sub Form1_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PantallaPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub GestiónProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónProductosToolStripMenuItem.Click
        Me.Close()
        GestionProductos.Show()

    End Sub

    Private Sub TPVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TPVToolStripMenuItem.Click
        Me.Close()
        TPV.Show()
    End Sub
End Class