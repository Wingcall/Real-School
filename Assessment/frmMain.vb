Public Class frmMain
    'Bla bla comments add later

    Private Sub lblPlay_Click(sender As Object, e As EventArgs) Handles lblPlay.Click
        frmLogin.openForm() 'Thats right a custom function
    End Sub

    Private Sub lblHelp_Click(sender As Object, e As EventArgs) Handles lblHelp.Click
        frmHelp.openForm()              'Displays the Help Form
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        End                         'Closes the Hangman Game
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmCategories.openForm()        'Testing purposes, REMOVE WHEN DONE
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmLogin.openForm()             'testing purposes, REMOVE WHEN DONE
    End Sub

    Private Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        frmGame.openForm()
    End Sub

    Private Sub lblAbout_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
        frmAbout.openForm()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing
        loadDB()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmEdit.openForm()
    End Sub



End Class