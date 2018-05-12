Public Class frmGame
    Dim localScore

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnLoadButton.Click
        loadDB()
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing

        plrWord = wordLists(catID).randomWord()
        lblWord.Text = plrWord.wordVal
        lblHint.Text = plrWord.hint
        lblCat.Text = wordLists(catID).name
        lblName.Text = userInfo(playerID).name
        lblScore.Text = userInfo(playerID).score
        lblHyphen.Text = plrWord.hyphenWord("BIl")

    End Sub

    Private Sub lblLetterS_Click(sender As Object, e As EventArgs) Handles lblLetterA.Click, lblLetterC.Click, lblLetterD.Click

    End Sub
End Class