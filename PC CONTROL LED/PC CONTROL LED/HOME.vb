Public Class HOME


#Region "VARIABLES"


    Private x, y As Integer
    Private coor As Point



#End Region


#Region "BOTONES BASICOS"


    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub maximizar_Click(sender As Object, e As EventArgs) Handles maximizar.Click
        If WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub HOME_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        btn_PixelDraw.Height = (Me.Height / 2) - 100
        btn_TextScroll.Height = (Me.Height / 2) - 100
        btn_PixelDraw.Width = Me.Width - 278
        btn_TextScroll.Width = Me.Width - 278

        btn_TextScroll.Top = btn_PixelDraw.Top + btn_PixelDraw.Height + 10
        Lb1.Top = Me.Height - 20
        Lb2.Top = Me.Height - 70

    End Sub

#End Region


#Region "MAIN"

    Private Sub HOME_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub


    Private Sub HOME_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            coor = Control.MousePosition
            coor.X -= x
            coor.Y -= y
            Me.Location = coor
        End If
    End Sub

    Private Sub btn_PixelDraw_MouseUp(sender As Object, e As EventArgs) Handles btn_PixelDraw.MouseUp
        PIXELDRAW.Show()
        Me.Close()
    End Sub

    Private Sub btn_TextScroll_MouseUp(sender As Object, e As EventArgs) Handles btn_TextScroll.MouseUp
        LEDSCROLL.Show()
        Me.Close()
    End Sub

#End Region


End Class
