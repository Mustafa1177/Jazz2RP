Imports DiscordRPC
Imports DiscordRPC.Message
Imports System
Imports System.Text
Imports System.Threading
Imports Jazz2RP.GeneralFunctions
Public Class FormMain
    Private udp As New Net.Sockets.UdpClient
    Private optionsForm As FormOptions
    Public jazz2ProcessNames As String() = {"jazz2", "jazz2+", "jazz2_nonplus"}
    Public jazz2PublicNames As String() = {}
    Public jazz2PrivateServers As String() = {}
    Dim windowIsActive As Boolean = False

    Dim jazz2Process As Process
    Dim gameVersion As Integer = 0
    Dim plusDllAddress As Integer = 0
    Dim presenceState As String = ""
    Dim presenceDetails As String = ""
    Dim joinUrl As String = ""

    Dim firstLoad As Boolean = True
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        If firstLoad Then
            firstLoad = False
            LoadData()
            ApplySettings()
            initJJ2()
            RPUpdateTimer.Interval = 3000
            RPUpdateTimer.Start()
            If My.Settings.ExtraRPButtonCaption <> "" Then
                rpExtraButton.Label = My.Settings.ExtraRPButtonCaption
            Else
                rpExtraButton.Label = ""
            End If
            If Not My.Settings.App_Upgraded Then
                My.Settings.Upgrade()
                My.Settings.App_Upgraded = True
                My.Settings.Save()
            End If
        End If

        If client IsNot Nothing AndAlso client.CurrentUser IsNot Nothing Then
            Me.Text = client.CurrentUser.Username
        End If
        AddHandler My.Application.StartupNextInstance, AddressOf StartupNextInstance_Event
        windowIsActive = True
        UpdateForm()
        Me.Show()
        ButtonHide.Select()
        TimerStartup.Start()
    End Sub

    Private Sub Startup_Tick(sender As Object, e As EventArgs) Handles TimerStartup.Tick
        TimerStartup.Stop()
        If My.Settings.ExitHandling() = ExitHandingWay.HIDE OrElse My.Settings.ExitHandling() = ExitHandingWay.MINIMIZE_TO_TRAY Then
            Me.Hide()
        End If
        Dim arguments As String() = Environment.GetCommandLineArgs()
        For Each arg In arguments
            Select Case arg.ToLower
                Case "-show"
                    Me.Show()
                Case "-hide"
                    Me.Hide()
                Case "-noextrabutton"
                    rpExtraButton.Label = ""
                Case "-extrabutton"
                    My.Settings.ExtraRPButtonCaption = "Matchmaking"
                    rpExtraButton.Label = "Matchmaking"
            End Select
        Next
        TimerStartup.Dispose()
    End Sub

    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Select Case e.CloseReason
            Case CloseReason.WindowsShutDown, CloseReason.TaskManagerClosing
                End
            Case Else
                Dim remember As Boolean = True
                If My.Settings.ExitHandling = ExitHandingWay.ASK Then
                    Using d As New DialogExit
                        Select Case d.ShowDialog
                            Case DialogResult.OK
                                If d.UserChoice <> 0 Then
                                    My.Settings.ExitHandling = d.UserChoice
                                    If d.RememberChoice Then
                                        My.Settings.Save()
                                    Else
                                        remember = False
                                    End If
                                End If
                            Case DialogResult.Cancel
                                d.Dispose()
                                e.Cancel = True
                                Exit Sub
                        End Select
                    End Using
                End If
                Select Case My.Settings.ExitHandling
                    Case ExitHandingWay.MINIMIZE_TO_TRAY
                        If remember = False Then My.Settings.ExitHandling = 0
                        e.Cancel = True
                        NotifyIcon1.Visible = True
                        Hide()
                        windowIsActive = False
                        Exit Sub
                    Case ExitHandingWay.HIDE
                        If remember = False Then My.Settings.ExitHandling = 0
                        e.Cancel = True
                        NotifyIcon1.Visible = False
                        Hide()
                        windowIsActive = False
                        Exit Sub
                    Case ExitHandingWay.EXIT_PROGRAM
                        If remember = False Then My.Settings.ExitHandling = 0
                        RPUpdateTimer.Stop()
                        If udp IsNot Nothing Then
                            udp.Close()
                        End If
                        CloseRP()
                End Select
        End Select
        If client IsNot Nothing Then
            If Not client.IsDisposed Then
                RPUpdateTimer.Stop()
                client.Dispose()
            End If
        End If
    End Sub

    Private Sub FormMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        windowIsActive = True
        UpdateForm()
    End Sub

    Private Sub StartupNextInstance_Event()
        Me.Show()
        Me.BringToFront()
        Me.Select()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        On Error Resume Next
        CloseRP()
        My.Settings.Save()
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonOptions.Click
        optionsForm = New FormOptions
        optionsForm.parent = Me
        optionsForm.ShowDialog()
        optionsForm.Close()
        optionsForm.Dispose()
        optionsForm = Nothing
        ApplySettings()
        SaveData()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonHide.Click
        Hide()
        windowIsActive = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
