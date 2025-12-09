Imports Microsoft.Data.SqlClient

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

End Module
