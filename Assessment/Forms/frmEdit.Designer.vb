﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.UclHomeExit1 = New Assessment.uclHomeExit()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstWords
        '
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.Location = New System.Drawing.Point(77, 112)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(186, 381)
        Me.lstWords.TabIndex = 6
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(406, 238)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(100, 23)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "Delete Word"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(406, 209)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add Word"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(406, 174)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(100, 20)
        Me.txtWord.TabIndex = 1
        '
        'cmbCat
        '
        Me.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Location = New System.Drawing.Point(406, 147)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(121, 21)
        Me.cmbCat.TabIndex = 0
        '
        'txtHint
        '
        Me.txtHint.Location = New System.Drawing.Point(334, 306)
        Me.txtHint.Name = "txtHint"
        Me.txtHint.Size = New System.Drawing.Size(325, 20)
        Me.txtHint.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(406, 267)
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
End Class
