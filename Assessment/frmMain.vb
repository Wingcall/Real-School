Public Class frmMain
    'Bla bla comments add later

    Private Sub lblPlay_Click(sender As Object, e As EventArgs) Handles lblPlay.Click
        frmLogin.Show()         'Displays the Login Form
        Me.Hide()               'Hides the Main Menu Form
    End Sub

    Private Sub lblHelp_Click(sender As Object, e As EventArgs) Handles lblHelp.Click
        frmHelp.Show()              'Displays the Help Form
        Me.Hide()                   'Hides the Main Menu Form
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        End                         'Closes the Hangman Game
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmCategories.Show()        'Testing purposes, REMOVE WHEN DONE
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmLogin.Show()             'testing purposes, REMOVE WHEN DONE
    End Sub

    Private Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        frmGame.Show()
    End Sub
End Class