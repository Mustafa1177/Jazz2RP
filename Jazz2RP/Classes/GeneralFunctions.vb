Public Class GeneralFunctions
    Public Shared Function StringArrayContains(source As String(), value As String, Optional ignoreCase As Boolean = False)
        If ignoreCase = False Then
            For Each s In source
                If s = value Then
                    Return True
                    Exit Function
                End If
            Next
        Else
            value = value.ToLower
            For Each s In source
                If s.ToLower = value Then
                    Return True
                End If
            Next
        End If
        Return False
    End Function
    Public Shared Function AddAppToStartup(ByVal undo As Boolean, Optional popups As Boolean = False) As String
        Try
            If undo = False Then
                My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                If popups Then MsgBox("Added successfully.")
            Else
                My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                If popups Then MsgBox("Removed successfully.")
            End If
        Catch ex As Exception
            Return ex.Message
        End Try
        Return ""
    End Function
End Class
