Imports Microsoft.Data.SqlClient
Public Class DashboardDosen
    Private Sub TampilData()
        Try
            BukaKoneksi()

            Dim query As String = "SELECT nim, nama, prodi, role FROM users"
            Dim da As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)

            DataGridView.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)

        Finally
            TutupKoneksi()
        End Try
    End Sub
    Private Sub DashboardDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProdiComboBox.Items.Add("TI")
        ProdiComboBox.Items.Add("TMJ")
        ProdiComboBox.Items.Add("TMD")

        RoleComboBox.Items.Add("Mahasiswa")
        RoleComboBox.Items.Add("Dosen")

        TampilData()

        EditButton.Enabled = False
        HapusButton.Enabled = False
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub TambahButton_Click(sender As Object, e As EventArgs) Handles TambahButton.Click
        If NamaTextBox.Text.Trim() = "" Or
       NIMTextBox.Text.Trim() = "" Or
       ProdiComboBox.Text.Trim() = "" Or
       RoleComboBox.Text.Trim() = "" Or
       PasswordTextBox.Text.Trim() = "" Then

            MessageBox.Show("Semua data harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            BukaKoneksi()

            ' Cek apakah NIM sudah ada
            Dim cekQuery As String = "SELECT COUNT(*) FROM users WHERE nim = @NIM"
            Dim cekCmd As New SqlCommand(cekQuery, conn)
            cekCmd.Parameters.AddWithValue("@NIM", NIMTextBox.Text.Trim())

            If cekCmd.ExecuteScalar() > 0 Then
                MessageBox.Show("NIM sudah terdaftar!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Hash password sebelum simpan
            Dim hashedPassword As String = HashPassword(PasswordTextBox.Text.Trim())

            ' Query insert
            Dim query As String = "INSERT INTO users (nim, nama, prodi, role, password) VALUES (@NIM, @Nama, @Prodi, @Role, @Password)"
            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@NIM", NIMTextBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Nama", NamaTextBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Prodi", ProdiComboBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Role", RoleComboBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Password", hashedPassword)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Akun berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset input
            NamaTextBox.Clear()
            NIMTextBox.Clear()
            ProdiComboBox.SelectedIndex = -1
            RoleComboBox.SelectedIndex = -1
            PasswordTextBox.Clear()

            ' Refresh datagrid
            TampilData()

        Catch ex As Exception
            MessageBox.Show("Terjadi error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick
        Try
            ' Cegah error saat klik header
            If e.RowIndex < 0 Then Exit Sub

            Dim row As DataGridViewRow = DataGridView.Rows(e.RowIndex)

            NIMTextBox.Text = row.Cells("NIM").Value.ToString()
            NamaTextBox.Text = row.Cells("Nama").Value.ToString()
            ProdiComboBox.Text = row.Cells("Prodi").Value.ToString()
            RoleComboBox.Text = row.Cells("Role").Value.ToString()

            ' Password sengaja dikosongkan untuk keamanan
            PasswordTextBox.Text = ""

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        End Try

        EditButton.Enabled = True
        HapusButton.Enabled = True
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If NIMTextBox.Text.Trim() = "" Then
            MessageBox.Show("Pilih data dari tabel terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If NamaTextBox.Text.Trim() = "" Or
           ProdiComboBox.Text.Trim() = "" Or
           RoleComboBox.Text.Trim() = "" Then

            MessageBox.Show("Nama, Prodi, dan Role tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            BukaKoneksi()

            Dim query As String

            ' Jika passwordTextBox diisi → update password juga
            If PasswordTextBox.Text.Trim() <> "" Then
                Dim hashedPassword As String = HashPassword(PasswordTextBox.Text.Trim())
                query = "UPDATE users SET nama=@Nama, Prodi=@Prodi, Role=@Role, password=@Password WHERE nim=@NIM"
            Else
                ' Jika tidak ada password baru → jangan ubah kolom PasswordHash
                query = "UPDATE users SET nama=@Nama, prodi=@Prodi, role=@Role WHERE nim=@NIM"
            End If

            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@NIM", NIMTextBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Nama", NamaTextBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Prodi", ProdiComboBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Role", RoleComboBox.Text.Trim())

            If PasswordTextBox.Text.Trim() <> "" Then
                cmd.Parameters.AddWithValue("@Password", HashPassword(PasswordTextBox.Text.Trim()))
            End If

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh tabel
            TampilData()

            ' Reset input
            PasswordTextBox.Clear()

        Catch ex As Exception
            MessageBox.Show("Terjadi error saat update: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub HapusButton_Click(sender As Object, e As EventArgs) Handles HapusButton.Click
        ' Pastikan NIM harus terisi
        If NIMTextBox.Text.Trim() = "" Then
            MessageBox.Show("Silakan pilih data dari tabel terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Confirmation dialog
        Dim result As DialogResult = MessageBox.Show(
            "Apakah Anda yakin ingin menghapus data dengan NIM: " & NIMTextBox.Text & "?",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If result = DialogResult.No Then Exit Sub

        Try
            BukaKoneksi()

            Dim query As String = "DELETE FROM users WHERE nim=@NIM"
            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@NIM", NIMTextBox.Text.Trim())

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh DataGridView setelah hapus
            TampilData()

            ' Kosongkan input setelah berhasil delete
            NamaTextBox.Clear()
            NIMTextBox.Clear()
            ProdiComboBox.SelectedIndex = -1
            RoleComboBox.SelectedIndex = -1
            PasswordTextBox.Clear()

        Catch ex As Exception
            MessageBox.Show("Terjadi error saat menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NamaTextBox.Clear()
        NIMTextBox.Clear()
        PasswordTextBox.Clear()

        ProdiComboBox.SelectedIndex = -1
        RoleComboBox.SelectedIndex = -1

        ' Optional: Disable tombol Edit & Hapus setelah clear
        EditButton.Enabled = False
        HapusButton.Enabled = False

        NamaTextBox.Focus()
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

    Private Sub CekHasilButton_Click(sender As Object, e As EventArgs) Handles CekHasilButton.Click
        If NIMTextBox.Text.Trim() = "" Then
            MessageBox.Show("Silakan isi NIM.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            BukaKoneksi()

            Dim query As String = "SELECT COUNT(*) FROM users WHERE nim = @NIM"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@NIM", NIMTextBox.Text.Trim())

            Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If jumlah > 0 Then
                ' NIM ditemukan → pindah form
                NIMMahasiswa = NIMTextBox.Text.Trim()
                NamaMahasiswa = AmbilNama(NIMMahasiswa)
                ProdiMahasiswa = AmbilProdi(NIMMahasiswa)

                HasilMahasiswa.Show()
                Me.Close()
            Else
                MessageBox.Show("NIM tidak terdaftar.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            TutupKoneksi()
        End Try
    End Sub
End Class