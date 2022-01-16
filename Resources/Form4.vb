


Public Class Form4
        Dim walkright As Integer = 0
        Dim walkleft As Integer = 0
        Dim walkdown As Integer = 0
        Dim walkup As Integer = 0
    Dim animation As Point

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown



            Dim collision(4) As PictureBox       'array for all the picture boxes in the form
        collision = {picgolem, pichitbox}

        Select Case e.KeyCode    'key

                Case Keys.D     'D is the move right, W is move up, A is move left, S is move down
                    'The movement is controlled by moving the character by 5 in the direction first and then checking if moving is false, 
                    'if it intersects with a Picture box or if it goes off screen it will move the player back. This gives the illusion that there was no movement  
                    loc = New Point(picplayer.Location.X + 5, picplayer.Location.Y)
                    picplayer.Location = loc

                    If moving = True Then
                        tmrmoveanimateright2.Start()
                        tmrmoveanimateright2.Interval = 200
                    End If


                    If picplayer.Location.X > 1025 Or moving = False Then         'repeat for all directions

                        loc = New Point(picplayer.Location.X - 5, picplayer.Location.Y)
                        picplayer.Location = loc

                    Else
                        For Each P As PictureBox In collision
                            If picplayer.Bounds.IntersectsWith(P.Bounds) = True Then


                                loc = New Point(picplayer.Location.X - 5, picplayer.Location.Y)
                                picplayer.Location = loc
                            End If
                        Next


                    End If


                Case Keys.A
                    loc = New Point(picplayer.Location.X - 5, picplayer.Location.Y)
                    picplayer.Location = loc

                    If moving = True Then
                        tmrmoveanimateleft2.Start()
                        tmrmoveanimateleft2.Interval = 200
                    End If


                    If picplayer.Location.X < 0 Or moving = False Then         'repeat for all directions

                        loc = New Point(picplayer.Location.X + 5, picplayer.Location.Y)
                        picplayer.Location = loc

                    Else
                        For Each P As PictureBox In collision
                            If picplayer.Bounds.IntersectsWith(P.Bounds) = True Then


                                loc = New Point(picplayer.Location.X + 5, picplayer.Location.Y)
                                picplayer.Location = loc
                            End If
                        Next


                    End If






                Case Keys.W
                    loc = New Point(picplayer.Location.X, picplayer.Location.Y - 5)
                    picplayer.Location = loc

                    If moving = True Then
                        tmrmoveanimateup2.Start()
                        tmrmoveanimateup2.Interval = 200
                    End If


                    If picplayer.Location.Y < 0 Or moving = False Then         'repeat for all directions

                        loc = New Point(picplayer.Location.X, picplayer.Location.Y + 5)
                        picplayer.Location = loc

                    Else
                        For Each P As PictureBox In collision
                            If picplayer.Bounds.IntersectsWith(P.Bounds) = True Then


                                loc = New Point(picplayer.Location.X, picplayer.Location.Y + 5)
                                picplayer.Location = loc
                            End If
                        Next


                    End If

                Case Keys.S
                    loc = New Point(picplayer.Location.X, picplayer.Location.Y + 5)
                    picplayer.Location = loc

                    If moving = True Then
                        tmrmoveanimatedown2.Start()
                        tmrmoveanimatedown2.Interval = 200
                    End If


                    If picplayer.Location.Y > 500 Or moving = False Then         'repeat for all directions

                        loc = New Point(picplayer.Location.X, picplayer.Location.Y - 5)
                        picplayer.Location = loc

                    Else
                        For Each P As PictureBox In collision
                            If picplayer.Bounds.IntersectsWith(P.Bounds) = True Then


                                loc = New Point(picplayer.Location.X, picplayer.Location.Y - 5)
                                picplayer.Location = loc
                            End If
                        Next


                    End If
                Case Keys.Space
                If picplayer.Bounds.IntersectsWith(picgolemfight.Bounds) Then
                    tmrbattlestart.Start()
                    tmrbattlestart.Interval = 1
                End If




        End Select

    End Sub




    Private Sub tmrmoveanimateright2_Tick(sender As Object, e As EventArgs) Handles tmrmoveanimateright2.Tick
        knightright.MakeTransparent(Color.White)

        If walkright = 0 Then
            picplayer.Image = My.Resources.Knightwalkingright1
            walkright = 1
        ElseIf walkright = 1 Then
            picplayer.Image = knightright
            walkright = 2
        ElseIf walkright = 2 Then
            picplayer.Image = My.Resources.Knightwalkingright2
            walkright = 3
        ElseIf walkright = 3 Then
            picplayer.Image = knightright
            walkright = 0
        End If


    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.D

                tmrmoveanimateright2.Stop()
                knightright.MakeTransparent(Color.White)
                picplayer.Image = knightright
                walkright = 0

        End Select
        Select Case e.KeyCode
            Case Keys.A
                tmrmoveanimateleft2.Stop()
                picplayer.Image = My.Resources.knightleft
                walkleft = 0
        End Select
        Select Case e.KeyCode
            Case Keys.S
                tmrmoveanimatedown2.Stop()
                picplayer.Image = My.Resources.Knightfront
                walkdown = 0
        End Select
        Select Case e.KeyCode
            Case Keys.W
                tmrmoveanimateup2.Stop()
                picplayer.Image = My.Resources.Knightbackwards
                walkup = 0
        End Select
    End Sub

    Private Sub tmrmoveanimateleft2_Tick(sender As Object, e As EventArgs) Handles tmrmoveanimateleft2.Tick
        If walkleft = 0 Then
            picplayer.Image = My.Resources.knightwalkingleft1
            walkleft = 1
        ElseIf walkleft = 1 Then
            picplayer.Image = My.Resources.knightleft
            walkleft = 2
        ElseIf walkleft = 2 Then
            picplayer.Image = My.Resources.knightWalkingleft2
            walkleft = 3
        ElseIf walkleft = 3 Then
            picplayer.Image = My.Resources.knightleft
            walkleft = 0
        End If
    End Sub

    Private Sub tmrmoveanimatedown2_Tick(sender As Object, e As EventArgs) Handles tmrmoveanimatedown2.Tick
        If walkdown = 0 Then
            picplayer.Image = My.Resources.Knightfrontwalking1
            walkdown = 1
        ElseIf walkdown = 1 Then
            picplayer.Image = My.Resources.Knightfront
            walkdown = 2
        ElseIf walkdown = 2 Then
            picplayer.Image = My.Resources.knightfrontwalking2
            walkdown = 3
        ElseIf walkdown = 3 Then
            picplayer.Image = My.Resources.Knightfront
            walkdown = 0
        End If
    End Sub

    Private Sub tmrmoveanimateup2_Tick(sender As Object, e As EventArgs) Handles tmrmoveanimateup2.Tick
        If walkup = 0 Then
            picplayer.Image = My.Resources.Knightbackwalk1
            walkup = 1
        ElseIf walkleft = 1 Then
            picplayer.Image = My.Resources.Knightbackwards
            walkup = 2
        ElseIf walkup = 2 Then
            picplayer.Image = My.Resources.knightbackwalk2
            walkup = 3
        ElseIf walkup = 3 Then
            picplayer.Image = My.Resources.Knightbackwards
            walkup = 0
        End If
    End Sub

    Private Sub tmrbattlestart_Tick(sender As Object, e As EventArgs) Handles tmrbattlestart.Tick


        picanimation.Location = New Point(picanimation.Location.X, picanimation.Location.Y + 5)


        If picanimation.Location.Y > -125 Then
            Form5.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblnpc1.Show()
        pictxt.Show()
        Lblpressspace.Show()
    End Sub
End Class

