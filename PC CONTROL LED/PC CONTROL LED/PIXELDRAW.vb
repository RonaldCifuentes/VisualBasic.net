Imports System.ComponentModel
Imports System.Drawing
Imports System.IO.Ports
Imports System.Windows
Public Class PIXELDRAW

#Region "BOTONES BASICOS"

    'BOTON MINIMIZAR
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'BOTON MAXIMIZAR
    Private Sub maximizar_Click(sender As Object, e As EventArgs) Handles maximizar.Click
        If WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub


    'BOTON CERRAR
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    'BOTON REGRESAR
    Private Sub regresar_Click(sender As Object, e As EventArgs) Handles regresar.Click
        HOME.Show()
        SP1.Close()
        Me.Close()
        Me.Dispose()
    End Sub

#End Region


#Region "VARIABLES"

    'VARIABLES GRAFICASS
    Dim G As Graphics
    Dim BM As Bitmap
    Dim r As Rectangle

    'PROGRAMA CORRIENDO?
    Dim IsRunning As Boolean = True


    'VARIABLES DE POSISIONAMIENTO
    Dim coor As Point
    Dim x, y As Integer

    Dim MouseX As Integer  'Coordenadas Pixeles X
    Dim MouseY As Integer  'Coordenadas Pixeles Y
    Dim mpx As Integer
    Dim mpy As Integer



    'VARIABLES DE CONTROL
    Dim a, b As Integer 'Banderas De Click Izq o Der Presionados y En Movimiento
    Dim DatachangeX As Integer = 0
    Dim DatachangeY As Integer = 0
    Dim DX As Integer = 0
    Dim DY As Integer = 0
    Dim cnt1 As Integer = 0
    Dim cnt2 As Integer = 0
    Dim condition(4) As Integer


    'VARIABLES DE TAMAÑO
    'Dim TC As Integer = 20
    Dim NTilesH As Integer = 32 'Numero De Cuadros En Sentido Horizontal
    Dim NTilesV As Integer = 16 'Numero De Cuadros En Sentido Vertical
    Dim PaddingWidth As Integer = 60
    Dim PaddingHeight As Integer = 180
    Dim LHC As Integer = Math.Floor((Me.Width - PaddingWidth) / NTilesH) 'Longitud Horizontal Cuadros
    Dim LVC As Integer = Math.Floor((Me.Height - PaddingHeight) / NTilesV) 'Longitud Vertical Cuadros

    'VARIABLES DE ALMACENAMIENTO
    Dim BufferRx As String
    Dim BufferTx As String
    Dim ArrayCoor(NTilesV) As Int32
    Dim DisplayVirtual(NTilesH, NTilesV) As Boolean

#End Region


#Region "RS232"



    Dim ComPortSelected As Integer



    'VERIFICA LOS PUERTOS DISPONIBLES Y LOS ENVIA AL COMBOBOX 
    Sub ObtenerPuertosDisponibles()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            combo.Items.Add(sp)
        Next sp
        combo.SelectedIndex = 0
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
                SP1.Write("DIBUJAR_ON" & vbCr)
            ElseIf state.ButtonText = "Desconectar" Then
                SP1.Write("DIBUJAR_OFF" & vbCr)
            End If
        Catch ex As Exception
            MsgBox("Este Puerto Está Ocupado")
            'MsgBox(ex.ToString)
        End Try
    End Sub


    'FUNCIONES PARA LEER

    'Funcion De Recepción
    Private Sub SP1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SP1.DataReceived
        BufferRx = SP1.ReadExisting
        Me.Invoke(dirPrint, BufferRx) 'Pasar BufferRX como argumento del metodo delegado
    End Sub

    'Creación e instanciado del delegado
    Delegate Sub DataDelegate(ByVal Buff As String)
    Dim dirPrint As New DataDelegate(AddressOf PrintData)

    'Función delegada
    Private Sub PrintData(ByVal Buff As String)

        If String.Compare("DIBUJADO_ON" & vbCr, Buff) Then
            state.ButtonText = "Desconectar"
            ledGreen.FillColor = Color.Lime
        End If
        If String.Compare("DIBUJADO_OFF" & vbCr, Buff) Then
            state.ButtonText = "Conectar"
            Timer0.Enabled = True
            Timer0.Start()
            ledGreen.FillColor = Color.FromArgb(0, 64, 0)
        End If
    End Sub







#End Region


#Region "TEMPORIZADORES"

    'RETARDO DE MUESTREO DE LAS COORDENADAS
    Private Sub Delay1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delay1.Tick
        'lbx.Text = MousePosition.X : lby.Text = MousePosition.Y
        lbx.Text = MouseX : lby.Text = MouseY
        mpx = MousePosition.X : mpy = MousePosition.Y
    End Sub

    Private Sub Delay2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delay2.Tick
        Try
            SP1.Write(1)
            Delay2.Stop()
            Delay2.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer0_Tick(sender As Object, e As EventArgs) Handles Timer0.Tick
        SP1.Close()
        SP1.Dispose()
        Timer0.Stop()
        Timer0.Enabled = False
        state.ButtonText = "Conectar"
    End Sub


#End Region


