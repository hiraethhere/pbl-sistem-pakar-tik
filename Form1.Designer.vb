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
        TableLayoutPanel2 = New TableLayoutPanel()
        KembaliButton = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' NIMTextBox
        ' 
        NIMTextBox.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        NIMTextBox.Location = New Point(3, 20)
        NIMTextBox.Name = "NIMTextBox"
        NIMTextBox.Size = New Size(340, 25)
        NIMTextBox.TabIndex = 0
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(3, 20)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(340, 25)
        PasswordTextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 17)
        Label1.TabIndex = 1
        Label1.Text = "NIM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 17)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' LoginButton
        ' 
        LoginButton.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        LoginButton.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        LoginButton.Cursor = Cursors.Hand
        LoginButton.FlatStyle = FlatStyle.Popup
        LoginButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LoginButton.ForeColor = SystemColors.ControlText
        LoginButton.Location = New Point(174, 3)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(166, 31)
        LoginButton.TabIndex = 2
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(205, 24)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(70, 25)
        lblTitle.TabIndex = 5
        lblTitle.Text = "Login"
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel2.BackColor = SystemColors.Control
        FlowLayoutPanel2.Controls.Add(Label1)
        FlowLayoutPanel2.Controls.Add(NIMTextBox)
        FlowLayoutPanel2.Location = New Point(3, 4)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(349, 60)
        FlowLayoutPanel2.TabIndex = 6
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.BackColor = SystemColors.Control
        FlowLayoutPanel3.Controls.Add(Label2)
        FlowLayoutPanel3.Controls.Add(PasswordTextBox)
        FlowLayoutPanel3.Location = New Point(3, 72)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(347, 60)
        FlowLayoutPanel3.TabIndex = 7
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = SystemColors.Control
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel2, 0, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel3, 0, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 2)
        TableLayoutPanel1.Location = New Point(73, 88)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 38.46154F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 38.4615364F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23.0769253F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(355, 181)
        TableLayoutPanel1.TabIndex = 9
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(KembaliButton, 0, 0)
        TableLayoutPanel2.Controls.Add(LoginButton, 1, 0)
        TableLayoutPanel2.Location = New Point(3, 141)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(343, 37)
        TableLayoutPanel2.TabIndex = 8
        ' 
        ' KembaliButton
        ' 
        KembaliButton.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        KembaliButton.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        KembaliButton.Cursor = Cursors.Hand
        KembaliButton.FlatStyle = FlatStyle.Popup
        KembaliButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KembaliButton.ForeColor = SystemColors.ControlText
        KembaliButton.Location = New Point(3, 3)
        KembaliButton.Name = "KembaliButton"
        KembaliButton.Size = New Size(165, 31)
        KembaliButton.TabIndex = 11
        KembaliButton.Text = "Kembali"
        KembaliButton.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.Control
        FlowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanel1.Location = New Point(63, 75)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(374, 210)
        FlowLayoutPanel1.TabIndex = 10
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(514, 328)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(lblTitle)
        Controls.Add(FlowLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Login"
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents KembaliButton As Button

End Class
