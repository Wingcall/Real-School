Public Class frmGame
    Dim maxGuesses As Integer = 7
    Dim letterGuesses As String = ""
    Dim badGuesses As Integer

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnLoadButton.Click
        loadDB()
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing

        picHangman.SizeMode = PictureBoxSizeMode.Normal
        picHangman.Image = Nothing

        letterGuesses = ""
        badGuesses = maxGuesses

        plrWord = wordLists(catID).randomWord()
        lblWord.Text = plrWord.wordVal
        lblHint.Text = plrWord.hint
        lblCat.Text = wordLists(catID).name
        lblName.Text = userInfo(playerID).name
        lblScore.Text = userInfo(playerID).score
        lblHyphen.Text = plrWord.hyphenWord()

        pnlLetters.Enabled = True
        For Each Letter As Label In pnlLetters.Controls
            If sender.name = "frmGame" Then
                AddHandler Letter.Click, AddressOf Me.lblLetterS_Click
            End If
            Letter.Enabled = True
        Next

    End Sub

    Private Sub lblLetterS_Click(sender As Label, e As EventArgs)
        sender.Enabled = False
        If plrWord.wordVal.Contains(sender.Text) Then
            letterGuesses += sender.Text
            lblHyphen.Text = plrWord.hyphenWord(letterGuesses)
            If Not lblHyphen.Text.Contains("-") Then
                pnlLetters.Enabled = False
                MsgBox("Game Win!")
            End If
        Else
            If badGuesses > 0 Then picHangman.Image = ilsHangmen.Images(badGuesses - 1)
            badGuesses -= 1
            If badGuesses <= 0 Then
                pnlLetters.Enabled = False
                MsgBox("Game Lost")
                Exit Sub
            End If
        End If
    End Sub
End Class