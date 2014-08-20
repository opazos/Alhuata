'Importamos la referencia a Mysql.net
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class conexion
    Public con As MySqlConnection
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public ds As DataSet
    Public cb As MySqlCommandBuilder
    Public odatarow As DataRow
    Public iposfilaactual As Integer

    'Con esta clase nos conectamos a la base de datos
    Public Sub Conectar()
        con = New MySqlConnection("server=www.sierrasur.gob.pe; user=psierras_oscar; password=sierrasur2; database=psierras_asistencia")
        'con = New MySqlConnection("server=localhost; user=root; password=root; database=bd_asistencia")
        con.Open()
    End Sub

    'Con esta clase nos desconectamos de la base de datos
    Public Sub Desconectar()
        con.Close()
    End Sub

    'Con esta clase ejecutamos las consultas
    Public Sub CrearComando(ByVal consulta As String)
        cmd = New MySqlCommand(consulta, con)
    End Sub

    'Con esta clase asignamos los parametros de los campos de la tabla
    Public Sub AsignarParametro(ByVal param As String, ByVal tipo As MySqlDbType, ByVal valor As Object)
        cmd.Parameters.Add(param, tipo).Value = valor
    End Sub

    'Con esta funcion corremos la consulta
    Public Function EjecutarConsulta() As Integer
        Dim numReg As Integer
        numReg = cmd.ExecuteNonQuery()
        Return numReg
    End Function

    Public Function EjecutaReader() As MySqlDataReader
        Return cmd.ExecuteReader
    End Function

    Public Function EjecutarDataTable() As DataTable
        dt = New DataTable
        da = New MySqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

End Class
