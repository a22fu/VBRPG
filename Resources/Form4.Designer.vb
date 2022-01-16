<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrmoveanimateright2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrmoveanimateleft2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrmoveanimateup2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrmoveanimatedown2 = New System.Windows.Forms.Timer(Me.components)
        Me.picplayer = New System.Windows.Forms.PictureBox()
        Me.picgolem = New System.Windows.Forms.PictureBox()
        Me.picgolemfight = New System.Windows.Forms.PictureBox()
        Me.pichitbox = New System.Windows.Forms.PictureBox()
        Me.picbackground = New System.Windows.Forms.PictureBox()
        Me.picanimation = New System.Windows.Forms.PictureBox()
        Me.tmrbattlestart = New System.Windows.Forms.Timer(Me.components)
        Me.Lblpressspace = New System.Windows.Forms.Label()
        Me.lblnpc1 = New System.Windows.Forms.Label()
        Me.pictxt = New System.Windows.Forms.PictureBox()
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picgolem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picgolemfight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichitbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picanimation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrmoveanimateright2
        '
        '
        'tmrmoveanimateleft2
        '
        '
        'tmrmoveanimateup2
        '
        '
        'tmrmoveanimatedown2
        '
        '
        'picplayer
        '
        Me.picplayer.BackColor = System.Drawing.Color.Transparent
        Me.picplayer.Location = New System.Drawing.Point(935, 382)
        Me.picplayer.Name = "picplayer"
        Me.picplayer.Size = New System.Drawing.Size(60, 60)
        Me.picplayer.TabIndex = 0
        Me.picplayer.TabStop = False
        '
        'picgolem
        '
        Me.picgolem.BackColor = System.Drawing.Color.Transparent
        Me.picgolem.Image = Global.Gaming.My.Resources.Resources.Golemenemy
        Me.picgolem.Location = New System.Drawing.Point(294, 249)
        Me.picgolem.Name = "picgolem"
        Me.picgolem.Size = New System.Drawing.Size(197, 181)
        Me.picgolem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picgolem.TabIndex = 1
        Me.picgolem.TabStop = False
        '
        'picgolemfight
        '
        Me.picgolemfight.Location = New System.Drawing.Point(286, 237)
        Me.picgolemfight.Name = "picgolemfight"
        Me.picgolemfight.Size = New System.Drawing.Size(218, 205)
        Me.picgolemfight.TabIndex = 2
        Me.picgolemfight.TabStop = False
        Me.picgolemfight.Visible = False
        '
        'pichitbox
        '
        Me.pichitbox.Location = New System.Drawing.Point(2, -4)
        Me.pichitbox.Name = "pichitbox"
        Me.pichitbox.Size = New System.Drawing.Size(1024, 317)
        Me.pichitbox.TabIndex = 3
        Me.pichitbox.TabStop = False
        Me.pichitbox.Visible = False
        '
        'picbackground
        '
        Me.picbackground.BackColor = System.Drawing.Color.SeaGreen
        Me.picbackground.BackgroundImage = Global.Gaming.My.Resources.Resources.forest
        Me.picbackground.Location = New System.Drawing.Point(0, 12)
        Me.picbackground.Name = "picbackground"
        Me.picbackground.Size = New System.Drawing.Size(1026, 568)
        Me.picbackground.TabIndex = 4
        Me.picbackground.TabStop = False
        '
        'picanimation
        '
        Me.picanimation.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picanimation.Location = New System.Drawing.Point(2, -725)
        Me.picanimation.Name = "picanimation"
        Me.picanimation.Size = New System.Drawing.Size(1049, 724)
        Me.picanimation.TabIndex = 5
        Me.picanimation.TabStop = False
        '
        'tmrbattlestart
        '
        '
        'Lblpressspace
        '
        Me.Lblpressspace.AutoSize = True
        Me.Lblpressspace.BackColor = System.Drawing.Color.Black
        Me.Lblpressspace.ForeColor = System.Drawing.Color.White
        Me.Lblpressspace.Location = New System.Drawing.Point(660, 515)
        Me.Lblpressspace.Name = "Lblpressspace"
        Me.Lblpressspace.Size = New System.Drawing.Size(124, 13)
        Me.Lblpressspace.TabIndex = 31
        Me.Lblpressspace.Text = "Press Space to Continue"
        Me.Lblpressspace.Visible = False
        '
        'lblnpc1
        '
        Me.lblnpc1.BackColor = System.Drawing.Color.Black
        Me.lblnpc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnpc1.ForeColor = System.Drawing.Color.White
        Me.lblnpc1.Location = New System.Drawing.Point(267, 398)
        Me.lblnpc1.Name = "lblnpc1"
        Me.lblnpc1.Size = New System.Drawing.Size(517, 130)
        Me.lblnpc1.TabIndex = 29
        Me.lblnpc1.Text = "Congratulations, you have beaten the VBRPG demo. More will come soon."
        Me.lblnpc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblnpc1.Visible = False
        '
        'pictxt
        '
        Me.pictxt.BackColor = System.Drawing.Color.Transparent
        Me.pictxt.BackgroundImage = Global.Gaming.My.Resources.Resources.Textbox
        Me.pictxt.Image = Global.Gaming.My.Resources.Resources.Textbox
        Me.pictxt.Location = New System.Drawing.Point(248, 383)
        Me.pictxt.Name = "pictxt"
        Me.pictxt.Size = New System.Drawing.Size(556, 162)
        Me.pictxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictxt.TabIndex = 30
        Me.pictxt.TabStop = False
        Me.pictxt.Visible = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gaming.My.Resources.Resources.forest
        Me.ClientSize = New System.Drawing.Size(1024, 561)
        Me.Controls.Add(Me.Lblpressspace)
        Me.Controls.Add(Me.lblnpc1)
        Me.Controls.Add(Me.pictxt)
        Me.Controls.Add(Me.picanimation)
        Me.Controls.Add(Me.picgolem)
        Me.Controls.Add(Me.picplayer)
        Me.Controls.Add(Me.picgolemfight)
        Me.Controls.Add(Me.pichitbox)
        Me.Controls.Add(Me.picbackground)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picgolem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picgolemfight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichitbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picanimation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picplayer As PictureBox
    Friend WithEvents tmrmoveanimateright2 As Timer
    Friend WithEvents tmrmoveanimateleft2 As Timer
    Friend WithEvents tmrmoveanimateup2 As Timer
    Friend WithEvents tmrmoveanimatedown2 As Timer
    Friend WithEvents picgolem As PictureBox
    Friend WithEvents picgolemfight As PictureBox
    Friend WithEvents pichitbox As PictureBox
    Friend WithEvents picbackground As PictureBox
    Friend WithEvents picanimation As PictureBox
    Friend WithEvents tmrbattlestart As Timer
    Friend WithEvents Lblpressspace As Label
    Friend WithEvents lblnpc1 As Label
    Friend WithEvents pictxt As PictureBox
End Class
