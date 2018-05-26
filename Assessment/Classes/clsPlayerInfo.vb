Public Class playerInfo
    'This is the playerinfo class. This is so that we can easly manage all the players as pre-made custom objects in the userinfo array.
    Public id As Int16 'The id of the user, a smaller (int16) int is used since the ids never go above the Int16 Limit
    Public name As String 'The name of the player
    Public score As Integer 'There score

    Public Sub New(pInfo As Array) 'This is called when a player object is created. It takes the array {id, name, score}
        id = pInfo(0) 'set the players id
        name = pInfo(1) 'set the players name
        score = pInfo(2) 'set the players score
    End Sub

    Public Sub wipePlayer(inName As String) 'this resets the players name and score to what ever is suplied and 0
        name = inName 'set the players new name
        score = 0 'clear the score
    End Sub

    Public Sub del() 'this resets the players name and score to "New Player!" and 0
        name = "New Player!" 'clear name
        score = 0 'clear score
    End Sub

    Public Sub ans(answer As String) 'this just sets the players name to what ever is supplied.
        name = answer 'set name
    End Sub
End Class
