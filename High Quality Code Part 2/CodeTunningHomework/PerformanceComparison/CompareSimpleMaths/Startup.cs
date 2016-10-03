namespace CompareSimpleMaths
{
    using System;

    public class Startup
    {
        private const int intValue = 1;
        private const long longValue = 1L;
        private const float floatValue = 1.0F;
        private const double doubleValue = 1.0;
        private const decimal decimalValue = 1.0M;

        public static void Main()
        {
            Console.WriteLine("add: ");
            TestMethods.TestOperation(intValue, Operations.Add);
            TestMethods.TestOperation(longValue, Operations.Add);
            TestMethods.TestOperation(floatValue, Operations.Add);
            TestMethods.TestOperation(doubleValue, Operations.Add);
            TestMethods.TestOperation(decimalValue, Operations.Add);

            Console.WriteLine("\nsubtract: ");
            TestMethods.TestOperation(intValue, Operations.Substaction);
            TestMethods.TestOperation(longValue, Operations.Substaction);
            TestMethods.TestOperation(floatValue, Operations.Substaction);
            TestMethods.TestOperation(doubleValue, Operations.Substaction);
            TestMethods.TestOperation(decimalValue, Operations.Substaction);

            Console.WriteLine("\ndivide: ");
            TestMethods.TestOperation(intValue, Operations.Division);
            TestMethods.TestOperation(longValue, Operations.Division);
            TestMethods.TestOperation(floatValue, Operations.Division);
            TestMethods.TestOperation(doubleValue, Operations.Division);
            TestMethods.TestOperation(decimalValue, Operations.Division);

            Console.WriteLine("\nmultiply: ");
            TestMethods.TestOperation(intValue, Operations.Multiply);
            TestMethods.TestOperation(longValue, Operations.Multiply);
            TestMethods.TestOperation(floatValue, Operations.Multiply);
            TestMethods.TestOperation(doubleValue, Operations.Multiply);
            TestMethods.TestOperation(decimalValue, Operations.Multiply);

            Console.WriteLine("\nincrement: ");
            TestMethods.TestOperation(intValue, Operations.Increment);
            TestMethods.TestOperation(longValue, Operations.Increment);
            TestMethods.TestOperation(floatValue, Operations.Increment);
            TestMethods.TestOperation(doubleValue, Operations.Increment);
            TestMethods.TestOperation(decimalValue, Operations.Increment);
        }
    }
}
