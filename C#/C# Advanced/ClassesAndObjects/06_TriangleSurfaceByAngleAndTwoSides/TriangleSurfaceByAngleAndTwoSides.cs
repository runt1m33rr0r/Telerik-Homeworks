using System;

class TriangleSurfaceByAngleAndTwoSides
{
    static void Main()
    {
        double firstSide = double.Parse(Console.ReadLine());
        double secondSide = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());
        double angleRadians = Math.PI / 180 * angle;

        Console.WriteLine("{0:F2}", ((firstSide * secondSide) / 2) * Math.Sin(angleRadians));
    }
}