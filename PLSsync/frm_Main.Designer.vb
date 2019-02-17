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
        Me.btn_UseSelectedDevice = New System.Windows.Forms.Button()
        Me.dgv_Devices = New System.Windows.Forms.DataGridView()
        Me.grp_Sync = New System.Windows.Forms.GroupBox()
        Me.grp_SelectedDevice = New System.Windows.Forms.GroupBox()
        Me.txt_Sync_MainMusicFolder = New System.Windows.Forms.TextBox()
        Me.lbl_Sync_MainMusicFolder = New System.Windows.Forms.Label()
        Me.lbl_Sync_StorageInfo = New System.Windows.Forms.Label()
        Me.txt_Sync_DeviceName = New System.Windows.Forms.TextBox()
        Me.lbl_Sync_DeviceName = New System.Windows.Forms.Label()
        Me.grp_PlaylistFiles = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_PlaylistFiles_Add = New System.Windows.Forms.Button()
        Me.btn_PlaylistFiles_Remove = New System.Windows.Forms.Button()
        Me.btn_SetMainMusicFolder = New System.Windows.Forms.Button()
        Me.pic_Progress = New System.Windows.Forms.PictureBox()
        Me.btn_RefreshDevices = New System.Windows.Forms.Button()
        Me.grp_Devices.SuspendLayout()
        CType(Me.dgv_Devices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Sync.SuspendLayout()
        Me.grp_SelectedDevice.SuspendLayout()
        Me.grp_PlaylistFiles.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
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
        'btn_UseSelectedDevice
        '
        Me.btn_UseSelectedDevice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_UseSelectedDevice.Image = Global.PLSsync.My.Resources.Resources.accept
        Me.btn_UseSelectedDevice.Location = New System.Drawing.Point(6, 155)
        Me.btn_UseSelectedDevice.Name = "btn_UseSelectedDevice"
        Me.btn_UseSelectedDevice.Size = New System.Drawing.Size(924, 38)
        Me.btn_UseSelectedDevice.TabIndex = 1
        Me.btn_UseSelectedDevice.Text = "use selected device"
        Me.btn_UseSelectedDevice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_UseSelectedDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_UseSelectedDevice.UseVisualStyleBackColor = True
        '
        'dgv_Devices
        '
        Me.dgv_Devices.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.grp_Sync.Controls.Add(Me.grp_PlaylistFiles)
        Me.grp_Sync.Controls.Add(Me.grp_SelectedDevice)
        Me.grp_Sync.Location = New System.Drawing.Point(12, 219)
        Me.grp_Sync.Name = "grp_Sync"
        Me.grp_Sync.Size = New System.Drawing.Size(980, 347)
        Me.grp_Sync.TabIndex = 2
        Me.grp_Sync.TabStop = False
        Me.grp_Sync.Text = "Sync"
        '
        'grp_SelectedDevice
        '
        Me.grp_SelectedDevice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_SelectedDevice.Controls.Add(Me.btn_SetMainMusicFolder)
        Me.grp_SelectedDevice.Controls.Add(Me.txt_Sync_MainMusicFolder)
        Me.grp_SelectedDevice.Controls.Add(Me.lbl_Sync_MainMusicFolder)
        Me.grp_SelectedDevice.Controls.Add(Me.pic_Progress)
        Me.grp_SelectedDevice.Controls.Add(Me.lbl_Sync_StorageInfo)
        Me.grp_SelectedDevice.Controls.Add(Me.txt_Sync_DeviceName)
        Me.grp_SelectedDevice.Controls.Add(Me.lbl_Sync_DeviceName)
        Me.grp_SelectedDevice.Location = New System.Drawing.Point(6, 19)
        Me.grp_SelectedDevice.Name = "grp_SelectedDevice"
        Me.grp_SelectedDevice.Size = New System.Drawing.Size(481, 138)
        Me.grp_SelectedDevice.TabIndex = 0
        Me.grp_SelectedDevice.TabStop = False
        Me.grp_SelectedDevice.Text = "selected Device"
        '
        'txt_Sync_MainMusicFolder
        '
        Me.txt_Sync_MainMusicFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Sync_MainMusicFolder.Location = New System.Drawing.Point(111, 70)
        Me.txt_Sync_MainMusicFolder.Name = "txt_Sync_MainMusicFolder"
        Me.txt_Sync_MainMusicFolder.ReadOnly = True
        Me.txt_Sync_MainMusicFolder.Size = New System.Drawing.Size(333, 20)
        Me.txt_Sync_MainMusicFolder.TabIndex = 7
        '
        'lbl_Sync_MainMusicFolder
        '
        Me.lbl_Sync_MainMusicFolder.AutoSize = True
        Me.lbl_Sync_MainMusicFolder.Location = New System.Drawing.Point(7, 73)
        Me.lbl_Sync_MainMusicFolder.Name = "lbl_Sync_MainMusicFolder"
        Me.lbl_Sync_MainMusicFolder.Size = New System.Drawing.Size(93, 13)
        Me.lbl_Sync_MainMusicFolder.TabIndex = 6
        Me.lbl_Sync_MainMusicFolder.Text = "Main Music folder:"
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
        Me.txt_Sync_DeviceName.Location = New System.Drawing.Point(111, 17)
        Me.txt_Sync_DeviceName.Name = "txt_Sync_DeviceName"
        Me.txt_Sync_DeviceName.ReadOnly = True
        Me.txt_Sync_DeviceName.Size = New System.Drawing.Size(364, 20)
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
        'grp_PlaylistFiles
        '
        Me.grp_PlaylistFiles.Controls.Add(Me.TableLayoutPanel1)
        Me.grp_PlaylistFiles.Controls.Add(Me.DataGridView1)
        Me.grp_PlaylistFiles.Location = New System.Drawing.Point(494, 19)
        Me.grp_PlaylistFiles.Name = "grp_PlaylistFiles"
        Me.grp_PlaylistFiles.Size = New System.Drawing.Size(480, 154)
        Me.grp_PlaylistFiles.TabIndex = 1
        Me.grp_PlaylistFiles.TabStop = False
        Me.grp_PlaylistFiles.Text = "Playlist files"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(468, 85)
        Me.DataGridView1.TabIndex = 0
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 110)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(468, 38)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btn_PlaylistFiles_Add
        '
        Me.btn_PlaylistFiles_Add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_PlaylistFiles_Add.Image = Global.PLSsync.My.Resources.Resources.add
        Me.btn_PlaylistFiles_Add.Location = New System.Drawing.Point(0, 0)
        Me.btn_PlaylistFiles_Add.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.btn_PlaylistFiles_Add.Name = "btn_PlaylistFiles_Add"
        Me.btn_PlaylistFiles_Add.Size = New System.Drawing.Size(231, 38)
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
        Me.btn_PlaylistFiles_Remove.Location = New System.Drawing.Point(237, 0)
        Me.btn_PlaylistFiles_Remove.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.btn_PlaylistFiles_Remove.Name = "btn_PlaylistFiles_Remove"
        Me.btn_PlaylistFiles_Remove.Size = New System.Drawing.Size(231, 38)
        Me.btn_PlaylistFiles_Remove.TabIndex = 1
        Me.btn_PlaylistFiles_Remove.Text = "remove Playlist File"
        Me.btn_PlaylistFiles_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_PlaylistFiles_Remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_PlaylistFiles_Remove.UseVisualStyleBackColor = True
        '
        'btn_SetMainMusicFolder
        '
        Me.btn_SetMainMusicFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SetMainMusicFolder.Image = Global.PLSsync.My.Resources.Resources.folder
        Me.btn_SetMainMusicFolder.Location = New System.Drawing.Point(450, 67)
        Me.btn_SetMainMusicFolder.Name = "btn_SetMainMusicFolder"
        Me.btn_SetMainMusicFolder.Size = New System.Drawing.Size(25, 25)
        Me.btn_SetMainMusicFolder.TabIndex = 8
        Me.btn_SetMainMusicFolder.UseVisualStyleBackColor = True
        '
        'pic_Progress
        '
        Me.pic_Progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_Progress.Location = New System.Drawing.Point(111, 43)
        Me.pic_Progress.Name = "pic_Progress"
        Me.pic_Progress.Size = New System.Drawing.Size(364, 20)
        Me.pic_Progress.TabIndex = 5
        Me.pic_Progress.TabStop = False
        '
        'btn_RefreshDevices
        '
        Me.btn_RefreshDevices.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_RefreshDevices.Image = Global.PLSsync.My.Resources.Resources.arrow_refresh
        Me.btn_RefreshDevices.Location = New System.Drawing.Point(936, 155)
        Me.btn_RefreshDevices.Name = "btn_RefreshDevices"
        Me.btn_RefreshDevices.Size = New System.Drawing.Size(38, 38)
        Me.btn_RefreshDevices.TabIndex = 2
        Me.btn_RefreshDevices.UseVisualStyleBackColor = True
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 578)
        Me.Controls.Add(Me.grp_Sync)
        Me.Controls.Add(Me.grp_Devices)
        Me.Name = "frm_Main"
        Me.Text = "PLSsync"
        Me.grp_Devices.ResumeLayout(False)
        CType(Me.dgv_Devices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Sync.ResumeLayout(False)
        Me.grp_SelectedDevice.ResumeLayout(False)
        Me.grp_SelectedDevice.PerformLayout()
        Me.grp_PlaylistFiles.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.pic_Progress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_Devices As GroupBox
    Friend WithEvents dgv_Devices As DataGridView
    Friend WithEvents btn_RefreshDevices As Button
    Friend WithEvents btn_UseSelectedDevice As Button
    Friend WithEvents grp_Sync As GroupBox
    Friend WithEvents grp_SelectedDevice As GroupBox
    Friend WithEvents lbl_Sync_DeviceName As Label
    Friend WithEvents txt_Sync_DeviceName As TextBox
    Friend WithEvents lbl_Sync_StorageInfo As Label
    Friend WithEvents pic_Progress As PictureBox
    Friend WithEvents btn_SetMainMusicFolder As Button
    Friend WithEvents txt_Sync_MainMusicFolder As TextBox
    Friend WithEvents lbl_Sync_MainMusicFolder As Label
    Friend WithEvents grp_PlaylistFiles As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_PlaylistFiles_Add As Button
    Friend WithEvents btn_PlaylistFiles_Remove As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
