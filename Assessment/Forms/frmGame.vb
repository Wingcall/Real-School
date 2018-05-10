Public Class frmGame
    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnLoadButton.Click
        loadDB()
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing

        plrWord = wordLists(catID).randomWord()
        lblWord.Text = plrWord.word
        lblHint.Text = plrWord.hint
        lblCat.Text = wordLists(catID).name
        lblName.Text = userInfo(playerID).name
        lblScore.Text = userInfo(playerID).score

    End Sub

End Class