Module miscFunctions
    Public Sub exitGame(form As Form, Optional e As FormClosingEventArgs = Nothing)
        Dim result As Integer = MessageBox.Show("Do you really want to quit?", "Exit", MessageBoxButtons.YesNo) 'Ask the user if they want to quit
        If (result = DialogResult.Yes) Then 'Check if they said yes
            'form.disabled = True
            If (form.Name = "frmGame") Then 'Check if the game form called the close
                updateUserXML() 'If so, save the user state
                'Else
                'form.disabled = False
            End If
            End 'Lets just quit
            'form.Close() 'Close the current form
            'frmMain.Close() 'close the main form.
        Else
            If Not IsNothing(e) Then
                e.Cancel = True
            End If
        End If
    End Sub

End Module
