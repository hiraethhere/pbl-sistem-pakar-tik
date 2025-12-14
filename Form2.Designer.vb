<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPertanyaanCF
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
        components = New ComponentModel.Container()
        lblNoSoal = New Label()
        lblPertanyaan = New Label()
        rbA = New RadioButton()
        rbB = New RadioButton()
        rbC = New RadioButton()
        rbD = New RadioButton()
        rbE = New RadioButton()
        btnLanjut = New Button()
        lblNamaMhs = New Label()
        TimerUjian = New Timer(components)
        lblWaktu = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        TableLayoutPanel8 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        TableLayoutPanel9 = New TableLayoutPanel()
        TableLayoutPanel10 = New TableLayoutPanel()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNoSoal
        ' 
        lblNoSoal.Anchor = AnchorStyles.Left
        lblNoSoal.AutoSize = True
        lblNoSoal.BackColor = SystemColors.Highlight
        lblNoSoal.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNoSoal.ForeColor = Color.AliceBlue
        lblNoSoal.Location = New Point(21, 25)
        lblNoSoal.Margin = New Padding(8, 0, 3, 0)
        lblNoSoal.Name = "lblNoSoal"
        lblNoSoal.Padding = New Padding(5)
        lblNoSoal.Size = New Size(130, 26)
        lblNoSoal.TabIndex = 0
        lblNoSoal.Text = "Nomor Pertanyaan"
        ' 
        ' lblPertanyaan
        ' 
        lblPertanyaan.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblPertanyaan.AutoSize = True
        lblPertanyaan.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPertanyaan.ForeColor = Color.Black
        lblPertanyaan.Location = New Point(16, 67)
        lblPertanyaan.Name = "lblPertanyaan"
        lblPertanyaan.Padding = New Padding(5)
        lblPertanyaan.Size = New Size(677, 31)
        lblPertanyaan.TabIndex = 0
        lblPertanyaan.Text = "Pertanyaan"
        ' 
        ' rbA
        ' 
        rbA.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        rbA.AutoSize = True
        rbA.BackColor = SystemColors.ControlLight
        rbA.CheckAlign = ContentAlignment.TopCenter
        rbA.Cursor = Cursors.Hand
        rbA.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        rbA.FlatAppearance.MouseDownBackColor = Color.Red
        rbA.FlatAppearance.MouseOverBackColor = Color.Red
        rbA.FlatStyle = FlatStyle.Flat
        rbA.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbA.ForeColor = SystemColors.ControlDarkDark
        rbA.Location = New Point(6, 7)
        rbA.Margin = New Padding(3, 4, 3, 4)
        rbA.Name = "rbA"
        rbA.Padding = New Padding(10)
        rbA.Size = New Size(123, 54)
        rbA.TabIndex = 1
        rbA.Text = "Sangat Kurang"
        rbA.TextAlign = ContentAlignment.MiddleCenter
        rbA.UseVisualStyleBackColor = False
        ' 
        ' rbB
        ' 
        rbB.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        rbB.AutoSize = True
        rbB.BackColor = SystemColors.GradientInactiveCaption
        rbB.CheckAlign = ContentAlignment.TopCenter
        rbB.Cursor = Cursors.Hand
        rbB.FlatAppearance.CheckedBackColor = Color.Cyan
        rbB.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        rbB.FlatAppearance.MouseOverBackColor = Color.Teal
        rbB.FlatStyle = FlatStyle.Flat
        rbB.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbB.ForeColor = SystemColors.ControlDarkDark
        rbB.Location = New Point(138, 7)
        rbB.Margin = New Padding(3, 4, 3, 4)
        rbB.Name = "rbB"
        rbB.Padding = New Padding(10)
        rbB.Size = New Size(123, 54)
        rbB.TabIndex = 1
        rbB.Text = "Kurang"
        rbB.TextAlign = ContentAlignment.MiddleCenter
        rbB.UseVisualStyleBackColor = False
        ' 
        ' rbC
        ' 
        rbC.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        rbC.AutoSize = True
        rbC.BackColor = SystemColors.InactiveCaption
        rbC.CheckAlign = ContentAlignment.TopCenter
        rbC.Cursor = Cursors.Hand
        rbC.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        rbC.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        rbC.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        rbC.FlatStyle = FlatStyle.Flat
        rbC.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbC.ForeColor = SystemColors.ControlDarkDark
        rbC.Location = New Point(270, 7)
        rbC.Margin = New Padding(3, 4, 3, 4)
        rbC.Name = "rbC"
        rbC.Padding = New Padding(10)
        rbC.Size = New Size(123, 54)
        rbC.TabIndex = 1
        rbC.Text = "Cukup"
        rbC.TextAlign = ContentAlignment.MiddleCenter
        rbC.UseVisualStyleBackColor = False
        ' 
        ' rbD
        ' 
        rbD.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        rbD.AutoSize = True
        rbD.BackColor = SystemColors.GradientActiveCaption
        rbD.CheckAlign = ContentAlignment.TopCenter
        rbD.Cursor = Cursors.Hand
        rbD.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        rbD.FlatAppearance.MouseDownBackColor = Color.Blue
        rbD.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        rbD.FlatStyle = FlatStyle.Flat
        rbD.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbD.ForeColor = SystemColors.ControlDarkDark
        rbD.Location = New Point(402, 7)
        rbD.Margin = New Padding(3, 4, 3, 4)
        rbD.Name = "rbD"
        rbD.Padding = New Padding(10)
        rbD.Size = New Size(123, 54)
        rbD.TabIndex = 1
        rbD.Text = "Baik"
        rbD.TextAlign = ContentAlignment.MiddleCenter
        rbD.UseVisualStyleBackColor = False
        ' 
        ' rbE
        ' 
        rbE.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        rbE.AutoSize = True
        rbE.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        rbE.CheckAlign = ContentAlignment.TopCenter
        rbE.Cursor = Cursors.Hand
        rbE.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        rbE.FlatAppearance.MouseDownBackColor = Color.Lime
        rbE.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        rbE.FlatStyle = FlatStyle.Flat
        rbE.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbE.ForeColor = SystemColors.ControlDarkDark
        rbE.Location = New Point(534, 7)
        rbE.Margin = New Padding(3, 4, 3, 4)
        rbE.Name = "rbE"
        rbE.Padding = New Padding(10)
        rbE.Size = New Size(123, 54)
        rbE.TabIndex = 1
        rbE.Text = "Sangat Baik"
        rbE.TextAlign = ContentAlignment.MiddleCenter
        rbE.UseVisualStyleBackColor = False
        ' 
        ' btnLanjut
        ' 
        btnLanjut.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnLanjut.Cursor = Cursors.Hand
        btnLanjut.FlatStyle = FlatStyle.Popup
        btnLanjut.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLanjut.ForeColor = Color.Black
        btnLanjut.Location = New Point(607, 419)
        btnLanjut.Margin = New Padding(3, 4, 3, 4)
        btnLanjut.Name = "btnLanjut"
        btnLanjut.Size = New Size(155, 34)
        btnLanjut.TabIndex = 3
        btnLanjut.Text = "Lanjut"
        btnLanjut.UseVisualStyleBackColor = False
        ' 
        ' lblNamaMhs
        ' 
        lblNamaMhs.Anchor = AnchorStyles.Left
        lblNamaMhs.AutoSize = True
        lblNamaMhs.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNamaMhs.Location = New Point(6, 9)
        lblNamaMhs.Name = "lblNamaMhs"
        lblNamaMhs.Size = New Size(86, 17)
        lblNamaMhs.TabIndex = 4
        lblNamaMhs.Text = "Nama: Reza"
        ' 
        ' TimerUjian
        ' 
        TimerUjian.Enabled = True
        TimerUjian.Interval = 1000
        ' 
        ' lblWaktu
        ' 
        lblWaktu.Anchor = AnchorStyles.Right
        lblWaktu.AutoSize = True
        lblWaktu.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWaktu.Location = New Point(628, 9)
        lblWaktu.Name = "lblWaktu"
        lblWaktu.Size = New Size(88, 17)
        lblWaktu.TabIndex = 5
        lblWaktu.Text = "Timer: 30:00"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.BackColor = Color.AliceBlue
        TableLayoutPanel2.BackgroundImageLayout = ImageLayout.None
        TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial
        TableLayoutPanel2.ColumnCount = 5
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.Controls.Add(rbE, 4, 0)
        TableLayoutPanel2.Controls.Add(rbD, 3, 0)
        TableLayoutPanel2.Controls.Add(rbC, 2, 0)
        TableLayoutPanel2.Controls.Add(rbB, 1, 0)
        TableLayoutPanel2.Controls.Add(rbA, 0, 0)
        TableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.AddColumns
        TableLayoutPanel2.Location = New Point(23, 179)
        TableLayoutPanel2.Margin = New Padding(10)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(663, 68)
        TableLayoutPanel2.TabIndex = 7
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(lblNamaMhs, 0, 0)
        TableLayoutPanel1.Controls.Add(lblWaktu, 1, 0)
        TableLayoutPanel1.ForeColor = Color.White
        TableLayoutPanel1.Location = New Point(40, 22)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(722, 36)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.BackColor = Color.AliceBlue
        TableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(lblNoSoal, 0, 0)
        TableLayoutPanel3.Controls.Add(lblPertanyaan, 0, 1)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel2, 0, 2)
        TableLayoutPanel3.Location = New Point(5, 5)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.Padding = New Padding(10)
        TableLayoutPanel3.RowCount = 3
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20.434782F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 35.217392F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 44.3478279F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(709, 282)
        TableLayoutPanel3.TabIndex = 9
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        FlowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanel1.Controls.Add(TableLayoutPanel3)
        FlowLayoutPanel1.Location = New Point(40, 90)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(2)
        FlowLayoutPanel1.Size = New Size(722, 297)
        FlowLayoutPanel1.TabIndex = 10
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.BackColor = Color.SkyBlue
        TableLayoutPanel8.ColumnCount = 2
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Location = New Point(56, 327)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 2
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 61F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 39F))
        TableLayoutPanel8.Size = New Size(107, 100)
        TableLayoutPanel8.TabIndex = 17
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = Color.PowderBlue
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Location = New Point(-48, 384)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(556, 117)
        TableLayoutPanel4.TabIndex = 14
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.BackColor = Color.DeepSkyBlue
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Location = New Point(-79, 201)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(354, 119)
        TableLayoutPanel5.TabIndex = 15
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.BackColor = Color.CadetBlue
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Location = New Point(535, 249)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 2
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Size = New Size(334, 186)
        TableLayoutPanel6.TabIndex = 16
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.BackColor = Color.SkyBlue
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Location = New Point(193, -46)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Size = New Size(107, 62)
        TableLayoutPanel7.TabIndex = 18
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.BackColor = Color.LightBlue
        TableLayoutPanel9.ColumnCount = 2
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.Location = New Point(-76, 36)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 2
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.Size = New Size(445, 100)
        TableLayoutPanel9.TabIndex = 19
        ' 
        ' TableLayoutPanel10
        ' 
        TableLayoutPanel10.BackColor = Color.PowderBlue
        TableLayoutPanel10.ColumnCount = 2
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.Location = New Point(501, -46)
        TableLayoutPanel10.Name = "TableLayoutPanel10"
        TableLayoutPanel10.RowCount = 2
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.Size = New Size(354, 186)
        TableLayoutPanel10.TabIndex = 20
        ' 
        ' FormPertanyaanCF
        ' 
        AutoScaleDimensions = New SizeF(9F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(790, 477)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(btnLanjut)
        Controls.Add(TableLayoutPanel8)
        Controls.Add(TableLayoutPanel4)
        Controls.Add(TableLayoutPanel5)
        Controls.Add(TableLayoutPanel6)
        Controls.Add(TableLayoutPanel7)
        Controls.Add(TableLayoutPanel9)
        Controls.Add(TableLayoutPanel10)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "FormPertanyaanCF"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pertanyaan"
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblNoSoal As Label
    Friend WithEvents lblPertanyaan As Label
    Friend WithEvents rbA As RadioButton
    Friend WithEvents rbB As RadioButton
    Friend WithEvents rbC As RadioButton
    Friend WithEvents rbD As RadioButton
    Friend WithEvents rbE As RadioButton
    Friend WithEvents btnLanjut As Button
    Friend WithEvents lblNamaMhs As Label
    Friend WithEvents TimerUjian As Timer
    Friend WithEvents lblWaktu As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
End Class
