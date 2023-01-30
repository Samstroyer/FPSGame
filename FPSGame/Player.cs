using System.Numerics;
using Raylib_cs;

public class Player
{
    public Camera3D camera = new(new(0, 2, 0), new(0, 1, 0), new(0, 1, 0), 70f, CameraProjection.CAMERA_PERSPECTIVE);
    public Vector3 Position
    {
        get
        {
            return camera.position;
        }
        set
        {
            camera.position = value;
        }
    }

    public List<Bullet> bullets = new();

    public Player()
    {
        Raylib.SetCameraMode(camera, CameraMode.CAMERA_FIRST_PERSON);
    }

    public void Shoot()
    {
        bullets.Add(new(Position, camera.target));
    }
}
