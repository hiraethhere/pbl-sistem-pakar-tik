Public Class FormDashboard

    Private Sub btnMulai_Click(sender As Object, e As EventArgs) Handles btnMulai.Click
        ' Buka Form Data Diri
        Dim formDataDiri As New FormDataDiri()
        formDataDiri.Show()
        Me.Hide() ' Sembunyikan Dashboard
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        ' Keluar dari seluruh aplikasi
        Application.Exit()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class