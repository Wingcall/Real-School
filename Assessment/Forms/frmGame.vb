Public Class frmGame
    Const maxGuesses As Integer = 7 'Stop yelling at me for magic numbers
    Dim letterGuesses As String = ""
    Dim badGuesses As Integer
    Dim cPlayer As playerInfo = userInfo(playerID)

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnLoadButton.Click
        loadDB()
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing

        picHangman.SizeMode = PictureBoxSizeMode.Normal
        picHangman.Image = Nothing

        letterGuesses = ""
        badGuesses = maxGuesses

        plrWord = wordLists(catID).randomWord()
        lblHint.Text = plrWord.hint
        lblCat.Text = wordLists(catID).name
        lblName.Text = cPlayer.name
        lblScore.Text = cPlayer.score
        lblHyphen.Text = plrWord.hyphenWord()

        pnlLetters.Enabled = True
        For Each Letter As Label In pnlLetters.Controls
            If sender.name = "frmGame" Then
                AddHandler Letter.Click, AddressOf Me.lblLetterS_Click
                AddHandler Letter.MouseHover, AddressOf Me.colourChange
                AddHandler Letter.MouseLeave, AddressOf Me.colourChange
            End If
            Letter.Enabled = True
        Next

    End Sub

    Private Sub colourChange(sender As Label, e As EventArgs)
        If sender.ForeColor = Color.MediumOrchid Then
            sender.ForeColor = Color.Black
        Else
            sender.ForeColor = Color.MediumOrchid
        End If
    End Sub

    Private Sub lblLetterS_Click(sender As Label, e As EventArgs)
        sender.Enabled = False
        If plrWord.wordVal.Contains(sender.Text) Then
            letterGuesses += sender.Text
            lblHyphen.Text = plrWord.hyphenWord(letterGuesses)
            If Not lblHyphen.Text.Contains("-") Then
                pnlLetters.Enabled = False
                userInfo(playerID).score += 1
                lblScore.Text = userInfo(playerID).score
                updateUserXML()
                Dim winText As String = "Well done " & cPlayer.name & "! You guessed the word was " & plrWord.wordVal & ". Would you like to try again?"
                Dim res As MsgBoxResult = MsgBox(winText, MsgBoxStyle.Question, "Congrats")
            End If
        Else
            If badGuesses > 0 Then picHangman.Image = ilsHangmen.Images(badGuesses - 1)
            badGuesses -= 1
            If badGuesses <= 0 Then
                pnlLetters.Enabled = False
                MsgBox("Game Lost! :(")
                Exit Sub
            End If
        End If
    End Sub
End Class