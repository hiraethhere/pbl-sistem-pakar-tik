Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrasi
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        FlowLayoutPanel5 = New FlowLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label3 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        FlowLayoutPanel4.SuspendLayout()
        FlowLayoutPanel5.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' KembaliButton
        ' 
        KembaliButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        KembaliButton.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        KembaliButton.Cursor = Cursors.Hand
        KembaliButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        KembaliButton.FlatStyle = FlatStyle.Flat
        KembaliButton.Font = New Font("Calibri", 9F, FontStyle.Bold)
        KembaliButton.ForeColor = Color.White
        KembaliButton.Location = New Point(21, 395)
        KembaliButton.Name = "KembaliButton"
        KembaliButton.Size = New Size(367, 26)
        KembaliButton.TabIndex = 0
        KembaliButton.Text = "Kembali"
        KembaliButton.UseVisualStyleBackColor = False
        ' 
        ' RegistrasiButton
        ' 
        RegistrasiButton.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        RegistrasiButton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        RegistrasiButton.Cursor = Cursors.Hand
        RegistrasiButton.FlatStyle = FlatStyle.Flat
        RegistrasiButton.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RegistrasiButton.ForeColor = SystemColors.ControlText
        RegistrasiButton.Location = New Point(21, 295)
        RegistrasiButton.Name = "RegistrasiButton"
        RegistrasiButton.Size = New Size(367, 26)
        RegistrasiButton.TabIndex = 1
        RegistrasiButton.Text = "Registrasi"
        RegistrasiButton.UseVisualStyleBackColor = False
        ' 
        ' ProdiComboBox
        ' 
        ProdiComboBox.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ProdiComboBox.FormattingEnabled = True
        ProdiComboBox.Location = New Point(3, 25)
        ProdiComboBox.Name = "ProdiComboBox"
        ProdiComboBox.Size = New Size(171, 30)
        ProdiComboBox.TabIndex = 2
        ' 
        ' NamaLabel
        ' 
        NamaLabel.AutoSize = True
        NamaLabel.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NamaLabel.Location = New Point(3, 0)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New Size(39, 14)
        NamaLabel.TabIndex = 3
        NamaLabel.Text = "Nama"
        ' 
        ' NIMLabel
        ' 
        NIMLabel.AutoSize = True
        NIMLabel.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NIMLabel.Location = New Point(3, 0)
        NIMLabel.Name = "NIMLabel"
        NIMLabel.Size = New Size(29, 14)
        NIMLabel.TabIndex = 4
        NIMLabel.Text = "NIM"
        ' 
        ' ProdiLabel
        ' 
        ProdiLabel.AutoSize = True
        ProdiLabel.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ProdiLabel.Location = New Point(3, 0)
        ProdiLabel.Name = "ProdiLabel"
        ProdiLabel.Size = New Size(40, 22)
        ProdiLabel.TabIndex = 5
        ProdiLabel.Text = "Prodi"
        ' 
        ' NamaTextBox
        ' 
        NamaTextBox.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NamaTextBox.Location = New Point(3, 17)
        NamaTextBox.Name = "NamaTextBox"
        NamaTextBox.Size = New Size(171, 25)
        NamaTextBox.TabIndex = 6
        ' 
        ' NIMTextBox
        ' 
        NIMTextBox.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NIMTextBox.Location = New Point(3, 17)
        NIMTextBox.Name = "NIMTextBox"
        NIMTextBox.Size = New Size(172, 25)
        NIMTextBox.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(5, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 22)
        Label1.TabIndex = 8
        Label1.Text = "Password"
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordTextBox.Location = New Point(5, 27)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(353, 25)
        PasswordTextBox.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 22)
        Label2.TabIndex = 10
        Label2.Text = "Role"
        ' 
        ' RoleComboBox
        ' 
        RoleComboBox.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RoleComboBox.FormattingEnabled = True
        RoleComboBox.Location = New Point(3, 25)
        RoleComboBox.Name = "RoleComboBox"
        RoleComboBox.Size = New Size(172, 30)
        RoleComboBox.TabIndex = 11
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel1.Controls.Add(NamaLabel)
        FlowLayoutPanel1.Controls.Add(NamaTextBox)
        FlowLayoutPanel1.Location = New Point(3, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(174, 45)
        FlowLayoutPanel1.TabIndex = 12
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel2.Controls.Add(ProdiLabel)
        FlowLayoutPanel2.Controls.Add(ProdiComboBox)
        FlowLayoutPanel2.Location = New Point(3, 54)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(174, 57)
        FlowLayoutPanel2.TabIndex = 13
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel3.Controls.Add(NIMLabel)
        FlowLayoutPanel3.Controls.Add(NIMTextBox)
        FlowLayoutPanel3.Location = New Point(183, 3)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(175, 45)
        FlowLayoutPanel3.TabIndex = 13
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel4.Controls.Add(Label2)
        FlowLayoutPanel4.Controls.Add(RoleComboBox)
        FlowLayoutPanel4.Location = New Point(183, 54)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(175, 57)
        FlowLayoutPanel4.TabIndex = 14
        ' 
        ' FlowLayoutPanel5
        ' 
        FlowLayoutPanel5.Anchor = AnchorStyles.Top
        FlowLayoutPanel5.Controls.Add(Label1)
        FlowLayoutPanel5.Controls.Add(PasswordTextBox)
        FlowLayoutPanel5.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel5.Location = New Point(3, 123)
        FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        FlowLayoutPanel5.Padding = New Padding(2)
        FlowLayoutPanel5.Size = New Size(361, 57)
        FlowLayoutPanel5.TabIndex = 15
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 0, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel3, 1, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel2, 0, 1)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel4, 1, 1)
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45.0549469F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 54.9450569F))
        TableLayoutPanel1.Size = New Size(361, 114)
        TableLayoutPanel1.TabIndex = 16
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.AliceBlue
        TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(Label3, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel2.Controls.Add(KembaliButton, 0, 3)
        TableLayoutPanel2.Controls.Add(RegistrasiButton, 0, 2)
        TableLayoutPanel2.Dock = DockStyle.Left
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(20)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.Padding = New Padding(15)
        TableLayoutPanel2.RowCount = 4
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20.2933979F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 48.65526F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.312959F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 24.694376F))
        TableLayoutPanel2.Size = New Size(409, 442)
        TableLayoutPanel2.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label3.Location = New Point(21, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(367, 33)
        Label3.TabIndex = 18
        Label3.Text = "Registrasi"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(FlowLayoutPanel5, 0, 1)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel1, 0, 0)
        TableLayoutPanel3.Location = New Point(21, 103)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 65.665F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 34.335F))
        TableLayoutPanel3.Size = New Size(367, 183)
        TableLayoutPanel3.TabIndex = 18
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.BackColor = Color.CadetBlue
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Location = New Point(295, 283)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(354, 186)
        TableLayoutPanel5.TabIndex = 18
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.BackColor = Color.LightBlue
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Location = New Point(204, -3)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 2
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Size = New Size(445, 100)
        TableLayoutPanel6.TabIndex = 19
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = Color.PowderBlue
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Location = New Point(469, -3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(354, 186)
        TableLayoutPanel4.TabIndex = 20
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.BackColor = Color.SkyBlue
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Location = New Point(346, 122)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Size = New Size(445, 100)
        TableLayoutPanel7.TabIndex = 21
        ' 
        ' FormRegistrasi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(790, 442)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel5)
        Controls.Add(TableLayoutPanel6)
        Controls.Add(TableLayoutPanel4)
        Controls.Add(TableLayoutPanel7)
        MaximizeBox = False
        Name = "FormRegistrasi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Registrasi"
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        FlowLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel4.PerformLayout()
        FlowLayoutPanel5.ResumeLayout(False)
        FlowLayoutPanel5.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    ' --- DEKLARASI FRIEND WITHEVENTS HARUS LENGKAP ---
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
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel

End Class