Public Class frmCategories

    Private Sub lblHome_Click(sender As Object, e As EventArgs)
        frmMain.Show()          'Display the Main Menu Form
        Me.Close()              'Closes the Categories Form
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs)
        End                     'Ends the Hangman Program
    End Sub

    Private Sub frmCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing
    End Sub
End Class