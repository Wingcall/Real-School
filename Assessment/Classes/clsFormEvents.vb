Public Class formEvents
    'This is so that in 3 lines every form can have the popup box open when the user tries to close the game.
    Public Shared Sub FormClosing(sender As Object, e As FormClosingEventArgs)
        If e.CloseReason = CloseReason.UserClosing Then 'If the close came from the red cross
            exitGame(sender, e) 'Call the exit function
        End If
    End Sub
End Class
