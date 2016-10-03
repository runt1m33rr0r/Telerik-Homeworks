namespace Methods.Printing
{
    using System;
    using GlobalConstants;

    internal class Printer
    {
        internal static void PrintAsNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine(FormatStrings.FloatFormat, number);
            }

            if (format == "%")
            {
                Console.WriteLine(FormatStrings.PercentageFormat, number);
            }

            if (format == "r")
            {
                Console.WriteLine(FormatStrings.RightAlignment, number);
            }
        }
    }
}
