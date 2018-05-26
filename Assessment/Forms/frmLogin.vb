Public Class frmLogin
    Private Sub Reset()
        rdoPlayer1.Text = userInfo(0).name          'Sets Player 1's Name
        rdoPlayer2.Text = userInfo(1).name          'Sets Player 2's Name
        rdoPlayer3.Text = userInfo(2).name          'Sets Player 3's Name
        rdoPlayer4.Text = userInfo(3).name          'Sets Player 4's Name
        lblPlayer1Score.Text = userInfo(0).score    'Sets Player 1's Score
        lblPlayer2Score.Text = userInfo(1).score    'Sets Player 2's Score
        lblPlayer3Score.Text = userInfo(2).score    'Sets Player 3's Score
        lblPlayer4Score.Text = userInfo(3).score    'Sets Player 4's Score
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing     'Adds the Closing Extension/Handler
        frmMain.musicPic(picMute, False)
        Reset()     'Calls sub-procedure Reset
    End Sub

    Private Sub btnDelPlayer_Click(sender As Object, e As EventArgs) Handles btnDelPlayer.Click
        If userInfo(playerID).name = "New Player!" Then     'Check if the player slots name is "New Player!"
            MessageBox.Show("This slot is empty!", "Divisions of Science", MessageBoxButtons.OK)    'Display Message Box saying that the slot is already empty
        Else
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete this slot?", "Divisions of Science", MessageBoxButtons.YesNo) 'Ask the user if they want to delete player
            If (result = DialogResult.Yes) Then     'If the result is yes, do below
                userInfo(playerID).del()        'Deletes the player info selected by selected.
                updateUserXML()                 'Updates the User XML File
                Reset()                         'Calls sub-procedure Reset
            End If
        End If
    End Sub

    Private Sub Namecatching()
        Dim prompt, title, answer, prompt2, title2, answer2 As String
        prompt = "Hello There! What's your name?"   'Sets the Question in the message box'
        title = "Create New Profile"    'Sets the Message Box Title'
        answer = InputBox(prompt, title)    'Answer is equal to what the user inputs
        btnNext.Focus()     'Sets the mouse focus to the Next Button
        If answer = "New Player!" Then
            MessageBox.Show("Nice Try! What's your name?", "Divisions of Science", MessageBoxButtons.OK)   'Displays message box to select player slot
            prompt2 = "Enter your REAL name!"   'Sets the instruction of the message box
            title2 = "Create New Profile"   'Sets the Title of the window
            answer2 = InputBox(prompt2, title2)     'Answer is equal to what the user inputs
            btnNext.Focus()     'Sets the mouse focus to the Next Button
            If answer2 = "New Player!" Then     'Check if the answer is "New Player!" again
                MessageBox.Show("Okay Bond, James Bond.", "Divisions of Science", MessageBoxButtons.OK)   'Displays message box to select player slot
                frmMain.Show()  'Show the main form
                Me.closeForm()  'Close the current form
            ElseIf answer2 = "" Then 'No-op
            Else
                userInfo(playerID).ans(answer2) 'Sets the input from the second message box
            End If
        ElseIf answer = "" Then 'NOOP
        Else
            userInfo(playerID).ans(answer)  'Sets the input from the first message box
        End If
        updateUserXML()     'Updates the User XML file
        Reset()                         'Calls sub-procedure Reset
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not userInfo(playerID).name = "New Player!" Then     'Check if the slot isn't "New Player!"
            Dim res As Integer = MessageBox.Show("Are you sure you want to overwrite this slot?", "Divisions of Science", MessageBoxButtons.YesNo)   'Displays message box to ask if the user wishes to overwrite
            If res = 6 Then
                Namecatching() 'Runs the sub-procedure Namecatching'
            Else
                userInfo(playerID).del()    'Runs the sub-procedure delete procedure found in Playerinfo class
            End If
        End If
        If userInfo(playerID).name = "New Player!" Then         'Check if the slot is "New Player!"
            Namecatching()      'Runs the sub-procedure Namecatching
        End If
    End Sub

    Private Sub rdoPlayer1_CheckedChanged(sender As RadioButton, e As EventArgs) Handles rdoPlayer1.CheckedChanged, rdoPlayer2.CheckedChanged, rdoPlayer3.CheckedChanged, rdoPlayer4.CheckedChanged
        playerID = Val(sender.Tag)   'Sets the playerID global variable to equal the value of sender.tag
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (rdoPlayer1.Checked = False And rdoPlayer2.Checked = False And rdoPlayer3.Checked = False And rdoPlayer4.Checked = False) Then
            MessageBox.Show("Please select a player slot!", "Divisions of Science", MessageBoxButtons.OK)   'Displays message box to select player slot
        ElseIf userInfo(playerID).name = "New Player!" Then
            Namecatching()  'Runs the sub-procedure Namecatching
        End If

        If userInfo(playerID).name = "New Player!" Then
        Else
            playerID = sender.tag   'Sets the global variable of playerID to be equal with the selected rdo button's tag
            frmCategories.Show()    'Displays the Categories Form
            Me.closeForm()  'Closes the current form
        End If
    End Sub

    Private Sub rdoPlayer1_MouseHover(sender As RadioButton, e As EventArgs) Handles rdoPlayer1.MouseHover, rdoPlayer2.MouseHover, rdoPlayer3.MouseHover, rdoPlayer4.MouseHover
        sender.ForeColor = Color.MediumOrchid       'On mouse hover, changes the Label(s) Forecolour to Medium Orchid
    End Sub

    Private Sub rdoPlayer1_MouseLeave(sender As RadioButton, e As EventArgs) Handles rdoPlayer1.MouseLeave, rdoPlayer2.MouseLeave, rdoPlayer3.MouseLeave, rdoPlayer4.MouseLeave
        sender.ForeColor = Color.Black              'On mouse leave, changes the Label(s) Forecolour to Black
    End Sub

    Private Sub picMute_Click(sender As Object, e As EventArgs) Handles picMute.Click
        frmMain.musicPic(sender)    'Calls the Public sub-procedure musicPic with the state
    End Sub
End Class