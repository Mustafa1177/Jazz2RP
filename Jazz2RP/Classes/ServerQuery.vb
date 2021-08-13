Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Public Class ServerQuery
    Public Class QueryResult
        Public Property ServerName As String
        Public Property PlayersCount As Byte
        Public Property PlayerLimit As Byte
        Public Property GameMode As Byte
        Public Property PrivateServer As Boolean
    End Class

    Shared QUERY_PACKET As Byte() = {6, 13, 5, 0}
    Public Shared Function Query(ByRef result As QueryResult, ByRef udp As UdpClient, ByVal serverIP As String, Optional serverPort As Integer = 10052, Optional timeout As Integer = 2000) As Boolean
        Try
            Dim ep As New IPEndPoint(IPAddress.Parse(serverIP), serverPort)
            udp.Client.ReceiveTimeout = timeout
            udp.Send(QUERY_PACKET, QUERY_PACKET.Length, serverIP, serverPort)
            Dim recv As Byte() = udp.Receive(ep)
            If recv.Length >= 20 Then
                If recv(2) = &H6 Then
                    result.PlayersCount = recv(12)
                    result.GameMode = recv(14)
                    result.PlayerLimit = recv(15)
                    Dim serverNameLength As Integer = recv(16)
                    If 19 + serverNameLength < recv.Length Then
                        result.ServerName = Encoding.ASCII.GetString(recv, 17, serverNameLength)
                        result.PrivateServer = CBool(recv(18 + serverNameLength) And &H1)
                        Return True
                    End If
                End If
            End If
        Catch ex As SocketException
        Catch ex As Exception
        End Try
        Return False
    End Function
End Class
