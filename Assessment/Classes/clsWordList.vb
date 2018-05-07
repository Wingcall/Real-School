Public Class wordList
    Public id As Int16
    Public name As String
    Public words(0) As word

    Public Sub New(idLocal As Int16, nameLocal As String)
        id = idLocal
        name = nameLocal
    End Sub

    Public Sub addWord(word As String, hint As String)
        words.add(New word(word, hint))
    End Sub

    Public Sub printList()
        For Each word As Object In words
            Dim del As String
            If word.del Then del = ", [Deleted]" Else del = ""
            Console.WriteLine("Word: " & word.word & ", Hint: " & word.hint & del)
        Next
    End Sub

    Public Function randomWord()
        Dim rWord As Integer = New Random().Next(0, words.Length)
        If words(rWord).del Then Return randomWord()
        Return words(rWord)
    End Function
End Class

Public Class word
    Public word As String
    Public hint As String
    Public del As Boolean = False


    Public Sub New(wordLocal As String, hintLocal As String)
        word = wordLocal
        hint = hintLocal
    End Sub

    Public Sub delWord()
        del = True
    End Sub
End Class
