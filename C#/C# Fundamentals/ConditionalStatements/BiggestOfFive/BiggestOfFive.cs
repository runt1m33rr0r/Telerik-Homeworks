using System;
using System.Linq;

class Biggest
{
    static void Main()
    {
        double[] numbers = new double[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine(numbers.Max());
    }
}