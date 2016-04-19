
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using SwinGameSDK;
using System.Diagnostics;
/// <summary>
/// The Game Logic provides calls to load and free 
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
        GameResources.LoadResources();

        //Play Music
        SwinGame.PlayMusic(GameResources.GameMusic("Background"));

        //Game Loop
        do {
			GameController.HandleUserInput();
			GameController.DrawScreen();
		} while (!(SwinGame.WindowCloseRequested() == true | GameController.CurrentState == GameState.Quitting));

        //Stop Music
        SwinGame.StopMusic();

        //Free Resources and Close Audio, to end the program.
        GameResources.FreeResources();
    }
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================