Public Class frmEdit
    Dim cLock As Boolean = False, dLock As Boolean = True
    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf formEvents.FormClosing
        loadWordDB()

        cmbCat.Items.Add("Select a Catigory")

        For Each cat As wordList In wordLists
            cmbCat.Items.Add(cat.name)
        Next
        cmbCat.SelectedItem = cmbCat.Items(0)
    End Sub

    Private Sub cmbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCat.SelectedIndexChanged
        If cLock And dLock Then
            cmbCat.Items.Remove(cmbCat.Items(0))
            cLock = False
            Exit Sub
        End If
        If dLock Then
            cLock = True
            dLock = False
        End If


        lstWords.Items.Clear()
        For Each word As word In wordLists(cmbCat.Items.IndexOf(cmbCat.SelectedItem)).words
            lstWords.Items.Add(word.word)
        Next
    End Sub
End Class