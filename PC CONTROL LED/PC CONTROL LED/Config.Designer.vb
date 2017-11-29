<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Config
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Config))
        Me.maximizar = New System.Windows.Forms.PictureBox()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.cerrar = New System.Windows.Forms.PictureBox()
        Me.ok = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.cancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Redireccion = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LedStatus = New System.Windows.Forms.CheckBox()
        Me.HexView = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ClosePortInact = New System.Windows.Forms.CheckBox()
        Me.KeepHistory = New System.Windows.Forms.CheckBox()
        Me.Autocomplete = New System.Windows.Forms.CheckBox()
        Me.OutESC = New System.Windows.Forms.CheckBox()
        Me.KeepUp = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Polling = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Source = New System.Windows.Forms.ComboBox()
        Me.LineAjust = New System.Windows.Forms.CheckBox()
        Me.SP1_TX = New System.Windows.Forms.GroupBox()
        Me.EchoLocal = New System.Windows.Forms.CheckBox()
        Me.WithCRLF = New System.Windows.Forms.RadioButton()
        Me.WithLF = New System.Windows.Forms.RadioButton()
        Me.WithCR = New System.Windows.Forms.RadioButton()
        Me.WithNoting = New System.Windows.Forms.RadioButton()
        Me.SP1_Gb_Cfg = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContFlujo = New System.Windows.Forms.ComboBox()
        Me.Paridad = New System.Windows.Forms.ComboBox()
        Me.BitsStop = New System.Windows.Forms.ComboBox()
        Me.BitsDatos = New System.Windows.Forms.ComboBox()
        Me.Velocidad = New System.Windows.Forms.ComboBox()
        Me.Puerto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.ColorRx = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ColorTx = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Color1 = New System.Windows.Forms.ColorDialog()
        Me.Color2 = New System.Windows.Forms.ColorDialog()
        CType(Me.maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SP1_TX.SuspendLayout()
        Me.SP1_Gb_Cfg.SuspendLayout()
        Me.SuspendLayout()
        '
        'maximizar
        '
        Me.maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.maximizar.Image = CType(resources.GetObject("maximizar.Image"), System.Drawing.Image)
        Me.maximizar.Location = New System.Drawing.Point(482, 12)
        Me.maximizar.Name = "maximizar"
        Me.maximizar.Size = New System.Drawing.Size(18, 17)
        Me.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.maximizar.TabIndex = 17
        Me.maximizar.TabStop = False
        '
        'minimizar
        '
        Me.minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimizar.Image = CType(resources.GetObject("minimizar.Image"), System.Drawing.Image)
        Me.minimizar.Location = New System.Drawing.Point(458, 12)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(18, 17)
        Me.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minimizar.TabIndex = 15
        Me.minimizar.TabStop = False
        '
        'cerrar
        '
        Me.cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cerrar.Image = CType(resources.GetObject("cerrar.Image"), System.Drawing.Image)
        Me.cerrar.Location = New System.Drawing.Point(506, 12)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(18, 17)
        Me.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cerrar.TabIndex = 16
        Me.cerrar.TabStop = False
        '
        'ok
        '
        Me.ok.ActiveBorderThickness = 1
        Me.ok.ActiveCornerRadius = 20
        Me.ok.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.ok.ActiveForecolor = System.Drawing.Color.White
        Me.ok.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ok.BackColor = System.Drawing.Color.Black
        Me.ok.BackgroundImage = CType(resources.GetObject("ok.BackgroundImage"), System.Drawing.Image)
        Me.ok.ButtonText = "ok"
        Me.ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ok.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.ok.ForeColor = System.Drawing.Color.SeaGreen
        Me.ok.IdleBorderThickness = 1
        Me.ok.IdleCornerRadius = 20
        Me.ok.IdleFillColor = System.Drawing.Color.Transparent
        Me.ok.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.ok.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.ok.Location = New System.Drawing.Point(384, 298)
        Me.ok.Margin = New System.Windows.Forms.Padding(5)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(64, 44)
        Me.ok.TabIndex = 18
        Me.ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cancel
        '
        Me.cancel.ActiveBorderThickness = 1
        Me.cancel.ActiveCornerRadius = 20
        Me.cancel.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.cancel.ActiveForecolor = System.Drawing.Color.White
        Me.cancel.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancel.BackColor = System.Drawing.Color.Black
        Me.cancel.BackgroundImage = CType(resources.GetObject("cancel.BackgroundImage"), System.Drawing.Image)
        Me.cancel.ButtonText = "Cancel"
        Me.cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancel.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.cancel.ForeColor = System.Drawing.Color.SeaGreen
        Me.cancel.IdleBorderThickness = 1
        Me.cancel.IdleCornerRadius = 20
        Me.cancel.IdleFillColor = System.Drawing.Color.Transparent
        Me.cancel.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.cancel.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.cancel.Location = New System.Drawing.Point(458, 298)
        Me.cancel.Margin = New System.Windows.Forms.Padding(5)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(64, 44)
        Me.cancel.TabIndex = 18
        Me.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Redireccion
        '
        Me.Redireccion.FormattingEnabled = True
        Me.Redireccion.Location = New System.Drawing.Point(94, 199)
        Me.Redireccion.Name = "Redireccion"
        Me.Redireccion.Size = New System.Drawing.Size(82, 24)
        Me.Redireccion.TabIndex = 20
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LedStatus)
        Me.GroupBox4.Controls.Add(Me.HexView)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(361, 190)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(150, 106)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Herramientas"
        '
        'LedStatus
        '
        Me.LedStatus.AutoSize = True
        Me.LedStatus.Location = New System.Drawing.Point(10, 39)
        Me.LedStatus.Name = "LedStatus"
        Me.LedStatus.Size = New System.Drawing.Size(83, 20)
        Me.LedStatus.TabIndex = 4
        Me.LedStatus.Text = "Led Status"
        Me.LedStatus.UseVisualStyleBackColor = True
        '
        'HexView
        '
        Me.HexView.AutoSize = True
        Me.HexView.Location = New System.Drawing.Point(10, 18)
        Me.HexView.Name = "HexView"
        Me.HexView.Size = New System.Drawing.Size(77, 20)
        Me.HexView.TabIndex = 2
        Me.HexView.Text = "Hex View"
        Me.HexView.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ClosePortInact)
        Me.GroupBox3.Controls.Add(Me.KeepHistory)
        Me.GroupBox3.Controls.Add(Me.Autocomplete)
        Me.GroupBox3.Controls.Add(Me.OutESC)
        Me.GroupBox3.Controls.Add(Me.KeepUp)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(361, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 129)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'ClosePortInact
        '
        Me.ClosePortInact.AutoSize = True
        Me.ClosePortInact.Location = New System.Drawing.Point(10, 96)
        Me.ClosePortInact.Name = "ClosePortInact"
        Me.ClosePortInact.Size = New System.Drawing.Size(133, 20)
        Me.ClosePortInact.TabIndex = 0
        Me.ClosePortInact.Text = "Cerrar Puerto Inact."
        Me.ClosePortInact.UseVisualStyleBackColor = True
        '
        'KeepHistory
        '
        Me.KeepHistory.AutoSize = True
        Me.KeepHistory.Location = New System.Drawing.Point(10, 76)
        Me.KeepHistory.Name = "KeepHistory"
        Me.KeepHistory.Size = New System.Drawing.Size(124, 20)
        Me.KeepHistory.TabIndex = 0
        Me.KeepHistory.Text = "Mantener Historial"
        Me.KeepHistory.UseVisualStyleBackColor = True
        '
        'Autocomplete
        '
        Me.Autocomplete.AutoSize = True
        Me.Autocomplete.Location = New System.Drawing.Point(10, 56)
        Me.Autocomplete.Name = "Autocomplete"
        Me.Autocomplete.Size = New System.Drawing.Size(108, 20)
        Me.Autocomplete.TabIndex = 0
        Me.Autocomplete.Text = "Autocompletar"
        Me.Autocomplete.UseVisualStyleBackColor = True
        '
        'OutESC
        '
        Me.OutESC.AutoSize = True
        Me.OutESC.Location = New System.Drawing.Point(10, 36)
        Me.OutESC.Name = "OutESC"
        Me.OutESC.Size = New System.Drawing.Size(105, 20)
        Me.OutESC.TabIndex = 0
        Me.OutESC.Text = "Sali Con <Esc>"
        Me.OutESC.UseVisualStyleBackColor = True
        '
        'KeepUp
        '
        Me.KeepUp.AutoSize = True
        Me.KeepUp.Location = New System.Drawing.Point(10, 16)
        Me.KeepUp.Name = "KeepUp"
        Me.KeepUp.Size = New System.Drawing.Size(115, 20)
        Me.KeepUp.TabIndex = 0
        Me.KeepUp.Text = "Mantener Arriba"
        Me.KeepUp.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Polling)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Source)
        Me.GroupBox2.Controls.Add(Me.LineAjust)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(216, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 106)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Texto Recibido"
        '
        'Polling
        '
        Me.Polling.Location = New System.Drawing.Point(57, 24)
        Me.Polling.Name = "Polling"
        Me.Polling.Size = New System.Drawing.Size(39, 21)
        Me.Polling.TabIndex = 27
        Me.Polling.Text = "100"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(6, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Fuente"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(102, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "ms"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Polling"
        '
        'Source
        '
        Me.Source.FormattingEnabled = True
        Me.Source.Location = New System.Drawing.Point(57, 48)
        Me.Source.Name = "Source"
        Me.Source.Size = New System.Drawing.Size(67, 24)
        Me.Source.TabIndex = 20
        '
        'LineAjust
        '
        Me.LineAjust.AutoSize = True
        Me.LineAjust.Location = New System.Drawing.Point(9, 78)
        Me.LineAjust.Name = "LineAjust"
        Me.LineAjust.Size = New System.Drawing.Size(115, 20)
        Me.LineAjust.TabIndex = 0
        Me.LineAjust.Text = "Ajueste De Linea"
        Me.LineAjust.UseVisualStyleBackColor = True
        '
        'SP1_TX
        '
        Me.SP1_TX.Controls.Add(Me.EchoLocal)
        Me.SP1_TX.Controls.Add(Me.WithCRLF)
        Me.SP1_TX.Controls.Add(Me.WithLF)
        Me.SP1_TX.Controls.Add(Me.WithCR)
        Me.SP1_TX.Controls.Add(Me.WithNoting)
        Me.SP1_TX.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SP1_TX.ForeColor = System.Drawing.Color.White
        Me.SP1_TX.Location = New System.Drawing.Point(216, 55)
        Me.SP1_TX.Name = "SP1_TX"
        Me.SP1_TX.Size = New System.Drawing.Size(130, 129)
        Me.SP1_TX.TabIndex = 24
        Me.SP1_TX.TabStop = False
        Me.SP1_TX.Text = "Texto Transmitido"
        '
        'EchoLocal
        '
        Me.EchoLocal.AutoSize = True
        Me.EchoLocal.Location = New System.Drawing.Point(6, 94)
        Me.EchoLocal.Name = "EchoLocal"
        Me.EchoLocal.Size = New System.Drawing.Size(79, 20)
        Me.EchoLocal.TabIndex = 0
        Me.EchoLocal.Text = "Eco Local"
        Me.EchoLocal.UseVisualStyleBackColor = True
        '
        'WithCRLF
        '
        Me.WithCRLF.AutoSize = True
        Me.WithCRLF.Location = New System.Drawing.Point(6, 76)
        Me.WithCRLF.Name = "WithCRLF"
        Me.WithCRLF.Size = New System.Drawing.Size(101, 20)
        Me.WithCRLF.TabIndex = 0
        Me.WithCRLF.Text = "Agregar CR-LF"
        Me.WithCRLF.UseVisualStyleBackColor = True
        '
        'WithLF
        '
        Me.WithLF.AutoSize = True
        Me.WithLF.Location = New System.Drawing.Point(6, 56)
        Me.WithLF.Name = "WithLF"
        Me.WithLF.Size = New System.Drawing.Size(81, 20)
        Me.WithLF.TabIndex = 0
        Me.WithLF.Text = "Agregar LF"
        Me.WithLF.UseVisualStyleBackColor = True
        '
        'WithCR
        '
        Me.WithCR.AutoSize = True
        Me.WithCR.Location = New System.Drawing.Point(6, 36)
        Me.WithCR.Name = "WithCR"
        Me.WithCR.Size = New System.Drawing.Size(87, 20)
        Me.WithCR.TabIndex = 0
        Me.WithCR.Text = "Agregar CR"
        Me.WithCR.UseVisualStyleBackColor = True
        '
        'WithNoting
        '
        Me.WithNoting.AutoSize = True
        Me.WithNoting.Location = New System.Drawing.Point(6, 16)
        Me.WithNoting.Name = "WithNoting"
        Me.WithNoting.Size = New System.Drawing.Size(121, 20)
        Me.WithNoting.TabIndex = 0
        Me.WithNoting.Text = "No Agregar Nada"
        Me.WithNoting.UseVisualStyleBackColor = True
        '
        'SP1_Gb_Cfg
        '
        Me.SP1_Gb_Cfg.Controls.Add(Me.Label8)
        Me.SP1_Gb_Cfg.Controls.Add(Me.Redireccion)
        Me.SP1_Gb_Cfg.Controls.Add(Me.Label7)
        Me.SP1_Gb_Cfg.Controls.Add(Me.Label6)
        Me.SP1_Gb_Cfg.Controls.Add(Me.Label5)
        Me.SP1_Gb_Cfg.Controls.Add(Me.Label4)
        Me.SP1_Gb_Cfg.Controls.Add(Me.Label3)
        Me.SP1_Gb_Cfg.Controls.Add(Me.Label2)
        Me.SP1_Gb_Cfg.Controls.Add(Me.ContFlujo)
        Me.SP1_Gb_Cfg.Controls.Add(Me.Paridad)
        Me.SP1_Gb_Cfg.Controls.Add(Me.BitsStop)
        Me.SP1_Gb_Cfg.Controls.Add(Me.BitsDatos)
        Me.SP1_Gb_Cfg.Controls.Add(Me.Velocidad)
        Me.SP1_Gb_Cfg.Controls.Add(Me.Puerto)
        Me.SP1_Gb_Cfg.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SP1_Gb_Cfg.ForeColor = System.Drawing.Color.White
        Me.SP1_Gb_Cfg.Location = New System.Drawing.Point(26, 55)
        Me.SP1_Gb_Cfg.Name = "SP1_Gb_Cfg"
        Me.SP1_Gb_Cfg.Size = New System.Drawing.Size(184, 241)
        Me.SP1_Gb_Cfg.TabIndex = 25
        Me.SP1_Gb_Cfg.TabStop = False
        Me.SP1_Gb_Cfg.Text = "Configuracion Del Puerto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(13, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Redirección"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(13, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Cont De Flujo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(13, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Paridad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Bits De Stop"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Bits De Datos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Velocidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Puerto"
        '
        'ContFlujo
        '
        Me.ContFlujo.FormattingEnabled = True
        Me.ContFlujo.Location = New System.Drawing.Point(94, 169)
        Me.ContFlujo.Name = "ContFlujo"
        Me.ContFlujo.Size = New System.Drawing.Size(82, 24)
        Me.ContFlujo.TabIndex = 0
        '
        'Paridad
        '
        Me.Paridad.FormattingEnabled = True
        Me.Paridad.Location = New System.Drawing.Point(94, 140)
        Me.Paridad.Name = "Paridad"
        Me.Paridad.Size = New System.Drawing.Size(82, 24)
        Me.Paridad.TabIndex = 0
        '
        'BitsStop
        '
        Me.BitsStop.FormattingEnabled = True
        Me.BitsStop.Location = New System.Drawing.Point(94, 110)
        Me.BitsStop.Name = "BitsStop"
        Me.BitsStop.Size = New System.Drawing.Size(82, 24)
        Me.BitsStop.TabIndex = 0
        '
        'BitsDatos
        '
        Me.BitsDatos.FormattingEnabled = True
        Me.BitsDatos.Location = New System.Drawing.Point(94, 80)
        Me.BitsDatos.Name = "BitsDatos"
        Me.BitsDatos.Size = New System.Drawing.Size(82, 24)
        Me.BitsDatos.TabIndex = 0
        '
        'Velocidad
        '
        Me.Velocidad.FormattingEnabled = True
        Me.Velocidad.Location = New System.Drawing.Point(94, 50)
        Me.Velocidad.Name = "Velocidad"
        Me.Velocidad.Size = New System.Drawing.Size(82, 24)
        Me.Velocidad.TabIndex = 0
        '
        'Puerto
        '
        Me.Puerto.FormattingEnabled = True
        Me.Puerto.Location = New System.Drawing.Point(94, 20)
        Me.Puerto.Name = "Puerto"
        Me.Puerto.Size = New System.Drawing.Size(82, 24)
        Me.Puerto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Configuracion Del Puerto Serie"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.ColorRx, Me.ColorTx})
        Me.ShapeContainer1.Size = New System.Drawing.Size(536, 349)
        Me.ShapeContainer1.TabIndex = 27
        Me.ShapeContainer1.TabStop = False
        '
        'ColorRx
        '
        Me.ColorRx.BackColor = System.Drawing.Color.MediumBlue
        Me.ColorRx.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.ColorRx.Cursor = System.Windows.Forms.Cursors.Default
        Me.ColorRx.Location = New System.Drawing.Point(175, 312)
        Me.ColorRx.Name = "ColorRx"
        Me.ColorRx.Size = New System.Drawing.Size(20, 17)
        '
        'ColorTx
        '
        Me.ColorTx.BackColor = System.Drawing.Color.SeaGreen
        Me.ColorTx.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.ColorTx.Location = New System.Drawing.Point(80, 312)
        Me.ColorTx.Name = "ColorTx"
        Me.ColorTx.Size = New System.Drawing.Size(20, 17)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Label12"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(23, 314)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "DatosTX"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(117, 314)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "DatosRX"
        '
        'Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(536, 349)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.SP1_TX)
        Me.Controls.Add(Me.SP1_Gb_Cfg)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.maximizar)
        Me.Controls.Add(Me.minimizar)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Config"
        CType(Me.maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SP1_TX.ResumeLayout(False)
        Me.SP1_TX.PerformLayout()
        Me.SP1_Gb_Cfg.ResumeLayout(False)
        Me.SP1_Gb_Cfg.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents maximizar As PictureBox
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents cerrar As PictureBox
    Friend WithEvents ok As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents cancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Redireccion As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SP1_TX As GroupBox
    Friend WithEvents SP1_Gb_Cfg As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ContFlujo As ComboBox
    Friend WithEvents Paridad As ComboBox
    Friend WithEvents BitsStop As ComboBox
    Friend WithEvents BitsDatos As ComboBox
    Friend WithEvents Velocidad As ComboBox
    Friend WithEvents Puerto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ClosePortInact As CheckBox
    Friend WithEvents KeepHistory As CheckBox
    Friend WithEvents Autocomplete As CheckBox
    Friend WithEvents OutESC As CheckBox
    Friend WithEvents KeepUp As CheckBox
    Friend WithEvents Polling As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Source As ComboBox
    Friend WithEvents LineAjust As CheckBox
    Friend WithEvents EchoLocal As CheckBox
    Friend WithEvents WithCRLF As RadioButton
    Friend WithEvents WithLF As RadioButton
    Friend WithEvents WithCR As RadioButton
    Friend WithEvents WithNoting As RadioButton
    Friend WithEvents HexView As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LedStatus As CheckBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents ColorTx As PowerPacks.RectangleShape
    Friend WithEvents Label12 As Label
    Friend WithEvents ColorRx As PowerPacks.RectangleShape
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Color1 As ColorDialog
    Friend WithEvents Color2 As ColorDialog
End Class
