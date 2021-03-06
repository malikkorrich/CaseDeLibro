Imports System.IO
Imports System.Drawing.Printing


Public Class GestionCobro
    Dim validador As New libValidacionDatos.Validacion

    Private Sub GestionCobro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim banderaPago As Boolean = False

    Public stringTicket As String = ""

    Public numeroRegistros As Single = 0

    ' Botón cero
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        TextBox_importe.Text = TextBox_importe.Text + "0"
    End Sub

    ' Botón uno
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox_importe.Text = TextBox_importe.Text + "1"
    End Sub

    ' Botón dos
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        TextBox_importe.Text = TextBox_importe.Text + "2"
    End Sub

    ' Botón tres
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        TextBox_importe.Text = TextBox_importe.Text + "3"
    End Sub

    ' Botón cuatro
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TextBox_importe.Text = TextBox_importe.Text + "4"
    End Sub

    ' Botón cinco
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        TextBox_importe.Text = TextBox_importe.Text + "5"
    End Sub

    ' Botón seis
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        TextBox_importe.Text = TextBox_importe.Text + "6"
    End Sub

    ' Botón siete
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        TextBox_importe.Text = TextBox_importe.Text + "7"
    End Sub

    ' Botón ocho
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        TextBox_importe.Text = TextBox_importe.Text + "8"
    End Sub

    ' Botón nueve
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        TextBox_importe.Text = TextBox_importe.Text + "9"
    End Sub

    ' Botón borrar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        TextBox_importe.Clear()
    End Sub

    ' Botón para introducir un punto
    Private Sub btn_ponerPunto_Click(sender As Object, e As EventArgs) Handles btn_ponerPunto.Click
        TextBox_importe.Text = TextBox_importe.Text + "."
    End Sub

    ' Se ejecuta al cargarse el formulario
    Private Sub Cobro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_importe.Focus()
        Label_numDevolver.Text = 0

        ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
        'Dim lectura As New LecturaEscrituraArchivos.Lectura

        ' Accedemos al archivo "Cobro_Aux.txt" y extraemos el número de registros con los que cuenta
        ' Dim numeroRegistros As Integer = lectura.numeroRegistros("Cobro_Aux.txt")
        ' Contendrá el valor de los registros que extraigamos del fichero Cobro_Aux.txt
        Dim columna As String = ""

        'lectura.leerProducto_ListBox(numeroRegistros, "Cobro_Aux.txt", columna)

        Dim aux As String = columna

        ' Asignamos al label el valor de aux (que es el precio total a pagar)
        'lbCobrado.Text = Trim(aux)
        lbCobrado.Text = TPV.precioTotal
    End Sub

    ' Para imprimir
    Private Sub ticket(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Try
            ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
            ' Dim lectura As New LecturaEscrituraArchivos.Lectura

            ' Accedemos al archivo "Cobro_Aux.txt" y extraemos el número de registros con los que cuenta
            '  Dim numeroRegistros As Integer = lectura.numeroRegistros("Cobro_Aux.txt")

            ' Contendrá el valor de los registros que extraigamos del fichero Cobro_Aux.txt
            Dim columna As String = ""
            ' Leemos
            ' lectura.leerProducto_ListBox(1, "Cobro_Aux.txt", columna)

            Dim espacios As Single = 120
            Dim incremento As Single = 25

            Dim estilo As String = "Arial"

            Dim auxIVA2 As Single = (Val(lbCobrado.Text) * 0.21)

            Dim auxIVA As Single = Val(lbCobrado.Text) - auxIVA2


            Dim auxStrinIVA As String = auxIVA

            ' Imprimimos Imagen

            ev.Graphics.DrawImage((PictureBox1.Image), 180, espacios, 220, 60)

            ' Imprimimos Texto
            espacios += 70
            ev.Graphics.DrawString("                Casa del Libro    ", New Font(estilo, 14, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("                C\Fuencarral 119    ", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("                Telef. 911 79 34 63    ", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            'ev.Graphics.DrawString("                  Telef. 605 689 166    ", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            ' espacios += incremento
            ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("Factura simplificada", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("Fecha: " + Now.ToLocalTime, New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("Nombre      Precio", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString(TPV.totalPedido, New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            If (numeroRegistros >= 4) Then
                espacios += numeroRegistros * 18
            ElseIf (numeroRegistros < 4) Then
                espacios += numeroRegistros * 15
            End If
            espacios += incremento * TPV.count
            'ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("Subtotal:                                              " + auxStrinIVA, New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            If cbxSocio.Checked = True Then
                ev.Graphics.DrawString("10% Descuento Socio", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
                espacios += incremento
            End If
            ev.Graphics.DrawString("21% IVA", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("Total:                                                   " + lbCobrado.Text, New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("Cantidad entregada:                            " + TextBox_importe.Text, New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("Cambio:                                               " + Label_numDevolver.Text, New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("      -------- Gracias por su visita --------           ", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("            Casa del Libro S.L.", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("            CIF: A-59913509", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("            C\Fuencarral 119", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
            espacios += incremento
            ev.Graphics.DrawString("            Madrid, Madrid", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)

            ev.HasMorePages = False

        Catch ex As Exception

            validador.mensajeErrorDatos()
            validador.errorLogWrite()
        End Try
    End Sub

    ' Botón para finalizar e imprimir el recibo
    Private Sub btn_finalizarImprimir_Click(sender As Object, e As EventArgs) Handles btn_finalizarImprimir.Click

        Try

            If (ComboBox1.SelectedItem <> "Tarjeta") Then
                If (ComboBox1.SelectedItem <> "Efectivo") Then
                    MsgBox("Debe seleccionar un método de pago. Operación abortada", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Aviso")
                    Return
                End If
            End If


            ' Imprimir
            AddHandler PrintDocument1.PrintPage, AddressOf Me.ticket
            PrintDocument1.PrinterSettings.PrintFileName() = "PRUEBA"
            PrintDocument1.Print()


            If (Val(Label_devolver.Text) < 0) Then
                ' Comprobamos que el cliente ha pagado lo suficiente para cubrir el precio.
                ' En caso contrario avisamos con un mensaje 
                MsgBox("El dinero aportado por el cliente es insuficiente.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Aviso")
                Return
            End If

            ' Guardamos lo cobrado en el archivo de recaudacion diaria. 
            ' Se guarda la línea con la fecha. 
            'Try
            '    Dim datosAcceso As New FileStream("cajaDiaria.txt", FileMode.Append, FileAccess.Write)
            '    Dim sw As New StreamWriter(datosAcceso)
            '    sw.WriteLine(lbCobrado.Text)
            '    sw.WriteLine("Guardada la caja diaria en: " & Now)
            '    ' Cerramos los flujos para escribir en el log de acceso.
            '    sw.Close()
            '    datosAcceso.Close()
            '    MsgBox("Caja diaria guardada correctamente.")
            'Catch ex As Exception
            '    MsgBox("Error al intentar escribir en el archivo de caja diaria", MsgBoxStyle.OkOnly, "Aviso")
            'End Try


            ' Conexión con el archivo 
            ' Dim Variable As New FileStream("")
            ' Imprimir...

            ' Borramos el fichero "Cobro_Aux.txt"
            ' My.Computer.FileSystem.DeleteFile("Cobro_Aux.txt")
            MsgBox("Ticket impreso correctamente.", 64, "Venta completada")
            ' Cerramos la pantalla de gestión de cobros
            Me.Close()
            ' Volvemos a la pantalla de ventas.
            TPV.Show()

        Catch ex As Exception

            validador.mensajeErrorDatos()
            validador.errorLogWrite()
        End Try

    End Sub

    ' Al pulsar el botón salir del menú
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Cerramos está pantalla
        Me.Close()
        ' Mostramos de nuevo la pantallaVentas
        TPV.Show()
    End Sub

    Private Sub TextBox_importe_TextChanged(sender As Object, e As EventArgs) Handles TextBox_importe.TextChanged

        Dim validador As New libValidacionDatos.Validacion
        Dim precio As Single

        Try

            If (validador.validarCodigo(TextBox_importe.Text, 2) And Val(TextBox_importe.Text) >= 0) Then

                If (banderaPago = True) Then
                    If cbxSocio.Checked = True Then
                        precio = Val(lbCobrado.Text) - (Val(lbCobrado.Text) * 0.1)
                        ' Se realiza el calculo del importe a devolver por parte del vendedor
                        Label_numDevolver.Text = Math.Round(Val(TextBox_importe.Text) - precio, 3)
                    Else
                        ' Se realiza el calculo del importe a devolver por parte del vendedor
                        Label_numDevolver.Text = Math.Round(Val(TextBox_importe.Text) - Val(lbCobrado.Text), 3)
                    End If



                End If
            Else
                MsgBox(validador.mensajeInfoDatoInvalido("Importe"), 64, "Importe")
                TextBox_importe.Clear()
            End If

        Catch ex As Exception

            validador.mensajeErrorDatos()
            validador.errorLogWrite()
        End Try



    End Sub

    ' Cuando se produzca un cambio en el comboBox...
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


        ' Pagar con tarjeta
        If (ComboBox1.SelectedItem = "Tarjeta") Then
            Label_numDevolver.Text = "0"
            TextBox_importe.Hide()
            TextBox_importe.Text = lbCobrado.Text
            banderaPago = False
        End If
        ' Pagar con efectivo
        If (ComboBox1.SelectedItem = "Efectivo") Then
            TextBox_importe.Show()
            banderaPago = True
        End If

    End Sub





End Class


