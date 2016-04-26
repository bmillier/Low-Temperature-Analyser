
'Imports System.Windows.Forms.DataVisualization.Charting

Imports System.IO
Imports System.Management

Public Class Com
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    ' Public Class mainForm

    Private readBuffer As String = String.Empty
    Private comOpen As Boolean
    Private RunTime As Integer
    Private finalTemperature As Integer
    Private startTemperature As Integer
    Private sample(2000) As Single
    Private index As Integer
    Dim x1 As Integer
    Dim y1 As Integer
    Dim x2 As Integer
    Dim y2 As Integer
    Private vlp As Single
    Private runFlag As Boolean
    Private coolerOn As Boolean
    Private coolerStatus As Boolean
    Private RunDoneFlag As Boolean
    Private rampIncrement As Integer
    Private elapsedTime As Integer
    Private comPortNumber As String
    Private fullComPortName As String
    Private cpindex As Integer




    Private Sub SetScale(ByVal gr As Graphics, ByVal gr_width _
    As Integer, ByVal gr_height As Integer, ByVal left_x As _
    Single, ByVal right_x As Single, ByVal top_y As Single,
    ByVal bottom_y As Single)
        ' Start from scratch.
        gr.ResetTransform()
        ' Scale so the viewport's width and height
        ' map to the Graphics object's width and height.
        Dim bounds As RectangleF = gr.ClipBounds
        gr.ScaleTransform(
         gr_width / (right_x - left_x),
         gr_height / (bottom_y - top_y))
        ' Translate (left_x, top_y) to the Graphics
        ' object's origin.
        gr.TranslateTransform(-left_x, -top_y)
    End Sub




    Private Sub cboComPort_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Com_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This is actually the Form Load event
        ' read avaiable COM Ports:
        Dim Portnames As String() = System.IO.Ports.SerialPort.GetPortNames
        'If Portnames Is Nothing Then
        If Portnames.Length = 0 Then
            MsgBox("There are no Com Ports detected- is instrument connected up?")
            Me.Close()
        End If

        Try
            Dim searcher As New ManagementObjectSearcher(
           "root\cimv2",
           "SELECT * FROM Win32_SerialPort")

            For Each queryObj As ManagementObject In searcher.Get()
                fullComPortName = queryObj("Name")
                If InStr(fullComPortName, "Arduino Uno") <> 0 Then
                    ' MsgBox(fullComPortName)
                    cpindex = InStr(fullComPortName, "COM")
                    comPortNumber = fullComPortName.Substring(cpindex - 1, Len(fullComPortName) - (cpindex))
                    tbComportnumber.Text = comPortNumber
                End If

            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while checking for COM ports: " & err.Message)
        End Try

        ' device params
        With SerialPort1

            'BM .ParityReplace = &H3B                    ' replace ";" when parity error occurs
            .PortName = comPortNumber    'cboComPort.Text
            .BaudRate = 57600
            .Parity = IO.Ports.Parity.None
            .DataBits = 8
            .StopBits = IO.Ports.StopBits.One
            .Handshake = IO.Ports.Handshake.None
            .RtsEnable = False
            .DtrEnable = True
            .ReceivedBytesThreshold = 1             'threshold: 1 byte in buffer > event is fired
            .NewLine = vbCr         ' CR must be the last char in frame. This terminates the SerialPort.readLine
            .ReadTimeout = 10000

        End With

        ' check whether device is avaiable:
        Try
            SerialPort1.Open()
            comOpen = SerialPort1.IsOpen
        Catch ex As Exception
            comOpen = False
            MsgBox("Error Open: " & ex.Message)
            picOpen.BackColor = Color.Red
        End Try

        If comOpen Then
            picOpen.BackColor = Color.Green
        End If

        RunTime = 10 * 60
        startTemperature = 20
        finalTemperature = 40
        runFlag = False
        coolerStatus = False
        ' load variables/textboxes with scrollbar values
        rampIncrement = hscrollRamp.Value
        tbRampIncrement.Text = Str(rampIncrement)
        tbRunTime.Text = hscrollRunTime.Value
        RunTime = hscrollRunTime.Value * 60
        tbStartTemperature.Text = hscrollStartTemperature.Value
        startTemperature = hscrollStartTemperature.Value
        tbFinalTemperature.Text = hscrollFinalTemperature.Value
        finalTemperature = hscrollFinalTemperature.Value
    End Sub






    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Graph1_Click(sender As Object, e As EventArgs) Handles Graph1.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If comOpen Then
            ' clear input buffer
            SerialPort1.DiscardInBuffer()
            SerialPort1.Close()
        End If
        comOpen = False
        Me.Close()
    End Sub

    Private Sub hscrollFinalTemperature_Scroll(sender As Object, e As ScrollEventArgs) Handles hscrollFinalTemperature.Scroll
        tbFinalTemperature.Text = hscrollFinalTemperature.Value
        finalTemperature = hscrollFinalTemperature.Value
    End Sub

    Private Sub hscrollStartTemperature_Scroll(sender As Object, e As ScrollEventArgs) Handles hscrollStartTemperature.Scroll
        tbStartTemperature.Text = hscrollStartTemperature.Value
        startTemperature = hscrollStartTemperature.Value

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles butStart.Click
        Dim g As Graphics
        Dim Tick As Single
        Dim rampRate As String
        Dim d As String
        Dim c As String
        Dim temperature As Single


        g = Graph1.CreateGraphics
        g.Clear(Color.White)
        SetScale(g, Me.Graph1.Width, Me.Graph1.Height, 0, RunTime, finalTemperature, startTemperature)
        Dim graypen As New Drawing.Pen(Color.Gray, 0)
        For i = 0 To RunTime Step 6
            If i Mod 60 = 0 Then Tick = (finalTemperature - startTemperature) / 30 Else Tick = (finalTemperature - startTemperature) / 50
            g.DrawLine(graypen, i, startTemperature, i, startTemperature + Tick)
        Next
        Dim blackpen As New Drawing.Pen(Color.Black, 0)
        index = 1  'datafile index
        elapsedTime = 0
        runFlag = True   ' This flags the Timer2 ISR to start the run
        RunDoneFlag = False
        Timer1.Enabled = False
        tbSampleTemperature.Text = String.Empty
        tbHeatSinkTemperature.Text = String.Empty
        rampRate = Str(hscrollRamp.Value * 10)
        tbHeatSinkTemperature.Text = rampRate
        SendCmd("Q")  ' abort run if it is currently executing
        SendCmd("R")
        SendParam(rampRate)
        SendCmd("G")     ' start up the run
        Statuswind.Text = "Running"
        Do
            Application.DoEvents()
            readBuffer = SerialPort1.ReadLine()
            c = readBuffer
            ' Extract the sample temperature
            d = Mid$(c, 1, 5)
            temperature = Val(d)
            ' do an IIR filter with an A of 2
            temperature = temperature - vlp
            temperature = temperature / 2
            vlp = vlp + temperature
            d = Str(vlp)
            d = Mid$(d, 1, 5)
            tbSampleTemperature.Text = d
            sample(index) = vlp   ' store the data point
            'Extract heatsink temperature
            If elapsedTime > 0 Then
                g.DrawLine(blackpen, index - 1, sample(index - 1), index, sample(index))
            End If
            d = Mid$(readBuffer, Len(readBuffer) - 2, 3)
            tbHeatSinkTemperature.Text = d
            index = index + 1
            elapsedTime = elapsedTime + 1
            tbElapsedTime.Text = Str(elapsedTime)
            If elapsedTime > RunTime Then
                runFlag = False
                RunDoneFlag = True
            End If
            Application.DoEvents()
        Loop Until RunDoneFlag = True
        SendCmd("Q")
        Statuswind.Text = "Run Complete"
        SaveSamplerun("c:\my documents\CurrentRun.txt")

    End Sub

    Private Sub hscrollRunTime_Scroll(sender As Object, e As ScrollEventArgs) Handles hscrollRunTime.Scroll
        tbRunTime.Text = hscrollRunTime.Value
        RunTime = hscrollRunTime.Value * 60

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim d As String
        Dim c As String
        Dim temperature As Single
        Dim length As Integer

        Statuswind.Text = String.Empty
        If comOpen Then
            Try
                If coolerOn = True Then
                    If coolerStatus = False Then
                        SendCmd("C")
                        SendParam("1")
                        coolerStatus = True
                    End If
                End If
                If coolerOn = False Then
                    If coolerStatus = True Then
                        SendCmd("C")
                        SendParam("0")
                        coolerStatus = False
                    End If
                End If
                SendCmd("Z")
                readBuffer = SerialPort1.ReadLine()
                c = readBuffer
                ' Extract the sample temperature
                d = Mid$(c, 1, 5)
                temperature = Val(d)
                ' do an IIR filter with an A of 2
                temperature = temperature - vlp
                temperature = temperature / 2
                vlp = vlp + temperature
                d = Str(vlp)
                d = Mid$(d, 1, 5)
                tbSampleTemperature.Text = d
                'Extract heatsink temperature
                length = 4
                d = Mid$(readBuffer, Len(readBuffer) - 2, 3)
                tbHeatSinkTemperature.Text = d
            Catch ex As Exception
                MsgBox("read " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles butCoolerOn.Click
        Statuswind.Text = String.Empty
        If Timer1.Enabled = False Then
            SendCmd("C")
            SendParam("1")
            coolerStatus = True
        End If
        coolerOn = True
        runFlag = False
        RunDoneFlag = False
    End Sub
    Private Sub SendCmd(cmd As String)
        Dim d As String
        Dim q As Byte
        d = SerialPort1.ReadExisting()
        SerialPort1.Write(cmd)
        Do
            q = SerialPort1.ReadByte
        Loop Until q = Asc(cmd)
        'Statuswind.Text = "Command Send"
    End Sub
    Private Sub SendParam(par As String)
        Dim q As Byte
        SerialPort1.WriteLine(par)
        Do  'wait for parameter to be echoed back
            q = SerialPort1.ReadByte
        Loop Until q = 10   ' LF char
        Statuswind.Text = "Command/parameter Sent"
    End Sub
    Private Sub butMeasureTemperature_Click(sender As Object, e As EventArgs) Handles butMeasureTemperature.Click
        vlp = 0
        tbElapsedTime.Text = String.Empty
        Timer1.Enabled = True
    End Sub

    Private Sub butCoolerOff_Click(sender As Object, e As EventArgs) Handles butCoolerOff.Click
        Statuswind.Text = String.Empty
        coolerOn = False
        If Timer1.Enabled = False Then
            SendCmd("C")
            SendParam("0")
            coolerStatus = False
        End If
    End Sub

    Private Sub hscrollRamp_Scroll(sender As Object, e As ScrollEventArgs) Handles hscrollRamp.Scroll
        rampIncrement = hscrollRamp.Value
        tbRampIncrement.Text = Str(rampIncrement)


    End Sub

    Private Sub butStop_Click(sender As Object, e As EventArgs) Handles butStop.Click
        RunDoneFlag = True
    End Sub
    Private Sub SaveSamplerun(fn As String)
        Dim D As String
        Using outputFile As New IO.StreamWriter(fn)
            outputFile.WriteLine("Time(sec)   Sample Temp")
            For i = 1 To index - 1
                D = Str(i) & "     " & Str(sample(i))
                outputFile.WriteLine(D)
            Next
        End Using
    End Sub

    Private Sub SaveCurrentRunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveCurrentRunToolStripMenuItem.Click
        Dim fn, fn2 As String
        Dim a As Integer
        SaveFileDialog1.InitialDirectory = "C:\my documents"
        SaveFileDialog1.FileName = "*.txt"
        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName = "*.txt" Then Exit Sub
        fn = SaveFileDialog1.FileName
        a = InStr(1, fn, ".")
        If a > 0 Then
            fn = Mid(fn, 1, a - 1)
        End If
        Statuswind.Text = fn
        fn2 = fn & ".txt"
        SaveSamplerun(fn2)
        Statuswind.Text = "Sample Run Saved to Disk"
    End Sub

    Private Sub LoadLastRunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadLastRunToolStripMenuItem.Click
        Dim D, F As String
        Dim g As Graphics
        Dim Tick As Single

        Try
            Using inputFile As New IO.StreamReader("C:\my documents\CurrentRun.txt")
                D = inputFile.ReadLine
                index = 1
                Do
                    D = inputFile.ReadLine
                    F = Mid(D, 6, Len(D) - 4)   ' skip the index number
                    'Statuswind.Text = F
                    sample(index) = Val(F)
                    index = index + 1
                Loop Until inputFile.EndOfStream
            End Using
        Catch
            MsgBox("Can't find current run file")
        End Try
        index = index - 1
        RunTime = index
        g = Graph1.CreateGraphics
        g.Clear(Color.White)
        SetScale(g, Me.Graph1.Width, Me.Graph1.Height, 0, RunTime, finalTemperature, startTemperature)
        Dim graypen As New Drawing.Pen(Color.Gray, 0)
        For i = 0 To RunTime Step 6
            If i Mod 60 = 0 Then Tick = (finalTemperature - startTemperature) / 30 Else Tick = (finalTemperature - startTemperature) / 50
            g.DrawLine(graypen, i, startTemperature, i, startTemperature + Tick)
        Next
        Dim blackpen As New Drawing.Pen(Color.Black, 0)
        For index = 2 To RunTime
            g.DrawLine(blackpen, index - 1, sample(index - 1), index, sample(index))
        Next
    End Sub

    Private Sub tbRx_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
