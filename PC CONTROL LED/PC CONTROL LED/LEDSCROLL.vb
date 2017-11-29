Imports System.Drawing
Imports System.IO.Ports

Public Class LEDSCROLL


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

    Private Sub LEDSCROLL_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

    End Sub

#End Region


#Region "RS232"


    Dim BufferRX As String
    Dim offset As Integer
    Dim count As Integer
    Dim ComPortSelected As Integer
    Dim condition As Integer = 0




    'VERIFICA LOS PUERTOS DISPONIBLES Y LOS ENVIA AL COMBOBOX 
    Public Sub ObtenerPuertosDisponibles()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            combo.Items.Add(sp)
        Next sp
        combo.SelectedIndex = 0
        SP1.Open()
        state.ButtonText = "Desconectar"
    End Sub

    'CARGAR PUERTO SELECCIONADO AL SERIALPORTNAME
    Private Sub combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo.SelectedIndexChanged
        Try
            SP1.PortName = combo.Items.Item(combo.SelectedIndex)
            ComPortSelected = combo.SelectedIndex
        Catch ex As Exception
            combo.SelectedIndex = ComPortSelected
            MsgBox("Desconecte Primero el puerto")
        End Try
    End Sub

    'CONECTA O DESCONECTA A UN PUERTO SELECCIONADO
    Private Sub state_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles state.Click

        Try
            If state.ButtonText = "Conectar" Then
                SP1.Open()
                state.ButtonText = "Desconectar"
            ElseIf state.ButtonText = "Desconectar" Then
                SP1.DiscardInBuffer()
                SP1.Dispose()
                SP1.Close()
                state.ButtonText = "Conectar"
            End If
        Catch ex As Exception
            MsgBox("Este Puerto Está Ocupado")
            'MsgBox(ex.ToString)
        End Try
    End Sub



    'FUNCIONES PARA LEER

    'Funcion De Recepción
    Private Sub SP1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SP1.DataReceived
        BufferRX = SP1.ReadExisting
        Me.Invoke(dirPrint, BufferRX) 'Pasar BufferRX como argumento del metodo delegado
    End Sub

    'Creación e instanciado del delegado
    Delegate Sub DataDelegate(ByVal Buff As String)
    Dim dirPrint As New DataDelegate(AddressOf PrintData)

    'Función delegada
    Private Sub PrintData(ByVal Buff As String)
        tb2.SelectionColor = My.Settings.ColorSave2
        tb2.SelectedText = Buff
    End Sub



    'FUNCIÓN PARA ESCRIBIR
    Private Sub env()
        If SP1.IsOpen() Then
            tb2.SelectionColor = My.Settings.ColorSave1

            If condition Then
                tb2.SelectedText = tb1.Text
            Else
                If My.Settings.EcoLocal = True Then

                    If My.Settings.WithNoting Then
                        SP1.Write(tb1.Text)
                        tb2.SelectedText = tb1.Text
                    End If
                    If My.Settings.WithCR Then
                        SP1.Write(tb1.Text & vbCr)
                        tb2.SelectedText = tb1.Text & vbCrLf
                    End If
                    If My.Settings.WithLF Then
                        SP1.Write(tb1.Text & vbLf)
                        tb2.SelectedText = tb1.Text & vbCrLf
                    End If
                    If My.Settings.WithCRLF Then
                        SP1.Write(tb1.Text & vbCrLf)
                        tb2.SelectedText = tb1.Text & vbCrLf
                    End If
                Else
                    If My.Settings.WithNoting Then
                        SP1.Write(tb1.Text)
                    End If
                    If My.Settings.WithCR Then
                        SP1.Write(tb1.Text & vbCr)
                    End If
                    If My.Settings.WithLF Then
                        SP1.Write(tb1.Text & vbLf)
                    End If
                    If My.Settings.WithCRLF Then
                        SP1.Write(tb1.Text & vbCrLf)
                    End If
                End If
            End If
            condition = False

            tb1.Clear()
            Else
                MsgBox("NO ESTAS CONECTADO")
        End If
    End Sub

    Private Sub enviar_Click(sender As Object, e As EventArgs) Handles enviar.Click
        env()
    End Sub

    Private Sub tb1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            env()
        End If
    End Sub


#End Region

#Region "VARIABLES"

    Dim x, y As Integer
    Dim coor As Point

#End Region


#Region "MAIN"

    Private Sub PIXELDRAW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerPuertosDisponibles() 'CARGAR PUERTOS COM
    End Sub

    Private Sub LEDSCROLL_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub LEDSCROLL_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        If e.Button = MouseButtons.Left Then
            coor = Control.MousePosition
            coor.x -= x
            coor.y -= y
            Me.Location = coor
        End If

    End Sub



#End Region


#Region "BOTONES DE PRIMER ORNDEN"

    Private Sub regresar_Click(sender As Object, e As EventArgs) Handles regresar.Click
        HOME.Show()
        SP1.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        tb2.Clear()
    End Sub

    Private Sub Config_Click(sender As Object, e As EventArgs) Handles Cnfg.Click
        Config.Show()
        Config.Puerto.SelectedIndex = combo.SelectedIndex

    End Sub

    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged

        'SEGUIR EL SCROLL
        If My.Settings.KeepUp = False Then
            tb2.Select(tb2.Text.Length, 0)
            tb2.ScrollToCaret()
        End If

    End Sub





#End Region


End Class