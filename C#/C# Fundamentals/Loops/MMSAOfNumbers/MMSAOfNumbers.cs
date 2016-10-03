using System;
using System.Collections.Generic;
using System.Linq;

class MMSA
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        List<double> inputNumbers = new List<double>();

        for (uint i = 1; i <= number; i++)
        {
            inputNumbers.Add(double.Parse(Console.ReadLine()));
        }

        Console.WriteLine("min={0:F2}", inputNumbers.Min());
        Console.WriteLine("max={0:F2}", inputNumbers.Max());
        Console.WriteLine("sum={0:F2}", inputNumbers.Sum());
        Console.WriteLine("avg={0:F2}", inputNumbers.Average());
    }
}