Imports Microsoft.Data.SqlClient
Imports System

Module Hasil
    Public Function SimpanHasil(hasil As List(Of Result))
        If hasil Is Nothing OrElse hasil.Count = 0 Then
            Return Nothing
        End If

        ModuleKoneksi.BukaKoneksi()
        Dim transaction As SqlTransaction = Nothing

        Try
            transaction = ModuleKoneksi.conn.BeginTransaction()

            Dim queryDelete As String = "DELETE FROM hasil WHERE user_id = @userId"
            Using cmdDelete As New SqlCommand(queryDelete, ModuleKoneksi.conn, transaction)
                cmdDelete.Parameters.AddWithValue("@userId", NIMMahasiswa)
                cmdDelete.ExecuteNonQuery()
            End Using

            Dim queryInsert As String = "INSERT INTO hasil (user_id, profil_id, persentase) VALUES (@userId, @profilId, @persentase)"

            For Each item In hasil
                Using cmdInsert As New SqlCommand(queryInsert, ModuleKoneksi.conn, transaction)
                    cmdInsert.Parameters.AddWithValue("@userId", NIMMahasiswa)
                    cmdInsert.Parameters.AddWithValue("@profilId", item.profile)
                    cmdInsert.Parameters.AddWithValue("@persentase", item.persentage)
                    cmdInsert.ExecuteNonQuery()
                End Using
            Next

            transaction.Commit()
        Catch ex As Exception
            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If
            Throw ex
        End Try
    End Function

    Public Function checkHasil(nim As String) As List(Of Integer)
        ModuleKoneksi.BukaKoneksi()

        Dim result As New List(Of Integer)()

        Dim query As String = "SELECT id FROM hasil WHERE user_id = @nim"

        Using cmd As New SqlCommand(query, ModuleKoneksi.conn)
            cmd.Parameters.AddWithValue("@nim", nim)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    result.Add(CInt(reader("id")))
                End While
            End Using
        End Using
        Return result
    End Function

    Public Function AmbilHasilTerakhir(nim As String) As List(Of Tuple(Of String, Double))
        Dim results As New List(Of Tuple(Of String, Double))
        ModuleKoneksi.BukaKoneksi()

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