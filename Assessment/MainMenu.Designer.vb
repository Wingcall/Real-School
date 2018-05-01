<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPlay
        '
        Me.lblPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlay.Location = New System.Drawing.Point(156, 72)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(108, 55)
        Me.lblPlay.TabIndex = 0
        Me.lblPlay.Text = "Play"
        '
        'lblAbout
        '
        Me.lblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(156, 127)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(149, 55)
        Me.lblAbout.TabIndex = 1
        Me.lblAbout.Text = "About"
        '
        'lblHelp
        '
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.Location = New System.Drawing.Point(156, 182)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(149, 55)
        Me.lblHelp.TabIndex = 2
        Me.lblHelp.Text = "Help"
        '
        'lblExit
        '
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(156, 237)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(149, 55)
        Me.lblExit.TabIndex = 3
        Me.lblExit.Text = "Exit"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 356)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.lblPlay)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPlay As System.Windows.Forms.Label
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label
End Class
