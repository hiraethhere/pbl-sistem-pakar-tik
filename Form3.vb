Imports System.Windows.Forms

Public Class FormHasil

    ' Asumsi: lblProfil, lblNilaiCF, btnTestLagi, btnKeluarAplikasi ada di Form ini.

    Public Sub New(ByVal hasil As String, ByVal cf As Double)
        InitializeComponent()

        Me.Text = "Hasil Profil Lulusan"
        ' Tampilkan hasil dengan format yang bagus
        lblProfil.Text = hasil
        lblNilaiCF.Text = $"Tingkat Keyakinan Sistem (CF): {Math.Round(cf, 3):0.000}"
    End Sub

    Private Sub btnTestLagi_Click(sender As Object, e As EventArgs) Handles btnTestLagi.Click
        ' Kembali ke Form Data Diri
        Dim formDataDiri As New FormDataDiri()
        formDataDiri.Show()
        Me.Close()
    End Sub

    Private Sub btnKeluarAplikasi_Click(sender As Object, e As EventArgs) Handles btnKeluarAplikasi.Click
        ' Menghentikan seluruh aplikasi
        If MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class