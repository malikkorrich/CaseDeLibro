Public Class GestionUsuarios

    'aqui se crea  un objeto de la clase GestionConexion de la liberia 

    Dim queryAdaptador As String = "SELECT * FROM Usuarios"
    Dim datasetTableName As String = "Usuarios"
    Dim queryRelacionEmpUsr As String = "Select Empleados.id, Empleados.nombre, Empleados.apellidos, Usuarios.id, Usuarios.usuario, Usuarios.clave, Usuarios.rol from Empleados,Usuarios where Empleados.id = Usuarios.fk_empleado"
    Dim queryUsr As String = "SELECT * FROM Usuarios"
    Dim queryEmp As String = "SELECT * FROM Empleados"

    Dim gestion As New LibConexion.GestionConexion(queryAdaptador, datasetTableName)
    Public datatable As New DataTable
    Public getIdFila As String
    Public fkEmpleado As String
    Public getUsuario As String
    Public dataset As DataSet

    ' Variables para validar datos vvvv
    Dim validDatos As New libValidacionDatos.Validacion



    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'aqui se recupera la tabla Empleados del dataset que se returna el metodo getEmpleados
            ' Cargamos el combobox con el contenido del campo
            Dim datasetEmp = gestion.getEmpleados("select id from Empleados", "Empleados")
            cbxEmpleados.DataSource = datasetEmp.Tables("Empleados")
            'aqui se visualiza solamente la columna id de la tabla empleados usando metodo DisplayMember
            cbxEmpleados.DisplayMember = "id"
            'cargar en el datagridview
            'donde sacar los datos pues de la memoria cache dataset



            dataset = gestion.getRelacionEmpUsr(queryRelacionEmpUsr, "relacion", queryEmp, queryUsr, "Empleados", "Usuarios")

            DataGridView1.DataSource = dataset
            DataGridView1.DataMember = "relacion"
            dataset.Relations.Add("relacion", dataset.Tables("Empleados").Columns("id"), dataset.Tables("Usuarios").Columns("fk_empleado"))



            'releacionar los campos de la tabla con los textbox se usando DataBindings
            txtID.DataBindings.Add("text", dataset, "Usuarios.id")
            txtUsuario.DataBindings.Add("text", dataset, "Usuarios.usuario")
            txtClave.DataBindings.Add("text", dataset, "Usuarios.Clave")
            cbxRol.DataBindings.Add("text", dataset, "Usuarios.Rol")
            cbxEmpleados.DataBindings.Add("text", dataset, "Empleados.id")



            cargarPantalla()


            'añadir la fecha en status label
            ToolStripStatusLabel1.Text = DateTime.Now.ToLongDateString.ToString

            'metodo para mostrar  donde esta cursor y en datagridview del total de la filas
            getNumeroRegistros()


            'definir la ruta del  fichiero help
            HelpProvider1.HelpNamespace = System.Environment.CurrentDirectory & "\\Ayuda software Casa del Libro.chm"

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try

        ' Comprobarmos permisos
        If PantallaPrincipal.lbtxtRol.Text.Equals("Usuario") Then

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


            ' Se entra como Guest /invitado.
        ElseIf PantallaPrincipal.lbtxtRol.Text.Equals("Guest") Then


            GestionBusqueda.GestionDeClientesToolStripMenuItem1.Enabled = False
            GestionBusqueda.GestionEmpleadosToolStripMenuItem.Enabled = False
            GestionBusqueda.GestionDeUsuariosToolStripMenuItem1.Enabled = False
            GestionBusqueda.GestiónProductosToolStripMenuItem.Enabled = False
            GestionBusqueda.GestionDeLibrosToolStripMenuItem1.Enabled = False
            GestionBusqueda.GestionDeStockToolStripMenuItem.Enabled = False
            ' Guardamos la hora de acceso del usuario (con sus datos):

        End If





    End Sub


    'metodo para dar alta usaurio 
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Try
            Timer1.Enabled = True
            If (txtID.Text = "" Or txtUsuario.Text = "" Or txtClave.Text = "" Or cbxRol.Text = "" Or cbxEmpleados.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Usuarios")
            Else

                If gestion.insertUsuario(CInt(txtID.Text), txtUsuario.Text, CInt(txtClave.Text), cbxRol.Text, CInt(cbxEmpleados.Text)) Then

                    cargarPantalla()
                    MsgBox("Usario Insertado con éxito . ", 64, "Gestion Usuarios")
                    llimpiarPantalla()
                    cargarPantalla()
                    getNumeroRegistros()
                Else
                    cargarPantalla()
                    MsgBox("Error Usario no Insertado  . ", MsgBoxStyle.Exclamation, "Gestion Usuarios")
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
        txtClave.Clear()
        txtUsuario.Clear()
        cbxEmpleados.Text = Nothing
        cbxRol.Text = Nothing


    End Sub


    'metodo para Actualizar y cargar los datos en data grid view
    Private Sub cargarPantalla()
        Try
            'aqui se carga el DatagridView

            dataset = gestion.getRelacionEmpUsr(queryRelacionEmpUsr, "relacion", queryEmp, queryUsr, "Empleados", "Usuarios")

            DataGridView1.DataSource = dataset
            DataGridView1.DataMember = "relacion"
            dataset.Relations.Add("relacion", dataset.Tables("Empleados").Columns("id"), dataset.Tables("Usuarios").Columns("fk_empleado"))

            DataGridView1.ClearSelection()


        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub




    'metodo para obtener elemento seleccionado del datagridview para poder programar el metodo Eliminar sin necesitar al biding
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            'aqui se declara una var de tipo entero que va guardar el indice de la fila seleccionada usando evento e.RowIndex
            Dim indice As Integer
            indice = e.RowIndex
            'aqui se crea un objeto de la clase DataGridViewRow que nos va permitir obtener el valor 
            Dim selectedFila As DataGridViewRow
            'aqui se obtiene la fila pasandole el indice 
            Try
                selectedFila = DataGridView1.Rows(indice)
                getIdFila = selectedFila.Cells(3).Value.ToString
                fkEmpleado = selectedFila.Cells(0).Value.ToString
                getUsuario = selectedFila.Cells(4).Value.ToString
            Catch ex As Exception
                MsgBox("Por favor selecciona una fila valida")
            End Try
            'MsgBox(getIdFila)

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub





    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        llimpiarPantalla()
    End Sub


    '  En el evento button Modificar para modifica  una fila
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
        ' y una vez seleccionda se recupera el id de la tabla para poder modifcar la fila 
        Try
            If (txtID.Text = "" Or txtUsuario.Text = "" Or txtClave.Text = "" Or cbxRol.Text = "" Or cbxEmpleados.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Usuarios")
            Else


                If DataGridView1.SelectedCells.Count > 0 Then
                    Dim valor As Integer = MsgBox("¿Esta seguro de que desea Modificar Empleado?", 36, "Gestion Empleados")
                    If valor = MsgBoxResult.Yes Then
                        'MsgBox(getIdFila)
                        Timer1.Enabled = True
                        If gestion.modificarUsuario(CInt(txtID.Text), txtUsuario.Text, CInt(txtClave.Text), cbxRol.Text, CInt(cbxEmpleados.Text), " Usuarios ", " id ") Then
                            MsgBox("Usuario Modificao con éxito . ", 64, "Gestion Usuarios")
                            cargarPantalla()
                        Else
                            MsgBox("Error Usuario no modificado  . ", MsgBoxStyle.Exclamation, "Gestion Usuarios")
                            'aqui se deselecta las celdas de datagridview
                            cargarPantalla()

                        End If
                    End If

                Else
                    MsgBox("Por favor seleccione un Usuario . ", 64, "Gestion Usuario")
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
            If DataGridView1.SelectedCells.Count > 0 Then


                Dim valor As Integer = MsgBox("¿Esta seguro de que desea Elminar Empleado?", 36, "Gestion Usuarios")
                If valor = MsgBoxResult.Yes Then
                    ' MsgBox(getIdFila)
                    Timer1.Enabled = True
                    If gestion.eliminarFila(getIdFila, " Usuarios ", " id ") Then
                        MsgBox("Usuario Eliminado con éxito . ", 64, "Gestion Usuarios")
                        llimpiarPantalla()
                        cargarPantalla()
                        getNumeroRegistros()
                    Else
                        MsgBox("Error Usuario no Eliminado  . ", MsgBoxStyle.Exclamation, "Gestion Usuarios")
                        'aqui se deselecta las celdas de datagridview
                        cargarPantalla()

                    End If
                End If

            Else
                MsgBox("Por favor seleccione  un Usuario . ", 64, "Gestion Usuarios")
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub
    ''En el evento textChange del campo txtBusDni se busca por caracter
    ''se usa el metodo buscarporCaracter() que recibe dos parametros la caracter y nombre de la columna correspondiente en la tabla 
    'Private Sub txtBusID_TextChanged(sender As Object, e As EventArgs)
    '    gestion.buscarporCaracter(txtBusID.Text, "Usuarios", "id", "Usuarios")
    '    'aqui se recupera midataset desde metodo get de la clase gestionConexion
    '    DataGridView1.DataSource = gestion.getDataSet


    'End Sub
    ''En el evento textChange del campo txtBusDni se busca por caracter
    ''se usa el metodo buscarporCaracter() que recibe dos parametros la caracter y nombre de la columna correspondiente en la tabla 
    'Private Sub txtBusUsuario_TextChanged(sender As Object, e As EventArgs)
    '    gestion.buscarporCaracter(txtBusUsuario.Text, "Usuarios", "usuario", "Usuarios")
    '    'aqui se recupera midataset desde metodo get de la clase gestionConexion
    '    DataGridView1.DataSource = gestion.getDataSet
    'End Sub

    'Private Sub cbxBusRol_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    gestion.buscarporCaracter(cbxBusRol.Text, "Usuarios", "Rol", "Usuarios")
    '    'aqui se recupera midataset desde metodo get de la clase gestionConexion
    '    DataGridView1.DataSource = gestion.getDataSet
    'End Sub



    ' Validar campo ID
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

    ' Validar campo usuario
    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        Try
            If (validDatos.validarUsuario(txtUsuario.Text, 0)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("Usuario"), 64, "Datos")
                txtUsuario.Clear()
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    ' Validar campo clave
    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        Try

            If (validDatos.validarCodigo(txtClave.Text, 0)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("Clave"), 64, "Datos")
                txtClave.Clear()
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    'get los valors de la filas seleccionadas en datagridview usando evento DataGridView1.Click  
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Try
            'aqui se recupera los valores pasando al datagridview las celdas que se necesita
            txtID.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            txtUsuario.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
            txtClave.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
            cbxRol.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
            cbxEmpleados.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString

        Catch ex As Exception
            MsgBox("Porfavor seleccione una fila valida " & Chr(13), 64, "Gestion Usuarios")
            ' gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub





    'metodo para mostrar  donde esta cursor y en datagridview del total de la filas
    Private Sub getNumeroRegistros()
        Try
            lblNumero.Text = (BindingContext(dataset, "relacion").Position + 1).ToString + " de " +
            (BindingContext(dataset, "relacion").Count).ToString

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        'BindingContext(midataset, "Tabla").Position = DataGridView1.RowCount - 1
        Try

            BindingContext(dataset, "relacion").Position = BindingContext(dataset, "relacion").Count - 1
            btnUltimo.Enabled = False
            btnSiguiete.Enabled = False
            btnPrimero.Enabled = True
            btnAnterior.Enabled = True
            'aqui se recupera los valores pasando al datagridview las celdas que se necesita
            txtID.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            txtUsuario.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
            txtClave.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
            cbxRol.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
            cbxEmpleados.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
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

            BindingContext(dataset, "relacion").Position += 1

            'aqui se recupera los valores pasando al datagridview las celdas que se necesita
            txtID.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            txtUsuario.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
            txtClave.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
            cbxRol.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
            cbxEmpleados.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
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

            BindingContext(dataset, "relacion").Position -= 1
            btnSiguiete.Enabled = True
            btnUltimo.Enabled = True

            'aqui se recupera los valores pasando al datagridview las celdas que se necesita
            txtID.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            txtUsuario.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
            txtClave.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
            cbxRol.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
            cbxEmpleados.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            'llamar al metodo
            getNumeroRegistros()

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        Try

            BindingContext(dataset, "relacion").Position = 0
            btnPrimero.Enabled = False
            btnAnterior.Enabled = False
            btnUltimo.Enabled = True
            btnSiguiete.Enabled = True
            'llamar al metodo
            getNumeroRegistros()

            'aqui se recupera los valores pasando al datagridview las celdas que se necesita
            txtID.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            txtUsuario.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
            txtClave.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
            cbxRol.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
            cbxEmpleados.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString


        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
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

    Private Sub GestionDeBusquedaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeBusquedaToolStripMenuItem.Click
        Me.Close()
        GestionBusqueda.Show()
    End Sub

    Private Sub GestionDeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeStockToolStripMenuItem.Click
        Me.Close()
        GestionStock.Show()
    End Sub

    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click
        Me.Close()
        GestionEmpleados.Show()

    End Sub

    Private Sub GestionDeClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestionDeClientesToolStripMenuItem1.Click
        Me.Close()
        GestionClienteSocio.Show()
    End Sub

    Private Sub MenúPrincipaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúPrincipaToolStripMenuItem.Click
        Me.Close()
        PantallaPrincipal.Show()

    End Sub

    Private Sub toolsbtnNuevo_Click(sender As Object, e As EventArgs) Handles toolsbtnNuevo.Click
        llimpiarPantalla()
    End Sub

    ' Botón de toolStrip guardar
    ' Misma funcion que alta
    Private Sub toolsbtnGuardar_Click(sender As Object, e As EventArgs) Handles toolsbtnGuardar.Click
        Try
            Timer1.Enabled = True
            If (txtID.Text = "" Or txtUsuario.Text = "" Or txtClave.Text = "" Or cbxRol.Text = "" Or cbxEmpleados.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Usuarios")
            Else

                If gestion.insertUsuario(CInt(txtID.Text), txtUsuario.Text, CInt(txtClave.Text), cbxRol.Text, CInt(cbxEmpleados.Text)) Then

                    cargarPantalla()
                    MsgBox("Usario Insertado con éxito . ", 64, "Gestion Usuarios")
                    llimpiarPantalla()
                    cargarPantalla()
                    getNumeroRegistros()
                Else
                    cargarPantalla()
                    MsgBox("Error Usario no Insertado  . ", MsgBoxStyle.Exclamation, "Gestion Usuarios")
                End If

            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    ' Botón toolStrip eliminar
    ' misma función que el botón eliminar
    Private Sub toolsbtnEliminar_Click(sender As Object, e As EventArgs) Handles toolsbtnEliminar.Click
        'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
        ' y una vez seleccionda se recupera el id de la tabla para poder eliminar la fila 

        Try

            If DataGridView1.SelectedCells.Count > 0 Then


                Dim valor As Integer = MsgBox("¿Esta seguro de que desea Elminar Empleado?", 36, "Gestion Usuarios")
                If valor = MsgBoxResult.Yes Then
                    ' MsgBox(getIdFila)
                    Timer1.Enabled = True
                    If gestion.eliminarFila(getIdFila, " Usuarios ", " id ") Then
                        MsgBox("Usuario Eliminado con éxito . ", 64, "Gestion Usuarios")
                        llimpiarPantalla()
                        cargarPantalla()
                        getNumeroRegistros()
                    Else
                        MsgBox("Error Usuario no Eliminado  . ", MsgBoxStyle.Exclamation, "Gestion Usuarios")
                        'aqui se deselecta las celdas de datagridview
                        cargarPantalla()

                    End If
                End If

            Else
                MsgBox("Por favor seleccione  un Usuario . ", 64, "Gestion Usuarios")
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try

    End Sub

    Private Sub btnVolverMenu_Click(sender As Object, e As EventArgs) Handles btnVolverMenu.Click
        Me.Close()
        PantallaPrincipal.Show()
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