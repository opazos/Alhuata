Imports MySql.Data.MySqlClient
Public Class FrmUsuario
    'Llamo a las clases usuario y conexion
    Dim objusuario As New usuario
    Dim conusuario As New conexion

    'desbloqueo cajas
    Sub desbloquear_form_usuario(ByVal estado As Boolean)
        txt_nombre.Enabled = estado
        txt_paterno.Enabled = estado
        txt_materno.Enabled = estado
        txt_clave.Enabled = estado
        txt_direccion.Enabled = estado
        f_nac.Enabled = estado
        cbo_oficina.Enabled = estado
        cbo_tipo_usuario.Enabled = estado
    End Sub

    'bloqueo btn_nuevo
    Sub bloquear_btn_nuevo()
        btn_nuevo.Enabled = False
        btn_cancela.Enabled = True
        btn_edita.Enabled = False
        btn_elimina.Enabled = False
        btn_guarda.Enabled = True
    End Sub

    'bloqueo btn_cancelar
    Sub bloquear_btn_cancela()
        btn_nuevo.Enabled = True
        btn_cancela.Enabled = False
        btn_edita.Enabled = False
        btn_elimina.Enabled = False
        btn_guarda.Enabled = False
    End Sub

    'Limpiar cajas
    Sub limpia_form()
        txt_dni.Text = String.Empty
        txt_nombre.Text = String.Empty
        txt_paterno.Text = String.Empty
        txt_materno.Text = String.Empty
        txt_clave.Text = String.Empty
        txt_direccion.Text = String.Empty
        txt_dni.Focus()
    End Sub

    'Valido formulario
    Sub valida_form()
        If txt_dni.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_dni.Focus()
        ElseIf txt_nombre.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_nombre.Focus()
        ElseIf txt_paterno.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_paterno.Focus()
        ElseIf txt_materno.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_materno.Focus()
        ElseIf txt_clave.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_clave.Focus()
        ElseIf txt_direccion.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_direccion.Focus()
        End If
    End Sub

    'Salgo del formulario
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FrmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bloquear_btn_cancela()
        limpia_form()
        desbloquear_form_usuario(False)
        txt_dni.Enabled = False


        'cargo el datagrid
        dgusuario.DataSource = objusuario.listausuario("")
        dgusuario.Columns("clave").Visible = False
        dgusuario.Columns("cod_tipo_usuario").Visible = False
        dgusuario.Columns("direccion").Visible = False
        dgusuario.Columns("cod_oficina").Visible = False


        'Cargo info del combobox sede
        Try
            conusuario.Conectar()
            conusuario.da = New MySqlDataAdapter("SELECT sedes.cod_oficina, sedes.nombre FROM sedes", conusuario.con)
            conusuario.ds = New DataSet
            conusuario.da.Fill(conusuario.ds, "sede")
            conusuario.con.Close()
            cbo_oficina.DataSource = conusuario.ds.Tables("sede")
            cbo_oficina.DisplayMember = conusuario.ds.Tables("sede").Columns("nombre").ToString
            cbo_oficina.ValueMember = conusuario.ds.Tables("sede").Columns("cod_oficina").ToString
        Catch ex As MySqlException
            MessageBox.Show("Error al realizar consulta")
            conusuario.con.Close()
        End Try

        'Cargo info del combobox tipousuario
        Try
            conusuario.Conectar()
            conusuario.da = New MySqlDataAdapter("SELECT tipo_usuario.cod_tipo_usuario, tipo_usuario.descripcion FROM tipo_usuario", conusuario.con)
            conusuario.ds = New DataSet
            conusuario.da.Fill(conusuario.ds, "tipo")
            conusuario.con.Close()
            cbo_tipo_usuario.DataSource = conusuario.ds.Tables("tipo")
            cbo_tipo_usuario.DisplayMember = conusuario.ds.Tables("tipo").Columns("descripcion").ToString
            cbo_tipo_usuario.ValueMember = conusuario.ds.Tables("tipo").Columns("cod_tipo_usuario").ToString
        Catch ex As MySqlException
            MessageBox.Show("Error al realizar consulta")
            conusuario.con.Close()
        End Try

    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        bloquear_btn_nuevo()
        desbloquear_form_usuario(True)
        txt_dni.Enabled = True
        limpia_form()
    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click
        bloquear_btn_cancela()
        desbloquear_form_usuario(False)
        txt_dni.Enabled = False
        limpia_form()
    End Sub

    Private Sub btn_guarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guarda.Click
        valida_form()
        If objusuario.insertausuario(txt_dni.Text, UCase(txt_nombre.Text), UCase(txt_paterno.Text), UCase(txt_materno.Text), txt_clave.Text, cbo_tipo_usuario.SelectedValue, CDate(f_nac.Value), UCase(txt_direccion.Text), cbo_oficina.SelectedValue) Then
            MessageBox.Show("Registro ingresado correctamente")
            bloquear_btn_cancela()
            desbloquear_form_usuario(False)
            txt_dni.Enabled = False
            limpia_form()
            dgusuario.DataSource = objusuario.listausuario("")
            dgusuario.Columns("clave").Visible = False
            dgusuario.Columns("cod_tipo_usuario").Visible = False
            dgusuario.Columns("direccion").Visible = False
            dgusuario.Columns("cod_oficina").Visible = False
        Else
            MessageBox.Show("No se pudo insertar la información", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_edita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edita.Click
        valida_form()
        Dim rpt As Integer = MessageBox.Show("Desea actualizar la información?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rpt = DialogResult.Yes Then
            objusuario.actualizausuario(UCase(txt_nombre.Text), UCase(txt_paterno.Text), UCase(txt_materno.Text), txt_clave.Text, cbo_tipo_usuario.SelectedValue, CDate(f_nac.Value), UCase(txt_direccion.Text), cbo_oficina.SelectedValue, txt_dni.Text)
            MessageBox.Show("Registro actualizado correctamente")
            bloquear_btn_cancela()
            desbloquear_form_usuario(False)
            txt_dni.Enabled = False
            limpia_form()
            dgusuario.DataSource = objusuario.listausuario("")
            dgusuario.Columns("clave").Visible = False
            dgusuario.Columns("cod_tipo_usuario").Visible = False
            dgusuario.Columns("direccion").Visible = False
            dgusuario.Columns("cod_oficina").Visible = False
        Else
            MessageBox.Show("No se pudo actualizar la información", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_elimina.Click
        Dim rpt As Integer = MessageBox.Show("Desea eliminar la información?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rpt = DialogResult.Yes Then
            objusuario.eliminarusuario(txt_dni.Text)
            MessageBox.Show("Registro eliminado correctamente")
            bloquear_btn_cancela()
            desbloquear_form_usuario(False)
            txt_dni.Enabled = False
            limpia_form()
            dgusuario.DataSource = objusuario.listausuario("")
            dgusuario.Columns("clave").Visible = False
            dgusuario.Columns("cod_tipo_usuario").Visible = False
            dgusuario.Columns("direccion").Visible = False
            dgusuario.Columns("cod_oficina").Visible = False
        Else
            MessageBox.Show("No se pudo eliminar la información", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgusuario_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgusuario.CellDoubleClick
        Try
            Me.txt_dni.Text = dgusuario.Rows(e.RowIndex).Cells(0).Value
            Me.txt_nombre.Text = dgusuario.Rows(e.RowIndex).Cells(1).Value
            Me.txt_paterno.Text = dgusuario.Rows(e.RowIndex).Cells(2).Value
            Me.txt_materno.Text = dgusuario.Rows(e.RowIndex).Cells(3).Value
            Me.txt_clave.Text = dgusuario.Rows(e.RowIndex).Cells(7).Value
            Me.txt_direccion.Text = dgusuario.Rows(e.RowIndex).Cells(9).Value
            Me.f_nac.Value = dgusuario.Rows(e.RowIndex).Cells(4).Value
            Me.cbo_oficina.SelectedValue = dgusuario.Rows(e.RowIndex).Cells(10).Value
            Me.cbo_tipo_usuario.SelectedValue = dgusuario.Rows(e.RowIndex).Cells(8).Value

            btn_cancela.Enabled = True
            btn_nuevo.Enabled = False
            btn_guarda.Enabled = False
            btn_edita.Enabled = True
            btn_elimina.Enabled = True

            desbloquear_form_usuario(True)
            txt_dni.Enabled = False
        Catch ex As Exception
            MessageBox.Show("No se pudo cargar la informacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class