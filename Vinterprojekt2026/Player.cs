
using System.Numerics;
using System.Runtime.CompilerServices;
using Raylib_cs;

public class Player
{
    private Vector2 Position;

    private float Speed;
    private bool canJump;

    private float velocityY;
    private float gravity = 4f;



    public Player()
    {

    }
    Rectangle Dude = new Rectangle(480, 270, 25, 25);

    public void Update()
    {

        Movement();
        PlayerDraw();

    }

    void Movement()
    {
        velocityY += gravity;

        // velocityY += gravity;

        // På marken IF (en punkt precis under karaktären är i ett mark-block)
        // velocityY = 0;

        // Position.Y += velocityY;

        // Hopp
        // velocityY = -100;
        Dude.Y += velocityY;
        if (Dude.Y > 200)
        {
            velocityY = 0;
            Dude.Y = 200;
        }

        if (Raylib.IsKeyDown(KeyboardKey.A))
        {
            Dude.X -= 5;
        }
        if (Raylib.IsKeyDown(KeyboardKey.W))
        {
            Dude.Y -= 5;
        }
        if (Raylib.IsKeyDown(KeyboardKey.S))
        {
            Dude.Y += 5;
        }
        if (Raylib.IsKeyDown(KeyboardKey.D))
        {
            Dude.X += 5;
        }
        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {

            velocityY = -25;

        }


    }


    public void PlayerDraw()
    {
        Raylib.DrawRectangleRec(Dude, Color.Green);

    }

}
