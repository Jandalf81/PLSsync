Public Class Track
    Private _localPath As String
    Private _localPathOriginal As String
    Private _remotePath As String
    Private _hasCover As Boolean
    Private _coverFile As String
    Private _preset As Preset

    Public Property localPath As String
        Get
            Return _localPath
        End Get
        Set(value As String)
            '_localPath = "\\?\" & value
            _localPath = value
            _localPathOriginal = value
            _remotePath = Replace(value, _preset.LocalMainPath, _preset.RemoteMainPath)

            ' TODO remove limitation on lenght of file path > 260 chars
            _localPathOnly = IO.Path.GetDirectoryName(_localPath)
            _localFilenameOnly = IO.Path.GetFileName(_localPath)
            _remotePathOnly = IO.Path.GetDirectoryName(_remotePath)

            Select Case True
                Case My.Computer.FileSystem.FileExists(_localPathOnly + "\folder.jpg") = True
                    _hasCover = True
                    _coverFile = "folder.jpg"
                Case My.Computer.FileSystem.FileExists(_localPathOnly + "\folder.png") = True
                    _hasCover = True
                    _coverFile = "folder.png"
                Case Else
                    _hasCover = False
                    _coverFile = ""
            End Select
        End Set
    End Property
    Public ReadOnly Property LocalPathOriginal As String
        Get
            Return _localPathOriginal
        End Get
    End Property
    Public ReadOnly Property remotePath As String
        Get
            Return _remotePath
        End Get
    End Property
    Public ReadOnly Property hasCover As Boolean
        Get
            Return _hasCover
        End Get
    End Property
    Public ReadOnly Property coverFile As String
        Get
            Return _coverFile
        End Get
    End Property

    Private _localPathOnly As String
    Private _remotePathOnly As String
    Private _localFilenameOnly As String

    Public Sub New()
    End Sub

    Public Sub New(localPathIN As String)
        Me._preset = frm_Main.preset
        Me.localPath = localPathIN
    End Sub

    Public Sub New(localPathIN As String, preset As Preset)
        Me._preset = preset
        Me.localPath = localPathIN
    End Sub

    'Public Sub upload()
    '    Me.upload(Me.remotePath)
    'End Sub

    Public Sub upload(toDevice As MediaDevices.MediaDevice, preset As Preset, newlyAdded As Playlist)
        Me.upload(toDevice, Me.remotePath, preset, newlyAdded)
    End Sub

    'Public Sub upload(toPath As String)
    '    If (frm_Main.selectedDevice.FileExists(Me.remotePath) = False) Then
    '        If (frm_Main.selectedDevice.DirectoryExists(Me._remotePathOnly) = False) Then
    '            frm_Main.selectedDevice.CreateDirectory(Me._remotePathOnly)
    '        End If

    '        Dim fs As New IO.FileStream(Me.localPath, IO.FileMode.Open, IO.FileAccess.Read)
    '        frm_Main.selectedDevice.UploadFile(fs, toPath)
    '    End If

    '    If (Me.hasCover = True) Then
    '        If (frm_Main.selectedDevice.FileExists(Me._remotePathOnly + "\" + Me.coverFile) = False) Then
    '            Dim fs As New IO.FileStream(Me._localPathOnly + "\" + Me.coverFile, IO.FileMode.Open, IO.FileAccess.Read)

    '            frm_Main.selectedDevice.UploadFile(fs, _remotePathOnly + "\" + Me.coverFile)
    '        End If
    '    End If
    'End Sub

    Public Sub upload(toDevice As MediaDevices.MediaDevice, toPath As String, preset As Preset, newlyAdded As Playlist)
        If (toDevice.FileExists(Me.remotePath) = False) Then
            If (toDevice.DirectoryExists(Me._remotePathOnly) = False) Then
                toDevice.CreateDirectory(Me._remotePathOnly)
            End If

            Dim fs As New IO.FileStream(Me.localPath, IO.FileMode.Open, IO.FileAccess.Read)
            toDevice.UploadFile(fs, toPath)

            fs.Dispose()

            ' add track to playlist if it's being uploaded
            If (preset.CreatePlaylistWithAddedTracks = True) Then
                newlyAdded.Tracks.Add(Me)
            End If
        End If


        If (Me.hasCover = True) Then
            If (toDevice.FileExists(Me._remotePathOnly + "\" + Me.coverFile) = False) Then
                Dim fs As New IO.FileStream(Me._localPathOnly + "\" + Me.coverFile, IO.FileMode.Open, IO.FileAccess.Read)

                toDevice.UploadFile(fs, _remotePathOnly + "\" + Me.coverFile)

                fs.Dispose()
            End If
        End If
    End Sub

    Public Sub convert(LAMEoptions As String)
        Try
            'If (My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\tmp\converted.mp3") = True) Then
            '    My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\tmp\converted.mp3")
            'End If

            ' LAME conversion
            Dim lame As New Process()

            With lame.StartInfo
                .FileName = My.Application.Info.DirectoryPath + "\lame\lame.exe"
                .Arguments = LAMEoptions + " """ + Me.localPath + """ """ + My.Application.Info.DirectoryPath + "\tmp\converted.mp3"""
                .CreateNoWindow = True
                .UseShellExecute = False
            End With

            lame.Start()
            lame.WaitForExit()

            lame.Dispose()

            Me._localPath = My.Application.Info.DirectoryPath + "\tmp\converted.mp3"
        Catch ex As Exception
            Debug.Print("ERROR: Could not delete """ & My.Application.Info.DirectoryPath + "\tmp\converted.mp3""")
        End Try
    End Sub

    Public Sub embedCover()
        TagLib.Id3v2.Tag.DefaultVersion = 3
        TagLib.Id3v2.Tag.ForceDefaultVersion = True

        ' copy file to embed cover in
        FileCopy(Me._localPath, My.Application.Info.DirectoryPath + "\tmp\embedCover.mp3")
        Me._localPath = My.Application.Info.DirectoryPath + "\tmp\embedCover.mp3"

        Dim mp3 As TagLib.File = TagLib.File.Create(Me._localPath)
        Dim cover As New TagLib.Id3v2.AttachedPictureFrame()
        Dim image As Image = Image.FromFile(Me._localPathOnly + "\" + Me.coverFile)
        Dim imgByte As Byte()

        ' convert image file to byte array
        Dim imgCon As New ImageConverter()
        imgByte = DirectCast(imgCon.ConvertTo(image, GetType(Byte())), Byte())

        ' add byte array to mp3 tag
        cover.Type = TagLib.PictureType.FrontCover
        cover.Data = imgByte
        cover.TextEncoding = TagLib.StringType.UTF16

        mp3.Tag.Pictures = New TagLib.IPicture() {cover}

        ' save mp3 file
        mp3.Save()
        mp3.Dispose()
    End Sub
End Class