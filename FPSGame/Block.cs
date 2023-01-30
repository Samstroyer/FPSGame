using System.Numerics;
using Raylib_cs;

public class Block : Targetable
{
    Vector3 size;

    public Block()
    {
        position = new(1, 0, 1);
        size = new(1, 1, 1);
    }

    public void Draw()
    {
        Raylib.DrawCube(position, size.X, size.Y, size.Z, Color.GREEN);
    }

    //Check collision 
}
