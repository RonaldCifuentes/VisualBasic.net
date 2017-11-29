<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LEDSCROLL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LEDSCROLL))
        Me.regresar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.enviar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.state = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.combo = New System.Windows.Forms.ComboBox()
        Me.SP1 = New System.IO.Ports.SerialPort(Me.components)
        Me.maximizar = New System.Windows.Forms.PictureBox()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.cerrar = New System.Windows.Forms.PictureBox()
        Me.Limpiar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Cnfg = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.tb2 = New System.Windows.Forms.RichTextBox()
        CType(Me.maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.regresar.Location = New System.Drawing.Point(412, 37)
        Me.regresar.Margin = New System.Windows.Forms.Padding(5)
        Me.regresar.Name = "regresar"
        Me.regresar.Size = New System.Drawing.Size(79, 44)
        Me.regresar.TabIndex = 0
        Me.regresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'enviar
        '
        Me.enviar.ActiveBorderThickness = 1
        Me.enviar.ActiveCornerRadius = 20
        Me.enviar.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.enviar.ActiveForecolor = System.Drawing.Color.White
        Me.enviar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.enviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.enviar.BackColor = System.Drawing.Color.Black
        Me.enviar.BackgroundImage = CType(resources.GetObject("enviar.BackgroundImage"), System.Drawing.Image)
        Me.enviar.ButtonText = "Enviar"
        Me.enviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enviar.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.enviar.ForeColor = System.Drawing.Color.SeaGreen
        Me.enviar.IdleBorderThickness = 1
        Me.enviar.IdleCornerRadius = 20
        Me.enviar.IdleFillColor = System.Drawing.Color.Transparent
        Me.enviar.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.enviar.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.enviar.Location = New System.Drawing.Point(396, 294)
        Me.enviar.Margin = New System.Windows.Forms.Padding(5)
        Me.enviar.Name = "enviar"
        Me.enviar.Size = New System.Drawing.Size(95, 44)
        Me.enviar.TabIndex = 0
        Me.enviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb1
        '
        Me.tb1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb1.BackColor = System.Drawing.Color.Black
        Me.tb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb1.ForeColor = System.Drawing.Color.White
        Me.tb1.Location = New System.Drawing.Point(33, 302)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(355, 29)
        Me.tb1.TabIndex = 5
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
        Me.state.Location = New System.Drawing.Point(131, 37)
        Me.state.Margin = New System.Windows.Forms.Padding(5)
        Me.state.Name = "state"
        Me.state.Size = New System.Drawing.Size(100, 44)
        Me.state.TabIndex = 11
        Me.state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'combo
        '
        Me.combo.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo.FormattingEnabled = True
        Me.combo.Location = New System.Drawing.Point(33, 45)
        Me.combo.Name = "combo"
        Me.combo.Size = New System.Drawing.Size(90, 29)
        Me.combo.TabIndex = 10
        '
        'SP1
        '
        '
        'maximizar
        '
        Me.maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.maximizar.Image = CType(resources.GetObject("maximizar.Image"), System.Drawing.Image)
        Me.maximizar.Location = New System.Drawing.Point(473, 12)
        Me.maximizar.Name = "maximizar"
        Me.maximizar.Size = New System.Drawing.Size(18, 17)
        Me.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.maximizar.TabIndex = 14
        Me.maximizar.TabStop = False
        '
        'minimizar
        '
        Me.minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimizar.Image = CType(resources.GetObject("minimizar.Image"), System.Drawing.Image)
        Me.minimizar.Location = New System.Drawing.Point(449, 12)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(18, 17)
        Me.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minimizar.TabIndex = 12
        Me.minimizar.TabStop = False
        '
        'cerrar
        '
        Me.cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cerrar.Image = CType(resources.GetObject("cerrar.Image"), System.Drawing.Image)
        Me.cerrar.Location = New System.Drawing.Point(497, 12)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(18, 17)
        Me.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cerrar.TabIndex = 13
        Me.cerrar.TabStop = False
        '
        'Limpiar
        '
        Me.Limpiar.ActiveBorderThickness = 1
        Me.Limpiar.ActiveCornerRadius = 20
        Me.Limpiar.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.Limpiar.ActiveForecolor = System.Drawing.Color.White
        Me.Limpiar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Limpiar.BackColor = System.Drawing.Color.Black
        Me.Limpiar.BackgroundImage = CType(resources.GetObject("Limpiar.BackgroundImage"), System.Drawing.Image)
        Me.Limpiar.ButtonText = "Limpiar"
        Me.Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Limpiar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpiar.ForeColor = System.Drawing.Color.SeaGreen
        Me.Limpiar.IdleBorderThickness = 1
        Me.Limpiar.IdleCornerRadius = 20
        Me.Limpiar.IdleFillColor = System.Drawing.Color.Transparent
        Me.Limpiar.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.Limpiar.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.Limpiar.Location = New System.Drawing.Point(324, 37)
        Me.Limpiar.Margin = New System.Windows.Forms.Padding(5)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(78, 44)
        Me.Limpiar.TabIndex = 0
        Me.Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cnfg
        '
        Me.Cnfg.ActiveBorderThickness = 1
        Me.Cnfg.ActiveCornerRadius = 20
        Me.Cnfg.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.Cnfg.ActiveForecolor = System.Drawing.Color.White
        Me.Cnfg.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.Cnfg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cnfg.BackColor = System.Drawing.Color.Black
        Me.Cnfg.BackgroundImage = CType(resources.GetObject("Cnfg.BackgroundImage"), System.Drawing.Image)
        Me.Cnfg.ButtonText = "Config"
        Me.Cnfg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cnfg.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cnfg.ForeColor = System.Drawing.Color.SeaGreen
        Me.Cnfg.IdleBorderThickness = 1
        Me.Cnfg.IdleCornerRadius = 20
        Me.Cnfg.IdleFillColor = System.Drawing.Color.Transparent
        Me.Cnfg.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.Cnfg.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.Cnfg.Location = New System.Drawing.Point(241, 37)
        Me.Cnfg.Margin = New System.Windows.Forms.Padding(5)
        Me.Cnfg.Name = "Cnfg"
        Me.Cnfg.Size = New System.Drawing.Size(78, 44)
        Me.Cnfg.TabIndex = 0
        Me.Cnfg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb2
        '
        Me.tb2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb2.BackColor = System.Drawing.Color.Black
        Me.tb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.tb2.ForeColor = System.Drawing.Color.White
        Me.tb2.Location = New System.Drawing.Point(33, 97)
        Me.tb2.Name = "tb2"
        Me.tb2.ReadOnly = True
        Me.tb2.Size = New System.Drawing.Size(355, 190)
        Me.tb2.TabIndex = 15
        Me.tb2.Text = ""
        '
        'LEDSCROLL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(527, 352)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.maximizar)
        Me.Controls.Add(Me.minimizar)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.state)
        Me.Controls.Add(Me.combo)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.enviar)
        Me.Controls.Add(Me.Cnfg)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.regresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LEDSCROLL"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PIXELDRAW"
        CType(Me.maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents regresar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents enviar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents tb1 As TextBox
    Friend WithEvents state As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents combo As ComboBox
    Friend WithEvents SP1 As IO.Ports.SerialPort
    Friend WithEvents maximizar As PictureBox
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents cerrar As PictureBox
    Friend WithEvents Limpiar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Cnfg As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents tb2 As RichTextBox
End Class
