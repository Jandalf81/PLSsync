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
            Me.NumberOfTracks = System.IO.File.ReadAllLines(value).Length
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
End Class
