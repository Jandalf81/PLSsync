Imports System.Xml.Serialization
Imports PLSsync

Public Class Playlist
    Private _Filename As String
    Private _NumberOfTracks As Integer
    Private _tracks As New List(Of Track)

    Public Property Filename As String
        Get
            Return _Filename
        End Get
        Set(value As String)
            _Filename = value

            ' get content of file on setting the Filename (even on Deserialization)
            If (My.Computer.FileSystem.FileExists(Me.Filename)) Then
                Me.NumberOfTracks = System.IO.File.ReadAllLines(value).Length
            Else
                Me.NumberOfTracks = 0
            End If
        End Set
    End Property
    <XmlIgnore()> Public Property NumberOfTracks As Integer ' ignore this property on Serialization
        Get
            Return _NumberOfTracks
        End Get
        Set(value As Integer)
            _NumberOfTracks = value
        End Set
    End Property
    <XmlIgnore()> Public ReadOnly Property Tracks As List(Of Track)
        Get
            Return _tracks
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Sub New(file As String)
        Me.Filename = file
    End Sub

    Public Sub read()
        Dim t As Track

        Me.Tracks.Clear()

        If (My.Computer.FileSystem.FileExists(Me.Filename) = True) Then
            Dim fileReader As System.IO.StreamReader
            Dim line As String

            fileReader = My.Computer.FileSystem.OpenTextFileReader(Me.Filename)

            Do
                line = fileReader.ReadLine()
                If line Is Nothing Then Exit Do

                t = New Track(line)
                Me.Tracks.Add(t)
            Loop

            fileReader.Close()
        End If
    End Sub

    Public Sub read(preset As Preset)
        Dim t As Track

        Me.Tracks.Clear()

        If (My.Computer.FileSystem.FileExists(Me.Filename) = True) Then
            Dim fileReader As System.IO.StreamReader
            Dim line As String

            fileReader = My.Computer.FileSystem.OpenTextFileReader(Me.Filename, System.Text.Encoding.UTF8)

            Do
                line = fileReader.ReadLine()
                If line Is Nothing Then Exit Do

                t = New Track(line, preset)
                Me.Tracks.Add(t)
            Loop

            fileReader.Close()
        End If
    End Sub

    Public Sub createRemotePlaylist(preset As Preset)
        Dim content As String = ""

        For Each track In Me.Tracks
            content += track.remotePath.Replace(preset.RemoteMainPath, "") & vbCrLf
        Next

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(My.Application.Info.DirectoryPath & "\tmp\" & IO.Path.GetFileName(Me.Filename), False)
        file.Write(content)
        file.Close()
        file.Dispose()
    End Sub

    Public Sub upload(toDevice As MediaDevices.MediaDevice, preset As Preset)
        ' delete Playlist file if it exists
        If (toDevice.FileExists(preset.RemoteMainPath & IO.Path.GetFileName(Me.Filename))) Then
            toDevice.DeleteFile(preset.RemoteMainPath & IO.Path.GetFileName(Me.Filename))
        End If

        ' create remote Playlist
        createRemotePlaylist(preset)

        ' upload new file
        Dim fs As New IO.FileStream(My.Application.Info.DirectoryPath & "\tmp\" & IO.Path.GetFileName(Me.Filename), IO.FileMode.Open, IO.FileAccess.Read)
        toDevice.UploadFile(fs, preset.RemoteMainPath & IO.Path.GetFileName(Me.Filename))

        fs.Dispose()
    End Sub
End Class
