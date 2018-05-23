Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing
        rdoPlayer1.Text = userInfo(0).name
        rdoPlayer2.Text = userInfo(1).name
        rdoPlayer3.Text = userInfo(2).name
        rdoPlayer4.Text = userInfo(3).name
        lblPlayer1Score.Text = userInfo(0).score
        lblPlayer2Score.Text = userInfo(1).score
        lblPlayer3Score.Text = userInfo(2).score
        lblPlayer4Score.Text = userInfo(3).score
    End Sub

    Private Sub btnDelPlayer_Click(sender As Object, e As EventArgs) Handles btnDelPlayer.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete this slot?", "Divisions of Science", MessageBoxButtons.YesNo) 'Ask the user if they want to delete player
        If (result = DialogResult.Yes) Then 'Check if they said yes
            userInfo(playerID).del()        'Deletes the player info selected by selected.
            rdoPlayer1.Text = userInfo(0).name          'Resets the Player's Names
            rdoPlayer2.Text = userInfo(1).name
            rdoPlayer3.Text = userInfo(2).name
            rdoPlayer4.Text = userInfo(3).name
            lblPlayer1Score.Text = userInfo(0).score    'Resets the Player's scores
            lblPlayer2Score.Text = userInfo(1).score
            lblPlayer3Score.Text = userInfo(2).score
            lblPlayer4Score.Text = userInfo(3).score
            updateUserXML()                 'Updates the User XML File
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim prompt As String
        Dim title As String
        Dim answer As String

        prompt = "Hello There! What's your name?"   'Sets the Question in the message box
        title = "Create New Profile"    'Sets the Message Box Title
        answer = InputBox(prompt, title)
        userInfo(playerID).ans(answer)
        rdoPlayer1.Text = userInfo(0).name          'Resets the Player's Names
        rdoPlayer2.Text = userInfo(1).name
        rdoPlayer3.Text = userInfo(2).name
        rdoPlayer4.Text = userInfo(3).name
        updateUserXML()
    End Sub

    Private Sub rdoPlayer1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPlayer1.CheckedChanged, rdoPlayer2.CheckedChanged, rdoPlayer3.CheckedChanged, rdoPlayer4.CheckedChanged
        playerID = sender.tag
        lblTag.Text = sender.tag
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click ';, rdoPlayer1.CheckedChanged, rdoPlayer2.CheckedChanged, rdoPlayer3.CheckedChanged, rdoPlayer4.CheckedChanged
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