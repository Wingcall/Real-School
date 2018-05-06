<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Me.cboHelp = New System.Windows.Forms.ComboBox()
        Me.UclHomeExit1 = New Assessment.uclHomeExit()
        Me.SuspendLayout()
        '
        'cboHelp
        '
        Me.cboHelp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboHelp.FormattingEnabled = True
        Me.cboHelp.Items.AddRange(New Object() {"Test 1", "Test 2", "Test 3", "Test 4"})
        Me.cboHelp.Location = New System.Drawing.Point(206, 233)
        Me.cboHelp.MaxDropDownItems = 5
        Me.cboHelp.Name = "cboHelp"
        Me.cboHelp.Size = New System.Drawing.Size(188, 21)
        Me.cboHelp.TabIndex = 0
        '
        'UclHomeExit1
        '
        Me.UclHomeExit1.BackColor = System.Drawing.Color.Transparent
        Me.UclHomeExit1.Location = New System.Drawing.Point(3, 1)
        Me.UclHomeExit1.Name = "UclHomeExit1"
        Me.UclHomeExit1.Size = New System.Drawing.Size(131, 29)
        Me.UclHomeExit1.TabIndex = 7
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assessment.My.Resources.Resources.Backgroundtest
        Me.ClientSize = New System.Drawing.Size(784, 586)
        Me.Controls.Add(Me.UclHomeExit1)
        Me.Controls.Add(Me.cboHelp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Divisions of Science"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboHelp As System.Windows.Forms.ComboBox
    Friend WithEvents UclHomeExit1 As Assessment.uclHomeExit
End Class
