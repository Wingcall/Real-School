Public Class frmGame

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sender.text = "Hello World"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sender.text = "Sub"
    End Sub

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUserDB()
    End Sub
End Class