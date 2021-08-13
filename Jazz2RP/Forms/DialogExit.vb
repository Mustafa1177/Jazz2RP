Imports System.Windows.Forms
Public Class DialogExit
    Public Property UserChoice As Integer
    Public Property RememberChoice As Boolean
    Private Sub DialogExit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = True
        RadioButton2.Checked = True
        RadioButton2.Select()
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If CheckBox2.Checked Then
            GeneralFunctions.AddAppToStartup(False)
        End If
        If RadioButton1.Checked Then
            UserChoice = ExitHandingWay.MINIMIZE_TO_TRAY
        ElseIf RadioButton2.Checked Then
            UserChoice = ExitHandingWay.HIDE
        ElseIf RadioButton3.Checked Then
            UserChoice = ExitHandingWay.EXIT_PROGRAM
        End If
        RememberChoice = CheckBox1.Checked
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        CheckBox1.Checked = False
    End Sub
End Class
