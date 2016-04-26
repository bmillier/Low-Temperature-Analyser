<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Com
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Statuswind = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Graph1 = New System.Windows.Forms.PictureBox()
        Me.butStart = New System.Windows.Forms.Button()
        Me.picOpen = New System.Windows.Forms.PictureBox()
        Me.tbRunTime = New System.Windows.Forms.TextBox()
        Me.tbStartTemperature = New System.Windows.Forms.TextBox()
        Me.tbFinalTemperature = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveCurrentRunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadLastRunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hscrollStartTemperature = New System.Windows.Forms.HScrollBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hscrollFinalTemperature = New System.Windows.Forms.HScrollBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.hscrollRunTime = New System.Windows.Forms.HScrollBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.butMeasureTemperature = New System.Windows.Forms.Button()
        Me.butCoolerOn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbElapsedTime = New System.Windows.Forms.TextBox()
        Me.tbHeatSinkTemperature = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbSampleTemperature = New System.Windows.Forms.TextBox()
        Me.hscrollRamp = New System.Windows.Forms.HScrollBar()
        Me.butCoolerOff = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbRampIncrement = New System.Windows.Forms.TextBox()
        Me.butStop = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.tbComportnumber = New System.Windows.Forms.TextBox()
        CType(Me.Graph1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 57600
        Me.SerialPort1.DtrEnable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(800, 544)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Instrument ComPort"
        '
        'Statuswind
        '
        Me.Statuswind.Location = New System.Drawing.Point(56, 539)
        Me.Statuswind.Name = "Statuswind"
        Me.Statuswind.Size = New System.Drawing.Size(409, 22)
        Me.Statuswind.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 542)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Status"
        '
        'Graph1
        '
        Me.Graph1.BackColor = System.Drawing.Color.White
        Me.Graph1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Graph1.Location = New System.Drawing.Point(176, 35)
        Me.Graph1.Margin = New System.Windows.Forms.Padding(0)
        Me.Graph1.Name = "Graph1"
        Me.Graph1.Size = New System.Drawing.Size(678, 362)
        Me.Graph1.TabIndex = 9
        Me.Graph1.TabStop = False
        '
        'butStart
        '
        Me.butStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butStart.Location = New System.Drawing.Point(142, 431)
        Me.butStart.Margin = New System.Windows.Forms.Padding(0)
        Me.butStart.Name = "butStart"
        Me.butStart.Size = New System.Drawing.Size(68, 50)
        Me.butStart.TabIndex = 10
        Me.butStart.Text = "Start"
        Me.butStart.UseVisualStyleBackColor = True
        '
        'picOpen
        '
        Me.picOpen.Location = New System.Drawing.Point(675, 544)
        Me.picOpen.Name = "picOpen"
        Me.picOpen.Size = New System.Drawing.Size(28, 21)
        Me.picOpen.TabIndex = 15
        Me.picOpen.TabStop = False
        '
        'tbRunTime
        '
        Me.tbRunTime.Location = New System.Drawing.Point(804, 397)
        Me.tbRunTime.Name = "tbRunTime"
        Me.tbRunTime.Size = New System.Drawing.Size(50, 22)
        Me.tbRunTime.TabIndex = 16
        Me.tbRunTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbStartTemperature
        '
        Me.tbStartTemperature.Location = New System.Drawing.Point(142, 370)
        Me.tbStartTemperature.Name = "tbStartTemperature"
        Me.tbStartTemperature.Size = New System.Drawing.Size(31, 22)
        Me.tbStartTemperature.TabIndex = 17
        Me.tbStartTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbFinalTemperature
        '
        Me.tbFinalTemperature.Location = New System.Drawing.Point(144, 30)
        Me.tbFinalTemperature.Name = "tbFinalTemperature"
        Me.tbFinalTemperature.Size = New System.Drawing.Size(29, 22)
        Me.tbFinalTemperature.TabIndex = 18
        Me.tbFinalTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(431, 397)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Run Time in minutes"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(152, 82)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(21, 272)
        Me.TextBox3.TabIndex = 20
        Me.TextBox3.Text = "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "p" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "u" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(944, 28)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveCurrentRunToolStripMenuItem, Me.LoadLastRunToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveCurrentRunToolStripMenuItem
        '
        Me.SaveCurrentRunToolStripMenuItem.Name = "SaveCurrentRunToolStripMenuItem"
        Me.SaveCurrentRunToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.SaveCurrentRunToolStripMenuItem.Text = "Save Current Run"
        '
        'LoadLastRunToolStripMenuItem
        '
        Me.LoadLastRunToolStripMenuItem.Name = "LoadLastRunToolStripMenuItem"
        Me.LoadLastRunToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.LoadLastRunToolStripMenuItem.Text = "Load Last Run"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'hscrollStartTemperature
        '
        Me.hscrollStartTemperature.LargeChange = 1
        Me.hscrollStartTemperature.Location = New System.Drawing.Point(0, 370)
        Me.hscrollStartTemperature.Maximum = 30
        Me.hscrollStartTemperature.Minimum = -10
        Me.hscrollStartTemperature.Name = "hscrollStartTemperature"
        Me.hscrollStartTemperature.Size = New System.Drawing.Size(117, 21)
        Me.hscrollStartTemperature.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 395)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Start Temperature"
        '
        'hscrollFinalTemperature
        '
        Me.hscrollFinalTemperature.LargeChange = 1
        Me.hscrollFinalTemperature.Location = New System.Drawing.Point(9, 31)
        Me.hscrollFinalTemperature.Maximum = 50
        Me.hscrollFinalTemperature.Name = "hscrollFinalTemperature"
        Me.hscrollFinalTemperature.Size = New System.Drawing.Size(117, 21)
        Me.hscrollFinalTemperature.TabIndex = 25
        Me.hscrollFinalTemperature.Value = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Final Temperature"
        '
        'hscrollRunTime
        '
        Me.hscrollRunTime.LargeChange = 1
        Me.hscrollRunTime.Location = New System.Drawing.Point(641, 397)
        Me.hscrollRunTime.Maximum = 15
        Me.hscrollRunTime.Minimum = 1
        Me.hscrollRunTime.Name = "hscrollRunTime"
        Me.hscrollRunTime.Size = New System.Drawing.Size(157, 22)
        Me.hscrollRunTime.TabIndex = 27
        Me.hscrollRunTime.Value = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(666, 431)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Run Time (minutes)"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'butMeasureTemperature
        '
        Me.butMeasureTemperature.Location = New System.Drawing.Point(318, 431)
        Me.butMeasureTemperature.Name = "butMeasureTemperature"
        Me.butMeasureTemperature.Size = New System.Drawing.Size(110, 50)
        Me.butMeasureTemperature.TabIndex = 29
        Me.butMeasureTemperature.Text = "Measure Temperature" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.butMeasureTemperature.UseVisualStyleBackColor = True
        '
        'butCoolerOn
        '
        Me.butCoolerOn.Location = New System.Drawing.Point(450, 432)
        Me.butCoolerOn.Name = "butCoolerOn"
        Me.butCoolerOn.Size = New System.Drawing.Size(81, 50)
        Me.butCoolerOn.TabIndex = 30
        Me.butCoolerOn.Text = "Cooler On"
        Me.butCoolerOn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tbElapsedTime)
        Me.GroupBox1.Controls.Add(Me.tbHeatSinkTemperature)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbSampleTemperature)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(117, 188)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Values"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 17)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Elapsed Time"
        '
        'tbElapsedTime
        '
        Me.tbElapsedTime.Location = New System.Drawing.Point(15, 160)
        Me.tbElapsedTime.Name = "tbElapsedTime"
        Me.tbElapsedTime.Size = New System.Drawing.Size(67, 22)
        Me.tbElapsedTime.TabIndex = 37
        '
        'tbHeatSinkTemperature
        '
        Me.tbHeatSinkTemperature.Location = New System.Drawing.Point(15, 115)
        Me.tbHeatSinkTemperature.Name = "tbHeatSinkTemperature"
        Me.tbHeatSinkTemperature.Size = New System.Drawing.Size(67, 22)
        Me.tbHeatSinkTemperature.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 17)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Heatsink Temp."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Sample Temp."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbSampleTemperature
        '
        Me.tbSampleTemperature.Location = New System.Drawing.Point(15, 70)
        Me.tbSampleTemperature.Name = "tbSampleTemperature"
        Me.tbSampleTemperature.Size = New System.Drawing.Size(67, 22)
        Me.tbSampleTemperature.TabIndex = 32
        '
        'hscrollRamp
        '
        Me.hscrollRamp.LargeChange = 5
        Me.hscrollRamp.Location = New System.Drawing.Point(641, 461)
        Me.hscrollRamp.Maximum = 104
        Me.hscrollRamp.Minimum = 1
        Me.hscrollRamp.Name = "hscrollRamp"
        Me.hscrollRamp.Size = New System.Drawing.Size(157, 21)
        Me.hscrollRamp.TabIndex = 32
        Me.hscrollRamp.Value = 1
        '
        'butCoolerOff
        '
        Me.butCoolerOff.Location = New System.Drawing.Point(546, 431)
        Me.butCoolerOff.Name = "butCoolerOff"
        Me.butCoolerOff.Size = New System.Drawing.Size(88, 50)
        Me.butCoolerOff.TabIndex = 33
        Me.butCoolerOff.Text = "Cooler Off"
        Me.butCoolerOff.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(672, 491)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 17)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Heater Ramp Rate"
        '
        'tbRampIncrement
        '
        Me.tbRampIncrement.Location = New System.Drawing.Point(804, 460)
        Me.tbRampIncrement.Name = "tbRampIncrement"
        Me.tbRampIncrement.Size = New System.Drawing.Size(50, 22)
        Me.tbRampIncrement.TabIndex = 35
        '
        'butStop
        '
        Me.butStop.Location = New System.Drawing.Point(226, 431)
        Me.butStop.Name = "butStop"
        Me.butStop.Size = New System.Drawing.Size(75, 50)
        Me.butStop.TabIndex = 36
        Me.butStop.Text = "Stop"
        Me.butStop.UseVisualStyleBackColor = True
        '
        'tbComportnumber
        '
        Me.tbComportnumber.Location = New System.Drawing.Point(729, 541)
        Me.tbComportnumber.Name = "tbComportnumber"
        Me.tbComportnumber.Size = New System.Drawing.Size(55, 22)
        Me.tbComportnumber.TabIndex = 37
        Me.tbComportnumber.Text = "none"
        '
        'Com
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(944, 573)
        Me.Controls.Add(Me.tbComportnumber)
        Me.Controls.Add(Me.butStop)
        Me.Controls.Add(Me.tbRampIncrement)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.butCoolerOff)
        Me.Controls.Add(Me.hscrollRamp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.butCoolerOn)
        Me.Controls.Add(Me.butMeasureTemperature)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.hscrollRunTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.hscrollFinalTemperature)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hscrollStartTemperature)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbFinalTemperature)
        Me.Controls.Add(Me.tbStartTemperature)
        Me.Controls.Add(Me.tbRunTime)
        Me.Controls.Add(Me.picOpen)
        Me.Controls.Add(Me.butStart)
        Me.Controls.Add(Me.Graph1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Statuswind)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Com"
        Me.Text = "Low Temperature Analyser C Brian Millier CIC April 17,2016"
        CType(Me.Graph1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOpen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label1 As Label
    Friend WithEvents Statuswind As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Graph1 As PictureBox
    Friend WithEvents butStart As Button
    Friend WithEvents picOpen As PictureBox
    Friend WithEvents tbRunTime As TextBox
    Friend WithEvents tbStartTemperature As TextBox
    Friend WithEvents tbFinalTemperature As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveCurrentRunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadLastRunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents hscrollStartTemperature As HScrollBar
    Friend WithEvents Label4 As Label
    Friend WithEvents hscrollFinalTemperature As HScrollBar
    Friend WithEvents Label5 As Label
    Friend WithEvents hscrollRunTime As HScrollBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents butMeasureTemperature As Button
    Friend WithEvents butCoolerOn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbSampleTemperature As TextBox
    Friend WithEvents tbHeatSinkTemperature As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents hscrollRamp As HScrollBar
    Friend WithEvents butCoolerOff As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents tbRampIncrement As TextBox
    Friend WithEvents butStop As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents tbElapsedTime As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents tbComportnumber As TextBox
End Class
