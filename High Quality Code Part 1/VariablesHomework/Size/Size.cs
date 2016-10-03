namespace Size
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double sizeWidth, double sizeHeight)
        {
            this.Width = sizeWidth;
            this.Height = sizeHeight;
        }

        internal double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                this.width = value;
            }
        }

        internal double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                this.height = value;
            }
        } 

        public static Size GetRotatedSize(Size someSize, double rotationAngle)
        {
            double absoluteSinRotation = Math.Abs(Math.Sin(rotationAngle));
            double absoluteCosRotation = Math.Abs(Math.Cos(rotationAngle));

            double firstRotatedWidth = absoluteCosRotation * someSize.Width;
            double secondRotatedWidth = absoluteSinRotation * someSize.Width;

            double firstRotatedHeight = absoluteSinRotation * someSize.Height;
            double secondRotatedHeight = absoluteCosRotation * someSize.Height;

            double widthResult = firstRotatedWidth + firstRotatedHeight;
            double heightResult = secondRotatedWidth + secondRotatedHeight;

            Size resultSize = new Size(widthResult, heightResult);

            return resultSize;
        }
    }
}
