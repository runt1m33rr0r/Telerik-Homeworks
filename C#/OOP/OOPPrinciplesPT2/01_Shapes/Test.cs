namespace _01_Shapes
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Shape[] shapes =
            {
                new Square(5, 5),
                new Triangle(4.4, 5),
                new Rectangle(6, 3.3)
            };

            foreach (var figure in shapes)
            {
                Console.WriteLine("{0} surface = {1}", figure.GetType().Name, figure.CalculateSurface());
            }
        }
    }
}
