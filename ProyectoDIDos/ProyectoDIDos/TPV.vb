Public Class TPV

    'aqui se crea  un objeto de la clase GestionConexion de la liberia 

    Dim queryAdaptador As String = "SELECT * FROM Libros"
    Dim datasetTableName As String = "Libros"


    Dim queryAdaptador2 As String = "SELECT * FROM Gafas"
    Dim datasetTableName2 As String = "Gafas"

    Dim gestion As New LibConexion.GestionConexion(queryAdaptador, datasetTableName)
    Public datatable As New DataTable
    Public getIdFila As String
    Public fkEmpleado As String
    Public getUsuario As String
    Public dataset As DataSet
    '-----------Atributos Productos------------
    Public getNombre As String
    Public getIsbn As String
    Public getPrecio As Single
    Public precioTotal As Single
    Public linea As String
    Public totalPedido As String
    Public count As Integer
    Dim arrayPreciosLista As New ArrayList
    ' Variables para validar datos vvvv
    Dim validDatos As New libValidacionDatos.Validacion
    Private Sub TPUV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PantallaPrincipal.darPermisos()
    End Sub

    Private Sub cbxProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProductos.SelectedIndexChanged
        If (cbxProductos.Text = "Libros") Then

            Dim datasetLibros = gestion.getProductos(queryAdaptador, datasetTableName)
            DataGridView1.DataSource = datasetLibros
            DataGridView1.DataMember = "Libros"
            DataGridView1.ClearSelection()

        ElseIf (cbxProductos.Text = "Gafas") Then

            Dim datasetLibros = gestion.getProductos(queryAdaptador2, datasetTableName2)
            DataGridView1.DataSource = datasetLibros
            DataGridView1.DataMember = "Gafas"
            DataGridView1.ClearSelection()

        End If
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
                If (cbxProductos.Text = "Libros") Then

                    selectedFila = DataGridView1.Rows(indice)
                    getNombre = selectedFila.Cells(2).Value.ToString
                    getIsbn = selectedFila.Cells(1).Value.ToString
                    getPrecio = selectedFila.Cells(3).Value.ToString

                ElseIf (cbxProductos.Text = "Gafas") Then

                    selectedFila = DataGridView1.Rows(indice)
                    getNombre = selectedFila.Cells(2).Value.ToString
                    getIsbn = selectedFila.Cells(1).Value.ToString
                    getPrecio = selectedFila.Cells(5).Value.ToString


                End If

            Catch ex As Exception
                MsgBox("Por favor selecciona una fila valida")
            End Try
            'MsgBox(getIdFila)

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub btnAnadirproducto_Click(sender As Object, e As EventArgs) Handles btnAnadirproducto.Click

        If DataGridView1.SelectedCells.Count > 0 Then


            linea = getNombre & "                       " & getPrecio & " €" & " " & Chr(13)
            totalPedido = totalPedido & linea & vbCrLf

            lbxCarrito.Items.Add(linea)
            arrayPreciosLista.Add(getPrecio)
            precioTotal = precioTotal + getPrecio
            lbPrecioTotalText.Text = CStr(precioTotal)
        Else
            MsgBox("Por favor seleccione un producto . ", 64, "TPV")
        End If



    End Sub

    Private Sub btnQuitarProducto_Click(sender As Object, e As EventArgs) Handles btnQuitarProducto.Click
        ' Si hay items en el listbox entonces se procede a eliminar.
        If lbxCarrito.Items.Count > 0 And lbxCarrito.SelectedIndex >= 0 Then
            ' Actualizamos el precio total y el label donde mostramos el texto:        
            precioTotal = precioTotal - arrayPreciosLista(lbxCarrito.SelectedIndex)
            lbPrecioTotalText.Text = Math.Round(precioTotal, 2)
            ' Quitamos el precio del arraylist también, dado que el item ya no estará en el listbox.
            arrayPreciosLista.RemoveAt(lbxCarrito.SelectedIndex)
            ' Quiamos el producto del listbox, efectivamente quitando un item.
            lbxCarrito.Items.Remove(lbxCarrito.SelectedItem)
        Else
        End If
    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        If lbxCarrito.Items.Count = 0 Then
            MsgBox("No hay productos para pagar.", 64, "Cesta vacía")
        Else

            GestionCobro.Show()
            count = lbxCarrito.Items.Count
        End If
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



    Private Sub GestionEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionEmpleadosToolStripMenuItem.Click
        Me.Close()
        GestionEmpleados.Show()
    End Sub



    Private Sub GestiónProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónProductosToolStripMenuItem.Click
        Me.Close()
        GestionProductos.Show()

    End Sub

    Private Sub MenúPrincipaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúPrincipaToolStripMenuItem.Click
        Me.Close()
        PantallaPrincipal.Show()
    End Sub

    Private Sub GestiónStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeStockToolStripMenuItem.Click
        Me.Close()
        GestionStock.Show()
    End Sub

    Private Sub GestionDeBusquedaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeBusquedaToolStripMenuItem.Click
        GestionBusqueda.Show()
        Me.Close()

    End Sub


    'Metodo de evento cerrando fourmulario 
    Private Sub Form1_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PantallaPrincipal.Show()
        Me.Dispose()
    End Sub
End Class