﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.picBiology = New System.Windows.Forms.PictureBox()
        Me.picChemistry = New System.Windows.Forms.PictureBox()
        Me.picPhysics = New System.Windows.Forms.PictureBox()
        Me.UclHomeExit1 = New Assessment.uclHomeExit()
        CType(Me.picBiology, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChemistry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhysics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBiology
        '
        Me.picBiology.BackColor = System.Drawing.Color.Transparent
        Me.picBiology.BackgroundImage = Global.Assessment.My.Resources.Resources.Biology_Icon
        Me.picBiology.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBiology.InitialImage = Nothing
        Me.picBiology.Location = New System.Drawing.Point(12, 198)
        Me.picBiology.Name = "picBiology"
        Me.picBiology.Size = New System.Drawing.Size(170, 170)
        Me.picBiology.TabIndex = 3
        Me.picBiology.TabStop = False
        '
        'picChemistry
        '
        Me.picChemistry.BackColor = System.Drawing.Color.Transparent
        Me.picChemistry.BackgroundImage = Global.Assessment.My.Resources.Resources.Chemistry_Icon
        Me.picChemistry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picChemistry.InitialImage = Nothing
        Me.picChemistry.Location = New System.Drawing.Point(305, 198)
        Me.picChemistry.Name = "picChemistry"
        Me.picChemistry.Size = New System.Drawing.Size(170, 170)
        Me.picChemistry.TabIndex = 4
        Me.picChemistry.TabStop = False
        '
        'picPhysics
        '
        Me.picPhysics.BackColor = System.Drawing.Color.Transparent
        Me.picPhysics.BackgroundImage = Global.Assessment.My.Resources.Resources.Phsyics_Icon
        Me.picPhysics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPhysics.InitialImage = Nothing
        Me.picPhysics.Location = New System.Drawing.Point(602, 198)
        Me.picPhysics.Name = "picPhysics"
        Me.picPhysics.Size = New System.Drawing.Size(170, 170)
        Me.picPhysics.TabIndex = 5
        Me.picPhysics.TabStop = False
        '
        'UclHomeExit1
        '
        Me.UclHomeExit1.BackColor = System.Drawing.Color.Transparent
        Me.UclHomeExit1.Location = New System.Drawing.Point(3, 1)
        Me.UclHomeExit1.Name = "UclHomeExit1"
        Me.UclHomeExit1.Size = New System.Drawing.Size(131, 29)
        Me.UclHomeExit1.TabIndex = 6
        '
        'frmCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assessment.My.Resources.Resources.Backgroundtest
        Me.ClientSize = New System.Drawing.Size(784, 586)
        Me.Controls.Add(Me.UclHomeExit1)
        Me.Controls.Add(Me.picPhysics)
        Me.Controls.Add(Me.picChemistry)
        Me.Controls.Add(Me.picBiology)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCategories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Divisions of Science"
        CType(Me.picBiology, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChemistry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhysics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBiology As System.Windows.Forms.PictureBox
    Friend WithEvents picChemistry As System.Windows.Forms.PictureBox
    Friend WithEvents picPhysics As System.Windows.Forms.PictureBox
    Friend WithEvents UclHomeExit1 As Assessment.uclHomeExit
End Class
