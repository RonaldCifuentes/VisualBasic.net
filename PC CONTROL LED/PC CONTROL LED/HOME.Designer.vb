<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HOME
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOME))
        Me.btn_PixelDraw = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_TextScroll = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cerrar = New System.Windows.Forms.PictureBox()
        Me.Lb1 = New System.Windows.Forms.Label()
        Me.Lb2 = New System.Windows.Forms.Label()
        Me.maximizar = New System.Windows.Forms.PictureBox()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.lb0 = New System.Windows.Forms.Label()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_PixelDraw
        '
        Me.btn_PixelDraw.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_PixelDraw.AutoSize = True
        Me.btn_PixelDraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_PixelDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_PixelDraw.BorderRadius = 0
        Me.btn_PixelDraw.ButtonText = "Dibujar Pixeles"
        Me.btn_PixelDraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_PixelDraw.DisabledColor = System.Drawing.Color.Gray
        Me.btn_PixelDraw.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_PixelDraw.Iconimage = CType(resources.GetObject("btn_PixelDraw.Iconimage"), System.Drawing.Image)
        Me.btn_PixelDraw.Iconimage_right = Nothing
        Me.btn_PixelDraw.Iconimage_right_Selected = Nothing
        Me.btn_PixelDraw.Iconimage_Selected = Nothing
        Me.btn_PixelDraw.IconMarginLeft = 0
        Me.btn_PixelDraw.IconMarginRight = 0
        Me.btn_PixelDraw.IconRightVisible = True
        Me.btn_PixelDraw.IconRightZoom = 0R
        Me.btn_PixelDraw.IconVisible = True
        Me.btn_PixelDraw.IconZoom = 90.0R
        Me.btn_PixelDraw.IsTab = False
        Me.btn_PixelDraw.Location = New System.Drawing.Point(131, 111)
        Me.btn_PixelDraw.Name = "btn_PixelDraw"
        Me.btn_PixelDraw.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_PixelDraw.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_PixelDraw.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_PixelDraw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_PixelDraw.selected = False
        Me.btn_PixelDraw.Size = New System.Drawing.Size(237, 49)
        Me.btn_PixelDraw.TabIndex = 0
        Me.btn_PixelDraw.Text = "Dibujar Pixeles"
        Me.btn_PixelDraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_PixelDraw.Textcolor = System.Drawing.Color.White
        Me.btn_PixelDraw.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_TextScroll
        '
        Me.btn_TextScroll.Activecolor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_TextScroll.AutoSize = True
        Me.btn_TextScroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_TextScroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_TextScroll.BorderRadius = 0
        Me.btn_TextScroll.ButtonText = "Desplazar Texto"
        Me.btn_TextScroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_TextScroll.DisabledColor = System.Drawing.Color.Gray
        Me.btn_TextScroll.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_TextScroll.Iconimage = CType(resources.GetObject("btn_TextScroll.Iconimage"), System.Drawing.Image)
        Me.btn_TextScroll.Iconimage_right = Nothing
        Me.btn_TextScroll.Iconimage_right_Selected = Nothing
        Me.btn_TextScroll.Iconimage_Selected = Nothing
        Me.btn_TextScroll.IconMarginLeft = 0
        Me.btn_TextScroll.IconMarginRight = 0
        Me.btn_TextScroll.IconRightVisible = True
        Me.btn_TextScroll.IconRightZoom = 0R
        Me.btn_TextScroll.IconVisible = True
        Me.btn_TextScroll.IconZoom = 90.0R
        Me.btn_TextScroll.IsTab = False
        Me.btn_TextScroll.Location = New System.Drawing.Point(131, 165)
        Me.btn_TextScroll.Name = "btn_TextScroll"
        Me.btn_TextScroll.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_TextScroll.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btn_TextScroll.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_TextScroll.selected = False
        Me.btn_TextScroll.Size = New System.Drawing.Size(235, 49)
        Me.btn_TextScroll.TabIndex = 0
        Me.btn_TextScroll.Text = "Desplazar Texto"
        Me.btn_TextScroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_TextScroll.Textcolor = System.Drawing.Color.White
        Me.btn_TextScroll.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cerrar
        '
        Me.cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cerrar.Image = CType(resources.GetObject("cerrar.Image"), System.Drawing.Image)
        Me.cerrar.Location = New System.Drawing.Point(469, 12)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(18, 17)
        Me.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cerrar.TabIndex = 1
        Me.cerrar.TabStop = False
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.ForeColor = System.Drawing.Color.White
        Me.Lb1.Location = New System.Drawing.Point(12, 302)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(113, 13)
        Me.Lb1.TabIndex = 4
        Me.Lb1.Text = "Diseños Extrasensorial"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.ForeColor = System.Drawing.Color.White
        Me.Lb2.Location = New System.Drawing.Point(8, 254)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(127, 39)
        Me.Lb2.TabIndex = 5
        Me.Lb2.Text = "Gacipe"
        '
        'maximizar
        '
        Me.maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.maximizar.Image = CType(resources.GetObject("maximizar.Image"), System.Drawing.Image)
        Me.maximizar.Location = New System.Drawing.Point(445, 12)
        Me.maximizar.Name = "maximizar"
        Me.maximizar.Size = New System.Drawing.Size(18, 17)
        Me.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.maximizar.TabIndex = 6
        Me.maximizar.TabStop = False
        '
        'minimizar
        '
        Me.minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimizar.Image = CType(resources.GetObject("minimizar.Image"), System.Drawing.Image)
        Me.minimizar.Location = New System.Drawing.Point(421, 12)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(18, 17)
        Me.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minimizar.TabIndex = 1
        Me.minimizar.TabStop = False
        '
        'lb0
        '
        Me.lb0.AutoSize = True
        Me.lb0.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb0.ForeColor = System.Drawing.Color.White
        Me.lb0.Location = New System.Drawing.Point(12, 12)
        Me.lb0.Name = "lb0"
        Me.lb0.Size = New System.Drawing.Size(307, 40)
        Me.lb0.TabIndex = 7
        Me.lb0.Text = "LED CONTROL PC"
        '
        'HOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(499, 324)
        Me.Controls.Add(Me.lb0)
        Me.Controls.Add(Me.maximizar)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.minimizar)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.btn_TextScroll)
        Me.Controls.Add(Me.btn_PixelDraw)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HOME"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_PixelDraw As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_TextScroll As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cerrar As PictureBox
    Friend WithEvents Lb1 As Label
    Friend WithEvents Lb2 As Label
    Friend WithEvents maximizar As PictureBox
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents lb0 As Label
End Class
