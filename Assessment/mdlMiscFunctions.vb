Module miscFunctions
    Public Sub exitGame(form As Object)
        Dim result As Integer = MessageBox.Show("Do you really want to quit?", "Exit", MessageBoxButtons.YesNo) 'Ask the user if they want to quit
        If (result = DialogResult.Yes) Then 'Check if they said yes
            If (form.Name = "frmGame") Then 'Check if the game form called the close
                updateUserXML() 'If so, save the user state
            End If
            form.close() 'Close the current form
            frmMain.Close() 'close the main form.
        End If
    End Sub
End Module
