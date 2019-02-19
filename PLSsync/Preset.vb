Imports PLSsync

Public Class Preset
    Private _localMainPath As String
    Private _remoteMainPath As String
    Private _Playlists As New List(Of Playlist)

    Public Property LocalMainPath As String
        Get
            Return _localMainPath
        End Get
        Set(value As String)
            _localMainPath = value
        End Set
    End Property
    Public Property RemoteMainPath As String
        Get
            Return _remoteMainPath
        End Get
        Set(value As String)
            _remoteMainPath = value
        End Set
    End Property
    Public Property Playlists As List(Of Playlist)
        Get
            Return _Playlists
        End Get
        Set(value As List(Of Playlist))
            _Playlists = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub Save(myPreset As String)
        Dim x As New Xml.Serialization.XmlSerializer(Me.GetType)
        Dim fileWriter As IO.StreamWriter

        If Not (My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\presets\")) Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath + "\presets\")
        End If

        fileWriter = My.Computer.FileSystem.OpenTextFileWriter(My.Application.Info.DirectoryPath + "\presets\" + myPreset + ".xml", False)
        x.Serialize(fileWriter, Me)
        fileWriter.Close()
    End Sub

    Public Sub Load(myPreset As String)
        Dim ISettings As New Preset()
        Dim x As New Xml.Serialization.XmlSerializer(Me.GetType)

        If Not (My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\presets\")) Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath + "\presets\")
        End If

        If (My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\presets\" + myPreset + ".xml")) Then
            Using fs As New IO.FileStream(My.Application.Info.DirectoryPath + "\presets\" + myPreset + ".xml", IO.FileMode.Open)
                ISettings = x.Deserialize(fs)
            End Using
        End If

        Me._localMainPath = ISettings.LocalMainPath
        Me._remoteMainPath = ISettings.RemoteMainPath
        Me.Playlists = ISettings.Playlists
    End Sub
End Class
