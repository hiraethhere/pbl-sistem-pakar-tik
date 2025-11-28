' FormPertanyaanCF.vb
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class FormPertanyaanCF

    ' Array untuk menyimpan nilai CF user (14 pertanyaan, index 1-14)
    Dim jawabanCF(14) As Double
    Dim dtPertanyaan As New DataTable
    Dim indexPertanyaan As Integer = 1 ' Mulai dari pertanyaan ke-1
    Dim NamaMhs As String
    Dim TotalDetik As Integer = 30 * 60 ' 30 menit * 60 detik
    ' Constructor untuk menerima Nama dari Form sebelumnya
    Public Sub New(ByVal nama As String)
        InitializeComponent()
        NamaMhs = nama
    End Sub

    Private Sub FormPertanyaanCF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNamaMhs.Text = "Nama: " & NamaMhs

        ' 1. Ambil pertanyaan dari Database
        ModuleKoneksi.BukaKoneksi()
        Dim da As New SqlDataAdapter("SELECT * FROM tbl_pertanyaan ORDER BY id_pertanyaan", ModuleKoneksi.conn)
        da.Fill(dtPertanyaan)
        ModuleKoneksi.TutupKoneksi()

        TampilkanPertanyaan()
        TimerUjian.Start()
    End Sub

    Private Sub TimerUjian_Tick(sender As Object, e As EventArgs) Handles TimerUjian.Tick
        TotalDetik -= 1 ' Kurangi 1 detik

        ' Hitung menit dan detik untuk ditampilkan
        Dim menit As Integer = TotalDetik \ 60
        Dim detik As Integer = TotalDetik Mod 60

        lblWaktu.Text = $"Waktu Tersisa: {menit:D2}:{detik:D2}"

        If TotalDetik <= 0 Then
            TimerUjian.Stop()
            MessageBox.Show("Waktu pengerjaan telah habis! Anda akan dikembalikan ke Dashboard.", "Waktu Habis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Kembali ke Dashboard
            Dim formDashboard As New FormDashboard()
            formDashboard.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FormPertanyaanCF_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TimerUjian.Stop()
    End Sub

    ' Tampilkan Pertanyaan Saat Ini
    Sub TampilkanPertanyaan()
        If indexPertanyaan <= dtPertanyaan.Rows.Count Then
            Dim row As DataRow = dtPertanyaan.Rows(indexPertanyaan - 1)
            lblNoSoal.Text = "Pertanyaan ke-" & indexPertanyaan
            lblPertanyaan.Text = row("teks_pertanyaan").ToString()

            ' Reset pilihan Radio Button
            rbA.Checked = False : rbB.Checked = False : rbC.Checked = False
            rbD.Checked = False : rbE.Checked = False
        Else
            ' Semua pertanyaan sudah dijawab, lakukan pemrosesan
            ProsesCertaintyFactor()
        End If
    End Sub

    ' Event saat tombol Lanjut diklik
    Private Sub btnLanjut_Click(sender As Object, e As EventArgs) Handles btnLanjut.Click

        Dim nilaiCFUser As Double = 0.0

        ' Cek dan ambil nilai CF dari pilihan Radio Button (0.0, 0.4, 0.6, 0.8, 1.0)
        If rbE.Checked Then
            nilaiCFUser = 1.0 ' Sangat Baik
        ElseIf rbD.Checked Then
            nilaiCFUser = 0.8 ' Baik
        ElseIf rbC.Checked Then
            nilaiCFUser = 0.6 ' Cukup
        ElseIf rbB.Checked Then
            nilaiCFUser = 0.4 ' Kurang
        ElseIf rbA.Checked Then
            nilaiCFUser = 0.0 ' Sangat Kurang
        Else
            MessageBox.Show("Anda harus memilih salah satu jawaban.", "Peringatan")
            Exit Sub
        End If

        ' Simpan nilai CF user untuk pertanyaan saat ini
        jawabanCF(indexPertanyaan) = nilaiCFUser

        ' Lanjut ke pertanyaan berikutnya
        indexPertanyaan += 1
        TampilkanPertanyaan()
    End Sub

    ' KODE CORE SISTEM PAKAR: PERHITUNGAN CF
    Sub ProsesCertaintyFactor()
        TimerUjian.Stop()
        ' 1. Deklarasi array untuk CF Pakar (dari Database)
        Dim CF_SOFT_DEV(14), CF_UIUX(14), CF_NET_ENGG(14) As Double

        ' 2. Ambil CF Pakar dari Database
        ModuleKoneksi.BukaKoneksi()
        Dim cmd As New SqlCommand("SELECT cf_soft_dev, cf_uiux, cf_net_engg FROM tbl_rule_cf ORDER BY id_pertanyaan", ModuleKoneksi.conn)
        Dim rd As SqlDataReader = cmd.ExecuteReader()
        Dim i As Integer = 1 ' Mulai dari index 1
        While rd.Read()
            CF_SOFT_DEV(i) = rd("cf_soft_dev")
            CF_UIUX(i) = rd("cf_uiux")
            CF_NET_ENGG(i) = rd("cf_net_engg")
            i += 1
        End While
        rd.Close()
        ModuleKoneksi.TutupKoneksi()

        ' 3. Hitung dan Combine CF (Rumus CF Combine: CF1 + CF2 * (1 - CF1))
        Dim CF_HASIL_SOFT_DEV As Double = 0.0
        Dim CF_HASIL_UIUX As Double = 0.0
        Dim CF_HASIL_NET_ENGG As Double = 0.0

        For i = 1 To 14 ' 14 pertanyaan
            ' CF[H,E] = CF[H] * CF[E]
            Dim CF_INDIV_SOFT_DEV As Double = CF_SOFT_DEV(i) * jawabanCF(i)
            Dim CF_INDIV_UIUX As Double = CF_UIUX(i) * jawabanCF(i)
            Dim CF_INDIV_NET_ENGG As Double = CF_NET_ENGG(i) * jawabanCF(i)

            If i = 1 Then
                ' Inisialisasi CF Kombinasi dengan hasil pertama
                CF_HASIL_SOFT_DEV = CF_INDIV_SOFT_DEV
                CF_HASIL_UIUX = CF_INDIV_UIUX
                CF_HASIL_NET_ENGG = CF_INDIV_NET_ENGG
            Else
                ' CF Combine
                CF_HASIL_SOFT_DEV = CF_HASIL_SOFT_DEV + CF_INDIV_SOFT_DEV * (1 - CF_HASIL_SOFT_DEV)
                CF_HASIL_UIUX = CF_HASIL_UIUX + CF_INDIV_UIUX * (1 - CF_HASIL_UIUX)
                CF_HASIL_NET_ENGG = CF_HASIL_NET_ENGG + CF_INDIV_NET_ENGG * (1 - CF_HASIL_NET_ENGG)
            End If
        Next

        ' 4. Tentukan Profil dengan CF Tertinggi
        Dim hasilTopik As String = "Belum Dapat Ditentukan"
        Dim nilaiTertinggi As Double = 0.0

        If CF_HASIL_SOFT_DEV >= CF_HASIL_UIUX AndAlso CF_HASIL_SOFT_DEV >= CF_HASIL_NET_ENGG Then
            hasilTopik = "Software Developer"
            nilaiTertinggi = CF_HASIL_SOFT_DEV
        ElseIf CF_HASIL_UIUX > CF_HASIL_SOFT_DEV AndAlso CF_HASIL_UIUX >= CF_HASIL_NET_ENGG Then
            hasilTopik = "UI/UX Designer"
            nilaiTertinggi = CF_HASIL_UIUX
        ElseIf CF_HASIL_NET_ENGG > CF_HASIL_SOFT_DEV AndAlso CF_HASIL_NET_ENGG > CF_HASIL_UIUX Then
            hasilTopik = "Network Engineer"
            nilaiTertinggi = CF_HASIL_NET_ENGG
        End If

        ' 5. Simpan Hasil ke Database
        SimpanHasil(NamaMhs, hasilTopik, nilaiTertinggi)

        ' 6. Tampilkan Form Hasil
        Dim formHasil As New FormHasil(hasilTopik, nilaiTertinggi)
        formHasil.Show()
        Me.Close()

    End Sub

    Sub SimpanHasil(nama As String, hasil As String, nilaiCF As Double)
        ModuleKoneksi.BukaKoneksi()
        Dim query As String = "INSERT INTO tbl_hasil (nama_mahasiswa, hasil_profil, nilai_cf) VALUES (@nama, @hasil, @nilai)"
        Using cmd As New SqlCommand(query, ModuleKoneksi.conn)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@hasil", hasil)
            cmd.Parameters.AddWithValue("@nilai", nilaiCF)
            cmd.ExecuteNonQuery()
        End Using
        ModuleKoneksi.TutupKoneksi()
    End Sub

    Private Sub lblPertanyaan_Click(sender As Object, e As EventArgs) Handles lblPertanyaan.Click

    End Sub

    Private Sub rbA_CheckedChanged(sender As Object, e As EventArgs) Handles rbA.CheckedChanged

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub rbB_CheckedChanged(sender As Object, e As EventArgs) Handles rbB.CheckedChanged

    End Sub
End Class