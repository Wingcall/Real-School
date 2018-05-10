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
        Me.lblHint = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.UclHomeExit1 = New Assessment.uclHomeExit()
        Me.btnLoadButton = New System.Windows.Forms.Button()
        Me.lblHyphen = New System.Windows.Forms.Label()
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
        'UclHomeExit1
        '
        Me.UclHomeExit1.BackColor = System.Drawing.Color.Transparent
        Me.UclHomeExit1.Location = New System.Drawing.Point(3, 1)
        Me.UclHomeExit1.Name = "UclHomeExit1"
        Me.UclHomeExit1.Size = New System.Drawing.Size(131, 29)
        Me.UclHomeExit1.TabIndex = 7
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
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assessment.My.Resources.Resources.Backgroundtest
        Me.ClientSize = New System.Drawing.Size(784, 586)
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
End Class
