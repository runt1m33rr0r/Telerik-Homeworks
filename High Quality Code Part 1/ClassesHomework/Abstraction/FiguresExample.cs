namespace Abstraction
{
    using System;
    using Interfaces;

    public class FiguresExample
    {
        private static void Main()
        {
            double circleRadius = 5;
            IFigure circle = new Circle(circleRadius);
            double circlePerimeter = circle.CalculatePerimeter();
            double cirleSurface = circle.CalculateSurface();

            double someRectangleWidth = 2;
            double someRectangleHeight = 3;
            IFigure someRectangle = new Rectangle(someRectangleWidth, someRectangleHeight);
            double someRectanglePerimeter = someRectangle.CalculatePerimeter();
            double someRectangleSurface = someRectangle.CalculateSurface();

            Console.WriteLine(
                "I am a circle. My perimeter is {0:f2}. My surface is {1:f2}.",
                circlePerimeter, 
                cirleSurface);
            
            Console.WriteLine(
                "I am a rectangle. My perimeter is {0:f2}. My surface is {1:f2}.",
                someRectanglePerimeter,
                someRectangleSurface);
        }
    }
}
