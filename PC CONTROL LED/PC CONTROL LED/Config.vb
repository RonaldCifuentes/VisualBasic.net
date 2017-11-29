Public Class Config


#Region "BOTONES BASICOS"


    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        My.Settings.Reload()
        LEDSCROLL.Show()
        Me.Close()
    End Sub

#End Region

#Region "VARIABLES"

    Dim x, y As Integer
    Dim coor As Point

    Dim ComSelected As Integer
    Dim state As Integer = 1

#End Region

#Region "BOTONES DE ORDEN 1"

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click

        'CONFIGURACION DEL PUERTO

        'Desconectar El Puerto
        LEDSCROLL.SP1.Close()

        'Puertos Disponibles
        LEDSCROLL.combo.SelectedIndex = Puerto.SelectedIndex
        LEDSCROLL.SP1.PortName = LEDSCROLL.combo.Items.Item(Puerto.SelectedIndex)

        'Abrir Puerto
        Try
            LEDSCROLL.SP1.Open()
            state = 1
        Catch ex As Exception
            state = 0
            MsgBox("Este Puerto Está Ocupado")
        End Try

        '
        If state = 1 Then
            LEDSCROLL.state.ButtonText = "Desconectar"
        Else
            LEDSCROLL.state.ButtonText = "Conectar"
        End If


        'TEXTO TRANSMITIDO
        My.Settings.WithNoting = Me.WithNoting.Checked
        My.Settings.WithCR = Me.WithCR.Checked
        My.Settings.WithLF = Me.WithLF.Checked
        My.Settings.WithCRLF = Me.WithCRLF.Checked
        My.Settings.EcoLocal = Me.EchoLocal.Checked

        'TEXTO RECIVIDO


        'OPCIONES
        My.Settings.KeepUp = Me.KeepUp.Checked
        My.Settings.OutEsc = Me.OutESC.Checked
        My.Settings.Autocomplete = Me.Autocomplete.Checked
        My.Settings.KeepHistory = Me.KeepHistory.Checked
        My.Settings.ClosePortInact = Me.ClosePortInact.Checked


        'HERRAMIENTAS


        'VOLVER ATRAS
        My.Settings.Save()
        LEDSCROLL.Show()
        Me.Close()

    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        My.Settings.Reload()
        LEDSCROLL.Show()
        Me.Close()
    End Sub

#End Region


#Region "MAIN"

    'FORM LOAD
    Private Sub Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarValoresIniciales()

    End Sub

    'MOUSE PRESIONADO SOBRE FORM
    Private Sub Config_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Puerto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Puerto.SelectedIndexChanged

    End Sub

    'MOUSE PRESIONADO Y MOVIENDOSE SOBRE FORM
    Private Sub Config_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button Then
            coor = Control.MousePosition
            coor.X -= x
            coor.Y -= y
            Me.Location = coor
        End If
    End Sub


    Private Sub ColorTx_Click(sender As Object, e As EventArgs) Handles ColorTx.Click
        If Color1.ShowDialog() = DialogResult.OK Then
            My.Settings.ColorSave1 = Color1.Color
            ColorTx.BackColor = Color1.Color
        End If
    End Sub

    Private Sub ColorRx_Click(sender As Object, e As EventArgs) Handles ColorRx.Click
        If Color2.ShowDialog() = DialogResult.OK Then
            My.Settings.ColorSave2 = Color2.Color
            ColorRx.BackColor = Color2.Color
        End If
    End Sub

#End Region


#Region "FUNCIONES"

#Region "CONFIGURACION DEL PUERTO SERIE"

    Private Sub CargarValoresIniciales()

        'CONFIGURACION DEL PUERTO
        For Each sp As String In LEDSCROLL.combo.Items
            Puerto.Items.Add(sp)
        Next sp
        Puerto.SelectedIndex = 0


        Velocidad.Items.Add("75")
        Velocidad.Items.Add("110")
        Velocidad.Items.Add("300")
        Velocidad.Items.Add("1200")
        Velocidad.Items.Add("2400")
        Velocidad.Items.Add("4800")
        Velocidad.Items.Add("9600")
        Velocidad.Items.Add("19200")
        Velocidad.Items.Add("38400")
        Velocidad.Items.Add("57600")
        Velocidad.Items.Add("115200")
        Velocidad.SelectedItem = LEDSCROLL.SP1.BaudRate.ToString

        'TEXTO TRANSMITIDO
        Me.WithNoting.Checked = My.Settings.WithNoting
        Me.WithCR.Checked = My.Settings.WithCR
        Me.WithLF.Checked = My.Settings.WithLF
        Me.WithCRLF.Checked = My.Settings.WithCRLF
        Me.EchoLocal.Checked = My.Settings.EcoLocal

        'TEXTO RECIVIDO

        'OPCIONES
        Me.KeepUp.Checked = My.Settings.KeepUp
        Me.OutESC.Checked = My.Settings.OutEsc
        Me.Autocomplete.Checked = My.Settings.Autocomplete
        Me.KeepHistory.Checked = My.Settings.KeepHistory
        Me.ClosePortInact.Checked = My.Settings.ClosePortInact

        'HERRAMIENTAS

        'DATA COLOR
        ColorTx.BackColor = My.Settings.ColorSave1
        ColorRx.BackColor = My.Settings.ColorSave2
    End Sub

#End Region

#End Region



End Class