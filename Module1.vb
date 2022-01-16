Public Module Module1
    Public loc As Point   'location of player

    Public moving As Boolean = True   'Check to allow movement, true = can move

    Public Chat As Integer = 0    'Integer to check how many text boxes the npc has spoken

    Public frame As Integer      'Integer to check what animation frame the monster is on

    Public ww2 As Bitmap = My.Resources.WW2   'make the ww picture be ww1 and the second frame be ww2
    Public ww1 As Bitmap = My.Resources.WW1
    Public knightright As Bitmap = My.Resources.Knightright

    Public mainsprite As Bitmap = My.Resources.Knight

    Public battle As Point
    Public locbattle As Point

    Public WWgone As Boolean = False

    Public Golemgone As Boolean = False

End Module
