Imports System.Data.OleDb
Imports System.IO
Public Class GestionConexion

    'Atributos de Conexion 
    Dim conexion As OleDbConnection
    Dim adaptador As OleDbDataAdapter
    Dim midataset, midataset2, midataset3 As DataSet
    Dim conexionUrl As String = "Provider=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=./cas_lib_db.accdb"


    ' Constructor vacío 
    ' Usos: en el inicio de sesión
    Public Sub New()

    End Sub


    'Constructor
    ' en el constructor se establce una conexion con la base de datos  le entra 3 parametros
    'url de conxion que es unico para todos formularios
    'queryAdaptador y datasetTableName son especificos por cada formulario
    Public Sub New(queryAdaptador As String, datasetTableName As String)
        Try
            conexion = New OleDbConnection(conexionUrl)
            'adaptador de la tabla Emplado
            adaptador = New OleDbDataAdapter(queryAdaptador, conexion)

            midataset = New DataSet

            adaptador.Fill(midataset, datasetTableName)
            conexion.Close()

        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Sub

    'Metodos Getters
    Public Function getAdapter() As OleDbDataAdapter
        Try
            Return adaptador

        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function


    Public Function getConxion() As OleDbConnection
        Try
            Return conexion
        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function


    Public Function getDataSet() As DataSet
        Try
            Return midataset

        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function


    'Metodo Buscar por nombre Empleado (por palabra ) 
    Public Function buscarPorCadena(cadena As String, Table As String, whColumnName As String) As Integer
        Dim pos As Integer = 0
        Dim flag, flag2, flag3 As Integer
        Try
            conexion.Open()
            Dim cmd As New OleDbCommand("SELECT * FROM " & Table & "'", conexion)


            'Aqui se crea un obj de la clase OldDBDataRereader que necsita un queriy para ejecutar la 
            Dim dr As OleDbDataReader = cmd.ExecuteReader


            'recorremos la tabla 
            While dr.Read
                If dr.Item("id") = cadena Then
                    flag2 = pos
                    flag = 1
                    Exit While
                Else
                    pos += 1


                End If
            End While

            If flag = 0 Then
                MsgBox("Busqueda fallida id no existe .  ", 64, "Gestion " & Table)
                flag2 = -1
            End If

            conexion.Close()

            Return flag2
        Catch ex As Exception

            mensajeErrorDatos()
            errorLogWrite()
        End Try
    End Function


    ' Tomas -> Metodo Buscar por nombre Empleado (por palabra ) 
    Public Function TbuscarEmpleado(nombre As String) As DataTable
        Try
            Dim midatatable As New DataTable
            midataset.Tables.Add(midatatable)
            adaptador = New OleDbDataAdapter("SELECT * FROM Empleado where nombre like '%" & nombre & "%'", conexion)
            adaptador.Fill(midatatable)

            Return midatatable

        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function


    'Metodo Buscar por caracteres   
    Public Function buscarporCaracter(cadena As String, Table As String, whColumnName As String, datasetTableName As String)
        Try
            'definir nuestra query  con el parametro que es caracter que se escribe en el textbox
            Dim comando As New OleDbCommand(("select * from " & Table & " where " & whColumnName & " LIKE '%" & cadena & "%'"), conexion)
            adaptador.SelectCommand = comando

            'se limpia y carga el dataset nuevo
            midataset.Clear()
            adaptador.Fill(midataset, datasetTableName)


        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function




    'Metodo Elminar una fila   que elimina por id 
    Public Function eliminarFila(idFila As Integer, Table As String, whColumnName As String)
        Dim result As Boolean
        Try

            'aqui se crear un objeto de la clase OleDbCommand con la query pereparada
            Dim comando As New OleDbCommand(("delete  from " & Table & " where " & whColumnName & " =@id"), conexion)
            'aqui se anade el parametro recibido el parametro 
            comando.Parameters.AddWithValue("@id", idFila)
            'aqui se abre la conexion 
            conexion.Open()
            'aqui se ejecuta la query el metodo ExecuteNonQuery devulve un entero que es numero de filas affectadas 
            Dim filas_affectas As Integer = comando.ExecuteNonQuery()

            'aqui tenemos una condicion por si numero de filas es mayor que 0 signfica que se ha eliminda una fila 
            'ponemos el var flag igual a a true si no false 
            If filas_affectas > 0 Then
                result = True
            Else
                result = False
            End If

            'se limpia y carga el dataset nuevo
            midataset.Clear()
            adaptador.Fill(midataset, "Empleados")

            'aqui se cierra la conexion con la base de datos
            conexion.Close()



        Catch ex As Exception
            ' MsgBox(ex)
            mensajeErrorDatos()
            errorLogWrite()
            'aqui por si habra una excepcion cerramos la conxion con la base de datos
            conexion.Close()
        End Try

        Return result
    End Function






    'Metodo Elminar una fila   que modificar  por id 
    Public Function modificarEmpleado(idFila As Integer, Dni As String, Nombre As String, Apellidos As String, Telefono As Integer, Table As String, whColumnName As String)
        Dim result As Boolean
        Try

            'aqui se crear un objeto de la clase OleDbCommand con la query pereparada
            Dim comando As New OleDbCommand(("update " & Table & "set dni=@dni ,nombre=@nombre,apellidos=@apellidos,telefono=@telefono Where " & whColumnName & " =@id"), conexion)
            'aqui se anade el parametro recibido el parametro 
            comando.Parameters.AddWithValue("@dni", Dni)
            comando.Parameters.AddWithValue("@nombre", Nombre)
            comando.Parameters.AddWithValue("@apellidos", Apellidos)
            comando.Parameters.AddWithValue("@telefono", Telefono)
            comando.Parameters.AddWithValue("@id", idFila)
            'aqui se abre la conexion 
            conexion.Open()
            'aqui se ejecuta la query el metodo ExecuteNonQuery devulve un entero que es numero de filas affectadas 
            Dim filas_affectas As Integer = comando.ExecuteNonQuery()

            'aqui tenemos una condicion por si numero de filas es mayor que 0 signfica que se ha eliminda una fila 
            'ponemos el var flag igual a a true si no false 
            If filas_affectas > 0 Then
                result = True
            Else
                result = False
            End If

            'se limpia y carga el dataset nuevo
            midataset.Clear()
            adaptador.Fill(midataset, "Empleados")

            'aqui se cierra la conexion con la base de datos
            conexion.Close()



        Catch ex As Exception
            MsgBox("Error de Modificacion , ha intentado introducir un valor duplicado " & Chr(13), 64, "Gestion Empleados")
            'mensajeErrorDatos()
            errorLogWrite()
            'aqui por si habra una excepcion cerramos la conxion con la base de datos
            conexion.Close()
        End Try

        Return result
    End Function









    'Metodo insert Empleado 
    Public Function insertEmpleado(id As Integer, Dni As String, Nombre As String, Apellidos As String, Telefono As Integer) As Boolean
        Dim result As Boolean
        Try


            Dim pos As Integer = 0
            Dim flag As Integer

            conexion.Open()
            'select query del empleado
            Dim cmd As New OleDbCommand("Select * from Empleados", conexion)



            'Aqui se crea un obj de la clase OldDBDataRereader que necsita un queriy para ejecutar la 
            Dim dr As OleDbDataReader = cmd.ExecuteReader


            'recorremos la tabla 
            While dr.Read
                'si id existe en la tabla no se hace nada 
                If dr.Item("id") = id Then

                    flag = 1
                    MsgBox("ID Empleado ya existe por favor introduce un nuevo id . ", 64, "Gestion Empleados")
                ElseIf dr.Item("dni") = Dni Then
                    flag = 1
                    MsgBox("DNI Empleado ya existe por favor introduce un nuevo dni . ", 64, "Gestion Empleados")

                Else
                    pos += 1


                End If
            End While


            'si no si inserta nuevo empleado 
            If flag = 0 Then

                'aqui se crea un objeto de clas  OledbCommandBuilder para perparar el commando insert
                Dim comando As New OleDbCommandBuilder(adaptador)



                'recuperamos el insert command desde adaptador
                adaptador.InsertCommand = comando.GetInsertCommand


                'aqui objeto de clase DataRowCollection  generar un hueco en dataset empleado
                Dim dataRowCollection As DataRowCollection = midataset.Tables("Empleados").Rows


                dataRowCollection.Add(id, Dni, Nombre, Apellidos, Telefono)
                adaptador.Update(midataset.Tables("Empleados"))






                result = True


            End If

            conexion.Close()




        Catch ex As Exception
            ' MsgBox(ex.Message)
            mensajeErrorDatos()
            errorLogWrite()
            result = False
            conexion.Close()
        End Try

        Return result

    End Function





    'Metodo insert Gafas 
    Public Function insertGafas(id As Integer, ISBN As String, Nombre As String, Forma As String, Color As String, Precio As Single, Stock As Integer, Imagen As Byte()) As Boolean

        Dim result As Boolean
        Try


            Dim pos As Integer = 0
            Dim flag As Integer

            conexion.Open()
            Dim cmd As New OleDbCommand("Select * from Gafas", conexion)

            'Aqui se crea un obj de la clase OldDBDataRereader que necsita un queriy para ejecutar la 
            Dim dr As OleDbDataReader = cmd.ExecuteReader


            'recorremos la tabla 
            While dr.Read
                'si id existe en la tabla no se hace nada 
                If dr.Item("id") = id Then

                    flag = 1
                    MsgBox("ID Gafas ya existe por favor introduce un nuevo id . ", 64, "Gestion Gafas")

                ElseIf dr.Item("isbn") = ISBN Then
                    flag = 2
                    MsgBox("ISBN Gafas ya existe por favor introduce un nuevo ISBN . ", 64, "Gestion Gafas")
                Else
                    pos += 1


                End If
            End While


            'si no si inserta nuevo empleado 
            If flag = 0 Then

                'aqui se crea un objeto de clas  OledbCommandBuilder para perparar el commando insert
                Dim comando As New OleDbCommandBuilder(adaptador)

                'recuperamos el insert command desde adaptador
                adaptador.InsertCommand = comando.GetInsertCommand


                'aqui objeto de clase DataRowCollection  generar un hueco en dataset empleado
                Dim dataRowCollection As DataRowCollection = midataset.Tables("Gafas").Rows


                dataRowCollection.Add(id, ISBN, Nombre, Forma, Color, Precio, Stock, Imagen)
                adaptador.Update(midataset.Tables("Gafas"))



                result = True


            End If

            conexion.Close()




        Catch ex As Exception
            ' MsgBox(ex.Message)
            mensajeErrorDatos()
            errorLogWrite()
            result = False
            conexion.Close()
        End Try

        Return result

    End Function





    'Metodo modificar Libro 
    Public Function ModificarGafas(idFila As Integer, ISBN As String, Nombre As String, Forma As String, Color As String, Precio As Single, Stock As Integer, Imagen As Byte(), Table As String, whColumnName As String) As Boolean
        Dim result As Boolean
        Try




            'aqui se crear un objeto de la clase OleDbCommand con la query pereparada
            Dim comando As New OleDbCommand(("update " & Table & "set isbn=@isbn ,nombre=@nombre,forma=@forma,color=@color,precio=@precio,stock=@stock,imagen=@imagen Where " & whColumnName & " =@id"), conexion)
            'aqui se anade el parametro recibido el parametro 
            comando.Parameters.AddWithValue("@isbn", ISBN)
            comando.Parameters.AddWithValue("@nombre", Nombre)
            comando.Parameters.AddWithValue("@forma", Forma)
            comando.Parameters.AddWithValue("@color", Color)
            comando.Parameters.AddWithValue("@precio", Precio)
            comando.Parameters.AddWithValue("@stock", Stock)
            comando.Parameters.AddWithValue("@imagen", Imagen)
            comando.Parameters.AddWithValue("@id", idFila)

            'aqui se abre la conexion 
            conexion.Open()
            'aqui se ejecuta la query el metodo ExecuteNonQuery devulve un entero que es numero de filas affectadas 
            Dim filas_affectas As Integer = comando.ExecuteNonQuery()

            'aqui tenemos una condicion por si numero de filas es mayor que 0 signfica que se ha eliminda una fila 
            'ponemos el var flag igual a a true si no false 
            If filas_affectas > 0 Then
                result = True
            Else
                result = False
            End If

            'se limpia y carga el dataset nuevo
            midataset.Clear()
            adaptador.Fill(midataset, "Gafas")



            'aqui se cierra la conexion con la base de datos
            conexion.Close()



        Catch ex As Exception

            MsgBox("Error de Modificacion , ha intentado introducir un valor duplicado " & Chr(13), 64, "Gestion Gafas")
            'mensajeErrorDatos()
            errorLogWrite()
            'aqui por si habra una excepcion cerramos la conxion con la base de datos
            conexion.Close()
        End Try

        Return result

    End Function

    'Metodo insert Cliente  
    Public Function insertClienteSocio(id As Integer, Nombre As String, Apellidos As String, Telefono As Integer, Email As String, fechaAlta As String, Socio As Boolean) As Boolean
        Dim result As Boolean
        Try


            Dim pos As Integer = 0
            Dim flag As Integer

            conexion.Open()
            Dim cmd As New OleDbCommand("Select * from ClientesSocios", conexion)

            'Aqui se crea un obj de la clase OldDBDataRereader que necsita un queriy para ejecutar la 
            Dim dr As OleDbDataReader = cmd.ExecuteReader


            'recorremos la tabla 
            While dr.Read
                'si id existe en la tabla no se hace nada 
                If dr.Item("id") = id Then

                    flag = 1
                    MsgBox("ID Cliente Socio ya existe por favor introduce un nuevo id . ", 64, "Gestion Clientes Socios")
                Else
                    pos += 1


                End If
            End While


            'si no si inserta nuevo empleado 
            If flag = 0 Then

                'aqui se crea un objeto de clas  OledbCommandBuilder para perparar el commando insert
                Dim comando As New OleDbCommandBuilder(adaptador)

                'recuperamos el insert command desde adaptador
                adaptador.InsertCommand = comando.GetInsertCommand


                'aqui objeto de clase DataRowCollection  generar un hueco en dataset empleado
                Dim dataRowCollection As DataRowCollection = midataset.Tables("ClientesSocios").Rows


                dataRowCollection.Add(id, Nombre, Apellidos, Telefono, Email, fechaAlta, Socio)
                adaptador.Update(midataset.Tables("ClientesSocios"))



                result = True


            End If

            conexion.Close()




        Catch ex As Exception
            'MsgBox(ex.Message)
            mensajeErrorDatos()
            errorLogWrite()
            result = False
            conexion.Close()
        End Try

        Return result

    End Function



    'Metodo Modificar una fila   que modificar  por id 
    Public Function modificarCliente(idFila As Integer, Nombre As String, Apellidos As String, Telefono As Integer, Email As String, fechaAlta As String, Socio As Boolean, Table As String, whColumnName As String) As Boolean
        Dim result As Boolean
        Try


            'aqui se crear un objeto de la clase OleDbCommand con la query pereparada
            Dim comando As New OleDbCommand(("update " & Table & "set nombre=@nombre ,apellidos=@apellidos,telefono=@telefono,email=@email,fechaalta=@fechaAlta,socio=@socio Where " & whColumnName & " =@id"), conexion)
            'aqui se anade el parametro recibido el parametro 

            comando.Parameters.AddWithValue("@nombre", Nombre)
            comando.Parameters.AddWithValue("@apellidos", Apellidos)
            comando.Parameters.AddWithValue("@telefono", Telefono)
            comando.Parameters.AddWithValue("@email", Email)
            comando.Parameters.AddWithValue("@fechaAlta", fechaAlta)
            comando.Parameters.AddWithValue("@socio", Socio)
            comando.Parameters.AddWithValue("@id", idFila)
            'aqui se abre la conexion 
            conexion.Open()
            'aqui se ejecuta la query el metodo ExecuteNonQuery devulve un entero que es numero de filas affectadas 
            Dim filas_affectas As Integer = comando.ExecuteNonQuery()

            'aqui tenemos una condicion por si numero de filas es mayor que 0 signfica que se ha eliminda una fila 
            'ponemos el var flag igual a a true si no false 
            If filas_affectas > 0 Then
                result = True
            Else
                result = False
            End If

            'se limpia y carga el dataset nuevo
            midataset.Clear()
            adaptador.Fill(midataset, "ClientesSocios")

            'aqui se cierra la conexion con la base de datos
            conexion.Close()



        Catch ex As Exception
            ' MsgBox(ex)
            mensajeErrorDatos()
            errorLogWrite()
            'aqui por si habra una excepcion cerramos la conxion con la base de datos
            conexion.Close()
        End Try

        Return result
    End Function





    'Metodo insert Libro 
    Public Function insertLibro(id As Integer, ISBN As String, Titulo As String, Precio As Single, Autor As String, Editorial As String, Tapa As String, Stock As Integer, Genero As String, Categoria As String, Estado As String, Idioma As String, Imagen As Byte()) As Boolean
        Dim result As Boolean
        Try


            Dim pos As Integer = 0
            Dim flag As Integer

            conexion.Open()
            Dim cmd As New OleDbCommand("Select * from Libros", conexion)

            'Aqui se crea un obj de la clase OldDBDataRereader que necsita un queriy para ejecutar la 
            Dim dr As OleDbDataReader = cmd.ExecuteReader


            'recorremos la tabla 
            While dr.Read
                'si id existe en la tabla no se hace nada 
                If dr.Item("id") = id Then

                    flag = 1
                    MsgBox("ID Libro ya existe por favor introduce un nuevo id . ", 64, "Gestion Libros")

                ElseIf dr.Item("isbn") = ISBN Then
                    flag = 2
                    MsgBox("ISBN Libro ya existe por favor introduce un nuevo ISBN . ", 64, "Gestion Libros")
                Else
                    pos += 1


                End If
            End While


            'si no si inserta nuevo empleado 
            If flag = 0 Then

                'aqui se crea un objeto de clas  OledbCommandBuilder para perparar el commando insert
                Dim comando As New OleDbCommandBuilder(adaptador)

                'recuperamos el insert command desde adaptador
                adaptador.InsertCommand = comando.GetInsertCommand


                'aqui objeto de clase DataRowCollection  generar un hueco en dataset empleado
                Dim dataRowCollection As DataRowCollection = midataset.Tables("Libros").Rows


                dataRowCollection.Add(id, ISBN, Titulo, Precio, Autor, Editorial, Tapa, Stock, Genero, Categoria, Estado, Idioma, Imagen)
                adaptador.Update(midataset.Tables("Libros"))



                result = True


            End If

            conexion.Close()




        Catch ex As Exception
            ' MsgBox(ex.Message)
            mensajeErrorDatos()
            errorLogWrite()
            result = False
            conexion.Close()
        End Try

        Return result

    End Function





    'Metodo modificar Libro 
    Public Function ModificarLibro(idFila As Integer, ISBN As String, Titulo As String, Precio As Single, Autor As String, Editorial As String, Tapa As String, Genero As String, Categoria As String, Estado As String, Idioma As String, Imagen As Byte(), Table As String, whColumnName As String) As Boolean
        Dim result As Boolean
        Try




            'aqui se crear un objeto de la clase OleDbCommand con la query pereparada
            Dim comando As New OleDbCommand(("update " & Table & "set isbn=@isbn ,titulo=@titulo,precio=@precio,autor=@autor,editorial=@editorial,tapa=@tapa,genero=@genero,categoria=@categoria,estado=@estado,idioma=@idioma,imagen=@imagen Where " & whColumnName & " =@id"), conexion)
            'aqui se anade el parametro recibido el parametro 
            comando.Parameters.AddWithValue("@isbn", ISBN)
            comando.Parameters.AddWithValue("@titulo", Titulo)
            comando.Parameters.AddWithValue("@precio", Precio)
            comando.Parameters.AddWithValue("@autor", Autor)
            comando.Parameters.AddWithValue("@editorial", Editorial)
            comando.Parameters.AddWithValue("@tapa", Tapa)
            comando.Parameters.AddWithValue("@genero", Genero)
            comando.Parameters.AddWithValue("@categoria", Categoria)
            comando.Parameters.AddWithValue("@estado", Estado)
            comando.Parameters.AddWithValue("@Idioma", Idioma)
            comando.Parameters.AddWithValue("@imagen", Imagen)
            comando.Parameters.AddWithValue("@id", idFila)

            'aqui se abre la conexion 
            conexion.Open()
            'aqui se ejecuta la query el metodo ExecuteNonQuery devulve un entero que es numero de filas affectadas 
            Dim filas_affectas As Integer = comando.ExecuteNonQuery()

            'aqui tenemos una condicion por si numero de filas es mayor que 0 signfica que se ha eliminda una fila 
            'ponemos el var flag igual a a true si no false 
            If filas_affectas > 0 Then
                result = True
            Else
                result = False
            End If

            'se limpia y carga el dataset nuevo
            midataset.Clear()
            adaptador.Fill(midataset, "Libros")



            'aqui se cierra la conexion con la base de datos
            conexion.Close()



        Catch ex As Exception

            MsgBox("Error de Modificacion , ha intentado introducir un valor duplicado " & Chr(13), 64, "Gestion Libros")
            'mensajeErrorDatos()
            errorLogWrite()
            'aqui por si habra una excepcion cerramos la conxion con la base de datos
            conexion.Close()
        End Try

        Return result

    End Function



    'Metodo modificarStock modfica el stock de la tabla libros por id 
    Public Function modificarStock(idFila As Integer, Stock As Integer, Table As String, whColumnName As String) As Boolean
        Dim result As Boolean
        Try

            'aqui se crear un objeto de la clase OleDbCommand con la query pereparada
            Dim comando As New OleDbCommand(("update " & Table & "set stock=@stock Where " & whColumnName & " =@id"), conexion)
            'aqui se anade el parametro recibido el parametro 
            comando.Parameters.AddWithValue("@stock", Stock)
            comando.Parameters.AddWithValue("@id", idFila)
            'aqui se abre la conexion 
            conexion.Open()
            'aqui se ejecuta la query el metodo ExecuteNonQuery devulve un entero que es numero de filas affectadas 
            Dim filas_affectas As Integer = comando.ExecuteNonQuery()

            'aqui tenemos una condicion por si numero de filas es mayor que 0 signfica que se ha eliminda una fila 
            'ponemos el var flag igual a a true si no false 
            If filas_affectas > 0 Then
                result = True
            Else
                result = False
            End If

            'se limpia y carga el dataset nuevo
            midataset.Clear()
            adaptador.Fill(midataset, "Libros")

            'aqui se cierra la conexion con la base de datos
            conexion.Close()



        Catch ex As Exception
            ' MsgBox(ex)
            mensajeErrorDatos()
            errorLogWrite()
            'aqui por si habra una excepcion cerramos la conxion con la base de datos
            conexion.Close()
        End Try

        Return result
    End Function






    'Metodo insert Usuario  
    Public Function insertUsuario(id As Integer, Usuario As String, Clave As Integer, Rol As String, fkEmpleado As Integer) As Boolean
        Dim result As Boolean
        Try


            Dim pos As Integer = 0
            Dim flag As Integer

            conexion.Open()
            Dim cmd As New OleDbCommand("Select * from Usuarios", conexion)

            'Aqui se crea un obj de la clase OldDBDataRereader que necsita un queriy para ejecutar la 
            Dim dr As OleDbDataReader = cmd.ExecuteReader


            'recorremos la tabla 
            While dr.Read
                'si id existe en la tabla no se hace nada 
                If dr.Item("Usuario") = Usuario Then
                    'comprobacion si usuario existe en la tabla usuario
                    flag = 1
                    MsgBox(" Usuario ya existe por favor introduce un nuevo usuario . ", 64, "Gestion Usuarios")

                    'comprobacion si id existe en la tabla usuario
                ElseIf dr.Item("id") = id Then
                    flag = 2
                    MsgBox(" id ya existe por favor introduce un nuevo id . ", 64, "Gestion Usuarios")

                    'comprobacion si usario esta relacionado con empleado 
                ElseIf dr.Item("fk_empleado") = fkEmpleado Then
                    flag = 3
                    MsgBox(" Empleado ya tiene un usuario por favor seleccione un nuevo empleado . ", 64, "Gestion Usuarios")
                Else
                    pos += 1


                End If
            End While


            'si no si inserta nuevo usuario 
            If flag = 0 Then

                'aqui se crea un objeto de clas  OledbCommandBuilder para perparar el commando insert
                Dim comando As New OleDbCommandBuilder(adaptador)

                'recuperamos el insert command desde adaptador
                adaptador.InsertCommand = comando.GetInsertCommand


                'aqui objeto de clase DataRowCollection  generar un hueco en dataset empleado
                Dim dataRowCollection As DataRowCollection = midataset.Tables("Usuarios").Rows


                dataRowCollection.Add(id, Usuario, Clave, Rol, fkEmpleado)
                adaptador.Update(midataset.Tables("Usuarios"))



                result = True


            End If

            conexion.Close()




        Catch ex As Exception
            MsgBox(ex.Message)
            result = False
            conexion.Close()
        End Try

        Return result

    End Function










    'Metodo modificarUsuario modfica el stock de la tabla libros por id 
    Public Function modificarUsuario(getIdFila As Integer, Usuario As String, Clave As Integer, Rol As String, fkEmpleado As Integer, Table As String, whColumnName As String) As Boolean
        Dim result As Boolean
        Try


            Dim pos As Integer = 0
            Dim flag As Integer = 0

            conexion.Open()
            Dim cmd As New OleDbCommand("Select * from Usuarios", conexion)

            'Aqui se crea un obj de la clase OldDBDataRereader que necsita un queriy para ejecutar la 
            Dim dr As OleDbDataReader = cmd.ExecuteReader


            'recorremos la tabla 
            While dr.Read
                'si id existe en la tabla no se hace nada 
                If dr.Item("Usuario") <> Usuario  Then 'And dr.Item("fk_empleado") <> fkEmpleado Then

                    flag = 0
                    'MsgBox(" Usuario ya existe por favor usa un nuevo usuario . ", 64, "Gestion Usuarios")
                    'MsgBox(" Este Empleado ya tiene un Usuario por favor Elige un nuevo Empleado . ", 64, "Gestion Usuarios")

                Else
                    pos += 1


                End If
            End While

            'si no si modifica nuevo usuario 
            If flag = 0 Then
                ' MsgBox("update")
                'aqui se crear un objeto de la clase OleDbCommand con la query pereparada
                Dim comando As New OleDbCommand(("update " & Table & "set usuario=@usuario,clave=@clave,rol=@rol,fk_empleado=@fkEmpleado Where " & whColumnName & " =@id"), conexion)
                'aqui se anade el parametro recibido el parametro 
                comando.Parameters.AddWithValue("@usuario", Usuario)
                comando.Parameters.AddWithValue("@clave", Clave)
                comando.Parameters.AddWithValue("@rol", Rol)
                comando.Parameters.AddWithValue("@fkEmpleado", fkEmpleado)
                comando.Parameters.AddWithValue("@id", getIdFila)

                'aqui se ejecuta la query el metodo ExecuteNonQuery devulve un entero que es numero de filas affectadas 
                Dim filas_affectas As Integer = comando.ExecuteNonQuery()

                'aqui tenemos una condicion por si numero de filas es mayor que 0 signfica que se ha eliminda una fila 
                'ponemos el var flag igual a a true si no false 
                If filas_affectas > 0 Then
                    result = True
                Else
                    result = False
                End If

                ' MsgBox(result)
                'se limpia y carga el dataset nuevo
                midataset.Clear()
                adaptador.Fill(midataset, "Usuarios")




            End If



            'aqui se cierra la conexion con la base de datos
            conexion.Close()






        Catch ex As Exception
            MsgBox("Error de Modificacion , ha intentado introducir un valor duplicado " & Chr(13), 64, "Gestion Usuarios")
            ' mensajeErrorDatos()
            errorLogWrite()
            'aqui por si habra una excepcion cerramos la conxion con la base de datos
            conexion.Close()
        End Try

        Return result
    End Function




    'Metodo getEmpleados que sirver para rellenar id de los empleados en formulario Gestion Usuaios
    Public Function getEmpleados(queryAdaptador As String, datasetTableName As String) As DataSet
        Try
            conexion = New OleDbConnection(conexionUrl)
            'adaptador de la tabla Emplado
            Dim adaptador2 As New OleDbDataAdapter(queryAdaptador, conexion)

            midataset2 = New DataSet

            adaptador2.Fill(midataset2, datasetTableName)
            conexion.Close()
            Return midataset2

        Catch ex As Exception

            mensajeErrorDatos()
            errorLogWrite()
        End Try
    End Function





    'Metodo getEmpleados que sirver para rellenar id de los empleados en formulario Gestion Usuaios
    Public Function getProductos(queryAdaptador As String, datasetTableName As String) As DataSet
        Try
            conexion = New OleDbConnection(conexionUrl)
            'adaptador de la tabla Emplado
            Dim adaptador2 As New OleDbDataAdapter(queryAdaptador, conexion)

            midataset2 = New DataSet

            adaptador2.Fill(midataset2, datasetTableName)
            conexion.Close()
            Return midataset2

        Catch ex As Exception

            mensajeErrorDatos()
            errorLogWrite()
        End Try
    End Function

    'metodo para obtener los datos  de la relacion entre empleados y usuarios
    Public Function getRelacionEmpUsr(queryAdaptadoRelacion As String, datasetTableRelacionName As String, queryAdaptadorEmp As String, queryAdaptadorUsr As String, datasetTableNameEmp As String, datasetTableNameUsr As String) As DataSet
        Try
            'aqui se crea una conexion con la base de datos 
            conexion = New OleDbConnection(conexionUrl)
            'preparar los adpaters 
            Dim adaptadorEmp As New OleDbDataAdapter(queryAdaptadorEmp, conexion)
            Dim adaptadorUsr As New OleDbDataAdapter(queryAdaptadorUsr, conexion)
            Dim adaptadorRelaciones As New OleDbDataAdapter(queryAdaptadoRelacion, conexion)

            midataset3 = New DataSet
            'cargar data set con los 3 tablas
            adaptadorEmp.Fill(midataset3, datasetTableNameEmp)
            adaptadorUsr.Fill(midataset3, datasetTableNameUsr)
            adaptadorRelaciones.Fill(midataset3, datasetTableRelacionName)

            Return midataset3


        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try

    End Function



    'Metodo Buscar por caracteres   
    Public Function buscarStock(cadena As String, Table As String, whColumnName As String, datasetTableName As String)
        Try
            'definir nuestra query  con el parametro que es caracter que se escribe en el textbox
            Dim comando As New OleDbCommand(("select id,isbn,titulo,stock from " & Table & " where " & whColumnName & " LIKE '%" & cadena & "%'"), conexion)
            adaptador.SelectCommand = comando

            'se limpia y carga el dataset nuevo
            midataset.Clear()
            adaptador.Fill(midataset, datasetTableName)

            ' cmd = New OleDbCommand("SELECT " & campo & " FROM " & tabla & " where " & cond1 & " = '" & cond2 & "' and " & cond3 & " = " & Integer.Parse(cond4), conexion)
        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function


    Public Function selectTabla(campo As String, tabla As String)
        Try
            Dim midatatable As New DataTable
            midataset.Tables.Add(midatatable)
            adaptador = New OleDbDataAdapter("SELECT " & campo & " FROM " & tabla, conexion)
            adaptador.Fill(midatatable)

            Return midatatable

        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function

    Public Function selectWhere(campo As String, tabla As String, cond1 As String, cond2 As String) As DataTable
        Try
            Dim midatatable As New DataTable
            midataset.Tables.Add(midatatable)
            adaptador = New OleDbDataAdapter("SELECT " & campo & " FROM " & tabla & " where usuario = " & cond1 & " = '" & cond2 & "'", conexion)
            adaptador.Fill(midatatable)

            Return midatatable

        Catch ex As Exception

            mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function



    Public Function selectDosWhere(campo As String, tabla As String, cond1 As String, cond2 As String, cond3 As String, cond4 As String) As Boolean
        Dim m As Integer = 0


        Dim correcto As Boolean = False
        Dim numero As Integer
        Dim cmd As OleDbCommand
        Try
            conexion.Open()
            If Integer.TryParse(cond4, numero) Then
                cmd = New OleDbCommand("SELECT " & campo & " FROM " & tabla & " where " & cond1 & " = '" & cond2 & "' and " & cond3 & " = " & Integer.Parse(cond4), conexion)
            Else
                cmd = New OleDbCommand("SELECT " & campo & " FROM " & tabla & " where " & cond1 & " = '" & cond2 & "' and " & cond3 & " = '" & cond4 & "'", conexion)
            End If

            ' la idea es:
            ' Select * From Usuarios Where usuario = 'admin' and clave = 123456

            ' midataset.Tables.Add(midatatable)
            ' adaptador = New OleDbDataAdapter("SELECT " & campo & " FROM " & tabla & " where " & cond1 & " = '" & cond2 & "' and " & cond3 & " = '" & cond4 & "'", conexion)
            'adaptador.Fill(midatatable)

            Dim dr As OleDbDataReader = cmd.ExecuteReader
            While dr.Read 'And m = 0
                If dr.Item(cond1) = cond2 Then
                    correcto = True
                    m = 1
                Else

                End If

            End While

            If m = 0 Then
                MsgBox("El usuario no existe, por favo asegúrese de haber introducido datos correctos.", 64, "Inicio de sesión")
            End If
            conexion.Close()

        Catch ex As Exception
            conexion.Close()
            mensajeErrorDatos()
            errorLogWrite()
        End Try


        Return correcto
    End Function



    Public Function getRol(cond1 As String, cond2 As String, cond3 As String, cond4 As String) As Integer
        Dim m As Integer = 0

        Dim valorColumna As String
        Dim numero As Integer
        Dim cmd As OleDbCommand
        ' Depende el rol se usa un integer u otro
        ' 1 es Amin
        ' 2 es Usuario
        ' 3 es Guest
        Dim queRol As Integer
        Try
            conexion.Open()
            cmd = New OleDbCommand("SELECT * from usuarios where " & cond1 & " = '" & cond2 & "' and " & cond3 & " = " & Integer.Parse(cond4), conexion)


            ' la idea es:
            ' Select * From Usuarios Where usuario = 'admin' and clave = 123456

            ' midataset.Tables.Add(midatatable)
            ' adaptador = New OleDbDataAdapter("SELECT " & campo & " FROM " & tabla & " where " & cond1 & " = '" & cond2 & "' and " & cond3 & " = '" & cond4 & "'", conexion)
            'adaptador.Fill(midatatable)

            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read And m = 0
                If dr.Item("rol") = "Administrador" Then

                    queRol = 1

                    m = 1
                ElseIf dr.Item("rol").Equals("Usuario") Then

                    queRol = 2

                    m = 1
                ElseIf dr.Item("rol").Equals("Guest") Then
                    ' Se entra como guest
                    queRol = 3
                    m = 1
                End If

            End While

            If m = 0 Then
                MsgBox("El usuario no existe, por favo asegúrese de haber introducido datos correctos.", 64, "Inicio de sesión")
            End If
            conexion.Close()


            Return queRol

        Catch ex As Exception
            conexion.Close()
        mensajeErrorDatos()
        errorLogWrite()
        End Try
    End Function




    ' Método traido de libValidacionDatos
    ' Escribe un archivo en el debug con los errores. (Fecha, info. del error, etc.)
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




    ' Método traido de libValidacionDatos
    ' Métodos sobrecargados: uno sin recibir parámetros, otro recibe un string, y otro recibe string y objeto exception.
    ' Retorna un string para mostrar en un msgbox o donde sea.
    Public Function mensajeErrorDatos() As String
        Dim s As String
        s = "Error en la comprobación de datos." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number
        MsgBox("Error en la comprobación de datos." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number)
        errorLogWrite()
        Return s
    End Function


    ' Falta completar
    Public Function mensajeErrorDatos(mensaje As String) As String
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

    ' Método traido de libValidacionDatos
    ' Retorna un string para mostrar en un msgbox o donde sea.
    Public Function mensajeErrorDatos(mensaje As String, ex As Exception) As String
        Dim s As String
        s = "Error en la comprobación de datos." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number
        ' MsgBox("Error en la comprobación de datos." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number)
        errorLogWrite()
        Return s
    End Function
End Class
