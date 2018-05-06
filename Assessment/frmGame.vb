Public Class frmGame

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sender.text = getRWord(0).word
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sender.text = getWord(0, 0)
    End Sub

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDB()
    End Sub
End Class