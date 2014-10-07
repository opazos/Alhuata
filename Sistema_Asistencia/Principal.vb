Imports MySql.Data.MySqlClient
Public Class Principal
    'Llamo a las clases asistencia y conexion
    Dim objasiste As New asistencia
    Dim conasiste As New conexion
    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Valido y bloqueo
        Timer2.Interval = 1000
        Timer2.Start()
        '1.- Cargo el horario
        objasiste.lista_horario(txt_e_m, txt_s_m, txt_e_t, txt_s_t, txt_min_em, txt_max_em, txt_min_sm, txt_max_sm, txt_min_et, txt_max_et, txt_min_st, txt_max_st)
        '2.- Cargo la fecha y hora actuales
        fec_ingreso.Value = DateTime.Now
        '3.- Cargo la Oficina Local
        txt_oficina.Text = "001"
        '4.- Cargo el datagrid
        dg_asistencia.DataSource = objasiste.listausuario("")
        '5.- Cargo el combo
        Try
            conasiste.Conectar()
            conasiste.da = New MySqlDataAdapter("SELECT CONCAT(usuario.nombres,' ',usuario.paterno,' ',usuario.materno) AS nombre, usuario.dni FROM usuario ORDER BY usuario.nombres ASC", conasiste.con)
            conasiste.ds = New DataSet
            conasiste.da.Fill(conasiste.ds, "usuario")
            conasiste.con.Close()

            cbo_usuario.DataSource = conasiste.ds.Tables("usuario")
            cbo_usuario.DisplayMember = conasiste.ds.Tables("usuario").Columns("nombre").ToString
            cbo_usuario.ValueMember = conasiste.ds.Tables("usuario").Columns("dni").ToString
        Catch ex As Exception
            MessageBox.Show("Error al realizar la consulta")
            conasiste.con.Close()
        End Try
    End Sub

    Sub valida_hora_formulario()

        'Defino las horas
        Dim hora, entrada, salida, entrada_max, salida_max, mediodia As Date
        hora = Format(Now, "Short Time")
        entrada = Format((TimeValue(txt_e_m.Text)), "Short Time")
        entrada_max = Format((TimeValue(txt_max_em.Text)), "Short Time")
        salida = Format((TimeValue(txt_s_t.Text)), "Short Time")
        salida_max = Format((TimeValue(txt_max_st.Text)), "Short Time")
        mediodia = Format((TimeValue("13:00:00 p.m.")), "Short Time")


        If hora >= entrada And hora <= entrada_max Then
            GroupBox2.Text = "REGISTRAR ASISTENCIA - INGRESO"
            bloqueo_asistencia(True)
            bloqueo_justificacion(False)
            txt_puntualidad.Text = 1
            txt_tipo.Text = "INGRESO"
            txt_turno.Text = "MAÑANA"
        ElseIf hora > entrada_max And hora < mediodia Then
            GroupBox2.Text = "REGISTRAR ASISTENCIA - INGRESO - TARDANZA"
            bloqueo_asistencia(True)
            bloqueo_justificacion(True)
            txt_puntualidad.Text = 0
            txt_tipo.Text = "INGRESO"
            txt_turno.Text = "MAÑANA"
        ElseIf hora > mediodia And hora < salida Then
            GroupBox2.Text = "REGISTRAR ASISTENCIA - SALIDA - ANTICIPADA"
            bloqueo_asistencia(True)
            bloqueo_justificacion(True)
            txt_puntualidad.Text = 0
            txt_tipo.Text = "SALIDA"
            txt_turno.Text = "TARDE"
        ElseIf hora >= salida And hora <= salida_max Then
            GroupBox2.Text = "REGISTRAR ASISTENCIA - SALIDA"
            bloqueo_asistencia(True)
            bloqueo_justificacion(False)
            txt_puntualidad.Text = 0
            txt_tipo.Text = "SALIDA"
            txt_turno.Text = "TARDE"
        Else
            GroupBox2.Text = "REGISTRAR ASISTENCIA - SISTEMA BLOQUEADO"
            bloqueo_asistencia(False)
            bloqueo_justificacion(False)
            txt_puntualidad.Text = 0
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToLongTimeString
        txt_hora.Text = Date.Now.ToShortTimeString
        fec_ingreso.Text = Format(Now, "short Date")
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        valida_hora_formulario()
        Timer2.Start()
    End Sub
    'Bloqueo asistencia
    Sub bloqueo_asistencia(ByVal estado As Boolean)
        cbo_usuario.Enabled = estado
        btn_asistencia.Enabled = estado
    End Sub
    Sub bloqueo_justificacion(ByVal estado As Boolean)
        txt_justificacion.Enabled = estado
    End Sub
    'Limpio formulario
    Sub limpiar_form()
        txt_justificacion.Text = String.Empty
        cbo_usuario.Text = String.Empty
    End Sub
    Private Sub btn_asistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_asistencia.Click
        btn_asistencia.Enabled = False
        If txt_justificacion.Enabled = True And txt_justificacion.Text = "" Then
            MessageBox.Show("Usted esta ingresando con retraso. Por favor ingrese una justificación.")
        Else
            If objasiste.insertarasistencia(cbo_usuario.SelectedValue, CDate(fec_ingreso.Value), txt_hora.Text, txt_tipo.Text, txt_turno.Text, txt_puntualidad.Text, UCase(txt_justificacion.Text)) Then
                MessageBox.Show("Asistencia registrada")
                dg_asistencia.DataSource = objasiste.listausuario("")
                limpiar_form()
                btn_asistencia.Enabled = True
            Else
                MessageBox.Show("Error al registrar asistencia", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub SalirDelSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub DefinirHoraDeEntradaYSalidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefinirHoraDeEntradaYSalidaToolStripMenuItem.Click
        FrmHorario.Show()
    End Sub

    Private Sub ModuloOficinasLocalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuloOficinasLocalesToolStripMenuItem.Click
        FrmOlp.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        FrmUsuario.Show()
    End Sub
    Private Sub SalirDelSistemaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirDelSistemaToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub RegistrarSalidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarSalidaToolStripMenuItem.Click
        FrmSalida.Show()
    End Sub
    Private Sub ReportesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesToolStripMenuItem.Click
        'Process.Start("http://www.sierrasur.gob.pe/alhuata/")
        Process.Start("http://localhost/asistencia/")
    End Sub
End Class
