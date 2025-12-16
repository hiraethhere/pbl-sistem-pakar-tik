' ModuleKoneksi.vb
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Module ModuleKoneksi

    ' Ganti string koneksi ini sesuai dengan database Anda
    Public conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sunez\OneDrive\Documents\kuliah\semester3\Visual Studio\project\pbl-sistem-pakar\Database1.mdf;Integrated Security=True")

    Public Sub BukaKoneksi()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Sub TutupKoneksi()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

End Module