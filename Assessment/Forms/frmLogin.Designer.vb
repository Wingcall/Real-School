<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.rdoPlayer1 = New System.Windows.Forms.RadioButton()
        Me.lblPlayer1Score = New System.Windows.Forms.Label()
        Me.btnDelPlayer = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoPlayer2 = New System.Windows.Forms.RadioButton()
        Me.rdoPlayer3 = New System.Windows.Forms.RadioButton()
        Me.rdoPlayer4 = New System.Windows.Forms.RadioButton()
        Me.lblPlayer2Score = New System.Windows.Forms.Label()
        Me.lblPlayer3Score = New System.Windows.Forms.Label()
        Me.lblPlayer4Score = New System.Windows.Forms.Label()
        Me.UclHomeExit1 = New Assessment.uclHomeExit()
        Me.SuspendLayout()
        '
        'rdoPlayer1
        '
        Me.rdoPlayer1.AutoCheck = False
        Me.rdoPlayer1.BackColor = System.Drawing.Color.Transparent
        Me.rdoPlayer1.Font = New System.Drawing.Font("Modern No. 20", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPlayer1.Location = New System.Drawing.Point(167, 177)
        Me.rdoPlayer1.Name = "rdoPlayer1"
        Me.rdoPlayer1.Size = New System.Drawing.Size(219, 58)
        Me.rdoPlayer1.TabIndex = 8
        Me.rdoPlayer1.TabStop = True
        Me.rdoPlayer1.Tag = "0"
        Me.rdoPlayer1.Text = "Player 1"
        Me.rdoPlayer1.UseVisualStyleBackColor = False
        '
        'lblPlayer1Score
        '
        Me.lblPlayer1Score.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer1Score.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1Score.Location = New System.Drawing.Point(500, 177)
        Me.lblPlayer1Score.Name = "lblPlayer1Score"
        Me.lblPlayer1Score.Size = New System.Drawing.Size(75, 58)
        Me.lblPlayer1Score.TabIndex = 12
        Me.lblPlayer1Score.Text = "Score"
        Me.lblPlayer1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelPlayer
        '
        Me.btnDelPlayer.Location = New System.Drawing.Point(325, 514)
        Me.btnDelPlayer.Name = "btnDelPlayer"
        Me.btnDelPlayer.Size = New System.Drawing.Size(75, 23)
        Me.btnDelPlayer.TabIndex = 16
        Me.btnDelPlayer.Text = "Delete Player"
        Me.btnDelPlayer.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(203, 514)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add Player"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(515, 514)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 18
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblTag
        '
        Me.lblTag.AutoSize = True
        Me.lblTag.Location = New System.Drawing.Point(41, 539)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(39, 13)
        Me.lblTag.TabIndex = 19
        Me.lblTag.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 57)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Welcome! Select your slot!"
        '
        'rdoPlayer2
        '
        Me.rdoPlayer2.AutoCheck = False
        Me.rdoPlayer2.BackColor = System.Drawing.Color.Transparent
        Me.rdoPlayer2.Font = New System.Drawing.Font("Modern No. 20", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPlayer2.Location = New System.Drawing.Point(167, 257)
        Me.rdoPlayer2.Name = "rdoPlayer2"
        Me.rdoPlayer2.Size = New System.Drawing.Size(219, 58)
        Me.rdoPlayer2.TabIndex = 21
        Me.rdoPlayer2.TabStop = True
        Me.rdoPlayer2.Tag = "1"
        Me.rdoPlayer2.Text = "Player 2"
        Me.rdoPlayer2.UseVisualStyleBackColor = False
        '
        'rdoPlayer3
        '
        Me.rdoPlayer3.AutoCheck = False
        Me.rdoPlayer3.BackColor = System.Drawing.Color.Transparent
        Me.rdoPlayer3.Font = New System.Drawing.Font("Modern No. 20", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPlayer3.Location = New System.Drawing.Point(167, 337)
        Me.rdoPlayer3.Name = "rdoPlayer3"
        Me.rdoPlayer3.Size = New System.Drawing.Size(219, 58)
        Me.rdoPlayer3.TabIndex = 22
        Me.rdoPlayer3.TabStop = True
        Me.rdoPlayer3.Tag = "2"
        Me.rdoPlayer3.Text = "Player 3"
        Me.rdoPlayer3.UseVisualStyleBackColor = False
        '
        'rdoPlayer4
        '
        Me.rdoPlayer4.AutoCheck = False
        Me.rdoPlayer4.BackColor = System.Drawing.Color.Transparent
        Me.rdoPlayer4.Font = New System.Drawing.Font("Modern No. 20", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPlayer4.Location = New System.Drawing.Point(167, 417)
        Me.rdoPlayer4.Name = "rdoPlayer4"
        Me.rdoPlayer4.Size = New System.Drawing.Size(219, 58)
        Me.rdoPlayer4.TabIndex = 23
        Me.rdoPlayer4.TabStop = True
        Me.rdoPlayer4.Tag = "3"
        Me.rdoPlayer4.Text = "Player 4"
        Me.rdoPlayer4.UseVisualStyleBackColor = False
        '
        'lblPlayer2Score
        '
        Me.lblPlayer2Score.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer2Score.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlayer2Score.Location = New System.Drawing.Point(500, 257)
        Me.lblPlayer2Score.Name = "lblPlayer2Score"
        Me.lblPlayer2Score.Size = New System.Drawing.Size(75, 58)
        Me.lblPlayer2Score.TabIndex = 24
        Me.lblPlayer2Score.Text = "Score"
        Me.lblPlayer2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer3Score
        '
        Me.lblPlayer3Score.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer3Score.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlayer3Score.Location = New System.Drawing.Point(500, 337)
        Me.lblPlayer3Score.Name = "lblPlayer3Score"
        Me.lblPlayer3Score.Size = New System.Drawing.Size(75, 58)
        Me.lblPlayer3Score.TabIndex = 25
        Me.lblPlayer3Score.Text = "Score"
        Me.lblPlayer3Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer4Score
        '
        Me.lblPlayer4Score.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer4Score.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlayer4Score.Location = New System.Drawing.Point(500, 417)
        Me.lblPlayer4Score.Name = "lblPlayer4Score"
        Me.lblPlayer4Score.Size = New System.Drawing.Size(75, 58)
        Me.lblPlayer4Score.TabIndex = 26
        Me.lblPlayer4Score.Text = "Score"
        Me.lblPlayer4Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UclHomeExit1
        '
        Me.UclHomeExit1.BackColor = System.Drawing.Color.Transparent
        Me.UclHomeExit1.Location = New System.Drawing.Point(3, 1)
        Me.UclHomeExit1.Name = "UclHomeExit1"
        Me.UclHomeExit1.Size = New System.Drawing.Size(131, 29)
        Me.UclHomeExit1.TabIndex = 7
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assessment.My.Resources.Resources.Backgroundtest
        Me.ClientSize = New System.Drawing.Size(784, 586)
        Me.Controls.Add(Me.lblPlayer4Score)
        Me.Controls.Add(Me.lblPlayer3Score)
        Me.Controls.Add(Me.lblPlayer2Score)
        Me.Controls.Add(Me.rdoPlayer4)
        Me.Controls.Add(Me.rdoPlayer3)
        Me.Controls.Add(Me.rdoPlayer2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTag)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelPlayer)
        Me.Controls.Add(Me.lblPlayer1Score)
        Me.Controls.Add(Me.rdoPlayer1)
        Me.Controls.Add(Me.UclHomeExit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Divisions of Science"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UclHomeExit1 As Assessment.uclHomeExit
    Friend WithEvents rdoPlayer1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPlayer1Score As System.Windows.Forms.Label
    Friend WithEvents btnDelPlayer As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblTag As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdoPlayer2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPlayer3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPlayer4 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPlayer2Score As System.Windows.Forms.Label
    Friend WithEvents lblPlayer3Score As System.Windows.Forms.Label
    Friend WithEvents lblPlayer4Score As System.Windows.Forms.Label
End Class