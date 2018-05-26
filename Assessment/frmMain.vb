﻿Public Class frmMain
    Dim musicstate As Boolean
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing     'Adds the Closing Extension/Handler
        loadDB()    'Initialilzes and loads XML database
        My.Computer.Audio.Play(My.Resources.Game_theme_music, AudioPlayMode.BackgroundLoop) 'Plays the Background audio'
        musicstate = True
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If musicstate = True Then
            musicstate = False
            My.Computer.Audio.Stop()

        Else
            My.Computer.Audio.Play(My.Resources.Game_theme_music, AudioPlayMode.BackgroundLoop)
        End If
    End Sub
End Class