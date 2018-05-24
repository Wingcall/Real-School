Module miscFunctions
    Public Const alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" 'Store the alphabet as a string. (This is a massive help later)

    Public Sub exitGame(form As Form, Optional e As FormClosingEventArgs = Nothing)
        Dim result As Integer
        result = MessageBox.Show("Do you really want to quit?", "Exit", MessageBoxButtons.YesNo) 'Ask the user if they want to quit
        If (result = DialogResult.Yes) Then 'Check if they said yes
            If (form.Name = "frmGame") Then 'Check if the game form called the close
                updateUserXML() 'If so, save the user state
            End If

            RemoveHandler frmMain.FormClosing, AddressOf formEvents.FormClosing
            frmMain.Close()
        Else
            If Not IsNothing(e) Then
                e.Cancel = True
            End If
        End If
    End Sub

    Public Sub exitGame1(form As Form, Optional e As FormClosedEventArgs = Nothing)
        RemoveHandler frmMain.FormClosing, AddressOf formEvents.FormClosing
        frmMain.Close()
    End Sub

End Module
