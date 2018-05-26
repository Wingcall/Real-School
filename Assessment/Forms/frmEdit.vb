Public Class frmEdit
    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing 'Add the close form handler
        frmMain.musicPic(picMute, False) 'Set the music icon properly

        cmbCat.Items.Add("Select a Category") 'Create the default option for the drop down

        For Each cat As wordList In wordLists 'For each catigory in the catList add an option to the drop down. This was done to allow for easy expansion
            cmbCat.Items.Add(cat.name) 'Add the catigorey
        Next
        cmbCat.SelectedItem = cmbCat.Items(0) 'Set the selected item to the select message
    End Sub

    Private Sub cmbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCat.SelectedIndexChanged 'When ever the catSelecter changes values
        If cmbCat.SelectedItem.ToString = "Select a Category" Then 'If the selected item is the choose message clear all boxes and lists
            txtWord.Text = ""
            txtHint.Text = ""
            lstWords.Items.Clear()
            Exit Sub
        End If
        refWordList() 'always refesh the list box
    End Sub

    Private Sub lstWords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstWords.SelectedIndexChanged 'When ever the list box selected item changes
        If cmbCat.SelectedItem.ToString = "Select a Category" Or IsNothing(lstWords.SelectedItem) Then lstWords.Items.Clear() : Exit Sub 'If the catigorey is the default or there is no items in the list then quit the sub

        btnAdd.Text = "Update Word" 'Since we selected an item change the Add buttons name

        Dim cat As wordList = wordLists(cmbCat.Items.IndexOf(cmbCat.SelectedItem) - 1) 'Get the selected cat
        Dim cWord As word = cat.findWord(lstWords.SelectedItem.ToString) 'Get the selected word

        txtWord.Text = cWord.wordValOrig 'Set the word textbox to the value of the word
        txtHint.Text = cWord.hint 'Set the hint text box to the value of the words hit
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click 'delete button is clicked
        If IsNothing(lstWords.SelectedItem) Or cmbCat.SelectedItem.ToString = "Select a Category" Then 'throw an error if no word or cat is selected
            MsgBox("Please check that a Word and Category have been selected!", MsgBoxStyle.Critical) 'tell the,
            Exit Sub 'exit the sub
        End If

        Dim res As Int16 = MsgBox("Are you sure you wish to delete this word?", MsgBoxStyle.YesNo, "Delete Word") 'Ask and remember if the user want to delete the word.
        If res = MsgBoxResult.No Then Exit Sub 'if they dont then exit the sub
        Dim cat As wordList = wordLists(cmbCat.Items.IndexOf(cmbCat.SelectedItem) - 1) 'From here they do, so get the cat of the word
        cat.findWord(lstWords.SelectedItem.ToString).delWord() 'find the word using the custom findWord function and delete it
        lstWords.Items.Clear() 'Clear the list bx
        refWordList() 'refresh the list box
        updateWordXML() 'Update the word xml-db
        btnClear_Click(Nothing, Nothing, False) 'run the clear code and dont triger the add word code. (hense the optional false)
    End Sub

    Function checkForLetter(inStr As String) 'This puppy makes sure that there is at least one letter in the (english) alphabet in a word for the user to guess.
        For Each tChar As Char In inStr.ToUpper 'For every charecter in the supplied string thats uppercased do
            If Not alphabet.IndexOfAny(tChar.ToString) = -1 Then Return True 'check that it is in the alphabet some where, if its is then return true, if not go to the next char
        Next
        Return False 'there was no letters in the string return false
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click 'When the add button is clicked
        If IsNothing(lstWords.SelectedItem) And Not btnAdd.Text = "Add Word" Then btnAdd.Text = "Add Word" : Exit Sub 'If there is nothing selected in the list box and the button is not called "Add Word" then fix that and exit the sub
        Dim check As Boolean = Not checkForLetter(txtWord.Text) Or Not checkForLetter(txtHint.Text) 'create a bool var and check that there is letters in hint and the word
        'check = check Or (txtWord.Text.Replace(" ", "") = "" Or txtHint.Text.Replace(" ", "") = "")'this is redunant as the above line does the same thing, basicly check that a non-empty string was given
        check = check Or (cmbCat.SelectedItem.ToString = "Select a Category") 'check that a catigory was suplied
        If Not check Then 'if all the things check out
            Dim bAddA As Boolean = btnAdd.Text = "Add Word" 'remember if the add button is called "Add Word"
            Dim cat As wordList = wordLists(cmbCat.Items.IndexOf(cmbCat.SelectedItem) - 1) 'get the selected cat
            Dim cWord As word = New word("BLANK", "BLANK", True) ' create a blank word to stop the error catcher whining

            If Not bAddA Then cWord = cat.findWord(lstWords.SelectedItem.ToString) 'If the add button is called "Update Word" then get the selected word to update.

            If Not cat.checkWordEsxits(txtWord.Text) Or Not bAddA Then 'See if the word exits or we are in update mode
                If bAddA Then : cat.addWord(txtWord.Text, txtHint.Text) 'if we are in add mode, then add the word to the cat (this is a compressed if a : does the same thing as a new line)
                Else : cWord.update(txtWord.Text, txtHint.Text) 'otherwise we update the word
                End If
            Else 'Tell the user that duplicate words are not allowed
                'If btnAdd.Text = "Update Word" Then 
                MsgBox("That word is already in the list!", MsgBoxStyle.Exclamation, "Word Exists!")
                Exit Sub 'exit the sub
            End If
        ElseIf cmbCat.SelectedItem.ToString = "Select a Category" Then 'If we dont have a catm yell at the user
            MsgBox("You need to select a Category first!", MsgBoxStyle.Exclamation, "Missing Category!")
            Exit Sub
        ElseIf txtWord.Text.Replace(" ", "") = "" Then 'If the word is blank, yell at the user
            MsgBox("You need to type in a Word first!", MsgBoxStyle.Exclamation, "Missing Word!")
            Exit Sub
        ElseIf txtHint.Text.Replace(" ", "") = "" Then 'If there is no hint, yell at the user
            MsgBox("You need to type in a Hint first!", MsgBoxStyle.Exclamation, "Missing Hint!")
            Exit Sub
        ElseIf checkForLetter(txtWord.Text) Or checkForLetter(txtHint.Text) Then 'If there is no letters then, you guessed it, yell at the user
            MsgBox("You need to enter at least one word for the Hint and the Word!", MsgBoxStyle.Exclamation, "Error!")
            Exit Sub
        End If
        refWordList() 'Refresh the word list
        updateWordXML() 'Update the word xml-db
        btnClear_Click(Nothing, Nothing, False) 'Call the clear sub and dont run the add code
    End Sub

    Private Sub refWordList() 'Refresh Word List code, basicly clear and replace all the words in the list box
        lstWords.Items.Clear() 'clear the list box. You will see that I clear it sometimes before this function is run as well. That is because a) it dosnt hurt and b) if i dont, it breaks sometimes...
        If IsNothing(cmbCat.SelectedItem) Then Exit Sub 'check if there is no cat and quit the sub if there isnt
        For Each word As word In wordLists(cmbCat.Items.IndexOf(cmbCat.SelectedItem) - 1).words 'For each word in the selectd cat 
            If Not word.del Then lstWords.Items.Add(word.wordValOrig) 'if its not to be deleted, then add it to the list box
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs, Optional alClear As Boolean = True) Handles btnClear.Click
        'If btnAdd.Text = "Add Word" And alClear Then
        ' btnAdd_Click(btnAdd, Nothing)
        ' Else
        txtWord.Text = "" 'clear the word box
        txtHint.Text = "" 'clear the hint box
        btnAdd.Text = "Add Word" 'Set the button text to "Add Word"
        refWordList() 'Clear/Refresh the list
        txtWord.Focus() 'Focus on the word box

        'End If
    End Sub

    Private Sub picMute_Click(sender As Object, e As EventArgs) Handles picMute.Click
        frmMain.musicPic(sender) 'Calls the Public sub-procedure musicPic with the sender
    End Sub
End Class