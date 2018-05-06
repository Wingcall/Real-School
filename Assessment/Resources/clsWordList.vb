Public Class wordList
    Public id As Int16
    Public name As String
    Public words(0) As Object

    Public Sub New(idLocal As Int16, nameLocal As String)
        id = idLocal
        name = nameLocal
    End Sub

    Public Sub addWord(word As String, hint As String)
        words.add(New word(word, hint))
    End Sub

    Public Sub printList()
        For Each word As Object In words
            Console.WriteLine("Word: " & word.word & ", Hint: " & word.hint)
        Next
    End Sub
End Class

Public Class word
    Public word As String
    Public hint As String

    Public Sub New(wordLocal As String, hintLocal As String)
        word = wordLocal
        hint = hintLocal
    End Sub
End Class
