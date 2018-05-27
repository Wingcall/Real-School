'Completed By Brandon.D 2018
Public Class frmMain
    Public musicState As Boolean = True
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing     'Adds the Closing Extension/Handler
        loadDB()    'Initialilzes and loads XML database
        My.Computer.Audio.Play(My.Resources.Game_theme_music, AudioPlayMode.BackgroundLoop) 'Plays the Background audio'
    End Sub

    Public Sub musicControl()
        If musicState = True Then
            My.Computer.Audio.Stop()    'Stop playing the music
        Else
            My.Computer.Audio.Play(My.Resources.Game_theme_music, AudioPlayMode.BackgroundLoop) 'Plays the Background music
        End If
        musicState = Not musicState 'Sets the music state to false
    End Sub

    Public Sub musicPic(pic As PictureBox, Optional music As Boolean = True)
        If music Then musicControl() 'Runs the sub-procedure musicControl
        If musicState Then
            pic.BackgroundImage = My.Resources.mute 'Change the mute icon to the mute state
        Else
            pic.BackgroundImage = My.Resources.play 'Change the mute icon to the play state
        End If
    End Sub

    Private Sub buttonHandler(sender As Object, e As EventArgs) Handles lblPlay.Click, lblEdit.Click, lblAbout.Click, lblHelp.Click, lblExit.Click
        Select Case sender.name         'Handles conditions with multiple outcomes
            Case "lblPlay"
                frmLogin.openForm()     'Runs the custom sub-routine to open the Login Form
            Case "lblAbout"
                frmAbout.openForm()     'Runs the custom sub-routine to open the About Form
            Case "lblHelp"
                frmHelp.openForm()      'Runs the custom sub-routine to open the Help Form
            Case "lblEdit"
                frmEdit.openForm()      'Runs the custom sub-routine to open the Edit Words Form
            Case "lblExit"
                End     'Closes the Divisions of Science Hangman Game
        End Select
    End Sub

    Private Sub lblPlay_MouseHover(sender As Label, e As EventArgs) Handles lblPlay.MouseHover, lblEdit.MouseHover, lblAbout.MouseHover, lblHelp.MouseHover, lblExit.MouseHover
        sender.ForeColor = Color.MediumOrchid   'On mouse hover, changes the Label(s) Forecolour to Medium Orchid
    End Sub

    Private Sub lblPlay_MouseLeave(sender As Label, e As EventArgs) Handles lblPlay.MouseLeave, lblEdit.MouseLeave, lblAbout.MouseLeave, lblHelp.MouseLeave, lblExit.MouseLeave
        sender.ForeColor = Color.Black  'On mouse leave, changes the Label(s) Forecolour to Black
    End Sub

    Private Sub picMute_Clicked(sender As Object, e As EventArgs) Handles picMute.Click
        musicPic(sender) 'Calls the Public sub-procedure musicPic with the state
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        musicPic(picMute, False) 'Make sure the mute button is set poperly every time the form is shown
    End Sub
End Class