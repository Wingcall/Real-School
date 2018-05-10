Public Class playerInfo
    Public id As Int16
    Public name As String
    Public score As Integer

    Public Sub New(pInfo As Array)
        id = pInfo(0)
        name = pInfo(1)
        score = pInfo(2)
    End Sub

    Public Sub updateName(inName As String)
        name = inName
    End Sub

    Public Sub del()
        name = "New Player!"
        score = 0
    End Sub
End Class
