'Completed By Cal.W 2018
Public Class uclHomeExit

    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click 'Home label clicked
        frmMain.Show() 'Show the main form
        Dim pForm As Form = sender.Parent.Parent 'Store the current form
        RemoveHandler pForm.FormClosing, AddressOf formEvents.FormClosing 'Remove the custom close event for the current form
        pForm.Close() 'Close the Current Form
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click 'Exit Label clicked
        exitGame(sender.Parent.Parent) 'Call the exit function
    End Sub
End Class
