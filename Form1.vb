Imports Microsoft.Data.SqlClient

Public Class FormLogin
    Private IsNavigatingAway As Boolean = False
    Private Sub btnLanjut_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If NIMTextBox.Text.Trim() = "" Or PasswordTextBox.Text.Trim() = "" Then
            MessageBox.Show("Silakan isi NIM dan Password.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            BukaKoneksi()

            Dim query As String = "SELECT password, role FROM users WHERE NIM = @NIM"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@NIM", NIMTextBox.Text.Trim())

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.HasRows = False Then
                reader.Close()
                MessageBox.Show("NIM belum terdaftar!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            reader.Read()
            Dim storedHash As String = reader("password").ToString()
            Dim role As String = reader("role").ToString()
            reader.Close()

            Dim inputHash As String = HashPassword(PasswordTextBox.Text.Trim())

            If inputHash <> storedHash Then
                MessageBox.Show("Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Login berhasil → arahkan sesuai role
            MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            IsNavigatingAway = True
            If role = "Mahasiswa" Then
                NIMMahasiswa = NIMTextBox.Text.Trim()
                NamaMahasiswa = AmbilNama(NIMMahasiswa)
                ProdiMahasiswa = AmbilProdi(NIMMahasiswa)
                DashboardMahasiswa.Show()
                Me.Close()
            ElseIf role = "Dosen" Then
                DashboardDosen.Show()
                Me.Close()
            Else
                MessageBox.Show("Role tidak dikenali. Periksa database.", "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Function AmbilNama(nim As String) As String
        Dim namaQuery As String = "SELECT nama FROM users WHERE nim = @NIM"
        Using cmd As New SqlCommand(namaQuery, conn)
            cmd.Parameters.AddWithValue("@NIM", nim)
            Return cmd.ExecuteScalar().ToString()
        End Using
    End Function

    Private Function AmbilProdi(nim As String) As String
        Dim prodiQuery As String = "SELECT prodi FROM users WHERE nim = @NIM"
        Using cmd As New SqlCommand(prodiQuery, conn)
            cmd.Parameters.AddWithValue("@NIM", nim)
            Return cmd.ExecuteScalar().ToString()
        End Using
    End Function

    Private Sub FormDataDiri_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing AndAlso IsNavigatingAway = False Then
            Dim formDashboard As New FormDashboard()
            formDashboard.Show()
        End If
    End Sub

    Private Sub FormDataDiri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextBox.PasswordChar = "*"
    End Sub

    Private Sub KembaliButton_Click(sender As Object, e As EventArgs) Handles KembaliButton.Click
        IsNavigatingAway = True
        Dim FormDashboard As New FormDashboard
        FormDashboard.Show()
        Me.Close()
    End Sub
End Class