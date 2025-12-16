Imports System.Windows.Forms
Imports Microsoft.Data.SqlClient
Imports System.Text

Public Class FormHasil

    Public Sub New(ByVal results As List(Of Result))
        InitializeComponent()

        Me.Text = "Hasil Profil Lulusan"

        Dim top1ProfileName As String = ""
        Dim top1CFValue As Double = 0.0


        Dim top3Detail As New System.Text.StringBuilder()
        top3Detail.AppendLine("Top 3 Rekomendasi Profil:")
        top3Detail.AppendLine("-------------------------")

        Dim ranking As Integer = 1
        For Each item In results
            Dim profileName As String = AmbilNamaProfil(item.profile)
            Dim persentase As String = (item.persentage).ToString("0.##") & "%"

            top3Detail.AppendLine($"{ranking}. {profileName} ({persentase})")

            If ranking = 1 Then
                top1ProfileName = profileName
                top1CFValue = item.value
            End If

            ranking += 1
        Next

        lblProfil.Text = top1ProfileName

        lblNilaiCF.Text = $"Tingkat Keyakinan Sistem (CF) Top 1: {Math.Round(top1CFValue, 3):0.000}" & vbCrLf & vbCrLf & top3Detail.ToString()

        btnTestLagi.Text = "Kembali ke Dashboard"
        btnKeluarAplikasi.Text = "Logout"
    End Sub

    Private Function AmbilNamaProfil(kode As String) As String
        Dim namaProfil As String = kode
        Try
            ModuleKoneksi.BukaKoneksi()

            Dim query As String = "SELECT profil FROM profil WHERE kode = @Kode"
            Using cmd As New SqlCommand(query, ModuleKoneksi.conn)
                cmd.Parameters.AddWithValue("@Kode", kode)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    namaProfil = result.ToString()
                End If
            End Using
        Catch ex As Exception

        Finally
            ModuleKoneksi.TutupKoneksi()
        End Try
        Return namaProfil
    End Function

    Private Sub btnTestLagi_Click(sender As Object, e As EventArgs) Handles btnTestLagi.Click

        Dim formDashboardMahasiswa As New DashboardMahasiswa()
        formDashboardMahasiswa.Show()
        Me.Close()
    End Sub


    Private Sub btnKeluarAplikasi_Click(sender As Object, e As EventArgs) Handles btnKeluarAplikasi.Click
        If MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


            NIMMahasiswa = Nothing
            NamaMahasiswa = Nothing
            ProdiMahasiswa = Nothing


            Dim formDashboard As New FormDashboard()
            formDashboard.Show()
            Me.Close()
        End If
    End Sub

End Class