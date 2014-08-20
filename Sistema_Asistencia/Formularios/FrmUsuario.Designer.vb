<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuario))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cancela = New System.Windows.Forms.Button()
        Me.btn_elimina = New System.Windows.Forms.Button()
        Me.btn_edita = New System.Windows.Forms.Button()
        Me.btn_guarda = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.cbo_oficina = New System.Windows.Forms.ComboBox()
        Me.cbo_tipo_usuario = New System.Windows.Forms.ComboBox()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.f_nac = New System.Windows.Forms.DateTimePicker()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_materno = New System.Windows.Forms.TextBox()
        Me.txt_paterno = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgusuario = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgusuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(710, 33)
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
        Me.GroupBox1.Controls.Add(Me.btn_cancela)
        Me.GroupBox1.Controls.Add(Me.btn_elimina)
        Me.GroupBox1.Controls.Add(Me.btn_edita)
        Me.GroupBox1.Controls.Add(Me.btn_guarda)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.cbo_oficina)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo_usuario)
        Me.GroupBox1.Controls.Add(Me.txt_clave)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.f_nac)
        Me.GroupBox1.Controls.Add(Me.txt_direccion)
        Me.GroupBox1.Controls.Add(Me.txt_materno)
        Me.GroupBox1.Controls.Add(Me.txt_paterno)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_dni)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 478)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'btn_cancela
        '
        Me.btn_cancela.Location = New System.Drawing.Point(492, 426)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(113, 41)
        Me.btn_cancela.TabIndex = 22
        Me.btn_cancela.Text = "Cancelar"
        Me.btn_cancela.UseVisualStyleBackColor = True
        '
        'btn_elimina
        '
        Me.btn_elimina.Location = New System.Drawing.Point(379, 426)
        Me.btn_elimina.Name = "btn_elimina"
        Me.btn_elimina.Size = New System.Drawing.Size(113, 41)
        Me.btn_elimina.TabIndex = 21
        Me.btn_elimina.Text = "Eliminar"
        Me.btn_elimina.UseVisualStyleBackColor = True
        '
        'btn_edita
        '
        Me.btn_edita.Location = New System.Drawing.Point(267, 426)
        Me.btn_edita.Name = "btn_edita"
        Me.btn_edita.Size = New System.Drawing.Size(113, 41)
        Me.btn_edita.TabIndex = 20
        Me.btn_edita.Text = "Editar"
        Me.btn_edita.UseVisualStyleBackColor = True
        '
        'btn_guarda
        '
        Me.btn_guarda.Location = New System.Drawing.Point(154, 426)
        Me.btn_guarda.Name = "btn_guarda"
        Me.btn_guarda.Size = New System.Drawing.Size(113, 41)
        Me.btn_guarda.TabIndex = 19
        Me.btn_guarda.Text = "Guardar"
        Me.btn_guarda.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(41, 426)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(113, 41)
        Me.btn_nuevo.TabIndex = 18
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'cbo_oficina
        '
        Me.cbo_oficina.FormattingEnabled = True
        Me.cbo_oficina.Location = New System.Drawing.Point(348, 211)
        Me.cbo_oficina.Name = "cbo_oficina"
        Me.cbo_oficina.Size = New System.Drawing.Size(270, 28)
        Me.cbo_oficina.TabIndex = 6
        '
        'cbo_tipo_usuario
        '
        Me.cbo_tipo_usuario.FormattingEnabled = True
        Me.cbo_tipo_usuario.Location = New System.Drawing.Point(28, 366)
        Me.cbo_tipo_usuario.Name = "cbo_tipo_usuario"
        Me.cbo_tipo_usuario.Size = New System.Drawing.Size(270, 28)
        Me.cbo_tipo_usuario.TabIndex = 8
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(348, 368)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(270, 26)
        Me.txt_clave.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(342, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Oficina local"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tipo de usuario"
        '
        'f_nac
        '
        Me.f_nac.Location = New System.Drawing.Point(348, 68)
        Me.f_nac.Name = "f_nac"
        Me.f_nac.Size = New System.Drawing.Size(270, 26)
        Me.f_nac.TabIndex = 2
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(28, 287)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(590, 26)
        Me.txt_direccion.TabIndex = 7
        '
        'txt_materno
        '
        Me.txt_materno.Location = New System.Drawing.Point(28, 211)
        Me.txt_materno.Name = "txt_materno"
        Me.txt_materno.Size = New System.Drawing.Size(270, 26)
        Me.txt_materno.TabIndex = 5
        '
        'txt_paterno
        '
        Me.txt_paterno.Location = New System.Drawing.Point(348, 137)
        Me.txt_paterno.Name = "txt_paterno"
        Me.txt_paterno.Size = New System.Drawing.Size(270, 26)
        Me.txt_paterno.TabIndex = 4
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(28, 137)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(270, 26)
        Me.txt_nombre.TabIndex = 3
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(28, 68)
        Me.txt_dni.MaxLength = 8
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(270, 26)
        Me.txt_dni.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Dirección"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(344, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha de nac."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apell. Materno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(344, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apell. Paterno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgusuario)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 535)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(657, 441)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registros"
        '
        'dgusuario
        '
        Me.dgusuario.AllowUserToAddRows = False
        Me.dgusuario.AllowUserToDeleteRows = False
        Me.dgusuario.AllowUserToOrderColumns = True
        Me.dgusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgusuario.Location = New System.Drawing.Point(28, 34)
        Me.dgusuario.Name = "dgusuario"
        Me.dgusuario.ReadOnly = True
        Me.dgusuario.RowTemplate.Height = 28
        Me.dgusuario.Size = New System.Drawing.Size(600, 388)
        Me.dgusuario.TabIndex = 0
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(710, 1003)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo Usuarios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgusuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_oficina As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_tipo_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents f_nac As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_materno As System.Windows.Forms.TextBox
    Friend WithEvents txt_paterno As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_dni As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents btn_elimina As System.Windows.Forms.Button
    Friend WithEvents btn_edita As System.Windows.Forms.Button
    Friend WithEvents btn_guarda As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgusuario As System.Windows.Forms.DataGridView
End Class
