Imports LibConexion
Public Class GestionEmpleados
    'aqui se crea  un objeto de la clase GestionConexion de la liberia 

    Dim queryAdaptador As String = "SELECT * FROM Empleados"
    Dim datasetTableName As String = "Empleados"

    Dim gestion As New LibConexion.GestionConexion(queryAdaptador, datasetTableName)
    Public datatable As New DataTable
    Public getIdFila As String
    Public getDNI As String

    ' Variables usadas para validar datos
    Dim validDatos As New libValidacionDatos.Validacion


    'Constructor formulario Gestion Empleados 
    Private Sub GestionEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try


            ' releacionar los campos de la tabla con los textbox se usando DataBindings
            txtID.DataBindings.Add("text", gestion.getDataSet, "Empleados.id")
            txtDni.DataBindings.Add("text", gestion.getDataSet, "Empleados.Dni")
            txtNombre.DataBindings.Add("text", gestion.getDataSet, "Empleados.Nombre")
            txtApellidos.DataBindings.Add("text", gestion.getDataSet, "Empleados.Apellidos")
            txtTelefono.DataBindings.Add("text", gestion.getDataSet, "Empleados.Telefono")
            'txtUsuario.DataBindings.Add("text", gestion.getDataSet, "Empleados.Usuario")
            'txtClave.DataBindings.Add("text", gestion.getDataSet, "Empleados.Clave")


            'cargar en el datagridview
            'donde sacar los datos pues de la memoria cache dataset
            cargarPantalla()
            ' DataGridView1.DataSource = gestion.getDataSet
            'y le damos nombre
            ' DataGridView1.DataMember = "Empleados"
            'aqui se deselect los elementos en el data gridview 
            ' DataGridView1.ClearSelection()

            'metodo para mostrar  donde esta cursor y en datagridview del total de la filas
            getNumeroRegistros()


            'añadir la fecha en status label
            ToolStripStatusLabel1.Text = DateTime.Now.ToLongDateString.ToString


            'definir la ruta del  fichiero help
            HelpProvider1.HelpNamespace = System.Environment.CurrentDirectory & "\\Ayuda software Casa del Libro.chm"

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try

        ' Llamamos al método para ver qué botones de la barra de herramientas están disponibles para
        ' este usuario.
        PantallaPrincipal.darPermisos()




    End Sub

    Private Sub MenúPrincipaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúPrincipaToolStripMenuItem.Click
        Me.Close()
        PantallaPrincipal.Show()

    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnAlta.Click
        Try
            Timer1.Enabled = True
            If (txtID.Text = "" Or txtDni.Text = "" Or txtNombre.Text = "" Or txtApellidos.Text = "" Or txtTelefono.Text = "") Then


                MsgBox("Por favor rellene los campos . ", 64, "Gestion Empleados")
            Else
                ' Comprobamos si el dni es válido.
                If (validDatos.validarDNI(txtDni.Text)) Then
                    If gestion.insertEmpleado(CInt(txtID.Text), txtDni.Text, txtNombre.Text, txtApellidos.Text, CInt(txtTelefono.Text)) Then

                        cargarPantalla()
                        MsgBox("Empleado Insertado con éxito . ", 64, "Gestion Empleados")
                        llimpiarPantalla()
                        cargarPantalla()
                        getNumeroRegistros()
                    Else
                        cargarPantalla()
                        MsgBox("Error Empleado no Insertado  . ", MsgBoxStyle.Exclamation, "Gestion Empleados")
                    End If
                Else
                    MsgBox(validDatos.mensajeInfoDatoInvalido("DNI"), 64, "Datos")
                    txtDni.Clear()
                End If


            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    'ojo todavia falta Arreglarla
    'En el evento buttonBuscar busca por id es por 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            'buscar por id 
            If txtBusID.Text = "" Then

                MsgBox("Por favor rellene El campo id . ", 64, "Gestion Empleados")
            Else

                Dim pos As Integer = gestion.buscarPorCadena(txtBusID.Text, "Empleados", " id")

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
            gestion.buscarporCaracter(txtBusNombre.Text, "empleados", " nombre", "Empleados")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView1.DataSource = gestion.getDataSet

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub
    'En el evento textChange del campo txtBusDni se busca por caracter
    'se usa el metodo buscarporCaracter() que recibe dos parametros la caracter y nombre de la columna correspondiente en la tabla 
    Private Sub txtBusDni_TextChanged(sender As Object, e As EventArgs) Handles txtBusDni.TextChanged
        Try
            gestion.buscarporCaracter(txtBusDni.Text, "empleados", "dni", "Empleados")
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
            If (txtID.Text = "" Or txtID.Text = "" Or txtNombre.Text = "" Or txtApellidos.Text = "" Or txtTelefono.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Empleados")
            Else
                'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
                ' y una vez seleccionda se recupera el id de la tabla para poder modifcar la fila 
                If DataGridView1.SelectedCells.Count > 0 Then
                    Dim valor As Integer = MsgBox("¿Esta seguro de que desea Modificar Empleado?", 36, "Gestion Empleados")
                    If valor = MsgBoxResult.Yes Then
                        Timer1.Enabled = True
                        ' MsgBox(getIdFila)
                        ' Comprobamos si el dni es valido aun
                        If (validDatos.validarDNI(txtDni.Text)) Then
                            If gestion.modificarEmpleado(getIdFila, txtDni.Text, txtNombre.Text, txtApellidos.Text, txtTelefono.Text, " Empleados ", " id ") Then
                                MsgBox("Empleado Modificado con éxito . ", 64, "Gestion Empleados")
                                cargarPantalla()
                            Else
                                MsgBox("Error Empleado no modificado  . ", MsgBoxStyle.Exclamation, "Gestion Empleados")
                                'aqui se deselecta las celdas de datagridview
                                cargarPantalla()

                            End If
                        Else
                            MsgBox(validDatos.mensajeInfoDatoInvalido("DNI"), 64, "Datos")
                            txtTelefono.Clear()
                        End If
                    End If

                Else
                    MsgBox("Por favor seleccione  un empleado . ", 64, "Gestion Empleados")
                End If
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    'En el evento button Eliminar para eliminar una fila
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
        ' y una vez seleccionda se recupera el id de la tabla para poder eliminar la fila 
        Try
            If (txtID.Text = "" Or txtID.Text = "" Or txtNombre.Text = "" Or txtApellidos.Text = "" Or txtTelefono.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Empleados")
            Else
                If DataGridView1.SelectedCells.Count > 0 Then


                    Dim valor As Integer = MsgBox("¿Esta seguro de que desea Elminar Empleado?", 36, "Gestion Empleados")
                    If valor = MsgBoxResult.Yes Then
                        ' MsgBox(getIdFila)
                        Timer1.Enabled = True
                        If gestion.eliminarFila(getIdFila, " Empleados ", " id ") Then
                            MsgBox("Empleado Eliminado con éxito . ", 64, "Gestion Empleados")
                            llimpiarPantalla()
                            cargarPantalla()
                            getNumeroRegistros()
                        Else
                            MsgBox("Error Empleado no Eliminado  . ", MsgBoxStyle.Exclamation, "Gestion Empleados")
                            'aqui se deselecta las celdas de datagridview
                            cargarPantalla()
                            getNumeroRegistros()
                        End If
                    End If

                Else
                    MsgBox("Por favor seleccione  un empleado . ", 64, "Gestion Empleados")
                End If
            End If
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub



    'Metodo para limpiar los campos del formulario
    Private Sub llimpiarPantalla()
        txtID.Clear()
        txtDni.Clear()
        txtNombre.Clear()
        txtApellidos.Clear()
        txtTelefono.Clear()

        'campos de busqueda
        txtBusDni.Clear()
        txtBusID.Clear()
        txtBusNombre.Clear()






    End Sub

    'En el evento button limpiar se limpia todos los campos del forumalario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        llimpiarPantalla()


    End Sub

    'metodo para Actualizar y cargar los datos en data grid view
    Private Sub cargarPantalla()
        Try
            gestion.getDataSet.Clear()
            gestion.getAdapter.Fill(gestion.getDataSet, "Empleados")
            'aqui se carga el DatagridView
            DataGridView1.DataSource = gestion.getDataSet
            DataGridView1.DataMember = "Empleados"
            DataGridView1.ClearSelection()
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
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
                getDNI = selectedFila.Cells(1).Value.ToString

                'actualizar datagrid view
                cargarPantalla()

            Catch ex As Exception
                MsgBox("Por favor seleccione  un fila valida . ", 64, "Gestion Empleados")
            End Try


            'aqui se recupera el valor de la primera celda que id 

            ' MsgBox(getIdFila)

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try

    End Sub


    ' Comprobar que id es correcto
    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        ' Si se recibe 0 se está validando contraseña en inicio de sesión. (se permiten 6 dígitos)
        ' Si se recibe 1 se está validando teléfono. (se permite 9 dígitos).
        ' Si se recibe 2 se está validando precios en productos
        ' Si recibe 3 es Id de cliente.
        Try
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
            lblNumero.Text = (BindingContext(gestion.getDataSet, "Empleados").Position + 1).ToString + " de " +
            (BindingContext(gestion.getDataSet, "Empleados").Count).ToString

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        'BindingContext(midataset, "Tabla").Position = DataGridView1.RowCount - 1
        Try
            BindingContext(gestion.getDataSet, "Empleados").Position = BindingContext(gestion.getDataSet, "Empleados").Count - 1
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
            BindingContext(gestion.getDataSet, "Empleados").Position += 1

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
            BindingContext(gestion.getDataSet, "Empleados").Position -= 1
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
            BindingContext(gestion.getDataSet, "Empleados").Position = 0
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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        FormRepEmple.Show()
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

    Private Sub GestionDeClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestionDeClientesToolStripMenuItem1.Click
        Me.Close()
        GestionClienteSocio.Show()
    End Sub

    Private Sub GestionDeBusquedaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeBusquedaToolStripMenuItem.Click
        Me.Close()
        GestionBusqueda.Show()
    End Sub

    Private Sub GestionDeStoclToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeStoclToolStripMenuItem.Click
        Me.Close()
        GestionStock.Show()

    End Sub

    Private Sub toolsbtnNuevo_Click(sender As Object, e As EventArgs) Handles toolsbtnNuevo.Click
        llimpiarPantalla()
    End Sub


    ' Botón toolStrip guardar, misma función que botón guardar.
    Private Sub toolsbtnGuardar_Click(sender As Object, e As EventArgs) Handles toolsbtnGuardar.Click
        Try
            Timer1.Enabled = True
            If (txtID.Text = "" Or txtDni.Text = "" Or txtNombre.Text = "" Or txtApellidos.Text = "" Or txtTelefono.Text = "") Then


                MsgBox("Por favor rellene los campos . ", 64, "Gestion Empleados")
            Else
                ' Comprobamos si el dni es válido.
                If (validDatos.validarDNI(txtDni.Text)) Then
                    If gestion.insertEmpleado(CInt(txtID.Text), txtDni.Text, txtNombre.Text, txtApellidos.Text, CInt(txtTelefono.Text)) Then

                        cargarPantalla()
                        MsgBox("Empleado Insertado con éxito . ", 64, "Gestion Empleados")
                        llimpiarPantalla()
                        cargarPantalla()
                        getNumeroRegistros()
                    Else
                        cargarPantalla()
                        MsgBox("Error Empleado no Insertado  . ", MsgBoxStyle.Exclamation, "Gestion Empleados")
                    End If
                Else
                    MsgBox(validDatos.mensajeInfoDatoInvalido("DNI"), 64, "Datos")
                    txtDni.Clear()
                End If


            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    ' Botón toolStrip eliminar
    ' misma función que botón eliminar.
    Private Sub toolsbtnEliminar_Click(sender As Object, e As EventArgs) Handles toolsbtnEliminar.Click
        'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
        ' y una vez seleccionda se recupera el id de la tabla para poder eliminar la fila 
        Try
            If (txtID.Text = "" Or txtID.Text = "" Or txtNombre.Text = "" Or txtApellidos.Text = "" Or txtTelefono.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Empleados")
            Else
                If DataGridView1.SelectedCells.Count > 0 Then


                    Dim valor As Integer = MsgBox("¿Esta seguro de que desea Elminar Empleado?", 36, "Gestion Empleados")
                    If valor = MsgBoxResult.Yes Then
                        ' MsgBox(getIdFila)
                        Timer1.Enabled = True
                        If gestion.eliminarFila(getIdFila, " Empleados ", " id ") Then
                            MsgBox("Empleado Eliminado con éxito . ", 64, "Gestion Empleados")
                            llimpiarPantalla()
                            cargarPantalla()
                            getNumeroRegistros()
                        Else
                            MsgBox("Error Empleado no Eliminado  . ", MsgBoxStyle.Exclamation, "Gestion Empleados")
                            'aqui se deselecta las celdas de datagridview
                            cargarPantalla()
                            getNumeroRegistros()
                        End If
                    End If

                Else
                    MsgBox("Por favor seleccione  un empleado . ", 64, "Gestion Empleados")
                End If
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    'Metodo de evento cerrando fourmulario 
    Private Sub Form1_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PantallaPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub GestiónProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónProductosToolStripMenuItem.Click
        Me.Close()
        GestionProductos.Show()

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

    Private Sub TPVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TPVToolStripMenuItem.Click
        Me.Close()
        TPV.Show()

    End Sub
End Class