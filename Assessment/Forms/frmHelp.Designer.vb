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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabGame = New System.Windows.Forms.TabPage()
        Me.tabLogin = New System.Windows.Forms.TabPage()
        Me.tabEdit = New System.Windows.Forms.TabPage()
        Me.UclHomeExit1 = New Assessment.uclHomeExit()
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabGame)
        Me.TabControl1.Controls.Add(Me.tabLogin)
        Me.TabControl1.Controls.Add(Me.tabEdit)
        Me.TabControl1.Location = New System.Drawing.Point(174, 136)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(443, 319)
        Me.TabControl1.TabIndex = 8
        '
        'tabGame
        '
        Me.tabGame.Location = New System.Drawing.Point(4, 22)
        Me.tabGame.Name = "tabGame"
        Me.tabGame.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGame.Size = New System.Drawing.Size(435, 293)
        Me.tabGame.TabIndex = 0
        Me.tabGame.Text = "Playing the Game"
        Me.tabGame.UseVisualStyleBackColor = True
        '
        'tabLogin
        '
        Me.tabLogin.Location = New System.Drawing.Point(4, 22)
        Me.tabLogin.Name = "tabLogin"
        Me.tabLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLogin.Size = New System.Drawing.Size(435, 293)
        Me.tabLogin.TabIndex = 1
        Me.tabLogin.Text = "Login Screen"
        Me.tabLogin.UseVisualStyleBackColor = True
        '
        'tabEdit
        '
        Me.tabEdit.Location = New System.Drawing.Point(4, 22)
        Me.tabEdit.Name = "tabEdit"
        Me.tabEdit.Size = New System.Drawing.Size(435, 293)
        Me.tabEdit.TabIndex = 2
        Me.tabEdit.Text = "Editting Words"
        Me.tabEdit.UseVisualStyleBackColor = True
        '
        'UclHomeExit1
        '
        Me.UclHomeExit1.BackColor = System.Drawing.Color.Transparent
        Me.UclHomeExit1.Location = New System.Drawing.Point(3, 1)
        Me.UclHomeExit1.Name = "UclHomeExit1"
        Me.UclHomeExit1.Size = New System.Drawing.Size(131, 29)
        Me.UclHomeExit1.TabIndex = 7
        '
        'picBanner
        '
        Me.picBanner.BackColor = System.Drawing.Color.Transparent
        Me.picBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBanner.Image = CType(resources.GetObject("picBanner.Image"), System.Drawing.Image)
        Me.picBanner.Location = New System.Drawing.Point(152, -2)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(480, 50)
        Me.picBanner.TabIndex = 9
        Me.picBanner.TabStop = False
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assessment.My.Resources.Resources.Backgroundtest
        Me.ClientSize = New System.Drawing.Size(784, 586)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.UclHomeExit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Divisions of Science"
        Me.TabControl1.ResumeLayout(False)
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UclHomeExit1 As Assessment.uclHomeExit
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabGame As System.Windows.Forms.TabPage
    Friend WithEvents tabLogin As System.Windows.Forms.TabPage
    Friend WithEvents tabEdit As System.Windows.Forms.TabPage
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
End Class