TheBegining:
        Try
            Dim res As String
            Select Case e.Button
                Case MouseButtons.Left
                    res = AddAppToStartup(False, True)
                Case MouseButtons.Right
                    res = AddAppToStartup(True, True)
            End Select
            If res IsNot Nothing Then
                If res <> "" Then
                    If MessageBox.Show(res, "Error adding/removing registry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = DialogResult.Retry Then
                        GoTo TheBegining
                    End If
                End If
            End If
        Catch ex As Exception
            If MessageBox.Show(ex.Message, "Error adding/removing registry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = DialogResult.Retry Then
                GoTo TheBegining
            End If
        End Try
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.BringToFront()
        Me.Select()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        On Error Resume Next
        RPUpdateTimer.Stop()
        CloseRP()
        My.Settings.Save()
        End
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Show()
        Me.BringToFront()
        Me.Select()
    End Sub

    Private Sub RPUpdateTimer_Tick(sender As Object, e As EventArgs) Handles RPUpdateTimer.Tick
        DoTheMainPurpose()
    End Sub

    Private Sub ButtonMakePriv_Click(sender As Object, e As EventArgs) Handles ButtonMakePriv.Click
        Dim res = makeCurrentServerPrivate()
        If res = "" Then
            MsgBox("Server has been added.")
        Else
            MsgBox(String.Format("Error: {0}.", res))
        End If
    End Sub

    Private Sub MakeServerPrivateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MakeServerPrivateToolStripMenuItem.Click
        Dim res = makeCurrentServerPrivate()
        If res = "" Then
            MsgBox("Server has been added.")
        Else
            MsgBox(String.Format("Error: {0}.", res))
        End If
    End Sub

    Function makeCurrentServerPrivate() As String
        Try
            If jazz2Process IsNot Nothing AndAlso jazz2Process.HasExited = False Then
                If jj2.Game_Data.GameConnection <> JJ2Reader.JJ2_Game_Data.GAME_CONNECTION.NONE AndAlso jj2.Game_Data.ClientID <> 0 AndAlso jj2.Client_Data.ServerPort <> 0 Then
                    Dim remoteHostIP As String = BytesToStringIP(jj2.Client_Data.ServerIPAddressBytes)
                    If remoteHostIP <> "0.0.0.0" Then
                        Dim newEntry As String = remoteHostIP & ":" & jj2.Client_Data.ServerPort
                        If StringArrayContains(jazz2PrivateServers, newEntry) = False Then
                            Dim newRes As New List(Of String)
                            newRes.AddRange(jazz2PrivateServers)
                            newRes.Add(remoteHostIP & ":" & jj2.Client_Data.ServerPort)
                            jazz2PrivateServers = newRes.ToArray
                        Else
                            Return "Entry is already added"
                        End If
                    Else
                        Return "Invalid IP address"
                    End If
                Else
                    Return "JJ2 is not connected to a server"
                End If
            Else
                Return "JJ2 is not running"
            End If
        Catch ex As Exception
            Return String.Format(ex.Message)
        End Try
        Return ""
    End Function

    Sub UpdateForm()
        If windowIsActive Then
            If (client IsNot Nothing) AndAlso (client.IsDisposed = False) Then
                If client.CurrentUser IsNot Nothing Then
                    LabelDcUsername.Text = client.CurrentUser.Username
                End If
                LabelRPDetails.Text = rp.Details
                LabelRPState.Text = rp.State
            Else
                LabelDcUsername.Text = ""
                LabelRPDetails.Text = ""
                LabelRPState.Text = ""
            End If
            LabelJJ2Name.Text = jj2.Game_Data.LocalPlayersNames(0)
            If jj2 IsNot Nothing AndAlso gameVersion <> 0 Then LabelGameVersion.Text = "1." & gameVersion Else LabelGameVersion.Text = "-"
        End If
    End Sub

    Sub ApplySettings()
        Select Case My.Settings.CpuUsage
            Case 0 'Lowest
                RPUpdateTimer.Interval = 1000 * (60 * 3)
            Case 1 'Lower
                RPUpdateTimer.Interval = 1000 * 60
            Case 2 'Low
                RPUpdateTimer.Interval = 1000 * 30
            Case 3 'Medium
                RPUpdateTimer.Interval = 1000 * 10
            Case 4 'High
                RPUpdateTimer.Interval = 1000 * 1
        End Select
        If My.Settings.ExitHandling = ExitHandingWay.MINIMIZE_TO_TRAY OrElse My.Settings.App_TrayIcon Then
            NotifyIcon1.Visible = True
        Else
            NotifyIcon1.Visible = False
        End If

    End Sub

    Sub LoadData()
        Dim res As String()

        If IO.File.Exists(IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jazz2processes.txt")) Then
            res = Storage.LoadStringArray(IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jazz2processes.txt"))
        Else
            res = Storage.LoadStringArray(IO.Path.Combine(Application.LocalUserAppDataPath, "jazz2processes.txt"))
        End If
        If res.Length > 0 Then
            jazz2ProcessNames = res
        End If

        If IO.File.Exists(IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "playernames.txt")) Then
            res = Storage.LoadStringArray(IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "playernames.txt"))
        Else
            res = Storage.LoadStringArray(IO.Path.Combine(Application.LocalUserAppDataPath, "playernames.txt"))
        End If
        If res.Length > 0 Then
            jazz2PublicNames = res
        End If

        If IO.File.Exists(IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "privateservers.txt")) Then
            res = Storage.LoadStringArray(IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "privateservers.txt"))
        Else
            res = Storage.LoadStringArray(IO.Path.Combine(Application.LocalUserAppDataPath, "privateservers.txt"))
        End If
        If res.Length > 0 Then
            jazz2PrivateServers = res
        End If
    End Sub

    Sub SaveData()
        Storage.SaveStringArray(IO.Path.Combine(Application.LocalUserAppDataPath, "jazz2processes.txt"), jazz2ProcessNames)
        Storage.SaveStringArray(IO.Path.Combine(Application.LocalUserAppDataPath, "playernames.txt"), jazz2PublicNames)
        Storage.SaveStringArray(IO.Path.Combine(Application.LocalUserAppDataPath, "privateservers.txt"), jazz2PrivateServers)
    End Sub

    Const jazz2Url As String = "jazz2://{0}:{1}/"
    Sub DoTheMainPurpose()

        'Check if jazz2 is has exited
        If jazz2Process IsNot Nothing Then
            If jazz2Process.HasExited Then
                jazz2Process.Dispose()
                jazz2Process = Nothing
                UpdateForm()
            End If
        End If

        'Open jazz2 once
        If jazz2Process Is Nothing Then
            For Each exeName In jazz2ProcessNames
                Dim jj2s = Process.GetProcessesByName(exeName)
                If jj2s.Length > 0 Then
                    If My.Settings.LatestProccessPriority = False Then
                        jazz2Process = jj2s(0) 'take the first one.
                    Else
                        jazz2Process = jj2s(jj2s.Length - 1) 'take the last one.
                    End If
                    Dim hProccess As IntPtr
                    Dim openRes = jj2.OpenJJ2Proccess(jazz2Process.Id, hProccess)
                    If openRes = "" Then
                        jj2._jazz2ProcId = jazz2Process.Id
                        jj2._hProcess = hProccess
                        Dim gameVer As Integer = JJ2Reader.JJ2MemoryReader.TryDetectGameVersion(hProccess)
                        If gameVer <> 0 Then
                            If gameVer <> gameVersion Then
                                gameVersion = gameVer
                                jj2.InitMemoryAddressVanilla(gameVer)
                            End If
                            If jj2._plusDllAddress <> plusDllAddress Then
                                jj2.InitMemoryAddress(IIf(jj2._plusDllAddress <> 0, &H50009, &H0))
                            End If
                            If client Is Nothing Then
                                Call RpMain(Environment.GetCommandLineArgs)
                            End If
                        Else
                            Log(String.Format("[{0}] At [{1}] - {2}", Date.Now, "DoMain", "Version could not be detected"))
                            GoTo CloseProcess
                        End If
                    Else
