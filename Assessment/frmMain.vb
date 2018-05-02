Public Class frmMain
    'Bla bla comments add later

    Private Sub lblPlay_Click(sender As Object, e As EventArgs) Handles lblPlay.Click
        frmLogin.Show()         'Displays the Login Form
        Me.Hide()               'Hides the Main Menu Form
    End Sub
End Class