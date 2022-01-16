<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblnpc1 = New System.Windows.Forms.Label()
        Me.picnpc1 = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picspeak = New System.Windows.Forms.PictureBox()
        Me.pictxt = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picnpc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picspeak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblnpc1
        '
        Me.lblnpc1.BackColor = System.Drawing.Color.Black
        Me.lblnpc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnpc1.ForeColor = System.Drawing.Color.White
        Me.lblnpc1.Location = New System.Drawing.Point(299, 396)
        Me.lblnpc1.Name = "lblnpc1"
        Me.lblnpc1.Size = New System.Drawing.Size(495, 130)
        Me.lblnpc1.TabIndex = 2
        Me.lblnpc1.Text = "Hello Big Bird 1"
        Me.lblnpc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblnpc1.Visible = False
        '
        'picnpc1
        '
        Me.picnpc1.Image = Global.Gaming.My.Resources.Resources.BigBird
        Me.picnpc1.Location = New System.Drawing.Point(216, 201)
        Me.picnpc1.Name = "picnpc1"
        Me.picnpc1.Size = New System.Drawing.Size(60, 60)
        Me.picnpc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picnpc1.TabIndex = 1
        Me.picnpc1.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.Image = Global.Gaming.My.Resources.Resources.BigBird
        Me.picPlayer.Location = New System.Drawing.Point(12, 261)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(60, 60)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picspeak
        '
        Me.picspeak.Location = New System.Drawing.Point(211, 196)
        Me.picspeak.Name = "picspeak"
        Me.picspeak.Size = New System.Drawing.Size(70, 70)
        Me.picspeak.TabIndex = 3
        Me.picspeak.TabStop = False
        Me.picspeak.Visible = False
        '
        'pictxt
        '
        Me.pictxt.BackgroundImage = Global.Gaming.My.Resources.Resources.Textbox
        Me.pictxt.Image = Global.Gaming.My.Resources.Resources.Textbox
        Me.pictxt.Location = New System.Drawing.Point(270, 381)
        Me.pictxt.Name = "pictxt"
        Me.pictxt.Size = New System.Drawing.Size(556, 162)
        Me.pictxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictxt.TabIndex = 4
        Me.pictxt.TabStop = False
        Me.pictxt.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gaming.My.Resources.Resources.TownBack
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1090, 564)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.lblnpc1)
        Me.Controls.Add(Me.picnpc1)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picspeak)
        Me.Controls.Add(Me.pictxt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "BingBong Gaming"
        CType(Me.picnpc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picspeak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picnpc1 As PictureBox
    Friend WithEvents lblnpc1 As Label
    Friend WithEvents picspeak As PictureBox
    Friend WithEvents pictxt As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
