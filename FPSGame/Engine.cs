using Raylib_cs;

public class Engine
{
    Player p = new();
    Block b = new();

    public void Start()
    {
        while (!Raylib.WindowShouldClose())
        {
            //Begin
            Raylib.BeginDrawing();
            Raylib.BeginMode3D(p.camera);
            Raylib.UpdateCamera(ref p.camera);
            Raylib.ClearBackground(Color.WHITE);



            Raylib.DrawPlane(new(0, 0, 0), new(10, 10), Color.RED);

            Keybinds();

            b.Draw();

            foreach (Bullet b in p.bullets)
            {
                b.Draw();
            }

            //End
            Raylib.EndMode3D();
            Raylib.EndDrawing();
        }
    }

    private void Keybinds()
    {
        KeyboardKey key = (KeyboardKey)Raylib.GetKeyPressed();


        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_RIGHT))
            if (Raylib.IsCursorHidden()) { Raylib.ShowCursor(); Raylib.EnableCursor(); }
            else { Raylib.HideCursor(); Raylib.DisableCursor(); }

        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT)) p.Shoot();
    }
}
