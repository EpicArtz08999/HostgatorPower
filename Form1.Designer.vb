<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.NumericPort = New System.Windows.Forms.NumericUpDown()
        Me.TrackBarThreads = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelConnections = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelFailedConnections = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelThreads = New System.Windows.Forms.Label()
        Me.LabelLastByte = New System.Windows.Forms.Label()
        CType(Me.NumericPort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarThreads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(47, 12)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(190, 20)
        Me.txtIP.TabIndex = 0
        '
        'NumericPort
        '
        Me.NumericPort.Location = New System.Drawing.Point(47, 36)
        Me.NumericPort.Maximum = New Decimal(New Integer() {25565, 0, 0, 0})
        Me.NumericPort.Name = "NumericPort"
        Me.NumericPort.Size = New System.Drawing.Size(190, 20)
        Me.NumericPort.TabIndex = 1
        Me.NumericPort.Value = New Decimal(New Integer() {19132, 0, 0, 0})
        '
        'TrackBarThreads
        '
        Me.TrackBarThreads.Location = New System.Drawing.Point(109, 62)
        Me.TrackBarThreads.Name = "TrackBarThreads"
        Me.TrackBarThreads.Size = New System.Drawing.Size(130, 45)
        Me.TrackBarThreads.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(95, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "IP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Port:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Connections:"
        '
        'LabelConnections
        '
        Me.LabelConnections.AutoSize = True
        Me.LabelConnections.Location = New System.Drawing.Point(76, 107)
        Me.LabelConnections.Name = "LabelConnections"
        Me.LabelConnections.Size = New System.Drawing.Size(13, 13)
        Me.LabelConnections.TabIndex = 8
        Me.LabelConnections.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Failed connections:"
        '
        'LabelFailedConnections
        '
        Me.LabelFailedConnections.AutoSize = True
        Me.LabelFailedConnections.Location = New System.Drawing.Point(106, 120)
        Me.LabelFailedConnections.Name = "LabelFailedConnections"
        Me.LabelFailedConnections.Size = New System.Drawing.Size(13, 13)
        Me.LabelFailedConnections.TabIndex = 10
        Me.LabelFailedConnections.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Number of threads:"
        '
        'LabelThreads
        '
        Me.LabelThreads.AutoSize = True
        Me.LabelThreads.Location = New System.Drawing.Point(104, 64)
        Me.LabelThreads.Name = "LabelThreads"
        Me.LabelThreads.Size = New System.Drawing.Size(13, 13)
        Me.LabelThreads.TabIndex = 12
        Me.LabelThreads.Text = "0"
        '
        'LabelLastByte
        '
        Me.LabelLastByte.AutoSize = True
        Me.LabelLastByte.Location = New System.Drawing.Point(176, 167)
        Me.LabelLastByte.Name = "LabelLastByte"
        Me.LabelLastByte.Size = New System.Drawing.Size(75, 13)
        Me.LabelLastByte.TabIndex = 13
        Me.LabelLastByte.Text = "Packet: NULL"
        Me.LabelLastByte.UseMnemonic = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 188)
        Me.Controls.Add(Me.LabelLastByte)
        Me.Controls.Add(Me.LabelThreads)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelFailedConnections)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelConnections)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TrackBarThreads)
        Me.Controls.Add(Me.NumericPort)
        Me.Controls.Add(Me.txtIP)
        Me.Name = "Form1"
        Me.Text = "#HostgatorPower"
        CType(Me.NumericPort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarThreads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIP As TextBox
    Friend WithEvents NumericPort As NumericUpDown
    Friend WithEvents TrackBarThreads As TrackBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelConnections As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelFailedConnections As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelThreads As Label
    Friend WithEvents LabelLastByte As Label
End Class
