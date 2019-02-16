Public Class frm_Main
    Public deviceList As New List(Of MediaDevices.MediaDevice)
    Public bs As Equin.ApplicationFramework.BindingListView(Of MediaDevices.MediaDevice) = New Equin.ApplicationFramework.BindingListView(Of MediaDevices.MediaDevice)(deviceList)


    Public Sub refreshDevices()
        Dim devices As IEnumerable(Of MediaDevices.MediaDevice) = MediaDevices.MediaDevice.GetDevices()
        Dim deviceList As New List(Of MediaDevices.MediaDevice)

        For Each device In devices
            device.Connect()
            deviceList.Add(device)
        Next

        'bs = New Equin.ApplicationFramework.BindingListView(Of MediaDevices.MediaDevice)(deviceList)
        dgv_Devices.DataSource = deviceList
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs)
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

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' settings for DataGridView
        With dgv_Devices
            .ReadOnly() = True
            .AllowUserToAddRows = False
            .AutoGenerateColumns = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End With

        ' prepare columns for DataGridView
        Dim col_FriendlyName As New DataGridViewTextBoxColumn()
        col_FriendlyName.DataPropertyName = "FriendlyName"
        col_FriendlyName.Name = "Friendly Name"

        Dim col_Description As New DataGridViewTextBoxColumn()
        col_Description.DataPropertyName = "Description"
        col_Description.Name = "Description"

        Dim col_Manufacturer As New DataGridViewTextBoxColumn()
        col_Manufacturer.DataPropertyName = "Manufacturer"
        col_Manufacturer.Name = "Manufacturer"

        Dim col_DeviceType As New DataGridViewTextBoxColumn()
        col_DeviceType.DataPropertyName = "DeviceType"
        col_DeviceType.Name = "DeviceType"

        Dim col_PowerLevel As New DataGridViewTextBoxColumn()
        col_PowerLevel.DataPropertyName = "PowerLevel"
        col_PowerLevel.Name = "PowerLevel"

        Dim col_SerialNumber As New DataGridViewTextBoxColumn()
        col_SerialNumber.DataPropertyName = "SerialNumber"
        col_SerialNumber.Name = "SerialNumber"

        ' add prepared columns to DataGridView
        With dgv_Devices.Columns
            .Add(col_Manufacturer)
            .Add(col_Description)
            .Add(col_DeviceType)
            .Add(col_FriendlyName)
            .Add(col_PowerLevel)
            .Add(col_SerialNumber)
        End With

        refreshDevices()
    End Sub

    Private Sub btn_RefreshDevices_Click(sender As Object, e As EventArgs) Handles btn_RefreshDevices.Click
        refreshDevices()
    End Sub
End Class
