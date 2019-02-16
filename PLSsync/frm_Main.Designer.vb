<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grp_Devices = New System.Windows.Forms.GroupBox()
        Me.dgv_Devices = New System.Windows.Forms.DataGridView()
        Me.btn_UseSelectedDevice = New System.Windows.Forms.Button()
        Me.btn_RefreshDevices = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grp_Devices.SuspendLayout()
        CType(Me.dgv_Devices, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 219)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(980, 347)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 578)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_Devices)
        Me.Name = "frm_Main"
        Me.Text = "PLSsync"
        Me.grp_Devices.ResumeLayout(False)
        CType(Me.dgv_Devices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_Devices As GroupBox
    Friend WithEvents dgv_Devices As DataGridView
    Friend WithEvents btn_RefreshDevices As Button
    Friend WithEvents btn_UseSelectedDevice As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
