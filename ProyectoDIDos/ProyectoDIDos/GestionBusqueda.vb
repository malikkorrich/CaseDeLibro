Imports System.ComponentModel

Public Class GestionBusqueda
    Dim queryAdaptador As String = "SELECT * FROM Libros"
    Dim datasetTableName As String = "Libros"

    Dim gestion As New LibConexion.GestionConexion(queryAdaptador, datasetTableName)
    Public datatable As New DataTable
    ' Variables usadas para validar datos
    Dim validDatos As New libValidacionDatos.Validacion
    Private Sub GestionBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'cargar en el datagridview
        'donde sacar los datos pues de la memoria cache dataset
        cargarPantalla()

        'definir la ruta del  fichiero help
        HelpProvider1.HelpNamespace = System.Environment.CurrentDirectory & "\\Ayuda software Casa del Libro.chm"


        'añadir la fecha en status label
        ToolStripStatusLabel1.Text = DateTime.Now.ToLongDateString.ToString


        ' Llamamos al método para ver qué botones de la barra de herramientas están disponibles para
        ' este usuario.
        PantallaPrincipal.darPermisos()

    End Sub



    'metodo para Actualizar y cargar los datos en data grid view
    Private Sub cargarPantalla()
        Try

            gestion.getDataSet.Clear()
            gestion.getAdapter.Fill(gestion.getDataSet, "Libros")
            'aqui se carga el DatagridView
            DataGridView1.DataSource = gestion.getDataSet
            DataGridView1.DataMember = "Libros"
            'metodo DefaultCellStyle permite de definir la forma que van aparecer  los valores de la columna precio  en este caso C como currency
            'docs.microsoft.com/en-us/previous-versions/dotnet/netframework-4.0/dwhawy9k(v=vs.100)?WT.mc_id=DT-MVP-5003235
            DataGridView1.Columns("Precio").DefaultCellStyle.Format = "C"
            DataGridView1.ClearSelection()
            'establacer el tamaño automatic de todoas la celdas del datagridview 
            'DataGridView1.Columns.Item("imagen").Width = 100
        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    'En el evento textChange del campo txtBusID se busca por caracter 
    'se usa el metodo buscarporCaracter() que recibe dos parametros la caracter y nombre de la columna correspondiente en la tabla 
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

    'En el evento textChange del campo txtBusISBN se busca por caracter 
    'se usa el metodo buscarporCaracter() que recibe dos parametros la caracter y nombre de la columna correspondiente en la tabla 
    Private Sub txtBusISBN_TextChanged(sender As Object, e As EventArgs) Handles txtBusISBN.TextChanged
        Try
            gestion.buscarporCaracter(txtBusISBN.Text, "Libros", " isbn", "Libros")
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
            gestion.buscarporCaracter(txtBusTitulo.Text, "Libros", " titulo", "Libros")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView1.DataSource = gestion.getDataSet
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    'En el evento textChange del campo txtBusEditorial se busca por caracter 
    'se usa el metodo buscarporCaracter() que recibe dos parametros la caracter y nombre de la columna correspondiente en la tabla 
    Private Sub txtBusEditorial_TextChanged(sender As Object, e As EventArgs) Handles txtBusEditorial.TextChanged
        Try
            gestion.buscarporCaracter(txtBusEditorial.Text, "Libros", " editorial", "Libros")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView1.DataSource = gestion.getDataSet
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    'En el evento textChange del campo txtBusGenero se busca por caracter 
    'se usa el metodo buscarporCaracter() que recibe dos parametros la caracter y nombre de la columna correspondiente en la tabla 
    Private Sub txtBusGenero_TextChanged(sender As Object, e As EventArgs) Handles txtBusGenero.TextChanged
        Try
            gestion.buscarporCaracter(txtBusGenero.Text, "Libros", " genero", "Libros")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView1.DataSource = gestion.getDataSet
        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    'En el evento textChange del campo txtBusGenero se busca por caracter 
    'se usa el metodo buscarporCaracter() que recibe dos parametros la caracter y nombre de la columna correspondiente en la tabla 
    Private Sub txtBusAutor_TextChanged(sender As Object, e As EventArgs) Handles txtBusAutor.TextChanged
        Try
            gestion.buscarporCaracter(txtBusAutor.Text, "Libros", " autor", "Libros")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView1.DataSource = gestion.getDataSet
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
        txtBusEditorial.Clear()
        txtBusGenero.Clear()
        txtBusAutor.Clear()
        cbxCategorias.Text = Nothing
        cbxEstado.Text = Nothing
        cbxIdioma.Text = Nothing
    End Sub

    ' Volver a Menu principal
    Private Sub MenúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúPrincipalToolStripMenuItem.Click
        Me.Close()
        PantallaPrincipal.Show()

    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try

            llimpiarPantalla()


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

    Private Sub GestionDeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeStockToolStripMenuItem.Click
        Me.Close()
        GestionStock.Show()
    End Sub

    Private Sub GestionEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionEmpleadosToolStripMenuItem.Click
        Me.Close()
        GestionEmpleados.Show()
    End Sub




    Private Sub cbxCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategorias.SelectedIndexChanged
        Try
            gestion.buscarporCaracter(cbxCategorias.Text, "Libros", "Categoria", "Libros")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView1.DataSource = gestion.getDataSet
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub cbxEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEstado.SelectedIndexChanged
        Try
            gestion.buscarporCaracter(cbxEstado.Text, "Libros", "Estado", "Libros")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView1.DataSource = gestion.getDataSet
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub cbxIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIdioma.SelectedIndexChanged
        Try
            gestion.buscarporCaracter(cbxIdioma.Text, "Libros", "Idioma", "Libros")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView1.DataSource = gestion.getDataSet
        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            'buscar por id 
            If txtBusID.Text = "" Then

                MsgBox("Por favor rellene El campo id . ", 64, "Gestion Busqueda")
            Else

                Dim pos As Integer = gestion.buscarPorCadena(txtBusID.Text, "Libros", " id")

                If pos <> -1 Then
                    DataGridView1.Rows(pos).Selected = True
                End If



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