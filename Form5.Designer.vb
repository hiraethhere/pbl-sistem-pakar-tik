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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        FlowLayoutPanel5 = New FlowLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label3 = New Label()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        FlowLayoutPanel5.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
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
        KembaliButton.Location = New Point(21, 449)
        KembaliButton.Name = "KembaliButton"
        KembaliButton.Size = New Size(367, 29)
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
        RegistrasiButton.Location = New Point(21, 368)
        RegistrasiButton.Name = "RegistrasiButton"
        RegistrasiButton.Size = New Size(367, 29)
        RegistrasiButton.TabIndex = 1
        RegistrasiButton.Text = "Registrasi"
        RegistrasiButton.UseVisualStyleBackColor = False
        ' 
        ' ProdiComboBox
        ' 
        ProdiComboBox.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ProdiComboBox.FormattingEnabled = True
        ProdiComboBox.Location = New Point(3, 20)
        ProdiComboBox.Name = "ProdiComboBox"
        ProdiComboBox.Size = New Size(324, 24)
        ProdiComboBox.TabIndex = 2
        ' 
        ' NamaLabel
        ' 
        NamaLabel.AutoSize = True
        NamaLabel.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NamaLabel.Location = New Point(3, 0)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New Size(42, 17)
        NamaLabel.TabIndex = 3
        NamaLabel.Text = "Nama"
        ' 
        ' NIMLabel
        ' 
        NIMLabel.AutoSize = True
        NIMLabel.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NIMLabel.Location = New Point(3, 0)
        NIMLabel.Name = "NIMLabel"
        NIMLabel.Size = New Size(33, 17)
        NIMLabel.TabIndex = 4
        NIMLabel.Text = "NIM"
        ' 
        ' ProdiLabel
        ' 
        ProdiLabel.AutoSize = True
        ProdiLabel.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ProdiLabel.Location = New Point(3, 0)
        ProdiLabel.Name = "ProdiLabel"
        ProdiLabel.Size = New Size(41, 17)
        ProdiLabel.TabIndex = 5
        ProdiLabel.Text = "Prodi"
        ' 
        ' NamaTextBox
        ' 
        NamaTextBox.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NamaTextBox.Location = New Point(3, 20)
        NamaTextBox.Name = "NamaTextBox"
        NamaTextBox.Size = New Size(324, 22)
        NamaTextBox.TabIndex = 6
        ' 
        ' NIMTextBox
        ' 
        NIMTextBox.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NIMTextBox.Location = New Point(3, 20)
        NIMTextBox.Name = "NIMTextBox"
        NIMTextBox.Size = New Size(324, 22)
        NIMTextBox.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(5, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 17)
        Label1.TabIndex = 8
        Label1.Text = "Password"
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordTextBox.Location = New Point(5, 22)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(324, 22)
        PasswordTextBox.TabIndex = 9
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top
        FlowLayoutPanel1.Controls.Add(NamaLabel)
        FlowLayoutPanel1.Controls.Add(NamaTextBox)
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(6, 69)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(355, 55)
        FlowLayoutPanel1.TabIndex = 12
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Anchor = AnchorStyles.Top
        FlowLayoutPanel2.Controls.Add(ProdiLabel)
        FlowLayoutPanel2.Controls.Add(ProdiComboBox)
        FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel2.Location = New Point(6, 135)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(355, 54)
        FlowLayoutPanel2.TabIndex = 13
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Anchor = AnchorStyles.Top
        FlowLayoutPanel3.Controls.Add(NIMLabel)
        FlowLayoutPanel3.Controls.Add(NIMTextBox)
        FlowLayoutPanel3.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel3.Location = New Point(6, 3)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(355, 54)
        FlowLayoutPanel3.TabIndex = 13
        ' 
        ' FlowLayoutPanel5
        ' 
        FlowLayoutPanel5.Anchor = AnchorStyles.Top
        FlowLayoutPanel5.Controls.Add(Label1)
        FlowLayoutPanel5.Controls.Add(PasswordTextBox)
        FlowLayoutPanel5.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel5.Location = New Point(3, 201)
        FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        FlowLayoutPanel5.Padding = New Padding(2)
        FlowLayoutPanel5.Size = New Size(361, 62)
        FlowLayoutPanel5.TabIndex = 15
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel5, 0, 3)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel2, 0, 2)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 0, 1)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel3, 0, 0)
        TableLayoutPanel1.Location = New Point(21, 91)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Size = New Size(367, 266)
        TableLayoutPanel1.TabIndex = 16
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.AliceBlue
        TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 0, 1)
        TableLayoutPanel2.Controls.Add(Label3, 0, 0)
        TableLayoutPanel2.Controls.Add(KembaliButton, 0, 3)
        TableLayoutPanel2.Controls.Add(RegistrasiButton, 0, 2)
        TableLayoutPanel2.Dock = DockStyle.Left
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(20, 23, 20, 23)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.Padding = New Padding(15, 17, 15, 17)
        TableLayoutPanel2.RowCount = 4
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 13.9269409F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 60.8200455F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 9.794989F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.8063784F))
        TableLayoutPanel2.Size = New Size(409, 501)
        TableLayoutPanel2.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label3.Location = New Point(21, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(367, 37)
        Label3.TabIndex = 18
        Label3.Text = "Registrasi"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.BackColor = Color.CadetBlue
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Location = New Point(295, 321)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(354, 211)
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
        TableLayoutPanel6.Size = New Size(445, 113)
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
        TableLayoutPanel4.Size = New Size(354, 211)
        TableLayoutPanel4.TabIndex = 20
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.BackColor = Color.SkyBlue
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Location = New Point(346, 138)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Size = New Size(445, 113)
        TableLayoutPanel7.TabIndex = 21
        ' 
        ' FormRegistrasi
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(790, 501)
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
        FlowLayoutPanel5.ResumeLayout(False)
        FlowLayoutPanel5.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
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
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel

End Class