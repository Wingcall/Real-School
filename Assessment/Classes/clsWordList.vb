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

    Public Function randomWord() As word
        Dim rWord As Integer = New Random().Next(0, words.Length)
        If words(rWord).del Then Return randomWord()
        Return words(rWord)
    End Function

    Function findWord(inputWord As String) As word
        Dim cWord As word = New word("BLANK", "BLANK", True)
        For Each word As word In words
            If word.word = inputWord Then
                cWord = word
            End If
        Next
        Return cWord
    End Function

    Function checkWordEsxits(inputWord As String) As Boolean
        For Each word As word In words
            If word.word = inputWord And Not word.del Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

End Class

Public Class word
    Public word As String
    Public hint As String
    Public del As Boolean = False
    Public blank As Boolean


    Public Sub New(wordLocal As String, hintLocal As String, Optional blankLocal As Boolean = False)
        word = wordLocal
        hint = hintLocal
        blank = blankLocal
    End Sub

    Public Sub delWord()
        del = True
    End Sub
End Class
