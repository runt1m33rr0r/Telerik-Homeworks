namespace CohesionAndCoupling
{
    using System;

    public class Figure
    {
        private const string NonPositiveDouble = "{0} must be a positive number!";
        private const string WidthProperty = "Width";
        private const string HeightProperty = "Height";
        private const string DepthProperty = "Depth";
        private const int Zero = 0;

        private double width;
        private double height;
        private double depth;

        public Figure(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                ValidateIfDoubleIsPositive(value, WidthProperty);

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
                ValidateIfDoubleIsPositive(value, HeightProperty);

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            private set
            {
                ValidateIfDoubleIsPositive(value, DepthProperty);

                this.depth = value;
            }
        }

        private static void ValidateIfDoubleIsPositive(double value, string propertyName)
        {
            if (value <= Zero)
            {
                throw new ArgumentException(string.Format(NonPositiveDouble, propertyName));
            }
        }
    }
}