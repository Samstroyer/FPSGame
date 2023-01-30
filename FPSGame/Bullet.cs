using System.Numerics;
using Raylib_cs;

public class Bullet
{
    Vector3 position, heading;
    float speed = 0.01f;

    public Bullet(Vector3 position_, Vector3 heading_)
    {
        position = position_ - new Vector3(0, 0.5f, 0);
        heading = Vector3.Normalize(heading_);
    }

    public void Draw()
    {
        Raylib.DrawPoint3D(position, Color.PURPLE);

        position += heading * speed;
    }
}
