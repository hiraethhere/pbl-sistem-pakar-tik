Imports Microsoft.Data.SqlClient
Imports System

Module Hasil

    Public Function SimpanHasil(hasil As List(Of Result))
        ModuleKoneksi.BukaKoneksi()
        Dim query As String = "INSERT INTO hasil (user_id, profil_id, persentase) VALUES (@userId, @profilId, @persentase)"

        For Each item In hasil
            Using cmd As New SqlCommand(query, ModuleKoneksi.conn)
                cmd.Parameters.AddWithValue("@userId", LoggedNIM)
                cmd.Parameters.AddWithValue("@profilId", item.profile)
                cmd.Parameters.AddWithValue("@persentase", item.persentage)
                cmd.ExecuteNonQuery()
            End Using
        Next

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
