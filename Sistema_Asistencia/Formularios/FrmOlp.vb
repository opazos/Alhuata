Imports MySql.Data.MySqlClient
Public Class FrmOlp
    'Llamo a las clases olp y conexion
    Dim objsede As New sede
    Dim consede As New conexion

    'Desbloqueamos cajas
    Sub desbloquear_sede(ByVal estado As Boolean)
        txt_codigo.Enabled = estado
        txt_nombre.Enabled = estado
        cbo_horario.Enabled = estado
    End Sub
    'Boton nuevo
    Sub bloquear_btn_nuevo()
        btn_nuevo.Enabled = False
        btn_cancela.Enabled = True
        btn_edita.Enabled = False
        btn_elimina.Enabled = False
        btn_guarda.Enabled = True
    End Sub
    'Boton cancela
    Sub bloquear_btn_cancela()
        btn_nuevo.Enabled = True
        btn_edita.Enabled = False
        btn_cancela.Enabled = False
        btn_elimina.Enabled = False
        btn_guarda.Enabled = False
    End Sub
    'Limpiar cajas
    Sub limpiar_form_sede()
        txt_codigo.Text = String.Empty
        txt_nombre.Text = String.Empty
        txt_codigo.Focus()
    End Sub
    'Valido campos
    Sub valida_form_sede()
        If txt_codigo.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_codigo.Focus()
        ElseIf txt_nombre.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_nombre.Focus()
        End If
    End Sub
    'Salgo del formulario
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FrmOlp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bloquear_btn_cancela()
        limpiar_form_sede()
        desbloquear_sede(False)
        'Cargo el datagrid
        dgsede.DataSource = objsede.listasede("")
        dgsede.Columns("cod_oficina").Visible = False
        dgsede.Columns("Cod").Visible = False

        'Cargo info del combobox
        Try
            consede.Conectar()
            consede.da = New MySqlDataAdapter("SELECT horario.cod_horario,CONCAT('Entrada :',horario.entrada_pri,' a.m. - Salida :',horario.salida_tarde,' p.m.') AS horario FROM horario", consede.con)
            consede.ds = New DataSet
            consede.da.Fill(consede.ds, "horario")
            consede.con.Close()

            cbo_horario.DataSource = consede.ds.Tables("horario")
            cbo_horario.DisplayMember = consede.ds.Tables("horario").Columns("horario").ToString
            cbo_horario.ValueMember = consede.ds.Tables("horario").Columns("cod_horario").ToString
        Catch ex As MySqlException
            MessageBox.Show("Error al realizar consulta", ex.Message)
            consede.con.Close()
        End Try

    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        bloquear_btn_nuevo()
        desbloquear_sede(True)
        limpiar_form_sede()
    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click
        bloquear_btn_cancela()
        desbloquear_sede(False)
        limpiar_form_sede()
    End Sub

    Private Sub btn_guarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guarda.Click
        valida_form_sede()
        If objsede.insertasede(txt_codigo.Text, UCase(txt_nombre.Text), cbo_horario.SelectedValue) Then
            MessageBox.Show("La oficina local fue registrada correctamente")
            bloquear_btn_cancela()
            desbloquear_sede(False)
            limpiar_form_sede()
            dgsede.DataSource = objsede.listasede("")
            dgsede.Columns("cod_oficina").Visible = False
            dgsede.Columns("Cod").Visible = False
        Else
            MessageBox.Show("No se pudo guardar la información", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_edita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edita.Click
        valida_form_sede()
        Dim rpt As Integer = MessageBox.Show("Desea actualizar el registro", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rpt = DialogResult.Yes Then
            objsede.actualizasede(txt_nombre.Text, cbo_horario.SelectedValue, txt_codigo.Text)
            MessageBox.Show("Los datos han sido actualizados correctamente")
            bloquear_btn_cancela()
            desbloquear_sede(False)
            limpiar_form_sede()
            dgsede.DataSource = objsede.listasede("")
            dgsede.Columns("cod_oficina").Visible = False
            dgsede.Columns("Cod").Visible = False
        Else
            MessageBox.Show("No se pudo guardar la información", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_elimina.Click
        Dim rpt As Integer = MessageBox.Show("Desea eliminar el registro", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If rpt = DialogResult.Yes Then
            objsede.eliminasede(txt_codigo.Text)
            MessageBox.Show("El registro fue eliminado de forma correcta")
            bloquear_btn_cancela()
            desbloquear_sede(False)
            limpiar_form_sede()
            dgsede.DataSource = objsede.listasede("")
            dgsede.Columns("cod_oficina").Visible = False
            dgsede.Columns("Cod").Visible = False
        Else
            MessageBox.Show("No se pudo eliminar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgsede_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgsede.CellDoubleClick
        Try
            Me.txt_codigo.Text = dgsede.Rows(e.RowIndex).Cells(0).Value
            Me.txt_nombre.Text = dgsede.Rows(e.RowIndex).Cells(1).Value
            Me.cbo_horario.SelectedValue = dgsede.Rows(e.RowIndex).Cells(3).Value

            btn_cancela.Enabled = True
            btn_elimina.Enabled = True
            btn_guarda.Enabled = False
            btn_nuevo.Enabled = False
            btn_edita.Enabled = True
            desbloquear_sede(True)
        Catch ex As Exception
            MessageBox.Show("No se pudo cargar la información", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class