namespace MobilePhones
{
    using System;
    using System.Text;

    class Display
    {
        private double? size;
        private int? numberOfColors;

        public Display(double? displaySize = null)
        {
            DisplaySize = displaySize;
        }

        public Display(double? displaySize, int? displayNumberOfColors = null) : this(displaySize)
        {
            DisplayColorNumber = displayNumberOfColors;
        }

        public double? DisplaySize
        {
            get
            {
                return size;
            }
            private set
            {
                if (value > 0 || value == null)
                {
                    size = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The display size must fit in double and be a positive number!");
                }
            }
        }
        public int? DisplayColorNumber
        {
            get
            {
                return numberOfColors;
            }
            private set
            {
                if (value > 0 || value == null)
                {
                    numberOfColors = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The number of colors of the display must fit in int32 and be a positive number!");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (size != null)
            {
                result.Append(string.Format("\nDisplay size: {0}\n", size));
            }
            else
            {
                result.Append(string.Format("Display size: unknown\n"));
            }

            if (numberOfColors != null)
            {
                result.Append(string.Format("Display number of colors: {0}", numberOfColors));
            }
            else
            {
                result.Append(string.Format("Display number of colors: unknown"));
            }

            return result.ToString();
        }
    }
}
