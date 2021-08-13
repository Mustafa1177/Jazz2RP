Imports System.IO
Imports System.Text
Public Class Storage
    Public Shared Sub SaveStringArray(ByVal filePath As String, ByVal value As String())
        File.WriteAllLines(filePath, value)
    End Sub
    Public Shared Function LoadStringArray(ByVal filePath As String) As String()
        Dim result As String() = {}
        Try
            If File.Exists(filePath) Then
                result = File.ReadAllLines(filePath)
            End If
        Catch ex As Exception
        End Try
        Return result
    End Function
End Class
