<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PIXELDRAW
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PIXELDRAW))
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.cerrar = New System.Windows.Forms.PictureBox()
        Me.maximizar = New System.Windows.Forms.PictureBox()
        Me.regresar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.state = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.combo = New System.Windows.Forms.ComboBox()
        Me.SP1 = New System.IO.Ports.SerialPort(Me.components)
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.LimpPant = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lb0 = New System.Windows.Forms.Label()
        Me.Delay1 = New System.Windows.Forms.Timer(Me.components)
        Me.Delay2 = New System.Windows.Forms.Timer(Me.components)
        Me.lb1 = New System.Windows.Forms.Label()
        Me.lbx = New System.Windows.Forms.Label()
        Me.lby = New System.Windows.Forms.Label()
        Me.ledGreen = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.ledBlue = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Timer0 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'minimizar
        '
        Me.minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimizar.Image = CType(resources.GetObject("minimizar.Image"), System.Drawing.Image)
        Me.minimizar.Location = New System.Drawing.Point(622, 12)
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
        Me.cerrar.Location = New System.Drawing.Point(670, 12)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(18, 17)
        Me.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cerrar.TabIndex = 16
        Me.cerrar.TabStop = False
        '
        'maximizar
        '
        Me.maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.maximizar.Image = CType(resources.GetObject("maximizar.Image"), System.Drawing.Image)
        Me.maximizar.Location = New System.Drawing.Point(646, 12)
        Me.maximizar.Name = "maximizar"
        Me.maximizar.Size = New System.Drawing.Size(18, 17)
        Me.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.maximizar.TabIndex = 17
        Me.maximizar.TabStop = False
        '
        'regresar
        '
        Me.regresar.ActiveBorderThickness = 1
        Me.regresar.ActiveCornerRadius = 20
        Me.regresar.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.regresar.ActiveForecolor = System.Drawing.Color.White
        Me.regresar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.regresar.BackColor = System.Drawing.Color.Black
        Me.regresar.BackgroundImage = CType(resources.GetObject("regresar.BackgroundImage"), System.Drawing.Image)
        Me.regresar.ButtonText = "Regresar"
        Me.regresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.regresar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresar.ForeColor = System.Drawing.Color.SeaGreen
        Me.regresar.IdleBorderThickness = 1
        Me.regresar.IdleCornerRadius = 20
        Me.regresar.IdleFillColor = System.Drawing.Color.Transparent
        Me.regresar.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.regresar.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.regresar.Location = New System.Drawing.Point(545, 37)
        Me.regresar.Margin = New System.Windows.Forms.Padding(5)
        Me.regresar.Name = "regresar"
        Me.regresar.Size = New System.Drawing.Size(95, 44)
        Me.regresar.TabIndex = 18
        Me.regresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'state
        '
        Me.state.ActiveBorderThickness = 1
        Me.state.ActiveCornerRadius = 20
        Me.state.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.state.ActiveForecolor = System.Drawing.Color.White
        Me.state.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.state.BackColor = System.Drawing.Color.Black
        Me.state.BackgroundImage = CType(resources.GetObject("state.BackgroundImage"), System.Drawing.Image)
        Me.state.ButtonText = "Conectar"
        Me.state.Cursor = System.Windows.Forms.Cursors.Hand
        Me.state.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.state.ForeColor = System.Drawing.Color.SeaGreen
        Me.state.IdleBorderThickness = 1
        Me.state.IdleCornerRadius = 20
        Me.state.IdleFillColor = System.Drawing.Color.Transparent
        Me.state.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.state.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.state.Location = New System.Drawing.Point(130, 37)
        Me.state.Margin = New System.Windows.Forms.Padding(5)
        Me.state.Name = "state"
        Me.state.Size = New System.Drawing.Size(111, 44)
        Me.state.TabIndex = 20
        Me.state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'combo
        '
        Me.combo.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo.FormattingEnabled = True
        Me.combo.Location = New System.Drawing.Point(32, 45)
        Me.combo.Name = "combo"
        Me.combo.Size = New System.Drawing.Size(90, 29)
        Me.combo.TabIndex = 19
        '
        'SP1
        '
        '
        'pb1
        '
        Me.pb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb1.Location = New System.Drawing.Point(30, 90)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(640, 320)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pb1.TabIndex = 21
        Me.pb1.TabStop = False
        '
        'LimpPant
        '
        Me.LimpPant.ActiveBorderThickness = 1
        Me.LimpPant.ActiveCornerRadius = 20
        Me.LimpPant.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.LimpPant.ActiveForecolor = System.Drawing.Color.White
        Me.LimpPant.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.LimpPant.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LimpPant.BackColor = System.Drawing.Color.Black
        Me.LimpPant.BackgroundImage = CType(resources.GetObject("LimpPant.BackgroundImage"), System.Drawing.Image)
        Me.LimpPant.ButtonText = "Limpiar Pantalla"
        Me.LimpPant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LimpPant.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LimpPant.ForeColor = System.Drawing.Color.SeaGreen
        Me.LimpPant.IdleBorderThickness = 1
        Me.LimpPant.IdleCornerRadius = 20
        Me.LimpPant.IdleFillColor = System.Drawing.Color.Transparent
        Me.LimpPant.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.LimpPant.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.LimpPant.Location = New System.Drawing.Point(291, 428)
        Me.LimpPant.Margin = New System.Windows.Forms.Padding(5)
        Me.LimpPant.Name = "LimpPant"
        Me.LimpPant.Size = New System.Drawing.Size(119, 58)
        Me.LimpPant.TabIndex = 22
        Me.LimpPant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb0
        '
        Me.lb0.AutoSize = True
        Me.lb0.ForeColor = System.Drawing.Color.White
        Me.lb0.Location = New System.Drawing.Point(344, 45)
        Me.lb0.Name = "lb0"
        Me.lb0.Size = New System.Drawing.Size(17, 13)
        Me.lb0.TabIndex = 23
        Me.lb0.Text = "X:"
        '
        'Delay1
        '
        Me.Delay1.Enabled = True
        Me.Delay1.Interval = 1
        '
        'Delay2
        '
        Me.Delay2.Interval = 1
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.ForeColor = System.Drawing.Color.White
        Me.lb1.Location = New System.Drawing.Point(344, 61)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(17, 13)
        Me.lb1.TabIndex = 23
        Me.lb1.Text = "Y:"
        '
        'lbx
        '
        Me.lbx.AutoSize = True
        Me.lbx.ForeColor = System.Drawing.Color.White
        Me.lbx.Location = New System.Drawing.Point(367, 45)
        Me.lbx.Name = "lbx"
        Me.lbx.Size = New System.Drawing.Size(0, 13)
        Me.lbx.TabIndex = 23
        '
        'lby
        '
        Me.lby.AutoSize = True
        Me.lby.ForeColor = System.Drawing.Color.White
        Me.lby.Location = New System.Drawing.Point(367, 61)
        Me.lby.Name = "lby"
        Me.lby.Size = New System.Drawing.Size(0, 13)
        Me.lby.TabIndex = 23
        '
        'ledGreen
        '
        Me.ledGreen.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ledGreen.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ledGreen.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ledGreen.Location = New System.Drawing.Point(250, 43)
        Me.ledGreen.Name = "ledGreen"
        Me.ledGreen.Size = New System.Drawing.Size(41, 31)
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(153, 445)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "DibMat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb1
        '
        Me.tb1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tb1.Location = New System.Drawing.Point(81, 445)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(30, 20)
        Me.tb1.TabIndex = 26
        Me.tb1.Text = "0"
        '
        'tb2
        '
        Me.tb2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tb2.Location = New System.Drawing.Point(117, 445)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(30, 20)
        Me.tb2.TabIndex = 26
        Me.tb2.Text = "0"
        '
        'ledBlue
        '
        Me.ledBlue.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ledBlue.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ledBlue.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ledBlue.Location = New System.Drawing.Point(296, 42)
        Me.ledBlue.Name = "ledBlue"
        Me.ledBlue.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ledBlue.Size = New System.Drawing.Size(41, 32)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.ledBlue, Me.ledGreen})
        Me.ShapeContainer1.Size = New System.Drawing.Size(700, 500)
        Me.ShapeContainer1.TabIndex = 28
        Me.ShapeContainer1.TabStop = False
        '
        'Timer0
        '
        Me.Timer0.Interval = 1
        '
        'PIXELDRAW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(700, 500)
        Me.Controls.Add(Me.lb0)
        Me.Controls.Add(Me.lbx)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.lby)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.combo)
        Me.Controls.Add(Me.LimpPant)
        Me.Controls.Add(Me.regresar)
        Me.Controls.Add(Me.state)
        Me.Controls.Add(Me.maximizar)
        Me.Controls.Add(Me.minimizar)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PIXELDRAW"
        Me.Opacity = 0.75R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "+"
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents cerrar As PictureBox
    Friend WithEvents maximizar As PictureBox
    Friend WithEvents regresar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents state As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents combo As ComboBox
    Friend WithEvents SP1 As IO.Ports.SerialPort
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents LimpPant As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lb0 As Label
    Friend WithEvents Delay1 As Timer
    Friend WithEvents Delay2 As Timer
    Friend WithEvents lb1 As Label
    Friend WithEvents lbx As Label
    Friend WithEvents lby As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tb1 As TextBox
    Friend WithEvents tb2 As TextBox
    Friend WithEvents ledGreen As PowerPacks.RectangleShape
    Friend WithEvents ledBlue As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Timer0 As Timer
End Class
