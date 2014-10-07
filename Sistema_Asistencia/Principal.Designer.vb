<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarSalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSistemaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefinirHoraDeEntradaYSalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuloOficinasLocalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_max_st = New System.Windows.Forms.TextBox()
        Me.txt_min_st = New System.Windows.Forms.TextBox()
        Me.txt_max_et = New System.Windows.Forms.TextBox()
        Me.txt_min_et = New System.Windows.Forms.TextBox()
        Me.txt_max_sm = New System.Windows.Forms.TextBox()
        Me.txt_min_sm = New System.Windows.Forms.TextBox()
        Me.txt_max_em = New System.Windows.Forms.TextBox()
        Me.txt_min_em = New System.Windows.Forms.TextBox()
        Me.dg_horario = New System.Windows.Forms.DataGridView()
        Me.txt_s_t = New System.Windows.Forms.TextBox()
        Me.txt_e_t = New System.Windows.Forms.TextBox()
        Me.txt_s_m = New System.Windows.Forms.TextBox()
        Me.txt_e_m = New System.Windows.Forms.TextBox()
        Me.txt_puntualidad = New System.Windows.Forms.TextBox()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.txt_turno = New System.Windows.Forms.TextBox()
        Me.txt_oficina = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.fec_ingreso = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_asistencia = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_usuario = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_justificacion = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dg_asistencia = New System.Windows.Forms.DataGridView()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_horario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg_asistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SistemaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1277, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarSalidaToolStripMenuItem, Me.SalirDelSistemaToolStripMenuItem1})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(107, 36)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'RegistrarSalidaToolStripMenuItem
        '
        Me.RegistrarSalidaToolStripMenuItem.Name = "RegistrarSalidaToolStripMenuItem"
        Me.RegistrarSalidaToolStripMenuItem.Size = New System.Drawing.Size(262, 36)
        Me.RegistrarSalidaToolStripMenuItem.Text = "Registrar Salida"
        '
        'SalirDelSistemaToolStripMenuItem1
        '
        Me.SalirDelSistemaToolStripMenuItem1.Name = "SalirDelSistemaToolStripMenuItem1"
        Me.SalirDelSistemaToolStripMenuItem1.Size = New System.Drawing.Size(262, 36)
        Me.SalirDelSistemaToolStripMenuItem1.Text = "Salir del sistema"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(121, 36)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefinirHoraDeEntradaYSalidaToolStripMenuItem, Me.SalirToolStripMenuItem, Me.ModuloOficinasLocalesToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(110, 36)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        Me.SistemaToolStripMenuItem.Visible = False
        '
        'DefinirHoraDeEntradaYSalidaToolStripMenuItem
        '
        Me.DefinirHoraDeEntradaYSalidaToolStripMenuItem.Name = "DefinirHoraDeEntradaYSalidaToolStripMenuItem"
        Me.DefinirHoraDeEntradaYSalidaToolStripMenuItem.Size = New System.Drawing.Size(350, 36)
        Me.DefinirHoraDeEntradaYSalidaToolStripMenuItem.Text = "Modulo Horarios"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(350, 36)
        Me.SalirToolStripMenuItem.Text = "Modulo Usuarios"
        '
        'ModuloOficinasLocalesToolStripMenuItem
        '
        Me.ModuloOficinasLocalesToolStripMenuItem.Name = "ModuloOficinasLocalesToolStripMenuItem"
        Me.ModuloOficinasLocalesToolStripMenuItem.Size = New System.Drawing.Size(350, 36)
        Me.ModuloOficinasLocalesToolStripMenuItem.Text = "Modulo Oficinas Locales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 96)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(643, 108)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "00:00:00 a.m."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_max_st)
        Me.GroupBox1.Controls.Add(Me.txt_min_st)
        Me.GroupBox1.Controls.Add(Me.txt_max_et)
        Me.GroupBox1.Controls.Add(Me.txt_min_et)
        Me.GroupBox1.Controls.Add(Me.txt_max_sm)
        Me.GroupBox1.Controls.Add(Me.txt_min_sm)
        Me.GroupBox1.Controls.Add(Me.txt_max_em)
        Me.GroupBox1.Controls.Add(Me.txt_min_em)
        Me.GroupBox1.Controls.Add(Me.dg_horario)
        Me.GroupBox1.Controls.Add(Me.txt_s_t)
        Me.GroupBox1.Controls.Add(Me.txt_e_t)
        Me.GroupBox1.Controls.Add(Me.txt_s_m)
        Me.GroupBox1.Controls.Add(Me.txt_e_m)
        Me.GroupBox1.Controls.Add(Me.txt_puntualidad)
        Me.GroupBox1.Controls.Add(Me.txt_tipo)
        Me.GroupBox1.Controls.Add(Me.txt_turno)
        Me.GroupBox1.Controls.Add(Me.txt_oficina)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 46)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1241, 416)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HORARIO"
        '
        'txt_max_st
        '
        Me.txt_max_st.Enabled = False
        Me.txt_max_st.Location = New System.Drawing.Point(1156, 25)
        Me.txt_max_st.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_max_st.Name = "txt_max_st"
        Me.txt_max_st.Size = New System.Drawing.Size(37, 32)
        Me.txt_max_st.TabIndex = 24
        Me.txt_max_st.Visible = False
        '
        'txt_min_st
        '
        Me.txt_min_st.Enabled = False
        Me.txt_min_st.Location = New System.Drawing.Point(1109, 25)
        Me.txt_min_st.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_min_st.Name = "txt_min_st"
        Me.txt_min_st.Size = New System.Drawing.Size(37, 32)
        Me.txt_min_st.TabIndex = 23
        Me.txt_min_st.Visible = False
        '
        'txt_max_et
        '
        Me.txt_max_et.Enabled = False
        Me.txt_max_et.Location = New System.Drawing.Point(1063, 25)
        Me.txt_max_et.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_max_et.Name = "txt_max_et"
        Me.txt_max_et.Size = New System.Drawing.Size(37, 32)
        Me.txt_max_et.TabIndex = 22
        Me.txt_max_et.Visible = False
        '
        'txt_min_et
        '
        Me.txt_min_et.Enabled = False
        Me.txt_min_et.Location = New System.Drawing.Point(1016, 25)
        Me.txt_min_et.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_min_et.Name = "txt_min_et"
        Me.txt_min_et.Size = New System.Drawing.Size(37, 32)
        Me.txt_min_et.TabIndex = 21
        Me.txt_min_et.Visible = False
        '
        'txt_max_sm
        '
        Me.txt_max_sm.Enabled = False
        Me.txt_max_sm.Location = New System.Drawing.Point(969, 25)
        Me.txt_max_sm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_max_sm.Name = "txt_max_sm"
        Me.txt_max_sm.Size = New System.Drawing.Size(37, 32)
        Me.txt_max_sm.TabIndex = 20
        Me.txt_max_sm.Visible = False
        '
        'txt_min_sm
        '
        Me.txt_min_sm.Enabled = False
        Me.txt_min_sm.Location = New System.Drawing.Point(923, 25)
        Me.txt_min_sm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_min_sm.Name = "txt_min_sm"
        Me.txt_min_sm.Size = New System.Drawing.Size(37, 32)
        Me.txt_min_sm.TabIndex = 19
        Me.txt_min_sm.Visible = False
        '
        'txt_max_em
        '
        Me.txt_max_em.Enabled = False
        Me.txt_max_em.Location = New System.Drawing.Point(876, 25)
        Me.txt_max_em.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_max_em.Name = "txt_max_em"
        Me.txt_max_em.Size = New System.Drawing.Size(37, 32)
        Me.txt_max_em.TabIndex = 18
        Me.txt_max_em.Visible = False
        '
        'txt_min_em
        '
        Me.txt_min_em.Enabled = False
        Me.txt_min_em.Location = New System.Drawing.Point(829, 25)
        Me.txt_min_em.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_min_em.Name = "txt_min_em"
        Me.txt_min_em.Size = New System.Drawing.Size(37, 32)
        Me.txt_min_em.TabIndex = 17
        Me.txt_min_em.Visible = False
        '
        'dg_horario
        '
        Me.dg_horario.AllowUserToAddRows = False
        Me.dg_horario.AllowUserToDeleteRows = False
        Me.dg_horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_horario.Location = New System.Drawing.Point(268, 25)
        Me.dg_horario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dg_horario.Name = "dg_horario"
        Me.dg_horario.ReadOnly = True
        Me.dg_horario.RowTemplate.Height = 28
        Me.dg_horario.Size = New System.Drawing.Size(384, 52)
        Me.dg_horario.TabIndex = 16
        Me.dg_horario.Visible = False
        '
        'txt_s_t
        '
        Me.txt_s_t.Enabled = False
        Me.txt_s_t.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_t.Location = New System.Drawing.Point(499, 354)
        Me.txt_s_t.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_s_t.Name = "txt_s_t"
        Me.txt_s_t.Size = New System.Drawing.Size(159, 35)
        Me.txt_s_t.TabIndex = 15
        '
        'txt_e_t
        '
        Me.txt_e_t.Enabled = False
        Me.txt_e_t.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_t.Location = New System.Drawing.Point(169, 354)
        Me.txt_e_t.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_e_t.Name = "txt_e_t"
        Me.txt_e_t.Size = New System.Drawing.Size(159, 35)
        Me.txt_e_t.TabIndex = 14
        '
        'txt_s_m
        '
        Me.txt_s_m.Enabled = False
        Me.txt_s_m.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_m.Location = New System.Drawing.Point(497, 265)
        Me.txt_s_m.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_s_m.Name = "txt_s_m"
        Me.txt_s_m.Size = New System.Drawing.Size(159, 35)
        Me.txt_s_m.TabIndex = 13
        '
        'txt_e_m
        '
        Me.txt_e_m.Enabled = False
        Me.txt_e_m.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_m.Location = New System.Drawing.Point(168, 268)
        Me.txt_e_m.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_e_m.Name = "txt_e_m"
        Me.txt_e_m.Size = New System.Drawing.Size(159, 35)
        Me.txt_e_m.TabIndex = 12
        '
        'txt_puntualidad
        '
        Me.txt_puntualidad.Location = New System.Drawing.Point(185, 32)
        Me.txt_puntualidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_puntualidad.Name = "txt_puntualidad"
        Me.txt_puntualidad.Size = New System.Drawing.Size(53, 32)
        Me.txt_puntualidad.TabIndex = 11
        Me.txt_puntualidad.Visible = False
        '
        'txt_tipo
        '
        Me.txt_tipo.Location = New System.Drawing.Point(135, 32)
        Me.txt_tipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(41, 32)
        Me.txt_tipo.TabIndex = 10
        Me.txt_tipo.Visible = False
        '
        'txt_turno
        '
        Me.txt_turno.Location = New System.Drawing.Point(83, 32)
        Me.txt_turno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_turno.Name = "txt_turno"
        Me.txt_turno.Size = New System.Drawing.Size(43, 32)
        Me.txt_turno.TabIndex = 9
        Me.txt_turno.Visible = False
        '
        'txt_oficina
        '
        Me.txt_oficina.Location = New System.Drawing.Point(29, 32)
        Me.txt_oficina.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_oficina.Name = "txt_oficina"
        Me.txt_oficina.Size = New System.Drawing.Size(44, 32)
        Me.txt_oficina.TabIndex = 8
        Me.txt_oficina.Visible = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Enabled = False
        Me.MonthCalendar1.Location = New System.Drawing.Point(768, 66)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 319)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 31)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "TARDE     : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 229)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 31)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "MAÑANA :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(405, 360)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 26)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Salida :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 362)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Entrada : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(404, 271)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Salida :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 274)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Entrada : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_hora)
        Me.GroupBox2.Controls.Add(Me.fec_ingreso)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.btn_asistencia)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbo_usuario)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 472)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1241, 254)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "REGISTRAR ASISTENCIA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(520, 139)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(206, 31)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Hora de ingreso"
        '
        'txt_hora
        '
        Me.txt_hora.Enabled = False
        Me.txt_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hora.Location = New System.Drawing.Point(519, 175)
        Me.txt_hora.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(447, 35)
        Me.txt_hora.TabIndex = 8
        '
        'fec_ingreso
        '
        Me.fec_ingreso.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fec_ingreso.Enabled = False
        Me.fec_ingreso.Location = New System.Drawing.Point(29, 175)
        Me.fec_ingreso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fec_ingreso.Name = "fec_ingreso"
        Me.fec_ingreso.Size = New System.Drawing.Size(455, 35)
        Me.fec_ingreso.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(512, 140)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(206, 31)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Hora de ingreso"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 140)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(223, 31)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Fecha de ingreso"
        '
        'btn_asistencia
        '
        Me.btn_asistencia.Location = New System.Drawing.Point(996, 81)
        Me.btn_asistencia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_asistencia.Name = "btn_asistencia"
        Me.btn_asistencia.Size = New System.Drawing.Size(227, 136)
        Me.btn_asistencia.TabIndex = 4
        Me.btn_asistencia.Text = "Registrar"
        Me.btn_asistencia.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 48)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(257, 31)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Seleccionar Usuario"
        '
        'cbo_usuario
        '
        Me.cbo_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_usuario.FormattingEnabled = True
        Me.cbo_usuario.Location = New System.Drawing.Point(28, 86)
        Me.cbo_usuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbo_usuario.Name = "cbo_usuario"
        Me.cbo_usuario.Size = New System.Drawing.Size(937, 37)
        Me.cbo_usuario.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_justificacion)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(17, 730)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(1241, 155)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Justificación Tardanza"
        '
        'txt_justificacion
        '
        Me.txt_justificacion.Location = New System.Drawing.Point(19, 38)
        Me.txt_justificacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_justificacion.Name = "txt_justificacion"
        Me.txt_justificacion.Size = New System.Drawing.Size(1203, 96)
        Me.txt_justificacion.TabIndex = 0
        Me.txt_justificacion.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dg_asistencia)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(17, 896)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(1241, 381)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Registro del día"
        '
        'dg_asistencia
        '
        Me.dg_asistencia.AllowUserToAddRows = False
        Me.dg_asistencia.AllowUserToDeleteRows = False
        Me.dg_asistencia.AllowUserToOrderColumns = True
        Me.dg_asistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_asistencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg_asistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_asistencia.Location = New System.Drawing.Point(19, 34)
        Me.dg_asistencia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dg_asistencia.Name = "dg_asistencia"
        Me.dg_asistencia.ReadOnly = True
        Me.dg_asistencia.RowTemplate.Height = 28
        Me.dg_asistencia.Size = New System.Drawing.Size(1204, 322)
        Me.dg_asistencia.TabIndex = 0
        '
        'Timer2
        '
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(1277, 1274)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(1506, 1345)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de asistencia NEC PDSS II"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg_horario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dg_asistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefinirHoraDeEntradaYSalidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_asistencia As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbo_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_justificacion As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_asistencia As System.Windows.Forms.DataGridView
    Friend WithEvents ModuloOficinasLocalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents fec_ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_puntualidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipo As System.Windows.Forms.TextBox
    Friend WithEvents txt_turno As System.Windows.Forms.TextBox
    Friend WithEvents txt_oficina As System.Windows.Forms.TextBox
    Friend WithEvents txt_s_t As System.Windows.Forms.TextBox
    Friend WithEvents txt_e_t As System.Windows.Forms.TextBox
    Friend WithEvents txt_s_m As System.Windows.Forms.TextBox
    Friend WithEvents txt_e_m As System.Windows.Forms.TextBox
    Friend WithEvents dg_horario As System.Windows.Forms.DataGridView
    Friend WithEvents SalirDelSistemaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarSalidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_max_st As System.Windows.Forms.TextBox
    Friend WithEvents txt_min_st As System.Windows.Forms.TextBox
    Friend WithEvents txt_max_et As System.Windows.Forms.TextBox
    Friend WithEvents txt_min_et As System.Windows.Forms.TextBox
    Friend WithEvents txt_max_sm As System.Windows.Forms.TextBox
    Friend WithEvents txt_min_sm As System.Windows.Forms.TextBox
    Friend WithEvents txt_max_em As System.Windows.Forms.TextBox
    Friend WithEvents txt_min_em As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
