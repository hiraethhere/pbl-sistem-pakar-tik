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
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblProfil
        ' 
        lblProfil.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblProfil.AutoSize = True
        lblProfil.Font = New Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProfil.Location = New Point(3, 49)
        lblProfil.Name = "lblProfil"
        lblProfil.Size = New Size(422, 37)
        lblProfil.TabIndex = 0
        lblProfil.Text = "Profil Lulusan"
        lblProfil.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNilaiCF
        ' 
        lblNilaiCF.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblNilaiCF.AutoSize = True
        lblNilaiCF.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        lblNilaiCF.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNilaiCF.ForeColor = Color.Green
        lblNilaiCF.Location = New Point(3, 108)
        lblNilaiCF.Name = "lblNilaiCF"
        lblNilaiCF.Size = New Size(422, 22)
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
        btnTestLagi.Location = New Point(221, 3)
        btnTestLagi.Name = "btnTestLagi"
        btnTestLagi.Padding = New Padding(5)
        btnTestLagi.Size = New Size(212, 35)
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
        btnKeluarAplikasi.Location = New Point(3, 3)
        btnKeluarAplikasi.Name = "btnKeluarAplikasi"
        btnKeluarAplikasi.Padding = New Padding(5)
        btnKeluarAplikasi.Size = New Size(212, 35)
        btnKeluarAplikasi.TabIndex = 2
        btnKeluarAplikasi.Text = "Keluar"
        btnKeluarAplikasi.UseVisualStyleBackColor = False
        ' 
        ' Cocok
        ' 
        Cocok.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Cocok.AutoSize = True
        Cocok.Font = New Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Cocok.ForeColor = Color.DarkGreen
        Cocok.Location = New Point(3, 10)
        Cocok.Name = "Cocok"
        Cocok.Size = New Size(422, 22)
        Cocok.TabIndex = 0
        Cocok.Text = "REKOMENDASI UTAMA"
        Cocok.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Cocok, 0, 0)
        TableLayoutPanel1.Controls.Add(lblProfil, 0, 1)
        TableLayoutPanel1.Controls.Add(lblNilaiCF, 0, 2)
        TableLayoutPanel1.Location = New Point(4, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 29.6874981F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 35.15625F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 35.15625F))
        TableLayoutPanel1.Size = New Size(428, 145)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.WhiteSmoke
        TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 0, 0)
        TableLayoutPanel2.Location = New Point(59, 47)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(436, 153)
        TableLayoutPanel2.TabIndex = 4
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(btnKeluarAplikasi, 0, 0)
        TableLayoutPanel3.Controls.Add(btnTestLagi, 1, 0)
        TableLayoutPanel3.Location = New Point(59, 220)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(436, 41)
        TableLayoutPanel3.TabIndex = 5
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 295)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel2)
        FormBorderStyle = FormBorderStyle.FixedDialog
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
End Class
