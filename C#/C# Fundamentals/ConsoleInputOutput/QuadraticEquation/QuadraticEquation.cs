/* 
   Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves 
   it (prints its real roots).
*/

using System;

class QuadEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double D = (b * b) - (4 * a * c);

        if (D < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (D == 0)
        {
            Console.WriteLine("{0:F2}", -b / (2 * a));
        }
        else
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);

            if (x1 < x2)
            {
                Console.WriteLine("{0:F2}", x1);
                Console.WriteLine("{0:F2}", x2);
            }
            else
            {
                Console.WriteLine("{0:F2}", x2);
                Console.WriteLine("{0:F2}", x1);
            }
        }
    }
}