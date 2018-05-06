Imports System.Xml
Module XML_DB
    Private ReadOnly appPath As String = My.Application.Info.DirectoryPath 'Make the app path simpler
    Private ReadOnly userPath As String = appPath & "\XML_Files\users.xml" 'The path to the users file
    Private ReadOnly wordPath As String = appPath & "\XML_Files\words.xml" 'The path to the word lists

    Public userInfo(3) As Object ' Due to non-dynamic arrays (Its too hard) there is a set amount of users allowed, this can be changed to anything above -1
    Public wordLists(2) As Object

    Public Sub loadUserDB()
        Dim doc As New XmlDocument() 'Create a var to hold the users xml file
        doc.Load(userPath) ' load the users file

        Dim nodes As XmlNodeList = doc.DocumentElement.SelectNodes("/users/user") 'Create a list of all the "user" elements in the DB
        For Each node As XmlNode In nodes 'For each element or user do
            Dim id As Int16, name As String, score As Integer 'Create some temp vars
            If Not (node.Attributes(0).Value < userInfo.Length) Then Exit For 'Quit the for loop if we have to many users in the XML file
            id = node.Attributes(0).Value 'Get the id of the user
            name = node.SelectSingleNode("name").InnerText 'Get the users name
            score = node.SelectSingleNode("score").InnerText 'Get the users score
            userInfo(id) = New playerInfo({id, name, score}) 'Create a plsyer object from the users info, and store it in the userInfo array
            'Console.WriteLine("id: " & id & " Name: " & name & " Score: " & score)
        Next 'Loop

        'Check that there is a player object in every slot of the array.
        'This could happen if there was not enough entrys in the XML File
        Dim x As Integer 'Create a tmp var
        For Each item As Object In userInfo 'For every space in the userInfo array do
            If IsNothing(item) Then 'Check if the spot is blank
                userInfo(x) = New playerInfo({x, "New Player!", 0}) 'If it is then create a new/default player object
            End If
            x += 1 'Add one to the temp var
        Next
        printUserInfo()
    End Sub

    Sub printUserInfo()
        For Each user As Object In userInfo
            Console.Write("id: " & user.id)
            Console.Write(", Name: " & user.name)
            Console.Write(", Score: " & user.score & vbNewLine)
        Next
    End Sub

End Module
