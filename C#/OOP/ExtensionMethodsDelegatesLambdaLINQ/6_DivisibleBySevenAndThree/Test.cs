namespace _6_DivisibleBySevenAndThree
{
    using System;
    using System.Linq;

    public static class Test
    {
        private static void Main()
        {
            long[] numbers = new long[] { 4645, 21, 42, 87, 56 };

            Console.WriteLine("Lambda:");
            long[] lambdaNumbers = numbers.FindDivisibleUsingLambda(3, 7).ToArray();
            Console.WriteLine(string.Join(", ", lambdaNumbers));

            Console.WriteLine();

            Console.WriteLine("LINQ:");
            long[] linqNumbers = numbers.FindDivisibleUsingLinq(3, 7).ToArray();
            Console.WriteLine(string.Join(", ", linqNumbers));
        }
    }
}
