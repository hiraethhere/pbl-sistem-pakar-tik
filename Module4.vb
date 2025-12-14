Imports Microsoft.Data.SqlClient
Imports System

Module Hasil

    Public Function SimpanHasil(hasil As List(Of Result))
        ' 1. Guard Clause: Cek apakah ada hasil yang mau disimpan
        If hasil Is Nothing OrElse hasil.Count = 0 Then
            Return Nothing ' Tidak ada data, keluar.
        End If

        ModuleKoneksi.BukaKoneksi()
        Dim transaction As SqlTransaction = Nothing

        Try
            ' Mulai Transaksi (Supaya proses HAPUS dan SIMPAN jadi satu paket)
            transaction = ModuleKoneksi.conn.BeginTransaction()

            ' ==========================================
            ' LANGKAH 1: BERSIHKAN DATA LAMA (DELETE)
            ' ==========================================
            ' Kita tidak perlu checkHasil() untuk dapat ID satu per satu.
            ' Langsung hapus semua milik user ini.
            Dim queryDelete As String = "DELETE FROM hasil WHERE user_id = @userId"
            Using cmdDelete As New SqlCommand(queryDelete, ModuleKoneksi.conn, transaction)
                cmdDelete.Parameters.AddWithValue("@userId", NIMMahasiswa)
                cmdDelete.ExecuteNonQuery()
            End Using

            ' ==========================================
            ' LANGKAH 2: SIMPAN DATA BARU (INSERT)
            ' ==========================================
            Dim queryInsert As String = "INSERT INTO hasil (user_id, profil_id, persentase) VALUES (@userId, @profilId, @persentase)"

            For Each item In hasil
                Using cmdInsert As New SqlCommand(queryInsert, ModuleKoneksi.conn, transaction)
                    cmdInsert.Parameters.AddWithValue("@userId", NIMMahasiswa)
                    cmdInsert.Parameters.AddWithValue("@profilId", item.profile)
                    cmdInsert.Parameters.AddWithValue("@persentase", item.persentage)
                    cmdInsert.ExecuteNonQuery()
                End Using
            Next

            ' Jika sampai sini lancar, Simpan Permanen
            transaction.Commit()

        Catch ex As Exception
            ' Jika ada error di tengah jalan, batalkan penghapusan tadi (Rollback)
            ' Data lama user akan kembali aman seolah tidak terjadi apa-apa
            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If
            ' Lempar error biar ketahuan (atau tampilkan MessageBox)
            Throw ex
        End Try

    End Function

    Public Function checkHasil(nim As String) As List(Of Integer)
        ModuleKoneksi.BukaKoneksi()

        ' PERBAIKAN 1: Gunakan 'New' agar list siap dipakai (bukan Nothing)
        Dim result As New List(Of Integer)()

        Dim query As String = "SELECT id FROM hasil WHERE user_id = @nim"

        Using cmd As New SqlCommand(query, ModuleKoneksi.conn)
            cmd.Parameters.AddWithValue("@nim", nim)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ' PERBAIKAN 2: Gunakan .Add() untuk memasukkan data ke list
                    ' PERBAIKAN 3: Konversi eksplisit (CInt) agar tipe data aman
                    result.Add(CInt(reader("id")))
                End While
            End Using
        End Using

        ' Function ini sekarang PASTI mengembalikan List.
        ' Bisa list kosong (Count = 0) atau berisi data, tapi TIDAK AKAN 'Nothing'.
        Return result
    End Function

    Public Function AmbilHasilTerakhir(nim As String) As List(Of Tuple(Of String, Double)) ' Returns List(Of (ProfileCode, Percentage))
        Dim results As New List(Of Tuple(Of String, Double))
        ModuleKoneksi.BukaKoneksi()

        ' Mengambil 3 hasil teratas berdasarkan persentase untuk user
        ' Asumsi: persentase sudah disimpan sebagai Double * 100 (misal: 98.0)
        Dim query As String = "SELECT TOP 3 profil_id, persentase FROM hasil WHERE user_id = @NIM ORDER BY persentase DESC"

        Using cmd As New SqlCommand(query, ModuleKoneksi.conn)
            cmd.Parameters.AddWithValue("@NIM", nim)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim profileCode As String = reader("profil_id").ToString()
                    Dim percentage As Double = Convert.ToDouble(reader("persentase"))
                    results.Add(New Tuple(Of String, Double)(profileCode, percentage))
                End While
            End Using
        End Using

        ModuleKoneksi.TutupKoneksi()

        Return results
    End Function

End Module
