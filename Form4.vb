Public Class FormDashboard
    Public Sub New()

        InitializeComponent()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim FormLogin As New FormLogin()
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub RegistrasiButton_Click(sender As Object, e As EventArgs) Handles RegistrasiButton.Click
        Dim FormRegistrasi As New FormRegistrasi()
        FormRegistrasi.Show()
        Me.Hide()
    End Sub
End Class