Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Data.SqlClient
Imports System.Diagnostics

Public Class HasilMahasiswa
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProdiComboBox.Items.Add("TI")
        ProdiComboBox.Items.Add("TMJ")
        ProdiComboBox.Items.Add("TMD")

        NamaTextBox.Text = NamaMahasiswa
        NIMTextBox.Text = NIMMahasiswa
        ProdiComboBox.Text = ProdiMahasiswa

        NamaTextBox.ReadOnly = True
        NIMTextBox.ReadOnly = True
        ProdiComboBox.Enabled = False
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub HasilMahasiswa_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Fungsi ini dipanggil saat form pertama kali dimuat DAN setiap kali
        ' form muncul kembali setelah form lain disembunyikan/ditutup.
        TampilkanHasilRekomendasi()
    End Sub

    Private Function AmbilNamaProfil(kode As String) As String
        Dim namaProfil As String = kode
        Try
            ModuleKoneksi.BukaKoneksi()
            Dim query As String = "SELECT profil FROM profil WHERE kode = @Kode"
            Using cmd As New SqlCommand(query, ModuleKoneksi.conn)
                cmd.Parameters.AddWithValue("@Kode", kode)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    namaProfil = result.ToString()
                End If
            End Using
        Catch ex As Exception
            ' Abaikan error dan kembalikan kode jika gagal
        Finally
            ModuleKoneksi.TutupKoneksi()
        End Try
        Return namaProfil
    End Function

    Private Sub TestRekomendasiButton_Click(sender As Object, e As EventArgs) Handles TestRekomendasiButton.Click
        NIMMahasiswa = Nothing
        NamaMahasiswa = Nothing
        ProdiMahasiswa = Nothing

        DashboardDosen.Show()
        Me.Close()
    End Sub

    Private Sub TampilkanHasilRekomendasi()
        Dim results As List(Of Tuple(Of String, Double)) = Hasil.AmbilHasilTerakhir(NIMMahasiswa)

        If ChartHasil Is Nothing Then
            GroupBox1.Text = "Error: Chart tidak termuat."
            Return
        End If


        ChartHasil.Series("Persentase").Points.Clear()


        If results IsNot Nothing AndAlso results.Count > 0 Then

            GroupBox1.Text = "Hasil Rekomendasi Terakhir"

            For Each item In results
                Dim profileCode As String = item.Item1
                Dim percentage As Double = item.Item2
                Dim profileName As String = AmbilNamaProfil(profileCode)

                ChartHasil.Series("Persentase").Points.AddXY(profileName, percentage)
            Next

            ' Kustomisasi Chart
            ChartHasil.Titles.Clear()
            ChartHasil.Titles.Add("Top " & results.Count & " Profil Cocok")

            ' --- PENGATURAN AXIS Y (Interval 5, Maks 100) ---
            ChartHasil.ChartAreas(0).AxisY.Title = "Persentase Keyakinan (%)"
            ChartHasil.ChartAreas(0).AxisY.Maximum = 100



            ' --- PENGATURAN AXIS X (Tidak Miring) ---
            ChartHasil.ChartAreas(0).AxisX.LabelStyle.Angle = 0 ' <-- Membuat tulisan tidak miring
            ChartHasil.ChartAreas(0).AxisX.Interval = 1

            ChartHasil.ChartAreas(0).AxisY.MajorGrid.Enabled = False     ' <-- Hapus garis horizontal
            ChartHasil.ChartAreas(0).AxisY.MajorTickMark.Enabled = False ' <-- Hapus garis tick mark vertikal

            ' --- PENGATURAN LABEL PADA BAR ---
            Dim columnSeries As System.Windows.Forms.DataVisualization.Charting.Series
            columnSeries = ChartHasil.Series("Persentase")

            columnSeries.IsValueShownAsLabel = True ' <-- Tampilkan label di atas bar

            ' Gunakan format #VALY untuk menampilkan nilai, tambahkan % dan format tanpa desimal (F0)
            columnSeries.LabelFormat = "{F0}%"
            columnSeries.Font = New Font("Arial", 8.25F, FontStyle.Bold)
            ' -------------------------------------------------------------

            ChartHasil.Series("Persentase").Color = Color.FromArgb(0, 150, 0)
        Else
            GroupBox1.Text = "Hasil Rekomendasi Terakhir (Belum Ada Tes)"
        End If
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

        Me.PrintPreviewDialog1.Document = Me.PrintDocument1

        Dim ppc As System.Windows.Forms.PrintPreviewControl = Nothing

        If Me.PrintPreviewDialog1.Controls.Count > 0 AndAlso TypeOf Me.PrintPreviewDialog1.Controls(0) Is System.Windows.Forms.PrintPreviewControl Then
            ppc = CType(Me.PrintPreviewDialog1.Controls(0), System.Windows.Forms.PrintPreviewControl)
        End If

        If ppc IsNot Nothing Then
            ppc.UseAntiAlias = False
            ppc.Zoom = 1.0
            ppc.InvalidatePreview()
        End If

        ' Mengatur WINDOW KE MAXIMIZED (FULLSCREEN)
        Me.PrintPreviewDialog1.WindowState = FormWindowState.Maximized

        ' Tampilkan Dialog
        Me.PrintPreviewDialog1.ShowDialog()

        ' Jika Anda menyembunyikan toolbar (solusi agresif), tampilkan kembali di sini:
        ' For i As Integer = 1 To PrintPreviewDialog1.Controls.Count - 1
        '     PrintPreviewDialog1.Controls(i).Visible = True
        ' Next

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            ' --- DEFINISI LAYOUT DAN FONT ---
            Dim g As Graphics = e.Graphics
            Dim marginX As Integer = 50
            Dim currentY As Integer = 50
            Dim lineSpacing As Integer = 25

            Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
            Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
            Dim normalFont As New Font("Arial", 10)

            ' --- 1. CETAK JUDUL UTAMA ---
            g.DrawString("LAPORAN HASIL REKOMENDASI PROFESI TIK", titleFont, Brushes.Black, marginX, currentY)
            currentY += 40

            g.DrawLine(Pens.Gray, marginX, currentY, e.PageBounds.Width - marginX, currentY)
            currentY += 15

            ' --- 2. CETAK DATA DIRI MAHASISWA ---
            g.DrawString("DATA MAHASISWA:", headerFont, Brushes.DarkBlue, marginX, currentY)
            currentY += lineSpacing

            g.DrawString($"Nama: {NamaMahasiswa}", normalFont, Brushes.Black, marginX, currentY)
            currentY += lineSpacing

            g.DrawString($"NIM: {NIMMahasiswa}", normalFont, Brushes.Black, marginX, currentY)
            currentY += lineSpacing

            g.DrawString($"Prodi: {ProdiMahasiswa}", normalFont, Brushes.Black, marginX, currentY)
            currentY += lineSpacing + 20

            ' --- 3. CETAK CHART HASIL REKOMENDASI ---
            g.DrawString("GRAFIK HASIL REKOMENDASI TERAKHIR:", headerFont, Brushes.DarkBlue, marginX, currentY)
            currentY += lineSpacing

            Dim chartPrintWidth As Integer = e.PageBounds.Width - 2 * marginX
            Dim chartPrintHeight As Integer = 300

            Dim chartDrawingArea As New Rectangle(marginX, currentY, chartPrintWidth, chartPrintHeight)

            ' Merender chart langsung ke Graphics object (output bersih)
            Me.ChartHasil.Printing.PrintPaint(g, chartDrawingArea)

            currentY += chartPrintHeight + 20

            e.HasMorePages = False

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mencetak: " & ex.Message, "Error Print")
        End Try
    End Sub

End Class