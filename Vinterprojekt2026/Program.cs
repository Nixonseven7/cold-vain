using System.Net;
using Raylib_cs;
using System.Numerics;


Raylib.InitWindow(960, 540, "Cold Vain");
Raylib.SetTargetFPS(60);
while (!Raylib.WindowShouldClose())
{
    BeginDraw();
    QL();
    Raylib.EndDrawing();
    // Console.WriteLine($"{Raylib.IsCursorHidden()}");

}
Raylib.CloseWindow();






void BeginDraw()
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.DarkGray);
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

    // Closing window
    if (Raylib.IsKeyPressed(KeyboardKey.Escape))
    {
        Raylib.CloseWindow();
    }
}