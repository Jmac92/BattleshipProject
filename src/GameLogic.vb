''' <summary>
''' The Game Logic provides calls to load & free 
''' the game's resources, draw and update the game,
''' as well as managing the game window itself.
''' </summary>

Module GameLogic
    Public Sub Main()
        'Opens a new Graphics Window
        SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600)

        'Load Resources
        LoadResources()

        'Play Music
        SwinGame.PlayMusic(GameMusic("Background"))

        'Game Loop
        Do
            HandleUserInput()
            DrawScreen()
        Loop Until SwinGame.WindowCloseRequested() = True Or CurrentState = GameState.Quitting

        'Stop Music
        SwinGame.StopMusic()

        'Free Resources and Close Audio, to end the program.
        FreeResources()
    End Sub
End Module
