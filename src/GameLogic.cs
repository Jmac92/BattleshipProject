
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
/// <summary>
/// The Game Logic provides calls to load & free 
/// the game's resources, draw and update the game,
/// as well as managing the game window itself.
/// </summary>

static class GameLogic
{
    public static void Main()
    {
        //Opens a new Graphics Window
        SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

        //Load Resources
        LoadResources();

        //Play Music
        SwinGame.PlayMusic(GameMusic("Background"));

        //Game Loop
        do {
            HandleUserInput();
            DrawScreen();
        } while (!(SwinGame.WindowCloseRequested() == true | CurrentState == GameState.Quitting));

        //Stop Music
        SwinGame.StopMusic();

        //Free Resources and Close Audio, to end the program.
        FreeResources();
    }
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
