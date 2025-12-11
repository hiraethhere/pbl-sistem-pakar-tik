Imports Microsoft.Data.SqlClient
Imports System.Text
Imports System.Windows.Forms

Public Module DumpProfilColumns
    Public Sub DumpProfilColumns()
        Try
            ModuleKoneksi.BukaKoneksi()
            Dim sb As New StringBuilder()
            Dim sql As String = "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'profil' ORDER BY ORDINAL_POSITION"
            Using cmd As New SqlCommand(sql, ModuleKoneksi.conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If Not reader.HasRows Then
                        MessageBox.Show("Table 'profil' not found or no columns returned.", "Diagnostics", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    While reader.Read()
                        sb.AppendLine(reader("COLUMN_NAME").ToString() & " (" & reader("DATA_TYPE").ToString() & ")")
                    End While
                End Using
            End Using
            MessageBox.Show(sb.ToString(), "profil columns", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to dump profil columns: " & ex.Message, "Diagnostics", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ModuleKoneksi.TutupKoneksi()
        End Try
    End Sub
End Module