Public Class frmCategories

    Private Sub frmCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing
    End Sub

    Private Sub picBiology_Click(sender As Object, e As EventArgs) Handles picBiology.Click, picChemistry.Click, picPhysics.Click
        catID = sender.tag      'Sets the Global CatID to the Tag Number
        lblTag.Text = catID     'Tests that the tag is being set by displaying the label
        frmGame.Show()
        Me.closeForm()
    End Sub
End Class