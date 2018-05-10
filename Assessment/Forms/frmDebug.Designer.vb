<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebug
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
        Me.btnPlayer1 = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnPlayer2 = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPlayer1
        '
        Me.btnPlayer1.Location = New System.Drawing.Point(54, 198)
        Me.btnPlayer1.Name = "btnPlayer1"
        Me.btnPlayer1.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayer1.TabIndex = 0
        Me.btnPlayer1.Tag = "0"
        Me.btnPlayer1.Text = "Button1"
        Me.btnPlayer1.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(119, 157)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(39, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Label1"
        '
        'btnPlayer2
        '
        Me.btnPlayer2.Location = New System.Drawing.Point(154, 198)
        Me.btnPlayer2.Name = "btnPlayer2"
        Me.btnPlayer2.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayer2.TabIndex = 2
        Me.btnPlayer2.Tag = "1"
        Me.btnPlayer2.Text = "Button2"
        Me.btnPlayer2.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(179, 157)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(39, 13)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "Label1"
        '
        'frmDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assessment.My.Resources.Resources.Backgroundtest
        Me.ClientSize = New System.Drawing.Size(784, 586)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnPlayer2)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnPlayer1)
        Me.Name = "frmDebug"
        Me.Text = "frmDebug"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlayer1 As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnPlayer2 As System.Windows.Forms.Button
    Friend WithEvents lblScore As System.Windows.Forms.Label
End Class