#Region "MAIN"

    'FORM LOAD
    Private Sub PIXELDRAW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
        G = pb1.CreateGraphics

    End Sub

    'MOUSE PRESIONADO SOBRE FORM
    Private Sub PIXELDRAW_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    'MOUSE PRESIONADO Y MOVIENDOSE SOBRE FORM
    Private Sub PIXELDRAW_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            coor = Control.MousePosition
            coor.X -= x
            coor.Y -= y
            Me.Location = coor
        End If
    End Sub

    'REDIMENSIONAMIENTO DE LA VENTANA
    Private Sub PIXELDRAW_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        LHC = Math.Floor((Me.Width - PaddingWidth) / NTilesH)   'Restar la distancia que hay entre la ventana y el picturebox y el resultado dividirlo entre el numero de cuadros para obtener la longitud horizontal del cuadrado, floor es el promedio inferior
        LVC = Math.Floor((Me.Height - PaddingHeight) / NTilesV) 'Restar la distancia que hay entre la ventana y el picturebox y el resultado dividirlo entre el numero de cuadros para obtener la longitud vertical del cuadrado, floor es el promedio inferior
        pb1.Width = LHC * NTilesH               'calcular el ancho del picturebox apartir de la longitud horizontal del cuadrado multiplicado por el numero de cuadrados
        pb1.Height = LVC * NTilesV              'calcular el alto del picturebox aparetir de la longitud vertical del cuadrado muliplicado por el numero de cuadrados

        DibujarImagenIni()

    End Sub

#End Region


#Region "PICTUREBOX"

    'MOUSE PRESIONADO
    Private Sub pb1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb1.MouseDown
        If e.Button = MouseButtons.Left Then                'Verificar Si El Boton Presionado Es El izquierdo
            If a = 0 Then                                   'Si Bandera Izq = 1, Encender Led, Dibujar cuadrado, enviar datos
                ledBlue.FillColor = Color.Blue                  'Encender led
                draw((MouseX * LHC) - 2, (MouseY * LVC) - 2) 'Dibujar Cuadrado
                DisplayVirtual(MouseX, MouseY) = 1
                a = 1                                       'Encender Bandera
            End If
            Delay2.Enabled = True
            Delay2.Start()
        ElseIf e.Button = MouseButtons.Right Then           'Verificar Si El Boton Presionado Es El Derecho
            If a = 0 Then
                ledBlue.FillColor = Color.Blue                  'Encender led
                clear((MouseX * LHC) - 2, (MouseY * LVC) - 2) 'Borrar Cuadrado
                DisplayVirtual(MouseX, MouseY) = 0
                b = 1                                       'Encender Bandera
            End If
            Delay2.Enabled = True
            Delay2.Start()
        End If
    End Sub

    'MOUSE MOVIENDOSE
    Private Sub pb1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb1.MouseMove
        MouseX = Math.Floor(e.X / LHC)
        MouseY = Math.Floor(e.Y / LVC)

        If a = 1 Then
            If MouseX >= 0 And MouseX < NTilesH And MouseY >= 0 And MouseY < NTilesV Then
                draw((MouseX * LHC) - 2, (MouseY * LVC) - 2) 'Dibujar Cuadrado
                DisplayVirtual(MouseX, MouseY) = 1
            End If
            Delay2.Enabled = True
            Delay2.Start()
        End If
        If b = 1 Then
            If MouseX >= 0 And MouseX < NTilesH And MouseY >= 0 And MouseY < NTilesV Then
                clear((MouseX * LHC) - 2, (MouseY * LVC) - 2) 'Borrar Cuadrado
                DisplayVirtual(MouseX, MouseY) = 0
            End If
            Delay2.Enabled = True
            Delay2.Start()
        End If
    End Sub

    'MOUSE SUELTO
    Private Sub pb1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb1.MouseUp
        If a = 1 Or b = 1 Then                  'Si El Click Izq o El Der Fueron Soltados Apagar Led
            Delay2.Enabled = True
            Delay2.Start()
            ledBlue.FillColor = Color.MidnightBlue  'Apagar Led
            a = 0                               'Reiniciar Bandera Click Izq
            b = 0                               'Reiniciar Bandera Click Der
        End If
        'MsgBox(MouseX.ToString & "," & MouseY.ToString, MsgBoxStyle.Information)
    End Sub

    Private Sub LimpPant_Click(sender As Object, e As EventArgs) Handles LimpPant.Click
        For i = 0 To (NTilesH - 1)
            For j = 0 To (NTilesV - 1)
                DisplayVirtual(i, j) = 0
            Next
        Next

        DibujarImagenIni()

        pb1.Refresh()
    End Sub



#End Region


#Region "FUNCIONES"

    Private Sub inicializar()
        Delay1.Start()
        Delay2.Stop()
        ObtenerPuertosDisponibles()
    End Sub

    'DIBUJAR IMAGEN INICIAL DEL PICTUREBOX
    Private Sub DibujarImagenIni()
        BM = New Bitmap(pb1.Width, pb1.Height)  'Crear un bitmap con las dimensiones del picturebox
        G = Graphics.FromImage(BM)              'Obterner el manipulador de graficos del Bitmap BM

        For x = 0 To (NTilesH - 1)
            For y = 0 To (NTilesV - 1)
                If True = DisplayVirtual(x, y) Then
                    G.FillRectangle(Brushes.Red, x * LHC, y * LVC, LHC, LVC)
                Else
                    G.FillRectangle(Brushes.Black, x * LHC, y * LVC, LHC, LVC)
                End If
                G.DrawRectangle(Pens.White, x * LHC, y * LVC, LHC, LVC)
            Next
        Next

        pb1.Image = BM
        G = pb1.CreateGraphics  '
    End Sub

    'DIBUJAR CUADROS
    Private Sub draw(ByVal x As Integer, ByVal y As Integer)
        r = New Rectangle(x, y, LHC, LVC)
        G.FillRectangle(Brushes.Red, r)
        G.DrawRectangle(Pens.White, r)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(DisplayVirtual(tb1.Text, tb2.Text))
    End Sub

    'BORRAR CUADROS
    Private Sub clear(ByVal x As Integer, ByVal y As Integer)
        r = New Rectangle(x, y, LHC, LVC)
        G.FillRectangle(Brushes.Black, r)
        G.DrawRectangle(Pens.White, r)
    End Sub


#End Region




End Class