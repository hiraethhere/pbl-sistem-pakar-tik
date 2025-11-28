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
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNoSoal
        ' 
        lblNoSoal.AutoSize = True
        lblNoSoal.BackColor = SystemColors.ActiveCaption
        lblNoSoal.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNoSoal.ForeColor = Color.MidnightBlue
        lblNoSoal.Location = New Point(13, 10)
        lblNoSoal.Name = "lblNoSoal"
        lblNoSoal.Padding = New Padding(5)
        lblNoSoal.Size = New Size(121, 29)
        lblNoSoal.TabIndex = 0
        lblNoSoal.Text = "Nomor Pertanyaan"
        ' 
        ' lblPertanyaan
        ' 
        lblPertanyaan.Anchor = AnchorStyles.Left
        lblPertanyaan.AutoSize = True
        lblPertanyaan.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPertanyaan.Location = New Point(13, 45)
        lblPertanyaan.Name = "lblPertanyaan"
        lblPertanyaan.Size = New Size(86, 23)
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
        rbA.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbA.ForeColor = SystemColors.ControlDarkDark
        rbA.Location = New Point(3, 5)
        rbA.Margin = New Padding(3, 4, 3, 4)
        rbA.Name = "rbA"
        rbA.Padding = New Padding(10)
        rbA.Size = New Size(123, 59)
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
        rbB.Font = New Font("Poppins", 9F)
        rbB.ForeColor = SystemColors.ControlDarkDark
        rbB.Location = New Point(132, 5)
        rbB.Margin = New Padding(3, 4, 3, 4)
        rbB.Name = "rbB"
        rbB.Padding = New Padding(10)
        rbB.Size = New Size(123, 59)
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
        rbC.Font = New Font("Poppins", 9F)
        rbC.ForeColor = SystemColors.ControlDarkDark
        rbC.Location = New Point(261, 5)
        rbC.Margin = New Padding(3, 4, 3, 4)
        rbC.Name = "rbC"
        rbC.Padding = New Padding(10)
        rbC.Size = New Size(123, 59)
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
        rbD.Font = New Font("Poppins", 9F)
        rbD.ForeColor = SystemColors.ControlDarkDark
        rbD.Location = New Point(390, 5)
        rbD.Margin = New Padding(3, 4, 3, 4)
        rbD.Name = "rbD"
        rbD.Padding = New Padding(10)
        rbD.Size = New Size(123, 59)
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
        rbE.Font = New Font("Poppins", 9F)
        rbE.ForeColor = SystemColors.ControlDarkDark
        rbE.ImageAlign = ContentAlignment.TopCenter
        rbE.Location = New Point(519, 5)
        rbE.Margin = New Padding(3, 4, 3, 4)
        rbE.Name = "rbE"
        rbE.Padding = New Padding(10)
        rbE.Size = New Size(125, 59)
        rbE.TabIndex = 1
        rbE.Text = "Sangat Baik"
        rbE.TextAlign = ContentAlignment.MiddleCenter
        rbE.UseVisualStyleBackColor = False
        ' 
        ' btnLanjut
        ' 
        btnLanjut.BackColor = Color.Green
        btnLanjut.Cursor = Cursors.Hand
        btnLanjut.FlatStyle = FlatStyle.Popup
        btnLanjut.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLanjut.ForeColor = SystemColors.Control
        btnLanjut.Location = New Point(565, 319)
        btnLanjut.Margin = New Padding(3, 4, 3, 4)
        btnLanjut.Name = "btnLanjut"
        btnLanjut.Size = New Size(197, 40)
        btnLanjut.TabIndex = 3
        btnLanjut.Text = "Lanjut"
        btnLanjut.UseVisualStyleBackColor = False
        ' 
        ' lblNamaMhs
        ' 
        lblNamaMhs.Anchor = AnchorStyles.Left
        lblNamaMhs.AutoSize = True
        lblNamaMhs.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNamaMhs.Location = New Point(3, 7)
        lblNamaMhs.Name = "lblNamaMhs"
        lblNamaMhs.Size = New Size(79, 22)
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
        lblWaktu.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWaktu.Location = New Point(602, 7)
        lblWaktu.Name = "lblWaktu"
        lblWaktu.Size = New Size(82, 22)
        lblWaktu.TabIndex = 5
        lblWaktu.Text = "Timer: 30:00"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.BackColor = SystemColors.Control
        TableLayoutPanel2.BackgroundImageLayout = ImageLayout.None
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
        TableLayoutPanel2.Location = New Point(20, 82)
        TableLayoutPanel2.Margin = New Padding(10)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(647, 69)
        TableLayoutPanel2.TabIndex = 7
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(lblNamaMhs, 0, 0)
        TableLayoutPanel1.Controls.Add(lblWaktu, 1, 0)
        TableLayoutPanel1.Location = New Point(75, 32)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(687, 36)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(lblNoSoal, 0, 0)
        TableLayoutPanel3.Controls.Add(lblPertanyaan, 0, 1)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel2, 0, 2)
        TableLayoutPanel3.Location = New Point(3, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.Padding = New Padding(10)
        TableLayoutPanel3.RowCount = 3
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20.5882339F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20.5882339F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 58.8235321F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(687, 171)
        TableLayoutPanel3.TabIndex = 9
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanel1.Controls.Add(TableLayoutPanel3)
        FlowLayoutPanel1.Location = New Point(75, 110)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(687, 178)
        FlowLayoutPanel1.TabIndex = 10
        ' 
        ' FormPertanyaanCF
        ' 
        AutoScaleDimensions = New SizeF(7F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(834, 386)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(btnLanjut)
        Font = New Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
End Class
