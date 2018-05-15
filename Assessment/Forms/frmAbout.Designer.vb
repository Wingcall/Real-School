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
        Me.UclHomeExit1 = New Assessment.uclHomeExit()
        Me.SuspendLayout()
        '
        'lblCAbout
        '
        Me.lblCAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblCAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCAbout.Font = New System.Drawing.Font("Monotype Corsiva", 22.0!, System.Drawing.FontStyle.Italic)
        Me.lblCAbout.Location = New System.Drawing.Point(561, 138)
        Me.lblCAbout.Name = "lblCAbout"
        Me.lblCAbout.Size = New System.Drawing.Size(219, 439)
        Me.lblCAbout.TabIndex = 8
        Me.lblCAbout.Text = "Cal Wing is a #Insert Infomation here!#"
        '
        'lblAbout
        '
        Me.lblAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAbout.Font = New System.Drawing.Font("Monotype Corsiva", 22.0!, System.Drawing.FontStyle.Italic)
        Me.lblAbout.Location = New System.Drawing.Point(278, 110)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(277, 294)
        Me.lblAbout.TabIndex = 9
        Me.lblAbout.Text = "About"
        '
        'lblBAbout
        '
        Me.lblBAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblBAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBAbout.Font = New System.Drawing.Font("Monotype Corsiva", 22.0!, System.Drawing.FontStyle.Italic)
        Me.lblBAbout.Location = New System.Drawing.Point(9, 138)
        Me.lblBAbout.Name = "lblBAbout"
        Me.lblBAbout.Size = New System.Drawing.Size(263, 439)
        Me.lblBAbout.TabIndex = 10
        Me.lblBAbout.Text = "About"
        '
        'lblBTitle
        '
        Me.lblBTitle.AutoSize = True
        Me.lblBTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblBTitle.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBTitle.Location = New System.Drawing.Point(-5, 93)
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
        Me.lblCTitle.Location = New System.Drawing.Point(591, 93)
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
End Class
