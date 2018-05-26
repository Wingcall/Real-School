Public Class wordList 'This is the class of the category
    Public id As Int16 'The id of the category
    Public name As String 'name of the category
    Public words(0) As word 'The array of words in the cat

    Public Sub New(idLocal As Int16, nameLocal As String) 'Set the name/id of the cat
        id = idLocal 'set id to given
        name = nameLocal 'set name to given
    End Sub

    Public Sub addWord(word As String, hint As String) 'The word adding function
        words.add(New word(word, hint)) 'use the custom array.add function to add a new word with the given name and hint
    End Sub

    Public Sub printList() 'This is a debug command to print all the words in the list
        For Each word As word In words
            Dim del As String
            If word.del Then del = ", [Deleted]" Else del = "" 'if the word is deleted then append that to the console
            Console.WriteLine("Word: " & word.wordVal & ", Hint: " & word.hint & del) 'print to the console
        Next
    End Sub

    Public Function randomWord() As word 'This function returns a random word from the wordlist.
        Dim rWord As Integer = New Random().Next(0, words.Length) 'Get a random integer between 0 and the number of words in the list
        If words(rWord).del Then Return randomWord() 'If that word is deleted try again
        Return words(rWord) 'return the word
    End Function

    Function findWord(inputWord As String) As word 'This finds a word basedon the input
        Dim cWord As word = New word("BLANK", "BLANK", True) 'Create a blank word to keep the error checkers happy
        For Each word As word In words 'For every word in the list
            If word.wordValOrig = inputWord Then 'Check if the given word is equal to the selected word
                cWord = word 'Rember that word
                Exit For 'quit the for loop
            End If
        Next
        Return cWord 'return the word, if no word is found then the blank will be given
    End Function

    Public Function checkWordEsxits(inputWord As String) As Boolean 'this is the word check funciton to see if the given word already exists
        For Each word As word In words 'For each word in the list
            If word.wordVal = inputWord.ToUpper And Not word.del Then Return True 'if the word is not to be deleted and it is exsits (this ignores case where as the above function does not) then Return True
        Next
        Return False 'Other wise its not found and return false
    End Function
End Class

Public Class word ' This is the class for the words. This holds lots of usefull code.
    Public wordVal As String 'The CAPITALISED value of the word, used for compairing and hyphenation
    Public wordValOrig As String 'The CaSeD value of the word, used for giveing to the user
    Public hint As String 'The hint for the word
    Public del As Boolean = False 'This determines if the word is to be deleted, words cant really be (easly) deleted from the array untill it is rebuilt thus a bool is usefull
    Public blank As Boolean 'This determines if the word is a blank, so if somehting errored when selecting a word, if this is true it shows no word is selcted.

    Public Function HyCount() As Integer 'This get the number of hyphens in the word
        Return wordVal.Length - wordVal.Replace("-", "").Length 'Get the length of the word and subtract the length of the word with hyphens removed.
    End Function

    Public Function correct(input As String) As Boolean 'This checks if the word has been guessed correctly
        Dim local As Integer = input.Length - input.Replace("-", "").Length 'Get the number of hyphens in the given string
        Return (local = HyCount()) 'Return if the local Hyphen count (dim above) is equal to the words hyphen count. This checks if there are any hyphens left from the hangman game
    End Function

    Public Sub New(wordLocal As String, hintLocal As String, Optional blankLocal As Boolean = False) 'This is called when a new word is created
        wordVal = wordLocal.ToUpper 'Set the CAPPED value of the word
        wordValOrig = wordLocal 'Set the CaSeD value of the Word
        hint = hintLocal 'Set the hint
        blank = blankLocal 'Set the blank flag, if unspecifed this = false
    End Sub

    Public Sub update(nWord As String, nHint As String) 'Update the word to new values
        wordVal = nWord.ToUpper 'Set the new CAPPED word value
        wordValOrig = nWord 'set the new CaSeD value
        hint = nHint 'set the new hint
    End Sub

    Public Sub delWord() 'Delete the word
        del = True 'set the true flag
    End Sub

    Public Function hyphenWord(Optional charList As String = "") As String 'This is the hyphen generator. This converts a word (plus any correct letters given) into hyphens or letters
        charList = charList.ToUpper 'Uppercase the input
        Dim hyphen As String = "" 'set a blank (out) string
        Dim wCharArray As Char() = wordVal.ToCharArray() 'Create a char array from the actual word
        For Each wChar As Char In wCharArray 'Do for each char in the actual word charArray
            If wChar <> CChar(" ") And Not charList.Contains(wChar.ToString) _
                And alphabet.Contains(wChar.ToString) Then hyphen += "-" 'If the char is not a space and is in the alphabet and it is not in the given charList then add a hyphen to the out string
            If charList.Contains(wChar.ToString) _
                Or Not alphabet.Contains(wChar.ToString) Then hyphen += wChar.ToString 'if the char is ether NOT in the alphabet (Number or puctuation ect) or it is in the given char list add that char to the out string
            If wChar = CChar(" ") Then hyphen += " " 'If it equals a space then add a space to the out string
        Next
        Return hyphen 'return that hyphen (out) string
    End Function
End Class
