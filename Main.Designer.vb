<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        settingsBTN = New Button()
        gamerunBTN = New Button()
        ModORPackGetList = New ListBox()
        SuspendLayout()
        ' 
        ' settingsBTN
        ' 
        settingsBTN.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(162))
        settingsBTN.Location = New Point(12, 12)
        settingsBTN.Name = "settingsBTN"
        settingsBTN.Size = New Size(45, 37)
        settingsBTN.TabIndex = 0
        settingsBTN.Text = "🎚️"
        settingsBTN.UseVisualStyleBackColor = True
        ' 
        ' gamerunBTN
        ' 
        gamerunBTN.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gamerunBTN.Location = New Point(63, 12)
        gamerunBTN.Name = "gamerunBTN"
        gamerunBTN.Size = New Size(75, 37)
        gamerunBTN.TabIndex = 1
        gamerunBTN.Text = "RUN ▶️"
        gamerunBTN.UseVisualStyleBackColor = True
        ' 
        ' ModORPackGetList
        ' 
        ModORPackGetList.AllowDrop = True
        ModORPackGetList.FormattingEnabled = True
        ModORPackGetList.ItemHeight = 15
        ModORPackGetList.Location = New Point(12, 55)
        ModORPackGetList.Name = "ModORPackGetList"
        ModORPackGetList.Size = New Size(198, 214)
        ModORPackGetList.TabIndex = 3
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(222, 284)
        Controls.Add(ModORPackGetList)
        Controls.Add(gamerunBTN)
        Controls.Add(settingsBTN)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "JRDM Launcher"
        ResumeLayout(False)
    End Sub

    Friend WithEvents settingsBTN As Button
    Friend WithEvents gamerunBTN As Button
    Friend WithEvents ModORPackGetList As ListBox

End Class
