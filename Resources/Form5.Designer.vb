<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.tmrSwordSlash = New System.Windows.Forms.Timer(Me.components)
        Me.tmrheal = New System.Windows.Forms.Timer(Me.components)
        Me.pichpanimationstop = New System.Windows.Forms.PictureBox()
        Me.pichpup = New System.Windows.Forms.PictureBox()
        Me.lblpressspace = New System.Windows.Forms.Label()
        Me.picExitbattle = New System.Windows.Forms.PictureBox()
        Me.lblinventoryopen = New System.Windows.Forms.Label()
        Me.Picinventoryopen = New System.Windows.Forms.PictureBox()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.picWin = New System.Windows.Forms.PictureBox()
        Me.picGold = New System.Windows.Forms.PictureBox()
        Me.lblEnemy = New System.Windows.Forms.Label()
        Me.lblAnalyze = New System.Windows.Forms.Label()
        Me.lblRun = New System.Windows.Forms.Label()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.lblFight = New System.Windows.Forms.Label()
        Me.lblYou = New System.Windows.Forms.Label()
        Me.lbloptions = New System.Windows.Forms.Label()
        Me.picoptions = New System.Windows.Forms.PictureBox()
        Me.lbltxtblck = New System.Windows.Forms.Label()
        Me.pictxt = New System.Windows.Forms.PictureBox()
        Me.Picgolem = New System.Windows.Forms.PictureBox()
        Me.picsword = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picexplosion = New System.Windows.Forms.PictureBox()
        Me.picmeteormash = New System.Windows.Forms.PictureBox()
        Me.tmrmeteor = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pichpanimationstop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichpup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExitbattle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picinventoryopen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picoptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picgolem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picexplosion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picmeteormash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrSwordSlash
        '
        '
        'tmrheal
        '
        '
        'pichpanimationstop
        '
        Me.pichpanimationstop.Location = New System.Drawing.Point(220, 81)
        Me.pichpanimationstop.Name = "pichpanimationstop"
        Me.pichpanimationstop.Size = New System.Drawing.Size(100, 50)
        Me.pichpanimationstop.TabIndex = 47
        Me.pichpanimationstop.TabStop = False
        Me.pichpanimationstop.Visible = False
        '
        'pichpup
        '
        Me.pichpup.BackColor = System.Drawing.Color.Transparent
        Me.pichpup.Image = Global.Gaming.My.Resources.Resources.HPup
        Me.pichpup.Location = New System.Drawing.Point(237, 172)
        Me.pichpup.Name = "pichpup"
        Me.pichpup.Size = New System.Drawing.Size(55, 50)
        Me.pichpup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pichpup.TabIndex = 46
        Me.pichpup.TabStop = False
        Me.pichpup.Visible = False
        '
        'lblpressspace
        '
        Me.lblpressspace.AutoSize = True
        Me.lblpressspace.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblpressspace.ForeColor = System.Drawing.Color.White
        Me.lblpressspace.Location = New System.Drawing.Point(926, 513)
        Me.lblpressspace.Name = "lblpressspace"
        Me.lblpressspace.Size = New System.Drawing.Size(124, 13)
        Me.lblpressspace.TabIndex = 45
        Me.lblpressspace.Text = "Press Space to Continue"
        Me.lblpressspace.Visible = False
        '
        'picExitbattle
        '
        Me.picExitbattle.BackColor = System.Drawing.Color.MidnightBlue
        Me.picExitbattle.Image = Global.Gaming.My.Resources.Resources.Exitbuttonbattle
        Me.picExitbattle.Location = New System.Drawing.Point(1014, 393)
        Me.picExitbattle.Name = "picExitbattle"
        Me.picExitbattle.Size = New System.Drawing.Size(45, 43)
        Me.picExitbattle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picExitbattle.TabIndex = 37
        Me.picExitbattle.TabStop = False
        '
        'lblinventoryopen
        '
        Me.lblinventoryopen.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblinventoryopen.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinventoryopen.ForeColor = System.Drawing.Color.White
        Me.lblinventoryopen.Location = New System.Drawing.Point(21, 40)
        Me.lblinventoryopen.Name = "lblinventoryopen"
        Me.lblinventoryopen.Size = New System.Drawing.Size(257, 306)
        Me.lblinventoryopen.TabIndex = 43
        Me.lblinventoryopen.Text = "Your Inventory is empty"
        Me.lblinventoryopen.Visible = False
        '
        'Picinventoryopen
        '
        Me.Picinventoryopen.BackColor = System.Drawing.Color.Transparent
        Me.Picinventoryopen.BackgroundImage = Global.Gaming.My.Resources.Resources.Textbox
        Me.Picinventoryopen.Image = Global.Gaming.My.Resources.Resources.Textbox
        Me.Picinventoryopen.Location = New System.Drawing.Point(7, 9)
        Me.Picinventoryopen.Name = "Picinventoryopen"
        Me.Picinventoryopen.Size = New System.Drawing.Size(285, 362)
        Me.Picinventoryopen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picinventoryopen.TabIndex = 44
        Me.Picinventoryopen.TabStop = False
        Me.Picinventoryopen.Visible = False
        Me.Picinventoryopen.WaitOnLoad = True
        '
        'lblWin
        '
        Me.lblWin.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWin.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.ForeColor = System.Drawing.Color.White
        Me.lblWin.Location = New System.Drawing.Point(23, 392)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(1036, 142)
        Me.lblWin.TabIndex = 40
        Me.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWin.Visible = False
        '
        'picWin
        '
        Me.picWin.BackColor = System.Drawing.Color.Transparent
        Me.picWin.BackgroundImage = Global.Gaming.My.Resources.Resources.Textbox
        Me.picWin.Image = Global.Gaming.My.Resources.Resources.Textbox
        Me.picWin.Location = New System.Drawing.Point(1, 377)
        Me.picWin.Name = "picWin"
        Me.picWin.Size = New System.Drawing.Size(1083, 174)
        Me.picWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWin.TabIndex = 41
        Me.picWin.TabStop = False
        Me.picWin.Visible = False
        Me.picWin.WaitOnLoad = True
        '
        'picGold
        '
        Me.picGold.BackColor = System.Drawing.Color.Transparent
        Me.picGold.Image = Global.Gaming.My.Resources.Resources.GoldReward
        Me.picGold.Location = New System.Drawing.Point(807, 237)
        Me.picGold.Name = "picGold"
        Me.picGold.Size = New System.Drawing.Size(202, 96)
        Me.picGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGold.TabIndex = 42
        Me.picGold.TabStop = False
        Me.picGold.Visible = False
        '
        'lblEnemy
        '
        Me.lblEnemy.AutoSize = True
        Me.lblEnemy.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblEnemy.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblEnemy.ForeColor = System.Drawing.Color.White
        Me.lblEnemy.Location = New System.Drawing.Point(756, 396)
        Me.lblEnemy.Name = "lblEnemy"
        Me.lblEnemy.Size = New System.Drawing.Size(253, 31)
        Me.lblEnemy.TabIndex = 36
        Me.lblEnemy.Text = "Werewolf    400/400"
        Me.lblEnemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAnalyze
        '
        Me.lblAnalyze.AutoSize = True
        Me.lblAnalyze.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblAnalyze.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblAnalyze.ForeColor = System.Drawing.Color.White
        Me.lblAnalyze.Location = New System.Drawing.Point(444, 492)
        Me.lblAnalyze.Name = "lblAnalyze"
        Me.lblAnalyze.Size = New System.Drawing.Size(111, 31)
        Me.lblAnalyze.TabIndex = 35
        Me.lblAnalyze.Text = "Analyze"
        Me.lblAnalyze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRun
        '
        Me.lblRun.AutoSize = True
        Me.lblRun.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblRun.ForeColor = System.Drawing.Color.White
        Me.lblRun.Location = New System.Drawing.Point(442, 459)
        Me.lblRun.Name = "lblRun"
        Me.lblRun.Size = New System.Drawing.Size(64, 31)
        Me.lblRun.TabIndex = 34
        Me.lblRun.Text = "Run"
        Me.lblRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInventory
        '
        Me.lblInventory.AutoSize = True
        Me.lblInventory.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblInventory.ForeColor = System.Drawing.Color.White
        Me.lblInventory.Location = New System.Drawing.Point(443, 426)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(127, 31)
        Me.lblInventory.TabIndex = 33
        Me.lblInventory.Text = "Inventory"
        Me.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFight
        '
        Me.lblFight.AutoSize = True
        Me.lblFight.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblFight.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblFight.ForeColor = System.Drawing.Color.White
        Me.lblFight.Location = New System.Drawing.Point(441, 393)
        Me.lblFight.Name = "lblFight"
        Me.lblFight.Size = New System.Drawing.Size(75, 31)
        Me.lblFight.TabIndex = 32
        Me.lblFight.Text = "Fight"
        Me.lblFight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYou
        '
        Me.lblYou.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblYou.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblYou.ForeColor = System.Drawing.Color.White
        Me.lblYou.Location = New System.Drawing.Point(23, 391)
        Me.lblYou.Name = "lblYou"
        Me.lblYou.Size = New System.Drawing.Size(378, 45)
        Me.lblYou.TabIndex = 31
        Me.lblYou.Text = "You                             500/500"
        Me.lblYou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbloptions
        '
        Me.lbloptions.BackColor = System.Drawing.Color.MidnightBlue
        Me.lbloptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloptions.ForeColor = System.Drawing.Color.White
        Me.lbloptions.Location = New System.Drawing.Point(440, 393)
        Me.lbloptions.Name = "lbloptions"
        Me.lbloptions.Size = New System.Drawing.Size(618, 142)
        Me.lbloptions.TabIndex = 29
        Me.lbloptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picoptions
        '
        Me.picoptions.BackColor = System.Drawing.Color.Transparent
        Me.picoptions.BackgroundImage = Global.Gaming.My.Resources.Resources.Textbox
        Me.picoptions.Image = Global.Gaming.My.Resources.Resources.Textbox
        Me.picoptions.Location = New System.Drawing.Point(418, 378)
        Me.picoptions.Name = "picoptions"
        Me.picoptions.Size = New System.Drawing.Size(665, 174)
        Me.picoptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picoptions.TabIndex = 30
        Me.picoptions.TabStop = False
        '
        'lbltxtblck
        '
        Me.lbltxtblck.BackColor = System.Drawing.Color.MidnightBlue
        Me.lbltxtblck.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltxtblck.ForeColor = System.Drawing.Color.White
        Me.lbltxtblck.Location = New System.Drawing.Point(22, 393)
        Me.lbltxtblck.Name = "lbltxtblck"
        Me.lbltxtblck.Size = New System.Drawing.Size(378, 142)
        Me.lbltxtblck.TabIndex = 27
        Me.lbltxtblck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictxt
        '
        Me.pictxt.BackColor = System.Drawing.Color.Transparent
        Me.pictxt.BackgroundImage = Global.Gaming.My.Resources.Resources.Textbox
        Me.pictxt.Image = Global.Gaming.My.Resources.Resources.Textbox
        Me.pictxt.Location = New System.Drawing.Point(3, 378)
        Me.pictxt.Name = "pictxt"
        Me.pictxt.Size = New System.Drawing.Size(417, 174)
        Me.pictxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictxt.TabIndex = 28
        Me.pictxt.TabStop = False
        '
        'Picgolem
        '
        Me.Picgolem.BackColor = System.Drawing.Color.Transparent
        Me.Picgolem.Image = Global.Gaming.My.Resources.Resources.Goleminbattle
        Me.Picgolem.Location = New System.Drawing.Point(811, 67)
        Me.Picgolem.Name = "Picgolem"
        Me.Picgolem.Size = New System.Drawing.Size(198, 252)
        Me.Picgolem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picgolem.TabIndex = 26
        Me.Picgolem.TabStop = False
        '
        'picsword
        '
        Me.picsword.BackColor = System.Drawing.Color.Transparent
        Me.picsword.Image = Global.Gaming.My.Resources.Resources.sword
        Me.picsword.Location = New System.Drawing.Point(273, 249)
        Me.picsword.Name = "picsword"
        Me.picsword.Size = New System.Drawing.Size(182, 43)
        Me.picsword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picsword.TabIndex = 39
        Me.picsword.TabStop = False
        Me.picsword.Visible = False
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer.Image = Global.Gaming.My.Resources.Resources.Knight
        Me.picPlayer.Location = New System.Drawing.Point(161, 133)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(187, 186)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 38
        Me.picPlayer.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gaming.My.Resources.Resources.Forestback
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1084, 567)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'picexplosion
        '
        Me.picexplosion.BackColor = System.Drawing.Color.Transparent
        Me.picexplosion.Image = Global.Gaming.My.Resources.Resources.Exploanimate
        Me.picexplosion.Location = New System.Drawing.Point(773, 62)
        Me.picexplosion.Name = "picexplosion"
        Me.picexplosion.Size = New System.Drawing.Size(100, 92)
        Me.picexplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picexplosion.TabIndex = 50
        Me.picexplosion.TabStop = False
        Me.picexplosion.Visible = False
        '
        'picmeteormash
        '
        Me.picmeteormash.BackColor = System.Drawing.Color.Transparent
        Me.picmeteormash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picmeteormash.Image = Global.Gaming.My.Resources.Resources.MeteorMash
        Me.picmeteormash.Location = New System.Drawing.Point(621, -25)
        Me.picmeteormash.Name = "picmeteormash"
        Me.picmeteormash.Size = New System.Drawing.Size(125, 115)
        Me.picmeteormash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picmeteormash.TabIndex = 49
        Me.picmeteormash.TabStop = False
        Me.picmeteormash.Visible = False
        '
        'tmrmeteor
        '
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gaming.My.Resources.Resources.Forestback
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.picexplosion)
        Me.Controls.Add(Me.picmeteormash)
        Me.Controls.Add(Me.pichpanimationstop)
        Me.Controls.Add(Me.pichpup)
        Me.Controls.Add(Me.lblpressspace)
        Me.Controls.Add(Me.picExitbattle)
        Me.Controls.Add(Me.lblinventoryopen)
        Me.Controls.Add(Me.Picinventoryopen)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.picWin)
        Me.Controls.Add(Me.picGold)
        Me.Controls.Add(Me.lblEnemy)
        Me.Controls.Add(Me.lblAnalyze)
        Me.Controls.Add(Me.lblRun)
        Me.Controls.Add(Me.lblInventory)
        Me.Controls.Add(Me.lblFight)
        Me.Controls.Add(Me.lblYou)
        Me.Controls.Add(Me.lbloptions)
        Me.Controls.Add(Me.picoptions)
        Me.Controls.Add(Me.lbltxtblck)
        Me.Controls.Add(Me.pictxt)
        Me.Controls.Add(Me.Picgolem)
        Me.Controls.Add(Me.picsword)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.pichpanimationstop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichpup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExitbattle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picinventoryopen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picoptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picgolem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picexplosion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picmeteormash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrSwordSlash As Timer
    Friend WithEvents tmrheal As Timer
    Friend WithEvents pichpanimationstop As PictureBox
    Friend WithEvents pichpup As PictureBox
    Friend WithEvents lblpressspace As Label
    Friend WithEvents picExitbattle As PictureBox
    Friend WithEvents lblinventoryopen As Label
    Friend WithEvents Picinventoryopen As PictureBox
    Friend WithEvents lblWin As Label
    Friend WithEvents picWin As PictureBox
    Friend WithEvents picGold As PictureBox
    Friend WithEvents lblEnemy As Label
    Friend WithEvents lblAnalyze As Label
    Friend WithEvents lblRun As Label
    Friend WithEvents lblInventory As Label
    Friend WithEvents lblFight As Label
    Friend WithEvents lblYou As Label
    Friend WithEvents lbloptions As Label
    Friend WithEvents picoptions As PictureBox
    Friend WithEvents lbltxtblck As Label
    Friend WithEvents pictxt As PictureBox
    Friend WithEvents Picgolem As PictureBox
    Friend WithEvents picsword As PictureBox
    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picexplosion As PictureBox
    Friend WithEvents picmeteormash As PictureBox
    Friend WithEvents tmrmeteor As Timer
End Class
