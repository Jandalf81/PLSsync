Public Class LogEntry
    Private _timestamp As DateTime
    Private _PlaylistFile As String
    Private _mp3File As String
    Private _text As String
    Private _status As myStatusEnum
    Private _convertStatus As myStatusEnum
    Private _convertStatusImage As Image
    Private _coverStatus As myStatusEnum
    Private _uploadStatus As myStatusEnum

    Public Property Timestamp As Date
        Get
            Return _timestamp
        End Get
        Set(value As Date)
            _timestamp = value
        End Set
    End Property
    Public Property PlaylistFile As String
        Get
            Return _PlaylistFile
        End Get
        Set(value As String)
            _PlaylistFile = value
        End Set
    End Property
    Public Property Mp3File As String
        Get
            Return _mp3File
        End Get
        Set(value As String)
            _mp3File = value
        End Set
    End Property
    Public Property Status As myStatusEnum
        Get
            Return _status
        End Get
        Set(value As myStatusEnum)
            _status = value
        End Set
    End Property
    Public Property ConvertStatus As myStatusEnum
        Get
            Return _convertStatus
        End Get
        Set(value As myStatusEnum)
            _convertStatus = value

            Select Case value
                Case LogEntry.myStatusEnum.Waiting
                    _convertStatusImage = My.Resources.accept
                Case LogEntry.myStatusEnum.OK
                    _convertStatusImage = My.Resources.add
                Case LogEntry.myStatusEnum.Info
                    _convertStatusImage = My.Resources.arrow_refresh
                Case LogEntry.myStatusEnum.Warning
                    _convertStatusImage = My.Resources.delete
                Case LogEntry.myStatusEnum.Error
                    _convertStatusImage = My.Resources.folder
                Case LogEntry.myStatusEnum.Skipped
                    _convertStatusImage = My.Resources.accept
            End Select
        End Set
    End Property
    Public Property ConvertStatusImage As Image
        Get
            Return _convertStatusImage
        End Get
        Set(value As Image)
            _convertStatusImage = value
        End Set
    End Property
    Public Property CoverStatus As myStatusEnum
        Get
            Return _coverStatus
        End Get
        Set(value As myStatusEnum)
            _coverStatus = value
        End Set
    End Property
    Public Property UploadStatus As myStatusEnum
        Get
            Return _uploadStatus
        End Get
        Set(value As myStatusEnum)
            _uploadStatus = value
        End Set
    End Property
    Public Property Text As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
        End Set
    End Property


    Public Enum myStatusEnum
        Waiting = 0
        OK = 1
        Info = 2
        Warning = 3
        [Error] = 4
        Skipped = 5
    End Enum

    Public Sub New()
        Me.Timestamp = Now()

        _convertStatusImage = My.Resources.accept
    End Sub

    Public Sub New(ByVal INPlaylistfile As String, INmp3File As String)
        Me.Timestamp = Now()

        _convertStatusImage = My.Resources.accept

        Me.PlaylistFile = INPlaylistfile
        Me.Mp3File = INmp3File
    End Sub
End Class
