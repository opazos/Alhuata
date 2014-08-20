<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSalida))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.btn_cancela = New System.Windows.Forms.Button()
        Me.btn_elimina = New System.Windows.Forms.Button()
        Me.btn_actualiza = New System.Windows.Forms.Button()
        Me.btn_guarda = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.txt_justificacion = New System.Windows.Forms.RichTextBox()
        Me.fec_llegada = New System.Windows.Forms.DateTimePicker()
        Me.fec_salida = New System.Windows.Forms.DateTimePicker()
        Me.cbo_tipo_salida = New System.Windows.Forms.ComboBox()
        Me.txt_n_doc = New System.Windows.Forms.TextBox()
        Me.cbo_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.cbo_usuario = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbregistros = New System.Windows.Forms.GroupBox()
        Me.dg_salida = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbregistros.SuspendLayout()
        CType(Me.dg_salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(912, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(86, 29)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(117, 30)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.btn_cancela)
        Me.GroupBox1.Controls.Add(Me.btn_elimina)
        Me.GroupBox1.Controls.Add(Me.btn_actualiza)
        Me.GroupBox1.Controls.Add(Me.btn_guarda)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.txt_justificacion)
        Me.GroupBox1.Controls.Add(Me.fec_llegada)
        Me.GroupBox1.Controls.Add(Me.fec_salida)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo_salida)
        Me.GroupBox1.Controls.Add(Me.txt_n_doc)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo_doc)
        Me.GroupBox1.Controls.Add(Me.cbo_usuario)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(862, 466)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro de salidas"
        '
        'txt_codigo
        '
        Me.txt_codigo.Enabled = False
        Me.txt_codigo.Location = New System.Drawing.Point(786, 414)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(55, 28)
        Me.txt_codigo.TabIndex = 21
        Me.txt_codigo.Visible = False
        '
        'btn_cancela
        '
        Me.btn_cancela.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancela.Location = New System.Drawing.Point(527, 409)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(121, 38)
        Me.btn_cancela.TabIndex = 20
        Me.btn_cancela.Text = "Cancelar"
        Me.btn_cancela.UseVisualStyleBackColor = True
        '
        'btn_elimina
        '
        Me.btn_elimina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_elimina.Location = New System.Drawing.Point(654, 409)
        Me.btn_elimina.Name = "btn_elimina"
        Me.btn_elimina.Size = New System.Drawing.Size(121, 38)
        Me.btn_elimina.TabIndex = 19
        Me.btn_elimina.Text = "Eliminar"
        Me.btn_elimina.UseVisualStyleBackColor = True
        Me.btn_elimina.Visible = False
        '
        'btn_actualiza
        '
        Me.btn_actualiza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualiza.Location = New System.Drawing.Point(400, 409)
        Me.btn_actualiza.Name = "btn_actualiza"
        Me.btn_actualiza.Size = New System.Drawing.Size(121, 38)
        Me.btn_actualiza.TabIndex = 18
        Me.btn_actualiza.Text = "Actualizar"
        Me.btn_actualiza.UseVisualStyleBackColor = True
        '
        'btn_guarda
        '
        Me.btn_guarda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guarda.Location = New System.Drawing.Point(273, 409)
        Me.btn_guarda.Name = "btn_guarda"
        Me.btn_guarda.Size = New System.Drawing.Size(121, 38)
        Me.btn_guarda.TabIndex = 17
        Me.btn_guarda.Text = "Guardar"
        Me.btn_guarda.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.Location = New System.Drawing.Point(146, 409)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(121, 38)
        Me.btn_nuevo.TabIndex = 16
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'txt_justificacion
        '
        Me.txt_justificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_justificacion.Location = New System.Drawing.Point(30, 295)
        Me.txt_justificacion.Name = "txt_justificacion"
        Me.txt_justificacion.Size = New System.Drawing.Size(793, 96)
        Me.txt_justificacion.TabIndex = 15
        Me.txt_justificacion.Text = ""
        '
        'fec_llegada
        '
        Me.fec_llegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fec_llegada.Location = New System.Drawing.Point(473, 225)
        Me.fec_llegada.Name = "fec_llegada"
        Me.fec_llegada.Size = New System.Drawing.Size(350, 28)
        Me.fec_llegada.TabIndex = 14
        '
        'fec_salida
        '
        Me.fec_salida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fec_salida.Location = New System.Drawing.Point(30, 225)
        Me.fec_salida.Name = "fec_salida"
        Me.fec_salida.Size = New System.Drawing.Size(350, 28)
        Me.fec_salida.TabIndex = 13
        '
        'cbo_tipo_salida
        '
        Me.cbo_tipo_salida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipo_salida.FormattingEnabled = True
        Me.cbo_tipo_salida.Items.AddRange(New Object() {"COMISION DE SERVICIO", "PERMISO POR SALUD", "PERMISO A CUENTA DE VACACIONES", "OTRO"})
        Me.cbo_tipo_salida.Location = New System.Drawing.Point(473, 54)
        Me.cbo_tipo_salida.Name = "cbo_tipo_salida"
        Me.cbo_tipo_salida.Size = New System.Drawing.Size(350, 30)
        Me.cbo_tipo_salida.TabIndex = 12
        '
        'txt_n_doc
        '
        Me.txt_n_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_n_doc.Location = New System.Drawing.Point(473, 152)
        Me.txt_n_doc.Name = "txt_n_doc"
        Me.txt_n_doc.Size = New System.Drawing.Size(350, 28)
        Me.txt_n_doc.TabIndex = 11
        '
        'cbo_tipo_doc
        '
        Me.cbo_tipo_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipo_doc.FormattingEnabled = True
        Me.cbo_tipo_doc.Items.AddRange(New Object() {"HOJA DE VIATICO", "CARTA", "OFICIO", "OTRO"})
        Me.cbo_tipo_doc.Location = New System.Drawing.Point(30, 152)
        Me.cbo_tipo_doc.Name = "cbo_tipo_doc"
        Me.cbo_tipo_doc.Size = New System.Drawing.Size(350, 30)
        Me.cbo_tipo_doc.TabIndex = 10
        '
        'cbo_usuario
        '
        Me.cbo_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_usuario.FormattingEnabled = True
        Me.cbo_usuario.Location = New System.Drawing.Point(30, 54)
        Me.cbo_usuario.Name = "cbo_usuario"
        Me.cbo_usuario.Size = New System.Drawing.Size(350, 30)
        Me.cbo_usuario.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(469, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Número de documento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tipo de documento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Referencia : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Justificación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(469, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de llegada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha de salida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(469, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de salida"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccionar Usuario"
        '
        'gbregistros
        '
        Me.gbregistros.Controls.Add(Me.dg_salida)
        Me.gbregistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbregistros.Location = New System.Drawing.Point(22, 526)
        Me.gbregistros.Name = "gbregistros"
        Me.gbregistros.Size = New System.Drawing.Size(862, 336)
        Me.gbregistros.TabIndex = 2
        Me.gbregistros.TabStop = False
        Me.gbregistros.Text = "Registros"
        '
        'dg_salida
        '
        Me.dg_salida.AllowUserToAddRows = False
        Me.dg_salida.AllowUserToDeleteRows = False
        Me.dg_salida.AllowUserToOrderColumns = True
        Me.dg_salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_salida.Location = New System.Drawing.Point(20, 28)
        Me.dg_salida.Name = "dg_salida"
        Me.dg_salida.ReadOnly = True
        Me.dg_salida.RowTemplate.Height = 28
        Me.dg_salida.Size = New System.Drawing.Size(821, 290)
        Me.dg_salida.TabIndex = 0
        '
        'FrmSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(912, 885)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbregistros)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmSalida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo para el registro de salidas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbregistros.ResumeLayout(False)
        CType(Me.dg_salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_justificacion As System.Windows.Forms.RichTextBox
    Friend WithEvents fec_llegada As System.Windows.Forms.DateTimePicker
    Friend WithEvents fec_salida As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_tipo_salida As System.Windows.Forms.ComboBox
    Friend WithEvents txt_n_doc As System.Windows.Forms.TextBox
    Friend WithEvents cbo_tipo_doc As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents btn_elimina As System.Windows.Forms.Button
    Friend WithEvents btn_actualiza As System.Windows.Forms.Button
    Friend WithEvents btn_guarda As System.Windows.Forms.Button
    Friend WithEvents gbregistros As System.Windows.Forms.GroupBox
    Friend WithEvents dg_salida As System.Windows.Forms.DataGridView
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
End Class
