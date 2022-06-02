Imports System.IO
Imports libValidacionDatos
Public Class GestionLibro
    Dim queryAdaptador As String = "SELECT * FROM Libros"
    Dim datasetTableName As String = "Libros"

    Dim gestion As New LibConexion.GestionConexion(queryAdaptador, datasetTableName)
    Public datatable As New DataTable
    Public getIdFila As String
    Dim ofd As OpenFileDialog

    ' Variables usadas para validar datos
    Dim validDatos As New libValidacionDatos.Validacion



    Private Sub GestionLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' releacionar los campos de la tabla con los textbox se usando DataBindings
            txtLibroID.DataBindings.Add("text", gestion.getDataSet, "Libros.id")
            txtISBN.DataBindings.Add("text", gestion.getDataSet, "Libros.isbn")
            txtTitulo.DataBindings.Add("text", gestion.getDataSet, "Libros.titulo")
            txtPrecio.DataBindings.Add("text", gestion.getDataSet, "Libros.precio")
            txtAutor.DataBindings.Add("text", gestion.getDataSet, "Libros.autor")
            txtEditorial.DataBindings.Add("text", gestion.getDataSet, "Libros.Editorial")
            txtTapa.DataBindings.Add("text", gestion.getDataSet, "Libros.tapa")
            txtStock.DataBindings.Add("text", gestion.getDataSet, "Libros.stock")
            txtGenero.DataBindings.Add("text", gestion.getDataSet, "Libros.genero")
            cbxCategorias.DataBindings.Add("text", gestion.getDataSet, "Libros.categoria")
            cbxEstado.DataBindings.Add("text", gestion.getDataSet, "Libros.estado")
            cbxIdioma.DataBindings.Add("text", gestion.getDataSet, "Libros.idioma")
            'picturebox databingdings se crea un objeto anonimo de la clase Binding que recibe 4 parametros
            'el tipo que es Image, nombre del dataset , nombre del campo , un boolean que permite aplicar formato
            imagenLibro.DataBindings.Add(New Binding("Image", gestion.getDataSet, "Libros.imagen", True))


            'cargar en el datagridview
            'donde sacar los datos pues de la memoria cache dataset
            cargarPantalla()


            'desabilitar campo de stock (no se peude gestion el stock , la gestion de libro)
            txtStock.Enabled = True



            'metodo para mostrar  donde esta cursor y en datagridview del total de la filas
            getNumeroRegistros()

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


    ' Alta de Libro
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        'damos nombre de imagen como el id del libro como es identificador unico
        Try
            If (txtLibroID.Text = "" Or txtISBN.Text = "" Or txtTitulo.Text = "" Or txtPrecio.Text = "" Or txtAutor.Text = "" Or txtEditorial.Text = "" Or txtTapa.Text = "" Or txtStock.Text = "" Or txtGenero.Text = "" Or cbxCategorias.Text = "" Or cbxEstado.Text = "" Or cbxIdioma.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Libros")
            Else
                If (validDatos.validarISBN(txtISBN.Text)) Then



                    If Not imagenLibro.Image Is Nothing Then


                        'se crea un objeto de clase Memorystream que va coger el tamaño de la imagen
                        Dim arrImage() As Byte
                        Dim mstream As New System.IO.MemoryStream()

                        'SPECIFIES THE FILE FORMAT OF THE IMAGE
                        imagenLibro.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

                        'RETURNS THE ARRAY OF UNSIGNED BYTES FROM WHICH THIS STREAM WAS CREATED
                        arrImage = mstream.GetBuffer()

                        'GET THE SIZE OF THE STREAM IN BYTES
                        Dim FileSize As UInt32
                        FileSize = mstream.Length
                        'CLOSES THE CURRENT STREAM AND RELEASE ANY RESOURCES ASSOCIATED WITH THE CURRENT STREAM
                        mstream.Close()


                        If gestion.insertLibro(CInt(txtLibroID.Text), txtISBN.Text, txtTitulo.Text, CSng(txtPrecio.Text), txtAutor.Text, txtEditorial.Text, txtTapa.Text, CInt(txtStock.Text), txtGenero.Text, cbxCategorias.Text, cbxEstado.Text, cbxIdioma.Text, arrImage) Then


                            MsgBox("Libro Insertado con éxito . ", 64, "Gestion Libros")
                            llimpiarPantalla()
                            cargarPantalla()
                            getNumeroRegistros()
                        Else

                            MsgBox("Error Libro no Insertado  . ", MsgBoxStyle.Exclamation, "Gestion Libros")
                        End If

                    Else
                        MsgBox("Por favor seleccione un imagen . ", MsgBoxStyle.Exclamation, "Gestion Libros")
                    End If

                Else
                    MsgBox(validDatos.mensajeInfoDatoInvalido("ISBN"), 64, "Datos")
                End If
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    Private Sub llimpiarPantalla()
        txtISBN.Clear()
        txtLibroID.Clear()
        txtTitulo.Clear()
        txtAutor.Clear()
        txtEditorial.Clear()
        txtTapa.Clear()
        txtStock.Clear()
        txtPrecio.Clear()
        txtGenero.Clear()
        cbxCategorias.Text = Nothing
        cbxEstado.Text = Nothing
        cbxIdioma.Text = Nothing
        imagenLibro.Image = New PictureBox().Image


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        llimpiarPantalla()
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Try
            'objeto de openfiledialog
            Dim odf As New OpenFileDialog()
            odf.Title = "Seleccione una imagen ..."
            'tipo de fichiero
            odf.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
            'inicio de la ruta
            odf.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            If odf.ShowDialog() = DialogResult.OK Then
                imagenLibro.Image = Image.FromFile(odf.FileName)

            End If


        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub
    'En el evento button Modificar para modifica  una fila
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If (txtLibroID.Text = "" Or txtISBN.Text = "" Or txtTitulo.Text = "" Or txtPrecio.Text = "" Or txtAutor.Text = "" Or txtEditorial.Text = "" Or txtTapa.Text = "" Or txtStock.Text = "" Or txtGenero.Text = "" Or cbxCategorias.Text = "" Or cbxEstado.Text = "" Or cbxIdioma.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Libros")
            Else

                'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
                ' y una vez seleccionda se recupera el id de la tabla para poder modifcar la fila 
                If DataGridView1.SelectedCells.Count > 0 Then
                    Dim valor As Integer = MsgBox("¿Esta seguro de que desea Modificar Libro?", 36, "Gestion Libros")
                    If valor = MsgBoxResult.Yes Then
                        ' MsgBox(getIdFila)


                        'se crea un objeto de clase Memorystream que va coger el tamaño de la imagen
                        Dim arrImage() As Byte
                        Dim mstream As New System.IO.MemoryStream()

                        'SPECIFIES THE FILE FORMAT OF THE IMAGE
                        imagenLibro.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

                        'RETURNS THE ARRAY OF UNSIGNED BYTES FROM WHICH THIS STREAM WAS CREATED
                        arrImage = mstream.GetBuffer()

                        'GET THE SIZE OF THE STREAM IN BYTES
                        Dim FileSize As UInt32
                        FileSize = mstream.Length
                        'CLOSES THE CURRENT STREAM AND RELEASE ANY RESOURCES ASSOCIATED WITH THE CURRENT STREAM
                        mstream.Close()

                        ' Comprobamos que el ISBN no fue modificado incorrectamente.
                        If (validDatos.validarISBN(txtISBN.Text)) Then
                            If gestion.ModificarLibro(getIdFila, txtISBN.Text, txtTitulo.Text, CSng(txtPrecio.Text), txtAutor.Text, txtEditorial.Text, txtTapa.Text, txtGenero.Text, cbxCategorias.Text, cbxEstado.Text, cbxIdioma.Text, arrImage, " Libros ", " id ") Then
                                MsgBox("Libro Modificado con éxito . ", 64, "Gestion Libros")
                                cargarPantalla()
                            Else
                                MsgBox("Error Libro no modificado  . ", MsgBoxStyle.Exclamation, "Gestion Libros")
                                'aqui se deselecta las celdas de datagridview
                                cargarPantalla()

                            End If
                        Else
                            ' Error al modificar el isbn

                            MsgBox(validDatos.mensajeInfoDatoInvalido("ISBN"), 64, "Datos")
                        End If

                    End If

                Else
                    MsgBox("Por favor seleccione un Libro . ", 64, "Gestion Libros")
                End If
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
            gestion.getAdapter.Fill(gestion.getDataSet, "Libros")
            'aqui se carga el DatagridView
            DataGridView1.DataSource = gestion.getDataSet
            DataGridView1.DataMember = "Libros"
            'metodo DefaultCellStyle permite de definir la forma que van aparecer  los valores de la columna precio  en este caso C como currency
            'docs.microsoft.com/en-us/previous-versions/dotnet/netframework-4.0/dwhawy9k(v=vs.100)?WT.mc_id=DT-MVP-5003235
            DataGridView1.Columns("Precio").DefaultCellStyle.Format = "C"
            DataGridView1.ClearSelection()
            'DataGridView1.Columns.Item("imagen").Width = 100

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
            'aqui se obtiene la fila pasandole el indice 
            Try
                selectedFila = DataGridView1.Rows(indice)
                getIdFila = selectedFila.Cells(0).Value.ToString

                'actualizar el datagridviwe
                cargarPantalla()
            Catch ex As Exception
                MsgBox("Por favor selecciona una fila valida")
            End Try
            ' MsgBox(getIdFila)

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try

    End Sub

    'Modificar o establecer el tamano del imagen 
    'Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
    '    Try
    '        If (e.RowIndex < 0 Or e.ColumnIndex < 0) Then Return

    '        If DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).ValueType = GetType(Byte()) Then
    '            CType(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex),
    '          DataGridViewImageCell).ImageLayout = DataGridViewImageCellLayout.Zoom
    '        End If

    '    Catch ex As Exception

    '        gestion.mensajeErrorDatos()
    '    gestion.errorLogWrite()
    '    End Try
    'End Sub
    'En el evento button Eliminar para eliminar una fila
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
            ' y una vez seleccionda se recupera el id de la tabla para poder eliminar la fila 
            If DataGridView1.SelectedCells.Count > 0 Then


                Dim valor As Integer = MsgBox("¿Esta seguro de que desea Elminar Libro?", 36, "Gestion Libros")
                If valor = MsgBoxResult.Yes Then
                    ' MsgBox(getIdFila)

                    If gestion.eliminarFila(getIdFila, " Libros ", " id ") Then
                        MsgBox("Libro Eliminado con éxito . ", 64, "Gestion Libros")
                        llimpiarPantalla()
                        cargarPantalla()
                        getNumeroRegistros()
                    Else
                        MsgBox("Error Libro no Eliminado  . ", MsgBoxStyle.Exclamation, "Gestion Libros")
                        'aqui se deselecta las celdas de datagridview
                        cargarPantalla()

                    End If
                End If

            Else
                MsgBox("Por favor seleccione  un Libro . ", 64, "Gestion Libros")
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    ' Volver al menú principal
    Private Sub MenúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúPrincipalToolStripMenuItem.Click
        Me.Close()
        PantallaPrincipal.Show()

    End Sub

    Private Sub txtTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtTitulo.TextChanged
        ' Si es 0, se está recibiendo que se va a validar un usuario.
        ' Si es 1, es nombre.
        ' Si es 2 es apellido.
        ' Si es 3 es dirección. -> Ejemmplo
        ' Ejemplos abajo
        ' 4 
        ' 5 
        ' 6 etc...
        ' Pasamos el valor 1 porque el título permite caracteres parecidos a los de un nombre de persona.
        Try
            If (validDatos.validarUsuario(txtTitulo.Text, 1)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("Título"), 64, "Datos")
                txtTitulo.Clear()
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        ' Si se recibe 0 se está validando contraseña en inicio de sesión. (se permiten 6 dígitos)
        ' Si se recibe 1 se está validando teléfono. (se permite 9 dígitos).
        ' Si se recibe 2 se está validando precios en productos
        ' Si recibe 3 es Id (cliente, libro, producto es igual).
        Try

            If (validDatos.validarCodigo(txtPrecio.Text, 2)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("Precio"), 64, "Precio")
                txtPrecio.Clear()
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    ' Validar autor
    Private Sub txtAutor_TextChanged(sender As Object, e As EventArgs) Handles txtAutor.TextChanged
        Try
            If (validDatos.validarUsuario(txtAutor.Text, 1)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("Autor"), 64, "Datos")
                txtAutor.Clear()
            End If

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



    ' Misma funcionalidad que botón limpiar
    Private Sub toolsbtnNuevo_Click(sender As Object, e As EventArgs) Handles toolsbtnNuevo.Click
        llimpiarPantalla()
    End Sub



    ' Guardar
    ' igual que botón alta.
    Private Sub toolsbtnGuardar_Click(sender As Object, e As EventArgs) Handles toolsbtnGuardar.Click
        'damos nombre de imagen como el id del libro como es identificador unico
        Try
            If (txtLibroID.Text = "" Or txtISBN.Text = "" Or txtTitulo.Text = "" Or txtPrecio.Text = "" Or txtAutor.Text = "" Or txtEditorial.Text = "" Or txtTapa.Text = "" Or txtStock.Text = "" Or txtGenero.Text = "" Or cbxCategorias.Text = "" Or cbxEstado.Text = "" Or cbxIdioma.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Libros")
            Else
                If (validDatos.validarISBN(txtISBN.Text)) Then

                    'se crea un objeto de clase Memorystream que va coger el tamaño de la imagen
                    Dim arrImage() As Byte
                    Dim mstream As New System.IO.MemoryStream()

                    'SPECIFIES THE FILE FORMAT OF THE IMAGE
                    imagenLibro.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

                    'RETURNS THE ARRAY OF UNSIGNED BYTES FROM WHICH THIS STREAM WAS CREATED
                    arrImage = mstream.GetBuffer()

                    'GET THE SIZE OF THE STREAM IN BYTES
                    Dim FileSize As UInt32
                    FileSize = mstream.Length
                    'CLOSES THE CURRENT STREAM AND RELEASE ANY RESOURCES ASSOCIATED WITH THE CURRENT STREAM
                    mstream.Close()


                    If gestion.insertLibro(CInt(txtLibroID.Text), txtISBN.Text, txtTitulo.Text, CSng(txtPrecio.Text), txtAutor.Text, txtEditorial.Text, txtTapa.Text, CInt(txtStock.Text), txtGenero.Text, cbxCategorias.Text, cbxEstado.Text, cbxIdioma.Text, arrImage) Then


                        MsgBox("Libro Insertado con éxito . ", 64, "Gestion Libros")
                        llimpiarPantalla()
                        cargarPantalla()
                        getNumeroRegistros()
                    Else

                        MsgBox("Error Libro no Insertado  . ", MsgBoxStyle.Exclamation, "Gestion Libros")
                    End If
                Else
                    MsgBox(validDatos.mensajeInfoDatoInvalido("ISBN"), 64, "Datos")
                End If
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub


    ' Toolstrip Eliminar
    ' Igual que botón eliminar
    Private Sub toolsbtnEliminar_Click(sender As Object, e As EventArgs) Handles toolsbtnEliminar.Click
        'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
        ' y una vez seleccionda se recupera el id de la tabla para poder eliminar la fila 
        Try
            If DataGridView1.SelectedCells.Count > 0 Then


                Dim valor As Integer = MsgBox("¿Esta seguro de que desea Elminar Libro?", 36, "Gestion Libros")
                If valor = MsgBoxResult.Yes Then
                    ' MsgBox(getIdFila)

                    If gestion.eliminarFila(getIdFila, " Libros ", " id ") Then
                        MsgBox("Libro Eliminado con éxito . ", 64, "Gestion Libros")
                        llimpiarPantalla()
                        cargarPantalla()
                        getNumeroRegistros()
                    Else
                        MsgBox("Error Libro no Eliminado  . ", MsgBoxStyle.Exclamation, "Gestion Libros")
                        'aqui se deselecta las celdas de datagridview
                        cargarPantalla()

                    End If
                End If

            Else
                MsgBox("Por favor seleccione  un Libro . ", 64, "Gestion Libros")
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
        gestion.errorLogWrite()
        End Try
    End Sub

    ' Método para llamar al generador de informes para libros.
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        FormRepLibros.Show()

    End Sub

    Private Sub GestionDeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeStockToolStripMenuItem.Click
        Me.Close()
        GestionStock.Show()
    End Sub

    Private Sub GestionDeBusquedaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeBusquedaToolStripMenuItem.Click
        Me.Close()
        GestionBusqueda.Show()
    End Sub

    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click
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

    Private Sub txtISBN_TextChanged(sender As Object, e As EventArgs) Handles txtISBN.TextChanged

    End Sub

    'Metodo de evento cerrando fourmulario 
    Private Sub Form1_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PantallaPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub txtEditorial_TextChanged(sender As Object, e As EventArgs) Handles txtEditorial.TextChanged
        ' Si es 0, se está recibiendo que se va a validar un usuario.
        ' Si es 1, es nombre.
        ' Si es 2 es apellido.
        ' Si es 3 es dirección. -> Ejemmplo
        ' Ejemplos abajo
        ' 4 
        ' 5 
        ' 6 etc...
        ' Pasamos el valor 1 porque el título permite caracteres parecidos a los de un nombre de persona.
        Try
            If (validDatos.validarUsuario(txtEditorial.Text, 1)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("Título"), 64, "Datos")
                txtEditorial.Clear()
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub txtTapa_TextChanged(sender As Object, e As EventArgs) Handles txtTapa.TextChanged
        ' Si es 0, se está recibiendo que se va a validar un usuario.
        ' Si es 1, es nombre.
        ' Si es 2 es apellido.
        ' Si es 3 es dirección. -> Ejemmplo
        ' Ejemplos abajo
        ' 4 
        ' 5 
        ' 6 etc...
        ' Pasamos el valor 1 porque el título permite caracteres parecidos a los de un nombre de persona.
        Try
            If (validDatos.validarUsuario(txtTapa.Text, 1)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("Título"), 64, "Datos")
                txtTapa.Clear()
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub txtGenero_TextChanged(sender As Object, e As EventArgs) Handles txtGenero.TextChanged
        ' Si es 0, se está recibiendo que se va a validar un usuario.
        ' Si es 1, es nombre.
        ' Si es 2 es apellido.
        ' Si es 3 es dirección. -> Ejemmplo
        ' Ejemplos abajo
        ' 4 
        ' 5 
        ' 6 etc...
        ' Pasamos el valor 1 porque el título permite caracteres parecidos a los de un nombre de persona.
        Try
            If (validDatos.validarUsuario(txtGenero.Text, 1)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("Título"), 64, "Datos")
                txtGenero.Clear()
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub GestiónProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónProductosToolStripMenuItem.Click
        Me.Close()
        GestionProductos.Show()

    End Sub

    Private Sub txtLibroID_TextChanged(sender As Object, e As EventArgs) Handles txtLibroID.TextChanged
        ' Si se recibe 0 se está validando contraseña en inicio de sesión. (se permiten 6 dígitos)
        ' Si se recibe 1 se está validando teléfono. (se permite 9 dígitos).
        ' Si se recibe 2 se está validando precios en productos
        ' Si recibe 3 es Id (cliente, libro, producto es igual).
        Try

            If (validDatos.validarCodigo(txtLibroID.Text, 3)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("ID"), 64, "ID")
                txtLibroID.Clear()
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub txtStock_TextChanged(sender As Object, e As EventArgs) Handles txtStock.TextChanged
        ' Si se recibe 0 se está validando contraseña en inicio de sesión. (se permiten 6 dígitos)
        ' Si se recibe 1 se está validando teléfono. (se permite 9 dígitos).
        ' Si se recibe 2 se está validando precios en productos
        ' Si recibe 3 es Id (cliente y libro es igual).
        ' Si recibe 4 es stock
        Try

            If (validDatos.validarCodigo(txtStock.Text, 3)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("Stock"), 64, "Stock")
                txtStock.Clear()
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