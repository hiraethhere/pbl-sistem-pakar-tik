Imports System.Windows.Forms
Imports Microsoft.Data.SqlClient
Imports System.Text ' Perlu untuk StringBuilder

Public Class FormHasil

    ' Asumsi: lblProfil, lblNilaiCF, btnTestLagi, btnKeluarAplikasi ada di Form ini.
    Public Sub New(ByVal results As List(Of Result))
        InitializeComponent()

        Me.Text = "Hasil Profil Lulusan"

        Dim top1ProfileName As String = ""
        Dim top1CFValue As Double = 0.0

        ' Gunakan StringBuilder untuk membangun daftar Top 3
        Dim top3Detail As New System.Text.StringBuilder()
        top3Detail.AppendLine("Top 3 Rekomendasi Profil:")
        top3Detail.AppendLine("-------------------------")

        Dim ranking As Integer = 1
        For Each item In results
            Dim profileName As String = AmbilNamaProfil(item.profile) ' Map P01 ke nama lengkap
            Dim persentase As String = (item.persentage).ToString("0.##") & "%"

            top3Detail.AppendLine($"{ranking}. {profileName} ({persentase})")

            If ranking = 1 Then
                top1ProfileName = profileName
                top1CFValue = item.value
            End If

            ranking += 1
        Next

        ' Tampilkan Top 1 di label utama (lblProfil)
        lblProfil.Text = top1ProfileName

        ' Gabungkan CF Top 1 dan detail Top 3
        lblNilaiCF.Text = $"Tingkat Keyakinan Sistem (CF) Top 1: {Math.Round(top1CFValue, 3):0.000}" & vbCrLf & vbCrLf & top3Detail.ToString()

        ' Mengubah teks tombol agar sesuai dengan fungsi yang baru
        btnTestLagi.Text = "Kembali ke Dashboard"
        btnKeluarAplikasi.Text = "Logout"
    End Sub

    ' Fungsi helper untuk mengambil nama profil dari kode (P01, P02, dll.)
    Private Function AmbilNamaProfil(kode As String) As String
        Dim namaProfil As String = kode ' Default ke kode jika gagal
        Try
            ModuleKoneksi.BukaKoneksi()
            ' Query untuk mengambil nama profil dari tabel 'profil'
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

    ' MODIFIKASI: Mengarahkan ke DashboardMahasiswa (Form6)
    Private Sub btnTestLagi_Click(sender As Object, e As EventArgs) Handles btnTestLagi.Click

        Dim formDashboardMahasiswa As New DashboardMahasiswa()
        formDashboardMahasiswa.Show()
        Me.Close()
    End Sub

    ' Logout: Tetap mengarahkan ke FormDashboard (Form4) dan membersihkan sesi
    Private Sub btnKeluarAplikasi_Click(sender As Object, e As EventArgs) Handles btnKeluarAplikasi.Click
        If MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ' Kosongkan variabel global yang login
            LoggedNIM = Nothing
            LoggedNama = Nothing
            LoggedProdi = Nothing
            LoggedRole = Nothing

            ' Buka FormDashboard (Form4) dan tutup FormHasil
            Dim formDashboard As New FormDashboard()
            formDashboard.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class