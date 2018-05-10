Public Class frmGame

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        sender.text = getRWord(0).word
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        sender.text = getWord(0, 0).word
    End Sub

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDB()
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing
    End Sub
End Class