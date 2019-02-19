Imports System.ComponentModel

Public Class frm_Main
    Public preset As New Preset()

    Public devices As IEnumerable(Of MediaDevices.MediaDevice)
    Public selectedDevice As MediaDevices.MediaDevice

    Public bs_Devices As New BindingSource()
    Public bs_PlaylistFiles As New BindingSource()

    Public DeviceMainFolder As String = ""

    Private Sub refreshDevices()
        devices = MediaDevices.MediaDevice.GetDevices()

        For Each device In devices
            device.Connect()
        Next

        bs_Devices.DataSource = devices

        dgv_Devices.DataSource = bs_Devices
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

#Region "form"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' prepare columns for DataGridView dgv_Devices
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
        With dgv_Devices
            .ReadOnly() = True
            .AllowUserToAddRows = False
            .AutoGenerateColumns = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .RowHeadersVisible = False

            .Columns.Add(col_Manufacturer)
            .Columns.Add(col_Description)
            .Columns.Add(col_DeviceType)
            .Columns.Add(col_FriendlyName)
            .Columns.Add(col_PowerLevel)
            .Columns.Add(col_SerialNumber)
        End With

        ' prepare columns for DataGridView dgv_PlaylistFiles
        Dim col_Playlist As New DataGridViewTextBoxColumn()
        col_Playlist.DataPropertyName = "Filename"
        col_Playlist.Name = "Playlist File"

        Dim col_NumberOfTracks As New DataGridViewTextBoxColumn()
        col_NumberOfTracks.DataPropertyName = "NumberOfTracks"
        col_NumberOfTracks.Name = "Tracks"

        bs_PlaylistFiles.DataSource = preset.Playlists

        With dgv_PlaylistFiles
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AutoGenerateColumns = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            .RowHeadersVisible = False

            .Columns.Add(col_Playlist)
            .Columns.Add(col_NumberOfTracks)

            .DataSource = bs_PlaylistFiles
        End With

        refreshDevices()
    End Sub

    Private Sub frm_Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        pic_Progress.Refresh()
    End Sub

    Private Sub frm_Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (Not selectedDevice Is Nothing) Then
            preset.Save(selectedDevice.Description + "_" + selectedDevice.SerialNumber)
        End If
    End Sub
#End Region

#Region "form grp_Devices"
    Private Sub btn_RefreshDevices_Click(sender As Object, e As EventArgs) Handles btn_RefreshDevices.Click
        refreshDevices()
    End Sub

    Private Sub btn_UseSelectedDevice_Click(sender As Object, e As EventArgs) Handles btn_UseSelectedDevice.Click
        If (Not selectedDevice Is Nothing) Then
            preset.Save(selectedDevice.Description + "_" + selectedDevice.SerialNumber)
        End If

        ' get currently selected device from DataGridView
        selectedDevice = dgv_Devices.SelectedRows(0).DataBoundItem

        txt_Sync_DeviceName.Text = String.Format("{0}, {1}, {2}", selectedDevice.Manufacturer, selectedDevice.Description, selectedDevice.SerialNumber)

        pic_Progress.Refresh()

        preset = New Preset()
        preset.Load(selectedDevice.Description + "_" + selectedDevice.SerialNumber)
        bs_PlaylistFiles.DataSource = preset.Playlists
    End Sub
#End Region

#Region "form grp_Sync"

#Region "form grp_Sync grp_Device"
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

    Private Sub btn_SetMainMusicFolder_Click(sender As Object, e As EventArgs) Handles btn_SetMainMusicFolder.Click
        ' TODO create a way to set the main folder
    End Sub
#End Region

#Region "form grp_Sync grp_Playlists"
    Private Sub btn_PlaylistFiles_Add_Click(sender As Object, e As EventArgs) Handles btn_PlaylistFiles_Add.Click
        OpenFileDialog.Filter = "playlist files (*.m3u, *.m3u8)|*.m3u;*.m3u8"
        OpenFileDialog.Multiselect = False
        OpenFileDialog.Title = "Add Playlist File"

        If (OpenFileDialog.ShowDialog() = DialogResult.OK) Then
            Dim pl As New Playlist(OpenFileDialog.FileName)

            bs_PlaylistFiles.Add(pl)
        End If
    End Sub
#End Region

#End Region

End Class
