Imports System.Xml.Serialization

Public Class Playlist
    Private _Filename As String
    Private _NumberOfTracks As Integer

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

    Public Sub New()
    End Sub

    Public Sub New(file As String)
        Me.Filename = file
    End Sub
End Class
