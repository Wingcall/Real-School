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
        Reset()     'Calls sub-procedure Reset
    End Sub

    Private Sub btnDelPlayer_Click(sender As Object, e As EventArgs) Handles btnDelPlayer.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete this slot?", "Divisions of Science", MessageBoxButtons.YesNo) 'Ask the user if they want to delete player
        If (result = DialogResult.Yes) Then     'If the result is yes, do below
            userInfo(playerID).del()        'Deletes the player info selected by selected.
            Reset()                         'Calls sub-procedure Reset
            updateUserXML()                 'Updates the User XML File
        End If
    End Sub

    Private Sub Namecatching()
        Dim prompt, title, answer, prompt2, title2, answer2 As String
        prompt = "Hello There! What's your name?"   'Sets the Question in the message box
        title = "Create New Profile"    'Sets the Message Box Title'
        answer = InputBox(prompt, title)
        If answer = "New Player!" Then
            MessageBox.Show("Nice Try! For real this time, what's your name?", "Divisions of Science", MessageBoxButtons.OK)   'Displays message box to select player slot
            prompt2 = "Enter your REAL name!"
            title2 = "Create New Profile"
            answer2 = InputBox(prompt2, title2)
            If answer2 = "New Player!" Then
                MessageBox.Show("Okay Bond, James Bond.", "Divisions of Science", MessageBoxButtons.OK)   'Displays message box to select player slot
                frmMain.Show()
                Me.closeForm()
            Else
                userInfo(playerID).ans(answer)
            End If
        End If
        userInfo(playerID).ans(answer)
        Reset()                         'Calls sub-procedure Reset
        updateUserXML()     'Updates the User XML file
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Namecatching()
    End Sub

    Private Sub rdoPlayer1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPlayer1.CheckedChanged, rdoPlayer2.CheckedChanged, rdoPlayer3.CheckedChanged, rdoPlayer4.CheckedChanged
        playerID = sender.tag   'Sets the playerID global variable to equal the value of sender.tag
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If userInfo(playerID).name = "New Player!" Then Namecatching()

        If (rdoPlayer1.Checked = False And rdoPlayer2.Checked = False And rdoPlayer3.Checked = False And rdoPlayer4.Checked = False) Then
            MessageBox.Show("Please select a player slot!", "Divisions of Science", MessageBoxButtons.OK)   'Displays message box to select player slot
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
End Class