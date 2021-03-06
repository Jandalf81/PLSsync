﻿Imports PLSsync

Public Class Preset
    Private _localMainPath As String
    Private _remoteMainPath As String
    Private _Playlists As New List(Of Playlist)
    Private _embedCover As Boolean
    Private _convert As Boolean
    Private _LAMEoptions As String
    Private _syncPlaylists As Boolean
    Private _createPlaylistWithAddedTracks As Boolean
    Private _PlaylistWithAddedTracksName As String

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
    Public Property EmbedCover As Boolean
        Get
            Return _embedCover
        End Get
        Set(value As Boolean)
            _embedCover = value
        End Set
    End Property
    Public Property Convert As Boolean
        Get
            Return _convert
        End Get
        Set(value As Boolean)
            _convert = value
        End Set
    End Property
    Public Property LAMEoptions As String
        Get
            Return _LAMEoptions
        End Get
        Set(value As String)
            _LAMEoptions = value
        End Set
    End Property
    Public Property SyncPlaylists As Boolean
        Get
            Return _syncPlaylists
        End Get
        Set(value As Boolean)
            _syncPlaylists = value
        End Set
    End Property
    Public Property CreatePlaylistWithAddedTracks As Boolean
        Get
            Return _createPlaylistWithAddedTracks
        End Get
        Set(value As Boolean)
            _createPlaylistWithAddedTracks = value
        End Set
    End Property
    Public Property PlaylistWithAddedTracksName As String
        Get
            Return _PlaylistWithAddedTracksName
        End Get
        Set(value As String)
            _PlaylistWithAddedTracksName = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub Save(myPreset As String)
        Dim x As New Xml.Serialization.XmlSerializer(Me.GetType)
        Dim fileWriter As IO.StreamWriter

        fileWriter = My.Computer.FileSystem.OpenTextFileWriter(My.Application.Info.DirectoryPath + "\presets\" + myPreset + ".xml", False)
        x.Serialize(fileWriter, Me)
        fileWriter.Close()
    End Sub

    Public Sub Load(myPreset As String)
        Dim IPreset As New Preset()
        Dim x As New Xml.Serialization.XmlSerializer(Me.GetType)

        If (My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\presets\" + myPreset + ".xml")) Then
            Using fs As New IO.FileStream(My.Application.Info.DirectoryPath + "\presets\" + myPreset + ".xml", IO.FileMode.Open)
                IPreset = x.Deserialize(fs)
            End Using
        End If

        Me._localMainPath = IPreset.LocalMainPath
        Me._remoteMainPath = IPreset.RemoteMainPath
        Me._Playlists = IPreset.Playlists
        Me._embedCover = IPreset.EmbedCover
        Me._convert = IPreset.Convert
        Me._LAMEoptions = IPreset.LAMEoptions
        Me._syncPlaylists = IPreset.SyncPlaylists
        Me._createPlaylistWithAddedTracks = IPreset.CreatePlaylistWithAddedTracks
        Me._PlaylistWithAddedTracksName = IPreset.PlaylistWithAddedTracksName
    End Sub
End Class
