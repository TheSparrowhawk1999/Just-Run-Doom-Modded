<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        findFileTXT = New TextBox()
        findBTN = New Button()
        CheckBox1 = New CheckBox()
        okBTN = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 0
        Label1.Text = "Game File :"
        ' 
        ' findFileTXT
        ' 
        findFileTXT.Location = New Point(83, 6)
        findFileTXT.Name = "findFileTXT"
        findFileTXT.Size = New Size(309, 23)
        findFileTXT.TabIndex = 1
        findFileTXT.Text = "Find Doom.exe --->"
        ' 
        ' findBTN
        ' 
        findBTN.Location = New Point(398, 6)
        findBTN.Name = "findBTN"
        findBTN.Size = New Size(49, 23)
        findBTN.TabIndex = 2
        findBTN.Text = "Find"
        findBTN.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(12, 45)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(173, 19)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Close when game launches."
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' okBTN
        ' 
        okBTN.Location = New Point(379, 45)
        okBTN.Name = "okBTN"
        okBTN.Size = New Size(75, 23)
        okBTN.TabIndex = 4
        okBTN.Text = "OK"
        okBTN.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(466, 80)
        Controls.Add(okBTN)
        Controls.Add(CheckBox1)
        Controls.Add(findBTN)
        Controls.Add(findFileTXT)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "settings"
        ShowIcon = False
        ShowInTaskbar = False
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents findFileTXT As TextBox
    Friend WithEvents findBTN As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents okBTN As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
