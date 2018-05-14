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
        Me.UclHomeExit1 = New Assessment.uclHomeExit()
        Me.rdoPlayer1 = New System.Windows.Forms.RadioButton()
        Me.rdoPlayer2 = New System.Windows.Forms.RadioButton()
        Me.rdoPlayer3 = New System.Windows.Forms.RadioButton()
        Me.rdoPlayer4 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'UclHomeExit1
        '
        Me.UclHomeExit1.BackColor = System.Drawing.Color.Transparent
        Me.UclHomeExit1.Location = New System.Drawing.Point(3, 1)
        Me.UclHomeExit1.Name = "UclHomeExit1"
        Me.UclHomeExit1.Size = New System.Drawing.Size(131, 29)
        Me.UclHomeExit1.TabIndex = 7
        '
        'rdoPlayer1
        '
        Me.rdoPlayer1.BackColor = System.Drawing.Color.Transparent
        Me.rdoPlayer1.Location = New System.Drawing.Point(317, 201)
        Me.rdoPlayer1.Name = "rdoPlayer1"
        Me.rdoPlayer1.Size = New System.Drawing.Size(89, 19)
        Me.rdoPlayer1.TabIndex = 8
        Me.rdoPlayer1.TabStop = True
        Me.rdoPlayer1.Text = "Player 1"
        Me.rdoPlayer1.UseVisualStyleBackColor = False
        '
        'rdoPlayer2
        '
        Me.rdoPlayer2.BackColor = System.Drawing.Color.Transparent
        Me.rdoPlayer2.Location = New System.Drawing.Point(317, 235)
        Me.rdoPlayer2.Name = "rdoPlayer2"
        Me.rdoPlayer2.Size = New System.Drawing.Size(89, 19)
        Me.rdoPlayer2.TabIndex = 9
        Me.rdoPlayer2.TabStop = True
        Me.rdoPlayer2.Text = "Player 2"
        Me.rdoPlayer2.UseVisualStyleBackColor = False
        '
        'rdoPlayer3
        '
        Me.rdoPlayer3.BackColor = System.Drawing.Color.Transparent
        Me.rdoPlayer3.Location = New System.Drawing.Point(317, 269)
        Me.rdoPlayer3.Name = "rdoPlayer3"
        Me.rdoPlayer3.Size = New System.Drawing.Size(89, 19)
        Me.rdoPlayer3.TabIndex = 10
        Me.rdoPlayer3.TabStop = True
        Me.rdoPlayer3.Text = "Player 3"
        Me.rdoPlayer3.UseVisualStyleBackColor = False
        '
        'rdoPlayer4
        '
        Me.rdoPlayer4.BackColor = System.Drawing.Color.Transparent
        Me.rdoPlayer4.Location = New System.Drawing.Point(317, 306)
        Me.rdoPlayer4.Name = "rdoPlayer4"
        Me.rdoPlayer4.Size = New System.Drawing.Size(89, 19)
        Me.rdoPlayer4.TabIndex = 11
        Me.rdoPlayer4.TabStop = True
        Me.rdoPlayer4.Text = "Player 4"
        Me.rdoPlayer4.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assessment.My.Resources.Resources.Backgroundtest
        Me.ClientSize = New System.Drawing.Size(784, 586)
        Me.Controls.Add(Me.rdoPlayer4)
        Me.Controls.Add(Me.rdoPlayer3)
        Me.Controls.Add(Me.rdoPlayer2)
        Me.Controls.Add(Me.rdoPlayer1)
        Me.Controls.Add(Me.UclHomeExit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Divisions of Science"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UclHomeExit1 As Assessment.uclHomeExit
    Friend WithEvents rdoPlayer1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPlayer2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPlayer3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPlayer4 As System.Windows.Forms.RadioButton
End Class
End Class
