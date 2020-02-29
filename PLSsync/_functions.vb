Module _functions
    Public Sub prepareDirectories()
        If Not (My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\lame\")) Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath + "\lame\")
        End If

        If Not (My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\logs\")) Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath + "\logs\")
        End If

        If Not (My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\presets\")) Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath + "\presets\")
        End If

        If Not (My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\tmp\")) Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath + "\tmp\")
        End If
    End Sub

    Public Sub logToFile(logFile As String, message As String)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(logFile, True)
        file.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss: ") & message)

        file.Close()
        file.Dispose()
    End Sub
End Module
