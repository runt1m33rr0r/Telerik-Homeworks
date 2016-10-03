/* 
   Write a program that reads a pair of coordinates x and y and uses an expression to 
   checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the 
   rectangle R(top=1, left=-1, width=6, height=2).
*/

using System;

class CircleRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double dist = Math.Sqrt((1 - x) * (1 - x) + (1 - y) * (1 - y));
        string ptCircle = dist <= 1.5 ? "inside" : "outside";

        string ptRect = (x >= -1 && x <= 5) && (y >= -1 && y <= 1) ? "inside" : "outside";

        Console.WriteLine("{0} circle {1} rectangle", ptCircle, ptRect);
    }
}