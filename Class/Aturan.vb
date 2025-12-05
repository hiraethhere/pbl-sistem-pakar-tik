Public Class Aturan
    Public Property ID As String
    Public Property Gejala As List(Of Pertanyaan)
    Public Property profile As String
    Public Property CF As Double

    Public Sub New(id As String, gejalaList As List(Of Pertanyaan), profil As String, nilaiCF As Double)
        Me.ID = id
        Me.Gejala = gejalaList
        Me.profile = profil
        Me.CF = nilaiCF
    End Sub
End Class
