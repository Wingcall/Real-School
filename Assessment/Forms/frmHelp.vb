'Completed By Brandon.D 2018
Public Class frmHelp

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing     'Adds the closing extension/handler
        frmMain.musicPic(picMute, False) 'Sets the state state of music to false in the Public sub-procedure
    End Sub

    Private Sub picMute_Click(sender As Object, e As EventArgs) Handles picMute.Click
        frmMain.musicPic(sender) 'Calls the Public sub-procedure musicPic with the state
    End Sub
End Class