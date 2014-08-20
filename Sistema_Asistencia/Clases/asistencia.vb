Imports MySql.Data.MySqlClient
Public Class asistencia
    Private Objcon As New conexion
    '1.- funcion para agregar datos
    Public Function insertarasistencia(ByVal dni As String, ByVal fecha As Date, ByVal hora As String, ByVal tipo As String, ByVal turno As String, ByVal puntal As Integer, ByVal just As String) As Boolean
        Dim inserto_asistencia As Boolean = False
        Try
            Objcon.Conectar()
            Objcon.CrearComando("INSERT INTO asistencia VALUES (null, ?dni, ?fecha, ?hora, ?tipo, ?turno, ?puntal, ?just)")
            Objcon.AsignarParametro("?dni", MySqlDbType.String, dni)
            Objcon.AsignarParametro("?fecha", MySqlDbType.Date, fecha)
            Objcon.AsignarParametro("?hora", MySqlDbType.String, hora)
            Objcon.AsignarParametro("?tipo", MySqlDbType.String, tipo)
            Objcon.AsignarParametro("?turno", MySqlDbType.String, turno)
            Objcon.AsignarParametro("?puntal", MySqlDbType.Int32, puntal)
            Objcon.AsignarParametro("?just", MySqlDbType.String, just)
            If Objcon.EjecutarConsulta > 0 Then
                inserto_asistencia = True
            Else
                inserto_asistencia = False
            End If
            Objcon.Desconectar()
        Catch ex As Exception
            inserto_asistencia = False
        End Try
        Return inserto_asistencia
    End Function

    '2.- Funcion para buscar datos
    Public Function listausuario(ByVal datos As String) As DataTable
        Dim tabla_asistencia As New DataTable
        Try
            Objcon.ds = New DataSet
            Objcon.Conectar()
            Objcon.da = New MySqlDataAdapter("SELECT CONCAT(usuario.nombres,' ',usuario.paterno,' ',usuario.materno) AS `Nombres y apellidos`,asistencia.fecha AS Fecha,asistencia.hora AS Hora,asistencia.tipo AS Tipo,asistencia.turno AS Turno,sedes.nombre AS Oficina FROM usuario INNER JOIN asistencia ON usuario.dni = asistencia.dni INNER JOIN sedes ON sedes.cod_oficina = usuario.cod_oficina WHERE asistencia.fecha =DATE(NOW())  ORDER BY usuario.cod_oficina ASC, Hora ASC", Objcon.con)
            Objcon.da.SelectCommand.CommandType = CommandType.Text
            Objcon.da.Fill(tabla_asistencia)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la consulta")
        End Try
        Return tabla_asistencia
    End Function

    '3.- Busco los datos de los horarios
    Public Sub lista_horario(ByVal ing_man As TextBox, ByVal sal_man As TextBox, ByVal ing_tar As TextBox, ByVal sal_tar As TextBox, ByVal min_em As TextBox, ByVal max_em As TextBox, ByVal min_sm As TextBox, ByVal max_sm As TextBox, ByVal min_et As TextBox, ByVal max_et As TextBox, ByVal min_st As TextBox, ByVal max_st As TextBox)
        Try
            Objcon.ds = New DataSet
            Objcon.Conectar()
            Objcon.da = New MySqlDataAdapter("SELECT horario.entrada_pri, horario.salida_pri,horario.entrada_tarde,horario.salida_tarde,horario.min_entrada_pri,horario.max_entrada_pri,horario.min_salida_pri,horario.max_salida_pri,horario.min_entrada_tarde,horario.max_entrada_tarde,horario.min_salida_tarde,horario.max_salida_tarde FROM sedes INNER JOIN horario ON sedes.cod_horario = horario.cod_horario WHERE sedes.cod_oficina<>001", Objcon.con)
            'Objcon.da = New MySqlDataAdapter("SELECT horario.entrada_pri, horario.salida_pri,horario.entrada_tarde,horario.salida_tarde,horario.min_entrada_pri,horario.max_entrada_pri,horario.min_salida_pri,horario.max_salida_pri,horario.min_entrada_tarde,horario.max_entrada_tarde,horario.min_salida_tarde,horario.max_salida_tarde FROM sedes INNER JOIN horario ON sedes.cod_horario = horario.cod_horario WHERE sedes.cod_oficina=001", Objcon.con)
            Objcon.da.Fill(Objcon.ds, "horario")
            Cargar(ing_man, sal_man, ing_tar, sal_tar, min_em, max_em, min_sm, max_sm, min_et, max_et, min_st, max_st)
            Objcon.Desconectar()
        Catch ex As MySqlException
            MessageBox.Show("Error al realizar la consulta" & ex.Message)
        End Try
    End Sub
    '4.- Los cargo
    Public Sub Cargar(ByVal ing_man As TextBox, ByVal sal_man As TextBox, ByVal ing_tar As TextBox, ByVal sal_tar As TextBox, ByVal min_em As TextBox, ByVal max_em As TextBox, ByVal min_sm As TextBox, ByVal max_sm As TextBox, ByVal min_et As TextBox, ByVal max_et As TextBox, ByVal min_st As TextBox, ByVal max_st As TextBox)
        If Objcon.ds.Tables("horario").Rows.Count > 0 Then
            Objcon.odatarow = Objcon.ds.Tables("horario").Rows(Objcon.iposfilaactual)
            ing_man.Text = Objcon.odatarow("entrada_pri")
            sal_man.Text = Objcon.odatarow("salida_pri")
            ing_tar.Text = Objcon.odatarow("entrada_tarde")
            sal_tar.Text = Objcon.odatarow("salida_tarde")
            min_em.Text = Objcon.odatarow("min_entrada_pri")
            max_em.Text = Objcon.odatarow("max_entrada_pri")
            min_sm.Text = Objcon.odatarow("min_salida_pri")
            max_sm.Text = Objcon.odatarow("max_salida_pri")
            min_et.Text = Objcon.odatarow("min_entrada_tarde")
            max_et.Text = Objcon.odatarow("max_entrada_tarde")
            min_st.Text = Objcon.odatarow("min_salida_tarde")
            max_st.Text = Objcon.odatarow("max_salida_tarde")
        End If
    End Sub
   

End Class
