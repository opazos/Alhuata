<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOlp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOlp))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cancela = New System.Windows.Forms.Button()
        Me.btn_elimina = New System.Windows.Forms.Button()
        Me.btn_edita = New System.Windows.Forms.Button()
        Me.btn_guarda = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.cbo_horario = New System.Windows.Forms.ComboBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgsede = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgsede, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cancela)
        Me.GroupBox1.Controls.Add(Me.btn_elimina)
        Me.GroupBox1.Controls.Add(Me.btn_edita)
        Me.GroupBox1.Controls.Add(Me.btn_guarda)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.cbo_horario)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 276)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oficinas Locales"
        '
        'btn_cancela
        '
        Me.btn_cancela.Location = New System.Drawing.Point(542, 212)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(131, 37)
        Me.btn_cancela.TabIndex = 15
        Me.btn_cancela.Text = "Cancelar"
        Me.btn_cancela.UseVisualStyleBackColor = True
        '
        'btn_elimina
        '
        Me.btn_elimina.Location = New System.Drawing.Point(412, 212)
        Me.btn_elimina.Name = "btn_elimina"
        Me.btn_elimina.Size = New System.Drawing.Size(131, 37)
        Me.btn_elimina.TabIndex = 14
        Me.btn_elimina.Text = "Eliminar"
        Me.btn_elimina.UseVisualStyleBackColor = True
        '
        'btn_edita
        '
        Me.btn_edita.Location = New System.Drawing.Point(282, 212)
        Me.btn_edita.Name = "btn_edita"
        Me.btn_edita.Size = New System.Drawing.Size(131, 37)
        Me.btn_edita.TabIndex = 13
        Me.btn_edita.Text = "Editar"
        Me.btn_edita.UseVisualStyleBackColor = True
        '
        'btn_guarda
        '
        Me.btn_guarda.Location = New System.Drawing.Point(152, 212)
        Me.btn_guarda.Name = "btn_guarda"
        Me.btn_guarda.Size = New System.Drawing.Size(131, 37)
        Me.btn_guarda.TabIndex = 12
        Me.btn_guarda.Text = "Guardar"
        Me.btn_guarda.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(22, 212)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(131, 37)
        Me.btn_nuevo.TabIndex = 11
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'cbo_horario
        '
        Me.cbo_horario.FormattingEnabled = True
        Me.cbo_horario.Location = New System.Drawing.Point(329, 160)
        Me.cbo_horario.Name = "cbo_horario"
        Me.cbo_horario.Size = New System.Drawing.Size(344, 28)
        Me.cbo_horario.TabIndex = 5
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(22, 160)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(270, 26)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(22, 82)
        Me.txt_codigo.MaxLength = 3
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(142, 26)
        Me.txt_codigo.TabIndex = 1
        Me.txt_codigo.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Horario de funciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de la OLP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de la OLP"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgsede)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(700, 422)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registros"
        '
        'dgsede
        '
        Me.dgsede.AllowUserToAddRows = False
        Me.dgsede.AllowUserToDeleteRows = False
        Me.dgsede.AllowUserToOrderColumns = True
        Me.dgsede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsede.Location = New System.Drawing.Point(22, 36)
        Me.dgsede.Name = "dgsede"
        Me.dgsede.ReadOnly = True
        Me.dgsede.RowTemplate.Height = 28
        Me.dgsede.Size = New System.Drawing.Size(651, 363)
        Me.dgsede.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(728, 33)
        Me.MenuStrip1.TabIndex = 4
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
        'FrmOlp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(728, 774)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOlp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo Oficinas Locales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgsede, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents btn_elimina As System.Windows.Forms.Button
    Friend WithEvents btn_edita As System.Windows.Forms.Button
    Friend WithEvents btn_guarda As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents cbo_horario As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgsede As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
