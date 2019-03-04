Public Class Track
    Private _localPath As String
    Private _remotePath As String
    Private _hasCover As Boolean
    Private _coverFile As String
    Private _preset As Preset

    Public Property localPath As String
        Get
            Return _localPath
        End Get
        Set(value As String)
            _localPath = value
            _remotePath = Replace(value, _preset.LocalMainPath, _preset.RemoteMainPath)

            _localPathOnly = IO.Path.GetDirectoryName(value)
            _localFilenameOnly = IO.Path.GetFileName(value)
            _remotePathOnly = IO.Path.GetDirectoryName(_remotePath)

            Select Case True
                Case My.Computer.FileSystem.FileExists(_localPathOnly + "\folder.jpg") = True
                    _hasCover = True
                    _coverFile = "folder.jpg"
                Case Else
                    _hasCover = False
                    _coverFile = ""
            End Select
        End Set
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

    Public Sub upload()
        Me.upload(Me.remotePath)
    End Sub

    Public Sub upload(toDevice As MediaDevices.MediaDevice)
        Me.upload(toDevice, Me.remotePath)
    End Sub

    Public Sub upload(toPath As String)
        If (frm_Main.selectedDevice.FileExists(Me.remotePath) = False) Then
            If (frm_Main.selectedDevice.DirectoryExists(Me._remotePathOnly) = False) Then
                frm_Main.selectedDevice.CreateDirectory(Me._remotePathOnly)
            End If

            Dim fs As New IO.FileStream(Me.localPath, IO.FileMode.Open, IO.FileAccess.Read)
            frm_Main.selectedDevice.UploadFile(fs, toPath)
        End If

        If (Me.hasCover = True) Then
            If (frm_Main.selectedDevice.FileExists(Me._remotePathOnly + "\" + Me.coverFile) = False) Then
                Dim fs As New IO.FileStream(Me._localPathOnly + "\" + Me.coverFile, IO.FileMode.Open, IO.FileAccess.Read)

                frm_Main.selectedDevice.UploadFile(fs, _remotePathOnly + "\" + Me.coverFile)
            End If
        End If
    End Sub

    Public Sub upload(toDevice As MediaDevices.MediaDevice, toPath As String)
        If (toDevice.FileExists(Me.remotePath) = False) Then
            If (toDevice.DirectoryExists(Me._remotePathOnly) = False) Then
                toDevice.CreateDirectory(Me._remotePathOnly)
            End If

            Dim fs As New IO.FileStream(Me.localPath, IO.FileMode.Open, IO.FileAccess.Read)
            toDevice.UploadFile(fs, toPath)

            fs.Dispose()
        End If


        If (Me.hasCover = True) Then
            If (toDevice.FileExists(Me._remotePathOnly + "\" + Me.coverFile) = False) Then
                Dim fs As New IO.FileStream(Me._localPathOnly + "\" + Me.coverFile, IO.FileMode.Open, IO.FileAccess.Read)

                toDevice.UploadFile(fs, _remotePathOnly + "\" + Me.coverFile)

                fs.Dispose()
            End If
        End If
    End Sub

    Public Sub convert()
        Try
            If (My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\tmp\converted.mp3") = True) Then
                My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\tmp\converted.mp3")
            End If

            ' LAME conversion
            Dim lame As New Process()

            With lame.StartInfo
                .FileName = My.Application.Info.DirectoryPath + "\lame\lame.exe"
                ' TODO make arguments dynamic
                .Arguments = "--nohist --preset medium """ + Me.localPath + """ """ + My.Application.Info.DirectoryPath + "\tmp\converted.mp3"""

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
End Class
