﻿'Completed By Brandon.D 2018
Public Class frmCategories

    Private Sub frmCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing     'Adds the Closing Extension/Handler
        frmMain.musicPic(picMute, False) 'Sets the state state of music to false in the Public sub-procedure
    End Sub

    Private Sub picBiology_Click(sender As Object, e As EventArgs) Handles picBiology.Click, picChemistry.Click, picPhysics.Click, lblBiology.Click, lblChemistry.Click, lblPhysics.Click
        catID = sender.tag      'Sets the global catID to equal the tag of the label or picture
        frmGame.Show()          'Opens the Game Form
        Me.closeForm()          'Closes the current (categories) form
    End Sub

    Private Sub picMute_Click(sender As Object, e As EventArgs) Handles picMute.Click
        frmMain.musicPic(sender) 'Calls the Public sub-procedure musicPic with the state
    End Sub
End Class