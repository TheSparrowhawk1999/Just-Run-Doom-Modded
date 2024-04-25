Imports System.Configuration
Public Class settings
    Private Sub okBTN_Click(sender As Object, e As EventArgs) Handles okBTN.Click
        Close()
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

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        If config.AppSettings.Settings("selectedFilePath") IsNot Nothing Then
            findFileTXT.Text = config.AppSettings.Settings("selectedFilePath").Value
        End If

        If config.AppSettings.Settings("CheckBox1") IsNot Nothing Then
            CheckBox1.Checked = Boolean.Parse(config.AppSettings.Settings("CheckBox1").Value)
        End If

    End Sub

    Private Sub settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        If config.AppSettings.Settings("selectedFilePath") IsNot Nothing Then
            config.AppSettings.Settings("selectedFilePath").Value = findFileTXT.Text
        Else
            config.AppSettings.Settings.Add("selectedFilePath", findFileTXT.Text)
        End If

        If config.AppSettings.Settings("CheckBox1") IsNot Nothing Then
            config.AppSettings.Settings("CheckBox1").Value = CheckBox1.Checked.ToString()
        Else
            config.AppSettings.Settings.Add("CheckBox1", CheckBox1.Checked.ToString())
        End If

        config.Save(ConfigurationSaveMode.Modified)
    End Sub
End Class