CloseProcess:
                        jazz2Process.Dispose()
                        jazz2Process = Nothing
                        CloseRP()
                        Log(String.Format("[{0}] At [{1}] - {2}", Date.Now, "DoMain", openRes))
                    End If
                    Exit For
                End If
            Next
        End If

        'Now RP info
        If jazz2Process IsNot Nothing Then
            Dim rpDetails As String = ""
            Dim rpState As String = ""
            Dim buttonsUpdated As Boolean = False
            joinUrl = ""

            If My.Settings.FullPrivacyMode = False Then
                jj2.DoEvents(IntPtr.Zero) 'Reads jazz2 memory

                If jj2.General_Data.InGame <> False Then
                    Dim isNamePublic As Boolean = True
                    If jj2.General_Data.PartyMode <> False Then
                        If jj2.Game_Data.GameConnection = JJ2Reader.JJ2_Game_Data.GAME_CONNECTION.NONE Then
                            If My.Settings.Privacy_State_InGame Then rpState = "In-Game" Else rpState = ""
                            If My.Settings.Privacy_Details_SplitScreen Then rpDetails = "Local Splitscreen" Else rpDetails = ""
                        Else
                            If jazz2PublicNames.Length > 0 Then
                                isNamePublic = False
                                Dim playerName As String = jj2.Game_Data.LocalPlayersNames(0).ToLower
                                For Each pName In jazz2PublicNames
                                    If playerName.EndsWith(pName) OrElse playerName.StartsWith(pName) Then
                                        isNamePublic = True
                                        Exit For
                                    End If
                                Next
                            End If
                            If isNamePublic Then
                                If jj2.Game_Data.ClientID = 0 Then 'Hosting Server
                                    If My.Settings.Privacy_State_InOnlineGame Then rpState = "In-Game"
                                    If My.Settings.Privacy_Details_HostedServerName Then rpDetails = String.Format("Hosting: {0}", jj2.Server_Data.ServerName) Else rpDetails = ""
                                Else 'Client
                                    If jj2._plusDllAddress <> 0 Then 'If JJ2+ 
                                        If jj2.Game_Data_Plus.SpectatorMode = False Then
                                            If jj2.Game_Data_Plus.GameStarted OrElse jj2.Game_Data_Plus.GameState <> JJ2Reader.JJ2_Game_Data_Plus.JJ2_GAME_STATE.STOPPED Then
                                                If My.Settings.Privacy_State_InOnlineGame Then rpState = "Playing Online"
                                            Else
                                                If My.Settings.Privacy_State_NoGame Then rpState = My.Settings.String_NoGame
                                            End If
                                        Else
                                            If My.Settings.Privacy_State_Spectating Then rpState = "Spectating a Game"
                                        End If
                                    Else 'If JJ2 vanilla
                                        If My.Settings.Privacy_State_InOnlineGame Then rpState = "Playing Online"
                                    End If
                                    Dim serverIP As String
                                    Dim serverName As String = jj2.Client_Data.ServerName
                                    Dim privServer As Boolean
                                    If jj2.Client_Data.ServerPort <> 0 AndAlso jj2.Client_Data.ServerIPAddressBytes(0) <> 0 OrElse jj2.Client_Data.ServerIPAddressBytes(0) <> 0 OrElse jj2.Client_Data.ServerIPAddressBytes(0) <> 0 OrElse jj2.Client_Data.ServerIPAddressBytes(0) <> 0 Then ' if IP is not 0.0.0.0
                                        serverIP = BytesToStringIP(jj2.Client_Data.ServerIPAddressBytes)
                                    End If

                                    If My.Settings.DisableServerQuery = False Then
                                        Dim timeElapsed = Date.Now.Subtract(qDate).TotalMilliseconds
                                        If (serverName = "" OrElse My.Settings.AlwaysQueryServerInfo OrElse timeElapsed >= My.Settings.QueryDelay) AndAlso serverIP IsNot Nothing Then
                                            qRes.ServerName = ""
                                            If ServerQuery.Query(qRes, udp, serverIP, jj2.Client_Data.ServerPort) Then 'query server info
                                                qDate = Date.Now
                                                serverName = qRes.ServerName
                                                privServer = qRes.PrivateServer
                                            End If
                                        End If
                                    End If

                                    Dim isHiddenServer As Boolean = False
                                    If serverIP IsNot Nothing Then
                                        Dim serverEP As String = serverIP & ":" & jj2.Client_Data.ServerPort
                                        For Each host In jazz2PrivateServers
                                            If host = serverEP Then
                                                isHiddenServer = True
                                                Exit For
                                            End If
                                        Next

                                    End If

                                    If My.Settings.Privacy_Details_Location AndAlso isHiddenServer = False AndAlso serverName <> "" Then
                                        rpDetails = String.Format("At: {0}", serverName.Replace("|", ""))
                                    End If
                                    If My.Settings.RP_JoinGameButton AndAlso privServer = False AndAlso isHiddenServer = False AndAlso serverIP IsNot Nothing Then
                                        If isHiddenServer = False AndAlso Not (serverIP.StartsWith("192.168") OrElse serverIP.StartsWith("127") OrElse serverIP.StartsWith("10.") OrElse serverIP.StartsWith("172.16.") OrElse serverIP.StartsWith("169.254")) Then 'check if not LAN / hidden
                                            joinUrl = String.Format(jazz2Url, serverIP, jj2.Client_Data.ServerPort)
                                        End If
                                    End If
                                    '//   rp.Party = New Party With {.Max = 32, .Privacy = Party.PrivacySetting.Public, .Size = 2}
                                    '//   rp.Secrets = New Secrets With {.JoinSecret = String.Format(jazz2Url, BytesToStringIP(jj2.Client_Data.ServerIPAddressBytes), jj2.Client_Data.ServerPort)}
                                End If
                            End If
                        End If
                        If My.Settings.Privacy_Details_GameMode AndAlso isNamePublic Then
                            Dim gameModeStr As String = GetGameModeString(jj2.Game_Data.GameType, jj2.Game_Data_Plus.customGameMode)
                            If gameModeStr <> "" Then
                                rpDetails = rpDetails & String.Format(" - Mode: {0}", gameModeStr)
                                If rpDetails.StartsWith(" - ") Then rpDetails = rpDetails.Substring(3)
                            End If
                        End If
                        RpUpdateTimeStamps()
                    Else
                        If My.Settings.Privacy_State_InGame Then rpState = "In-Game" Else rpState = ""
                        If My.Settings.Privacy_Details_SinglePlayer Then rpDetails = My.Settings.String_SinglePlayer Else rpDetails = ""
                    End If
                    If My.Settings.Privacy_Details_LevelName AndAlso isNamePublic Then
                        If jj2.Level_Data.Title <> "" Then
                            rpDetails = rpDetails & String.Format(" - {0}: {1}", IIf(jj2.Game_Data.GameType > 1, "Map", "Level"), jj2.Level_Data.Title)
                            If rpDetails.StartsWith(" - ") Then rpDetails = rpDetails.Substring(3)
                        End If
                    End If
                Else
                    If My.Settings.Privacy_State_InMenu Then rpState = "In Menu" Else rpState = ""
                End If
            End If

            If rpDetails.Length > 127 Then rpDetails = rpDetails.Substring(0, 126)
            If rpState.Length > 127 Then rpState = rpState.Substring(0, 126)

            If My.Settings.RP_SwapStateDetails Then
                Dim tempStr = rpDetails
                rpDetails = rpState
                rpState = tempStr
            End If

            If rp.Details <> rpDetails OrElse rp.State <> rpState OrElse rpJoinButton.Url <> joinUrl Then
                rp.Details = rpDetails
                rp.State = rpState
                If joinUrl <> "" Then
                    rpJoinButton.Url = joinUrl
                    If Not rp.Buttons(0).Equals(rpJoinButton) Then
                        ReDim rp.Buttons(1)
                        rp.Buttons(0) = rpJoinButton
                        rp.Buttons(1) = rpExtraButton
                    End If
                Else
                    If rp.Buttons(0).Equals(rpJoinButton) Then
                        ReDim rp.Buttons(0)
                        rp.Buttons(0) = rpExtraButton
                    End If
                End If
                UpdatePresence()
                UpdateForm()
            End If

        Else
            'remove RP
            CloseRP()
        End If
    End Sub

    Sub RpUpdateTimeStamps()
        Exit Sub
        If jj2._plusDllAddress <> 0 Then
            If jj2.Game_Data_Plus.GameStarted AndAlso jj2.Game_Data_Plus.timerType = JJ2Reader.JJ2_Game_Data_Plus.JJ2_TIMER_TYPE.TIMELIMIT Then
                rp.Timestamps = New Timestamps() With
              {
                  .Start = DateTime.UtcNow, .End = DateTime.UtcNow + TimeSpan.FromMilliseconds(jj2.Game_Data_Plus.TimeRemaining)
              }
            Else
                If rp.HasTimestamps Then
                    RpRemoveTimeStamps()
                End If
            End If
        Else
            If rp.HasTimestamps Then
                RpRemoveTimeStamps()
            End If
        End If
    End Sub

    Sub RpRemoveTimeStamps()

    End Sub

    Sub Log(txt As String)
        Try
            IO.File.AppendAllText(IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "programlog.txt"), txt & vbNewLine)
        Catch ex As Exception
        End Try
    End Sub



    '---------------------------------------------------------------------------
    ''Discord RP Part
    '---------------------------------------------------------------------------
    Private logLevel As DiscordRPC.Logging.LogLevel = Logging.LogLevel.Trace

    Private discordPipe As Integer = -1

    Private presence As RichPresence = New RichPresence() With {
    .Details = "Example Project 🎁",
    .State = "csharp example",
    .Assets = New Assets() With {
        .LargeImageKey = "image_large",
        .LargeImageText = "Lachee's Discord IPC Library",
        .SmallImageKey = "image_small"
        }
    }

    Private rp As RichPresence = New RichPresence()
    Private WithEvents client As DiscordRpcClient

    Private rpJoinButton As DiscordRPC.Button = New DiscordRPC.Button With {.Label = "Join Game", .Url = "jazz2://0.0.0.0:10052/"}
    Private rpExtraButton As DiscordRPC.Button = New DiscordRPC.Button With {.Label = "Matchmaking", .Url = "https://dsc.gg/jj2"}


    Private isRunning = True
    Private word As StringBuilder = New StringBuilder

    Sub RpMain(args As String())
        'Reads the arguments for the pipe
        For i As Integer = 0 To args.Length - 1
            Select Case args(i)
                Case "-pipe"
                    i += 1
                    discordPipe = Integer.Parse(args(i))
                    Exit Select
                Case Else
                    Exit Select
            End Select
        Next

        BasicExample()
    End Sub
    Sub CreateRPClient()

    End Sub
    Sub UpdatePresence()
        client.SetPresence(rp)
    End Sub
    Sub BasicExample()
        ' == Create the client
        client = New DiscordRpcClient("865611220216184833", pipe:=discordPipe) With {
            .Logger = New Logging.ConsoleLogger(logLevel, True)}

        ' == Subscribe to some events
        'done

        ' == Initialize
        client.Initialize()

        ' == Set the presence
        If True Then
            rp.Details = ""
            rp.State = ""
            rp.Assets = New Assets()
            rp.Assets.LargeImageKey = "jazz2"
            rp.Assets.LargeImageText = "JJ2"
            rp.Party = New Party
            ReDim rp.Buttons(0)
            rp.Buttons(0) = rpExtraButton
        End If

        'old learning code
        If False Then
            rp.Details = "At: Gem Collecting Challenge"
            rp.State = "Playing Treasure Hunt Online"
            rp.Assets = New Assets()
            rp.Assets.LargeImageKey = "jazz2"
            rp.Assets.LargeImageText = "JJ2"
            rp.Party = New Party
            ReDim rp.Buttons(1)
            rp.Buttons(0) = New DiscordRPC.Button
            rp.Buttons(0).Label = "Join Game"
            rp.Buttons(0).Url = "jazz2://95.219.60.180:10053/"
            rp.Buttons(1) = New DiscordRPC.Button
            rp.Buttons(1).Label = "Matchmaking"
            rp.Buttons(1).Url = "https://dsc.gg/jj2"
            client.SetPresence(rp)
        End If

    End Sub
    Sub CloseRP()
        If client IsNot Nothing Then
            If Not client.IsDisposed Then
                client.ClearPresence()
                client.Dispose()
            End If
            client = Nothing
        End If
    End Sub
    Private Sub client_OnReady(sender As Object, msg As ReadyMessage) Handles client.OnReady
        'Create some events so we know things are happening
