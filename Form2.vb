' FormPertanyaanCF.vb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics.X86
Imports Microsoft.Data.SqlClient

Public Class FormPertanyaanCF

    Dim jawabanCF As New List(Of Input)
    Dim dtPertanyaan As New DataTable
    Dim indexPertanyaan As Integer = 1
    Dim NamaMhs As String
    Dim kode As String
    Dim TotalDetik As Integer = 30 * 60

    Public Sub New(ByVal nama As String)
        InitializeComponent()
        NamaMhs = nama
    End Sub

    Private Sub FormPertanyaanCF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNamaMhs.Text = "Nama: " & NamaMhs


        ModuleKoneksi.BukaKoneksi()
        Dim da As New SqlDataAdapter("SELECT * FROM pertanyaan ORDER BY id", ModuleKoneksi.conn)
        da.Fill(dtPertanyaan)
        ModuleKoneksi.TutupKoneksi()

        TampilkanPertanyaan()
        TimerUjian.Start()
    End Sub

    Private Sub TimerUjian_Tick(sender As Object, e As EventArgs) Handles TimerUjian.Tick
        TotalDetik -= 1


        Dim menit As Integer = TotalDetik \ 60
        Dim detik As Integer = TotalDetik Mod 60

        lblWaktu.Text = $"Waktu Tersisa: {menit:D2}:{detik:D2}"

        If TotalDetik <= 0 Then
            TimerUjian.Stop()
            MessageBox.Show("Waktu pengerjaan telah habis! Anda akan dikembalikan ke Dashboard.", "Waktu Habis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


            Dim formDashboard As New FormDashboard()
            formDashboard.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FormPertanyaanCF_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TimerUjian.Stop()
    End Sub


    Sub TampilkanPertanyaan()
        If indexPertanyaan <= dtPertanyaan.Rows.Count() Then
            Dim row As DataRow = dtPertanyaan.Rows(indexPertanyaan - 1)
            lblNoSoal.Text = "Pertanyaan ke-" & indexPertanyaan
            lblPertanyaan.Text = row("pertanyaan").ToString()
            kode = row("id")


            rbA.Checked = False : rbB.Checked = False : rbC.Checked = False
            rbD.Checked = False : rbE.Checked = False
        Else

            ProsesCertaintyFactor()
        End If
    End Sub


    Private Sub btnLanjut_Click(sender As Object, e As EventArgs) Handles btnLanjut.Click

        Dim nilaiCFUser As Double = 0.0

        If rbE.Checked Then
            nilaiCFUser = 1.0
        ElseIf rbD.Checked Then
            nilaiCFUser = 0.8
        ElseIf rbC.Checked Then
            nilaiCFUser = 0.6
        ElseIf rbB.Checked Then
            nilaiCFUser = 0.4
        ElseIf rbA.Checked Then
            nilaiCFUser = 0.0
        Else
            MessageBox.Show("Anda harus memilih salah satu jawaban.", "Peringatan")
            Exit Sub
        End If


        jawabanCF.Add(New Input(kode, nilaiCFUser))


        indexPertanyaan += 1
        ResetRadioButtonColors()
        TampilkanPertanyaan()
    End Sub

    Sub ProsesCertaintyFactor()
        TimerUjian.Stop()

        Dim listOfRules As New List(Of Aturan) From {
            New Aturan("R01", "P01", 0.98, jawabanCF, 0, 1, 4, 10, 12, 16),
            New Aturan("R02", "P01", 0.95, jawabanCF, 0, 1, 4, 12),
            New Aturan("R03", "P01", 0.88, jawabanCF, 0, 1, 4),
            New Aturan("R04", "P01", 0.8, jawabanCF, 0, 3, 4),
            New Aturan("R05", "P02", 0.98, jawabanCF, 0, 2, 3, 15, 18, 20),
            New Aturan("R06", "P02", 0.9, jawabanCF, 2, 3, 4, 18, 20),
            New Aturan("R07", "P02", 0.85, jawabanCF, 2, 3, 4, 15),
            New Aturan("R08", "P02", 0.8, jawabanCF, 3, 14, 15, 20),
            New Aturan("R09", "P03", 0.98, jawabanCF, 4, 5, 14),
            New Aturan("R10", "P03", 0.92, jawabanCF, 3, 4, 5),
            New Aturan("R11", "P03", 0.85, jawabanCF, 5, 14),
            New Aturan("R12", "P03", 0.8, jawabanCF, 3, 4),
            New Aturan("R13", "P04", 0.98, jawabanCF, 6, 7, 21, 0),
            New Aturan("R14", "P04", 0.9, jawabanCF,
            6, 7, 0),
            New Aturan("R15", "P04", 0.85, jawabanCF, 6, 7, 12),
            New Aturan("R16", "P04", 0.82, jawabanCF, 7, 21),
            New Aturan("R17", "P05", 0.98, jawabanCF, 8, 9, 12, 13, 17),
            New Aturan("R18", "P05", 0.92, jawabanCF, 8, 9, 17),
            New Aturan("R19", "P05", 0.86, jawabanCF, 8, 9, 13),
            New Aturan("R20", "P05", 0.8, jawabanCF, 9, 12),
            New Aturan("R21", "P06", 0.98, jawabanCF, 10, 11, 12, 13, 17, 19),
            New Aturan("R22", "P06", 0.94, jawabanCF, 10, 11, 17, 19),
            New Aturan("R23", "P06", 0.85, jawabanCF, 10, 11, 12, 19),
            New Aturan("R24", "P06", 0.8, jawabanCF, 10, 11, 12, 13)
       }

        Dim result As List(Of Result) = HitungHasil(listOfRules)

        Dim formHasil As New FormHasil(result)
        formHasil.Show()

        Me.Close()
    End Sub

    Function HitungHasil(listOfRules As List(Of Aturan)) As List(Of Result)
        Dim CF_P01, CF_P02, CF_P03, CF_P04, CF_P05, CF_P06 As Double
        CF_P01 = 0 : CF_P02 = 0 : CF_P03 = 0 : CF_P04 = 0 : CF_P05 = 0 : CF_P06 = 0

        For Each item In listOfRules
            Dim currentCF As Double = item.hitungCF()
            If currentCF > 0 Then
                Select Case item.profile.ToString()
                    Case "P01"
                        CF_P01 = combineCF(CF_P01, currentCF)
                    Case "P02"
                        CF_P02 = combineCF(CF_P02, currentCF)
                    Case "P03"
                        CF_P03 = combineCF(CF_P03, currentCF)
                    Case "P04"
                        CF_P04 = combineCF(CF_P04, currentCF)
                    Case "P05"
                        CF_P05 = combineCF(CF_P05, currentCF)
                    Case "P06"
                        CF_P06 = combineCF(CF_P06, currentCF)
                End Select
            End If
        Next

        Dim hasilAkhir As New List(Of Result)

        hasilAkhir.Add(New Result("P01", CF_P01))
        hasilAkhir.Add(New Result("P02", CF_P02))
        hasilAkhir.Add(New Result("P03", CF_P03))
        hasilAkhir.Add(New Result("P04", CF_P04))
        hasilAkhir.Add(New Result("P05", CF_P05))
        hasilAkhir.Add(New Result("P06", CF_P06))


        hasilAkhir.Sort(Function(x, y) y.value.CompareTo(x.value))
        Dim top3 As List(Of Result) = hasilAkhir.Take(3).ToList()
        Hasil.SimpanHasil(top3)
        Return top3
    End Function

    Function combineCF(oldValue As Double, newValue As Double) As Double
        Return oldValue + newValue * (1.0 - oldValue)
    End Function


    Private ReadOnly HoverColor_A As Color = Color.FromArgb(255, 150, 150)
    Private ReadOnly HoverColor_B As Color = Color.FromArgb(150, 204, 204)
    Private ReadOnly HoverColor_C As Color = Color.FromArgb(180, 180, 255)
    Private ReadOnly HoverColor_D As Color = Color.FromArgb(100, 150, 230)
    Private ReadOnly HoverColor_E As Color = Color.FromArgb(100, 200, 100)
    Private Sub RadioButton_MouseEnter(sender As Object, e As EventArgs) Handles rbA.MouseEnter, rbB.MouseEnter, rbC.MouseEnter, rbD.MouseEnter, rbE.MouseEnter
        Dim rb As RadioButton = CType(sender, RadioButton)

        If Not rb.Checked Then
            Select Case rb.Name
                Case "rbA" : rb.BackColor = HoverColor_A
                Case "rbB" : rb.BackColor = HoverColor_B
                Case "rbC" : rb.BackColor = HoverColor_C
                Case "rbD" : rb.BackColor = HoverColor_D
                Case "rbE" : rb.BackColor = HoverColor_E
            End Select
        End If
    End Sub

    Private Sub RadioButton_MouseLeave(sender As Object, e As EventArgs) Handles rbA.MouseLeave, rbB.MouseLeave, rbC.MouseLeave, rbD.MouseLeave, rbE.MouseLeave
        Dim rb As RadioButton = CType(sender, RadioButton)

        If Not rb.Checked Then
            Select Case rb.Name
                Case "rbA" : rb.BackColor = SystemColors.ControlLight
                Case "rbB" : rb.BackColor = SystemColors.GradientInactiveCaption
                Case "rbC" : rb.BackColor = SystemColors.InactiveCaption
                Case "rbD" : rb.BackColor = SystemColors.GradientActiveCaption
                Case "rbE" : rb.BackColor = Color.FromArgb(192, 255, 192)
                Case Else : rb.BackColor = SystemColors.Control
            End Select
        End If
    End Sub

    Private Sub ResetRadioButtonColors()
        Dim rbs() As RadioButton = {rbA, rbB, rbC, rbD, rbE}

        For Each rb As RadioButton In rbs

            rb.Checked = False
            RadioButton_MouseLeave(rb, EventArgs.Empty)
        Next
    End Sub

End Class