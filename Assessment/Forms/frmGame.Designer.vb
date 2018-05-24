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
        Me.lblCat = New System.Windows.Forms.Label()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.lblHyphen = New System.Windows.Forms.Label()
        Me.pnlLetters = New System.Windows.Forms.Panel()
        Me.lblLetterZ = New System.Windows.Forms.Label()
        Me.lblLetterY = New System.Windows.Forms.Label()
        Me.lblLetterX = New System.Windows.Forms.Label()
        Me.lblLetterW = New System.Windows.Forms.Label()
        Me.lblLetterV = New System.Windows.Forms.Label()
        Me.lblLetterU = New System.Windows.Forms.Label()
        Me.lblLetterT = New System.Windows.Forms.Label()
        Me.lblLetterS = New System.Windows.Forms.Label()
        Me.lblLetterR = New System.Windows.Forms.Label()
        Me.lblLetterQ = New System.Windows.Forms.Label()
        Me.lblLetterP = New System.Windows.Forms.Label()
        Me.lblLetterO = New System.Windows.Forms.Label()
        Me.lblLetterN = New System.Windows.Forms.Label()
        Me.lblLetterM = New System.Windows.Forms.Label()
        Me.lblLetterL = New System.Windows.Forms.Label()
        Me.lblLetterK = New System.Windows.Forms.Label()
        Me.lblLetterJ = New System.Windows.Forms.Label()
        Me.lblLetterI = New System.Windows.Forms.Label()
        Me.lblLetterH = New System.Windows.Forms.Label()
        Me.lblLetterG = New System.Windows.Forms.Label()
        Me.lblLetterF = New System.Windows.Forms.Label()
        Me.lblLetterE = New System.Windows.Forms.Label()
        Me.lblLetterB = New System.Windows.Forms.Label()
        Me.lblLetterC = New System.Windows.Forms.Label()
        Me.lblLetterD = New System.Windows.Forms.Label()
        Me.lblLetterA = New System.Windows.Forms.Label()
        Me.picHangman = New System.Windows.Forms.PictureBox()
        Me.ilsHangmen = New System.Windows.Forms.ImageList(Me.components)
        Me.lblNameLabel = New System.Windows.Forms.Label()
        Me.lblScoreLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnForfeit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.UclHomeExit1 = New Assessment.uclHomeExit()
        Me.pnlLetters.SuspendLayout()
        CType(Me.picHangman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHint
        '
        Me.lblHint.BackColor = System.Drawing.Color.Transparent
        Me.lblHint.Font = New System.Drawing.Font("Palatino Linotype", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.Location = New System.Drawing.Point(65, 98)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(445, 105)
        Me.lblHint.TabIndex = 8
        Me.lblHint.Text = "Hint"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(439, 46)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(81, 33)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = "Score"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Magneto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(104, 37)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(88, 28)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Name"
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.BackColor = System.Drawing.Color.Transparent
        Me.lblCat.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat.Location = New System.Drawing.Point(177, 402)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(43, 25)
        Me.lblCat.TabIndex = 12
        Me.lblCat.Text = "Cat"
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(683, 392)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(75, 23)
        Me.btnNewGame.TabIndex = 13
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'lblHyphen
        '
        Me.lblHyphen.BackColor = System.Drawing.Color.Transparent
        Me.lblHyphen.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHyphen.Location = New System.Drawing.Point(70, 203)
        Me.lblHyphen.Name = "lblHyphen"
        Me.lblHyphen.Size = New System.Drawing.Size(440, 183)
        Me.lblHyphen.TabIndex = 14
        Me.lblHyphen.Text = "Hyphen"
        Me.lblHyphen.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.pnlLetters.Location = New System.Drawing.Point(98, 438)
        Me.pnlLetters.Name = "pnlLetters"
        Me.pnlLetters.Size = New System.Drawing.Size(610, 113)
        Me.pnlLetters.TabIndex = 23
        '
        'lblLetterZ
        '
        Me.lblLetterZ.AutoSize = True
        Me.lblLetterZ.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterZ.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterZ.Location = New System.Drawing.Point(511, 62)
        Me.lblLetterZ.Name = "lblLetterZ"
        Me.lblLetterZ.Size = New System.Drawing.Size(42, 42)
        Me.lblLetterZ.TabIndex = 48
        Me.lblLetterZ.Text = "Z"
        '
        'lblLetterY
        '
        Me.lblLetterY.AutoSize = True
        Me.lblLetterY.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterY.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterY.Location = New System.Drawing.Point(468, 62)
        Me.lblLetterY.Name = "lblLetterY"
        Me.lblLetterY.Size = New System.Drawing.Size(43, 42)
        Me.lblLetterY.TabIndex = 47
        Me.lblLetterY.Text = "Y"
        '
        'lblLetterX
        '
        Me.lblLetterX.AutoSize = True
        Me.lblLetterX.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterX.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterX.Location = New System.Drawing.Point(426, 62)
        Me.lblLetterX.Name = "lblLetterX"
        Me.lblLetterX.Size = New System.Drawing.Size(42, 42)
        Me.lblLetterX.TabIndex = 46
        Me.lblLetterX.Text = "X"
        '
        'lblLetterW
        '
        Me.lblLetterW.AutoSize = True
        Me.lblLetterW.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterW.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterW.Location = New System.Drawing.Point(373, 62)
        Me.lblLetterW.Name = "lblLetterW"
        Me.lblLetterW.Size = New System.Drawing.Size(53, 42)
        Me.lblLetterW.TabIndex = 45
        Me.lblLetterW.Text = "W"
        '
        'lblLetterV
        '
        Me.lblLetterV.AutoSize = True
        Me.lblLetterV.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterV.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterV.Location = New System.Drawing.Point(329, 62)
        Me.lblLetterV.Name = "lblLetterV"
        Me.lblLetterV.Size = New System.Drawing.Size(44, 42)
        Me.lblLetterV.TabIndex = 44
        Me.lblLetterV.Text = "V"
        '
        'lblLetterU
        '
        Me.lblLetterU.AutoSize = True
        Me.lblLetterU.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterU.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterU.Location = New System.Drawing.Point(285, 62)
        Me.lblLetterU.Name = "lblLetterU"
        Me.lblLetterU.Size = New System.Drawing.Size(44, 42)
        Me.lblLetterU.TabIndex = 43
        Me.lblLetterU.Text = "U"
        '
        'lblLetterT
        '
        Me.lblLetterT.AutoSize = True
        Me.lblLetterT.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterT.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterT.Location = New System.Drawing.Point(241, 62)
        Me.lblLetterT.Name = "lblLetterT"
        Me.lblLetterT.Size = New System.Drawing.Size(44, 42)
        Me.lblLetterT.TabIndex = 42
        Me.lblLetterT.Text = "T"
        '
        'lblLetterS
        '
        Me.lblLetterS.AutoSize = True
        Me.lblLetterS.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterS.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterS.Location = New System.Drawing.Point(203, 62)
        Me.lblLetterS.Name = "lblLetterS"
        Me.lblLetterS.Size = New System.Drawing.Size(38, 42)
        Me.lblLetterS.TabIndex = 41
        Me.lblLetterS.Text = "S"
        '
        'lblLetterR
        '
        Me.lblLetterR.AutoSize = True
        Me.lblLetterR.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterR.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterR.Location = New System.Drawing.Point(160, 62)
        Me.lblLetterR.Name = "lblLetterR"
        Me.lblLetterR.Size = New System.Drawing.Size(43, 42)
        Me.lblLetterR.TabIndex = 40
        Me.lblLetterR.Text = "R"
        '
        'lblLetterQ
        '
        Me.lblLetterQ.AutoSize = True
        Me.lblLetterQ.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterQ.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterQ.Location = New System.Drawing.Point(113, 62)
        Me.lblLetterQ.Name = "lblLetterQ"
        Me.lblLetterQ.Size = New System.Drawing.Size(47, 42)
        Me.lblLetterQ.TabIndex = 39
        Me.lblLetterQ.Text = "Q"
        '
        'lblLetterP
        '
        Me.lblLetterP.AutoSize = True
        Me.lblLetterP.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterP.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterP.Location = New System.Drawing.Point(74, 62)
        Me.lblLetterP.Name = "lblLetterP"
        Me.lblLetterP.Size = New System.Drawing.Size(39, 42)
        Me.lblLetterP.TabIndex = 38
        Me.lblLetterP.Text = "P"
        '
        'lblLetterO
        '
        Me.lblLetterO.AutoSize = True
        Me.lblLetterO.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterO.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterO.Location = New System.Drawing.Point(564, 13)
        Me.lblLetterO.Name = "lblLetterO"
        Me.lblLetterO.Size = New System.Drawing.Size(47, 42)
        Me.lblLetterO.TabIndex = 37
        Me.lblLetterO.Text = "O"
        '
        'lblLetterN
        '
        Me.lblLetterN.AutoSize = True
        Me.lblLetterN.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterN.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterN.Location = New System.Drawing.Point(525, 13)
        Me.lblLetterN.Name = "lblLetterN"
        Me.lblLetterN.Size = New System.Drawing.Size(45, 42)
        Me.lblLetterN.TabIndex = 36
        Me.lblLetterN.Text = "N"
        '
        'lblLetterM
        '
        Me.lblLetterM.AutoSize = True
        Me.lblLetterM.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterM.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterM.Location = New System.Drawing.Point(475, 13)
        Me.lblLetterM.Name = "lblLetterM"
        Me.lblLetterM.Size = New System.Drawing.Size(50, 42)
        Me.lblLetterM.TabIndex = 35
        Me.lblLetterM.Text = "M"
        '
        'lblLetterL
        '
        Me.lblLetterL.AutoSize = True
        Me.lblLetterL.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterL.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterL.Location = New System.Drawing.Point(436, 13)
        Me.lblLetterL.Name = "lblLetterL"
        Me.lblLetterL.Size = New System.Drawing.Size(39, 42)
        Me.lblLetterL.TabIndex = 34
        Me.lblLetterL.Text = "L"
        '
        'lblLetterK
        '
        Me.lblLetterK.AutoSize = True
        Me.lblLetterK.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterK.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterK.Location = New System.Drawing.Point(392, 13)
        Me.lblLetterK.Name = "lblLetterK"
        Me.lblLetterK.Size = New System.Drawing.Size(44, 42)
        Me.lblLetterK.TabIndex = 33
        Me.lblLetterK.Text = "K"
        '
        'lblLetterJ
        '
        Me.lblLetterJ.AutoSize = True
        Me.lblLetterJ.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterJ.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterJ.Location = New System.Drawing.Point(359, 13)
        Me.lblLetterJ.Name = "lblLetterJ"
        Me.lblLetterJ.Size = New System.Drawing.Size(33, 42)
        Me.lblLetterJ.TabIndex = 32
        Me.lblLetterJ.Text = "J"
        '
        'lblLetterI
        '
        Me.lblLetterI.AutoSize = True
        Me.lblLetterI.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterI.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterI.Location = New System.Drawing.Point(329, 13)
        Me.lblLetterI.Name = "lblLetterI"
        Me.lblLetterI.Size = New System.Drawing.Size(30, 42)
        Me.lblLetterI.TabIndex = 31
        Me.lblLetterI.Text = "I"
        '
        'lblLetterH
        '
        Me.lblLetterH.AutoSize = True
        Me.lblLetterH.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterH.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterH.Location = New System.Drawing.Point(282, 13)
        Me.lblLetterH.Name = "lblLetterH"
        Me.lblLetterH.Size = New System.Drawing.Size(47, 42)
        Me.lblLetterH.TabIndex = 30
        Me.lblLetterH.Text = "H"
        '
        'lblLetterG
        '
        Me.lblLetterG.AutoSize = True
        Me.lblLetterG.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterG.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterG.Location = New System.Drawing.Point(242, 13)
        Me.lblLetterG.Name = "lblLetterG"
        Me.lblLetterG.Size = New System.Drawing.Size(46, 42)
        Me.lblLetterG.TabIndex = 29
        Me.lblLetterG.Text = "G"
        '
        'lblLetterF
        '
        Me.lblLetterF.AutoSize = True
        Me.lblLetterF.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterF.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterF.Location = New System.Drawing.Point(208, 13)
        Me.lblLetterF.Name = "lblLetterF"
        Me.lblLetterF.Size = New System.Drawing.Size(38, 42)
        Me.lblLetterF.TabIndex = 28
        Me.lblLetterF.Text = "F"
        '
        'lblLetterE
        '
        Me.lblLetterE.AutoSize = True
        Me.lblLetterE.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterE.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterE.Location = New System.Drawing.Point(169, 13)
        Me.lblLetterE.Name = "lblLetterE"
        Me.lblLetterE.Size = New System.Drawing.Size(39, 42)
        Me.lblLetterE.TabIndex = 27
        Me.lblLetterE.Text = "E"
        '
        'lblLetterB
        '
        Me.lblLetterB.AutoSize = True
        Me.lblLetterB.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterB.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterB.Location = New System.Drawing.Point(51, 13)
        Me.lblLetterB.Name = "lblLetterB"
        Me.lblLetterB.Size = New System.Drawing.Size(40, 42)
        Me.lblLetterB.TabIndex = 26
        Me.lblLetterB.Text = "B"
        '
        'lblLetterC
        '
        Me.lblLetterC.AutoSize = True
        Me.lblLetterC.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterC.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterC.Location = New System.Drawing.Point(85, 13)
        Me.lblLetterC.Name = "lblLetterC"
        Me.lblLetterC.Size = New System.Drawing.Size(44, 42)
        Me.lblLetterC.TabIndex = 25
        Me.lblLetterC.Text = "C"
        '
        'lblLetterD
        '
        Me.lblLetterD.AutoSize = True
        Me.lblLetterD.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterD.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterD.Location = New System.Drawing.Point(126, 13)
        Me.lblLetterD.Name = "lblLetterD"
        Me.lblLetterD.Size = New System.Drawing.Size(46, 42)
        Me.lblLetterD.TabIndex = 24
        Me.lblLetterD.Text = "D"
        '
        'lblLetterA
        '
        Me.lblLetterA.AutoSize = True
        Me.lblLetterA.BackColor = System.Drawing.Color.Transparent
        Me.lblLetterA.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterA.Location = New System.Drawing.Point(7, 13)
        Me.lblLetterA.Name = "lblLetterA"
        Me.lblLetterA.Size = New System.Drawing.Size(46, 42)
        Me.lblLetterA.TabIndex = 23
        Me.lblLetterA.Text = "A"
        '
        'picHangman
        '
        Me.picHangman.BackColor = System.Drawing.Color.Transparent
        Me.picHangman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picHangman.InitialImage = Nothing
        Me.picHangman.Location = New System.Drawing.Point(516, 49)
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
        'lblNameLabel
        '
        Me.lblNameLabel.AutoSize = True
        Me.lblNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblNameLabel.Font = New System.Drawing.Font("Magneto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameLabel.Location = New System.Drawing.Point(4, 36)
        Me.lblNameLabel.Name = "lblNameLabel"
        Me.lblNameLabel.Size = New System.Drawing.Size(118, 28)
        Me.lblNameLabel.TabIndex = 50
        Me.lblNameLabel.Text = "Player: "
        '
        'lblScoreLabel
        '
        Me.lblScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreLabel.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreLabel.Location = New System.Drawing.Point(297, 46)
        Me.lblScoreLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.lblScoreLabel.Name = "lblScoreLabel"
        Me.lblScoreLabel.Size = New System.Drawing.Size(147, 33)
        Me.lblScoreLabel.TabIndex = 51
        Me.lblScoreLabel.Text = "Your Score:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 402)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Category: "
        '
        'btnForfeit
        '
        Me.btnForfeit.Location = New System.Drawing.Point(4, 397)
        Me.btnForfeit.Name = "btnForfeit"
        Me.btnForfeit.Size = New System.Drawing.Size(75, 23)
        Me.btnForfeit.TabIndex = 53
        Me.btnForfeit.Text = "Forfeit"
        Me.btnForfeit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 17.25!)
        Me.Label3.Location = New System.Drawing.Point(7, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 31)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Hint: "
        '
        'picBanner
        '
        Me.picBanner.BackColor = System.Drawing.Color.Transparent
        Me.picBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBanner.Image = CType(resources.GetObject("picBanner.Image"), System.Drawing.Image)
        Me.picBanner.Location = New System.Drawing.Point(303, 1)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(480, 50)
        Me.picBanner.TabIndex = 55
        Me.picBanner.TabStop = False
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
        Me.Controls.Add(Me.lblCat)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.picHangman)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoreLabel)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnForfeit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNameLabel)
        Me.Controls.Add(Me.pnlLetters)
        Me.Controls.Add(Me.lblHyphen)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.UclHomeExit1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmGame"
        Me.Text = "Divisions of Science"
        Me.pnlLetters.ResumeLayout(False)
        Me.pnlLetters.PerformLayout()
        CType(Me.picHangman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UclHomeExit1 As Assessment.uclHomeExit
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCat As System.Windows.Forms.Label
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
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
    Friend WithEvents lblNameLabel As System.Windows.Forms.Label
    Friend WithEvents lblScoreLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnForfeit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
End Class
