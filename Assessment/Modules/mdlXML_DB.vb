Imports System.Xml
Module XML_DB
    Private ReadOnly appPath As String = My.Application.Info.DirectoryPath 'Make the app path simpler
    Private ReadOnly userPath As String = appPath & "\XML_Files\users.xml" 'The path to the users file
    Private ReadOnly wordPath As String = appPath & "\XML_Files\words.xml" 'The path to the word lists

    Private ReadOnly userLimit As Int16 = 4 'Wow, ok before you yell at me for magic numbers, this is a limit we chose to impliment.

    Public userInfo(0) As playerInfo 'This is now dynamic using Array.add
    Public wordLists(0) As wordList 'This is now dynamic using Array.add

    Public Sub loadWordDB()
        ReDim wordLists(0) 'clear the word lists
        Dim doc As New XmlDocument() 'Create a var to hold the users xml file
        doc.Load(wordPath) ' load the users file

        Dim nodes As XmlNodeList = doc.DocumentElement.SelectNodes("/wordList/category") 'Create a list of all the "user" elements in the DB
        For Each node As XmlNode In nodes 'For each element or user do
            Dim id As Int16, name As String 'Create some temp vars
            'If Not (node.Attributes(0).Value < wordLists.Length) Then Exit For 'Quit the for loop if we have to many users in the XML file
            id = node.Attributes(0).Value 'Get the id of the list
            name = node.SelectSingleNode("name").InnerText 'Get the list name
            wordLists.add(New wordList(id, name)) 'Create a plsyer object from the users info, and store it in the userInfo array

            Dim docX As New XmlDocument() 'Create a var to hold the users xml file
            docX.LoadXml("<root>" & node.InnerXml & "</root>") 'load the word lists
            Dim nodesX As XmlNodeList = docX.DocumentElement.SelectNodes("/root/words/word") 'Create a list of all the "user" elements in the DB
            For Each nodeX As XmlNode In nodesX 'for each word in the xml word DB in the current category
                Dim word, hint As String
                word = nodeX.SelectSingleNode("name").InnerText 'get the word
                hint = nodeX.SelectSingleNode("hint").InnerText 'get the hint
                wordLists.Last.addWord(word, hint) 'add the word/hint into the category
            Next

            'Console.WriteLine("id: " & id & " Name: " & name & " Score: " & score)
        Next 'Loop
        'printCatInfo()
    End Sub

    Public Sub loadUserDB()
        ReDim userInfo(0) 'clear the user db
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

        'printUserInfo()
    End Sub

    '==========This is all debug functions==========
    Sub printUserInfo() 'this just prints all the users and thee scores
        For Each user As Object In userInfo
            Console.Write("id: " & user.id)
            Console.Write(", Name: " & user.name)
            Console.Write(", Score: " & user.score & vbNewLine)
        Next
    End Sub

    Sub printCatInfo() 'this justs prints all the words in all the categorys
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
    '===========End Debug Functions=================

    Public Sub updateWordXML() 'this updates the word lists
        Dim XML As String = "<wordList>" 'start the string
        For Each cat As wordList In wordLists 'for each category in the cat list.
            XML += "<category id=" & ControlChars.Quote & cat.id & ControlChars.Quote & ">" 'add the cat id and open the tag
            XML += "<name>" & cat.name & "</name>" 'add the cat name
            XML += "<words>" 'add the word list
            For Each word As word In cat.words 'for each word in the right category
                If Not word.del Then 'if the word is not to be deleted
                    XML += "<word>" 'open the word tag
                    XML += "<name>" & word.wordValOrig & "</name>" 'add the word
                    XML += "<hint>" & word.hint & "</hint>" 'add the hint
                    XML += "</word>" 'close the word tag
                End If
            Next
            XML += "</words>" 'close the tags
            XML += "</category>"
        Next
        XML += "</wordList>"
        XML = prettyXML(XML).Replace("utf-16", "utf-8") 'Fix the xml headers
        writeFile(wordPath, XML) 'write the xml to the file
    End Sub

    Public Sub updateUserXML() 'update the user xml file
        Dim XML As String = "<users>" 'start the xml
        For Each user As playerInfo In userInfo 'for each player in the player list
            XML += "<user id=" & ControlChars.Quote & user.id & ControlChars.Quote & ">" 'add the id to the string
            XML += "<name>" & user.name & "</name>" 'add the name to the string
            XML += "<score>" & user.score & "</score>" 'add the score to the string
            XML += "</user>" 'close the user tag
        Next
        XML += "</users>" 'close the file
        XML = prettyXML(XML).Replace("utf-16", "utf-8") 'fix some xml-formating
        writeFile(userPath, XML) 'write to the file
    End Sub

    Public Sub loadDB() 'load all the XML-DBs
        loadWordDB() 'load the word db
        loadUserDB() 'load the user db
        'updateWordXML()
        'updateUserXML()
    End Sub

    Function prettyXML(XMLString As String) 'this makes the grnerated xml pretty
        Dim sw As New IO.StringWriter() 'create some buffers
        Dim xw As New XmlTextWriter(sw)
        xw.Formatting = Formatting.Indented 'format the xml
        xw.Indentation = 4 'more formating
        Dim doc As New XmlDocument 'make a tmp doc
        doc.LoadXml(XMLString) 'actuly do the formating
        doc.Save(xw) 'save that formating
        Return sw.ToString() 'return the formated string
    End Function

    Sub writeFile(file, text) 'write text to a file
        Using writer As IO.StreamWriter = New IO.StreamWriter(file, False) 'open a blank file
            writer.Write(text) 'write the text to the file
        End Using
    End Sub

End Module
