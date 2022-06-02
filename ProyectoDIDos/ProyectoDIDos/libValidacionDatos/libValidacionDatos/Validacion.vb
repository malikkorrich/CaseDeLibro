Imports System.IO
Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Validacion
    Dim conexionUrl As String = "Provider=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=./cas_lib_db.accdb"
    Dim adaptador As OleDbDataAdapter
    Dim midataset As DataSet
    Dim conexion As OleDbConnection

    Public Sub New()
        Try
            conexion = New OleDbConnection(conexionUrl)
            adaptador = New OleDbDataAdapter("SELECT * FROM Usuarios", conexion)
            midataset = New DataSet
            adaptador.Fill(midataset, "Tabla")
        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Sub

    ' Constructor parametrizado.
    Public Sub New(consulta As String, tabla As String)
        Try
            conexion = New OleDbConnection(conexionUrl)
            adaptador = New OleDbDataAdapter("SELECT " & consulta & " FROM " & tabla, conexion)
            midataset = New DataSet
            adaptador.Fill(midataset, tabla)

        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Sub


    ' Función para ver si los datos (String) introducidos por el usuario son válidos para lo que se exige en
    ' el campo.
    Public Function validarUsuario(stringRecibido As String, tipo As Integer) As Boolean
        ' Si es 0, se está recibiendo que se va a validar un usuario.
        ' Si es 1, es nombre.
        ' Si es 2 es apellido.
        ' Si es 3 es dirección. -> Ejemmplo
        ' Ejemplos abajo
        ' 4 
        ' 5 
        ' 6 etc...

        ' Entorno:
        ' Creamos una lista de caracteres permitidos.
        Dim charsPosibles As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ"
        ' Se permiten espacios y otros caracteres en los nombres, apellidos y direcciones.
        ' Para el nombre y apellidos es el mismo rango de caracteres posible.
        Dim charsPosiblesNombre As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚç- "
        Dim charsposiblesDireccion As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ ,'ªº\-0123456789"


        ' Las variables donde guardaremos los caracteres para compararlos.
        Dim chDeLista As Char
        Dim chRecibido As Char
        ' El buchón/chivato para ver si el número de aciertos (caracteres equivalentes) es el mismo al número
        ' de caracteres del string pasado por parámetro.
        Dim coincidencias As Integer = 0
        ' Finalmente la variable boolean valido para que en el formulario se pueda saber si
        ' el string es válido o no.
        Dim valido As Boolean = False
        Dim valorMaximo As Integer
        Try

            If tipo = 0 Then
                valorMaximo = 10
            ElseIf tipo = 1 Then
                valorMaximo = 25
            ElseIf tipo = 2 Then
                valorMaximo = 30
            ElseIf tipo = 3 Then
                valorMaximo = 50

            End If



            ' Inicio
            ' Primero comprobamos el tamaño del string
            If stringRecibido.Length > valorMaximo Then
                MsgBox("No se permiten más de" & valorMaximo & " caracteres.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta")
            Else
                ' Iteramos un número de veces igual al tamaño del string pasado por parámetro.
                For i = 1 To stringRecibido.Length
                    ' Guardamos el carácter en chRecibido.
                    chRecibido = GetChar(stringRecibido, i)
                    ' Comprobamos si el carácter que acabamos de guardar es igual a los caracteres del string(charsPosibles).
                    ' Iteramos un número de veces igual al tamaño de charsPosibles (dos veces el abecedario, una en minúsculas y otra mayúsculas)

                    ' 0 Es usuario
                    If tipo = 0 Then
                        For j = 1 To charsPosibles.Length
                            If chRecibido = GetChar(charsPosibles, j) Then
                                ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                                coincidencias = coincidencias + 1
                            Else
                                ' MsgBox("No ha introducido un carácter válido.", MsgBoxStyle.Exclamation, "Error al introducir datos para el acceso.")
                            End If
                        Next j
                    ElseIf tipo = 1 Then
                        For j = 1 To charsPosiblesNombre.Length
                            If chRecibido = GetChar(charsPosiblesNombre, j) Then
                                ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                                coincidencias = coincidencias + 1
                            Else
                                ' MsgBox("No ha introducido un carácter válido.", MsgBoxStyle.Exclamation, "Error al introducir datos para el acceso.")
                            End If
                        Next j
                    ElseIf tipo = 2 Then
                        ' Con el apellido usamos el mismo rango de caracteres válidos que con el nombre.
                        For j = 1 To charsPosiblesNombre.Length
                            If chRecibido = GetChar(charsPosiblesNombre, j) Then
                                ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                                coincidencias = coincidencias + 1
                            Else
                                ' MsgBox("No ha introducido un carácter válido.", MsgBoxStyle.Exclamation, "Error al introducir datos para el acceso.")
                            End If
                        Next j
                    ElseIf tipo = 3 Then
                        For j = 1 To charsposiblesDireccion.Length
                            If chRecibido = GetChar(charsposiblesDireccion, j) Then
                                ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                                coincidencias = coincidencias + 1
                            Else
                                ' MsgBox("No ha introducido un carácter válido.", MsgBoxStyle.Exclamation, "Error al introducir datos para el acceso.")
                            End If
                        Next j
                    End If
                Next i

                ' Si el buchón tiene un valor igual al tamaño del string pasado, significa que todos los caracteres
                ' son válidos, pues fueron comparados con los caracteres del String y fueron dados por buenos.
                If coincidencias = stringRecibido.Length Then
                    valido = True
                End If
            End If

            Return valido

        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try

    End Function


    ' Método usado en la pantalla de inicio de sesión para ver que se introducen solo números en el campo de contraseña.
    Public Function validarCodigo(codigo As String, tipo As Integer) As Boolean
        ' Si se recibe 0 se está validando contraseña en inicio de sesión. (se permiten 6 dígitos)
        ' Si se recibe 1 se está validando teléfono. (se permite 9 dígitos).
        ' Si se recibe 2 se está validando precios en productos 
        ' vvv validaciones en proyecto Casa del libro:
        ' Si se recibe 3 se está validando un ID.
        ' Si recibe 4 es Stock

        ' Se opta de nuevo por la solución de poner en un String los valores permitidos.
        Dim charsPosibles As String = "0123456789"
        ' Para el campo de teléfono se permite usar el carácter especial +.
        ' Se ha quitado el carácter especial + por ahora.
        Dim charsPosiblesTelefono As String = "0123456789"
        Dim charsPosiblesPrecio As String = "0123456789."
        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        Try

            ' Clave/contraseña de inicio sesión
            If tipo = 0 Then
                valorMaximo = 6
                ' Número de teléfono
            ElseIf tipo = 1 Then
                valorMaximo = 9
                ' Precios de productos
            ElseIf tipo = 2 Then
                valorMaximo = 8
                ' ID de libro
            ElseIf tipo = 3 Then
                valorMaximo = 6
            ElseIf tipo = 4 Then
                valorMaximo = 6
            End If
            ' Solo se permiten códigos de hasta 4 números.
            ' La validación de que sean 4 se hace en otro método, porque eso depende de la creación de usuarios.
            If codigo.Length > valorMaximo Then
                MsgBox("Se ha excedido la longitud máxima", 64, "Longitud incorrecta.")

            Else
                For i = 1 To codigo.Length
                    If tipo = 0 Then
                        For j = 1 To charsPosibles.Length
                            ' Chars posibles solo 0 a 9
                            If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then

                            Else
                                ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                                ' entonces los datos se validan.
                                coincidencias = coincidencias + 1
                            End If
                        Next j
                    ElseIf tipo = 1 Then
                        ' Chars posibles para telefono
                        For j = 1 To charsPosiblesTelefono.Length
                            If (GetChar(codigo, i) <> GetChar(charsPosiblesTelefono, j)) Then

                            Else
                                ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                                ' entonces los datos se validan.
                                coincidencias = coincidencias + 1
                            End If
                        Next j
                    ElseIf tipo = 2 Then
                        For j = 1 To charsPosiblesPrecio.Length
                            ' Chars posibles para precio.
                            If (GetChar(codigo, i) <> GetChar(charsPosiblesPrecio, j)) Then

                            Else
                                ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                                ' entonces los datos se validan.
                                coincidencias = coincidencias + 1
                            End If
                        Next j
                    ElseIf tipo = 3 Then
                        For j = 1 To charsPosibles.Length
                            ' Solo usamos de 0 al 9
                            If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then

                            Else
                                ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                                ' entonces los datos se validan.
                                coincidencias = coincidencias + 1
                            End If
                        Next j
                    ElseIf tipo = 4 Then
                        For j = 1 To charsPosibles.Length
                            ' Solo usamos de 0 al 9
                            If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then

                            Else
                                ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                                ' entonces los datos se validan.
                                coincidencias = coincidencias + 1
                            End If
                        Next j
                    End If
                Next i
            End If
            ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
            If coincidencias = codigo.Length Then
                valido = True
            End If
            Return valido


        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function



    Public Function errorLogWrite() As Boolean
        Dim correcto As Boolean = False
        ' Escribir en errorLog
        Dim fichero = "Errorlog.txt"
        Try
            Dim fich As New FileStream(fichero, FileMode.Append, FileAccess.Write)
            Dim rs As New StreamWriter(fich)
            rs.WriteLine(Now & "---> " & "Error en la comprobación de datos." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number)
            rs.Close()
            fich.Close()
            correcto = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return correcto
    End Function

    Public Function mensajeErrorDatos() As String
        Dim s As String
        Try
            s = "Error en la comprobación de datos." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number
            ' MsgBox("Error en la comprobación de datos." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number)
            errorLogWrite()
            Return s

        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function

    ' Mensaje de información al usuario de que el dato intrducido no es válido
    ' se retorna un string, hace falta usar msgbox o equivalente en el programa principal para que se vea.
    Public Function mensajeInfoDatoInvalido(ByVal campo As String) As String
        Try
            ' Chr(13) sirve para salto de linea, es como <br> en html
            Dim s As String
            s = "El dato que ha introducido en el campo " & campo & " no es válido."
            ' MsgBox("Error en la comprobación de datos." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number)

            Return s

        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function


    ' Validar/Validación email
    Function validarEmail(ByVal emailAddress As String) As Boolean

        Dim regExPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, regExPattern)
        Try
            If emailAddressMatch.Success Then
                Return True
            Else
                '  mensajeInfoDatoInvalido("Correo eletrónico")
                Return False
            End If

        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function


    ' Validar/Validación DNI
    Function validarDNI(ByVal dni As String) As Boolean
        Dim regExPattern As String = "^[0-9]+[a-zA-Z]{1,2}$"
        Dim dnimatch As Match = Regex.Match(dni, regExPattern)
        Try
            If dnimatch.Success Then
                Return True
            Else
                ' mensajeInfoDatoInvalido("DNI")
                Return False
            End If

        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function


    ' Validar/Validación ISBN
    ' Matches y non matches para el primer regex pattern.
    ' matches 0672317249 | 9780672317248
    ' Non-Matches 	0-672-31724-9 | 5555555555555
    Function validarISBN(ByVal isbn As String) As Boolean
        'Dim regExPattern As String = "/(978[\--– ])?[0-9][0-9\--– ]{10}[\--– ][0-9xX])|((978)?[0-9]{9}[0-9Xx])/"
        'Dim regExPattern As String = "^(?:ISBN(?:-13)?:?●)?(?=[0-9]{13}$|(?=(?:[0-9]+[-●]){4})[-●0-9]{17}$) 97[89][-●]?[0-9]{1,5}[-●]?[0-9]+[-●]?[0-9]+[-●]?[0-9]$"
        Try
            Dim regExPattern As String = "^(97(8|9))?\d{9}(\d|X)$"
            Dim isbnMatch As Match = Regex.Match(isbn, regExPattern)
            If isbnMatch.Success Then
                Return True
            Else
                ' mensajeInfoDatoInvalido("DNI")
                Return False
            End If


        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function



End Class
