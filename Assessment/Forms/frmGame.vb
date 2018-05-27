Public Class frmGame
    Const maxGuesses As Integer = 7 'lock the max number of guesses
    Dim letterGuesses As String = "" 'The letter that the player has guessed
    Dim badGuesses As Integer 'Number of bad guesses
    Dim cPlayer As playerInfo = userInfo(playerID) 'current player


    Private Sub checkLetter(letter As String) 'Check the letter is in the selected word (correct guess)
        If plrWord.wordVal.Contains(letter) Then 'if the letter is in the wordd
            letterGuesses += letter 'add the letter to the guess string
            lblHyphen.Text = plrWord.hyphenWord(letterGuesses) 'set the hyphen label text to the hyphenString of the word
            If plrWord.correct(lblHyphen.Text) Then 'If the word has no more guess hyphens
                pnlLetters.Enabled = False 'disable the letter pannel
                userInfo(playerID).score += 1 'add one to the score
                lblScore.Text = userInfo(playerID).score 'update the score label text
                updateUserXML() ' update the user xmlDB
                winLose(True) 'call the win game function
            End If
        Else 'incorrect guess
            If badGuesses > 0 Then picHangman.Image = ilsHangmen.Images(badGuesses - 1) 'if the bad guess int is above 0 set the imageBox to the correct image
            badGuesses -= 1 'take one from the badGuess Var
            If badGuesses <= 0 Then 'If it is equal or less then 0 then the game is lost.
                pnlLetters.Enabled = False 'disable the letter panel
                winLose(False) 'call the lose game function
                'Exit Sub
            End If
        End If
    End Sub

    Private Sub reset() 'reset the game form to empty
        picHangman.Image = Nothing 'clear the hangman image
        lblHyphen.Text = "" 'clear the hyphen text
        lblHint.Text = "" 'clear the hint
        lblScore.Text = cPlayer.score 'Update the player score

        btnForfeit.Enabled = False 'disable the forfeit button
    End Sub

    Private Sub winLose(win As Boolean) 'Win/Lose
        Dim message, title As String 'create some strings
        title = "Divisions of Science"
        If win Then 'If we win
            message = "Well done, " & cPlayer.name & "! You guessed the word was " & plrWord.wordVal & "." & vbNewLine & "Would you like to try again?" 'Win message
        Else
            message = "To Bad, " & cPlayer.name & "! You didn't guess the word. :(" & vbNewLine & "Would you like to try again?" 'lose message
        End If
        Dim res As MsgBoxResult = MsgBox(message, MsgBoxStyle.YesNo, title) 'Ask the user to replay
        If res = MsgBoxResult.Yes Then frmGame_Load(Me, Nothing) : Exit Sub Else btnNewGame.Enabled = True 'If the user wants to replay then reload else enable the reload button
        reset() 'reset
    End Sub

    Private Sub colourChangeP(sender As Label, e As EventArgs)
        sender.ForeColor = Color.MediumOrchid 'change the senders colour to purpul
    End Sub
    Private Sub colourChangeB(sender As Label, e As EventArgs)
        sender.ForeColor = Color.Black 'change the senders colour to black
    End Sub

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnNewGame.Click
        'loadDB()
        If sender.name = "frmGame" Then AddHandler Me.FormClosing, AddressOf formEvents.FormClosing ' if the sender is the form then add the close handler
        frmMain.musicPic(picMute, False) 'set the mute button
        Me.KeyPreview = True 'Enable the form to listen to all keys input
        btnNewGame.Enabled = False 'disable new game button
        btnForfeit.Enabled = True 'enable the foreit button

        picHangman.SizeMode = PictureBoxSizeMode.Normal 'set some image settings
        picHangman.Image = Nothing 'clear the image box

        letterGuesses = "" 'reset the letter guess
        badGuesses = maxGuesses 'reset the bad guesses

        plrWord = wordLists(catID).randomWord() 'get a random word
        lblHint.Text = plrWord.hint 'show the hint
        lblCat.Text = wordLists(catID).name 'Set the catigorey label
        lblName.Text = cPlayer.name 'set the player name
        lblScore.Text = cPlayer.score 'set the score
        lblHyphen.Text = plrWord.hyphenWord() 'set the hyhen label

        pnlLetters.Enabled = True 'enable the letter pannel
        For Each Letter As Label In pnlLetters.Controls 'for each letter in the pannel
            If sender.name = "frmGame" Then 'if we are in the init then
                AddHandler Letter.Click, AddressOf Me.lblLetterS_Click 'add letter handler
                AddHandler Letter.MouseHover, AddressOf Me.colourChangeP 'add p colour
                AddHandler Letter.MouseLeave, AddressOf Me.colourChangeB 'add b colour
            End If
            Letter.Enabled = True 'enable letter
        Next

    End Sub

    Private Sub lblLetterS_Click(sender As Label, e As EventArgs) 'when any letter is clicked
        sender.Enabled = False 'disable it
        checkLetter(sender.Text) 'call the checkletter function with the letter
    End Sub

    Private Sub frmGame_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress 'When any key is pressed
        Dim upperKey As String = e.KeyChar.ToString.ToUpper 'make the key into a string
        Dim letterLabel As Label = pnlLetters.Controls("lblLetter" & upperKey) 'get the correct letter label with the key
        If IsNothing(letterLabel) Then Exit Sub 'if the letter label is nothing then the wrong key is pressed and we quit 
        If alphabet.Contains(upperKey) And letterLabel.Enabled Then 'If the key is in the alphabet and the label is enabled
            letterLabel.Enabled = False 'disable the letter
            checkLetter(upperKey) 'check the letter
        End If
    End Sub

    Private Sub btnForfeit_Click(sender As Object, e As EventArgs) Handles btnForfeit.Click 'foreit button
        Dim message = "Hey, " & cPlayer.name & ", Are you sure you wish to forfeit?" & vbNewLine & "You will lose a point!"
        Dim res As MsgBoxResult = MsgBox(message, MsgBoxStyle.YesNo, "Divisions of Science") 'ask them if they want to foreit
        If res = MsgBoxResult.Yes Then 'if they do then
            btnForfeit.Enabled = False 'disable it
            If userInfo(playerID).score > 0 Then userInfo(playerID).score -= 1 'if the score is above 0 then take a point
            frmGame_Load(Me, Nothing) 'reload
            'Else : btnNewGame.Enabled = True
        End If
    End Sub

    Private Sub picMute_Click(sender As Object, e As EventArgs) Handles picMute.Click
        frmMain.musicPic(sender) 'handel the mute 
    End Sub
End Class