#If DEBUG Then
          Console.WriteLine("Connected to discord with user {0}", msg.User.Username)
#End If
    End Sub
    Private Sub client_OnPresenceUpdate(sender As Object, msg As PresenceMessage) Handles client.OnPresenceUpdate
        'The presence has updated
#If DEBUG Then
            Console.WriteLine("Presence has been updated! ")
#End If
    End Sub
    Private Sub client_OnConnectionEstablished(sender As Object, args As ConnectionEstablishedMessage) Handles client.OnConnectionEstablished
        If client IsNot Nothing AndAlso client.CurrentUser IsNot Nothing Then
            Me.Text = client.CurrentUser.Username
        End If
    End Sub
    Private Sub client_OnClose(sender As Object, args As CloseMessage) Handles client.OnClose
        '   MsgBox("close")
        ' client.Dispose()
    End Sub



    '---------------------------------------------------------------------------
    ''Jazz2 Part
    '---------------------------------------------------------------------------
    Dim qRes As New ServerQuery.QueryResult
    Dim qDate As Date
    Public Shared GameModeStrings As String() = {"Cooperative", "Cooperative", "Battle", "Race", "Treasure Hunt", "CTF"}
    Public Shared CustomModeStrings As String() = {"", "Roast Tag", "LRS", "XLRS", "Pestilence", "", "", "", "", "", "", "Team Battle", "Jailbreak", "Death CTF", "Flag Run", "TLRS", "Domination", "Head Hunters"}
    Private WithEvents jj2 As JJ2Reader.JJ2MemoryReader
    Sub initJJ2()
        jj2 = New JJ2Reader.JJ2MemoryReader
    End Sub
    Function GetGameModeString(gameMode As Byte, Optional customGameMode As Byte = 0) As String
        If customGameMode = 0 Then
            If gameMode < GameModeStrings.Length Then
                Return GameModeStrings(gameMode)
            End If
        Else
            If customGameMode < CustomModeStrings.Length Then
                Return CustomModeStrings(customGameMode)
            End If
        End If
        Return ""
    End Function
    Private Function BytesToStringIP(ByVal buff As Byte()) As String
        Return buff(3) & "." & buff(2) & "." & buff(1) & "." & buff(0)
    End Function
End Class
