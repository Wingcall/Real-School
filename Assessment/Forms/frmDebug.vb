Public Class frmDebug

    Private Sub btnPlayer1_Click(sender As Object, e As EventArgs) Handles btnPlayer1.Click, btnPlayer2.Click
        loadUserDB()
        lblName.Text = userInfo(Int(sender.Tag)).name
        lblScore.Text = userInfo(Int(sender.Tag)).score
        'lblName.Text = sender.Tag
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        exitGame1(Me)
    End Sub
End Class