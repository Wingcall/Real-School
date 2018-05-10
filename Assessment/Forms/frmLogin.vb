Public Class frmLogin

    Private Sub lblExit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing
        loadUserDB()
        rdoPlayer1.Text = userInfo(0).name
        rdoPlayer2.Text = userInfo(1).name
        rdoPlayer3.Text = userInfo(2).name
        rdoPlayer4.Text = userInfo(3).name
        lblPlayer0Score.Text = userInfo(0).score
        lblPlayer1Score.Text = userInfo(1).score
        lblPlayer2Score.Text = userInfo(2).score
        lblPlayer3Score.Text = userInfo(3).score
    End Sub

End Class