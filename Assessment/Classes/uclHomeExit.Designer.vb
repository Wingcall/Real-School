<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uclHomeExit
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblExit
        '
        Me.lblExit.BackColor = System.Drawing.Color.Transparent
        Me.lblExit.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(78, 0)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(59, 27)
        Me.lblExit.TabIndex = 4
        Me.lblExit.Text = "EXIT"
        '
        'lblHome
        '
        Me.lblHome.BackColor = System.Drawing.Color.Transparent
        Me.lblHome.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.Location = New System.Drawing.Point(0, 0)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(77, 27)
        Me.lblHome.TabIndex = 3
        Me.lblHome.Text = "HOME"
        '
        'uclHomeExit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblHome)
        Me.Name = "uclHomeExit"
        Me.Size = New System.Drawing.Size(131, 29)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents lblHome As System.Windows.Forms.Label

End Class
