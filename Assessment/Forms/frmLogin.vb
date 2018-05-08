Public Class frmLogin

    Private Sub lblExit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing
    End Sub
End Class