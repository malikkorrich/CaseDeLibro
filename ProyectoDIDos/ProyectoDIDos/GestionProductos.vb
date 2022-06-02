Imports System.Windows.Forms

Public Class GestionProductos
    'aqui se crea  un objeto de la clase GestionConexion de la liberia 

    Dim queryAdaptador As String = "SELECT * FROM Gafas"
    Dim datasetTableName As String = "Gafas"

    Dim gestion As New LibConexion.GestionConexion(queryAdaptador, datasetTableName)
    Public datatable As New DataTable
    Public getIdFila As String
    Public getISBN As String

    ' Variables usadas para validar datos
    Dim validDatos As New libValidacionDatos.Validacion

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles LimpiarToolStripButton.Click
        limpiarPantalla()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles AltaToolStripButton.Click
        'damos nombre de imagen como el id del libro como es identificador unico
        Try
            If (txtID.Text = "" Or txtISBN.Text = "" Or txtNombre.Text = "" Or cbxForma.Text = "" Or cbxColor.Text = "" Or txtPrecio.Text = "" Or txtStock.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Libros")
            Else
                If (validDatos.validarISBN(txtISBN.Text)) Then



                    If Not imagenGafas.Image Is Nothing Then


                        'se crea un objeto de clase Memorystream que va coger el tamaño de la imagen
                        Dim arrImage() As Byte
                        Dim mstream As New System.IO.MemoryStream()

                        'SPECIFIES THE FILE FORMAT OF THE IMAGE
                        imagenGafas.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

                        'RETURNS THE ARRAY OF UNSIGNED BYTES FROM WHICH THIS STREAM WAS CREATED
                        arrImage = mstream.GetBuffer()

                        'GET THE SIZE OF THE STREAM IN BYTES
                        Dim FileSize As UInt32
                        FileSize = mstream.Length
                        'CLOSES THE CURRENT STREAM AND RELEASE ANY RESOURCES ASSOCIATED WITH THE CURRENT STREAM
                        mstream.Close()


                        If gestion.insertGafas(CInt(txtID.Text), txtISBN.Text, txtNombre.Text, cbxForma.Text, cbxColor.Text, CSng(txtPrecio.Text), CInt(txtStock.Text), arrImage) Then


                            MsgBox("Gafa Insertado con éxito . ", 64, "Gestion Gafas")
                            limpiarPantalla()
                            cargarTab1()
                            getNumeroRegistros()
                        Else

                            MsgBox("Error Gafa no Insertado  . ", MsgBoxStyle.Exclamation, "Gestion Gafas")
                        End If

                    Else
                        MsgBox("Por favor seleccione un imagen . ", MsgBoxStyle.Exclamation, "Gestion Gafas")
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




    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub




    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer


    '--------------------------------------------------------------------------------------------------



    Private Sub GestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' releacionar los campos de la tabla con los textbox se usando DataBindings
        txtID.DataBindings.Add("text", gestion.getDataSet, "Gafas.Id")
        txtISBN.DataBindings.Add("text", gestion.getDataSet, "Gafas.isbn")
        txtNombre.DataBindings.Add("text", gestion.getDataSet, "Gafas.nombre")
        txtStock.DataBindings.Add("text", gestion.getDataSet, "Gafas.stock")
        txtPrecio.DataBindings.Add("text", gestion.getDataSet, "Gafas.precio")
        cbxForma.DataBindings.Add("text", gestion.getDataSet, "Gafas.forma")
        cbxColor.DataBindings.Add("text", gestion.getDataSet, "Gafas.color")
        'picturebox databingdings se crea un objeto anonimo de la clase Binding que recibe 4 parametros
        'el tipo que es Image, nombre del dataset , nombre del campo , un boolean que permite aplicar formato
        imagenGafas.DataBindings.Add(New Binding("Image", gestion.getDataSet, "Gafas.imagen", True))


        'cargar en el datagridview de la tab1 
        'donde sacar los datos pues de la memoria cache dataset
        cargarTab1()

        'cargar en el datagridview de la tab2
        cargarTab2()

        'desabilitar campo de stock (no se peude gestion el stock , la gestion de libro)
        txtStock.Enabled = True



        'metodo para mostrar  donde esta cursor y en datagridview del total de la filas
        getNumeroRegistros()


        ' Llamamos al método para ver qué botones de la barra de herramientas están disponibles para
        ' este usuario.
        PantallaPrincipal.darPermisos()

        'definir la ruta del  fichiero help
        HelpProvider1.HelpNamespace = System.Environment.CurrentDirectory & "\\Ayuda software Casa del Libro.chm"
    End Sub

    'Metodo para limpiar los campos del formulario
    Private Sub limpiarPantalla()
        txtID.Clear()
        txtISBN.Clear()
        txtNombre.Clear()
        txtPrecio.Clear()
        txtStock.Clear()
        cbxForma.Text = Nothing
        cbxColor.Text = Nothing
        imagenGafas.Image = New PictureBox().Image




    End Sub



    'metodo para Actualizar y cargar los datos en data grid view
    Private Sub cargarTab1()
        Try
            gestion.getDataSet.Clear()
            gestion.getAdapter.Fill(gestion.getDataSet, "Gafas")
            'aqui se carga el DatagridView
            DataGridView1.DataSource = gestion.getDataSet
            DataGridView1.DataMember = "Gafas"
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


    'metodo para Actualizar y cargar los datos en data grid view
    Private Sub cargarTab2()
        Try
            gestion.getDataSet.Clear()
            gestion.getAdapter.Fill(gestion.getDataSet, "Gafas")
            'aqui se carga el DatagridView
            DataGridView2.DataSource = gestion.getDataSet
            DataGridView2.DataMember = "Gafas"
            'metodo DefaultCellStyle permite de definir la forma que van aparecer  los valores de la columna precio  en este caso C como currency
            'docs.microsoft.com/en-us/previous-versions/dotnet/netframework-4.0/dwhawy9k(v=vs.100)?WT.mc_id=DT-MVP-5003235
            DataGridView2.Columns("Precio").DefaultCellStyle.Format = "C"
            DataGridView2.ClearSelection()
            'DataGridView1.Columns.Item("imagen").Width = 100
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
                getISBN = selectedFila.Cells(1).Value.ToString

                'actualizar datagrid view
                cargarTab1()

            Catch ex As Exception
                MsgBox("Por favor seleccione  un fila valida . ", 64, "Gestion Gafas")
            End Try


            'aqui se recupera el valor de la primera celda que id 

            ' MsgBox(getIdFila)

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try

    End Sub







    'metodo para mostrar  donde esta cursor y en datagridview del total de la filas
    Private Sub getNumeroRegistros()
        Try
            lblNumero.Text = (BindingContext(gestion.getDataSet, "Gafas").Position + 1).ToString + " de " +
            (BindingContext(gestion.getDataSet, "Gafas").Count).ToString

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        'BindingContext(midataset, "Tabla").Position = DataGridView1.RowCount - 1
        Try
            BindingContext(gestion.getDataSet, "Gafas").Position = BindingContext(gestion.getDataSet, "Gafas").Count - 1
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
            BindingContext(gestion.getDataSet, "Gafas").Position += 1

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
            BindingContext(gestion.getDataSet, "Gafas").Position -= 1
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
            BindingContext(gestion.getDataSet, "Gafas").Position = 0
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



    'Metodo de evento cerrando fourmulario 
    Private Sub Form1_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PantallaPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        'damos nombre de imagen como el id del libro como es identificador unico
        Try
            If (txtID.Text = "" Or txtISBN.Text = "" Or txtNombre.Text = "" Or cbxForma.Text = "" Or cbxColor.Text = "" Or txtPrecio.Text = "" Or txtStock.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Libros")
            Else
                If (validDatos.validarISBN(txtISBN.Text)) Then



                    If Not imagenGafas.Image Is Nothing Then


                        'se crea un objeto de clase Memorystream que va coger el tamaño de la imagen
                        Dim arrImage() As Byte
                        Dim mstream As New System.IO.MemoryStream()

                        'SPECIFIES THE FILE FORMAT OF THE IMAGE
                        imagenGafas.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

                        'RETURNS THE ARRAY OF UNSIGNED BYTES FROM WHICH THIS STREAM WAS CREATED
                        arrImage = mstream.GetBuffer()

                        'GET THE SIZE OF THE STREAM IN BYTES
                        Dim FileSize As UInt32
                        FileSize = mstream.Length
                        'CLOSES THE CURRENT STREAM AND RELEASE ANY RESOURCES ASSOCIATED WITH THE CURRENT STREAM
                        mstream.Close()


                        If gestion.insertGafas(CInt(txtID.Text), txtISBN.Text, txtNombre.Text, cbxForma.Text, cbxColor.Text, CSng(txtPrecio.Text), CInt(txtStock.Text), arrImage) Then


                            MsgBox("Gafa Insertado con éxito . ", 64, "Gestion Gafas")
                            limpiarPantalla()
                            cargarTab1()
                            getNumeroRegistros()
                        Else

                            MsgBox("Error Gafa no Insertado  . ", MsgBoxStyle.Exclamation, "Gestion Gafas")
                        End If

                    Else
                        MsgBox("Por favor seleccione un imagen . ", MsgBoxStyle.Exclamation, "Gestion Gafas")
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
                imagenGafas.Image = Image.FromFile(odf.FileName)

            End If


        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If (txtID.Text = "" Or txtISBN.Text = "" Or txtNombre.Text = "" Or cbxForma.Text = "" Or cbxColor.Text = "" Or txtPrecio.Text = "" Or txtStock.Text = "") Then

                MsgBox("Por favor rellene los campos . ", 64, "Gestion Gafas")
            Else

                'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
                ' y una vez seleccionda se recupera el id de la tabla para poder modifcar la fila 
                If DataGridView1.SelectedCells.Count > 0 Then
                    Dim valor As Integer = MsgBox("¿Esta seguro de que desea Modificar Libro?", 36, "Gestion Gafas")
                    If valor = MsgBoxResult.Yes Then
                        'MsgBox(getIdFila)


                        'se crea un objeto de clase Memorystream que va coger el tamaño de la imagen
                        Dim arrImage() As Byte
                        Dim mstream As New System.IO.MemoryStream()

                        'SPECIFIES THE FILE FORMAT OF THE IMAGE
                        imagenGafas.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

                        'RETURNS THE ARRAY OF UNSIGNED BYTES FROM WHICH THIS STREAM WAS CREATED
                        arrImage = mstream.GetBuffer()

                        'GET THE SIZE OF THE STREAM IN BYTES
                        Dim FileSize As UInt32
                        FileSize = mstream.Length
                        'CLOSES THE CURRENT STREAM AND RELEASE ANY RESOURCES ASSOCIATED WITH THE CURRENT STREAM
                        mstream.Close()

                        ' Comprobamos que el ISBN no fue modificado incorrectamente.
                        If (validDatos.validarISBN(txtISBN.Text)) Then
                            If gestion.ModificarGafas(getIdFila, txtISBN.Text, txtNombre.Text, cbxForma.Text, cbxColor.Text, CSng(txtPrecio.Text), CInt(txtStock.Text), arrImage, " Gafas ", " id ") Then
                                MsgBox("Gafa Modificado con éxito . ", 64, "Gestion Gafas")
                                cargarTab1()
                            Else
                                MsgBox("Error Gafa no modificado  . ", MsgBoxStyle.Exclamation, "Gestion Gafas")
                                'aqui se deselecta las celdas de datagridview
                                cargarTab1()

                            End If
                        Else
                            ' Error al modificar el isbn

                            MsgBox(validDatos.mensajeInfoDatoInvalido("ISBN"), 64, "Datos")
                        End If

                    End If

                Else
                    MsgBox("Por favor seleccione una Gafa . ", 64, "Gestion Gafas")
                End If
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
            ' y una vez seleccionda se recupera el id de la tabla para poder eliminar la fila 
            If DataGridView1.SelectedCells.Count > 0 Then


                Dim valor As Integer = MsgBox("¿Esta seguro de que desea Elminar Libro?", 36, "Gestion Gafas")
                If valor = MsgBoxResult.Yes Then
                    ' MsgBox(getIdFila)

                    If gestion.eliminarFila(getIdFila, " Gafas ", " id ") Then
                        MsgBox("Gafa Eliminada con éxito . ", 64, "Gestion Gafas")
                        limpiarPantalla()
                        cargarTab1()
                        getNumeroRegistros()
                    Else
                        MsgBox("Error gafa no Eliminada  . ", MsgBoxStyle.Exclamation, "Gestion Gafas")
                        'aqui se deselecta las celdas de datagridview
                        cargarTab1()

                    End If
                End If

            Else
                MsgBox("Por favor seleccione  una Gafa . ", 64, "Gestion Gafas")
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

            gestion.buscarporCaracter(txtBusID.Text, "Gafas", " id", "Gafas")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView2.DataSource = gestion.getDataSet
        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try

    End Sub

    Private Sub txtBusISBN_TextChanged(sender As Object, e As EventArgs) Handles txtBusISBN.TextChanged
        Try


            gestion.buscarporCaracter(txtBusISBN.Text, "Gafas", " isbn", "Gafas")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView2.DataSource = gestion.getDataSet
        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub txtBusNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBusNombre.TextChanged
        Try


            gestion.buscarporCaracter(txtBusNombre.Text, "Gafas", " nombre", "Gafas")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView2.DataSource = gestion.getDataSet
        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub cbxBusColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxBusColor.SelectedIndexChanged
        Try


            gestion.buscarporCaracter(cbxBusColor.Text, "Gafas", " color", "Gafas")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView2.DataSource = gestion.getDataSet
        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub cbxBusForma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxBusForma.SelectedIndexChanged
        Try


            gestion.buscarporCaracter(cbxBusForma.Text, "Gafas", " forma", "Gafas")
            'aqui se recupera midataset desde metodo get de la clase gestionConexion
            DataGridView2.DataSource = gestion.getDataSet
        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiarTab2.Click
        'limpiar campos campos de busqueda de la tab2
        txtBusID.Clear()
        txtBusISBN.Clear()
        txtBusNombre.Clear()
        cbxBusColor.Text = Nothing
        cbxBusForma.Text = Nothing
    End Sub

    Private Sub btnLimpiarTab1_Click(sender As Object, e As EventArgs) Handles btnLimpiarTab1.Click
        limpiarPantalla()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        ' Si se recibe 0 se está validando contraseña en inicio de sesión. (se permiten 6 dígitos)
        ' Si se recibe 1 se está validando teléfono. (se permite 9 dígitos).
        ' Si se recibe 2 se está validando precios en productos
        ' Si recibe 3 es Id (cliente,  libro, producto es igual).
        Try

            If (validDatos.validarCodigo(txtID.Text, 3)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("ID"), 64, "ID")
                txtID.Clear()
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

    Private Sub GestionDeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeStockToolStripMenuItem.Click
        Me.Close()
        GestionStock.Show()
    End Sub

    Private Sub GestionEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionEmpleadosToolStripMenuItem.Click
        Me.Close()
        GestionEmpleados.Show()
    End Sub


    Private Sub GestionDeBusquedaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BúsquedaToolStripMenuItem.Click
        Me.Close()
        GestionBusqueda.Show()

    End Sub

    Private Sub EliminarToolStripButton_Click(sender As Object, e As EventArgs) Handles EliminarToolStripButton.Click
        Try
            'esa condicion nos permite assegurar que una celda de la fila en datagridview es seleccionda para poder eleminar la fila 
            ' y una vez seleccionda se recupera el id de la tabla para poder eliminar la fila 
            If DataGridView1.SelectedCells.Count > 0 Then


                Dim valor As Integer = MsgBox("¿Esta seguro de que desea Elminar Libro?", 36, "Gestion Gafas")
                If valor = MsgBoxResult.Yes Then
                    ' MsgBox(getIdFila)

                    If gestion.eliminarFila(getIdFila, " Gafas ", " id ") Then
                        MsgBox("Gafa Eliminada con éxito . ", 64, "Gestion Gafas")
                        limpiarPantalla()
                        cargarTab1()
                        getNumeroRegistros()
                    Else
                        MsgBox("Error gafa no Eliminada  . ", MsgBoxStyle.Exclamation, "Gestion Gafas")
                        'aqui se deselecta las celdas de datagridview
                        cargarTab1()

                    End If
                End If

            Else
                MsgBox("Por favor seleccione  una Gafa . ", 64, "Gestion Gafas")
            End If

        Catch ex As Exception

            gestion.mensajeErrorDatos()
            gestion.errorLogWrite()
        End Try
    End Sub

    Private Sub MenúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúPrincipalToolStripMenuItem.Click
        Me.Close()
        PantallaPrincipal.Show()
    End Sub

    Private Sub txtStock_TextChanged(sender As Object, e As EventArgs) Handles txtStock.TextChanged
        ' Si se recibe 0 se está validando contraseña en inicio de sesión. (se permiten 6 dígitos)
        ' Si se recibe 1 se está validando teléfono. (se permite 9 dígitos).
        ' Si se recibe 2 se está validando precios en productos
        ' Si recibe 3 es Id (cliente y libro es igual).
        ' si recibe 4 es para validar stock.
        Try

            If (validDatos.validarCodigo(txtStock.Text, 4)) Then
            Else
                MsgBox(validDatos.mensajeInfoDatoInvalido("Stock"), 64, "Stock")
                txtStock.Clear()
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

    Private Sub TPVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TPVToolStripMenuItem.Click
        Me.Close()
        TPV.Show()
    End Sub
End Class
