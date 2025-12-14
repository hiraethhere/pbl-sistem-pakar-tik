Imports Microsoft.Data.SqlClient

Public Class FormRegistrasi
    Private Sub FormRegistrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProdiComboBox.Items.Add("TI")
        ProdiComboBox.Items.Add("TMJ")
        ProdiComboBox.Items.Add("TMD")
    End Sub

    Private Sub KembaliButton_Click(sender As Object, e As EventArgs) Handles KembaliButton.Click
        Dim FormDashboard As New FormDashboard
        FormDashboard.Show()
        Me.Close()
    End Sub

    Private Sub RegistrasiButton_Click(sender As Object, e As EventArgs) Handles RegistrasiButton.Click
        If NamaTextBox.Text.Trim() = "" Or NIMTextBox.Text.Trim() = "" Or
           ProdiComboBox.Text.Trim() = "" Or PasswordTextBox.Text.Trim() = "" Then
            MessageBox.Show("Semua data harus diisi.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            BukaKoneksi()

            ' Cek duplikasi NIM
            Dim cekQuery As String = "SELECT COUNT(*) FROM users WHERE nim = @NIM"
            Dim cekCmd As New SqlCommand(cekQuery, conn)
            cekCmd.Parameters.AddWithValue("@NIM", NIMTextBox.Text.Trim())

            If cekCmd.ExecuteScalar() > 0 Then
                MessageBox.Show("NIM sudah digunakan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim roleUser = "Mahasiswa"

            ' Hash password sebelum disimpan
            Dim hashedPassword As String = HashPassword(PasswordTextBox.Text.Trim())

            ' Insert query
            Dim query As String = "INSERT INTO users (nim, nama, prodi, role, password) VALUES (@NIM, @Nama, @Prodi, @Role, @Password)"
            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@NIM", NIMTextBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Nama", NamaTextBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Prodi", ProdiComboBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Role", roleUser)
            cmd.Parameters.AddWithValue("@Password", hashedPassword)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset input
            NamaTextBox.Clear()
            NIMTextBox.Clear()
            ProdiComboBox.SelectedIndex = -1
            'RoleComboBox.SelectedIndex = -1
            PasswordTextBox.Clear()

            ' Pindah ke dashboard
            FormDashboard.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Terjadi error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            TutupKoneksi()
        End Try
    End Sub
End Class