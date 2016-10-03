namespace CompareAdvancedMaths
{
    using System;

    public class Startup
    {
        private const float floatValue = 100.0f;
        private const double doubleValue = 100.0;
        private const decimal decimalValue = 100.0M;

        public static void Main()
        {
            Console.WriteLine("square root: ");
            TestMethods.TestOperation(floatValue, Operations.Sqrt);
            TestMethods.TestOperation(doubleValue, Operations.Sqrt);
            TestMethods.TestOperation(decimalValue, Operations.Sqrt);

            Console.WriteLine("\nnatural logarithm: ");
            TestMethods.TestOperation(floatValue, Operations.Log);
            TestMethods.TestOperation(doubleValue, Operations.Log);
            TestMethods.TestOperation(decimalValue, Operations.Log);

            Console.WriteLine("\nsinus: ");
            TestMethods.TestOperation(floatValue, Operations.Sin);
            TestMethods.TestOperation(doubleValue, Operations.Sin);
            TestMethods.TestOperation(decimalValue, Operations.Sin);
        }
    }
}
