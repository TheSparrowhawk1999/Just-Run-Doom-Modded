Public Class settings
    Private Sub okBTN_Click(sender As Object, e As EventArgs) Handles okBTN.Click
        Close()
        Dim Main As New Main()
        Dim gamerunBTN As Button = Main.gamerunBTN
        gamerunBTN.Enabled = True
    End Sub

    Private Sub findBTN_Click(sender As Object, e As EventArgs) Handles findBTN.Click
        OpenFileDialog1.Filter = "Executable Files|*.exe"
        OpenFileDialog1.Title = "Find Doom Exes (Doom, Doom 2 or GZdoom Only)"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedFilePath As String = OpenFileDialog1.FileName
            If selectedFilePath.EndsWith("doom.exe", StringComparison.OrdinalIgnoreCase) OrElse selectedFilePath.EndsWith("doom2.exe", StringComparison.OrdinalIgnoreCase) OrElse selectedFilePath.EndsWith("gzdoom.exe", StringComparison.OrdinalIgnoreCase) Then
                findFileTXT.Text = selectedFilePath
            Else
                MessageBox.Show("Only Doom Exes accepted. Select again.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
End Class