/* 
   Write a program that reads from the console the radius r of a circle and prints its perimeter and area, 
   rounded and formatted with 2 digits after the decimal point.
*/

using System;

class Circle
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:F2} {1:F2}", 2 * Math.PI * r, Math.PI * r * r);
    }
}