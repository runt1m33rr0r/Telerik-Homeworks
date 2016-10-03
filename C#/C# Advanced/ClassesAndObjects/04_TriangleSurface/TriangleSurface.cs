using System;

class TriangleSurface
{
    static void Main()
    {
        double length = double.Parse(Console.ReadLine());
        double altitude = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:F2}", (length*altitude) / 2);
    }
}