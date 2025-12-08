<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrasi
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
        KembaliButton = New Button()
        RegistrasiButton = New Button()
        ProdiComboBox = New ComboBox()
        NamaLabel = New Label()
        NIMLabel = New Label()
        ProdiLabel = New Label()
        NamaTextBox = New TextBox()
        NIMTextBox = New TextBox()
        Label1 = New Label()
        PasswordTextBox = New TextBox()
        Label2 = New Label()
        RoleComboBox = New ComboBox()
        SuspendLayout()
        ' 
        ' KembaliButton
        ' 
        KembaliButton.Location = New Point(54, 231)
        KembaliButton.Name = "KembaliButton"
        KembaliButton.Size = New Size(83, 25)
        KembaliButton.TabIndex = 0
        KembaliButton.Text = "Kembali"
        KembaliButton.UseVisualStyleBackColor = True
        ' 
        ' RegistrasiButton
        ' 
        RegistrasiButton.Location = New Point(245, 231)
        RegistrasiButton.Name = "RegistrasiButton"
        RegistrasiButton.Size = New Size(83, 25)
        RegistrasiButton.TabIndex = 1
        RegistrasiButton.Text = "Registrasi"
        RegistrasiButton.UseVisualStyleBackColor = True
        ' 
        ' ProdiComboBox
        ' 
        ProdiComboBox.FormattingEnabled = True
        ProdiComboBox.Location = New Point(12, 106)
        ProdiComboBox.Name = "ProdiComboBox"
        ProdiComboBox.Size = New Size(178, 25)
        ProdiComboBox.TabIndex = 2
        ' 
        ' NamaLabel
        ' 
        NamaLabel.AutoSize = True
        NamaLabel.Location = New Point(12, 19)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New Size(43, 17)
        NamaLabel.TabIndex = 3
        NamaLabel.Text = "Nama"
        ' 
        ' NIMLabel
        ' 
        NIMLabel.AutoSize = True
        NIMLabel.Location = New Point(211, 19)
        NIMLabel.Name = "NIMLabel"
        NIMLabel.Size = New Size(33, 17)
        NIMLabel.TabIndex = 4
        NIMLabel.Text = "NIM"
        ' 
        ' ProdiLabel
        ' 
        ProdiLabel.AutoSize = True
        ProdiLabel.Location = New Point(12, 86)
        ProdiLabel.Name = "ProdiLabel"
        ProdiLabel.Size = New Size(39, 17)
        ProdiLabel.TabIndex = 5
        ProdiLabel.Text = "Prodi"
        ' 
        ' NamaTextBox
        ' 
        NamaTextBox.Location = New Point(12, 39)
        NamaTextBox.Name = "NamaTextBox"
        NamaTextBox.Size = New Size(178, 25)
        NamaTextBox.TabIndex = 6
        ' 
        ' NIMTextBox
        ' 
        NIMTextBox.Location = New Point(211, 39)
        NIMTextBox.Name = "NIMTextBox"
        NIMTextBox.Size = New Size(178, 25)
        NIMTextBox.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 153)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 17)
        Label1.TabIndex = 8
        Label1.Text = "Password"
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(12, 173)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(178, 25)
        PasswordTextBox.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(211, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 17)
        Label2.TabIndex = 10
        Label2.Text = "Role"
        ' 
        ' RoleComboBox
        ' 
        RoleComboBox.FormattingEnabled = True
        RoleComboBox.Location = New Point(211, 106)
        RoleComboBox.Name = "RoleComboBox"
        RoleComboBox.Size = New Size(178, 25)
        RoleComboBox.TabIndex = 11
        ' 
        ' FormRegistrasi
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(401, 288)
        Controls.Add(RoleComboBox)
        Controls.Add(Label2)
        Controls.Add(PasswordTextBox)
        Controls.Add(Label1)
        Controls.Add(NIMTextBox)
        Controls.Add(NamaTextBox)
        Controls.Add(ProdiLabel)
        Controls.Add(NIMLabel)
        Controls.Add(NamaLabel)
        Controls.Add(ProdiComboBox)
        Controls.Add(RegistrasiButton)
        Controls.Add(KembaliButton)
        Name = "FormRegistrasi"
        Text = "Form Registrasi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents KembaliButton As Button
    Friend WithEvents RegistrasiButton As Button
    Friend WithEvents ProdiComboBox As ComboBox
    Friend WithEvents NamaLabel As Label
    Friend WithEvents NIMLabel As Label
    Friend WithEvents ProdiLabel As Label
    Friend WithEvents NamaTextBox As TextBox
    Friend WithEvents NIMTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RoleComboBox As ComboBox
End Class
