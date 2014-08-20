Imports MySql.Data.MySqlClient
Public Class sede
    Private Objcon As New conexion
    '1.- Clase para guardar datos
    Public Function insertasede(ByVal cod_sede As String, ByVal sede As String, ByVal horario As Integer) As Boolean
        Dim inserto_sede As Boolean = False
        Try
            Objcon.Conectar()
            Objcon.CrearComando("INSERT INTO sedes VALUES (?cod_sede, ?sede, ?horario)")
            Objcon.AsignarParametro("?cod_sede", MySqlDbType.String, cod_sede)
            Objcon.AsignarParametro("?sede", MySqlDbType.String, sede)
            Objcon.AsignarParametro("?horario", MySqlDbType.Int32, horario)
            If Objcon.EjecutarConsulta() > 0 Then
                inserto_sede = True
            Else
                inserto_sede = False
            End If
            Objcon.Desconectar()
        Catch ex As Exception
            inserto_sede = False
        End Try
        Return inserto_sede
    End Function

    '2.- Clase para actualizar datos
    Public Function actualizasede(ByVal sede As String, ByVal horario As Integer, ByVal cod_sede As String)
        Dim actualizo_sede As Boolean = False
        Try
            Objcon.Conectar()
            Objcon.CrearComando("UPDATE sedes SET nombre=?sede, cod_horario=?horario WHERE cod_oficina=?cod_sede")
            Objcon.AsignarParametro("?sede", MySqlDbType.String, sede)
            Objcon.AsignarParametro("?horario", MySqlDbType.Int32, horario)
            Objcon.AsignarParametro("?cod_sede", MySqlDbType.String, cod_sede)
            If Objcon.EjecutarConsulta() > 0 Then
                actualizo_sede = True
            Else
                actualizo_sede = False
            End If
            Objcon.Desconectar()
        Catch ex As Exception
            actualizo_sede = False
        End Try
        Return actualizo_sede
    End Function

    '3.- Clase para eliminar datos
    Public Function eliminasede(ByVal cod_sede As String)
        Dim elimino_sede As Boolean = False
        Try
            Objcon.Conectar()
            Objcon.CrearComando("DELETE FROM sedes WHERE cod_oficina=?cod_sede")
            Objcon.AsignarParametro("?cod_sede", MySqlDbType.String, cod_sede)
            If Objcon.EjecutarConsulta() > 0 Then
                elimino_sede = True
            Else
                elimino_sede = False
            End If
            Objcon.Desconectar()
        Catch ex As Exception
            elimino_sede = False
        End Try
        Return elimino_sede
    End Function

    '4.- Clase para listar datos
    Public Function listasede(ByVal datos As String) As DataTable
        Dim tabla_sede As New DataTable
        Try
            Objcon.ds = New DataSet
            Objcon.Conectar()
            Objcon.da = New MySqlDataAdapter("SELECT sedes.cod_oficina, sedes.nombre AS `Oficina Local`, CONCAT('Entrada: ',horario.entrada_pri,' - Salida: ',horario.salida_tarde) AS Horario,sedes.cod_horario AS Cod FROM horario INNER JOIN sedes ON horario.cod_horario = sedes.cod_horario", Objcon.con)
            Objcon.da.SelectCommand.CommandType = CommandType.Text
            Objcon.da.Fill(tabla_sede)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error en la consulta")
        End Try
        Return tabla_sede
    End Function
End Class
