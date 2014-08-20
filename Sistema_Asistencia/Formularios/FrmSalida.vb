Imports MySql.Data.MySqlClient
Public Class FrmSalida
    'Llamo a las clases salida y conexion
    Dim objsalida As New salida
    Dim consalida As New conexion

    'desbloqueo cajas
    Sub desbloquea_form(ByVal estado As Boolean)
        cbo_tipo_doc.Enabled = estado
        cbo_tipo_salida.Enabled = estado
        cbo_usuario.Enabled = estado
        txt_n_doc.Enabled = estado
        txt_justificacion.Enabled = estado
        fec_llegada.Enabled = estado
        fec_salida.Enabled = estado
    End Sub
    'bloquear boton nuevo
    Sub bloquear_btn_nuevo()
        btn_nuevo.Enabled = False
        btn_actualiza.Enabled = False
        btn_cancela.Enabled = True
        btn_elimina.Enabled = False
        btn_guarda.Enabled = True
    End Sub
    'bloquear boton cancelar
    Sub bloquear_btn_cancela()
        btn_nuevo.Enabled = True
        btn_actualiza.Enabled = False
        btn_cancela.Enabled = False
        btn_elimina.Enabled = False
        btn_guarda.Enabled = False
    End Sub
    'funcion limpiar cajas
    Sub limpiar_form()
        txt_n_doc.Text = String.Empty
        txt_justificacion.Text = String.Empty
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquea_form(True)
        bloquear_btn_nuevo()
        limpiar_form()
    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click
        desbloquea_form(False)
        bloquear_btn_cancela()
        limpiar_form()
    End Sub

    Private Sub FrmSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bloquear_btn_cancela()
        limpiar_form()
        desbloquea_form(False)

        'Cargo el datagrid
        dg_salida.DataSource = objsalida.listasalida("")
        dg_salida.Columns("cod_salida").Visible = False
        dg_salida.Columns("tipo_documento").Visible = False
        dg_salida.Columns("n_documento").Visible = False
        dg_salida.Columns("dni").Visible = False

        'Cargo el combo
        Try
            consalida.Conectar()
            consalida.da = New MySqlDataAdapter("SELECT CONCAT(usuario.nombres,' ',usuario.paterno,' ',usuario.materno) AS nombre, usuario.dni FROM usuario ORDER BY usuario.nombres ASC", consalida.con)
            consalida.ds = New DataSet
            consalida.da.Fill(consalida.ds, "usuario")
            consalida.con.Close()
            cbo_usuario.DataSource = consalida.ds.Tables("usuario")
            cbo_usuario.DisplayMember = consalida.ds.Tables("usuario").Columns("nombre").ToString
            cbo_usuario.ValueMember = consalida.ds.Tables("usuario").Columns("dni").ToString
        Catch ex As MySqlException
            MessageBox.Show("Error al realizar consulta")
            consalida.con.Close()
        End Try

    End Sub

    Private Sub btn_guarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guarda.Click
        If objsalida.insertasalida(cbo_usuario.SelectedValue, cbo_tipo_salida.Text, cbo_tipo_doc.Text, txt_n_doc.Text, CDate(fec_salida.Value), CDate(fec_llegada.Value), UCase(txt_justificacion.Text)) Then
            MessageBox.Show("La salida fue registrada correctamente")
            bloquear_btn_cancela()
            desbloquea_form(False)
            limpiar_form()
            dg_salida.DataSource = objsalida.listasalida("")
            dg_salida.Columns("cod_salida").Visible = False
            dg_salida.Columns("tipo_documento").Visible = False
            dg_salida.Columns("n_documento").Visible = False
            dg_salida.Columns("dni").Visible = False
        Else
            MessageBox.Show("No se pudo registrar la informacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_actualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_actualiza.Click
        Dim rpt As Integer = MessageBox.Show("Desea actualizar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rpt = DialogResult.Yes Then
            objsalida.actualizasalida(cbo_usuario.SelectedValue, cbo_tipo_salida.Text, cbo_tipo_doc.Text, txt_n_doc.Text, CDate(fec_salida.Value), CDate(fec_llegada.Value), UCase(txt_justificacion.Text), txt_codigo.Text)
            MessageBox.Show("El registro fue actualizado de forma correcta")
            bloquear_btn_cancela()
            desbloquea_form(False)
            limpiar_form()
            dg_salida.DataSource = objsalida.listasalida("")
            dg_salida.Columns("cod_salida").Visible = False
            dg_salida.Columns("tipo_documento").Visible = False
            dg_salida.Columns("n_documento").Visible = False
            dg_salida.Columns("dni").Visible = False
        Else
            MessageBox.Show("No se pudo actualizar la informacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_elimina.Click
        Dim rpt As Integer = MessageBox.Show("Desea eliminar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rpt = DialogResult.Yes Then
            objsalida.eliminasalida(txt_codigo.Text)
            MessageBox.Show("El registro fue eliminado de forma correcta")
            bloquear_btn_cancela()
            desbloquea_form(False)
            limpiar_form()
            dg_salida.DataSource = objsalida.listasalida("")
            dg_salida.Columns("cod_salida").Visible = False
            dg_salida.Columns("tipo_documento").Visible = False
            dg_salida.Columns("n_documento").Visible = False
            dg_salida.Columns("dni").Visible = False
        Else
            MessageBox.Show("No se pudo eliminar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub dg_salida_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_salida.CellDoubleClick
        Try
            Me.cbo_usuario.SelectedValue = dg_salida.Rows(e.RowIndex).Cells(8).Value
            Me.cbo_tipo_salida.Text = dg_salida.Rows(e.RowIndex).Cells(2).Value
            Me.cbo_tipo_doc.Text = dg_salida.Rows(e.RowIndex).Cells(6).Value
            Me.txt_codigo.Text = dg_salida.Rows(e.RowIndex).Cells(0).Value
            Me.txt_justificacion.Text = dg_salida.Rows(e.RowIndex).Cells(5).Value
            Me.txt_n_doc.Text = dg_salida.Rows(e.RowIndex).Cells(7).Value
            Me.fec_llegada.Value = dg_salida.Rows(e.RowIndex).Cells(4).Value
            Me.fec_salida.Value = dg_salida.Rows(e.RowIndex).Cells(3).Value

            btn_cancela.Enabled = True
            btn_nuevo.Enabled = False
            btn_guarda.Enabled = False
            btn_actualiza.Enabled = True
            btn_elimina.Enabled = True
            desbloquea_form(True)
        Catch ex As Exception
            MessageBox.Show("No se pudo cargar la informacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class