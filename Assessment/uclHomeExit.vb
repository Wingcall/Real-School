Public Class uclHomeExit

    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click
        frmMain.Show() 'Show the main form
        sender.Parent.Parent.close() 'Close the Current Form
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        exitGame(sender.Parent.Parent)
    End Sub
End Class
