Public Class frmDebug

    Private Sub btnPlayer1_Click(sender As Object, e As EventArgs) Handles btnPlayer1.Click, btnPlayer2.Click
        'loadUserDB()

        lblName.Text = sender.Tag
    End Sub
End Class