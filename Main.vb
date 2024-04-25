Imports System.Configuration
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
        End If
    End Sub

    Private Sub settings_FormClosed(sender As Object, e As FormClosedEventArgs)
        openOnce = False
    End Sub

    Private Sub gamerunBTN_Click(sender As Object, e As EventArgs) Handles gamerunBTN.Click
        Dim selectedFilePath As String = ConfigurationManager.AppSettings("selectedFilePath")

        If Not String.IsNullOrEmpty(selectedFilePath) Then
            Try
                Process.Start(selectedFilePath)
            Catch ex As Exception
                MessageBox.Show("Failed to launch the application." & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            'This code is for when user selected the checkbox on settings form, this code starts to work.
            Dim CheckBox1 As CheckBox = settings.CheckBox1
            If CheckBox1.Checked Then
                Close()
            End If
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim settings As New settings()
        Dim findFileTXT As TextBox = settings.findFileTXT
        Dim CheckBox1 As CheckBox = settings.CheckBox1

        findFileTXT.Text = My.Settings.selectedFilePath
        CheckBox1.Checked = My.Settings.CheckBox1

    End Sub
End Class
