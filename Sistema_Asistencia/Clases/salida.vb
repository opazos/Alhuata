Imports MySql.Data.MySqlClient
Public Class salida

    Private Objcon As New conexion
    '1.- Funcion para guardar datos
    Public Function insertasalida(ByVal dni As String, ByVal tipo As String, ByVal tipo_doc As String, ByVal n_doc As String, ByVal f_inicio As Date, ByVal f_termino As Date, ByVal refer As String) As Boolean
        Dim inserto_salida As Boolean = False
        Try
            Objcon.Conectar()
            Objcon.CrearComando("INSERT INTO salida VALUES (null, ?dni, ?tipo, ?tipo_doc, ?n_doc, ?f_inicio, ?f_termino, ?refer)")
            Objcon.AsignarParametro("?dni", MySqlDbType.String, dni)
            Objcon.AsignarParametro("?tipo", MySqlDbType.String, tipo)
            Objcon.AsignarParametro("?tipo_doc", MySqlDbType.String, tipo_doc)
            Objcon.AsignarParametro("?n_doc", MySqlDbType.String, n_doc)
            Objcon.AsignarParametro("?f_inicio", MySqlDbType.Date, f_inicio)
            Objcon.AsignarParametro("?f_termino", MySqlDbType.Date, f_termino)
            Objcon.AsignarParametro("?refer", MySqlDbType.String, refer)
            If Objcon.EjecutarConsulta > 0 Then
                inserto_salida = True
            Else
                insertasalida = False
            End If
            Objcon.Desconectar()
        Catch ex As Exception
            inserto_salida = False
        End Try
        Return inserto_salida
    End Function

    '2.- Funcion para actualizar datos
    Public Function actualizasalida(ByVal dni As String, ByVal tipo As String, ByVal tipo_doc As String, ByVal n_doc As String, ByVal f_inicio As Date, ByVal f_termino As Date, ByVal refer As String, ByVal codigo As Integer)
        Dim actualizo_salida As Boolean = False
        Try
            Objcon.Conectar()
            Objcon.CrearComando("UPDATE salida SET dni=?dni, tipo_salida=?tipo, tipo_documento=?tipo_doc, n_documento=?n_doc, f_inicio=?f_inicio, f_termino=?f_termino, referencia=?refer WHERE cod_salida=?codigo")
            Objcon.AsignarParametro("?dni", MySqlDbType.String, dni)
            Objcon.AsignarParametro("?tipo", MySqlDbType.String, tipo)
            Objcon.AsignarParametro("?tipo_doc", MySqlDbType.String, tipo_doc)
            Objcon.AsignarParametro("?n_doc", MySqlDbType.String, n_doc)
            Objcon.AsignarParametro("?f_inicio", MySqlDbType.Date, f_inicio)
            Objcon.AsignarParametro("?f_termino", MySqlDbType.Date, f_termino)
            Objcon.AsignarParametro("?refer", MySqlDbType.String, refer)
            Objcon.AsignarParametro("?codigo", MySqlDbType.Int32, codigo)
            If Objcon.EjecutarConsulta > 0 Then
                actualizo_salida = True
            Else
                actualizo_salida = False
            End If
            Objcon.Desconectar()
        Catch ex As Exception
            actualizo_salida = False
        End Try
        Return actualizo_salida
    End Function
    '3.- Funcion para eliminar datos
    Public Function eliminasalida(ByVal codigo As Integer)
        Dim elimino_salida As Boolean = False
        Try
            Objcon.Conectar()
            Objcon.CrearComando("DELETE FROM salida WHERE cod_salida=?codigo")
            Objcon.AsignarParametro("?codigo", MySqlDbType.Int32, codigo)
            If Objcon.EjecutarConsulta > 0 Then
                elimino_salida = True
            Else
                elimino_salida = False
            End If
            Objcon.Desconectar()
        Catch ex As Exception
            elimino_salida = False
        End Try
        Return elimino_salida
    End Function
    '4.- Listo salidas
    Public Function listasalida(ByVal dato As String) As DataTable
        Dim tabla_salida As New DataTable
        Try
            Objcon.ds = New DataSet
            Objcon.Conectar()
            Objcon.da = New MySqlDataAdapter("SELECT salida.cod_salida, CONCAT(usuario.nombres,' ',usuario.paterno,' ',usuario.materno) AS 'Nombres y apellidos', salida.tipo_salida AS Tipo, salida.f_inicio AS Inicio, salida.f_termino AS Termino, salida.referencia AS Justificacion, salida.tipo_documento, salida.n_documento, salida.dni FROM usuario INNER JOIN salida ON usuario.dni = salida.dni WHERE salida.f_inicio=DATE(NOW())", Objcon.con)
            Objcon.da.SelectCommand.CommandType = CommandType.Text
            Objcon.da.Fill(tabla_salida)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la consulta")
        End Try
        Return tabla_salida
    End Function

End Class
