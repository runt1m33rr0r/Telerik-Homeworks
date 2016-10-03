/* 
   Write an expression that calculates rectangle’s area and perimeter by given width and height. 
   The width and height should be read from the console.
*/

using System;

class Rectangle
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = (2 * width) + (2 * height);
        double perimeter = width * height;

        Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
    }
}