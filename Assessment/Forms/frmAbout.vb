Public Class frmAbout

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing
    End Sub

    Private Sub lblBTitle_Click(sender As Object, e As EventArgs) Handles lblBTitle.Click

    End Sub
End Class