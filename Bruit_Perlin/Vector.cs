using System;

public class Vector3
{
    public Point point { get; private set; }

    public Vector3(double x, double y, double z)
    {
        point = new Point(x, y, z);
    }


    public Vector3 Aléatoire()
    {

    }
}

public class Vector2
{
    public Point point { get; private set; }

    public Vector2(double x, double y)
    {
        point = new Point(x, y);
    }
}

public struct Point
{
    public double X, Y;
    public double Z = 0;
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    public Point(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

}
