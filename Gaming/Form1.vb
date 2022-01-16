Public Class Form1

    Dim loc As Point   'location of player

    Dim moving As Boolean = True   'Check to allow movement, true = can move

    Dim Chat As Integer = 0    'Integer to check how many text boxes the npc has spoken


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim collision(4) As PictureBox       'array for all the picture boxes in the form
        collision = {picnpc1}

        Select Case e.KeyCode    'key

            Case Keys.D     'D is the move right, W is move up, A is move left, S is move down
                'The movement is controlled by moving the character by 5 in the direction first and then checking if moving is false, 
                'if it intersects with a Picture box or if it goes off screen it will move the player back. This gives the illusion that there was no movement  

                For Each P As PictureBox In collision
                    loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = loc
                    If picPlayer.Location.X > 1025 Or moving = False Or picPlayer.Bounds.IntersectsWith(P.Bounds) = True Then      'repeat for all directions
                        loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = loc
                    End If
                Next

            Case Keys.A


                For Each P As PictureBox In collision
                    loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = loc
                    If picPlayer.Location.X < 0 Or moving = False Or picPlayer.Bounds.IntersectsWith(P.Bounds) = True Then      'repeat for all directions
                        loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = loc
                    End If
                Next

            Case Keys.W


                For Each P As PictureBox In collision
                    loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                    picPlayer.Location = loc
                    If picPlayer.Location.Y < 0 Or moving = False Or picPlayer.Bounds.IntersectsWith(P.Bounds) = True Then      'repeat for all directions
                        loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = loc
                    End If
                Next

            Case Keys.S

                For Each P As PictureBox In collision
                    loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = loc
                    If picPlayer.Location.Y > 500 Or moving = False Or picPlayer.Bounds.IntersectsWith(P.Bounds) = True Then      'repeat for all directions
                        loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = loc
                    End If
                Next


            Case Keys.Space
                If picPlayer.Bounds.IntersectsWith(picspeak.Bounds) And Chat = 0 Then     'If the player is in the hitbox for the npc
                    Me.lblnpc1.Visible = True
                    pictxt.Visible = True
                    moving = False
                    Chat = 1
                ElseIf Chat = 1 Then
                    lblnpc1.Text = "You must defeat the monsters to continue"
                    Chat = 2
                ElseIf Chat = 2 Then
                    lblnpc1.Text = "Go now"
                    Chat = 3
                ElseIf Chat = 3 Then
                    lblnpc1.Visible = False
                    moving = True
                    Chat = 4
                    pictxt.Visible = False
                ElseIf Chat = 4 And picPlayer.Bounds.IntersectsWith(picspeak.Bounds) Then
                    lblnpc1.Visible = True
                    lblnpc1.Text = "Go"
                    Chat = 5
                    pictxt.Visible = True
                    moving = False
                ElseIf Chat = 5 Then
                    lblnpc1.Visible = False
                    Chat = 4
                    pictxt.Visible = False
                    moving = True
                End If
        End Select


    End Sub


End Class
