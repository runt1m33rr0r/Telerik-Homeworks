namespace _01_Shapes
{
    using System;

    public class Square : Shape
    {
        public Square(double width, double height) : base(width, height)
        {
            if (this.Height != this.Width)
            {
                throw new ArgumentException("Height and width of the square can not be different!");
            }
        }

        public override double CalculateSurface()
        {
            return this.Width * 2;
        }
    }
}
