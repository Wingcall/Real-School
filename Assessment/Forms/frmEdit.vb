Public Class frmEdit
    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing
        frmMain.musicPic(picMute, False)

        cmbCat.Items.Add("Select a Catigory")

        For Each cat As wordList In wordLists :
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
        If cmbCat.SelectedItem.ToString = "Select a Catigory" Then lstWords.Items.Clear() : Exit Sub

        btnAdd.Text = "Update Word"

        Dim cat As wordList = wordLists(cmbCat.Items.IndexOf(cmbCat.SelectedItem) - 1)
        Dim cWord As word = cat.findWord(lstWords.SelectedItem.ToString)

        txtWord.Text = cWord.wordValOrig
        txtHint.Text = cWord.hint
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If IsNothing(lstWords.SelectedItem) And cmbCat.SelectedItem.ToString = "Select a Catigory" Then Exit Sub

        Dim res As Int16 = MsgBox("Are you sure you wish to delete this word?", MsgBoxStyle.YesNo, "Delete Word")
        If res = MsgBoxResult.No Then Exit Sub
        Dim cat As wordList = wordLists(cmbCat.Items.IndexOf(cmbCat.SelectedItem) - 1)
        cat.findWord(lstWords.SelectedItem.ToString).delWord()
        lstWords.Items.Clear()
        refWordList()
        updateWordXML()
    End Sub

    Function checkForLetter(inStr As String)
        For Each tChar As Char In inStr.ToUpper
            If Not alphabet.IndexOfAny(tChar.ToString) = -1 Then Return True
        Next
        Return False
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add Word" Then
            Dim check As Boolean = Not checkForLetter(txtWord.Text) Or Not checkForLetter(txtHint.Text)
            check = check Or (txtWord.Text.Replace(" ", "") = "" Or txtHint.Text.Replace(" ", "") = "")
            check = check Or (cmbCat.SelectedItem.ToString = "Select a Catigory")
            If Not check Then
                Dim cat As wordList = wordLists(cmbCat.Items.IndexOf(cmbCat.SelectedItem) - 1)
                If Not cat.checkWordEsxits(txtWord.Text) Then
                    cat.addWord(txtWord.Text, txtHint.Text)
                Else
                    Exit Sub
                End If
            ElseIf checkForLetter(txtWord.Text) Or checkForLetter(txtHint.Text) Then
                MsgBox("You need to enter at least one word for the Hint and the Word!", MsgBoxStyle.Exclamation, "Error!")
                Exit Sub
            ElseIf cmbCat.SelectedItem.ToString = "Select a Catigory" Then
                MsgBox("You Need to select a Catigory first!", MsgBoxStyle.Exclamation, "Missing")
                Exit Sub
            ElseIf txtWord.Text.Replace(" ", "") = "" Then
                MsgBox("Bad!, no word!")
                Exit Sub
            ElseIf txtHint.Text.Replace(" ", "") = "" Then
                MsgBox("Bad!, no hint!")
                Exit Sub
            End If
            refWordList()
            updateWordXML()
        Else
            Dim check As Boolean = (txtWord.Text.Replace(" ", "") = "" Or txtHint.Text.Replace(" ", "") = "")
            check = check Or (cmbCat.SelectedItem.ToString = "Select a Catigory")
            If Not check Then
                Dim cat As wordList = wordLists(cmbCat.Items.IndexOf(cmbCat.SelectedItem) - 1)
                Dim word As word = cat.findWord(lstWords.SelectedItem.ToString)
                If Not cat.checkWordEsxits(txtWord.Text) Then
                    word.wordVal = txtWord.Text
                    word.hint = txtHint.Text
                Else
                    MsgBox("Bad, no Dupes!")
                    Exit Sub
                End If
            ElseIf cmbCat.SelectedItem.ToString = "Select a Catigory" Then
                MsgBox("Bad!, no cat!")
                Exit Sub
            ElseIf txtWord.Text.Replace(" ", "") = "" Then
                MsgBox("Bad!, no word!")
                Exit Sub
            ElseIf txtHint.Text.Replace(" ", "") = "" Then
                MsgBox("Bad!, no hint!")
                Exit Sub
            End If
            refWordList()
            updateWordXML()
        End If
    End Sub

    Private Sub refWordList()
        lstWords.Items.Clear()
        For Each word As word In wordLists(cmbCat.Items.IndexOf(cmbCat.SelectedItem) - 1).words
            If Not word.del Then lstWords.Items.Add(word.wordValOrig)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If btnAdd.Text = "Add Word" Then
            btnAdd_Click(btnAdd, Nothing)
        Else
            txtWord.Text = ""
            txtHint.Text = ""
            btnAdd.Text = "Add Word"
        End If
    End Sub

    Private Sub picMute_Click(sender As Object, e As EventArgs) Handles picMute.Click
        frmMain.musicPic(sender)
    End Sub
End Class