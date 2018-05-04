Public Class frmCategories

    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click
        frmMain.Show()          'Display the Main Menu Form
        Me.Close()              'Closes the Categories Form
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        End                     'Ends the Hangman Program
    End Sub
End Class