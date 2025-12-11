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
        ' --- KODE INISIALISASI CHART & OBJEK DASAR (DITAMBAH DI AWAL) ---
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
        Me.ChartHasil.Size = New System.Drawing.Size(713, 200)
        Me.ChartHasil.TabIndex = 0
        Me.ChartHasil.Text = "ChartHasil"
        Me.ChartHasil.EndInit()
        ' -------------------------------------------------------------------

        ' --- INISIALISASI KONTROL LAMA ---
        Me.Label1 = New Label()
        Me.NamaTextBox = New TextBox()
        Me.Label2 = New Label()
        Me.NIMTextBox = New TextBox()
        Me.Label3 = New Label()
        Me.ProdiComboBox = New ComboBox()
        Me.LogOutButton = New Button()
        Me.TestRekomendasiButton = New Button()
        Me.GroupBox1 = New GroupBox()
        Me.FlowLayoutPanel1 = New FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New FlowLayoutPanel()
        Me.TableLayoutPanel5 = New TableLayoutPanel()
        Me.TableLayoutPanel6 = New TableLayoutPanel()
        Me.TableLayoutPanel4 = New TableLayoutPanel()
        Me.TableLayoutPanel7 = New TableLayoutPanel()
        Me.TableLayoutPanel1 = New TableLayoutPanel()
        Me.TableLayoutPanel2 = New TableLayoutPanel()
        Me.TableLayoutPanel3 = New TableLayoutPanel()
        Me.TableLayoutPanel8 = New TableLayoutPanel()

        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()

        ' 
        ' Label1
        ' 
        Me.Label1.AutoSize = True
        Me.Label1.Font = New Font("Calibri", 9.75F)
        Me.Label1.ForeColor = Color.White
        Me.Label1.Location = New Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        ' 
        ' NamaTextBox
        ' 
        Me.NamaTextBox.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Me.NamaTextBox.Location = New Point(3, 18)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New Size(180, 23)
        Me.NamaTextBox.TabIndex = 1
        ' 
        ' Label2
        ' 
        Me.Label2.AutoSize = True
        Me.Label2.Font = New Font("Calibri", 9.75F)
        Me.Label2.ForeColor = Color.White
        Me.Label2.Location = New Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(30, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NIM"
        ' 
        ' NIMTextBox
        ' 
        Me.NIMTextBox.Font = New Font("Calibri", 9.75F)
        Me.NIMTextBox.Location = New Point(3, 18)
        Me.NIMTextBox.Name = "NIMTextBox"
        Me.NIMTextBox.Size = New Size(169, 23)
        Me.NIMTextBox.TabIndex = 1

        ' 
        ' Label3
        ' 
        Me.Label3.AutoSize = True
        Me.Label3.Font = New Font("Calibri", 9.75F)
        Me.Label3.ForeColor = Color.White
        Me.Label3.Location = New Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(37, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Prodi"
        ' 
        ' ProdiComboBox
        ' 
        Me.ProdiComboBox.Font = New Font("Calibri", 9.75F)
        Me.ProdiComboBox.Location = New Point(3, 18)
        Me.ProdiComboBox.Name = "ProdiComboBox"
        Me.ProdiComboBox.Size = New Size(169, 23)
        Me.ProdiComboBox.TabIndex = 1

        ' 
        ' LogOutButton
        ' 
        Me.LogOutButton.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Me.LogOutButton.Cursor = Cursors.Hand
        Me.LogOutButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Me.LogOutButton.FlatStyle = FlatStyle.Flat
        Me.LogOutButton.Font = New Font("Calibri", 9.0F)
        Me.LogOutButton.ForeColor = SystemColors.ButtonHighlight
        Me.LogOutButton.Location = New Point(29, 365) ' Y-coordinate from final fix
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New Size(117, 45)
        Me.LogOutButton.TabIndex = 10
        Me.LogOutButton.Text = "Logout"
        Me.LogOutButton.UseVisualStyleBackColor = False

        ' 
        ' TestRekomendasiButton
        ' 
        Me.TestRekomendasiButton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Me.TestRekomendasiButton.Cursor = Cursors.PanEast
        Me.TestRekomendasiButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Me.TestRekomendasiButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Me.TestRekomendasiButton.FlatAppearance.MouseOverBackColor = Color.Green
        Me.TestRekomendasiButton.FlatStyle = FlatStyle.Flat
        Me.TestRekomendasiButton.Font = New Font("Calibri", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.TestRekomendasiButton.Location = New Point(640, 365) ' Y-coordinate from final fix
        Me.TestRekomendasiButton.Name = "TestRekomendasiButton"
        Me.TestRekomendasiButton.Size = New Size(117, 45)
        Me.TestRekomendasiButton.TabIndex = 9
        Me.TestRekomendasiButton.Text = "Test Rekomendasi"
        Me.TestRekomendasiButton.UseVisualStyleBackColor = False

        ' 
        ' GroupBox1
        ' 
        Me.GroupBox1.BackColor = Color.White
        Me.GroupBox1.Controls.Add(Me.ChartHasil) ' <-- CHART DITAMBAHKAN DI SINI
        Me.GroupBox1.Font = New Font("Calibri", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.GroupBox1.Location = New Point(29, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New Size(725, 230)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hasil Rekomendasi"

        ' 
        ' FlowLayoutPanel1
        ' 
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.NIMTextBox)
        Me.FlowLayoutPanel1.Location = New Point(385, 21)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New Size(178, 47)
        Me.FlowLayoutPanel1.TabIndex = 2

        ' 
        ' FlowLayoutPanel2
        ' 
        Me.FlowLayoutPanel2.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel2.Controls.Add(Me.NamaTextBox)
        Me.FlowLayoutPanel2.Location = New Point(29, 21)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New Size(200, 47)
        Me.FlowLayoutPanel2.TabIndex = 1

        ' 
        ' FlowLayoutPanel3
        ' 
        Me.FlowLayoutPanel3.BackColor = Color.PowderBlue
        Me.FlowLayoutPanel3.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel3.Controls.Add(Me.ProdiComboBox)
        Me.FlowLayoutPanel3.Location = New Point(578, 21)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New Size(179, 47)
        Me.FlowLayoutPanel3.TabIndex = 0

        ' -------------------------------------------------------------------
        ' --- DEFINISI LENGKAP UNTUK SEMUA TABLELAYOUTPANELS YANG ADA ---
        ' -------------------------------------------------------------------

        ' TableLayoutPanel5
        Me.TableLayoutPanel5.BackColor = Color.CadetBlue
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel5.Location = New Point(606, 290)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(334, 186)
        Me.TableLayoutPanel5.TabIndex = 11

        ' TableLayoutPanel6
        Me.TableLayoutPanel6.BackColor = Color.LightBlue
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel6.Location = New Point(-5, 77)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(445, 100)
        Me.TableLayoutPanel6.TabIndex = 12

        ' TableLayoutPanel4
        Me.TableLayoutPanel4.BackColor = Color.PowderBlue
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel4.Location = New Point(572, -5)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(354, 186)
        Me.TableLayoutPanel4.TabIndex = 13

        ' TableLayoutPanel7
        Me.TableLayoutPanel7.BackColor = Color.SkyBlue
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel7.Location = New Point(228, 115)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(445, 100)
        Me.TableLayoutPanel7.TabIndex = 14

        ' TableLayoutPanel1
        Me.TableLayoutPanel1.BackColor = Color.SkyBlue
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel1.Location = New Point(264, -5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(107, 114)
        Me.TableLayoutPanel1.TabIndex = 12

        ' TableLayoutPanel2
        Me.TableLayoutPanel2.BackColor = Color.PowderBlue
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel2.Location = New Point(256, 413)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(556, 117)
        Me.TableLayoutPanel2.TabIndex = 11

        ' TableLayoutPanel3
        Me.TableLayoutPanel3.BackColor = Color.DeepSkyBlue
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel3.Location = New Point(-8, 242)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(354, 119)
        Me.TableLayoutPanel3.TabIndex = 11

        ' TableLayoutPanel8
        Me.TableLayoutPanel8.BackColor = Color.SkyBlue
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel8.Location = New Point(351, 367)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(107, 100)
        Me.TableLayoutPanel8.TabIndex = 12

        ' 
        ' DashboardMahasiswa (PENAMBAHAN KONTROL KE FORM)
        ' 
        Me.AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.CornflowerBlue
        Me.ClientSize = New Size(790, 442)

        ' --- BARIS KRUSIAL: Menambahkan semua FlowLayoutPanels dan Tombol ke Form ---
        Me.Controls.Add(Me.TableLayoutPanel8)
        Me.Controls.Add(Me.LogOutButton)
        Me.Controls.Add(Me.TestRekomendasiButton)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel6)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.TableLayoutPanel7)
        ' -------------------------------------------------------------------------

        Me.MaximizeBox = False
        Me.Name = "DashboardMahasiswa"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Dashboard Mahasiswa"

        ' Resume Layouts
        Me.GroupBox1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.ChartHasil.ResumeLayout(False)
        Me.ResumeLayout(False)

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