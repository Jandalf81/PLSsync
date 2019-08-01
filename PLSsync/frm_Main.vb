﻿Imports System.ComponentModel

Public Class frm_Main
    Public preset As New Preset()

    Public devices As IEnumerable(Of MediaDevices.MediaDevice)
    Public selectedDevice As MediaDevices.MediaDevice
    Public storageInfo As MediaDevices.MediaStorageInfo

    Public bs_Devices As New BindingSource()
    Public bs_PlaylistFiles As New BindingSource()

    Public DeviceMainFolder As String = ""

    Public WithEvents bgw_SyncPlaylist As New BackgroundWorker() With {
        .WorkerReportsProgress = True,
        .WorkerSupportsCancellation = True
    }

    Private Sub refreshDevices()
        devices = MediaDevices.MediaDevice.GetDevices()

        For Each device In devices
            device.Connect()
        Next

        bs_Devices.DataSource = devices
        dgv_Devices.DataSource = bs_Devices
    End Sub

    Private Sub tidyUp()
        If (My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\tmp\converted.mp3") = True) Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\tmp\converted.mp3")
        End If

        If (My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\tmp\embedCover.mp3") = True) Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\tmp\embedCover.mp3")
        End If
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

    'Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim t As New Track("E:\_PARsync\Chiptunes\Chipzel\Disconnected (2010)\01 - Something beautiful.mp3")

    '    txt_Log.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss: ") & "Starte Konvertierung..." + vbCrLf
    '    t.convert(preset.LAMEoptions)
    '    txt_Log.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss: ") & "Konvertierung beendet" + vbCrLf

    '    txt_Log.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss: ") & "Starte Upload..." + vbCrLf
    '    t.upload()
    '    txt_Log.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss: ") & "Upload beendet" + vbCrLf
    'End Sub

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

        ' set BindingSources
        bs_PlaylistFiles.DataSource = preset.Playlists

        refreshDevices()

        grp_Sync.Enabled = False
    End Sub

    Private Sub frm_Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        pic_Progress.Refresh()
    End Sub

    Private Sub frm_Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' save current preset
        If (Not selectedDevice Is Nothing) Then
            preset.Save(selectedDevice.Description + "_" + selectedDevice.SerialNumber)
        End If

        ' remove temporary files
        tidyUp()
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

        Try
            storageInfo = selectedDevice.GetStorageInfo(selectedDevice.FunctionalObjects(MediaDevices.FunctionalCategory.Storage).First())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        pic_Progress.Refresh()

        preset = New Preset()
        preset.Load(selectedDevice.Description + "_" + selectedDevice.SerialNumber)
        bs_PlaylistFiles.DataSource = preset.Playlists
        txt_Sync_MainMusicFolder_Local.Text = preset.LocalMainPath
        txt_Sync_MainMusicFolder_Remote.Text = preset.RemoteMainPath
        chk_Sync_EmbedCover.Checked = preset.EmbedCover
        chk_Sync_Convert.Checked = preset.Convert
        txt_Sync_LAMEoptions.Text = preset.LAMEoptions
        txt_Sync_LAMEoptions.Enabled = preset.Convert ' Only enable the text field if the chekbox is checkes

        grp_Sync.Enabled = True
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
            'Dim storageInfo As MediaDevices.MediaStorageInfo = selectedDevice.GetStorageInfo(selectedDevice.FunctionalObjects(MediaDevices.FunctionalCategory.Storage).First())

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

    Private Sub btn_SetMainMusicFolder_Click(sender As Object, e As EventArgs) Handles btn_SetMainMusicFolder_Local.Click
        With FolderBrowserDialog
            .RootFolder = System.Environment.SpecialFolder.MyComputer
            .ShowNewFolderButton = False
            .Description = "Set main folder for your local music"
        End With

        If (FolderBrowserDialog.ShowDialog() = DialogResult.OK) Then
            txt_Sync_MainMusicFolder_Local.Text = FolderBrowserDialog.SelectedPath
            preset.LocalMainPath = FolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub chk_Sync_EmbedCover_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Sync_EmbedCover.CheckedChanged
        preset.EmbedCover = chk_Sync_EmbedCover.Checked
    End Sub

    Private Sub chk_Sync_Convert_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Sync_Convert.CheckedChanged
        ' TODO insert check if LAME.EXE exists
        preset.Convert = chk_Sync_Convert.Checked
        txt_Sync_LAMEoptions.Enabled = chk_Sync_Convert.Checked  ' Only enable the text field if the chekbox is checkes
    End Sub

    Private Sub txt_Sync_LAMEoptions_TextChanged(sender As Object, e As EventArgs) Handles txt_Sync_LAMEoptions.TextChanged
        preset.LAMEoptions = txt_Sync_LAMEoptions.Text
    End Sub
