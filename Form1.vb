

Public Class Form1
    Dim walkright As Integer = 0
    Dim walkleft As Integer = 0
    Dim walkdown As Integer = 0
    Dim walkup As Integer = 0




    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim collision(4) As PictureBox       'array for all the picture boxes in the form
        collision = {picWereWolf, picnpc1, PictureBox2, PictureBox3, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, PictureBox12, PictureBox13, PictureBox14, PictureBox15, PictureBox16, PictureBox17, PictureBox18, PictureBox19, PictureBox20}

        Select Case e.KeyCode    'key

            Case Keys.D     'D is the move right, W is move up, A is move left, S is move down
                'The movement is controlled by moving the character by 5 in the direction first and then checking if moving is false, 
                'if it intersects with a Picture box or if it goes off screen it will move the player back. This gives the illusion that there was no movement  
                loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                picPlayer.Location = loc

                If moving = True Then
                    tmrmoveanimateright.Start()
                    tmrmoveanimateright.Interval = 200
                End If


                If picPlayer.Location.X > 1025 Or moving = False Then         'repeat for all directions

                    loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = loc

                Else
                    For Each P As PictureBox In collision
                        If picPlayer.Bounds.IntersectsWith(P.Bounds) = True Then


                            loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                            picPlayer.Location = loc
                        End If
                    Next


                End If


            Case Keys.A
                loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                picPlayer.Location = loc

                If moving = True Then
                    tmrmoveanimateleft.Start()
                    tmrmoveanimateleft.Interval = 200
                End If


                If picPlayer.Location.X < 0 Or moving = False Then         'repeat for all directions

                    loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = loc

                Else
                    For Each P As PictureBox In collision
                        If picPlayer.Bounds.IntersectsWith(P.Bounds) = True Then


                            loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                            picPlayer.Location = loc
                        End If
                    Next


                End If


                If picPlayer.Bounds.IntersectsWith(picleftmove.Bounds) And WWgone = True Then

                    Form4.Show()
                    Form4.Location = Me.Location
                    Me.Hide()


                End If



            Case Keys.W
                loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = loc

                If moving = True Then
                    tmrmoveanimateup.Start()
                    tmrmoveanimateup.Interval = 200
                End If


                If picPlayer.Location.Y < 0 Or moving = False Then         'repeat for all directions

                    loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = loc

                Else
                    For Each P As PictureBox In collision
                        If picPlayer.Bounds.IntersectsWith(P.Bounds) = True Then


                            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                            picPlayer.Location = loc
                        End If
                    Next


                End If

            Case Keys.S
                loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                picPlayer.Location = loc

                If moving = True Then
                    tmrmoveanimatedown.Start()
                    tmrmoveanimatedown.Interval = 200
                End If


                If picPlayer.Location.Y > 500 Or moving = False Then         'repeat for all directions

                    loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                    picPlayer.Location = loc

                Else
                    For Each P As PictureBox In collision
                        If picPlayer.Bounds.IntersectsWith(P.Bounds) = True Then


                            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                            picPlayer.Location = loc
                        End If
                    Next


                End If
            Case Keys.Space
                If picPlayer.Bounds.IntersectsWith(picspeak.Bounds) And Chat = 0 And WWgone = False Then   'If the player is in the hitbox for the npc and if they press space then the text starts and you cant move
                    Me.lblnpc1.Visible = True
                    pictxt.Visible = True
                    lblnpc1.Text = "Hello Knight"
                    moving = False
                    Chat = 1
                    Lblpressspace.Show()
                ElseIf Chat = 1 Then
                    lblnpc1.Text = "You must defeat the monsters to continue"       'Everytime you press space next to the npc the chat coutner goes up and once it reaches 3
                    Chat = 2                                                         'you can move again and if you speak to him again he just sais go
                ElseIf Chat = 2 Then
                    lblnpc1.Text = "Go now"
                    Chat = 3
                ElseIf Chat = 3 Then
                    lblnpc1.Visible = False
                    moving = True
                    Chat = 4
                    pictxt.Visible = False
                    Lblpressspace.Hide()
                End If
                If Chat = 4 And picPlayer.Bounds.IntersectsWith(picspeak.Bounds) And WWgone = False Then
                    lblnpc1.Visible = True
                    lblnpc1.Text = "Go"
                    Chat = 5
                    pictxt.Visible = True
                    moving = False
                    Lblpressspace.Show()
                ElseIf Chat = 5 Then
                    lblnpc1.Visible = False
                    Chat = 4
                    pictxt.Visible = False
                    moving = True
                    Lblpressspace.Hide()
                ElseIf WWgone = True And Chat = 4 Then
                    lblnpc1.Visible = True
                    lblnpc1.Text = "Thanks now go to the left part of the village to clear the monsters away"
                    pictxt.Visible = True
                    moving = False
                    Lblpressspace.Show()
                    Chat = 6
                ElseIf Chat = 6 And WWgone = True Then
                    lblnpc1.Visible = False
                    Chat = 4
                    pictxt.Visible = False
                    moving = True
                    Lblpressspace.Hide()
                End If

                If picPlayer.Bounds.IntersectsWith(pichitboxww.Bounds) And WWgone = False Then

                    tmrbattle.Start()
                    tmrbattle.Interval = 15
                End If

                If lblnpc1.Text = "Go help the poor villager from the werewolf" Then
                    lblnpc1.Visible = False

                    pictxt.Visible = False
                    moving = True
                    Lblpressspace.Hide()
                    pictxt.Text = ""
                End If
                If lblnpc1.Text = "Great now go help the villagers to the left" Then
                    lblnpc1.Visible = False

                    pictxt.Visible = False
                    moving = True
                    Lblpressspace.Hide()
                    pictxt.Text = ""
                End If
        End Select


    End Sub




    Private Sub tmranimate_Tick(sender As Object, e As EventArgs) Handles tmranimate.Tick

        If frame = 1 Then
            picWereWolf.Image = ww1
            frame = 2
        Else
            picWereWolf.Image = ww2
            frame = 1
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmranimate.Start()

        tmranimate.Interval = 500

        frame = 1
        ww2.MakeTransparent(Color.White)

        ww1.MakeTransparent(Color.White)

        knightright.MakeTransparent(Color.White)



        If WWgone = True Then
            picWereWolf.Hide()
            picPlayer.Location = locbattle

            Me.lblnpc1.Visible = True
            pictxt.Visible = True
            lblnpc1.Text = "Great now go help the villagers to the left"
            moving = False
            Lblpressspace.Show()
            picWereWolf.Location = New Point(1000, 1000)
        Else
            picPlayer.Location = New Point(161, 327)
            Me.lblnpc1.Visible = True
            pictxt.Visible = True
            lblnpc1.Text = "Go help the poor villager from the werewolf"
            moving = False
            Lblpressspace.Show()
        End If
    End Sub

    Private Sub tmrbattle_Tick(sender As Object, e As EventArgs) Handles tmrbattle.Tick
        If picBattleintro.Location.X > 0 Then
            battle = New Point(picBattleintro.Location.X - 25, picBattleintro.Location.Y)
            picBattleintro.Location = battle
        Else

            Form3.Show()

            Form3.Location = Me.Location


            Me.Close()
            tmrbattle.Stop()
        End If
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        locbattle = New Point(picPlayer.Location.X, picPlayer.Location.Y)

    End Sub

    Private Sub tmrmoveanimate_Tick(sender As Object, e As EventArgs) Handles tmrmoveanimateright.Tick
        knightright.MakeTransparent(Color.White)

        If walkright = 0 Then
            picPlayer.Image = My.Resources.Knightwalkingright1
            walkright = 1
        ElseIf walkright = 1 Then
            picPlayer.Image = knightright
            walkright = 2
        ElseIf walkright = 2 Then
            picPlayer.Image = My.Resources.Knightwalkingright2
            walkright = 3
        ElseIf walkright = 3 Then
            picPlayer.Image = knightright
            walkright = 0
        End If


    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.D

                tmrmoveanimateright.Stop()
                knightright.MakeTransparent(Color.White)
                picPlayer.Image = knightright
                walkright = 0

        End Select
        Select Case e.KeyCode
            Case Keys.A
                tmrmoveanimateleft.Stop()
                picPlayer.Image = My.Resources.knightleft
                walkleft = 0
        End Select
        Select Case e.KeyCode
            Case Keys.S
                tmrmoveanimatedown.Stop()
                picPlayer.Image = My.Resources.Knightfront
                walkdown = 0
        End Select
        Select Case e.KeyCode
            Case Keys.W
                tmrmoveanimateup.Stop()
                picPlayer.Image = My.Resources.Knightbackwards
                walkup = 0
        End Select
    End Sub

    Private Sub tmrmoveanimateleft_Tick(sender As Object, e As EventArgs) Handles tmrmoveanimateleft.Tick
        If walkleft = 0 Then
            picPlayer.Image = My.Resources.knightwalkingleft1
            walkleft = 1
        ElseIf walkleft = 1 Then
            picPlayer.Image = My.Resources.knightleft
            walkleft = 2
        ElseIf walkleft = 2 Then
            picPlayer.Image = My.Resources.knightWalkingleft2
            walkleft = 3
        ElseIf walkleft = 3 Then
            picPlayer.Image = My.Resources.knightleft
            walkleft = 0
        End If
    End Sub

    Private Sub tmrmoveanimatedown_Tick(sender As Object, e As EventArgs) Handles tmrmoveanimatedown.Tick
        If walkdown = 0 Then
            picPlayer.Image = My.Resources.Knightfrontwalking1
            walkdown = 1
        ElseIf walkdown = 1 Then
            picPlayer.Image = My.Resources.Knightfront
            walkdown = 2
        ElseIf walkdown = 2 Then
            picPlayer.Image = My.Resources.knightfrontwalking2
            walkdown = 3
        ElseIf walkdown = 3 Then
            picPlayer.Image = My.Resources.Knightfront
            walkdown = 0
        End If
    End Sub

    Private Sub tmrmoveanimateup_Tick(sender As Object, e As EventArgs) Handles tmrmoveanimateup.Tick
        If walkup = 0 Then
            picPlayer.Image = My.Resources.Knightbackwalk1
            walkup = 1
        ElseIf walkleft = 1 Then
            picPlayer.Image = My.Resources.Knightbackwards
            walkup = 2
        ElseIf walkup = 2 Then
            picPlayer.Image = My.Resources.knightbackwalk2
            walkup = 3
        ElseIf walkup = 3 Then
            picPlayer.Image = My.Resources.Knightbackwards
            walkup = 0
        End If
    End Sub
End Class
