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
        Me.tabMain = New System.Windows.Forms.TabPage()
        Me.lblMaininfo = New System.Windows.Forms.Label()
        Me.tabGame = New System.Windows.Forms.TabPage()
        Me.lblPlayinginfo = New System.Windows.Forms.Label()
        Me.tabLogin = New System.Windows.Forms.TabPage()
        Me.lblLogininfo = New System.Windows.Forms.Label()
        Me.tabEdit = New System.Windows.Forms.TabPage()
        Me.lblEditinfo = New System.Windows.Forms.Label()
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.UclHomeExit1 = New Assessment.uclHomeExit()
        Me.TabControl1.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabGame.SuspendLayout()
        Me.tabLogin.SuspendLayout()
        Me.tabEdit.SuspendLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabMain)
        Me.TabControl1.Controls.Add(Me.tabGame)
        Me.TabControl1.Controls.Add(Me.tabLogin)
        Me.TabControl1.Controls.Add(Me.tabEdit)
        Me.TabControl1.Location = New System.Drawing.Point(139, 179)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(513, 358)
        Me.TabControl1.TabIndex = 8
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.lblMaininfo)
        Me.tabMain.Location = New System.Drawing.Point(4, 22)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMain.Size = New System.Drawing.Size(505, 332)
        Me.tabMain.TabIndex = 3
        Me.tabMain.Text = "Main Menu"
        Me.tabMain.UseVisualStyleBackColor = True
        '
        'lblMaininfo
        '
        Me.lblMaininfo.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaininfo.Location = New System.Drawing.Point(4, 12)
        Me.lblMaininfo.Name = "lblMaininfo"
        Me.lblMaininfo.Size = New System.Drawing.Size(505, 297)
        Me.lblMaininfo.TabIndex = 1
        Me.lblMaininfo.Text = resources.GetString("lblMaininfo.Text")
        '
        'tabGame
        '
        Me.tabGame.Controls.Add(Me.lblPlayinginfo)
        Me.tabGame.Location = New System.Drawing.Point(4, 22)
        Me.tabGame.Name = "tabGame"
        Me.tabGame.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGame.Size = New System.Drawing.Size(505, 332)
        Me.tabGame.TabIndex = 0
        Me.tabGame.Text = "Playing the Game"
        Me.tabGame.UseVisualStyleBackColor = True
        '
        'lblPlayinginfo
        '
        Me.lblPlayinginfo.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayinginfo.Location = New System.Drawing.Point(3, 3)
        Me.lblPlayinginfo.Name = "lblPlayinginfo"
        Me.lblPlayinginfo.Size = New System.Drawing.Size(506, 326)
        Me.lblPlayinginfo.TabIndex = 0
        Me.lblPlayinginfo.Text = resources.GetString("lblPlayinginfo.Text")
        '
        'tabLogin
        '
        Me.tabLogin.Controls.Add(Me.lblLogininfo)
        Me.tabLogin.Location = New System.Drawing.Point(4, 22)
        Me.tabLogin.Name = "tabLogin"
        Me.tabLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLogin.Size = New System.Drawing.Size(505, 332)
        Me.tabLogin.TabIndex = 1
        Me.tabLogin.Text = "Login Screen"
        Me.tabLogin.UseVisualStyleBackColor = True
        '
        'lblLogininfo
        '
        Me.lblLogininfo.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogininfo.Location = New System.Drawing.Point(3, 4)
        Me.lblLogininfo.Name = "lblLogininfo"
        Me.lblLogininfo.Size = New System.Drawing.Size(506, 325)
        Me.lblLogininfo.TabIndex = 1
        Me.lblLogininfo.Text = resources.GetString("lblLogininfo.Text")
        '
        'tabEdit
        '
        Me.tabEdit.Controls.Add(Me.lblEditinfo)
        Me.tabEdit.Location = New System.Drawing.Point(4, 22)
        Me.tabEdit.Name = "tabEdit"
        Me.tabEdit.Size = New System.Drawing.Size(505, 332)
        Me.tabEdit.TabIndex = 2
        Me.tabEdit.Text = "Editting Words"
        Me.tabEdit.UseVisualStyleBackColor = True
        '
        'lblEditinfo
        '
        Me.lblEditinfo.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditinfo.Location = New System.Drawing.Point(3, 3)
        Me.lblEditinfo.Name = "lblEditinfo"
        Me.lblEditinfo.Size = New System.Drawing.Size(499, 333)
        Me.lblEditinfo.TabIndex = 1
        Me.lblEditinfo.Text = resources.GetString("lblEditinfo.Text")
        '
        'picBanner
        '
        Me.picBanner.BackColor = System.Drawing.Color.Transparent
        Me.picBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBanner.Image = Global.Assessment.My.Resources.Resources.Banner
        Me.picBanner.Location = New System.Drawing.Point(152, -2)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(480, 50)
        Me.picBanner.TabIndex = 9
        Me.picBanner.TabStop = False
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.BackColor = System.Drawing.Color.Transparent
        Me.lblHelp.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.Location = New System.Drawing.Point(277, 82)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(218, 57)
        Me.lblHelp.TabIndex = 21
        Me.lblHelp.Text = "Help Menu"
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
        Me.Controls.Add(Me.lblHelp)
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
        Me.tabMain.ResumeLayout(False)
        Me.tabGame.ResumeLayout(False)
        Me.tabLogin.ResumeLayout(False)
        Me.tabEdit.ResumeLayout(False)
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UclHomeExit1 As Assessment.uclHomeExit
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabGame As System.Windows.Forms.TabPage
    Friend WithEvents tabLogin As System.Windows.Forms.TabPage
    Friend WithEvents tabEdit As System.Windows.Forms.TabPage
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents lblPlayinginfo As System.Windows.Forms.Label
    Friend WithEvents lblLogininfo As System.Windows.Forms.Label
    Friend WithEvents lblEditinfo As System.Windows.Forms.Label
    Friend WithEvents tabMain As System.Windows.Forms.TabPage
    Friend WithEvents lblMaininfo As System.Windows.Forms.Label
    Friend WithEvents lblHelp As System.Windows.Forms.Label
End Class
