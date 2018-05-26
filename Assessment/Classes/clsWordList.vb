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
            If word.wordValOrig = inputWord Then
                cWord = word
            End If
        Next
        Return cWord
    End Function

    Public Function checkWordEsxits(inputWord As String) As Boolean
        For Each word As word In words
            If word.wordValOrig = inputWord And Not word.del Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function
End Class

Public Class word
    Public wordVal As String
    Public wordValOrig As String
    Public hint As String
    Public del As Boolean = False
    Public blank As Boolean

    Public Function HyCount() As Integer
        Return wordVal.Length - wordVal.Replace("-", "").Length
    End Function

    Public Function correct(input As String) As Boolean
        Dim local As Integer = input.Length - input.Replace("-", "").Length
        Return (local = HyCount())
    End Function

    Public Sub New(wordLocal As String, hintLocal As String, Optional blankLocal As Boolean = False)
        wordVal = wordLocal.ToUpper
        wordValOrig = wordLocal
        hint = hintLocal
        blank = blankLocal
    End Sub

    Public Sub update(nWord As String, nHint As String)
        wordVal = nWord.ToUpper
        wordValOrig = nWord
        hint = nHint
    End Sub

    Public Sub delWord()
        del = True
    End Sub

    Public Function hyphenWord(Optional charList As String = "") As String
        charList = charList.ToUpper
        Dim hyphen As String = ""
        Dim wCharArray As Char() = wordVal.ToCharArray()
        For Each wChar As Char In wCharArray
            If wChar <> CChar(" ") And Not charList.Contains(wChar.ToString) _
                And alphabet.Contains(wChar.ToString) Then hyphen += "-"
            If charList.Contains(wChar.ToString) _
                Or Not alphabet.Contains(wChar.ToString) Then hyphen += wChar.ToString
            If wChar = CChar(" ") Then hyphen += " "
        Next
        Return hyphen
    End Function
End Class
