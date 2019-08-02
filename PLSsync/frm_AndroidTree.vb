Public Class frm_AndroidTree
    Private device As MediaDevices.MediaDevice
    Private Const maxLevelsToLoad As Integer = 2

    Public selectedPath As String

    Public Sub New(givenDevice As MediaDevices.MediaDevice)
        InitializeComponent()
        device = givenDevice
    End Sub

    Private Sub frm_AndroidTree_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rootNode As New TreeNode(device.Description)

        trv_Android.Nodes.Add(rootNode)
        addSubDirectoriesToNode("\", rootNode, 0)
        'test("\", rootNode)

        rootNode.Expand()
        btn_OK.Enabled = False
    End Sub

    ' get all directories from a given path, add them to a parent node RECURSIVELY
    Private Sub addSubDirectoriesToNode(path As String, parentNode As TreeNode, currentLevel As Integer)
        Dim directories As IEnumerable(Of String)
        directories = device.EnumerateDirectories(path).ToArray

        Array.Sort(directories)

        For Each directory In directories
            directory = directory.Split("\").Last

            Dim newNode As New TreeNode(directory)
            parentNode.Nodes.Add(newNode)

            If (currentLevel < maxLevelsToLoad) Then
                addSubDirectoriesToNode(path & "\" & directory, newNode, currentLevel + 1)
                ' TODO finish lazy loading
            End If
        Next
    End Sub

    Private Sub test(path As String, parentNode As TreeNode)
        Dim directories As IEnumerable(Of String)
        directories = device.EnumerateDirectories(path, "", IO.SearchOption.AllDirectories)

        Dim splitPath As String()
        Dim level As Integer

        For Each directory In directories
            splitPath = directory.Split("\")

            level = 1

            For Each partOfPath In splitPath
                ' TODO finish populating the tree
            Next
        Next
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        selectedPath = trv_Android.SelectedNode.FullPath
        selectedPath = selectedPath.Replace(selectedPath.Split("\").First & "\", "") & "\"

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub trv_Android_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles trv_Android.BeforeExpand
        ' TODO finish lazy loading
    End Sub

    Private Sub enableOKButton() Handles trv_Android.AfterSelect
        If (trv_Android.SelectedNode.Level >= 1) Then
            btn_OK.Enabled = True
        Else
            btn_OK.Enabled = False
        End If
    End Sub
End Class