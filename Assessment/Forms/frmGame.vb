Public Class frmGame
    Const maxGuesses As Integer = 7 'Stop yelling at me for magic numbers
    Dim letterGuesses As String = ""
    Dim badGuesses As Integer
    Dim cPlayer As playerInfo = userInfo(playerID)


    Private Sub checkLetter(letter As String)
        If plrWord.wordVal.Contains(letter) Then
            letterGuesses += letter
            lblHyphen.Text = plrWord.hyphenWord(letterGuesses)
            If plrWord.correct(lblHyphen.Text) Then
                pnlLetters.Enabled = False
                userInfo(playerID).score += 1
                lblScore.Text = userInfo(playerID).score
                updateUserXML()
                winLose(True)
            End If
        Else
            If badGuesses > 0 Then picHangman.Image = ilsHangmen.Images(badGuesses - 1)
            badGuesses -= 1
            If badGuesses <= 0 Then
                pnlLetters.Enabled = False
                winLose(False)
                'Exit Sub
            End If
        End If
    End Sub

    Private Sub reset()
        picHangman.Image = Nothing
        lblHyphen.Text = ""
        lblHint.Text = ""
        lblScore.Text = cPlayer.score

        btnForfeit.Enabled = False
    End Sub

    Private Sub winLose(win As Boolean)
        Dim message, title As String
        If win Then
            title = "Congratulations!"
            message = "Well done, " & cPlayer.name & "! You guessed the word was " & plrWord.wordValOrig & "." & vbNewLine & "Would you like to try again?"
        Else
            title = "Good Try!"
            message = "To Bad, " & cPlayer.name & "! You didn't guess the word. :(" & vbNewLine & "Would you like to try again?"
        End If
        Dim res As MsgBoxResult = MsgBox(message, MsgBoxStyle.YesNo, title)
        If res = MsgBoxResult.Yes Then frmGame_Load(Me, Nothing) : Exit Sub Else btnNewGame.Enabled = True
        reset()
    End Sub

    Private Sub colourChangeP(sender As Label, e As EventArgs)
        sender.ForeColor = Color.MediumOrchid
    End Sub
    Private Sub colourChangeB(sender As Label, e As EventArgs)
        sender.ForeColor = Color.Black
    End Sub

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnNewGame.Click
        'loadDB()
        If sender.name = "frmGame" Then AddHandler Me.FormClosing, AddressOf formEvents.FormClosing
        Me.KeyPreview = True
        btnNewGame.Enabled = False
        btnForfeit.Enabled = True

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
                AddHandler Letter.MouseHover, AddressOf Me.colourChangeP
                AddHandler Letter.MouseLeave, AddressOf Me.colourChangeB
            End If
            Letter.Enabled = True
        Next

    End Sub

    Private Sub lblLetterS_Click(sender As Label, e As EventArgs)
        sender.Enabled = False
        checkLetter(sender.Text)
    End Sub

    Private Sub frmGame_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim upperKey As String = e.KeyChar.ToString.ToUpper
        Dim letterLabel As Label = pnlLetters.Controls("lblLetter" & upperKey)
        If IsNothing(letterLabel) Then Exit Sub
        If alphabet.Contains(upperKey) And letterLabel.Enabled Then
            letterLabel.Enabled = False
            checkLetter(upperKey)
        End If
    End Sub

    Private Sub btnForfeit_Click(sender As Object, e As EventArgs) Handles btnForfeit.Click
        btnForfeit.Enabled = False
        Dim message = "Hey " & cPlayer.name & ", Are you sure you wish to forfit?" & vbNewLine & "You will lose a point!"
        Dim res As MsgBoxResult = MsgBox(message, MsgBoxStyle.YesNo, "Your Loss.")
        If res = MsgBoxResult.Yes Then
            If userInfo(playerID).score > 0 Then userInfo(playerID).score -= 1
            frmGame_Load(Me, Nothing)
        Else : btnNewGame.Enabled = True
        End If
    End Sub
End Class