' ModuleKoneksi.vb
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Module ModuleKoneksi

    ' Ganti string koneksi ini sesuai dengan database Anda
<<<<<<< HEAD
    Public conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sunez\OneDrive\Documents\kuliah\semester3\Visual Studio\project\pbl-sistem-pakar\Database1.mdf;Integrated Security=True")
=======
    Public conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Farrel\PROJECTS\pbl-sistem-pakar-tik\Database1.mdf;Integrated Security=True")
>>>>>>> f10c9f6cd191a0d883f69c5c84358e33c877bcda

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