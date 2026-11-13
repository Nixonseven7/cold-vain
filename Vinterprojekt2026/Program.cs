using System.Net;
using Raylib_cs;
using System.Numerics;
using System.Data;


bool isColliding;

Player player = new();


// start of the game
Main();





void Main()
{

    Raylib.InitWindow(960, 540, "Cold Vain");
    Raylib.SetTargetFPS(60);
    while (!Raylib.WindowShouldClose())
    {
        Drawing();
        QL();
        player.Update();
        // Console.WriteLine($"{Raylib.IsCursorHidden()}");

    }
    Raylib.CloseWindow();
}

//metoder

void Drawing()
{

    // ritar
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.DarkGray);
    Raylib.EndDrawing();
}


void QL()
{
    // Hide cursor or show cursor
    if (Raylib.IsCursorHidden() == false)
    {
        if (Raylib.IsKeyPressed(KeyboardKey.One))
        {
            Raylib.HideCursor();
        }
    }
    else if (Raylib.IsCursorHidden() == true)
    {
        if (Raylib.IsKeyPressed(KeyboardKey.One))
        {
            Raylib.ShowCursor();
        }
    }

    // fullscreen
    if (Raylib.IsKeyPressed(KeyboardKey.F))
    {
        Raylib.ToggleFullscreen();
    }

    // Closing window/game
    Raylib.SetExitKey(KeyboardKey.Escape);
    // if (Raylib.IsKeyPressed(KeyboardKey.Escape))
    // {
    //     Raylib.CloseWindow();
    // }
}