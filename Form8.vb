Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

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

End Class