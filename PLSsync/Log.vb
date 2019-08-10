Imports PLSsync

Public Class Log
    Private _logEntries As New List(Of LogEntry)

    Public Property LogEntries As List(Of LogEntry)
        Get
            Return _logEntries
        End Get
        Set(value As List(Of LogEntry))
            _logEntries = value
        End Set
    End Property

    Public Sub New()
    End Sub
End Class
