Imports MySql.Data.MySqlClient
Public Class usuario
    Private Objcon As New conexion
    '1.- Clase para guardar datos
    Public Function insertausuario(ByVal dni As String, ByVal nombre As String, ByVal paterno As String, ByVal materno As String, ByVal clave As String, ByVal tipo As Integer, ByVal f_nac As Date, ByVal dir As String, ByVal cod_sede As String) As Boolean
        Dim inserto_usuario As Boolean = False
        Try
            Objcon.Conectar()
            Objcon.CrearComando("INSERT INTO usuario VALUES (?dni, ?nombre, ?paterno, ?materno, ?clave, ?tipo, ?f_nac, ?dir, ?cod_sede)")
            Objcon.AsignarParametro("?dni", MySqlDbType.String, dni)
            Objcon.AsignarParametro("?nombre", MySqlDbType.String, nombre)
            Objcon.AsignarParametro("?paterno", MySqlDbType.String, paterno)
            Objcon.AsignarParametro("?materno", MySqlDbType.String, materno)
            Objcon.AsignarParametro("?clave", MySqlDbType.String, clave)
            Objcon.AsignarParametro("?tipo", MySqlDbType.Int32, tipo)
            Objcon.AsignarParametro("?f_nac", MySqlDbType.Date, f_nac)
            Objcon.AsignarParametro("?dir", MySqlDbType.String, dir)
            Objcon.AsignarParametro("?cod_sede", MySqlDbType.String, cod_sede)
            If Objcon.EjecutarConsulta() > 0 Then
                inserto_usuario = True
            Else
                inserto_usuario = False
            End If
            Objcon.Desconectar()
        Catch ex As Exception
            inserto_usuario = False
        End Try
        Return inserto_usuario
    End Function
    '2.- Clase para actualizar datos
    Public Function actualizausuario(ByVal nombre As String, ByVal paterno As String, ByVal materno As String, ByVal clave As String, ByVal tipo As Integer, ByVal f_nac As Date, ByVal dir As String, ByVal cod_sede As String, ByVal dni As String)
        Dim actualizo_usuario As Boolean = False
        Try
            Objcon.Conectar()
            Objcon.CrearComando("UPDATE usuario SET nombres=?nombre, paterno=?paterno, materno=?materno, clave=?clave, cod_tipo_usuario=?tipo, f_nacimiento=?f_nac, direccion=?dir, cod_oficina=?cod_sede WHERE dni=?dni")
            Objcon.AsignarParametro("?dni", MySqlDbType.String, dni)
            Objcon.AsignarParametro("?nombre", MySqlDbType.String, nombre)
            Objcon.AsignarParametro("?paterno", MySqlDbType.String, paterno)
            Objcon.AsignarParametro("?materno", MySqlDbType.String, materno)
            Objcon.AsignarParametro("?clave", MySqlDbType.String, clave)
            Objcon.AsignarParametro("?tipo", MySqlDbType.Int32, tipo)
            Objcon.AsignarParametro("?f_nac", MySqlDbType.Date, f_nac)
            Objcon.AsignarParametro("?dir", MySqlDbType.String, dir)
            Objcon.AsignarParametro("?cod_sede", MySqlDbType.String, cod_sede)
            If Objcon.EjecutarConsulta() > 0 Then
                actualizo_usuario = True
            Else
                actualizo_usuario = False
            End If
            Objcon.Desconectar()
        Catch ex As Exception
            actualizo_usuario = False
        End Try
        Return actualizo_usuario
    End Function
    '3.- Clase para eliminar datos
    Public Function eliminarusuario(ByVal dni As String)
        Dim elimino_usuario As Boolean = False
        Try
            Objcon.Conectar()
            Objcon.CrearComando("DELETE FROM usuario WHERE dni =?dni")
            Objcon.AsignarParametro("?dni", MySqlDbType.String, dni)
            If Objcon.EjecutarConsulta() > 0 Then
                elimino_usuario = True
            Else
                eliminarusuario = False
            End If
            Objcon.Desconectar()
        Catch ex As Exception
            elimino_usuario = False
        End Try
        Return elimino_usuario
    End Function
    '4.- Clase para listar usuarios
    Public Function listausuario(ByVal dato As String) As DataTable
        Dim tabla_usuario As New DataTable
        Try
            Objcon.ds = New DataSet
            Objcon.Conectar()
            Objcon.da = New MySqlDataAdapter("SELECT usuario.dni AS DNI, usuario.nombres AS Nombres,usuario.paterno AS `Ape. Paterno`, usuario.materno AS `Ape. Materno`, usuario.f_nacimiento AS `F.Nac`,tipo_usuario.descripcion AS Tipo,sedes.nombre AS Oficina,usuario.clave,usuario.cod_tipo_usuario, usuario.direccion, usuario.cod_oficina FROM tipo_usuario INNER JOIN usuario ON tipo_usuario.cod_tipo_usuario = usuario.cod_tipo_usuario INNER JOIN sedes ON sedes.cod_oficina = usuario.cod_oficina ORDER BY usuario.nombres ASC", Objcon.con)
            Objcon.da.SelectCommand.CommandType = CommandType.Text
            Objcon.da.Fill(tabla_usuario)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error en la consulta")
        End Try
        Return tabla_usuario
    End Function


End Class
