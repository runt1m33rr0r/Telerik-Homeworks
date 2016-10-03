namespace BooleanPrinter
{
    using System;

    internal class Printer
    {
        private const int MaxCount = 6;

        private static void Main()
        {
            var testBoolPrinter = new BoolPrinter();

            testBoolPrinter.Print(true);
        }

        private class BoolPrinter
        {
            internal void Print(bool value)
            {
                Console.WriteLine(value);
            }
        }
    }
}
