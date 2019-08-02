<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grp_Devices = New System.Windows.Forms.GroupBox()
        Me.btn_RefreshDevices = New System.Windows.Forms.Button()
        Me.btn_UseSelectedDevice = New System.Windows.Forms.Button()
        Me.dgv_Devices = New System.Windows.Forms.DataGridView()
        Me.grp_Sync = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.grp_PlaylistFiles = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_PlaylistFiles_Add = New System.Windows.Forms.Button()
        Me.btn_PlaylistFiles_Remove = New System.Windows.Forms.Button()
        Me.dgv_PlaylistFiles = New System.Windows.Forms.DataGridView()
        Me.grp_SelectedDevice = New System.Windows.Forms.GroupBox()
        Me.lbl_Sync_PlaylistWithAddedTracks = New System.Windows.Forms.Label()
        Me.txt_Sync_PlaylistWithAddedTracks = New System.Windows.Forms.TextBox()
        Me.chk_Sync_CreatePlaylistWithAddedTracks = New System.Windows.Forms.CheckBox()
        Me.chk_Sync_SyncPlaylists = New System.Windows.Forms.CheckBox()
        Me.chk_Sync_Convert = New System.Windows.Forms.CheckBox()
        Me.txt_Sync_LAMEoptions = New System.Windows.Forms.TextBox()
        Me.lbl_Sync_LAMEoptions = New System.Windows.Forms.Label()
        Me.chk_Sync_EmbedCover = New System.Windows.Forms.CheckBox()
        Me.btn_SetMainMusicFolder_Remote = New System.Windows.Forms.Button()
        Me.lbl_Sync_MainMusicFolder_Remote = New System.Windows.Forms.Label()
        Me.txt_Sync_MainMusicFolder_Remote = New System.Windows.Forms.TextBox()
        Me.btn_SetMainMusicFolder_Local = New System.Windows.Forms.Button()
        Me.txt_Sync_MainMusicFolder_Local = New System.Windows.Forms.TextBox()
        Me.lbl_Sync_MainMusicFolder_Local = New System.Windows.Forms.Label()
        Me.pic_Progress = New System.Windows.Forms.PictureBox()
        Me.lbl_Sync_StorageInfo = New System.Windows.Forms.Label()
        Me.txt_Sync_DeviceName = New System.Windows.Forms.TextBox()
        Me.lbl_Sync_DeviceName = New System.Windows.Forms.Label()
        Me.prb_SyncPlaylists = New System.Windows.Forms.ProgressBar()
        Me.btn_Sync_Sync = New System.Windows.Forms.Button()
        Me.txt_Log = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.grp_Devices.SuspendLayout()
        CType(Me.dgv_Devices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Sync.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grp_PlaylistFiles.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgv_PlaylistFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_SelectedDevice.SuspendLayout()
        CType(Me.pic_Progress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_Devices
        '
        Me.grp_Devices.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Devices.Controls.Add(Me.btn_RefreshDevices)
        Me.grp_Devices.Controls.Add(Me.btn_UseSelectedDevice)
        Me.grp_Devices.Controls.Add(Me.dgv_Devices)
        Me.grp_Devices.Location = New System.Drawing.Point(12, 12)
        Me.grp_Devices.Name = "grp_Devices"
        Me.grp_Devices.Size = New System.Drawing.Size(980, 201)
        Me.grp_Devices.TabIndex = 1
        Me.grp_Devices.TabStop = False
        Me.grp_Devices.Text = "Devices"
        '
        'btn_RefreshDevices
        '
        Me.btn_RefreshDevices.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_RefreshDevices.Image = Global.PLSsync.My.Resources.Resources.arrow_refresh
        Me.btn_RefreshDevices.Location = New System.Drawing.Point(827, 155)
        Me.btn_RefreshDevices.Name = "btn_RefreshDevices"
        Me.btn_RefreshDevices.Size = New System.Drawing.Size(147, 38)
        Me.btn_RefreshDevices.TabIndex = 2
        Me.btn_RefreshDevices.Text = "Refresh Device List"
        Me.btn_RefreshDevices.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_RefreshDevices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_RefreshDevices.UseVisualStyleBackColor = True
        '
        'btn_UseSelectedDevice
        '
        Me.btn_UseSelectedDevice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_UseSelectedDevice.Image = Global.PLSsync.My.Resources.Resources.accept
        Me.btn_UseSelectedDevice.Location = New System.Drawing.Point(6, 155)
        Me.btn_UseSelectedDevice.Name = "btn_UseSelectedDevice"
        Me.btn_UseSelectedDevice.Size = New System.Drawing.Size(815, 38)
        Me.btn_UseSelectedDevice.TabIndex = 1
        Me.btn_UseSelectedDevice.Text = "use selected device"
        Me.btn_UseSelectedDevice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_UseSelectedDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_UseSelectedDevice.UseVisualStyleBackColor = True
        '
        'dgv_Devices
        '
        Me.dgv_Devices.AllowUserToAddRows = False
        Me.dgv_Devices.AllowUserToDeleteRows = False
        Me.dgv_Devices.AllowUserToOrderColumns = True
        Me.dgv_Devices.AllowUserToResizeRows = False
        Me.dgv_Devices.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Devices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Devices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Devices.Location = New System.Drawing.Point(6, 19)
        Me.dgv_Devices.Name = "dgv_Devices"
        Me.dgv_Devices.Size = New System.Drawing.Size(968, 130)
        Me.dgv_Devices.TabIndex = 0
        '
        'grp_Sync
        '
        Me.grp_Sync.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Sync.Controls.Add(Me.TableLayoutPanel2)
        Me.grp_Sync.Controls.Add(Me.prb_SyncPlaylists)
        Me.grp_Sync.Controls.Add(Me.btn_Sync_Sync)
        Me.grp_Sync.Controls.Add(Me.txt_Log)
        Me.grp_Sync.Location = New System.Drawing.Point(12, 219)
        Me.grp_Sync.Name = "grp_Sync"
        Me.grp_Sync.Size = New System.Drawing.Size(980, 445)
        Me.grp_Sync.TabIndex = 2
        Me.grp_Sync.TabStop = False
        Me.grp_Sync.Text = "Sync"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.grp_PlaylistFiles, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.grp_SelectedDevice, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(7, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(967, 283)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'grp_PlaylistFiles
        '
        Me.grp_PlaylistFiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_PlaylistFiles.Controls.Add(Me.TableLayoutPanel1)
        Me.grp_PlaylistFiles.Controls.Add(Me.dgv_PlaylistFiles)
        Me.grp_PlaylistFiles.Location = New System.Drawing.Point(486, 3)
        Me.grp_PlaylistFiles.Name = "grp_PlaylistFiles"
        Me.grp_PlaylistFiles.Size = New System.Drawing.Size(478, 212)
        Me.grp_PlaylistFiles.TabIndex = 2
        Me.grp_PlaylistFiles.TabStop = False
        Me.grp_PlaylistFiles.Text = "Playlist files"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_PlaylistFiles_Add, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_PlaylistFiles_Remove, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 168)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(466, 38)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btn_PlaylistFiles_Add
        '
        Me.btn_PlaylistFiles_Add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_PlaylistFiles_Add.Image = Global.PLSsync.My.Resources.Resources.add
        Me.btn_PlaylistFiles_Add.Location = New System.Drawing.Point(0, 0)
        Me.btn_PlaylistFiles_Add.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.btn_PlaylistFiles_Add.Name = "btn_PlaylistFiles_Add"
        Me.btn_PlaylistFiles_Add.Size = New System.Drawing.Size(230, 38)
        Me.btn_PlaylistFiles_Add.TabIndex = 0
        Me.btn_PlaylistFiles_Add.Text = "add Playlist File"
        Me.btn_PlaylistFiles_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_PlaylistFiles_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_PlaylistFiles_Add.UseVisualStyleBackColor = True
        '
        'btn_PlaylistFiles_Remove
        '
        Me.btn_PlaylistFiles_Remove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_PlaylistFiles_Remove.Image = Global.PLSsync.My.Resources.Resources.delete
        Me.btn_PlaylistFiles_Remove.Location = New System.Drawing.Point(236, 0)
        Me.btn_PlaylistFiles_Remove.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.btn_PlaylistFiles_Remove.Name = "btn_PlaylistFiles_Remove"
        Me.btn_PlaylistFiles_Remove.Size = New System.Drawing.Size(230, 38)
        Me.btn_PlaylistFiles_Remove.TabIndex = 1
        Me.btn_PlaylistFiles_Remove.Text = "remove Playlist File"
        Me.btn_PlaylistFiles_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_PlaylistFiles_Remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_PlaylistFiles_Remove.UseVisualStyleBackColor = True
        '
        'dgv_PlaylistFiles
        '
        Me.dgv_PlaylistFiles.AllowUserToAddRows = False
        Me.dgv_PlaylistFiles.AllowUserToDeleteRows = False
        Me.dgv_PlaylistFiles.AllowUserToResizeRows = False
        Me.dgv_PlaylistFiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_PlaylistFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_PlaylistFiles.Location = New System.Drawing.Point(6, 19)
        Me.dgv_PlaylistFiles.Name = "dgv_PlaylistFiles"
        Me.dgv_PlaylistFiles.Size = New System.Drawing.Size(466, 143)
        Me.dgv_PlaylistFiles.TabIndex = 0
        '
        'grp_SelectedDevice
        '
        Me.grp_SelectedDevice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_SelectedDevice.Controls.Add(Me.lbl_Sync_PlaylistWithAddedTracks)
        Me.grp_SelectedDevice.Controls.Add(Me.txt_Sync_PlaylistWithAddedTracks)
        Me.grp_SelectedDevice.Controls.Add(Me.chk_Sync_CreatePlaylistWithAddedTracks)
        Me.grp_SelectedDevice.Controls.Add(Me.chk_Sync_SyncPlaylists)
        Me.grp_SelectedDevice.Controls.Add(Me.chk_Sync_Convert)
        Me.grp_SelectedDevice.Controls.Add(Me.txt_Sync_LAMEoptions)
        Me.grp_SelectedDevice.Controls.Add(Me.lbl_Sync_LAMEoptions)
        Me.grp_SelectedDevice.Controls.Add(Me.chk_Sync_EmbedCover)
        Me.grp_SelectedDevice.Controls.Add(Me.btn_SetMainMusicFolder_Remote)
        Me.grp_SelectedDevice.Controls.Add(Me.lbl_Sync_MainMusicFolder_Remote)
        Me.grp_SelectedDevice.Controls.Add(Me.txt_Sync_MainMusicFolder_Remote)
        Me.grp_SelectedDevice.Controls.Add(Me.btn_SetMainMusicFolder_Local)
        Me.grp_SelectedDevice.Controls.Add(Me.txt_Sync_MainMusicFolder_Local)
        Me.grp_SelectedDevice.Controls.Add(Me.lbl_Sync_MainMusicFolder_Local)
        Me.grp_SelectedDevice.Controls.Add(Me.pic_Progress)
        Me.grp_SelectedDevice.Controls.Add(Me.lbl_Sync_StorageInfo)
        Me.grp_SelectedDevice.Controls.Add(Me.txt_Sync_DeviceName)
        Me.grp_SelectedDevice.Controls.Add(Me.lbl_Sync_DeviceName)
        Me.grp_SelectedDevice.Location = New System.Drawing.Point(3, 3)
        Me.grp_SelectedDevice.Name = "grp_SelectedDevice"
        Me.grp_SelectedDevice.Size = New System.Drawing.Size(477, 277)
        Me.grp_SelectedDevice.TabIndex = 1
        Me.grp_SelectedDevice.TabStop = False
        Me.grp_SelectedDevice.Text = "selected Device"
        '
        'lbl_Sync_PlaylistWithAddedTracks
        '
        Me.lbl_Sync_PlaylistWithAddedTracks.AutoSize = True
        Me.lbl_Sync_PlaylistWithAddedTracks.Location = New System.Drawing.Point(7, 247)
        Me.lbl_Sync_PlaylistWithAddedTracks.Name = "lbl_Sync_PlaylistWithAddedTracks"
        Me.lbl_Sync_PlaylistWithAddedTracks.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Sync_PlaylistWithAddedTracks.TabIndex = 19
        Me.lbl_Sync_PlaylistWithAddedTracks.Text = "Playlist name:"
        '
        'txt_Sync_PlaylistWithAddedTracks
        '
        Me.txt_Sync_PlaylistWithAddedTracks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Sync_PlaylistWithAddedTracks.Location = New System.Drawing.Point(144, 244)
        Me.txt_Sync_PlaylistWithAddedTracks.Name = "txt_Sync_PlaylistWithAddedTracks"
        Me.txt_Sync_PlaylistWithAddedTracks.Size = New System.Drawing.Size(327, 20)
        Me.txt_Sync_PlaylistWithAddedTracks.TabIndex = 18
        '
        'chk_Sync_CreatePlaylistWithAddedTracks
        '
        Me.chk_Sync_CreatePlaylistWithAddedTracks.AutoSize = True
        Me.chk_Sync_CreatePlaylistWithAddedTracks.Location = New System.Drawing.Point(144, 220)
        Me.chk_Sync_CreatePlaylistWithAddedTracks.Name = "chk_Sync_CreatePlaylistWithAddedTracks"
        Me.chk_Sync_CreatePlaylistWithAddedTracks.Size = New System.Drawing.Size(183, 17)
        Me.chk_Sync_CreatePlaylistWithAddedTracks.TabIndex = 17
        Me.chk_Sync_CreatePlaylistWithAddedTracks.Text = "Create Playlist with added Tracks"
        Me.chk_Sync_CreatePlaylistWithAddedTracks.UseVisualStyleBackColor = True
        '
        'chk_Sync_SyncPlaylists
        '
        Me.chk_Sync_SyncPlaylists.AutoSize = True
        Me.chk_Sync_SyncPlaylists.Location = New System.Drawing.Point(144, 196)
        Me.chk_Sync_SyncPlaylists.Name = "chk_Sync_SyncPlaylists"
        Me.chk_Sync_SyncPlaylists.Size = New System.Drawing.Size(90, 17)
        Me.chk_Sync_SyncPlaylists.TabIndex = 16
        Me.chk_Sync_SyncPlaylists.Text = "Sync Playlists"
        Me.chk_Sync_SyncPlaylists.UseVisualStyleBackColor = True
        '
        'chk_Sync_Convert
        '
        Me.chk_Sync_Convert.AutoSize = True
        Me.chk_Sync_Convert.Location = New System.Drawing.Point(144, 146)
        Me.chk_Sync_Convert.Name = "chk_Sync_Convert"
        Me.chk_Sync_Convert.Size = New System.Drawing.Size(117, 17)
        Me.chk_Sync_Convert.TabIndex = 15
        Me.chk_Sync_Convert.Text = "Convert with LAME"
        Me.chk_Sync_Convert.UseVisualStyleBackColor = True
        '
        'txt_Sync_LAMEoptions
        '
        Me.txt_Sync_LAMEoptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Sync_LAMEoptions.Location = New System.Drawing.Point(144, 169)
        Me.txt_Sync_LAMEoptions.Name = "txt_Sync_LAMEoptions"
        Me.txt_Sync_LAMEoptions.Size = New System.Drawing.Size(327, 20)
        Me.txt_Sync_LAMEoptions.TabIndex = 14
        '
        'lbl_Sync_LAMEoptions
        '
        Me.lbl_Sync_LAMEoptions.AutoSize = True
        Me.lbl_Sync_LAMEoptions.Location = New System.Drawing.Point(7, 172)
        Me.lbl_Sync_LAMEoptions.Name = "lbl_Sync_LAMEoptions"
        Me.lbl_Sync_LAMEoptions.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Sync_LAMEoptions.TabIndex = 13
        Me.lbl_Sync_LAMEoptions.Text = "LAME Options:"
        '
        'chk_Sync_EmbedCover
        '
        Me.chk_Sync_EmbedCover.AutoSize = True
        Me.chk_Sync_EmbedCover.Location = New System.Drawing.Point(144, 123)
        Me.chk_Sync_EmbedCover.Name = "chk_Sync_EmbedCover"
        Me.chk_Sync_EmbedCover.Size = New System.Drawing.Size(90, 17)
        Me.chk_Sync_EmbedCover.TabIndex = 12
        Me.chk_Sync_EmbedCover.Text = "Embed Cover"
        Me.chk_Sync_EmbedCover.UseVisualStyleBackColor = True
        '
        'btn_SetMainMusicFolder_Remote
        '
        Me.btn_SetMainMusicFolder_Remote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SetMainMusicFolder_Remote.Image = Global.PLSsync.My.Resources.Resources.folder
        Me.btn_SetMainMusicFolder_Remote.Location = New System.Drawing.Point(446, 94)
        Me.btn_SetMainMusicFolder_Remote.Name = "btn_SetMainMusicFolder_Remote"
        Me.btn_SetMainMusicFolder_Remote.Size = New System.Drawing.Size(25, 25)
        Me.btn_SetMainMusicFolder_Remote.TabIndex = 11
        Me.btn_SetMainMusicFolder_Remote.UseVisualStyleBackColor = True
        '
        'lbl_Sync_MainMusicFolder_Remote
        '
        Me.lbl_Sync_MainMusicFolder_Remote.AutoSize = True
        Me.lbl_Sync_MainMusicFolder_Remote.Location = New System.Drawing.Point(7, 100)
        Me.lbl_Sync_MainMusicFolder_Remote.Name = "lbl_Sync_MainMusicFolder_Remote"
        Me.lbl_Sync_MainMusicFolder_Remote.Size = New System.Drawing.Size(136, 13)
        Me.lbl_Sync_MainMusicFolder_Remote.TabIndex = 10
        Me.lbl_Sync_MainMusicFolder_Remote.Text = "Remote Main Music Folder:"
        '
        'txt_Sync_MainMusicFolder_Remote
        '
        Me.txt_Sync_MainMusicFolder_Remote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Sync_MainMusicFolder_Remote.Location = New System.Drawing.Point(144, 97)
        Me.txt_Sync_MainMusicFolder_Remote.Name = "txt_Sync_MainMusicFolder_Remote"
        Me.txt_Sync_MainMusicFolder_Remote.ReadOnly = True
        Me.txt_Sync_MainMusicFolder_Remote.Size = New System.Drawing.Size(296, 20)
        Me.txt_Sync_MainMusicFolder_Remote.TabIndex = 9
        '
        'btn_SetMainMusicFolder_Local
        '
        Me.btn_SetMainMusicFolder_Local.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SetMainMusicFolder_Local.Image = Global.PLSsync.My.Resources.Resources.folder
        Me.btn_SetMainMusicFolder_Local.Location = New System.Drawing.Point(446, 67)
        Me.btn_SetMainMusicFolder_Local.Name = "btn_SetMainMusicFolder_Local"
        Me.btn_SetMainMusicFolder_Local.Size = New System.Drawing.Size(25, 25)
        Me.btn_SetMainMusicFolder_Local.TabIndex = 8
        Me.btn_SetMainMusicFolder_Local.UseVisualStyleBackColor = True
        '
        'txt_Sync_MainMusicFolder_Local
        '
        Me.txt_Sync_MainMusicFolder_Local.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Sync_MainMusicFolder_Local.Location = New System.Drawing.Point(144, 70)
        Me.txt_Sync_MainMusicFolder_Local.Name = "txt_Sync_MainMusicFolder_Local"
        Me.txt_Sync_MainMusicFolder_Local.ReadOnly = True
        Me.txt_Sync_MainMusicFolder_Local.Size = New System.Drawing.Size(296, 20)
        Me.txt_Sync_MainMusicFolder_Local.TabIndex = 7
        '
        'lbl_Sync_MainMusicFolder_Local
        '
        Me.lbl_Sync_MainMusicFolder_Local.AutoSize = True
        Me.lbl_Sync_MainMusicFolder_Local.Location = New System.Drawing.Point(7, 73)
        Me.lbl_Sync_MainMusicFolder_Local.Name = "lbl_Sync_MainMusicFolder_Local"
        Me.lbl_Sync_MainMusicFolder_Local.Size = New System.Drawing.Size(125, 13)
        Me.lbl_Sync_MainMusicFolder_Local.TabIndex = 6
        Me.lbl_Sync_MainMusicFolder_Local.Text = "Local Main Music Folder:"
        '
        'pic_Progress
        '
        Me.pic_Progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_Progress.Location = New System.Drawing.Point(144, 43)
        Me.pic_Progress.Name = "pic_Progress"
        Me.pic_Progress.Size = New System.Drawing.Size(327, 20)
        Me.pic_Progress.TabIndex = 5
        Me.pic_Progress.TabStop = False
        '
        'lbl_Sync_StorageInfo
        '
        Me.lbl_Sync_StorageInfo.AutoSize = True
        Me.lbl_Sync_StorageInfo.Location = New System.Drawing.Point(7, 47)
        Me.lbl_Sync_StorageInfo.Name = "lbl_Sync_StorageInfo"
        Me.lbl_Sync_StorageInfo.Size = New System.Drawing.Size(68, 13)
        Me.lbl_Sync_StorageInfo.TabIndex = 2
        Me.lbl_Sync_StorageInfo.Text = "Storage Info:"
        '
        'txt_Sync_DeviceName
        '
        Me.txt_Sync_DeviceName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Sync_DeviceName.Location = New System.Drawing.Point(144, 17)
        Me.txt_Sync_DeviceName.Name = "txt_Sync_DeviceName"
        Me.txt_Sync_DeviceName.ReadOnly = True
        Me.txt_Sync_DeviceName.Size = New System.Drawing.Size(327, 20)
        Me.txt_Sync_DeviceName.TabIndex = 1
        '
        'lbl_Sync_DeviceName
        '
        Me.lbl_Sync_DeviceName.AutoSize = True
        Me.lbl_Sync_DeviceName.Location = New System.Drawing.Point(7, 20)
        Me.lbl_Sync_DeviceName.Name = "lbl_Sync_DeviceName"
        Me.lbl_Sync_DeviceName.Size = New System.Drawing.Size(75, 13)
        Me.lbl_Sync_DeviceName.TabIndex = 0
        Me.lbl_Sync_DeviceName.Text = "Device Name:"
        '
        'prb_SyncPlaylists
        '
        Me.prb_SyncPlaylists.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prb_SyncPlaylists.Location = New System.Drawing.Point(7, 349)
        Me.prb_SyncPlaylists.Name = "prb_SyncPlaylists"
        Me.prb_SyncPlaylists.Size = New System.Drawing.Size(967, 23)
        Me.prb_SyncPlaylists.TabIndex = 5
        '
        'btn_Sync_Sync
        '
        Me.btn_Sync_Sync.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Sync_Sync.Image = Global.PLSsync.My.Resources.Resources.arrow_refresh
        Me.btn_Sync_Sync.Location = New System.Drawing.Point(7, 308)
        Me.btn_Sync_Sync.Name = "btn_Sync_Sync"
        Me.btn_Sync_Sync.Size = New System.Drawing.Size(967, 38)
        Me.btn_Sync_Sync.TabIndex = 4
        Me.btn_Sync_Sync.Text = "Sync Playlists to Device"
        Me.btn_Sync_Sync.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Sync_Sync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Sync_Sync.UseVisualStyleBackColor = True
        '
        'txt_Log
        '
        Me.txt_Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Log.Location = New System.Drawing.Point(7, 378)
        Me.txt_Log.Multiline = True
        Me.txt_Log.Name = "txt_Log"
        Me.txt_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Log.Size = New System.Drawing.Size(967, 61)
        Me.txt_Log.TabIndex = 3
        Me.txt_Log.WordWrap = False
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.FolderBrowserDialog.ShowNewFolderButton = False
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 676)
        Me.Controls.Add(Me.grp_Sync)
        Me.Controls.Add(Me.grp_Devices)
        Me.Name = "frm_Main"
        Me.Text = "PLSsync"
        Me.grp_Devices.ResumeLayout(False)
        CType(Me.dgv_Devices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Sync.ResumeLayout(False)
        Me.grp_Sync.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.grp_PlaylistFiles.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv_PlaylistFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_SelectedDevice.ResumeLayout(False)
        Me.grp_SelectedDevice.PerformLayout()
        CType(Me.pic_Progress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_Devices As GroupBox
    Friend WithEvents dgv_Devices As DataGridView
    Friend WithEvents btn_RefreshDevices As Button
    Friend WithEvents btn_UseSelectedDevice As Button
    Friend WithEvents grp_Sync As GroupBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents txt_Log As TextBox
    Friend WithEvents btn_Sync_Sync As Button
    Friend WithEvents prb_SyncPlaylists As ProgressBar
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents grp_PlaylistFiles As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_PlaylistFiles_Add As Button
    Friend WithEvents btn_PlaylistFiles_Remove As Button
    Friend WithEvents dgv_PlaylistFiles As DataGridView
    Friend WithEvents grp_SelectedDevice As GroupBox
    Friend WithEvents chk_Sync_Convert As CheckBox
    Friend WithEvents txt_Sync_LAMEoptions As TextBox
    Friend WithEvents lbl_Sync_LAMEoptions As Label
    Friend WithEvents chk_Sync_EmbedCover As CheckBox
    Friend WithEvents btn_SetMainMusicFolder_Remote As Button
    Friend WithEvents lbl_Sync_MainMusicFolder_Remote As Label
    Friend WithEvents txt_Sync_MainMusicFolder_Remote As TextBox
    Friend WithEvents btn_SetMainMusicFolder_Local As Button
    Friend WithEvents txt_Sync_MainMusicFolder_Local As TextBox
    Friend WithEvents lbl_Sync_MainMusicFolder_Local As Label
    Friend WithEvents pic_Progress As PictureBox
    Friend WithEvents lbl_Sync_StorageInfo As Label
    Friend WithEvents txt_Sync_DeviceName As TextBox
    Friend WithEvents lbl_Sync_DeviceName As Label
    Friend WithEvents chk_Sync_SyncPlaylists As CheckBox
    Friend WithEvents chk_Sync_CreatePlaylistWithAddedTracks As CheckBox
    Friend WithEvents lbl_Sync_PlaylistWithAddedTracks As Label
    Friend WithEvents txt_Sync_PlaylistWithAddedTracks As TextBox
End Class
