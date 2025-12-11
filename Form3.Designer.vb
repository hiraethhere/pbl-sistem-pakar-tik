<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
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
        lblProfil = New Label()
        lblNilaiCF = New Label()
        btnTestLagi = New Button()
        btnKeluarAplikasi = New Button()
        Cocok = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel8 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        TableLayoutPanel9 = New TableLayoutPanel()
        TableLayoutPanel10 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblProfil
        ' 
        lblProfil.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblProfil.AutoSize = True
        lblProfil.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProfil.Location = New Point(6, 48)
        lblProfil.Name = "lblProfil"
        lblProfil.Size = New Size(647, 26)
        lblProfil.TabIndex = 0
        lblProfil.Text = "Profil Lulusan"
        lblProfil.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNilaiCF
        ' 
        lblNilaiCF.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblNilaiCF.AutoSize = True
        lblNilaiCF.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        lblNilaiCF.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNilaiCF.ForeColor = Color.Green
        lblNilaiCF.Location = New Point(6, 93)
        lblNilaiCF.Margin = New Padding(3, 10, 3, 0)
        lblNilaiCF.Name = "lblNilaiCF"
        lblNilaiCF.Padding = New Padding(10)
        lblNilaiCF.Size = New Size(647, 39)
        lblNilaiCF.TabIndex = 0
        lblNilaiCF.Text = "Nilai CF"
        lblNilaiCF.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnTestLagi
        ' 
        btnTestLagi.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnTestLagi.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnTestLagi.Cursor = Cursors.Hand
        btnTestLagi.FlatStyle = FlatStyle.Popup
        btnTestLagi.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTestLagi.Location = New Point(338, 10)
        btnTestLagi.Name = "btnTestLagi"
        btnTestLagi.Padding = New Padding(5)
        btnTestLagi.Size = New Size(326, 35)
        btnTestLagi.TabIndex = 1
        btnTestLagi.Text = "Coba lagi"
        btnTestLagi.UseVisualStyleBackColor = False
        ' 
        ' btnKeluarAplikasi
        ' 
        btnKeluarAplikasi.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnKeluarAplikasi.BackColor = Color.DarkSalmon
        btnKeluarAplikasi.Cursor = Cursors.Hand
        btnKeluarAplikasi.FlatStyle = FlatStyle.Popup
        btnKeluarAplikasi.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnKeluarAplikasi.Location = New Point(3, 10)
        btnKeluarAplikasi.Name = "btnKeluarAplikasi"
        btnKeluarAplikasi.Padding = New Padding(5)
        btnKeluarAplikasi.Size = New Size(329, 35)
        btnKeluarAplikasi.TabIndex = 2
        btnKeluarAplikasi.Text = "Keluar"
        btnKeluarAplikasi.UseVisualStyleBackColor = False
        ' 
        ' Cocok
        ' 
        Cocok.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Cocok.AutoSize = True
        Cocok.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Cocok.ForeColor = Color.DarkGreen
        Cocok.Location = New Point(6, 14)
        Cocok.Name = "Cocok"
        Cocok.Size = New Size(647, 14)
        Cocok.TabIndex = 0
        Cocok.Text = "REKOMENDASI UTAMA"
        Cocok.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.AliceBlue
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Cocok, 0, 0)
        TableLayoutPanel1.Controls.Add(lblProfil, 0, 1)
        TableLayoutPanel1.Controls.Add(lblNilaiCF, 0, 2)
        TableLayoutPanel1.Location = New Point(4, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.9779739F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.8590307F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 68.7224655F))
        TableLayoutPanel1.Size = New Size(659, 253)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 0, 0)
        TableLayoutPanel2.Location = New Point(59, 47)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(667, 261)
        TableLayoutPanel2.TabIndex = 4
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.2248878F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.7751122F))
        TableLayoutPanel3.Controls.Add(btnKeluarAplikasi, 0, 0)
        TableLayoutPanel3.Controls.Add(btnTestLagi, 1, 0)
        TableLayoutPanel3.Location = New Point(59, 336)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(667, 56)
        TableLayoutPanel3.TabIndex = 5
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.BackColor = Color.SkyBlue
        TableLayoutPanel8.ColumnCount = 2
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Location = New Point(750, 177)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 2
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 61F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 39F))
        TableLayoutPanel8.Size = New Size(107, 100)
        TableLayoutPanel8.TabIndex = 24
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = Color.PowderBlue
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Location = New Point(-48, 404)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(556, 117)
        TableLayoutPanel4.TabIndex = 21
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.BackColor = Color.DeepSkyBlue
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Location = New Point(-79, 204)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(354, 119)
        TableLayoutPanel5.TabIndex = 22
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.BackColor = Color.CadetBlue
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Location = New Point(731, 253)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 2
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Size = New Size(334, 186)
        TableLayoutPanel6.TabIndex = 23
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.BackColor = Color.SkyBlue
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Location = New Point(226, -41)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Size = New Size(107, 62)
        TableLayoutPanel7.TabIndex = 25
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.BackColor = Color.LightBlue
        TableLayoutPanel9.ColumnCount = 2
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.Location = New Point(-76, 39)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 2
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.Size = New Size(445, 100)
        TableLayoutPanel9.TabIndex = 26
        ' 
        ' TableLayoutPanel10
        ' 
        TableLayoutPanel10.BackColor = Color.PowderBlue
        TableLayoutPanel10.ColumnCount = 2
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.Location = New Point(501, -52)
        TableLayoutPanel10.Name = "TableLayoutPanel10"
        TableLayoutPanel10.RowCount = 2
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.Size = New Size(354, 186)
        TableLayoutPanel10.TabIndex = 27
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(790, 442)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel8)
        Controls.Add(TableLayoutPanel4)
        Controls.Add(TableLayoutPanel5)
        Controls.Add(TableLayoutPanel6)
        Controls.Add(TableLayoutPanel7)
        Controls.Add(TableLayoutPanel9)
        Controls.Add(TableLayoutPanel10)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "FormHasil"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hasil"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblProfil As Label
    Friend WithEvents lblNilaiCF As Label
    Friend WithEvents btnTestLagi As Button
    Friend WithEvents btnKeluarAplikasi As Button
    Friend WithEvents Cocok As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
End Class
