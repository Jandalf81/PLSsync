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
        Me.grp_SelectedDevice = New System.Windows.Forms.GroupBox()
        Me.pic_Progress = New System.Windows.Forms.PictureBox()
        Me.lbl_Sync_StorageInfo = New System.Windows.Forms.Label()
        Me.txt_Sync_DeviceName = New System.Windows.Forms.TextBox()
        Me.lbl_Sync_DeviceName = New System.Windows.Forms.Label()
        Me.grp_Devices.SuspendLayout()
        CType(Me.dgv_Devices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Sync.SuspendLayout()
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
        Me.btn_RefreshDevices.Location = New System.Drawing.Point(936, 155)
        Me.btn_RefreshDevices.Name = "btn_RefreshDevices"
        Me.btn_RefreshDevices.Size = New System.Drawing.Size(38, 38)
        Me.btn_RefreshDevices.TabIndex = 2
        Me.btn_RefreshDevices.UseVisualStyleBackColor = True
        '
        'btn_UseSelectedDevice
        '
        Me.btn_UseSelectedDevice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_UseSelectedDevice.Location = New System.Drawing.Point(6, 155)
        Me.btn_UseSelectedDevice.Name = "btn_UseSelectedDevice"
        Me.btn_UseSelectedDevice.Size = New System.Drawing.Size(924, 38)
        Me.btn_UseSelectedDevice.TabIndex = 1
        Me.btn_UseSelectedDevice.Text = "use selected device"
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
        Me.grp_SelectedDevice.Controls.Add(Me.pic_Progress)
        Me.grp_SelectedDevice.Controls.Add(Me.lbl_Sync_StorageInfo)
        Me.grp_SelectedDevice.Controls.Add(Me.txt_Sync_DeviceName)
        Me.grp_SelectedDevice.Controls.Add(Me.lbl_Sync_DeviceName)
        Me.grp_SelectedDevice.Location = New System.Drawing.Point(6, 19)
        Me.grp_SelectedDevice.Name = "grp_SelectedDevice"
        Me.grp_SelectedDevice.Size = New System.Drawing.Size(461, 138)
        Me.grp_SelectedDevice.TabIndex = 0
        Me.grp_SelectedDevice.TabStop = False
        Me.grp_SelectedDevice.Text = "selected Device"
        '
        'pic_Progress
        '
        Me.pic_Progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_Progress.Location = New System.Drawing.Point(111, 43)
        Me.pic_Progress.Name = "pic_Progress"
        Me.pic_Progress.Size = New System.Drawing.Size(344, 20)
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
        Me.txt_Sync_DeviceName.Location = New System.Drawing.Point(111, 17)
        Me.txt_Sync_DeviceName.Name = "txt_Sync_DeviceName"
        Me.txt_Sync_DeviceName.ReadOnly = True
        Me.txt_Sync_DeviceName.Size = New System.Drawing.Size(344, 20)
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
End Class
