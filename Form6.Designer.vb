<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardMahasiswa
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
        NamaTextBox = New TextBox()
        Label2 = New Label()
        NIMTextBox = New TextBox()
        Label3 = New Label()
        ProdiComboBox = New ComboBox()
        LogOutButton = New Button()
        TestRekomendasiButton = New Button()
        GroupBox1 = New GroupBox()
        Label4 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 17)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' NamaTextBox
        ' 
        NamaTextBox.Location = New Point(26, 105)
        NamaTextBox.Name = "NamaTextBox"
        NamaTextBox.Size = New Size(169, 25)
        NamaTextBox.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 17)
        Label2.TabIndex = 2
        Label2.Text = "NIM"
        ' 
        ' NIMTextBox
        ' 
        NIMTextBox.Location = New Point(26, 46)
        NIMTextBox.Name = "NIMTextBox"
        NIMTextBox.Size = New Size(169, 25)
        NIMTextBox.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 17)
        Label3.TabIndex = 4
        Label3.Text = "Prodi"
        ' 
        ' ProdiComboBox
        ' 
        ProdiComboBox.FormattingEnabled = True
        ProdiComboBox.Location = New Point(26, 168)
        ProdiComboBox.Name = "ProdiComboBox"
        ProdiComboBox.Size = New Size(169, 25)
        ProdiComboBox.TabIndex = 5
        ' 
        ' LogOutButton
        ' 
        LogOutButton.Location = New Point(26, 264)
        LogOutButton.Name = "LogOutButton"
        LogOutButton.Size = New Size(83, 25)
        LogOutButton.TabIndex = 6
        LogOutButton.Text = "Logout"
        LogOutButton.UseVisualStyleBackColor = True
        ' 
        ' TestRekomendasiButton
        ' 
        TestRekomendasiButton.Location = New Point(164, 264)
        TestRekomendasiButton.Name = "TestRekomendasiButton"
        TestRekomendasiButton.Size = New Size(132, 25)
        TestRekomendasiButton.TabIndex = 7
        TestRekomendasiButton.Text = "Test Rekomendasi"
        TestRekomendasiButton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(274, 31)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(282, 179)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(88, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 17)
        Label4.TabIndex = 0
        Label4.Text = "Tambahin hasilnya"
        ' 
        ' DashboardMahasiswa
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(593, 358)
        Controls.Add(GroupBox1)
        Controls.Add(TestRekomendasiButton)
        Controls.Add(LogOutButton)
        Controls.Add(ProdiComboBox)
        Controls.Add(Label3)
        Controls.Add(NIMTextBox)
        Controls.Add(Label2)
        Controls.Add(NamaTextBox)
        Controls.Add(Label1)
        Name = "DashboardMahasiswa"
        Text = "Dashboard Mahasiswa"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NamaTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NIMTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ProdiComboBox As ComboBox
    Friend WithEvents LogOutButton As Button
    Friend WithEvents TestRekomendasiButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
End Class
