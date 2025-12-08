Public Class FormDashboard

    Private Sub btnMulai_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        ' Buka Form Data Diri
        Dim FormLogin As New FormLogin()
        FormLogin.Show()
        Me.Hide() ' Sembunyikan Dashboard
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        ' Keluar dari seluruh aplikasi
        Application.Exit()
    End Sub

    Private Sub RegistrasiButton_Click(sender As Object, e As EventArgs) Handles RegistrasiButton.Click
        Dim FormRegistrasi As New FormRegistrasi()
        FormRegistrasi.Show()
        Me.Hide()
    End Sub
End Class