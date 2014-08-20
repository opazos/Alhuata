Imports MySql.Data.MySqlClient
Public Class horario
    Private Objcon As New conexion
    '1.- Funcion para guardar los datos
    Public Function insertahorario(ByVal entr_pri As String, ByVal sal_pri As String, ByVal entr_seg As String, ByVal sal_seg As String, ByVal min_em As String, ByVal max_em As String, ByVal min_sm As String, ByVal max_sm As String, ByVal min_et As String, ByVal max_et As String, ByVal min_st As String, ByVal max_st As String) As Boolean
        Dim inserto_horario As Boolean = False
        Try
            Objcon.Conectar()
            Objcon.CrearComando("INSERT INTO horario VALUES (null,?entr_pri, ?sal_pri, ?entr_seg, ?sal_seg, ?min_em, ?max_em, ?min_sm, ?max_sm, ?min_et, ?max_et, ?min_st, ?max_st)")
            Objcon.AsignarParametro("?entr_pri", MySqlDbType.String, entr_pri)
            Objcon.AsignarParametro("?sal_pri", MySqlDbType.String, sal_pri)
            Objcon.AsignarParametro("?entr_seg", MySqlDbType.String, entr_seg)
            Objcon.AsignarParametro("?sal_seg", MySqlDbType.String, sal_seg)
            Objcon.AsignarParametro("?min_em", MySqlDbType.String, min_em)
            Objcon.AsignarParametro("?max_em", MySqlDbType.String, max_em)
            Objcon.AsignarParametro("?min_sm", MySqlDbType.String, min_sm)
            Objcon.AsignarParametro("?max_sm", MySqlDbType.String, max_sm)
            Objcon.AsignarParametro("?min_et", MySqlDbType.String, min_et)
            Objcon.AsignarParametro("?max_et", MySqlDbType.String, max_et)
            Objcon.AsignarParametro("?min_st", MySqlDbType.String, min_st)
            Objcon.AsignarParametro("?max_st", MySqlDbType.String, max_st)
            If Objcon.EjecutarConsulta() > 0 Then
                inserto_horario = True
            Else
                inserto_horario = False
            End If
            Objcon.Desconectar()

        Catch ex As MySqlException
            inserto_horario = False
        End Try
        Return inserto_horario
    End Function

    '2.- Funcion para actualizar los datos
    Public Function actualizahorario(ByVal entr_pri As String, ByVal sal_pri As String, ByVal entr_seg As String, ByVal sal_seg As String, ByVal min_em As String, ByVal max_em As String, ByVal min_sm As String, ByVal max_sm As String, ByVal min_et As String, ByVal max_et As String, ByVal min_st As String, ByVal max_st As String, ByVal cod_horario As Integer)
        Dim actualizo_horario As Boolean = False
        Try
            Objcon.Conectar()
            Objcon.CrearComando("UPDATE horario SET entrada_pri=?entr_pri, salida_pri=?sal_pri, entrada_tarde=?entr_seg, salida_tarde=?sal_seg, min_entrada_pri=?min_em, max_entrada_pri=?max_em, min_salida_pri=?min_sm, max_salida_pri=?max_sm, min_entrada_tarde=?min_et, max_entrada_tarde=?max_et, min_salida_tarde=?min_st, max_salida_tarde= ?max_st WHERE cod_horario=?cod_horario")
            Objcon.AsignarParametro("?entr_pri", MySqlDbType.String, entr_pri)
            Objcon.AsignarParametro("?sal_pri", MySqlDbType.String, sal_pri)
            Objcon.AsignarParametro("?entr_seg", MySqlDbType.String, entr_seg)
            Objcon.AsignarParametro("?sal_seg", MySqlDbType.String, sal_seg)
            Objcon.AsignarParametro("?min_em", MySqlDbType.String, min_em)
            Objcon.AsignarParametro("?max_em", MySqlDbType.String, max_em)
            Objcon.AsignarParametro("?min_sm", MySqlDbType.String, min_sm)
            Objcon.AsignarParametro("?max_sm", MySqlDbType.String, max_sm)
            Objcon.AsignarParametro("?min_et", MySqlDbType.String, min_et)
            Objcon.AsignarParametro("?max_et", MySqlDbType.String, max_et)
            Objcon.AsignarParametro("?min_st", MySqlDbType.String, min_st)
            Objcon.AsignarParametro("?max_st", MySqlDbType.String, max_st)
            Objcon.AsignarParametro("?cod_horario", MySqlDbType.Int32, cod_horario)
            If Objcon.EjecutarConsulta() > 0 Then
                actualizo_horario = True
            Else
                actualizo_horario = False
            End If
            Objcon.Desconectar()
        Catch ex As MySqlException
            actualizo_horario = False
        End Try
        Return actualizo_horario
    End Function
    '3.- Función para eliminar datos
    Public Function eliminarhorario(ByVal cod_horario As Integer)
        Dim elimino_horario As Boolean = False
        Try
            Objcon.Conectar()
            Objcon.CrearComando("DELETE FROM horario WHERE cod_horario=?cod_horario")
            Objcon.AsignarParametro("?cod_horario", MySqlDbType.Int32, cod_horario)
            If Objcon.EjecutarConsulta() > 0 Then
                elimino_horario = True
            Else
                elimino_horario = False
            End If
            Objcon.Desconectar()
        Catch ex As MySqlException
            elimino_horario = False
        End Try
        Return elimino_horario
    End Function

    '4.- Funcion para listar los datos
    Public Function listahorario(ByVal dato As String) As DataTable
        Dim tabla_horario As New DataTable
        Try
            Objcon.ds = New DataSet
            Objcon.Conectar()
            Objcon.da = New MySqlDataAdapter("SELECT horario.cod_horario AS Cod, horario.entrada_pri AS `Entrada Temprano`, horario.salida_pri AS `Salida Temprano`, horario.entrada_tarde AS `Entrada Tarde`, horario.salida_tarde AS `Salida Tarde`, horario.min_entrada_pri, horario.max_entrada_pri, horario.min_salida_pri, horario.max_salida_pri, horario.min_entrada_tarde, horario.max_entrada_tarde, horario.min_salida_tarde, horario.max_salida_tarde FROM horario", Objcon.con)
            Objcon.da.SelectCommand.CommandType = CommandType.Text
            Objcon.da.Fill(tabla_horario)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error en la consulta")
        End Try
        Return tabla_horario
    End Function

End Class
