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

    Private Sub picBiology_Click(sender As Object, e As EventArgs) Handles picBiology.Click, picChemistry.Click, picPhysics.Click
        catID = sender.tag      'Sets the Global CatID to the Tag Number
        lblTag.Text = catID     'Tests that the tag is being set by displaying the label
        frmGame.Show()
        Me.Hide()
    End Sub

    Private Sub lblBiology_Click(sender As Object, e As EventArgs) Handles lblBiology.Click, lblChemistry.Click, lblPhysics.Click
        catID = sender.tag
        lblTag.Text = catID
        frmGame.Show()
        Me.Hide()
    End Sub
End Class