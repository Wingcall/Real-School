'Completed By Cal.W 2018
Module miscFunctions
    Public Const alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" 'Store the alphabet as a string. (This is a massive help later)

    Public Sub exitGame(form As Form, Optional e As FormClosingEventArgs = Nothing)
        Dim result As Integer
        result = MessageBox.Show("Do you really want to quit?", "Exit", MessageBoxButtons.YesNo) 'Ask the user if they want to quit
        If (result = DialogResult.Yes) Then 'Check if they said yes
            If (form.Name = "frmGame") Then 'Check if the game form called the close
                updateUserXML() 'If so, save the user state
            End If

            RemoveHandler frmMain.FormClosing, AddressOf formEvents.FormClosing 'remove the form closing handler
            frmMain.Close() 'close the main form
        Else
            If Not IsNothing(e) Then 'if e is given then
                e.Cancel = True 'cancel the closing
            End If
        End If
    End Sub

End Module
