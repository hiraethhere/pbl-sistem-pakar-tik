<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        NIMTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        LoginButton = New Button()
        lblTitle = New Label()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        KembaliButton = New Button()
        TableLayoutPanel8 = New TableLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' NIMTextBox
        ' 
        NIMTextBox.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        NIMTextBox.Font = New Font("Calibri", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NIMTextBox.Location = New Point(3, 17)
        NIMTextBox.Name = "NIMTextBox"
        NIMTextBox.Size = New Size(358, 22)
        NIMTextBox.TabIndex = 0
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Font = New Font("Calibri", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordTextBox.Location = New Point(3, 17)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(358, 22)
        PasswordTextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(29, 14)
        Label1.TabIndex = 1
        Label1.Text = "NIM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 14)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' LoginButton
        ' 
        LoginButton.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        LoginButton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        LoginButton.Cursor = Cursors.Hand
        LoginButton.FlatAppearance.BorderColor = Color.Black
        LoginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        LoginButton.FlatAppearance.MouseOverBackColor = Color.Green
        LoginButton.FlatStyle = FlatStyle.Flat
        LoginButton.Font = New Font("Calibri", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginButton.ForeColor = SystemColors.ControlText
        LoginButton.Location = New Point(21, 223)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(367, 26)
        LoginButton.TabIndex = 2
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Calibri", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.Black
        lblTitle.Location = New Point(21, 41)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(367, 33)
        lblTitle.TabIndex = 5
        lblTitle.Text = "Login"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel2.BackColor = Color.AliceBlue
        FlowLayoutPanel2.Controls.Add(Label1)
        FlowLayoutPanel2.Controls.Add(NIMTextBox)
        FlowLayoutPanel2.Location = New Point(3, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(361, 44)
        FlowLayoutPanel2.TabIndex = 6
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel3.BackColor = Color.AliceBlue
        FlowLayoutPanel3.Controls.Add(Label2)
        FlowLayoutPanel3.Controls.Add(PasswordTextBox)
        FlowLayoutPanel3.Location = New Point(3, 53)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(361, 44)
        FlowLayoutPanel3.TabIndex = 7
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.AliceBlue
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Controls.Add(KembaliButton, 0, 3)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel8, 0, 1)
        TableLayoutPanel1.Controls.Add(lblTitle, 0, 0)
        TableLayoutPanel1.Controls.Add(LoginButton, 0, 2)
        TableLayoutPanel1.Dock = DockStyle.Left
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(20)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(15)
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20.1456318F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 28.15534F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.4077673F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 40.2912636F))
        TableLayoutPanel1.Size = New Size(409, 442)
        TableLayoutPanel1.TabIndex = 9
        ' 
        ' KembaliButton
        ' 
        KembaliButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        KembaliButton.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        KembaliButton.Cursor = Cursors.Hand
        KembaliButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        KembaliButton.FlatStyle = FlatStyle.Flat
        KembaliButton.Font = New Font("Calibri", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KembaliButton.ForeColor = Color.White
        KembaliButton.Location = New Point(21, 395)
        KembaliButton.Name = "KembaliButton"
        KembaliButton.Size = New Size(367, 26)
        KembaliButton.TabIndex = 11
        KembaliButton.Text = "Kembali"
        KembaliButton.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel8.ColumnCount = 1
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel8.Controls.Add(FlowLayoutPanel3, 0, 1)
        TableLayoutPanel8.Controls.Add(FlowLayoutPanel2, 0, 0)
        TableLayoutPanel8.Location = New Point(21, 105)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 2
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel8.Size = New Size(367, 100)
        TableLayoutPanel8.TabIndex = 12
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.BackColor = Color.LightBlue
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.Location = New Point(-7, 196)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 2
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.Size = New Size(364, 137)
        TableLayoutPanel6.TabIndex = 11
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.CadetBlue
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Location = New Point(459, -7)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Size = New Size(562, 100)
        TableLayoutPanel3.TabIndex = 11
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = Color.SkyBlue
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.Location = New Point(400, 336)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.Size = New Size(515, 147)
        TableLayoutPanel4.TabIndex = 11
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.BackColor = Color.SkyBlue
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.Location = New Point(-4, -4)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.Size = New Size(165, 147)
        TableLayoutPanel5.TabIndex = 11
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.BackColor = Color.PowderBlue
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel7.Location = New Point(615, 68)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel7.Size = New Size(207, 138)
        TableLayoutPanel7.TabIndex = 11
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(790, 442)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(TableLayoutPanel4)
        Controls.Add(TableLayoutPanel6)
        Controls.Add(TableLayoutPanel7)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel5)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Login"
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel8.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents NIMTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents KembaliButton As Button
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel

End Class
