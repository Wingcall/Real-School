<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategories
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
        Me.lblHome = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHome
        '
        Me.lblHome.BackColor = System.Drawing.Color.Transparent
        Me.lblHome.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.Location = New System.Drawing.Point(12, 9)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(77, 27)
        Me.lblHome.TabIndex = 1
        Me.lblHome.Text = "HOME"
        '
        'lblExit
        '
        Me.lblExit.BackColor = System.Drawing.Color.Transparent
        Me.lblExit.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(95, 9)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(59, 27)
        Me.lblExit.TabIndex = 2
        Me.lblExit.Text = "EXIT"
        '
        'frmCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assessment.My.Resources.Resources.Backgroundtest
        Me.ClientSize = New System.Drawing.Size(784, 586)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCategories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Divisions of Science"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHome As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label
End Class
