Public Class frmEdit
    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing
        frmMain.musicPic(picMute, False)

        cmbCat.Items.Add("Select a Catigory")

        For Each cat As wordList In wordLists
            cmbCat.Items.Add(cat.name)
        Next
        cmbCat.SelectedItem = cmbCat.Items(0)
    End Sub

    Private Sub cmbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCat.SelectedIndexChanged
        If cmbCat.SelectedItem.ToString = "Select a Catigory" Then
            txtWord.Text = ""
            txtHint.Text = ""
            lstWords.Items.Clear()
            Exit Sub
        End If
        refWordList()
    End Sub

    Private Sub lstWords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstWords.SelectedIndexChanged
        If cmbCat.SelectedItem.ToString = "Select a Catigory" Or IsNothing(lstWords.SelectedItem) Then lstWords.Items.Clear() : Exit Sub

        btnAdd.Text = "Update Word"

        Dim cat As wordList = wordLists(cmbCat.Items.IndexOf(cmbCat.SelectedItem) - 1)
        Dim cWord As word = cat.findWord(lstWords.SelectedItem.ToString)

        txtWord.Text = cWord.wordValOrig
        txtHint.Text = cWord.hint
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If IsNothing(lstWords.SelectedItem) Or cmbCat.SelectedItem.ToString = "Select a Catigory" Then
            MsgBox("Please check that a Word and Catigory have been selected!")
            Exit Sub
        End If

        Dim res As Int16 = MsgBox("Are you sure you wish to delete this word?", MsgBoxStyle.YesNo, "Delete Word")
        If res = MsgBoxResult.No Then Exit Sub
        Dim cat As wordList = wordLists(cmbCat.Items.IndexOf(cmbCat.SelectedItem) - 1)
        cat.findWord(lstWords.SelectedItem.ToString).delWord()
        lstWords.Items.Clear()
        refWordList()
        updateWordXML()
        btnClear_Click(Nothing, Nothing, False)
    End Sub

    Function checkForLetter(inStr As String)
        For Each tChar As Char In inStr.ToUpper
            If Not alphabet.IndexOfAny(tChar.ToString) = -1 Then Return True
        Next
        Return False
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If IsNothing(lstWords.SelectedItem) And Not btnAdd.Text = "Add Word" Then btnAdd.Text = "Add Word" : Exit Sub
        Dim check As Boolean = Not checkForLetter(txtWord.Text) Or Not checkForLetter(txtHint.Text)
        check = check Or (txtWord.Text.Replace(" ", "") = "" Or txtHint.Text.Replace(" ", "") = "")
        check = check Or (cmbCat.SelectedItem.ToString = "Select a Catigory")
        If Not check Then
            Dim bAddA As Boolean = btnAdd.Text = "Add Word"
            Dim cat As wordList = wordLists(cmbCat.Items.IndexOf(cmbCat.SelectedItem) - 1)
            Dim cWord As word = New word("BLANK", "BLANK", True)

            If Not bAddA Then cWord = cat.findWord(lstWords.SelectedItem.ToString)

            If Not cat.checkWordEsxits(txtWord.Text) Or Not bAddA Then
                If bAddA Then : cat.addWord(txtWord.Text, txtHint.Text)
                Else : cWord.update(txtWord.Text, txtHint.Text)
                End If
            Else
                'If btnAdd.Text = "Update Word" Then 
                MsgBox("That word is already in the list!", MsgBoxStyle.Exclamation, "Word Exists!")
                Exit Sub
            End If
        ElseIf cmbCat.SelectedItem.ToString = "Select a Catigory" Then
            MsgBox("You need to select a Catigory first!", MsgBoxStyle.Exclamation, "Missing Catigory!")
            Exit Sub
        ElseIf txtWord.Text.Replace(" ", "") = "" Then
            MsgBox("You need to type in a Word first!", MsgBoxStyle.Exclamation, "Missing Word!")
            Exit Sub
        ElseIf txtHint.Text.Replace(" ", "") = "" Then
            MsgBox("You need to type in a Hint first!", MsgBoxStyle.Exclamation, "Missing Hint!")
            Exit Sub
        ElseIf checkForLetter(txtWord.Text) Or checkForLetter(txtHint.Text) Then
            MsgBox("You need to enter at least one word for the Hint and the Word!", MsgBoxStyle.Exclamation, "Error!")
            Exit Sub
        End If
        refWordList()
        updateWordXML()
        btnClear_Click(Nothing, Nothing, False)
    End Sub

    Private Sub refWordList()
        lstWords.Items.Clear()
        If IsNothing(cmbCat.SelectedItem) Then Exit Sub
        For Each word As word In wordLists(cmbCat.Items.IndexOf(cmbCat.SelectedItem) - 1).words
            If Not word.del Then lstWords.Items.Add(word.wordValOrig)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs, Optional alClear As Boolean = True) Handles btnClear.Click
        'If btnAdd.Text = "Add Word" And alClear Then
        ' btnAdd_Click(btnAdd, Nothing)
        ' Else
        txtWord.Text = ""
        txtHint.Text = ""
        btnAdd.Text = "Add Word"
        refWordList()
        txtWord.Focus()

        'End If
    End Sub

    Private Sub picMute_Click(sender As Object, e As EventArgs) Handles picMute.Click
        frmMain.musicPic(sender)
    End Sub
End Class