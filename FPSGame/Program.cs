using Raylib_cs;

Console.WriteLine("Hello, World!");

Engine e = new();

Setup();
Draw();

void Setup()
{
    Raylib.InitWindow(1000, 800, "Shooter");
    Raylib.SetTargetFPS(144);
}

void Draw()
{
    e.Start();
}