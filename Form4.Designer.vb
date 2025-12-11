<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
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
        Label1 = New Label()
        btnKeluar = New Button()
        Label2 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        aaa = New Label()
        RegistrasiButton = New Button()
        LoginButton = New Button()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label1.Location = New Point(3, 1)
        Label1.Name = "Label1"
        Label1.Size = New Size(371, 33)
        Label1.TabIndex = 0
        Label1.Text = "Sistem Pakar Profil Lulusan TIK"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnKeluar.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnKeluar.Cursor = Cursors.Hand
        btnKeluar.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Calibri", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnKeluar.ForeColor = SystemColors.ButtonHighlight
        btnKeluar.Location = New Point(16, 394)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(377, 32)
        btnKeluar.TabIndex = 1
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(3, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(371, 14)
        Label2.TabIndex = 0
        Label2.Text = "Tentukan Jalur Karir Terbaik Anda dengan Sistem Pakar"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 1)
        TableLayoutPanel1.Location = New Point(16, 52)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 54.5454559F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45.4545441F))
        TableLayoutPanel1.Size = New Size(377, 66)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.AliceBlue
        TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 0, 0)
        TableLayoutPanel2.Controls.Add(btnKeluar, 0, 2)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Left
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(10)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.Padding = New Padding(10)
        TableLayoutPanel2.RightToLeft = RightToLeft.No
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 35.147007F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 55.76208F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
        TableLayoutPanel2.Size = New Size(409, 442)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel3.Controls.Add(aaa, 0, 1)
        TableLayoutPanel3.Controls.Add(RegistrasiButton, 0, 2)
        TableLayoutPanel3.Controls.Add(LoginButton, 0, 0)
        TableLayoutPanel3.Location = New Point(16, 163)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 3
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 40.00001F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 19.9999924F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 39.9999924F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel3.Size = New Size(377, 78)
        TableLayoutPanel3.TabIndex = 3
        ' 
        ' aaa
        ' 
        aaa.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        aaa.AutoSize = True
        aaa.Location = New Point(3, 31)
        aaa.Name = "aaa"
        aaa.RightToLeft = RightToLeft.No
        aaa.Size = New Size(371, 15)
        aaa.TabIndex = 4
        aaa.Text = "--------------------------------------------------------------------------------------------------------"
        aaa.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RegistrasiButton
        ' 
        RegistrasiButton.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        RegistrasiButton.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        RegistrasiButton.Cursor = Cursors.Hand
        RegistrasiButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        RegistrasiButton.FlatStyle = FlatStyle.Flat
        RegistrasiButton.Font = New Font("Calibri", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RegistrasiButton.Location = New Point(0, 47)
        RegistrasiButton.Margin = New Padding(0)
        RegistrasiButton.Name = "RegistrasiButton"
        RegistrasiButton.Size = New Size(377, 29)
        RegistrasiButton.TabIndex = 4
        RegistrasiButton.Text = "Registrasi"
        RegistrasiButton.UseVisualStyleBackColor = False
        ' 
        ' LoginButton
        ' 
        LoginButton.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        LoginButton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        LoginButton.Cursor = Cursors.Hand
        LoginButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        LoginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        LoginButton.FlatAppearance.MouseOverBackColor = Color.Green
        LoginButton.FlatStyle = FlatStyle.Flat
        LoginButton.Font = New Font("Calibri", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginButton.Location = New Point(0, 2)
        LoginButton.Margin = New Padding(0)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(377, 27)
        LoginButton.TabIndex = 1
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = Color.PowderBlue
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.Location = New Point(621, 0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.Size = New Size(354, 186)
        TableLayoutPanel4.TabIndex = 4
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.BackColor = Color.CadetBlue
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.Location = New Point(447, 286)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.Size = New Size(354, 186)
        TableLayoutPanel5.TabIndex = 4
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.BackColor = Color.LightBlue
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.Location = New Point(356, 0)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 2
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.Size = New Size(445, 100)
        TableLayoutPanel6.TabIndex = 4
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.BackColor = Color.SkyBlue
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel7.Location = New Point(498, 125)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel7.Size = New Size(445, 100)
        TableLayoutPanel7.TabIndex = 4
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(790, 442)
        Controls.Add(TableLayoutPanel5)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel6)
        Controls.Add(TableLayoutPanel4)
        Controls.Add(TableLayoutPanel7)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RegistrasiButton As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LoginButton As Button
    Friend WithEvents aaa As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
End Class