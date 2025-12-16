Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class DashboardDosen
    Private NIMLama As String = ""

    Private Sub TampilData()
        Try
            BukaKoneksi()

            Dim query As String = "SELECT nim, nama, prodi, role FROM users"
            Using da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                DataGridView.DataSource = dt
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub ResetForm()
        NamaTextBox.Clear()
        NIMTextBox.Clear()
        PasswordTextBox.Clear()

        ProdiComboBox.SelectedIndex = -1
        RoleComboBox.SelectedIndex = -1

        EditButton.Enabled = False
        HapusButton.Enabled = False

        NIMLama = ""
        NIMTextBox.ReadOnly = False
        NIMTextBox.Enabled = True

        NamaTextBox.Focus()
    End Sub

    Private Sub DashboardDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProdiComboBox.Items.Add("TI")
        ProdiComboBox.Items.Add("TMJ")
        ProdiComboBox.Items.Add("TMD")

        RoleComboBox.Items.Add("Mahasiswa")
        RoleComboBox.Items.Add("Dosen")

        TampilData()
        ResetForm()
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub TambahButton_Click(sender As Object, e As EventArgs) Handles TambahButton.Click
        If NamaTextBox.Text.Trim() = "" OrElse
           NIMTextBox.Text.Trim() = "" OrElse
           ProdiComboBox.Text.Trim() = "" OrElse
           RoleComboBox.Text.Trim() = "" OrElse
           PasswordTextBox.Text.Trim() = "" Then

            MessageBox.Show("Semua data harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            BukaKoneksi()

            Dim cekQuery As String = "SELECT COUNT(*) FROM users WHERE nim = @NIM"
            Using cekCmd As New SqlCommand(cekQuery, conn)
                cekCmd.Parameters.AddWithValue("@NIM", NIMTextBox.Text.Trim())
                If Convert.ToInt32(cekCmd.ExecuteScalar()) > 0 Then
                    MessageBox.Show("NIM sudah terdaftar!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using

            Dim hashedPassword As String = HashPassword(PasswordTextBox.Text.Trim())

            Dim query As String = "INSERT INTO users (nim, nama, prodi, role, password) VALUES (@NIM, @Nama, @Prodi, @Role, @Password)"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NIM", NIMTextBox.Text.Trim())
                cmd.Parameters.AddWithValue("@Nama", NamaTextBox.Text.Trim())
                cmd.Parameters.AddWithValue("@Prodi", ProdiComboBox.Text.Trim())
                cmd.Parameters.AddWithValue("@Role", RoleComboBox.Text.Trim())
                cmd.Parameters.AddWithValue("@Password", hashedPassword)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Akun berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            ResetForm()

        Catch ex As Exception
            MessageBox.Show("Terjadi error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        Try
            If e.RowIndex < 0 Then Exit Sub

            Dim row As DataGridViewRow = DataGridView.Rows(e.RowIndex)

            NIMLama = row.Cells("nim").Value.ToString()

            NIMTextBox.Text = NIMLama
            NamaTextBox.Text = row.Cells("nama").Value.ToString()
            ProdiComboBox.Text = row.Cells("prodi").Value.ToString()
            RoleComboBox.Text = row.Cells("role").Value.ToString()
            PasswordTextBox.Text = ""

            EditButton.Enabled = True
            HapusButton.Enabled = True

            NIMTextBox.ReadOnly = False
            NIMTextBox.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        End Try
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim nimBaru As String = NIMTextBox.Text.Trim()
        Dim nama As String = NamaTextBox.Text.Trim()
        Dim prodi As String = ProdiComboBox.Text.Trim()
        Dim role As String = RoleComboBox.Text.Trim()
        Dim passInput As String = PasswordTextBox.Text.Trim()

        If NIMLama.Trim() = "" Then
            MessageBox.Show("Pilih data dari tabel terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If nimBaru = "" OrElse nama = "" OrElse prodi = "" OrElse role = "" Then
            MessageBox.Show("NIM, Nama, Prodi, dan Role tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            BukaKoneksi()

            If nimBaru <> NIMLama Then
                Dim cekNimBaru As String = "SELECT COUNT(*) FROM users WHERE nim = @NIMBaru"
                Using cekCmd As New SqlCommand(cekNimBaru, conn)
                    cekCmd.Parameters.AddWithValue("@NIMBaru", nimBaru)
                    If Convert.ToInt32(cekCmd.ExecuteScalar()) > 0 Then
                        MessageBox.Show("NIM baru sudah terdaftar. Gunakan NIM lain.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using
            End If

            Dim query As String
            If passInput <> "" Then
                query = "UPDATE users SET nim=@NIMBaru, nama=@Nama, prodi=@Prodi, role=@Role, password=@Password WHERE nim=@NIMLama"
            Else
                query = "UPDATE users SET nim=@NIMBaru, nama=@Nama, prodi=@Prodi, role=@Role WHERE nim=@NIMLama"
            End If

            Dim rowsAffected As Integer
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NIMBaru", nimBaru)
                cmd.Parameters.AddWithValue("@Nama", nama)
                cmd.Parameters.AddWithValue("@Prodi", prodi)
                cmd.Parameters.AddWithValue("@Role", role)
                cmd.Parameters.AddWithValue("@NIMLama", NIMLama)

                If passInput <> "" Then
                    cmd.Parameters.AddWithValue("@Password", HashPassword(passInput))
                End If

                rowsAffected = cmd.ExecuteNonQuery()
            End Using

            If rowsAffected = 0 Then
                MessageBox.Show("Data tidak ditemukan/berhasil diubah. Pastikan memilih data dari tabel.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            NIMLama = nimBaru

            TampilData()
            PasswordTextBox.Clear()

        Catch ex As Exception
            MessageBox.Show("Terjadi error saat update: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub HapusButton_Click(sender As Object, e As EventArgs) Handles HapusButton.Click
        If NIMLama.Trim() = "" Then
            MessageBox.Show("Silakan pilih data dari tabel terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show(
            "Apakah Anda yakin ingin menghapus data dengan NIM: " & NIMLama & "?",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If result = DialogResult.No Then Exit Sub

        Try
            BukaKoneksi()

            Dim query As String = "DELETE FROM users WHERE nim=@NIM"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NIM", NIMLama)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            ResetForm()

        Catch ex As Exception
            MessageBox.Show("Terjadi error saat menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResetForm()
    End Sub

    Private Function AmbilNama(nim As String) As String
        Dim namaQuery As String = "SELECT nama FROM users WHERE nim = @NIM"
        Using cmd As New SqlCommand(namaQuery, conn)
            cmd.Parameters.AddWithValue("@NIM", nim)
            Dim result = cmd.ExecuteScalar()
            If result Is Nothing OrElse result Is DBNull.Value Then Return ""
            Return result.ToString()
        End Using
    End Function

    Private Function AmbilProdi(nim As String) As String
        Dim prodiQuery As String = "SELECT prodi FROM users WHERE nim = @NIM"
        Using cmd As New SqlCommand(prodiQuery, conn)
            cmd.Parameters.AddWithValue("@NIM", nim)
            Dim result = cmd.ExecuteScalar()
            If result Is Nothing OrElse result Is DBNull.Value Then Return ""
            Return result.ToString()
        End Using
    End Function

    Private Sub CekHasilButton_Click(sender As Object, e As EventArgs) Handles CekHasilButton.Click
        If NIMTextBox.Text.Trim() = "" Then
            MessageBox.Show("Silakan isi NIM.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            BukaKoneksi()

            Dim query As String = "SELECT COUNT(*) FROM users WHERE nim = @NIM"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NIM", NIMTextBox.Text.Trim())

                Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If jumlah > 0 Then
                    NIMMahasiswa = NIMTextBox.Text.Trim()
                    NamaMahasiswa = AmbilNama(NIMMahasiswa)
                    ProdiMahasiswa = AmbilProdi(NIMMahasiswa)

                    HasilMahasiswa.Show()
                    Me.Close()
                Else
                    MessageBox.Show("NIM tidak terdaftar.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try
    End Sub
End Class