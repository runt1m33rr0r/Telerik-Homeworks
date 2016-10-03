using System;

class TriangleSurfaceBySides
{
    static void Main()
    {
        double firstSide = double.Parse(Console.ReadLine());
        double secondSide = double.Parse(Console.ReadLine());
        double thirdSide = double.Parse(Console.ReadLine());

        double P = (firstSide + secondSide + thirdSide) / 2;
        double area = Math.Sqrt(P * (P - firstSide) * (P - secondSide) * (P - thirdSide));

        Console.WriteLine("{0:F2}", area);
    }
}