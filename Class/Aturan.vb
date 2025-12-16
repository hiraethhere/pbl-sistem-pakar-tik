Public Class Aturan
    Public Property ID As String
    Public Property profile As String
    Public Property CF As Double
    Public Property userInputIdx As Integer()
    Public Property Input As List(Of Input)

    Public Sub New(id As String, profil As String, nilaiCF As Double, input As List(Of Input), ParamArray idx() As Integer)
        Me.ID = id
        Me.profile = profil
        Me.CF = nilaiCF
        Me.Input = input
        Me.userInputIdx = idx
    End Sub

    Public Function hitungCF() As Double
        Dim minUserCF As Double = 1.0
        For Each index In userInputIdx
            If Input(index).value <= minUserCF Then
                minUserCF = Input(index).value
            End If
        Next
        Dim result As Double = Me.CF * minUserCF
        Return result
    End Function
End Class