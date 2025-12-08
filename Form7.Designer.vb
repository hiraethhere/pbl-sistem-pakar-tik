<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardDosen
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
        NamaTextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        NIMTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        DataGridView = New DataGridView()
        ProdiComboBox = New ComboBox()
        Label4 = New Label()
        RoleComboBox = New ComboBox()
        Label5 = New Label()
        LogOutButton = New Button()
        TambahButton = New Button()
        EditButton = New Button()
        HapusButton = New Button()
        ClearButton = New Button()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NamaTextBox
        ' 
        NamaTextBox.Location = New Point(26, 107)
        NamaTextBox.Name = "NamaTextBox"
        NamaTextBox.Size = New Size(158, 25)
        NamaTextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 17)
        Label1.TabIndex = 1
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 17)
        Label2.TabIndex = 2
        Label2.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 17)
        Label3.TabIndex = 3
        Label3.Text = "Prodi"
        ' 
        ' NIMTextBox
        ' 
        NIMTextBox.Location = New Point(26, 48)
        NIMTextBox.Name = "NIMTextBox"
        NIMTextBox.Size = New Size(158, 25)
        NIMTextBox.TabIndex = 4
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(26, 304)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(158, 25)
        PasswordTextBox.TabIndex = 5
        ' 
        ' DataGridView
        ' 
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Location = New Point(220, 28)
        DataGridView.Name = "DataGridView"
        DataGridView.RowHeadersWidth = 45
        DataGridView.Size = New Size(568, 170)
        DataGridView.TabIndex = 6
        ' 
        ' ProdiComboBox
        ' 
        ProdiComboBox.FormattingEnabled = True
        ProdiComboBox.Location = New Point(26, 173)
        ProdiComboBox.Name = "ProdiComboBox"
        ProdiComboBox.Size = New Size(158, 25)
        ProdiComboBox.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 216)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 17)
        Label4.TabIndex = 8
        Label4.Text = "Role"
        ' 
        ' RoleComboBox
        ' 
        RoleComboBox.FormattingEnabled = True
        RoleComboBox.Location = New Point(26, 236)
        RoleComboBox.Name = "RoleComboBox"
        RoleComboBox.Size = New Size(158, 25)
        RoleComboBox.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(26, 284)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 17)
        Label5.TabIndex = 10
        Label5.Text = "Password"
        ' 
        ' LogOutButton
        ' 
        LogOutButton.Location = New Point(220, 262)
        LogOutButton.Name = "LogOutButton"
        LogOutButton.Size = New Size(83, 25)
        LogOutButton.TabIndex = 11
        LogOutButton.Text = "Logout"
        LogOutButton.UseVisualStyleBackColor = True
        ' 
        ' TambahButton
        ' 
        TambahButton.Location = New Point(347, 262)
        TambahButton.Name = "TambahButton"
        TambahButton.Size = New Size(83, 25)
        TambahButton.TabIndex = 12
        TambahButton.Text = "Tambah"
        TambahButton.UseVisualStyleBackColor = True
        ' 
        ' EditButton
        ' 
        EditButton.Location = New Point(482, 262)
        EditButton.Name = "EditButton"
        EditButton.Size = New Size(83, 25)
        EditButton.TabIndex = 13
        EditButton.Text = "Edit"
        EditButton.UseVisualStyleBackColor = True
        ' 
        ' HapusButton
        ' 
        HapusButton.Location = New Point(609, 262)
        HapusButton.Name = "HapusButton"
        HapusButton.Size = New Size(83, 25)
        HapusButton.TabIndex = 14
        HapusButton.Text = "Hapus"
        HapusButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(220, 212)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(83, 25)
        ClearButton.TabIndex = 15
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' DashboardDosen
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 353)
        Controls.Add(ClearButton)
        Controls.Add(HapusButton)
        Controls.Add(EditButton)
        Controls.Add(TambahButton)
        Controls.Add(LogOutButton)
        Controls.Add(Label5)
        Controls.Add(RoleComboBox)
        Controls.Add(Label4)
        Controls.Add(ProdiComboBox)
        Controls.Add(DataGridView)
        Controls.Add(PasswordTextBox)
        Controls.Add(NIMTextBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(NamaTextBox)
        Name = "DashboardDosen"
        Text = "Dashboard Dosen"
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NamaTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NIMTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents ProdiComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RoleComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LogOutButton As Button
    Friend WithEvents TambahButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents HapusButton As Button
    Friend WithEvents ClearButton As Button
End Class
