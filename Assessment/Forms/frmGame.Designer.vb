<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.lblHint = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.btnLoadButton = New System.Windows.Forms.Button()
        Me.lblHyphen = New System.Windows.Forms.Label()
        Me.pnlLetters = New System.Windows.Forms.Panel()
        Me.lblLetterB = New System.Windows.Forms.Label()
        Me.lblLetterC = New System.Windows.Forms.Label()
        Me.lblLetterD = New System.Windows.Forms.Label()
        Me.lblLetterA = New System.Windows.Forms.Label()
        Me.lblLetterE = New System.Windows.Forms.Label()
        Me.lblLetterF = New System.Windows.Forms.Label()
        Me.lblLetterG = New System.Windows.Forms.Label()
        Me.lblLetterH = New System.Windows.Forms.Label()
        Me.lblLetterI = New System.Windows.Forms.Label()
        Me.lblLetterJ = New System.Windows.Forms.Label()
        Me.lblLetterK = New System.Windows.Forms.Label()
        Me.lblLetterL = New System.Windows.Forms.Label()
        Me.lblLetterM = New System.Windows.Forms.Label()
        Me.lblLetterN = New System.Windows.Forms.Label()
        Me.lblLetterO = New System.Windows.Forms.Label()
        Me.lblLetterP = New System.Windows.Forms.Label()
        Me.lblLetterQ = New System.Windows.Forms.Label()
        Me.lblLetterR = New System.Windows.Forms.Label()
        Me.lblLetterS = New System.Windows.Forms.Label()
        Me.lblLetterT = New System.Windows.Forms.Label()
        Me.lblLetterU = New System.Windows.Forms.Label()
        Me.lblLetterV = New System.Windows.Forms.Label()
        Me.lblLetterW = New System.Windows.Forms.Label()
        Me.lblLetterX = New System.Windows.Forms.Label()
        Me.lblLetterY = New System.Windows.Forms.Label()
        Me.lblLetterZ = New System.Windows.Forms.Label()
        Me.picHangman = New System.Windows.Forms.PictureBox()
        Me.ilsHangmen = New System.Windows.Forms.ImageList(Me.components)
        Me.UclHomeExit1 = New Assessment.uclHomeExit()
        Me.pnlLetters.SuspendLayout()
        CType(Me.picHangman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.BackColor = System.Drawing.Color.Transparent
        Me.lblHint.Location = New System.Drawing.Point(180, 97)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(26, 13)
        Me.lblHint.TabIndex = 8
        Me.lblHint.Text = "Hint"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Location = New System.Drawing.Point(126, 115)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(35, 13)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = "Score"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Location = New System.Drawing.Point(95, 77)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Name"
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.BackColor = System.Drawing.Color.Transparent
        Me.lblWord.Location = New System.Drawing.Point(143, 62)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(33, 13)
        Me.lblWord.TabIndex = 11
        Me.lblWord.Text = "Word"
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.BackColor = System.Drawing.Color.Transparent
        Me.lblCat.Location = New System.Drawing.Point(193, 147)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(23, 13)
        Me.lblCat.TabIndex = 12
        Me.lblCat.Text = "Cat"
        '
        'btnLoadButton
        '
        Me.btnLoadButton.Location = New System.Drawing.Point(330, 166)
        Me.btnLoadButton.Name = "btnLoadButton"
        Me.btnLoadButton.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadButton.TabIndex = 13
        Me.btnLoadButton.Text = "go"
        Me.btnLoadButton.UseVisualStyleBackColor = True
        '
        'lblHyphen
        '
        Me.lblHyphen.AutoSize = True
        Me.lblHyphen.BackColor = System.Drawing.Color.Transparent
        Me.lblHyphen.Location = New System.Drawing.Point(105, 166)
        Me.lblHyphen.Name = "lblHyphen"
        Me.lblHyphen.Size = New System.Drawing.Size(44, 13)
        Me.lblHyphen.TabIndex = 14
        Me.lblHyphen.Text = "Hyphen"
        '
        'pnlLetters
        '
        Me.pnlLetters.BackColor = System.Drawing.Color.Transparent
        Me.pnlLetters.Controls.Add(Me.lblLetterZ)
        Me.pnlLetters.Controls.Add(Me.lblLetterY)
        Me.pnlLetters.Controls.Add(Me.lblLetterX)
        Me.pnlLetters.Controls.Add(Me.lblLetterW)
        Me.pnlLetters.Controls.Add(Me.lblLetterV)
        Me.pnlLetters.Controls.Add(Me.lblLetterU)
        Me.pnlLetters.Controls.Add(Me.lblLetterT)
        Me.pnlLetters.Controls.Add(Me.lblLetterS)
        Me.pnlLetters.Controls.Add(Me.lblLetterR)
        Me.pnlLetters.Controls.Add(Me.lblLetterQ)
        Me.pnlLetters.Controls.Add(Me.lblLetterP)
        Me.pnlLetters.Controls.Add(Me.lblLetterO)
        Me.pnlLetters.Controls.Add(Me.lblLetterN)
        Me.pnlLetters.Controls.Add(Me.lblLetterM)
        Me.pnlLetters.Controls.Add(Me.lblLetterL)
        Me.pnlLetters.Controls.Add(Me.lblLetterK)
        Me.pnlLetters.Controls.Add(Me.lblLetterJ)
        Me.pnlLetters.Controls.Add(Me.lblLetterI)
        Me.pnlLetters.Controls.Add(Me.lblLetterH)
        Me.pnlLetters.Controls.Add(Me.lblLetterG)
        Me.pnlLetters.Controls.Add(Me.lblLetterF)
        Me.pnlLetters.Controls.Add(Me.lblLetterE)
        Me.pnlLetters.Controls.Add(Me.lblLetterB)
        Me.pnlLetters.Controls.Add(Me.lblLetterC)
        Me.pnlLetters.Controls.Add(Me.lblLetterD)
        Me.pnlLetters.Controls.Add(Me.lblLetterA)
        Me.pnlLetters.Location = New System.Drawing.Point(82, 280)
        Me.pnlLetters.Name = "pnlLetters"
        Me.pnlLetters.Size = New System.Drawing.Size(615, 116)
        Me.pnlLetters.TabIndex = 23
        '
        'lblLetterB
        '
        Me.lblLetterB.AutoSize = True
        Me.lblLetterB.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterB.Location = New System.Drawing.Point(49, 14)
        Me.lblLetterB.Name = "lblLetterB"
        Me.lblLetterB.Size = New System.Drawing.Size(34, 33)
        Me.lblLetterB.TabIndex = 26
        Me.lblLetterB.Text = "B"
        '
        'lblLetterC
        '
        Me.lblLetterC.AutoSize = True
        Me.lblLetterC.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterC.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterC.Location = New System.Drawing.Point(81, 14)
        Me.lblLetterC.Name = "lblLetterC"
        Me.lblLetterC.Size = New System.Drawing.Size(36, 33)
        Me.lblLetterC.TabIndex = 25
        Me.lblLetterC.Text = "C"
        '
        'lblLetterD
        '
        Me.lblLetterD.AutoSize = True
        Me.lblLetterD.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterD.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterD.Location = New System.Drawing.Point(116, 14)
        Me.lblLetterD.Name = "lblLetterD"
        Me.lblLetterD.Size = New System.Drawing.Size(36, 33)
        Me.lblLetterD.TabIndex = 24
        Me.lblLetterD.Text = "D"
        '
        'lblLetterA
        '
        Me.lblLetterA.AutoSize = True
        Me.lblLetterA.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterA.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterA.Location = New System.Drawing.Point(18, 14)
        Me.lblLetterA.Name = "lblLetterA"
        Me.lblLetterA.Size = New System.Drawing.Size(34, 33)
        Me.lblLetterA.TabIndex = 23
        Me.lblLetterA.Text = "A"
        '
        'lblLetterE
        '
        Me.lblLetterE.AutoSize = True
        Me.lblLetterE.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterE.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterE.Location = New System.Drawing.Point(158, 14)
        Me.lblLetterE.Name = "lblLetterE"
        Me.lblLetterE.Size = New System.Drawing.Size(34, 33)
        Me.lblLetterE.TabIndex = 27
        Me.lblLetterE.Text = "E"
        '
        'lblLetterF
        '
        Me.lblLetterF.AutoSize = True
        Me.lblLetterF.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterF.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterF.Location = New System.Drawing.Point(198, 14)
        Me.lblLetterF.Name = "lblLetterF"
        Me.lblLetterF.Size = New System.Drawing.Size(33, 33)
        Me.lblLetterF.TabIndex = 28
        Me.lblLetterF.Text = "F"
        '
        'lblLetterG
        '
        Me.lblLetterG.AutoSize = True
        Me.lblLetterG.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterG.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterG.Location = New System.Drawing.Point(237, 14)
        Me.lblLetterG.Name = "lblLetterG"
        Me.lblLetterG.Size = New System.Drawing.Size(38, 33)
        Me.lblLetterG.TabIndex = 29
        Me.lblLetterG.Text = "G"
        '
        'lblLetterH
        '
        Me.lblLetterH.AutoSize = True
        Me.lblLetterH.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterH.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterH.Location = New System.Drawing.Point(281, 14)
        Me.lblLetterH.Name = "lblLetterH"
        Me.lblLetterH.Size = New System.Drawing.Size(36, 33)
        Me.lblLetterH.TabIndex = 30
        Me.lblLetterH.Text = "H"
        '
        'lblLetterI
        '
        Me.lblLetterI.AutoSize = True
        Me.lblLetterI.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterI.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterI.Location = New System.Drawing.Point(311, 14)
        Me.lblLetterI.Name = "lblLetterI"
        Me.lblLetterI.Size = New System.Drawing.Size(23, 33)
        Me.lblLetterI.TabIndex = 31
        Me.lblLetterI.Text = "I"
        '
        'lblLetterJ
        '
        Me.lblLetterJ.AutoSize = True
        Me.lblLetterJ.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterJ.Location = New System.Drawing.Point(323, 14)
        Me.lblLetterJ.Name = "lblLetterJ"
        Me.lblLetterJ.Size = New System.Drawing.Size(30, 33)
        Me.lblLetterJ.TabIndex = 32
        Me.lblLetterJ.Text = "J"
        '
        'lblLetterK
        '
        Me.lblLetterK.AutoSize = True
        Me.lblLetterK.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterK.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterK.Location = New System.Drawing.Point(359, 14)
        Me.lblLetterK.Name = "lblLetterK"
        Me.lblLetterK.Size = New System.Drawing.Size(34, 33)
        Me.lblLetterK.TabIndex = 33
        Me.lblLetterK.Text = "K"
        '
        'lblLetterL
        '
        Me.lblLetterL.AutoSize = True
        Me.lblLetterL.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterL.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterL.Location = New System.Drawing.Point(399, 14)
        Me.lblLetterL.Name = "lblLetterL"
        Me.lblLetterL.Size = New System.Drawing.Size(31, 33)
        Me.lblLetterL.TabIndex = 34
        Me.lblLetterL.Text = "L"
        '
        'lblLetterM
        '
        Me.lblLetterM.AutoSize = True
        Me.lblLetterM.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterM.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterM.Location = New System.Drawing.Point(436, 14)
        Me.lblLetterM.Name = "lblLetterM"
        Me.lblLetterM.Size = New System.Drawing.Size(39, 33)
        Me.lblLetterM.TabIndex = 35
        Me.lblLetterM.Text = "M"
        '
        'lblLetterN
        '
        Me.lblLetterN.AutoSize = True
        Me.lblLetterN.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterN.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterN.Location = New System.Drawing.Point(481, 14)
        Me.lblLetterN.Name = "lblLetterN"
        Me.lblLetterN.Size = New System.Drawing.Size(36, 33)
        Me.lblLetterN.TabIndex = 36
        Me.lblLetterN.Text = "N"
        '
        'lblLetterO
        '
        Me.lblLetterO.AutoSize = True
        Me.lblLetterO.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterO.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterO.Location = New System.Drawing.Point(523, 14)
        Me.lblLetterO.Name = "lblLetterO"
        Me.lblLetterO.Size = New System.Drawing.Size(38, 33)
        Me.lblLetterO.TabIndex = 37
        Me.lblLetterO.Text = "O"
        '
        'lblLetterP
        '
        Me.lblLetterP.AutoSize = True
        Me.lblLetterP.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterP.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterP.Location = New System.Drawing.Point(49, 47)
        Me.lblLetterP.Name = "lblLetterP"
        Me.lblLetterP.Size = New System.Drawing.Size(34, 33)
        Me.lblLetterP.TabIndex = 38
        Me.lblLetterP.Text = "P"
        '
        'lblLetterQ
        '
        Me.lblLetterQ.AutoSize = True
        Me.lblLetterQ.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterQ.Location = New System.Drawing.Point(81, 47)
        Me.lblLetterQ.Name = "lblLetterQ"
        Me.lblLetterQ.Size = New System.Drawing.Size(38, 33)
        Me.lblLetterQ.TabIndex = 39
        Me.lblLetterQ.Text = "Q"
        '
        'lblLetterR
        '
        Me.lblLetterR.AutoSize = True
        Me.lblLetterR.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterR.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterR.Location = New System.Drawing.Point(116, 47)
        Me.lblLetterR.Name = "lblLetterR"
        Me.lblLetterR.Size = New System.Drawing.Size(36, 33)
        Me.lblLetterR.TabIndex = 40
        Me.lblLetterR.Text = "R"
        '
        'lblLetterS
        '
        Me.lblLetterS.AutoSize = True
        Me.lblLetterS.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterS.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterS.Location = New System.Drawing.Point(158, 47)
        Me.lblLetterS.Name = "lblLetterS"
        Me.lblLetterS.Size = New System.Drawing.Size(34, 33)
        Me.lblLetterS.TabIndex = 41
        Me.lblLetterS.Text = "S"
        '
        'lblLetterT
        '
        Me.lblLetterT.AutoSize = True
        Me.lblLetterT.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterT.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterT.Location = New System.Drawing.Point(198, 47)
        Me.lblLetterT.Name = "lblLetterT"
        Me.lblLetterT.Size = New System.Drawing.Size(33, 33)
        Me.lblLetterT.TabIndex = 42
        Me.lblLetterT.Text = "T"
        '
        'lblLetterU
        '
        Me.lblLetterU.AutoSize = True
        Me.lblLetterU.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterU.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterU.Location = New System.Drawing.Point(237, 47)
        Me.lblLetterU.Name = "lblLetterU"
        Me.lblLetterU.Size = New System.Drawing.Size(36, 33)
        Me.lblLetterU.TabIndex = 43
        Me.lblLetterU.Text = "U"
        '
        'lblLetterV
        '
        Me.lblLetterV.AutoSize = True
        Me.lblLetterV.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterV.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterV.Location = New System.Drawing.Point(279, 47)
        Me.lblLetterV.Name = "lblLetterV"
        Me.lblLetterV.Size = New System.Drawing.Size(34, 33)
        Me.lblLetterV.TabIndex = 44
        Me.lblLetterV.Text = "V"
        '
        'lblLetterW
        '
        Me.lblLetterW.AutoSize = True
        Me.lblLetterW.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterW.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterW.Location = New System.Drawing.Point(323, 47)
        Me.lblLetterW.Name = "lblLetterW"
        Me.lblLetterW.Size = New System.Drawing.Size(42, 33)
        Me.lblLetterW.TabIndex = 45
        Me.lblLetterW.Text = "W"
        '
        'lblLetterX
        '
        Me.lblLetterX.AutoSize = True
        Me.lblLetterX.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterX.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterX.Location = New System.Drawing.Point(371, 47)
        Me.lblLetterX.Name = "lblLetterX"
        Me.lblLetterX.Size = New System.Drawing.Size(34, 33)
        Me.lblLetterX.TabIndex = 46
        Me.lblLetterX.Text = "X"
        '
        'lblLetterY
        '
        Me.lblLetterY.AutoSize = True
        Me.lblLetterY.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterY.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterY.Location = New System.Drawing.Point(411, 47)
        Me.lblLetterY.Name = "lblLetterY"
        Me.lblLetterY.Size = New System.Drawing.Size(35, 33)
        Me.lblLetterY.TabIndex = 47
        Me.lblLetterY.Text = "Y"
        '
        'lblLetterZ
        '
        Me.lblLetterZ.AutoSize = True
        Me.lblLetterZ.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterZ.Location = New System.Drawing.Point(452, 47)
        Me.lblLetterZ.Name = "lblLetterZ"
        Me.lblLetterZ.Size = New System.Drawing.Size(33, 33)
        Me.lblLetterZ.TabIndex = 48
        Me.lblLetterZ.Text = "Z"
        '
        'picHangman
        '
        Me.picHangman.BackColor = System.Drawing.Color.Transparent
        Me.picHangman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picHangman.InitialImage = Nothing
        Me.picHangman.Location = New System.Drawing.Point(516, 1)
        Me.picHangman.Name = "picHangman"
        Me.picHangman.Size = New System.Drawing.Size(256, 256)
        Me.picHangman.TabIndex = 49
        Me.picHangman.TabStop = False
        '
        'ilsHangmen
        '
        Me.ilsHangmen.ImageStream = CType(resources.GetObject("ilsHangmen.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilsHangmen.TransparentColor = System.Drawing.Color.Transparent
        Me.ilsHangmen.Images.SetKeyName(0, "Hangman-6.png")
        Me.ilsHangmen.Images.SetKeyName(1, "Hangman-5.png")
        Me.ilsHangmen.Images.SetKeyName(2, "Hangman-4.png")
        Me.ilsHangmen.Images.SetKeyName(3, "Hangman-3.png")
        Me.ilsHangmen.Images.SetKeyName(4, "Hangman-2.png")
        Me.ilsHangmen.Images.SetKeyName(5, "Hangman-1.png")
        Me.ilsHangmen.Images.SetKeyName(6, "Hangman-0.png")
        '
        'UclHomeExit1
        '
        Me.UclHomeExit1.BackColor = System.Drawing.Color.Transparent
        Me.UclHomeExit1.Location = New System.Drawing.Point(3, 1)
        Me.UclHomeExit1.Name = "UclHomeExit1"
        Me.UclHomeExit1.Size = New System.Drawing.Size(131, 29)
        Me.UclHomeExit1.TabIndex = 7
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assessment.My.Resources.Resources.Backgroundtest
        Me.ClientSize = New System.Drawing.Size(784, 586)
        Me.Controls.Add(Me.picHangman)
        Me.Controls.Add(Me.pnlLetters)
        Me.Controls.Add(Me.lblHyphen)
        Me.Controls.Add(Me.btnLoadButton)
        Me.Controls.Add(Me.lblCat)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.UclHomeExit1)
        Me.MaximizeBox = False
        Me.Name = "frmGame"
        Me.Text = "Divisions of Science"
        Me.pnlLetters.ResumeLayout(False)
        Me.pnlLetters.PerformLayout()
        CType(Me.picHangman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UclHomeExit1 As Assessment.uclHomeExit
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblWord As System.Windows.Forms.Label
    Friend WithEvents lblCat As System.Windows.Forms.Label
    Friend WithEvents btnLoadButton As System.Windows.Forms.Button
    Friend WithEvents lblHyphen As System.Windows.Forms.Label
    Friend WithEvents pnlLetters As System.Windows.Forms.Panel
    Friend WithEvents lblLetterB As System.Windows.Forms.Label
    Friend WithEvents lblLetterC As System.Windows.Forms.Label
    Friend WithEvents lblLetterD As System.Windows.Forms.Label
    Friend WithEvents lblLetterA As System.Windows.Forms.Label
    Friend WithEvents lblLetterH As System.Windows.Forms.Label
    Friend WithEvents lblLetterG As System.Windows.Forms.Label
    Friend WithEvents lblLetterF As System.Windows.Forms.Label
    Friend WithEvents lblLetterE As System.Windows.Forms.Label
    Friend WithEvents lblLetterZ As System.Windows.Forms.Label
    Friend WithEvents lblLetterY As System.Windows.Forms.Label
    Friend WithEvents lblLetterX As System.Windows.Forms.Label
    Friend WithEvents lblLetterW As System.Windows.Forms.Label
    Friend WithEvents lblLetterV As System.Windows.Forms.Label
    Friend WithEvents lblLetterU As System.Windows.Forms.Label
    Friend WithEvents lblLetterT As System.Windows.Forms.Label
    Friend WithEvents lblLetterS As System.Windows.Forms.Label
    Friend WithEvents lblLetterR As System.Windows.Forms.Label
    Friend WithEvents lblLetterQ As System.Windows.Forms.Label
    Friend WithEvents lblLetterP As System.Windows.Forms.Label
    Friend WithEvents lblLetterO As System.Windows.Forms.Label
    Friend WithEvents lblLetterN As System.Windows.Forms.Label
    Friend WithEvents lblLetterM As System.Windows.Forms.Label
    Friend WithEvents lblLetterL As System.Windows.Forms.Label
    Friend WithEvents lblLetterK As System.Windows.Forms.Label
    Friend WithEvents lblLetterJ As System.Windows.Forms.Label
    Friend WithEvents lblLetterI As System.Windows.Forms.Label
    Friend WithEvents picHangman As System.Windows.Forms.PictureBox
    Friend WithEvents ilsHangmen As System.Windows.Forms.ImageList
End Class
