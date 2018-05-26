<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblCAbout = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblBAbout = New System.Windows.Forms.Label()
        Me.lblBTitle = New System.Windows.Forms.Label()
        Me.lblCTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.UclHomeExit1 = New Assessment.uclHomeExit()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCAbout
        '
        Me.lblCAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblCAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCAbout.Font = New System.Drawing.Font("Monotype Corsiva", 22.0!, System.Drawing.FontStyle.Italic)
        Me.lblCAbout.Location = New System.Drawing.Point(546, 136)
        Me.lblCAbout.Name = "lblCAbout"
        Me.lblCAbout.Size = New System.Drawing.Size(234, 449)
        Me.lblCAbout.TabIndex = 8
        Me.lblCAbout.Text = "Cal Wing is the 2nd creator of Divisons of Scicence. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "He is a rower, hobbest c" & _
    "oder and general tinkerer in a range of areas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "He was also 17 at the time of " & _
    "this project."
        '
        'lblAbout
        '
        Me.lblAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAbout.Font = New System.Drawing.Font("Imprint MT Shadow", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(278, 110)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(262, 337)
        Me.lblAbout.TabIndex = 9
        Me.lblAbout.Text = "Divisions of Science, is the classic game of ""Hangman"" but Digitised!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For more" & _
    " inofmation about the game, click ""Home"" (top left) then ""Help"" on the main scre" & _
    "en."
        '
        'lblBAbout
        '
        Me.lblBAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblBAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBAbout.Font = New System.Drawing.Font("Monotype Corsiva", 22.0!, System.Drawing.FontStyle.Italic)
        Me.lblBAbout.Location = New System.Drawing.Point(9, 136)
        Me.lblBAbout.Name = "lblBAbout"
        Me.lblBAbout.Size = New System.Drawing.Size(263, 449)
        Me.lblBAbout.TabIndex = 10
        Me.lblBAbout.Text = "Brandon Dingley is one of the creators of Divisons of Science. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "His hobbies in" & _
    "clude sports, technology, cooking and sleeping. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "At the time of this project " & _
    "(2018), Brandon was 17." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBTitle
        '
        Me.lblBTitle.AutoSize = True
        Me.lblBTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblBTitle.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBTitle.Location = New System.Drawing.Point(-5, 91)
        Me.lblBTitle.Name = "lblBTitle"
        Me.lblBTitle.Size = New System.Drawing.Size(283, 45)
        Me.lblBTitle.TabIndex = 11
        Me.lblBTitle.Text = "Brandon Dingley"
        '
        'lblCTitle
        '
        Me.lblCTitle.AutoSize = True
        Me.lblCTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCTitle.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCTitle.Location = New System.Drawing.Point(591, 91)
        Me.lblCTitle.Name = "lblCTitle"
        Me.lblCTitle.Size = New System.Drawing.Size(165, 45)
        Me.lblCTitle.TabIndex = 12
        Me.lblCTitle.Text = "Cal Wing"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Algerian", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(344, 52)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(141, 41)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "About"
        '
        'picBanner
        '
        Me.picBanner.BackColor = System.Drawing.Color.Transparent
        Me.picBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBanner.Image = Global.Assessment.My.Resources.Resources.Banner
        Me.picBanner.Location = New System.Drawing.Point(172, 1)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(480, 50)
        Me.picBanner.TabIndex = 14
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
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assessment.My.Resources.Resources.Backgroundtest
        Me.ClientSize = New System.Drawing.Size(784, 586)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblCTitle)
        Me.Controls.Add(Me.lblBTitle)
        Me.Controls.Add(Me.lblBAbout)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.lblCAbout)
        Me.Controls.Add(Me.UclHomeExit1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAbout"
        Me.Text = "Divisions of Science"
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UclHomeExit1 As Assessment.uclHomeExit
    Friend WithEvents lblCAbout As System.Windows.Forms.Label
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents lblBAbout As System.Windows.Forms.Label
    Friend WithEvents lblBTitle As System.Windows.Forms.Label
    Friend WithEvents lblCTitle As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
End Class
