Public Class formEvents
    Public Shared Sub FormClosing(sender As Object, e As FormClosingEventArgs)
        If e.CloseReason = CloseReason.UserClosing Then 'If the close came from the red cross
            exitGame(sender, e) 'Call the exit function
        End If
    End Sub
End Class
