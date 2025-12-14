<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HasilMahasiswa
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim chartArea1 As New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim series1 As New System.Windows.Forms.DataVisualization.Charting.Series()

        Me.ChartHasil = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartHasil.BeginInit()

        chartArea1.Name = "ChartArea1"
        Me.ChartHasil.ChartAreas.Add(chartArea1)
        series1.ChartArea = "ChartArea1"
        series1.Name = "Persentase"
        series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
        Me.ChartHasil.Series.Add(series1)

        Me.ChartHasil.Location = New System.Drawing.Point(6, 20)
        Me.ChartHasil.Name = "ChartHasil"
        Me.ChartHasil.Size = New System.Drawing.Size(713, 220)
        Me.ChartHasil.TabIndex = 0
        Me.ChartHasil.Text = "ChartHasil"
        Me.ChartHasil.EndInit()
        TableLayoutPanel8 = New TableLayoutPanel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        Label3 = New Label()
        ProdiComboBox = New ComboBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Label1 = New Label()
        NamaTextBox = New TextBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label2 = New Label()
        NIMTextBox = New TextBox()
        GroupBox1 = New GroupBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        TestRekomendasiButton = New Button()
        FlowLayoutPanel3.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.BackColor = Color.SkyBlue
        TableLayoutPanel8.ColumnCount = 2
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel8.Location = New Point(349, 366)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 2
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel8.Size = New Size(107, 100)
        TableLayoutPanel8.TabIndex = 24
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.BackColor = Color.PowderBlue
        FlowLayoutPanel3.Controls.Add(Label3)
        FlowLayoutPanel3.Controls.Add(ProdiComboBox)
        FlowLayoutPanel3.Location = New Point(576, 20)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(179, 47)
        FlowLayoutPanel3.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 9.75F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 15)
        Label3.TabIndex = 0
        Label3.Text = "Prodi"
        ' 
        ' ProdiComboBox
        ' 
        ProdiComboBox.Font = New Font("Calibri", 9.75F)
        ProdiComboBox.Location = New Point(3, 18)
        ProdiComboBox.Name = "ProdiComboBox"
        ProdiComboBox.Size = New Size(169, 23)
        ProdiComboBox.TabIndex = 1
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(Label1)
        FlowLayoutPanel2.Controls.Add(NamaTextBox)
        FlowLayoutPanel2.Location = New Point(27, 20)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(200, 47)
        FlowLayoutPanel2.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 9.75F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' NamaTextBox
        ' 
        NamaTextBox.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NamaTextBox.Location = New Point(3, 18)
        NamaTextBox.Name = "NamaTextBox"
        NamaTextBox.Size = New Size(180, 23)
        NamaTextBox.TabIndex = 1
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Label2)
        FlowLayoutPanel1.Controls.Add(NIMTextBox)
        FlowLayoutPanel1.Location = New Point(383, 20)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(178, 47)
        FlowLayoutPanel1.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.75F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 15)
        Label2.TabIndex = 0
        Label2.Text = "NIM"
        ' 
        ' NIMTextBox
        ' 
        NIMTextBox.Font = New Font("Calibri", 9.75F)
        NIMTextBox.Location = New Point(3, 18)
        NIMTextBox.Name = "NIMTextBox"
        NIMTextBox.Size = New Size(169, 23)
        NIMTextBox.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(Me.ChartHasil)
        GroupBox1.Font = New Font("Calibri", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(27, 96)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(725, 230)
        GroupBox1.TabIndex = 18
        GroupBox1.TabStop = False
        GroupBox1.Text = "Hasil Rekomendasi"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.DeepSkyBlue
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Location = New Point(-10, 241)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Size = New Size(354, 119)
        TableLayoutPanel3.TabIndex = 21
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.PowderBlue
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.Location = New Point(254, 412)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.Size = New Size(556, 117)
        TableLayoutPanel2.TabIndex = 22
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.BackColor = Color.CadetBlue
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.Location = New Point(604, 289)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.Size = New Size(334, 186)
        TableLayoutPanel5.TabIndex = 23
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.SkyBlue
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Location = New Point(262, -6)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Size = New Size(107, 114)
        TableLayoutPanel1.TabIndex = 25
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.BackColor = Color.LightBlue
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.Location = New Point(-7, 76)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 2
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.Size = New Size(445, 100)
        TableLayoutPanel6.TabIndex = 26
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = Color.PowderBlue
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.Location = New Point(570, -6)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.Size = New Size(354, 186)
        TableLayoutPanel4.TabIndex = 27
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.BackColor = Color.SkyBlue
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel7.Location = New Point(226, 114)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel7.Size = New Size(445, 100)
        TableLayoutPanel7.TabIndex = 28
        ' 
        ' TestRekomendasiButton
        ' 
        TestRekomendasiButton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        TestRekomendasiButton.Cursor = Cursors.PanEast
        TestRekomendasiButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        TestRekomendasiButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        TestRekomendasiButton.FlatAppearance.MouseOverBackColor = Color.Green
        TestRekomendasiButton.FlatStyle = FlatStyle.Flat
        TestRekomendasiButton.Font = New Font("Calibri", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TestRekomendasiButton.Location = New Point(27, 365)
        TestRekomendasiButton.Name = "TestRekomendasiButton"
        TestRekomendasiButton.Size = New Size(117, 45)
        TestRekomendasiButton.TabIndex = 29
        TestRekomendasiButton.Text = "Kembali ke Dashboard"
        TestRekomendasiButton.UseVisualStyleBackColor = False
        ' 
        ' HasilMahasiswa
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(800, 436)
        Controls.Add(TestRekomendasiButton)
        Controls.Add(TableLayoutPanel8)
        Controls.Add(FlowLayoutPanel3)
        Controls.Add(FlowLayoutPanel2)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(GroupBox1)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel5)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(TableLayoutPanel6)
        Controls.Add(TableLayoutPanel4)
        Controls.Add(TableLayoutPanel7)
        Name = "HasilMahasiswa"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form8"
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ChartHasil As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents ProdiComboBox As ComboBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents NamaTextBox As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents NIMTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TestRekomendasiButton As Button
End Class
