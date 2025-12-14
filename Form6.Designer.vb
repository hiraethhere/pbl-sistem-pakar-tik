Imports System.Windows.Forms.DataVisualization.Charting

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardMahasiswa
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel8 = New TableLayoutPanel()
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 9.75F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 18)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' NamaTextBox
        ' 
        NamaTextBox.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NamaTextBox.Location = New Point(3, 21)
        NamaTextBox.Name = "NamaTextBox"
        NamaTextBox.Size = New Size(180, 25)
        NamaTextBox.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.75F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 18)
        Label2.TabIndex = 0
        Label2.Text = "NIM"
        ' 
        ' NIMTextBox
        ' 
        NIMTextBox.Font = New Font("Calibri", 9.75F)
        NIMTextBox.Location = New Point(3, 21)
        NIMTextBox.Name = "NIMTextBox"
        NIMTextBox.Size = New Size(169, 25)
        NIMTextBox.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 9.75F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 18)
        Label3.TabIndex = 0
        Label3.Text = "Prodi"
        ' 
        ' ProdiComboBox
        ' 
        ProdiComboBox.Font = New Font("Calibri", 9.75F)
        ProdiComboBox.Location = New Point(3, 21)
        ProdiComboBox.Name = "ProdiComboBox"
        ProdiComboBox.Size = New Size(169, 25)
        ProdiComboBox.TabIndex = 1
        ' 
        ' LogOutButton
        ' 
        LogOutButton.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        LogOutButton.Cursor = Cursors.Hand
        LogOutButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        LogOutButton.FlatStyle = FlatStyle.Flat
        LogOutButton.Font = New Font("Calibri", 9F)
        LogOutButton.ForeColor = SystemColors.ButtonHighlight
        LogOutButton.Location = New Point(29, 414)
        LogOutButton.Name = "LogOutButton"
        LogOutButton.Size = New Size(117, 51)
        LogOutButton.TabIndex = 10
        LogOutButton.Text = "Logout"
        LogOutButton.UseVisualStyleBackColor = False
        ' 
        ' TestRekomendasiButton
        ' 
        TestRekomendasiButton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        TestRekomendasiButton.Cursor = Cursors.PanEast
        TestRekomendasiButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        TestRekomendasiButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        TestRekomendasiButton.FlatAppearance.MouseOverBackColor = Color.Green
        TestRekomendasiButton.FlatStyle = FlatStyle.Flat
        TestRekomendasiButton.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TestRekomendasiButton.Location = New Point(640, 414)
        TestRekomendasiButton.Name = "TestRekomendasiButton"
        TestRekomendasiButton.Size = New Size(117, 51)
        TestRekomendasiButton.TabIndex = 9
        TestRekomendasiButton.Text = "Test Rekomendasi"
        TestRekomendasiButton.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(29, 110)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(725, 261)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Hasil Rekomendasi"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Label2)
        FlowLayoutPanel1.Controls.Add(NIMTextBox)
        FlowLayoutPanel1.Location = New Point(385, 24)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(178, 53)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(Label1)
        FlowLayoutPanel2.Controls.Add(NamaTextBox)
        FlowLayoutPanel2.Location = New Point(29, 24)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(200, 53)
        FlowLayoutPanel2.TabIndex = 1
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.BackColor = Color.PowderBlue
        FlowLayoutPanel3.Controls.Add(Label3)
        FlowLayoutPanel3.Controls.Add(ProdiComboBox)
        FlowLayoutPanel3.Location = New Point(578, 24)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(179, 53)
        FlowLayoutPanel3.TabIndex = 0
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.BackColor = Color.CadetBlue
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Location = New Point(606, 329)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(334, 211)
        TableLayoutPanel5.TabIndex = 11
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.BackColor = Color.LightBlue
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Location = New Point(-5, 87)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 2
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Size = New Size(445, 113)
        TableLayoutPanel6.TabIndex = 12
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = Color.PowderBlue
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Location = New Point(572, -6)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(354, 211)
        TableLayoutPanel4.TabIndex = 13
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.BackColor = Color.SkyBlue
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Location = New Point(228, 130)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Size = New Size(445, 113)
        TableLayoutPanel7.TabIndex = 14
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.SkyBlue
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Location = New Point(264, -6)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(107, 129)
        TableLayoutPanel1.TabIndex = 12
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.PowderBlue
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Location = New Point(256, 468)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(556, 133)
        TableLayoutPanel2.TabIndex = 11
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.DeepSkyBlue
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Location = New Point(-8, 274)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(354, 135)
        TableLayoutPanel3.TabIndex = 11
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.BackColor = Color.SkyBlue
        TableLayoutPanel8.ColumnCount = 2
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Location = New Point(351, 416)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 2
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Size = New Size(107, 113)
        TableLayoutPanel8.TabIndex = 12
        ' 
        ' DashboardMahasiswa
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(790, 501)
        Controls.Add(TableLayoutPanel8)
        Controls.Add(LogOutButton)
        Controls.Add(TestRekomendasiButton)
        Controls.Add(FlowLayoutPanel3)
        Controls.Add(FlowLayoutPanel2)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(GroupBox1)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel5)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(TableLayoutPanel6)
        Controls.Add(TableLayoutPanel4)
        Controls.Add(TableLayoutPanel7)
        MaximizeBox = False
        Name = "DashboardMahasiswa"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard Mahasiswa"
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        ResumeLayout(False)

    End Sub

    ' --- Deklarasi Friend WithEvents ---
    Friend WithEvents ChartHasil As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NIMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProdiComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LogOutButton As System.Windows.Forms.Button
    Friend WithEvents TestRekomendasiButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
End Class