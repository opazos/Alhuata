<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHorario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHorario))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_max_st = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_min_st = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_max_et = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_min_et = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_max_sm = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_min_sm = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_max_em = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_min_em = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_cancela = New System.Windows.Forms.Button()
        Me.btn_elimina = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_guarda = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.txt_salida_seg = New System.Windows.Forms.TextBox()
        Me.txt_salida_prim = New System.Windows.Forms.TextBox()
        Me.txt_entrada_seg = New System.Windows.Forms.TextBox()
        Me.txt_entrada_prim = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cod_horario = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dg_horario = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_horario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(781, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(84, 29)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(117, 30)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_max_st)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_min_st)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txt_max_et)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_min_et)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_max_sm)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_min_sm)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_max_em)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_min_em)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btn_cancela)
        Me.GroupBox1.Controls.Add(Me.btn_elimina)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.btn_guarda)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.txt_salida_seg)
        Me.GroupBox1.Controls.Add(Me.txt_salida_prim)
        Me.GroupBox1.Controls.Add(Me.txt_entrada_seg)
        Me.GroupBox1.Controls.Add(Me.txt_entrada_prim)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(737, 492)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horarios"
        '
        'txt_max_st
        '
        Me.txt_max_st.Location = New System.Drawing.Point(536, 385)
        Me.txt_max_st.Name = "txt_max_st"
        Me.txt_max_st.Size = New System.Drawing.Size(179, 26)
        Me.txt_max_st.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(374, 391)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(140, 20)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Tolerancia máxima"
        '
        'txt_min_st
        '
        Me.txt_min_st.Location = New System.Drawing.Point(166, 385)
        Me.txt_min_st.Name = "txt_min_st"
        Me.txt_min_st.Size = New System.Drawing.Size(179, 26)
        Me.txt_min_st.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 388)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 20)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Tolerancia mínima"
        '
        'txt_max_et
        '
        Me.txt_max_et.Location = New System.Drawing.Point(536, 298)
        Me.txt_max_et.Name = "txt_max_et"
        Me.txt_max_et.Size = New System.Drawing.Size(179, 26)
        Me.txt_max_et.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(374, 304)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 20)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Tolerancia máxima"
        '
        'txt_min_et
        '
        Me.txt_min_et.Location = New System.Drawing.Point(166, 298)
        Me.txt_min_et.Name = "txt_min_et"
        Me.txt_min_et.Size = New System.Drawing.Size(179, 26)
        Me.txt_min_et.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 301)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Tolerancia mínima"
        '
        'txt_max_sm
        '
        Me.txt_max_sm.Location = New System.Drawing.Point(536, 187)
        Me.txt_max_sm.Name = "txt_max_sm"
        Me.txt_max_sm.Size = New System.Drawing.Size(179, 26)
        Me.txt_max_sm.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(374, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Tolerancia máxima"
        '
        'txt_min_sm
        '
        Me.txt_min_sm.Location = New System.Drawing.Point(166, 187)
        Me.txt_min_sm.Name = "txt_min_sm"
        Me.txt_min_sm.Size = New System.Drawing.Size(179, 26)
        Me.txt_min_sm.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Tolerancia mínima"
        '
        'txt_max_em
        '
        Me.txt_max_em.Location = New System.Drawing.Point(536, 100)
        Me.txt_max_em.Name = "txt_max_em"
        Me.txt_max_em.Size = New System.Drawing.Size(179, 26)
        Me.txt_max_em.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(374, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Tolerancia máxima"
        '
        'txt_min_em
        '
        Me.txt_min_em.Location = New System.Drawing.Point(166, 100)
        Me.txt_min_em.Name = "txt_min_em"
        Me.txt_min_em.Size = New System.Drawing.Size(179, 26)
        Me.txt_min_em.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tolerancia mínima"
        '
        'btn_cancela
        '
        Me.btn_cancela.Location = New System.Drawing.Point(556, 440)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(131, 37)
        Me.btn_cancela.TabIndex = 14
        Me.btn_cancela.Text = "Cancelar"
        Me.btn_cancela.UseVisualStyleBackColor = True
        '
        'btn_elimina
        '
        Me.btn_elimina.Location = New System.Drawing.Point(427, 440)
        Me.btn_elimina.Name = "btn_elimina"
        Me.btn_elimina.Size = New System.Drawing.Size(131, 37)
        Me.btn_elimina.TabIndex = 13
        Me.btn_elimina.Text = "Eliminar"
        Me.btn_elimina.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(298, 440)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(131, 37)
        Me.btn_update.TabIndex = 12
        Me.btn_update.Text = "Actualizar"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_guarda
        '
        Me.btn_guarda.Location = New System.Drawing.Point(169, 440)
        Me.btn_guarda.Name = "btn_guarda"
        Me.btn_guarda.Size = New System.Drawing.Size(131, 37)
        Me.btn_guarda.TabIndex = 11
        Me.btn_guarda.Text = "Guardar"
        Me.btn_guarda.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(40, 440)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(131, 37)
        Me.btn_nuevo.TabIndex = 10
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'txt_salida_seg
        '
        Me.txt_salida_seg.Location = New System.Drawing.Point(166, 349)
        Me.txt_salida_seg.Name = "txt_salida_seg"
        Me.txt_salida_seg.Size = New System.Drawing.Size(179, 26)
        Me.txt_salida_seg.TabIndex = 4
        '
        'txt_salida_prim
        '
        Me.txt_salida_prim.Location = New System.Drawing.Point(166, 151)
        Me.txt_salida_prim.Name = "txt_salida_prim"
        Me.txt_salida_prim.Size = New System.Drawing.Size(179, 26)
        Me.txt_salida_prim.TabIndex = 2
        '
        'txt_entrada_seg
        '
        Me.txt_entrada_seg.Location = New System.Drawing.Point(166, 260)
        Me.txt_entrada_seg.Name = "txt_entrada_seg"
        Me.txt_entrada_seg.Size = New System.Drawing.Size(179, 26)
        Me.txt_entrada_seg.TabIndex = 3
        '
        'txt_entrada_prim
        '
        Me.txt_entrada_prim.Location = New System.Drawing.Point(166, 63)
        Me.txt_entrada_prim.Name = "txt_entrada_prim"
        Me.txt_entrada_prim.Size = New System.Drawing.Size(179, 26)
        Me.txt_entrada_prim.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Salida"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Salida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Entrada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Entrada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tarde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mañana"
        '
        'txt_cod_horario
        '
        Me.txt_cod_horario.Enabled = False
        Me.txt_cod_horario.Location = New System.Drawing.Point(636, 38)
        Me.txt_cod_horario.Name = "txt_cod_horario"
        Me.txt_cod_horario.Size = New System.Drawing.Size(77, 26)
        Me.txt_cod_horario.TabIndex = 16
        Me.txt_cod_horario.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dg_horario)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 567)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(737, 274)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registros Ingresados"
        '
        'dg_horario
        '
        Me.dg_horario.AllowUserToAddRows = False
        Me.dg_horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_horario.Location = New System.Drawing.Point(20, 35)
        Me.dg_horario.Name = "dg_horario"
        Me.dg_horario.RowTemplate.Height = 28
        Me.dg_horario.Size = New System.Drawing.Size(695, 222)
        Me.dg_horario.TabIndex = 0
        '
        'FrmHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(781, 857)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_cod_horario)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmHorario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo Horarios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dg_horario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents btn_elimina As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_guarda As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_salida_seg As System.Windows.Forms.TextBox
    Friend WithEvents txt_salida_prim As System.Windows.Forms.TextBox
    Friend WithEvents txt_entrada_seg As System.Windows.Forms.TextBox
    Friend WithEvents txt_entrada_prim As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_horario As System.Windows.Forms.DataGridView
    Friend WithEvents txt_cod_horario As System.Windows.Forms.TextBox
    Friend WithEvents txt_max_st As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_min_st As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_max_et As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_min_et As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_max_sm As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_min_sm As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_max_em As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_min_em As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
