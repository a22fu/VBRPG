Public Class Form2
    Private Sub picPlay_MouseEnter(sender As Object, e As EventArgs) Handles picPlay.MouseEnter
        picArrow1.Show()
        picArrow2.Hide()
        picArrow3.Hide()                  'Show the arrow next to it and hide the others   Repeat with the next three options
    End Sub

    Private Sub picHowto_MouseEnter(sender As Object, e As EventArgs) Handles picHowto.MouseEnter
        picArrow1.Hide()
        picArrow2.Show()
        picArrow3.Hide()
    End Sub

    Private Sub picExit_MouseEnter(sender As Object, e As EventArgs) Handles picExit.MouseEnter
        picArrow1.Hide()
        picArrow2.Hide()
        picArrow3.Show()
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Application.Exit()    'Exit
    End Sub

    Private Sub picPlay_Click(sender As Object, e As EventArgs) Handles picPlay.Click
        Form1.Show()
        Form1.Location = Me.Location
        Me.Close()                                          'Open the gameplay form in the same location

    End Sub

    Private Sub picHowto_Click(sender As Object, e As EventArgs) Handles picHowto.Click
        picArrow1.Hide()
        picArrow2.Hide()
        picArrow3.Hide()
        picExit.Hide()
        picPlay.Hide()
        picHowto.Hide()               'Hide everything and open the How to Play Window label and back button
        picTitle.Hide()

        picscroll.Show()
        picBack.Show()
        lblControls1.Show()
        lblControls2.Show()
        lblControls3.Show()
        lblControls4.Show()
        lblControls5.Show()
        lblControls6.Show()
        lblControls7.Show()
        lblAbout.Show()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        picExit.Show()
        picPlay.Show()
        picHowto.Show()
        picTitle.Show()

        picscroll.Hide()
        picBack.Hide()
        lblControls1.Hide()
        lblControls2.Hide()
        lblControls3.Hide()
        lblControls4.Hide()
        lblControls5.Hide()
        lblControls6.Hide()
        lblControls7.Hide()
        lblAbout.Hide()
    End Sub

    Private Sub picHowto_MouseLeave(sender As Object, e As EventArgs) Handles picHowto.MouseLeave
        picArrow2.Hide()
    End Sub

    Private Sub picExit_MouseLeave(sender As Object, e As EventArgs) Handles picExit.MouseLeave
        picArrow3.Hide()
    End Sub

    Private Sub picPlay_MouseLeave(sender As Object, e As EventArgs) Handles picPlay.MouseLeave
        picArrow1.Hide()
    End Sub
End Class