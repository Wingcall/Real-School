Imports System.Xml
Module XML_DB
    Private ReadOnly appPath As String = My.Application.Info.DirectoryPath 'Make the app path simpler
    Private ReadOnly userPath As String = appPath & "\XML_Files\users.xml" 'The path to the users file
    Private ReadOnly wordPath As String = appPath & "\XML_Files\words.xml" 'The path to the word lists

    Private ReadOnly userLimit As Int16 = 4 'Wow, ok before you yell at me for magic numbers, this is a limit we chose to impliment.

    Public userInfo(0) As playerInfo 'This is now dynamic using Array.add
    Public wordLists(0) As wordList

    Public Sub loadWordDB()
        Dim doc As New XmlDocument() 'Create a var to hold the users xml file
        doc.Load(wordPath) ' load the users file

        Dim nodes As XmlNodeList = doc.DocumentElement.SelectNodes("/wordList/category") 'Create a list of all the "user" elements in the DB
        For Each node As XmlNode In nodes 'For each element or user do
            Dim id As Int16, name As String 'Create some temp vars
            'If Not (node.Attributes(0).Value < wordLists.Length) Then Exit For 'Quit the for loop if we have to many users in the XML file
            id = node.Attributes(0).Value 'Get the id of the list
            name = node.SelectSingleNode("name").InnerText 'Get the list name
            wordLists.add(New wordList(id, name)) 'Create a plsyer object from the users info, and store it in the userInfo array

            Dim docX As New XmlDocument()
            docX.LoadXml("<root>" & node.InnerXml & "</root>")
            Dim nodesX As XmlNodeList = docX.DocumentElement.SelectNodes("/root/words/word")
            For Each nodeX As XmlNode In nodesX
                Dim word, hint As String
                word = nodeX.SelectSingleNode("name").InnerText
                hint = nodeX.SelectSingleNode("hint").InnerText
                wordLists.Last.addWord(word, hint)
            Next

            'Console.WriteLine("id: " & id & " Name: " & name & " Score: " & score)
        Next 'Loop
        'printCatInfo()
    End Sub

    Public Sub loadUserDB()
        Dim doc As New XmlDocument() 'Create a var to hold the users xml file
        doc.Load(userPath) ' load the users file

        Dim nodes As XmlNodeList = doc.DocumentElement.SelectNodes("/users/user") 'Create a list of all the "user" elements in the DB
        For Each node As XmlNode In nodes 'For each element or user do
            Dim id As Int16, name As String, score As Integer 'Create some temp vars
            'If Not (node.Attributes(0).Value < userInfo.Length) Then Exit For 'Quit the for loop if we have to many users in the XML file
            id = node.Attributes(0).Value 'Get the id of the user
            name = node.SelectSingleNode("name").InnerText 'Get the users name
            score = node.SelectSingleNode("score").InnerText 'Get the users score
            userInfo.add(New playerInfo({id, name, score}), userLimit) 'Create a player object from the users info, and store it in the userInfo array
            'Console.WriteLine("id: " & id & " Name: " & name & " Score: " & score)
        Next 'Loop

        printUserInfo()
    End Sub

    Sub printUserInfo()
        For Each user As Object In userInfo
            Console.Write("id: " & user.id)
            Console.Write(", Name: " & user.name)
            Console.Write(", Score: " & user.score & vbNewLine)
        Next
    End Sub

    Sub printCatInfo()
        For Each cat As Object In wordLists
            Console.WriteLine()
            Console.WriteLine("###################################")
            Console.Write("id: " & cat.id)
            Console.Write(", Name: " & cat.name & vbNewLine)
            Console.WriteLine("Word List")
            Console.WriteLine("===================================")
            cat.printList()
            Console.WriteLine("===================================")
        Next
    End Sub

    Public Sub updateWordXML()
        Dim XML As String = "<wordList>"
        For Each cat As wordList In wordLists
            XML += "<category id=" & ControlChars.Quote & cat.id & ControlChars.Quote & ">"
            XML += "<name>" & cat.name & "</name>"
            XML += "<words>"
            For Each word As word In cat.words
                If Not word.del Then
                    XML += "<word>"
                    XML += "<name>" & word.wordVal & "</name>"
                    XML += "<hint>" & word.hint & "</hint>"
                    XML += "</word>"
                End If
            Next
            XML += "</words>"
            XML += "</category>"
        Next
        XML += "</wordList>"
        XML = prettyXML(XML).Replace("utf-16", "utf-8")
        writeFile(wordPath, XML)
    End Sub

    Public Sub updateUserXML()
        Dim XML As String = "<users>"
        For Each user As playerInfo In userInfo
            XML += "<user id=" & ControlChars.Quote & user.id & ControlChars.Quote & ">"
            XML += "<name>" & user.name & "</name>"
            XML += "<score>" & user.score & "</score>"
            XML += "</user>"
        Next
        XML += "</users>"
        XML = prettyXML(XML).Replace("utf-16", "utf-8")
        writeFile(userPath, XML)
    End Sub

    Public Function getWord(cat As Int16, word As Integer)
        Return wordLists(cat).words(word)
    End Function

    Public Function getRWord(cat As Int16)
        Return wordLists(cat).randomWord()
    End Function

    Public Sub loadDB()
        loadWordDB()
        loadUserDB()
        'updateWordXML()
        'updateUserXML()
    End Sub

    Function prettyXML(XMLString As String)
        Dim sw As New IO.StringWriter()
        Dim xw As New XmlTextWriter(sw)
        xw.Formatting = Formatting.Indented
        xw.Indentation = 4
        Dim doc As New XmlDocument
        doc.LoadXml(XMLString)
        doc.Save(xw)
        Return sw.ToString()
    End Function

    Sub writeFile(file, text)
        Using writer As IO.StreamWriter = New IO.StreamWriter(file, False)
            writer.Write(text)
        End Using
    End Sub

End Module
