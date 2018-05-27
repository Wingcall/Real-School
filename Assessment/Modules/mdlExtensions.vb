'Completed By Cal.W 2018
Imports System.Runtime.CompilerServices
'This module extends exsiting functions
Module extensions
    'HERE BE DRAGONS
    <Extension()> _
    Public Sub add(Of T)(ByRef arr As T(), item As T, Optional limit As Integer = -1, Optional lock As Boolean = False) 'This is an extention to the array object
        If IsNothing(arr) Then
            Throw New ArgumentException("Your Array is empty, have at least 1 (0) spaces!") 'if the array doesnt have one item then throw an error
        End If

        If (limit > -1) And (arr.Length >= limit) And Not lock Then 'If not locked and the limit it below -1 and the limit
            Console.WriteLine("Hello, someone is adding over there limit...")
            Exit Sub
        End If

        If Not (arr.Length = 0) Then 'If the array length is not 0
            Dim x As Integer = 0
            For Each itemX As Object In arr 'for each object in the array
                If IsNothing(itemX) Then 'if it is nothing
                    arr(x) = item 'set the object to the item
                    Exit Sub 'exit the sub
                End If
                x += 1 'increase x
            Next
            If Not lock Then 'if the array is not locked 
                Array.Resize(arr, arr.Length + 1) 'resize the array to the array add 1
                arr(arr.Length - 1) = item 'set the new blank position to the given item
            Else
                Console.WriteLine("Hey, Someone is adding when this array is locked.")
            End If
            Exit Sub
        Else
            arr(0) = item 'Other wise just set the 0th position to the given item
            Exit Sub
        End If
    End Sub

    <Extension()>
    Public Sub openForm(ByVal form As Form) 'Exstention to the forms
        form.Show() 'Show the selected form
        frmMain.Hide() 'Hide the main form
    End Sub

    <Extension()>
    Public Sub closeForm(ByVal form As Form) 'Exstention to the forms
        RemoveHandler form.FormClosing, AddressOf formEvents.FormClosing 'remove handler
        form.Close() 'close form
    End Sub
End Module
