Public Class frmMain
    'Idk

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing     'Adds the Closing Extension/Handler
        loadDB()    'Initialilzes and loads XML database
    End Sub

    Private Sub buttonHandler(sender As Object, e As EventArgs) Handles lblPlay.Click, lblAbout.Click, lblHelp.Click, lblExit.Click
        Select Case sender.name         'Handles conditions with multiple outcomes
            Case "lblPlay"
                frmLogin.openForm()     'Runs the custom sub-routine to open the Login Form
            Case "lblAbout"
                frmAbout.openForm()     'Runs the custom sub-routine to open the About Form
            Case "lblHelp"
                frmHelp.openForm()      'Runs the custom sub-routine to open the Help Form
            Case "lblExit"
                End     'Closes the Divisions of Science Hangman Game
        End Select
    End Sub

    Private Sub lblPlay_MouseHover(sender As Label, e As EventArgs) Handles lblPlay.MouseHover, lblAbout.MouseHover, lblHelp.MouseHover, lblExit.MouseHover
        sender.ForeColor = Color.MediumOrchid   'On mouse hover, changes the Label(s) Forecolour to Medium Orchid
    End Sub

    Private Sub lblPlay_MouseLeave(sender As Label, e As EventArgs) Handles lblPlay.MouseLeave, lblAbout.MouseLeave, lblHelp.MouseLeave, lblExit.MouseLeave
        sender.ForeColor = Color.Black  'On mouse leave, changes the Label(s) Forecolour to Black
    End Sub

    'Below are debug buttons, to be removed in final copy.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmCategories.openForm()        'Testing purposes, REMOVE WHEN DONE
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmLogin.openForm()             'testing purposes, REMOVE WHEN DONE
    End Sub

    Private Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        frmGame.openForm()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmEdit.openForm()
    End Sub
End Class