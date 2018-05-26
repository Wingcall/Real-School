<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnGame = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.lblEdit = New System.Windows.Forms.Label()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPlay
        '
        Me.lblPlay.BackColor = System.Drawing.Color.Transparent
        Me.lblPlay.Font = New System.Drawing.Font("Segoe Print", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlay.Location = New System.Drawing.Point(292, 125)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(225, 74)
        Me.lblPlay.TabIndex = 0
        Me.lblPlay.Text = "PLAY"
        Me.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHelp
        '
        Me.lblHelp.BackColor = System.Drawing.Color.Transparent
        Me.lblHelp.Font = New System.Drawing.Font("Segoe Print", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.Location = New System.Drawing.Point(292, 347)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(225, 74)
        Me.lblHelp.TabIndex = 1
        Me.lblHelp.Text = "HELP"
        Me.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExit
        '
        Me.lblExit.BackColor = System.Drawing.Color.Transparent
        Me.lblExit.Font = New System.Drawing.Font("Segoe Print", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(292, 421)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(225, 74)
        Me.lblExit.TabIndex = 2
        Me.lblExit.Text = "EXIT"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAbout
        '
        Me.lblAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblAbout.Font = New System.Drawing.Font("Segoe Print", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAbout.Location = New System.Drawing.Point(292, 273)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(225, 74)
        Me.lblAbout.TabIndex = 3
        Me.lblAbout.Text = "ABOUT"
        Me.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 431)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "go to categories"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 473)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "go to login"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnGame
        '
        Me.btnGame.Location = New System.Drawing.Point(12, 513)
        Me.btnGame.Name = "btnGame"
        Me.btnGame.Size = New System.Drawing.Size(105, 23)
        Me.btnGame.TabIndex = 0
        Me.btnGame.Text = "go to game"
        Me.btnGame.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(12, 554)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(105, 23)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "go to edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'picBanner
        '
        Me.picBanner.BackColor = System.Drawing.Color.Transparent
        Me.picBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBanner.Image = Global.Assessment.My.Resources.Resources.Banner
        Me.picBanner.Location = New System.Drawing.Point(158, 12)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(480, 50)
        Me.picBanner.TabIndex = 7
        Me.picBanner.TabStop = False
        '
        'lblEdit
        '
        Me.lblEdit.BackColor = System.Drawing.Color.Transparent
        Me.lblEdit.Font = New System.Drawing.Font("Segoe Print", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.Location = New System.Drawing.Point(216, 199)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(383, 74)
        Me.lblEdit.TabIndex = 8
        Me.lblEdit.Text = "EDIT WORDS"
        Me.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assessment.My.Resources.Resources.Backgroundtest
        Me.ClientSize = New System.Drawing.Size(784, 586)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnGame)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.lblPlay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Divisions of Science"
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPlay As System.Windows.Forms.Label
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnGame As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents lblEdit As System.Windows.Forms.Label
End Class
