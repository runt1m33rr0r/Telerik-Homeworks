namespace _01_Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        protected double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width can not be less or equal than zero!");
                }

                this.width = value;
            }
        }

        protected double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The height can not be less or equal than zero!");
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