#End Region

#Region "form grp_Sync grp_Playlists"
    Private Sub btn_PlaylistFiles_Add_Click(sender As Object, e As EventArgs) Handles btn_PlaylistFiles_Add.Click
        With OpenFileDialog
            .Filter = "playlist files (*.m3u, *.m3u8)|*.m3u;*.m3u8"
            .Multiselect = False
            .Title = "Add Playlist File"
        End With

        If (OpenFileDialog.ShowDialog() = DialogResult.OK) Then
            Dim pl As New Playlist(OpenFileDialog.FileName)

            bs_PlaylistFiles.Add(pl)
        End If
    End Sub

    Private Sub btn_PlaylistFiles_Remove_Click(sender As Object, e As EventArgs) Handles btn_PlaylistFiles_Remove.Click
        Dim selectedPlaylist As Playlist = dgv_PlaylistFiles.SelectedRows(0).DataBoundItem
        bs_PlaylistFiles.Remove(selectedPlaylist)
    End Sub
#End Region

    Private Sub btn_Sync_Sync_Click(sender As Object, e As EventArgs) Handles btn_Sync_Sync.Click
        preset.Save(selectedDevice.Description + "_" + selectedDevice.SerialNumber)
        bgw_SyncPlaylist.RunWorkerAsync(preset)
    End Sub

#End Region


#Region "Background Workers"

#Region "bgw_SyncPlaylist"
    Private Sub bgw_SyncPlaylist_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_SyncPlaylist.DoWork
        Dim allTracks As Integer = 0
        Dim currentTrack As Integer = 0

        ' get number of Tracks from all playlists
        For Each playlist In preset.Playlists
            playlist.read(preset)
            allTracks += playlist.Tracks.Count
        Next

        For Each playlist In preset.Playlists
            For Each track In playlist.Tracks

                ' TODO put log in table format

                currentTrack += 1
                Debug.Print(currentTrack & "/" & allTracks & " - Playlist: " & playlist.Filename & ", Track: " & track.localPath)

                bgw_SyncPlaylist.ReportProgress(currentTrack * 100 / allTracks, "INFO" & vbTab & currentTrack & "/" & allTracks & " - Playlist: " & playlist.Filename & ", Track: " & track.localPath)

                If (selectedDevice.FileExists(track.remotePath) = False) Then
                    If (preset.Convert = True) Then
                        bgw_SyncPlaylist.ReportProgress(currentTrack * 100 / allTracks, "INFO" & vbTab & "Converting...")
                        track.convert(preset.LAMEoptions)
                        bgw_SyncPlaylist.ReportProgress(currentTrack * 100 / allTracks, "INFO" & vbTab & "Conversion OK")
                    End If

                    If (preset.EmbedCover = True) Then
                        track.embedCover()
                    End If

                    bgw_SyncPlaylist.ReportProgress(currentTrack * 100 / allTracks, "INFO" & vbTab & "Uploading...")
                    track.upload(selectedDevice)
                    bgw_SyncPlaylist.ReportProgress(currentTrack * 100 / allTracks, "INFO" & vbTab & "Upload OK")
                Else
                    bgw_SyncPlaylist.ReportProgress(currentTrack * 100 / allTracks, "INFO" & vbTab & "File exists")
                End If

                tidyUp()
            Next
        Next
    End Sub

    Private Sub bgw_SyncPlaylist_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_SyncPlaylist.ProgressChanged
        prb_SyncPlaylists.Value = e.ProgressPercentage
        txt_Log.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & vbTab & e.UserState & vbCrLf)
        My.Application.DoEvents()
    End Sub
#End Region

#End Region

End Class
