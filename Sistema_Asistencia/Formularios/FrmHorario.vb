Imports MySql.Data.MySqlClient
Public Class FrmHorario
    'Llamo a las clases horario y conexion
    Dim objhorario As New horario
    Dim conhorario As New conexion

    'Funcion para desbloquear cajas
    Sub desbloquear_form_horario(ByVal estado As Boolean)
        txt_entrada_prim.Enabled = estado
        txt_salida_prim.Enabled = estado
        txt_entrada_seg.Enabled = estado
        txt_salida_seg.Enabled = estado
        txt_min_em.Enabled = estado
        txt_max_em.Enabled = estado
        txt_min_et.Enabled = estado
        txt_max_et.Enabled = estado
        txt_min_sm.Enabled = estado
        txt_max_sm.Enabled = estado
        txt_min_st.Enabled = estado
        txt_max_st.Enabled = estado

    End Sub
    'Funcion para botones cuando doy click en nuevo
    Sub bloquear_btn_nuevo()
        btn_nuevo.Enabled = False
        btn_guarda.Enabled = True
        btn_cancela.Enabled = True
        btn_elimina.Enabled = False
        btn_update.Enabled = False
    End Sub
    'Funcion para botones cuando doy click en cancelar
    Sub bloquear_btn_cancela()
        btn_nuevo.Enabled = True
        btn_guarda.Enabled = False
        btn_cancela.Enabled = False
        btn_elimina.Enabled = False
        btn_update.Enabled = False
    End Sub
    'Funcion para limpiar cajas
    Sub limpiar_form_horario()
        txt_cod_horario.Text = String.Empty
        txt_entrada_prim.Text = String.Empty
        txt_entrada_seg.Text = String.Empty
        txt_salida_prim.Text = String.Empty
        txt_salida_seg.Text = String.Empty

        txt_min_em.Text = String.Empty
        txt_min_et.Text = String.Empty
        txt_min_sm.Text = String.Empty
        txt_min_st.Text = String.Empty
        txt_max_em.Text = String.Empty
        txt_max_et.Text = String.Empty
        txt_max_sm.Text = String.Empty
        txt_max_st.Text = String.Empty

        txt_entrada_prim.Focus()
    End Sub
    'Funcion para Validar cajas de texto
    Sub valida_form_horario()
        If txt_entrada_prim.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_entrada_prim.Focus()
        ElseIf txt_salida_prim.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_salida_prim.Focus()
        ElseIf txt_entrada_seg.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_entrada_seg.Focus()
        ElseIf txt_salida_seg.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_salida_seg.Focus()

        ElseIf txt_min_em.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_min_em.Focus()
        ElseIf txt_min_et.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_min_et.Focus()
        ElseIf txt_min_sm.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_min_sm.Focus()
        ElseIf txt_min_st.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_min_st.Focus()
        ElseIf txt_max_em.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_max_em.Focus()
        ElseIf txt_max_et.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_max_et.Focus()
        ElseIf txt_max_sm.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_max_sm.Focus()
        ElseIf txt_max_st.Text = "" Then
            MessageBox.Show("Ingrese un valor de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_max_st.Focus()
        End If
    End Sub
    'Funcion para formatear cajas de texto
    Sub format_form_horario()
        txt_entrada_prim.Text = Format(txt_entrada_prim.Text, "hh:mm tt")
        txt_entrada_seg.Text = Format(txt_entrada_seg.Text, "hh:mm tt")
        txt_salida_prim.Text = Format(txt_salida_prim.Text, "hh:mm tt")
        txt_salida_seg.Text = Format(txt_salida_seg.Text, "hh:mm tt")

        txt_min_em.Text = Format(txt_min_em.Text, "hh:mm tt")
        txt_min_et.Text = Format(txt_min_et.Text, "hh:mm tt")
        txt_min_sm.Text = Format(txt_min_sm.Text, "hh:mm tt")
        txt_min_st.Text = Format(txt_min_st.Text, "hh:mm tt")

        txt_max_em.Text = Format(txt_max_em.Text, "hh:mm tt")
        txt_max_et.Text = Format(txt_max_et.Text, "hh:mm tt")
        txt_max_sm.Text = Format(txt_max_sm.Text, "hh:mm tt")
        txt_max_st.Text = Format(txt_max_st.Text, "hh:mm tt")

    End Sub

    'Funcion para salir del formulario
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FrmHorario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bloquear_btn_cancela()
        limpiar_form_horario()
        desbloquear_form_horario(False)
        'Cargo el DataGrid
        dg_horario.DataSource = objhorario.listahorario("")
        dg_horario.Columns("Cod").Visible = False
        dg_horario.Columns("min_entrada_pri").Visible = False
        dg_horario.Columns("max_entrada_pri").Visible = False
        dg_horario.Columns("min_salida_pri").Visible = False
        dg_horario.Columns("max_salida_pri").Visible = False
        dg_horario.Columns("min_entrada_tarde").Visible = False
        dg_horario.Columns("max_entrada_tarde").Visible = False
        dg_horario.Columns("min_salida_tarde").Visible = False
        dg_horario.Columns("max_salida_tarde").Visible = False


    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        bloquear_btn_nuevo()
        desbloquear_form_horario(True)
        limpiar_form_horario()
        format_form_horario()
    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click
        bloquear_btn_cancela()
        desbloquear_form_horario(False)
        limpiar_form_horario()
    End Sub
    'Añadir registros
    Private Sub btn_guarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guarda.Click
        valida_form_horario()
        If objhorario.insertahorario(txt_entrada_prim.Text, txt_salida_prim.Text, txt_entrada_seg.Text, txt_salida_seg.Text, txt_min_em.Text, txt_max_em.Text, txt_min_sm.Text, txt_max_sm.Text, txt_min_et.Text, txt_max_et.Text, txt_min_st.Text, txt_max_st.Text) Then
            MessageBox.Show("El horario fue registrado de forma correcta")
            bloquear_btn_cancela()
            desbloquear_form_horario(False)
            limpiar_form_horario()
            dg_horario.DataSource = objhorario.listahorario("")
            dg_horario.Columns("Cod").Visible = False
            dg_horario.Columns("min_entrada_pri").Visible = False
            dg_horario.Columns("max_entrada_pri").Visible = False
            dg_horario.Columns("min_salida_pri").Visible = False
            dg_horario.Columns("max_salida_pri").Visible = False
            dg_horario.Columns("min_entrada_tarde").Visible = False
            dg_horario.Columns("max_entrada_tarde").Visible = False
            dg_horario.Columns("min_salida_tarde").Visible = False
            dg_horario.Columns("max_salida_tarde").Visible = False

        Else
            MessageBox.Show("No se pudo guardar la informacion", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub
    'Actualizar registros
    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        valida_form_horario()
        Dim rpt As Integer = MessageBox.Show("Desea actualizar el registro", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rpt = DialogResult.Yes Then
            objhorario.actualizahorario(txt_entrada_prim.Text, txt_salida_prim.Text, txt_entrada_seg.Text, txt_salida_seg.Text, txt_min_em.Text, txt_max_em.Text, txt_min_sm.Text, txt_max_sm.Text, txt_min_et.Text, txt_max_et.Text, txt_min_st.Text, txt_max_st.Text, txt_cod_horario.Text)
            MessageBox.Show("El horario fue actualizado correctamente")
            bloquear_btn_cancela()
            desbloquear_form_horario(False)
            limpiar_form_horario()
            dg_horario.DataSource = objhorario.listahorario("")
            dg_horario.Columns("Cod").Visible = False
            dg_horario.Columns("min_entrada_pri").Visible = False
            dg_horario.Columns("max_entrada_pri").Visible = False
            dg_horario.Columns("min_salida_pri").Visible = False
            dg_horario.Columns("max_salida_pri").Visible = False
            dg_horario.Columns("min_entrada_tarde").Visible = False
            dg_horario.Columns("max_entrada_tarde").Visible = False
            dg_horario.Columns("min_salida_tarde").Visible = False
            dg_horario.Columns("max_salida_tarde").Visible = False
        Else
            MessageBox.Show("No se pudo guardar la informacion", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub
    'Eliminar registros
    Private Sub btn_elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_elimina.Click
        Dim rpt As Integer = MessageBox.Show("Desea eliminar el registro?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        If rpt = DialogResult.Yes Then
            objhorario.eliminarhorario(txt_cod_horario.Text)
            MessageBox.Show("El horario fue eliminado de forma correcta")
            bloquear_btn_cancela()
            desbloquear_form_horario(False)
            limpiar_form_horario()
            dg_horario.DataSource = objhorario.listahorario("")
            dg_horario.Columns("Cod").Visible = False
            dg_horario.Columns("min_entrada_pri").Visible = False
            dg_horario.Columns("max_entrada_pri").Visible = False
            dg_horario.Columns("min_salida_pri").Visible = False
            dg_horario.Columns("max_salida_pri").Visible = False
            dg_horario.Columns("min_entrada_tarde").Visible = False
            dg_horario.Columns("max_entrada_tarde").Visible = False
            dg_horario.Columns("min_salida_tarde").Visible = False
            dg_horario.Columns("max_salida_tarde").Visible = False
        Else
            MessageBox.Show("No se pudo eliminar la informacion", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

        End If
    End Sub
    'Cargar registros al formulario
    Private Sub dg_horario_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_horario.CellDoubleClick
        Try
            Me.txt_cod_horario.Text = dg_horario.Rows(e.RowIndex).Cells(0).Value
            Me.txt_entrada_prim.Text = dg_horario.Rows(e.RowIndex).Cells(1).Value
            Me.txt_salida_prim.Text = dg_horario.Rows(e.RowIndex).Cells(2).Value
            Me.txt_entrada_seg.Text = dg_horario.Rows(e.RowIndex).Cells(3).Value
            Me.txt_salida_seg.Text = dg_horario.Rows(e.RowIndex).Cells(4).Value
            Me.txt_min_em.Text = dg_horario.Rows(e.RowIndex).Cells(5).Value
            Me.txt_max_em.Text = dg_horario.Rows(e.RowIndex).Cells(6).Value
            Me.txt_min_sm.Text = dg_horario.Rows(e.RowIndex).Cells(7).Value
            Me.txt_max_sm.Text = dg_horario.Rows(e.RowIndex).Cells(8).Value
            Me.txt_min_et.Text = dg_horario.Rows(e.RowIndex).Cells(9).Value
            Me.txt_max_et.Text = dg_horario.Rows(e.RowIndex).Cells(10).Value
            Me.txt_min_st.Text = dg_horario.Rows(e.RowIndex).Cells(11).Value
            Me.txt_max_st.Text = dg_horario.Rows(e.RowIndex).Cells(12).Value


            btn_cancela.Enabled = True
            btn_elimina.Enabled = True
            btn_guarda.Enabled = False
            btn_nuevo.Enabled = False
            btn_update.Enabled = True
            desbloquear_form_horario(True)
        Catch ex As Exception
            MessageBox.Show("No se pudo cargar la informacion", ex.Message, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class