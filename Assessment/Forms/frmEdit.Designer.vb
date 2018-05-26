<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEdit))
        Me.lstWords = New System.Windows.Forms.ListBox()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.txtHint = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.picMute = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UclHomeExit1 = New Assessment.uclHomeExit()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstWords
        '
        Me.lstWords.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.ItemHeight = 24
        Me.lstWords.Location = New System.Drawing.Point(90, 132)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(186, 364)
        Me.lstWords.TabIndex = 6
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(327, 329)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(100, 23)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "Remove Word"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(327, 300)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add Word"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtWord
        '
        Me.txtWord.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWord.Location = New System.Drawing.Point(330, 249)
        Me.txtWord.MaxLength = 54
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(201, 30)
        Me.txtWord.TabIndex = 1
        '
        'cmbCat
        '
        Me.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCat.Font = New System.Drawing.Font("Modern No. 20", 15.75!)
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Location = New System.Drawing.Point(327, 171)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(121, 32)
        Me.cmbCat.TabIndex = 0
        '
        'txtHint
        '
        Me.txtHint.Font = New System.Drawing.Font("Modern No. 20", 15.75!)
        Me.txtHint.Location = New System.Drawing.Point(286, 504)
        Me.txtHint.MaxLength = 118
        Me.txtHint.Multiline = True
        Me.txtHint.Name = "txtHint"
        Me.txtHint.Size = New System.Drawing.Size(401, 75)
        Me.txtHint.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(327, 358)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear Textboxes"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'picBanner
        '
        Me.picBanner.BackColor = System.Drawing.Color.Transparent
        Me.picBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBanner.Image = Global.Assessment.My.Resources.Resources.Banner
        Me.picBanner.Location = New System.Drawing.Point(149, 1)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(480, 50)
        Me.picBanner.TabIndex = 16
        Me.picBanner.TabStop = False
        '
        'picMute
        '
        Me.picMute.BackColor = System.Drawing.Color.Transparent
        Me.picMute.BackgroundImage = Global.Assessment.My.Resources.Resources.mute
        Me.picMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMute.Location = New System.Drawing.Point(705, 515)
        Me.picMute.Name = "picMute"
        Me.picMute.Size = New System.Drawing.Size(67, 59)
        Me.picMute.TabIndex = 17
        Me.picMute.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(324, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 31)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Label2.Location = New System.Drawing.Point(321, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 31)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Word"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Label3.Location = New System.Drawing.Point(208, 504)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 31)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Hint"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Californian FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(291, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 43)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "List Editor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(119, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 31)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Word List"
        '
        'UclHomeExit1
        '
        Me.UclHomeExit1.BackColor = System.Drawing.Color.Transparent
        Me.UclHomeExit1.Location = New System.Drawing.Point(3, 1)
        Me.UclHomeExit1.Name = "UclHomeExit1"
        Me.UclHomeExit1.Size = New System.Drawing.Size(131, 29)
        Me.UclHomeExit1.TabIndex = 7
        '
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assessment.My.Resources.Resources.Backgroundtest
        Me.ClientSize = New System.Drawing.Size(784, 586)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picMute)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtHint)
        Me.Controls.Add(Me.cmbCat)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.lstWords)
        Me.Controls.Add(Me.UclHomeExit1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEdit"
        Me.Text = "Divisions of Science"
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UclHomeExit1 As Assessment.uclHomeExit
    Friend WithEvents lstWords As System.Windows.Forms.ListBox
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents txtHint As System.Windows.Forms.TextBox
    Friend WithEvents cmbCat As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents picMute As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
