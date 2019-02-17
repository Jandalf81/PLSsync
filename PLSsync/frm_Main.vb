Public Class frm_Main
    Public devices As IEnumerable(Of MediaDevices.MediaDevice)
    Public selectedDevice As MediaDevices.MediaDevice
    Public DeviceMainFolder As String = ""
    'Public deviceList As New List(Of MediaDevices.MediaDevice)
    'Public bs As Equin.ApplicationFramework.BindingListView(Of MediaDevices.MediaDevice) = New Equin.ApplicationFramework.BindingListView(Of MediaDevices.MediaDevice)(deviceList)


    Public Sub refreshDevices()
        devices = MediaDevices.MediaDevice.GetDevices()
        'Dim deviceList As New List(Of MediaDevices.MediaDevice)

        For Each device In devices
            device.Connect()
            ' deviceList.Add(device)
        Next

        'bs = New Equin.ApplicationFramework.BindingListView(Of MediaDevices.MediaDevice)(deviceList)
        dgv_Devices.DataSource = devices
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim devices As IEnumerable(Of MediaDevices.MediaDevice) = MediaDevices.MediaDevice.GetDevices()

        For Each device In devices
            MsgBox("FriendlyName: " + device.FriendlyName + vbCrLf +
                   "Description: " + device.Description + vbCrLf +
                   "Manufacturer: " + device.Manufacturer)

            If (device.Description = "Pixel 2") Then
                device.Connect()

                Dim directories As IEnumerable(Of String) = device.EnumerateDirectories("/", "", IO.SearchOption.TopDirectoryOnly)
                For Each directory In directories
                    MsgBox("Directory: " + directory)
                Next

                Dim contentLocations As IEnumerable(Of String) = device.GetContentLocations(MediaDevices.ContentType.Audio)
                For Each contentLocation In contentLocations
                    MsgBox("Content Location: " + contentLocation)
                Next
            End If
        Next
    End Sub

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' settings for DataGridView
        With dgv_Devices
            .ReadOnly() = True
            .AllowUserToAddRows = False
            .AutoGenerateColumns = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End With

        ' prepare columns for DataGridView
        Dim col_FriendlyName As New DataGridViewTextBoxColumn()
        col_FriendlyName.DataPropertyName = "FriendlyName"
        col_FriendlyName.Name = "Friendly Name"

        Dim col_Description As New DataGridViewTextBoxColumn()
        col_Description.DataPropertyName = "Description"
        col_Description.Name = "Description"

        Dim col_Manufacturer As New DataGridViewTextBoxColumn()
        col_Manufacturer.DataPropertyName = "Manufacturer"
        col_Manufacturer.Name = "Manufacturer"

        Dim col_DeviceType As New DataGridViewTextBoxColumn()
        col_DeviceType.DataPropertyName = "DeviceType"
        col_DeviceType.Name = "DeviceType"

        Dim col_PowerLevel As New DataGridViewTextBoxColumn()
        col_PowerLevel.DataPropertyName = "PowerLevel"
        col_PowerLevel.Name = "PowerLevel"

        Dim col_SerialNumber As New DataGridViewTextBoxColumn()
        col_SerialNumber.DataPropertyName = "SerialNumber"
        col_SerialNumber.Name = "SerialNumber"

        ' add prepared columns to DataGridView
        With dgv_Devices.Columns
            .Add(col_Manufacturer)
            .Add(col_Description)
            .Add(col_DeviceType)
            .Add(col_FriendlyName)
            .Add(col_PowerLevel)
            .Add(col_SerialNumber)
        End With

        refreshDevices()
    End Sub

    Private Sub btn_RefreshDevices_Click(sender As Object, e As EventArgs) Handles btn_RefreshDevices.Click
        refreshDevices()
    End Sub

    Private Sub btn_UseSelectedDevice_Click(sender As Object, e As EventArgs) Handles btn_UseSelectedDevice.Click
        ' get currently selected device from DataGridView
        selectedDevice = dgv_Devices.SelectedRows(0).DataBoundItem

        txt_Sync_DeviceName.Text = String.Format("{0}, {1}, {2}", selectedDevice.Manufacturer, selectedDevice.Description, selectedDevice.SerialNumber)

        pic_Progress.Refresh()
    End Sub



    Private Sub pic_Progress_Paint(sender As Object, e As PaintEventArgs) Handles pic_Progress.Paint
        ' reset
        e.Graphics.Clear(pic_Progress.BackColor)
        e.Graphics.DrawRectangle(New Pen(Brushes.Gray, 1), 0, 0, pic_Progress.ClientSize.Width - 1, pic_Progress.ClientSize.Height - 1)

        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Dim sf As New StringFormat()
        sf.Alignment = StringAlignment.Near
        sf.LineAlignment = StringAlignment.Center

        If selectedDevice Is Nothing Then
            e.Graphics.DrawRectangle(New Pen(Brushes.Gray, 1), 0, 0, pic_Progress.ClientSize.Width - 1, pic_Progress.ClientSize.Height - 1)
        Else
            Dim objects = selectedDevice.FunctionalObjects(MediaDevices.FunctionalCategory.Storage)
            Dim storageInfo As MediaDevices.MediaStorageInfo = selectedDevice.GetStorageInfo(objects.First())

            If storageInfo Is Nothing Then
                e.Graphics.DrawString("n/a", Me.Font, Brushes.Black, pic_Progress.ClientRectangle, sf)
            Else
                DeviceMainFolder = storageInfo.Description

                Dim percent As Integer = Math.Round(storageInfo.FreeSpaceInBytes * 100 / storageInfo.Capacity, 0)
                Dim color As Brush

                Select Case percent
                    Case < 10
                        color = Brushes.Red
                    Case < 20
                        color = Brushes.Orange
                    Case Else
                        color = Brushes.LightGreen
                End Select

                ' draw the background
                Dim fraction As Single = storageInfo.FreeSpaceInBytes / storageInfo.Capacity
                Dim width As Integer = fraction * pic_Progress.ClientSize.Width

                e.Graphics.FillRectangle(color, 0, 0, width, pic_Progress.ClientSize.Height)
                e.Graphics.DrawRectangle(New Pen(Brushes.Gray, 1), 0, 0, pic_Progress.ClientSize.Width - 1, pic_Progress.ClientSize.Height - 1)

                ' draw the text
                e.Graphics.DrawString(String.Format("{0} GB free of {1} GB ({2}%)", Math.Round(storageInfo.FreeSpaceInBytes / 1024 / 1024 / 1024, 2), Math.Round(storageInfo.Capacity / 1024 / 1024 / 1024, 2), percent), Me.Font, Brushes.Black, pic_Progress.ClientRectangle, sf)
            End If
        End If
    End Sub

    Private Sub frm_Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        pic_Progress.Refresh()
    End Sub

    Private Sub btn_SetMainMusicFolder_Click(sender As Object, e As EventArgs) Handles btn_SetMainMusicFolder.Click
        ' TODO create a way to set the main folder
    End Sub
End Class
