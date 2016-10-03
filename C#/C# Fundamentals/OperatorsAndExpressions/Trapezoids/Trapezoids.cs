/* 
   Write an expression that calculates trapezoid's area by given sides a and b and height h. 
   The three values should be read from the console in the order shown below. All three 
   value will be floating-point numbers.
*/

using System;

class Trapezoids
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:F7}", ((a + b) * h) / 2);
    }
}