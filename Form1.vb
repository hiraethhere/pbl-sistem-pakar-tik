Public Class FormDataDiri

    Private Sub btnLanjut_Click(sender As Object, e As EventArgs) Handles btnLanjut.Click
        'If txtNama.Text.Trim() = "" Or txtNIM.Text.Trim() = "" Then
        '    MessageBox.Show("Mohon isi data diri lengkap.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'End If

        ' Inisialisasi dan tampilkan Form Pertanyaan (dengan nama yang di-passing)
        Dim formPertanyaan As New FormPertanyaanCF(txtNama.Text)
        formPertanyaan.Show()
        Me.Hide() ' Sembunyikan Form Data Diri
    End Sub

    Private Sub FormDataDiri_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Jika form ini ditutup (tanpa tombol lanjut), kembali ke Dashboard
        If e.CloseReason = CloseReason.UserClosing Then
            Dim formDashboard As New FormDashboard()
            formDashboard.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormDataDiri_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class