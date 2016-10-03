namespace Abstraction
{
    using Common;
    using Interfaces;

    public class Rectangle : Figure, IRectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                Validator.ValidateIfDoubleIsPositive(value, "The width");

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                Validator.ValidateIfDoubleIsPositive(value, "The height");

                this.height = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = (this.Width + this.Height) * 2;

            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;

            return surface;
        }
    }
}
