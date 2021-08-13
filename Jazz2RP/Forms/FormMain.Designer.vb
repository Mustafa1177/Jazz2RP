<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RPUpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelRPState = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelRPDetails = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelTimerType = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelDcUsername = New System.Windows.Forms.Label()
        Me.ButtonOptions = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelServerName = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelJJ2Name = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel10 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelGameVersion = New System.Windows.Forms.Label()
        Me.ButtonMakePriv = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel9 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonHide = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStripTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeServerPrivateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TimerStartup = New System.Windows.Forms.Timer(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.FlowLayoutPanel8.SuspendLayout()
        Me.FlowLayoutPanel10.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel9.SuspendLayout()
        Me.ContextMenuStripTray.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(386, 287)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'RPUpdateTimer
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "State:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelRPState)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 29)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(103, 17)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'LabelRPState
        '
        Me.LabelRPState.AutoSize = True
        Me.LabelRPState.Location = New System.Drawing.Point(54, 0)
        Me.LabelRPState.Name = "LabelRPState"
        Me.LabelRPState.Size = New System.Drawing.Size(13, 17)
        Me.LabelRPState.TabIndex = 6
        Me.LabelRPState.Text = "-"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel3)
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel4)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 21)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(239, 131)
        Me.FlowLayoutPanel2.TabIndex = 7
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel3.Controls.Add(Me.LabelRPDetails)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 4)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(103, 17)
        Me.FlowLayoutPanel3.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Details:"
        '
        'LabelRPDetails
        '
        Me.LabelRPDetails.AutoSize = True
        Me.LabelRPDetails.Location = New System.Drawing.Point(61, 0)
        Me.LabelRPDetails.Name = "LabelRPDetails"
        Me.LabelRPDetails.Size = New System.Drawing.Size(13, 17)
        Me.LabelRPDetails.TabIndex = 6
        Me.LabelRPDetails.Text = "-"
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel4.AutoSize = True
        Me.FlowLayoutPanel4.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel4.Controls.Add(Me.LabelTimerType)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 54)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(103, 17)
        Me.FlowLayoutPanel4.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "TimerType:"
        '
        'LabelTimerType
        '
        Me.LabelTimerType.AutoSize = True
        Me.LabelTimerType.Location = New System.Drawing.Point(87, 0)
        Me.LabelTimerType.Name = "LabelTimerType"
        Me.LabelTimerType.Size = New System.Drawing.Size(13, 17)
        Me.LabelTimerType.TabIndex = 6
        Me.LabelTimerType.Text = "-"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(245, 156)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rich Presence"
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel5.AutoSize = True
        Me.FlowLayoutPanel5.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelDcUsername)
        Me.FlowLayoutPanel5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(10, 15)
        Me.FlowLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(505, 33)
        Me.FlowLayoutPanel5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "User:"
        '
        'LabelDcUsername
        '
        Me.LabelDcUsername.AutoSize = True
        Me.LabelDcUsername.Location = New System.Drawing.Point(85, 0)
        Me.LabelDcUsername.Name = "LabelDcUsername"
        Me.LabelDcUsername.Size = New System.Drawing.Size(23, 29)
        Me.LabelDcUsername.TabIndex = 6
        Me.LabelDcUsername.Text = "-"
        '
        'ButtonOptions
        '
        Me.ButtonOptions.Location = New System.Drawing.Point(259, 4)
        Me.ButtonOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonOptions.Name = "ButtonOptions"
        Me.ButtonOptions.Size = New System.Drawing.Size(122, 33)
        Me.ButtonOptions.TabIndex = 2
        Me.ButtonOptions.Text = "Options"
        Me.ButtonOptions.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FlowLayoutPanel6)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(254, 156)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Game"
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.FlowLayoutPanel7)
        Me.FlowLayoutPanel6.Controls.Add(Me.FlowLayoutPanel8)
        Me.FlowLayoutPanel6.Controls.Add(Me.FlowLayoutPanel10)
        Me.FlowLayoutPanel6.Controls.Add(Me.ButtonMakePriv)
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(3, 21)
        Me.FlowLayoutPanel6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(248, 131)
        Me.FlowLayoutPanel6.TabIndex = 7
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel7.AutoSize = True
        Me.FlowLayoutPanel7.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel7.Controls.Add(Me.LabelServerName)
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(3, 4)
        Me.FlowLayoutPanel7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(149, 17)
        Me.FlowLayoutPanel7.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Server:"
        '
        'LabelServerName
        '
        Me.LabelServerName.AutoSize = True
        Me.LabelServerName.Location = New System.Drawing.Point(62, 0)
        Me.LabelServerName.Name = "LabelServerName"
        Me.LabelServerName.Size = New System.Drawing.Size(13, 17)
        Me.LabelServerName.TabIndex = 6
        Me.LabelServerName.Text = "-"
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel8.AutoSize = True
        Me.FlowLayoutPanel8.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel8.Controls.Add(Me.LabelJJ2Name)
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(3, 29)
        Me.FlowLayoutPanel8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(149, 17)
        Me.FlowLayoutPanel8.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Name:"
        '
        'LabelJJ2Name
        '
        Me.LabelJJ2Name.AutoSize = True
        Me.LabelJJ2Name.Location = New System.Drawing.Point(57, 0)
        Me.LabelJJ2Name.Name = "LabelJJ2Name"
        Me.LabelJJ2Name.Size = New System.Drawing.Size(13, 17)
        Me.LabelJJ2Name.TabIndex = 6
        Me.LabelJJ2Name.Text = "-"
        '
        'FlowLayoutPanel10
        '
        Me.FlowLayoutPanel10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel10.AutoSize = True
        Me.FlowLayoutPanel10.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel10.Controls.Add(Me.LabelGameVersion)
        Me.FlowLayoutPanel10.Location = New System.Drawing.Point(3, 54)
        Me.FlowLayoutPanel10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        Me.FlowLayoutPanel10.Size = New System.Drawing.Size(149, 17)
        Me.FlowLayoutPanel10.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Patch:"
        '
        'LabelGameVersion
        '
        Me.LabelGameVersion.AutoSize = True
        Me.LabelGameVersion.Location = New System.Drawing.Point(57, 0)
        Me.LabelGameVersion.Name = "LabelGameVersion"
        Me.LabelGameVersion.Size = New System.Drawing.Size(13, 17)
        Me.LabelGameVersion.TabIndex = 6
        Me.LabelGameVersion.Text = "-"
        '
        'ButtonMakePriv
        '
        Me.ButtonMakePriv.Location = New System.Drawing.Point(3, 79)
        Me.ButtonMakePriv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonMakePriv.Name = "ButtonMakePriv"
        Me.ButtonMakePriv.Size = New System.Drawing.Size(149, 34)
        Me.ButtonMakePriv.TabIndex = 4
        Me.ButtonMakePriv.Text = "Make Server Private"
        Me.ButtonMakePriv.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(3, 4)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(122, 33)
        Me.ButtonExit.TabIndex = 0
        Me.ButtonExit.Text = "Exit Program"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 55)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(504, 156)
        Me.SplitContainer1.SplitterDistance = 245
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 3
        Me.SplitContainer1.TabStop = False
        '
        'FlowLayoutPanel9
        '
        Me.FlowLayoutPanel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel9.Controls.Add(Me.ButtonExit)
        Me.FlowLayoutPanel9.Controls.Add(Me.ButtonHide)
        Me.FlowLayoutPanel9.Controls.Add(Me.ButtonOptions)
        Me.FlowLayoutPanel9.Controls.Add(Me.LinkLabel1)
        Me.FlowLayoutPanel9.Location = New System.Drawing.Point(12, 219)
        Me.FlowLayoutPanel9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        Me.FlowLayoutPanel9.Size = New System.Drawing.Size(504, 60)
        Me.FlowLayoutPanel9.TabIndex = 13
        '
        'ButtonHide
        '
        Me.ButtonHide.Location = New System.Drawing.Point(131, 4)
        Me.ButtonHide.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonHide.Name = "ButtonHide"
        Me.ButtonHide.Size = New System.Drawing.Size(122, 33)
        Me.ButtonHide.TabIndex = 1
        Me.ButtonHide.Text = "Hide"
        Me.ButtonHide.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(387, 24)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(99, 17)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Add to Startup"
        Me.ToolTip1.SetToolTip(Me.LinkLabel1, "Right click to remove")
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(15, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Program: ON, v5.9"
        Me.ToolTip1.SetToolTip(Me.Label7, "JJ2+Target: v5.9")
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStripTray
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Jazz2RP"
        '
        'ContextMenuStripTray
        '
        Me.ContextMenuStripTray.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStripTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.MakeServerPrivateToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStripTray.Name = "ContextMenuStripTray"
        Me.ContextMenuStripTray.Size = New System.Drawing.Size(209, 76)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'MakeServerPrivateToolStripMenuItem
        '
        Me.MakeServerPrivateToolStripMenuItem.Name = "MakeServerPrivateToolStripMenuItem"
        Me.MakeServerPrivateToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.MakeServerPrivateToolStripMenuItem.Text = "Make Server Private"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TimerStartup
        '
        Me.TimerStartup.Interval = 10
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 330)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.FlowLayoutPanel9)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FlowLayoutPanel5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormMain"
        Me.Opacity = 0.98R
        Me.Text = "Jazz2RP"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.FlowLayoutPanel6.PerformLayout()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel7.PerformLayout()
        Me.FlowLayoutPanel8.ResumeLayout(False)
        Me.FlowLayoutPanel8.PerformLayout()
        Me.FlowLayoutPanel10.ResumeLayout(False)
        Me.FlowLayoutPanel10.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel9.ResumeLayout(False)
        Me.FlowLayoutPanel9.PerformLayout()
        Me.ContextMenuStripTray.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents RPUpdateTimer As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents LabelRPState As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelRPDetails As Label
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelTimerType As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelDcUsername As Label
    Friend WithEvents ButtonOptions As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelServerName As Label
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelJJ2Name As Label
    Friend WithEvents ButtonMakePriv As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents FlowLayoutPanel9 As FlowLayoutPanel
    Friend WithEvents ButtonHide As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents FlowLayoutPanel10 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelGameVersion As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ContextMenuStripTray As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakeServerPrivateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerStartup As Timer
End Class
