Imports System.IO

Public Class Main

    Private openOnce As Boolean = False

    Private Sub ModORPackGetList_DragEnter(sender As Object, e As DragEventArgs) Handles ModORPackGetList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files As String() = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
            Dim supportedfilesOnly As String() = {".wad", ".pk3"} 'Only gets Doom files like WAD or PK3

            For Each file In files
                Dim fileExt As String = Path.GetExtension(file)

                If supportedfilesOnly.Contains(fileExt) Then
                    e.Effect = DragDropEffects.Copy
                Else
                    e.Effect = DragDropEffects.None
                    Exit Sub

                End If
            Next
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub ModORPackGetList_DragDrop(sender As Object, e As DragEventArgs) Handles ModORPackGetList.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files As String() = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
            For Each file In files
                ModORPackGetList.Items.Add(file)
            Next
        End If
    End Sub

    Private Sub ModORPackGetList_KeyDown(sender As Object, e As KeyEventArgs) Handles ModORPackGetList.KeyDown
        'This is for deleting files in listbox via DEL button, you cannot right click on this.
        If e.KeyCode = Keys.Delete Then
            For Each selectedItem As String In ModORPackGetList.SelectedItems.Cast(Of String)().ToList()
                ModORPackGetList.Items.Remove(selectedItem)
            Next
        End If
    End Sub

    Private Sub settingsBTN_Click(sender As Object, e As EventArgs) Handles settingsBTN.Click
        If Not openOnce Then
            Dim settings As New settings()
            settings.Show()
            'these 2 lines of code is for not making other open section opening multiple times. Since VB.NET is dumb but easy.
            openOnce = True
            AddHandler settings.FormClosed, AddressOf settings_FormClosed
            gamerunBTN.Enabled = False
        End If
    End Sub

    Private Sub settings_FormClosed(sender As Object, e As FormClosedEventArgs)
        openOnce = False
    End Sub
End Class
