Public Class Result
    Public Property value As Double
    Public Property profile As String
    Public Property persentage As Double
    Public Sub New(kode As String, nilai As Double)
        Me.profile = kode
        Me.value = nilai
        Me.persentage = nilai * 100
    End Sub
End Class