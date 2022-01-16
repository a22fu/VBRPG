

Public Class Form3
    Dim wwsprite As Bitmap = My.Resources.WWBAttle    'A variable to create a sprite for the enemy so it can be changed and reset later

    Dim Hp As Integer = 500 'set the Hp of the player

    Dim WWHp As Integer = 400 'set the Hp of the enemy

    Dim sword As Point  'the position of the sword so i can animate it slightly

    Dim hpup As Point

    Dim turn As Boolean = True  'A boolean check to see if it is your turn or not

    Dim attacks As Boolean = False  'boolean to check if you are looking at the attacks screen or not true means yes

    Dim attackStat As Integer 'integer to tell how much damage you do

    Dim WWturn As Boolean 'boolean to check if its the werewolfs turn

    Dim WWloc As Point

    Dim Meteor As Point

    Dim explosion As Boolean = True

    Private Sub lblFight_Click(sender As Object, e As EventArgs) Handles lblFight.Click


        If lblFight.Text = "Fight" Then
            lblFight.Text = "Sword Slash"
            lblInventory.Text = "Heal Spell"
            lblRun.Text = "Meteor Mash"
            lblAnalyze.Hide()
            picExitbattle.Show()
            attacks = True
        ElseIf attacks = True And turn = True Then

            picsword.Show()
            tmrSwordSlash.Start()
            tmrSwordSlash.Interval = 1
            turn = False
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblYou.Text = "You                             " & Hp & "/" & Hp
        lblEnemy.Text = "Werewolf    " & WWHp & "/" & 400


        wwsprite.MakeTransparent(Color.White)
        PicWW.Image = wwsprite
        picexplosion.Image = My.Resources.exploanimate
    End Sub

    Private Sub tmrSwordSlash_Tick(sender As Object, e As EventArgs) Handles tmrSwordSlash.Tick
        If picsword.Visible = True And picsword.Bounds.IntersectsWith(PicWW.Bounds) = False Then

            sword = New Point(picsword.Location.X + 5, picsword.Location.Y)
            picsword.Location = sword

        ElseIf WWturn = True And PicWW.Bounds.IntersectsWith(picplayer.Bounds) = False Then
            WWloc = New Point(PicWW.Location.X - 5, PicWW.Location.Y)
            PicWW.Location = WWloc

        ElseIf PicWW.Bounds.IntersectsWith(picplayer.Bounds) = True Then
            PicWW.Location = New Point(812, 80)
            turn = True
            WWturn = False
            Hp = Hp - 175
            lblYou.Text = "You                             " & Hp & "/500"
            tmrSwordSlash.Stop()
        Else
            picsword.Hide()



            sword = New Point(274, 248)
            picsword.Location = sword

            Randomize()
            WWHp = WWHp - 190 - 90 * Rnd() + 90
            lblEnemy.Text = "Werewolf    " & WWHp & "/" & 400

            WWturn = True

            If WWHp < 0 Then
                WWgone = True
                WWHp = 0
                lblEnemy.Text = "Werewolf    " & WWHp & "/" & 400
                turn = False
                lblWin.Show()
                picWin.Show()
                lblWin.Text = "You have defeated the Werewolf. You have gained 20 Gold and 20 EXP"

                PicWW.Hide()
                picGold.Show()
                picExitbattle.Hide()

            End If




        End If

    End Sub
    Private Sub picExitbattle_Click(sender As Object, e As EventArgs) Handles picExitbattle.Click
        If lblWin.Text = "You must save the big bird" Then
            lblWin.Hide()
            picWin.Hide()
            lblWin.Text = ""
            picExitbattle.Hide()
        ElseIf lblinventoryopen.Visible = True Then
            lblWin.Hide()
            picWin.Hide()
            picExitbattle.Hide()
            Picinventoryopen.Hide()
            lblinventoryopen.Hide()
        ElseIf lblWin.Text = "You are facing a Werewolf, use your Sword Slash ability to kill it." Then
            lblWin.Hide()
            picWin.Hide()
            picExitbattle.Hide()

        ElseIf turn = True And attacks = True Then
            lblInventory.Text = "Inventory"
            lblFight.Text = "Fight"
            lblRun.Text = "run"
            lblInventory.Show()
            lblAnalyze.Show()
            lblRun.Show()
            picExitbattle.Hide()

        End If
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode

            Case Keys.Space
                If lblWin.Visible = True And lblWin.Text = "You have defeated the Werewolf. You have gained 20 Gold and 20 EXP" Then
                    Form1.Show()
                    Me.Hide()
                    lblpressspace.Show()

                End If

        End Select
    End Sub

    Private Sub lblRun_Click(sender As Object, e As EventArgs) Handles lblRun.Click



        If lblFight.Text = "run" Then
            lblWin.Show()
            picWin.Show()
            picExitbattle.Show()
            lblWin.Text = "You must save the big bird"
        ElseIf attacks = True And turn = True Then

            picmeteormash.Show()
            tmrmeteor.Start()
            tmrmeteor.Interval = 1
            explosion = False
            turn = False
        End If


    End Sub

    Private Sub lblInventory_Click(sender As Object, e As EventArgs) Handles lblInventory.Click

        If lblInventory.Text = "Inventory" Then
            lblWin.Show()
            picWin.Show()

            lblinventoryopen.Show()
            Picinventoryopen.Show()
            picExitbattle.Show()
        ElseIf lblInventory.Text = "Heal Spell" And attacks = True And turn = True Then
            pichpup.Location = New Point(247, 171)
            pichpup.Show()
            tmrheal.Start()
            tmrheal.Interval = 10
            turn = False
        End If



    End Sub

    Private Sub lblAnalyze_Click(sender As Object, e As EventArgs) Handles lblAnalyze.Click
        lblWin.Show()
        picWin.Show()
        lblWin.Text = "You are facing a Werewolf, use your Sword Slash ability to kill it."

        picExitbattle.Show()
    End Sub

    Private Sub tmrheal_Tick(sender As Object, e As EventArgs) Handles tmrheal.Tick
        If pichpup.Visible = True And pichpup.Bounds.IntersectsWith(pichpanimationstop.Bounds) = False Then

            hpup = New Point(pichpup.Location.X, pichpup.Location.Y - 5)
            pichpup.Location = hpup




        ElseIf WWturn = True And PicWW.Bounds.IntersectsWith(picPlayer.Bounds) = False Then
            WWloc = New Point(PicWW.Location.X - 5, PicWW.Location.Y)
            PicWW.Location = WWloc


        ElseIf PicWW.Bounds.IntersectsWith(picPlayer.Bounds) = True Then
            PicWW.Location = New Point(812, 80)

            turn = True
            WWturn = False
            Hp = Hp - 175
            lblYou.Text = "You                             " & Hp & "/500"
            tmrheal.Stop()
        Else
            Randomize()
            Hp = Hp + (190 - 165 + 1) * Rnd() + 165
            If Hp > 500 Then
                Hp = 500
            End If
            lblYou.Text = "You                             " & Hp & "/500"



            pichpup.Hide()



            WWturn = True



        End If

    End Sub

    Private Sub tmrmeteor_Tick(sender As Object, e As EventArgs) Handles tmrmeteor.Tick
        If picmeteormash.Visible = True And picmeteormash.Bounds.IntersectsWith(PicWW.Bounds) = False Then

            Meteor = New Point(picmeteormash.Location.X + 5, picmeteormash.Location.Y + 5)
            picmeteormash.Location = Meteor

        ElseIf WWturn = True And PicWW.Bounds.IntersectsWith(picPlayer.Bounds) = False Then
            WWloc = New Point(PicWW.Location.X - 5, PicWW.Location.Y)
            PicWW.Location = WWloc

        ElseIf PicWW.Bounds.IntersectsWith(picPlayer.Bounds) = True Then
            PicWW.Location = New Point(812, 80)
            turn = True
            WWturn = False
            Hp = Hp - 175
            lblYou.Text = "You                             " & Hp & "/500"
            tmrmeteor.Stop()
        Else
            picmeteormash.Hide()
            If picexplosion.Visible = False And explosion = False Then
                picexplosion.Show()
                tmrmeteor.Interval = 500
                explosion = True
            Else
                tmrmeteor.Interval = 1
                picexplosion.Hide()
                explosion = True
                Meteor = New Point(648, 15)
                picmeteormash.Location = Meteor
                Randomize()
                WWHp = WWHp - (300 - 1) * Rnd() + 1
                lblEnemy.Text = "Werewolf    " & WWHp & "/" & 400

                WWturn = True

                If WWHp < 0 Then
                    WWgone = True
                    WWHp = 0
                    lblEnemy.Text = "Werewolf    " & WWHp & "/" & 400
                    turn = False
                    lblWin.Show()
                    picWin.Show()
                    lblWin.Text = "You have defeated the Werewolf. You have gained 20 Gold and 20 EXP"

                    PicWW.Hide()
                    picGold.Show()
                    picExitbattle.Hide()

                End If

            End If





        End If
    End Sub
End Class