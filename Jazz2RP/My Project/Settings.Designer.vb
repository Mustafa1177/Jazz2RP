'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UdpDisabled() As Boolean
            Get
                Return CType(Me("UdpDisabled"),Boolean)
            End Get
            Set
                Me("UdpDisabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property FullPrivacyMode() As Boolean
            Get
                Return CType(Me("FullPrivacyMode"),Boolean)
            End Get
            Set
                Me("FullPrivacyMode") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property AlwaysQueryServerInfo() As Boolean
            Get
                Return CType(Me("AlwaysQueryServerInfo"),Boolean)
            End Get
            Set
                Me("AlwaysQueryServerInfo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property LatestProccessPriority() As Boolean
            Get
                Return CType(Me("LatestProccessPriority"),Boolean)
            End Get
            Set
                Me("LatestProccessPriority") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public Property RP_TimerSource() As Integer
            Get
                Return CType(Me("RP_TimerSource"),Integer)
            End Get
            Set
                Me("RP_TimerSource") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property LoggerEnabled() As Boolean
            Get
                Return CType(Me("LoggerEnabled"),Boolean)
            End Get
            Set
                Me("LoggerEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Matchmaking")>  _
        Public Property ExtraRPButtonCaption() As String
            Get
                Return CType(Me("ExtraRPButtonCaption"),String)
            End Get
            Set
                Me("ExtraRPButtonCaption") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3")>  _
        Public Property CpuUsage() As Byte
            Get
                Return CType(Me("CpuUsage"),Byte)
            End Get
            Set
                Me("CpuUsage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Privacy_Details_Location() As Boolean
            Get
                Return CType(Me("Privacy_Details_Location"),Boolean)
            End Get
            Set
                Me("Privacy_Details_Location") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Privacy_Details_HostedServerName() As Boolean
            Get
                Return CType(Me("Privacy_Details_HostedServerName"),Boolean)
            End Get
            Set
                Me("Privacy_Details_HostedServerName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Privacy_Details_GameMode() As Boolean
            Get
                Return CType(Me("Privacy_Details_GameMode"),Boolean)
            End Get
            Set
                Me("Privacy_Details_GameMode") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Privacy_Details_LevelName() As Boolean
            Get
                Return CType(Me("Privacy_Details_LevelName"),Boolean)
            End Get
            Set
                Me("Privacy_Details_LevelName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Privacy_Details_SplitScreen() As Boolean
            Get
                Return CType(Me("Privacy_Details_SplitScreen"),Boolean)
            End Get
            Set
                Me("Privacy_Details_SplitScreen") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Privacy_Details_SinglePlayer() As Boolean
            Get
                Return CType(Me("Privacy_Details_SinglePlayer"),Boolean)
            End Get
            Set
                Me("Privacy_Details_SinglePlayer") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Privacy_State_InMenu() As Boolean
            Get
                Return CType(Me("Privacy_State_InMenu"),Boolean)
            End Get
            Set
                Me("Privacy_State_InMenu") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Privacy_State_InGame() As Boolean
            Get
                Return CType(Me("Privacy_State_InGame"),Boolean)
            End Get
            Set
                Me("Privacy_State_InGame") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Privacy_State_InOnlineGame() As Boolean
            Get
                Return CType(Me("Privacy_State_InOnlineGame"),Boolean)
            End Get
            Set
                Me("Privacy_State_InOnlineGame") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Privacy_State_Spectating() As Boolean
            Get
                Return CType(Me("Privacy_State_Spectating"),Boolean)
            End Get
            Set
                Me("Privacy_State_Spectating") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Privacy_State_NoGame() As Boolean
            Get
                Return CType(Me("Privacy_State_NoGame"),Boolean)
            End Get
            Set
                Me("Privacy_State_NoGame") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public Property PrivacyLevel() As Integer
            Get
                Return CType(Me("PrivacyLevel"),Integer)
            End Get
            Set
                Me("PrivacyLevel") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Playing Online")>  _
        Public Property String_NoGame() As String
            Get
                Return CType(Me("String_NoGame"),String)
            End Get
            Set
                Me("String_NoGame") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Single Player")>  _
        Public Property String_SinglePlayer() As String
            Get
                Return CType(Me("String_SinglePlayer"),String)
            End Get
            Set
                Me("String_SinglePlayer") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property DisableServerQuery() As Boolean
            Get
                Return CType(Me("DisableServerQuery"),Boolean)
            End Get
            Set
                Me("DisableServerQuery") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("80000")>  _
        Public Property QueryDelay() As Double
            Get
                Return CType(Me("QueryDelay"),Double)
            End Get
            Set
                Me("QueryDelay") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2000")>  _
        Public Property QueryTimeout() As Integer
            Get
                Return CType(Me("QueryTimeout"),Integer)
            End Get
            Set
                Me("QueryTimeout") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property RP_JoinGameButton() As Boolean
            Get
                Return CType(Me("RP_JoinGameButton"),Boolean)
            End Get
            Set
                Me("RP_JoinGameButton") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property ExitHandling() As Integer
            Get
                Return CType(Me("ExitHandling"),Integer)
            End Get
            Set
                Me("ExitHandling") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property RP_SwapStateDetails() As Boolean
            Get
                Return CType(Me("RP_SwapStateDetails"),Boolean)
            End Get
            Set
                Me("RP_SwapStateDetails") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property App_TrayIcon() As Boolean
            Get
                Return CType(Me("App_TrayIcon"),Boolean)
            End Get
            Set
                Me("App_TrayIcon") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property App_Upgraded() As Boolean
            Get
                Return CType(Me("App_Upgraded"),Boolean)
            End Get
            Set
                Me("App_Upgraded") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Jazz2RP.My.MySettings
            Get
                Return Global.Jazz2RP.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
