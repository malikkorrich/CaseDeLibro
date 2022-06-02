Public Class GestionStock
    'aqui se crea  un objeto de la clase GestionConexion de la liberia 

    Dim queryAdaptador As String = "SELECT id,isbn,titulo,stock FROM Libros"
    Dim datasetTableName As String = "Libros"

    Dim gestion As New LibConexion.GestionConexion(queryAdaptador, datasetTableName)
    Public datatable As New DataTable
    Public getIdFila As String

    Private Sub GestionStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' releacionar los campos de la tabla con los textbox se usando DataBindings
        Try
            txtStock.DataBindings.Add("text", gestion.getDataSet, "Libros.stock")

            'cargar en el datagridview
            'donde sacar los datos pues de la memoria cache dataset
            cargarPantalla()

            'metodo para mostrar  donde esta cursor y en datagridview del total de la filas
            getNumeroRegistros()


            'añadir la fecha en status label
            ToolStripStatusLabel1.Text = DateTime.Now.ToLongDateString.ToString

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try

        ' Llamamos al método para ver qué botones de la barra de herramientas están disponibles para
        ' este usuario.
        PantallaPrincipal.darPermisos()


        'definir la ruta del  fichiero help
        HelpProvider1.HelpNamespace = System.Environment.CurrentDirectory & "\\Ayuda software Casa del Libro.chm"

    End Sub

    'metodo para Actualizar y cargar los datos en data grid view
    Private Sub cargarPantalla()
        Try
            gestion.getDataSet.Clear()
            gestion.getAdapter.Fill(gestion.getDataSet, "Libros")
            'aqui se carga el DatagridView
            DataGridView1.DataSource = gestion.getDataSet
            DataGridView1.DataMember = "Libros"
            DataGridView1.ClearSelection()

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    'Metodo para limpiar los campos del formulario
    Private Sub llimpiarPantalla()
        txtBusID.Clear()
        txtBusISBN.Clear()
        txtBusTitulo.Clear()
        ' txtStock.Clear()
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
            'aqui se obtiene la fila pasandole el indice 
            Try
                selectedFila = DataGridView1.Rows(indice)
                getIdFila = selectedFila.Cells(0).Value.ToString
            Catch ex As Exception
                MsgBox("Por favor selecciona una fila valida")
            End Try
            'MsgBox(getIdFila)

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try

    End Sub

    'En el evento button Modificar stock para modificar el campo stock de la tabla libros 
    Private Sub btnModificarStock_Click(sender As Object, e As EventArgs) Handles btnModificarStock.Click
        Try
            'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
            ' y una vez seleccionda se recupera el id de la tabla para poder modifcar la fila 
            If DataGridView1.SelectedCells.Count > 0 Then
                Dim valor As Integer = MsgBox("¿Esta seguro de que desea modificar el stock ?", 36, "Gestion Stock")
                If valor = MsgBoxResult.Yes Then
                    ' MsgBox(getIdFila)
                    Timer1.Enabled = True

                    If gestion.modificarStock(getIdFila, CInt(txtStock.Text), " Libros ", " id ") Then
                        MsgBox("Stock Modificao con éxito . ", 64, "Gestion Stock")
                        cargarPantalla()
                    Else
                        MsgBox("Error Stock no modificado  . ", MsgBoxStyle.Exclamation, "Gestion Stock")
                        'aqui se deselecta las celdas de datagridview
                        cargarPantalla()

                    End If
                End If

            Else
                MsgBox("Por favor seleccione el Stock . ", 64, "Gestion Stock")
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub



    'En el evento textChange del campo txtBusID se busca por caracter 
    'se usa el metodo buscarporCaracter() que recibe dos parametros la caracter y nombre de la columna correspondiente en la tabla 
    Private Sub txtBusID_TextChanged(sender As Object, e As EventArgs) Handles txtBusID.TextChanged
        Try
            gestion.buscarStock(txtBusID.Text, "Libros", " id", "Libros")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView1.DataSource = gestion.getDataSet

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub



    'En el evento textChange del campo txtBusISBN se busca por caracter 
    'se usa el metodo buscarporCaracter() que recibe dos parametros la caracter y nombre de la columna correspondiente en la tabla 
    Private Sub txtBusISBN_TextChanged(sender As Object, e As EventArgs) Handles txtBusISBN.TextChanged
        Try
            gestion.buscarStock(txtBusISBN.Text, "Libros", " isbn", "Libros")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView1.DataSource = gestion.getDataSet

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    'En el evento textChange del campo  txtBusTitulo se busca por caracter 
    'se usa el metodo buscarporCaracter() que recibe dos parametros la caracter y nombre de la columna correspondiente en la tabla 
    Private Sub txtBusTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtBusTitulo.TextChanged
        Try
            gestion.buscarStock(txtBusTitulo.Text, "Libros", " titulo", "Libros")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView1.DataSource = gestion.getDataSet

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    'metodo para mostrar  donde esta cursor y en datagridview del total de la filas
    Private Sub getNumeroRegistros()
        Try
            lblNumero.Text = (BindingContext(gestion.getDataSet, "Libros").Position + 1).ToString + " de " +
            (BindingContext(gestion.getDataSet, "Libros").Count).ToString

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        'BindingContext(midataset, "Tabla").Position = DataGridView1.RowCount - 1
        Try
            BindingContext(gestion.getDataSet, "Libros").Position = BindingContext(gestion.getDataSet, "Libros").Count - 1
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
        Try
            'colacrtese con bindingContext en la dataset dandlole nombre en la posicion
            BindingContext(gestion.getDataSet, "Libros").Position += 1

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
            BindingContext(gestion.getDataSet, "Libros").Position -= 1
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
            BindingContext(gestion.getDataSet, "Libros").Position = 0
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

    Private Sub GestionEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionEmpleadosToolStripMenuItem.Click
        Me.Close()
        GestionEmpleados.Show()

    End Sub

    Private Sub GestionDeUsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestionDeUsuariosToolStripMenuItem1.Click
        Me.Close()
        GestionUsuarios.Show()
    End Sub

    Private Sub GestionDeClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestionDeClientesToolStripMenuItem1.Click
        Me.Close()
        GestionClienteSocio.Show()
    End Sub

    Private Sub MenúPrincipaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúPrincipaToolStripMenuItem.Click
        Me.Close()
        PantallaPrincipal.Show()

    End Sub


    'Metodo de evento cerrando fourmulario 
    Private Sub Form1_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PantallaPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        txtStock.Text = TrackBar1.Value.ToString
    End Sub

    Private Sub GestiónProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónProductosToolStripMenuItem.Click
        Me.Close()
        GestionProductos.Show()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarPantalla()
    End Sub


    'metodo limpiarPantalla() permite limpiar los campos de buesqueda
    Private Sub limpiarPantalla()
        txtBusID.Clear()
        txtBusISBN.Clear()
        txtBusTitulo.Clear()

    End Sub

    Private Sub TPVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TPVToolStripMenuItem.Click
        Me.Close()
        TPV.Show()

    End Sub
End Class