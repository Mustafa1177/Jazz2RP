Imports Jazz2RP.GeneralFunctions
Public Class FormOptions
    Public Property parent As FormMain
    Sub UpdateForm()
        On Error Resume Next
        ListBoxProccesses.Items.Clear()
        For Each n In parent.jazz2ProcessNames
            ListBoxProccesses.Items.Add(n)
        Next

        ListBoxPlayerNames.Items.Clear()
        For Each n In parent.jazz2PublicNames
            ListBoxPlayerNames.Items.Add(n)
        Next

        ListBoxPrivServers.Items.Clear()
        For Each n In parent.jazz2PrivateServers
            ListBoxPrivServers.Items.Add(n)
        Next

        Select Case My.Settings.ExitHandling
            Case ExitHandingWay.MINIMIZE_TO_TRAY
                RadioButton1.Checked = True
            Case ExitHandingWay.HIDE
                RadioButton2.Checked = True
            Case ExitHandingWay.EXIT_PROGRAM
                RadioButton3.Checked = True
            Case Else
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
        End Select

        Dim selectedIndex As Integer = ComboBoxCpu.Items.Count - My.Settings.CpuUsage - 1
        If selectedIndex >= 0 AndAlso selectedIndex < ComboBoxCpu.Items.Count Then
            ComboBoxCpu.SelectedIndex = selectedIndex
        End If

        CheckBoxNotifyIcon.Checked = My.Settings.App_TrayIcon
        CheckBoxSwapRP.Checked = My.Settings.RP_SwapStateDetails

        If My.Settings.PrivacyLevel >= TrackBarPrivacyLvl.Minimum AndAlso My.Settings.PrivacyLevel <= TrackBarPrivacyLvl.Maximum Then
            TrackBarPrivacyLvl.Value = My.Settings.PrivacyLevel
        End If
        CheckBoxMaxPrivacy.Checked = My.Settings.FullPrivacyMode

        CheckBox2.Checked = My.Settings.Privacy_Details_Location
        CheckBox3.Checked = My.Settings.Privacy_Details_HostedServerName
        CheckBox4.Checked = My.Settings.Privacy_Details_GameMode
        CheckBox5.Checked = My.Settings.Privacy_Details_LevelName
        CheckBox6.Checked = My.Settings.Privacy_Details_SplitScreen
        CheckBox7.Checked = My.Settings.Privacy_Details_SinglePlayer
        CheckBox14.Checked = My.Settings.Privacy_State_InMenu
        CheckBox13.Checked = My.Settings.Privacy_State_InGame
        CheckBox10.Checked = My.Settings.Privacy_State_InOnlineGame = True
        CheckBox11.Checked = My.Settings.Privacy_State_Spectating = True
        CheckBox12.Checked = My.Settings.Privacy_State_NoGame = True

        CheckBoxJoin.Checked = My.Settings.RP_JoinGameButton

        TextBoxNoGame.Text = My.Settings.String_NoGame
        TextBoxSP.Text = My.Settings.String_SinglePlayer
    End Sub

    Private tab3Backup As TabPage
    Private Sub FormOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tab3Backup Is Nothing Then
            tab3Backup = TabPage3
            TabControl1.TabPages.Remove(TabPage3)
        End If
        UpdateForm()
    End Sub
    Private Sub FormOptions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
    End Sub
    Private Sub ButtonDone_Click(sender As Object, e As EventArgs) Handles ButtonDone.Click
        Close()
    End Sub
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        If MessageBox.Show("Are you sure you want to restore the default settings?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            My.Settings.Reset()
            parent.jazz2PublicNames = {}
            UpdateForm()
            TrackBarPrivacyLvl.Value = 2
            Call TrackBarPrivacyLvl_Scroll(TrackBarPrivacyLvl, New EventArgs)
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            My.Settings.ExitHandling = ExitHandingWay.ASK
        End If
    End Sub


    '//----General Page -------------------------------------------------
    Private Sub ButtonAddProccess_Click(sender As Object, e As EventArgs) Handles ButtonAddProccess.Click
        Using fDialog As New OpenFileDialog
            fDialog.Filter = "executable files (*.exe)|*.exe"
            fDialog.Title = "Select Jazz2 executable"
            Select Case fDialog.ShowDialog()
                Case DialogResult.OK
                    If StringArrayContains(parent.jazz2ProcessNames, IO.Path.GetFileNameWithoutExtension(fDialog.FileName)) = False Then
                        Dim newRes As New List(Of String)
                        newRes.Add(IO.Path.GetFileNameWithoutExtension(fDialog.FileName))
                        newRes.AddRange(parent.jazz2ProcessNames)
                        parent.jazz2ProcessNames = newRes.ToArray
                        UpdateForm()
                    Else
                        MsgBox("Entry Is already added")
                    End If
            End Select
            fDialog.Dispose()
        End Using
    End Sub
    Private Sub ButtonRemoveProccess_Click(sender As Object, e As EventArgs) Handles ButtonRemoveProccess.Click
        Try
            If ListBoxProccesses.SelectedIndex >= 0 Then
                Dim newRes As New List(Of String)
                newRes.AddRange(parent.jazz2ProcessNames)
                newRes.RemoveAt(ListBoxProccesses.SelectedIndex)
                parent.jazz2ProcessNames = newRes.ToArray
            Else
                MsgBox("Select a name.")
            End If
            UpdateForm()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        My.Settings.ExitHandling = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        My.Settings.ExitHandling = 2
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        My.Settings.ExitHandling = 3
    End Sub
    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        My.Settings.DisableServerQuery = CType(sender, CheckBox).Checked
    End Sub
    Private Sub CheckBoxNotifyIcon_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxNotifyIcon.CheckedChanged
        My.Settings.App_TrayIcon = CType(sender, CheckBox).Checked
    End Sub
    Private Sub CheckBoxSwapRP_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSwapRP.CheckedChanged
        My.Settings.RP_SwapStateDetails = CType(sender, CheckBox).Checked
    End Sub


    '//----Privacy Page -------------------------------------------------
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        My.Settings.FullPrivacyMode = CType(sender, CheckBox).Checked
    End Sub

    Private Sub CheckBoxMaxPrivacy_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMaxPrivacy.CheckedChanged
        GroupBoxDetails.Enabled = Not CheckBoxMaxPrivacy.Checked
        GroupBoxStates.Enabled = Not CheckBoxMaxPrivacy.Checked
        My.Settings.FullPrivacyMode = CheckBoxMaxPrivacy.Checked
    End Sub

    Private Sub ComboBoxCpu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCpu.SelectedIndexChanged
        My.Settings.CpuUsage = CType(sender, ComboBox).Items.Count - CType(sender, ComboBox).SelectedIndex - 1
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        My.Settings.Privacy_Details_Location = CType(sender, CheckBox).Checked
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        My.Settings.Privacy_Details_HostedServerName = CType(sender, CheckBox).Checked
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        My.Settings.Privacy_Details_GameMode = CType(sender, CheckBox).Checked
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        My.Settings.Privacy_Details_LevelName = CType(sender, CheckBox).Checked
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        My.Settings.Privacy_Details_SplitScreen = CType(sender, CheckBox).Checked
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        My.Settings.Privacy_Details_SinglePlayer = CType(sender, CheckBox).Checked
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        My.Settings.Privacy_State_InMenu = CType(sender, CheckBox).Checked
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        My.Settings.Privacy_State_InGame = CType(sender, CheckBox).Checked
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        My.Settings.Privacy_State_InOnlineGame = CType(sender, CheckBox).Checked
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        My.Settings.Privacy_State_Spectating = CType(sender, CheckBox).Checked
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        My.Settings.Privacy_State_NoGame = CType(sender, CheckBox).Checked
    End Sub

    Private Sub TrackBarPrivacyLvl_Scroll(sender As Object, e As EventArgs) Handles TrackBarPrivacyLvl.Scroll
        My.Settings.PrivacyLevel = TrackBarPrivacyLvl.Value
        Select Case My.Settings.PrivacyLevel
            Case 1
                My.Settings.Privacy_Details_Location = True
                My.Settings.Privacy_Details_HostedServerName = True
                My.Settings.Privacy_Details_GameMode = True
                My.Settings.Privacy_Details_LevelName = True
                My.Settings.Privacy_Details_SplitScreen = True
                My.Settings.Privacy_Details_SinglePlayer = True
                My.Settings.Privacy_State_InMenu = True
                My.Settings.Privacy_State_InGame = True
                My.Settings.Privacy_State_InOnlineGame = True
                My.Settings.Privacy_State_Spectating = True
                My.Settings.Privacy_State_NoGame = True
            Case 2
                My.Settings.Privacy_Details_Location = True
                My.Settings.Privacy_Details_HostedServerName = True
                My.Settings.Privacy_Details_GameMode = False
                My.Settings.Privacy_Details_LevelName = False
                My.Settings.Privacy_Details_SplitScreen = True
                My.Settings.Privacy_Details_SinglePlayer = True
                My.Settings.Privacy_State_InMenu = True
                My.Settings.Privacy_State_InGame = True
                My.Settings.Privacy_State_InOnlineGame = True
                My.Settings.Privacy_State_Spectating = True
                My.Settings.Privacy_State_NoGame = True
            Case 3
                My.Settings.Privacy_Details_Location = False
                My.Settings.Privacy_Details_HostedServerName = True
                My.Settings.Privacy_Details_GameMode = False
                My.Settings.Privacy_Details_LevelName = False
                My.Settings.Privacy_Details_SplitScreen = False
                My.Settings.Privacy_Details_SinglePlayer = True
                My.Settings.Privacy_State_InMenu = False
                My.Settings.Privacy_State_InGame = True
                My.Settings.Privacy_State_InOnlineGame = True
                My.Settings.Privacy_State_Spectating = True
                My.Settings.Privacy_State_NoGame = True
            Case 4
                My.Settings.Privacy_Details_Location = False
                My.Settings.Privacy_Details_HostedServerName = False
                My.Settings.Privacy_Details_GameMode = False
                My.Settings.Privacy_Details_LevelName = False
                My.Settings.Privacy_Details_SplitScreen = False
                My.Settings.Privacy_Details_SinglePlayer = False
                My.Settings.Privacy_State_InMenu = False
                My.Settings.Privacy_State_InGame = True
                My.Settings.Privacy_State_InOnlineGame = True
                My.Settings.Privacy_State_Spectating = True
                My.Settings.Privacy_State_NoGame = False
        End Select
        UpdateForm()
    End Sub
    Private Sub CheckBoxJoin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxJoin.CheckedChanged
        My.Settings.RP_JoinGameButton = CType(sender, CheckBox).Checked
    End Sub
    Private Sub ButtonAddName_Click(sender As Object, e As EventArgs) Handles ButtonAddName.Click
        Try
            Dim userInput = Interaction.InputBox("Enter JJ2 name", "Add Name", "").ToLower
            If userInput <> "" Then
                If StringArrayContains(parent.jazz2PublicNames, userInput) = False Then
                    Dim newRes As New List(Of String)
                    newRes.AddRange(parent.jazz2PublicNames)
                    newRes.Add(userInput)
                    parent.jazz2PublicNames = newRes.ToArray
                    UpdateForm()
                Else
                    MsgBox("Entry already exists.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonRemoveName_Click(sender As Object, e As EventArgs) Handles ButtonRemoveName.Click
        Try
            If ListBoxPlayerNames.SelectedIndex >= 0 Then
                Dim newRes As New List(Of String)
                newRes.AddRange(parent.jazz2PublicNames)
                newRes.RemoveAt(ListBoxPlayerNames.SelectedIndex)
                parent.jazz2PublicNames = newRes.ToArray
            Else
                MsgBox("Select a name.")
            End If
            UpdateForm()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonAddPriServer_Click(sender As Object, e As EventArgs) Handles ButtonAddPriServer.Click
        Try
            Dim userInput = Interaction.InputBox("Enter end point of the server you want to make private (""IP:Port"")." & vbNewLine & "Example: ""127.0.0.1:10052""", "Add Host", "").ToLower
            If userInput <> "" Then
                If StringArrayContains(parent.jazz2PrivateServers, userInput) = False Then
                    Dim newRes As New List(Of String)
                    newRes.AddRange(parent.jazz2PrivateServers)
                    newRes.Add(userInput)
                    parent.jazz2PrivateServers = newRes.ToArray
                    UpdateForm()
                Else
                    MsgBox("Entry already exists.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonRemovePriServer_Click(sender As Object, e As EventArgs) Handles ButtonRemovePriServer.Click
        Try
            If ListBoxPrivServers.SelectedIndex >= 0 Then
                Dim newRes As New List(Of String)
                newRes.AddRange(parent.jazz2PrivateServers)
                newRes.RemoveAt(ListBoxPrivServers.SelectedIndex)
                parent.jazz2PrivateServers = newRes.ToArray
            Else
                MsgBox("Select entry.")
            End If
            UpdateForm()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    '//----Strings Page -------------------------------------------------
    Private Sub TextBoxSP_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSP.TextChanged
        My.Settings.String_SinglePlayer = TextBoxSP.Text
    End Sub

    Private Sub TextBoxNoGame_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNoGame.TextChanged
        My.Settings.String_NoGame = TextBoxNoGame.Text
    End Sub




















    '//-----------------------------------------------------------------




End Class