Imports System.Runtime.CompilerServices
'This module extends exsiting functions
Module extensions
    <Extension()> _
    Public Sub add(Of T)(ByRef arr As T(), item As T, Optional limit As Integer = -1, Optional lock As Boolean = False)
        If IsNothing(arr) Then
            Throw New ArgumentException("Your Array is empty, have at least 1 (0) spaces!")
        End If

        If (limit > -1) And (arr.Length >= limit) And Not lock Then
            Console.WriteLine("Hello, someone is adding over there limit...")
            Exit Sub
        End If

        If Not (arr.Length = 0) Then
            Dim x As Integer = 0
            For Each itemX As Object In arr
                If IsNothing(itemX) Then
                    arr(x) = item
                    Exit Sub
                End If
                x += 1
            Next
            If Not lock Then
                Array.Resize(arr, arr.Length + 1)
                arr(arr.Length - 1) = item
            Else
                Console.WriteLine("Hey, Someone is adding when this array is locked.")
            End If
            Exit Sub
        Else
            arr(0) = item
            Exit Sub
        End If
    End Sub

    <Extension()>
    Public Sub openForm(ByVal form As Form) 'Exstention to the forms
        form.Show() 'Show the selected form
        frmMain.Hide() 'Hide the main form
    End Sub
End Module
