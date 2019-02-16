Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim devices As IEnumerable(Of MediaDevices.MediaDevice) = MediaDevices.MediaDevice.GetDevices()

        For Each device In devices
            MsgBox("FriendlyName: " + device.FriendlyName + vbCrLf +
                   "Description: " + device.Description + vbCrLf +
                   "Manufacturer: " + device.Manufacturer)

            If (device.Description = "Pixel 2") Then
                device.Connect()

                Dim directories As IEnumerable(Of String) = device.EnumerateDirectories("/", "", IO.SearchOption.TopDirectoryOnly)
                For Each directory In directories
                    MsgBox("Directory: " + directory)
                Next

                Dim contentLocations As IEnumerable(Of String) = device.GetContentLocations(MediaDevices.ContentType.Audio)
                For Each contentLocation In contentLocations
                    MsgBox("Content Location: " + contentLocation)
                Next
            End If
        Next
    End Sub
End Class
