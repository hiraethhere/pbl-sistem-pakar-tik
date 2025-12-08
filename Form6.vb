Public Class DashboardMahasiswa
    Private Sub DashboardMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProdiComboBox.Items.Add("TI")
        ProdiComboBox.Items.Add("TMJ")
        ProdiComboBox.Items.Add("TMD")
    End Sub

    Private Sub FormMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NamaTextBox.Text = LoggedNama
        NIMTextBox.Text = LoggedNIM
        ProdiComboBox.Text = LoggedProdi

        ' Optional: Kunci input biar tidak bisa diedit kecuali kamu mau fitur edit profil
        NamaTextBox.ReadOnly = True
        NIMTextBox.ReadOnly = True
        ProdiComboBox.Enabled = False
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        LoggedNIM = Nothing
        LoggedNama = Nothing
        LoggedProdi = Nothing
        LoggedRole = Nothing

        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub TestRekomendasiButton_Click(sender As Object, e As EventArgs) Handles TestRekomendasiButton.Click
        Dim formPertanyaan As New FormPertanyaanCF(NamaTextBox.Text)
        formPertanyaan.Show()
        Me.Hide() ' Sembunyikan Form Data Diri
    End Sub
End Class