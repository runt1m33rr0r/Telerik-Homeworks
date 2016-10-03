using System;
using System.Linq;
using System.Numerics;

class IntCalculations
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Console.WriteLine(Min(numbers));
        Console.WriteLine(Max(numbers));
        Console.WriteLine("{0:F2}", Average(numbers));
        Console.WriteLine(Sum(numbers));
        Console.WriteLine(Product(numbers));
    }

    static BigInteger Min(int[] arr)
    {
        BigInteger smallest = long.MaxValue;

        foreach (var item in arr)
        {
            if (item < smallest)
            {
                smallest = item;
            }
        }

        return smallest;
    }

    static BigInteger Max(int[] arr)
    {
        BigInteger biggest = long.MinValue;

        foreach (var item in arr)
        {
            if (item > biggest)
            {
                biggest = item;
            }
        }

        return biggest;
    }

    static decimal Average(int[] arr)
    {
        decimal result;

        result = (decimal)Sum(arr) / arr.Length;

        return result;
    }

    static BigInteger Sum(int[] arr)
    {
        BigInteger sum = 0;

        foreach (var item in arr)
        {
            sum += item;
        }

        return sum;
    }

    static BigInteger Product(int[] arr)
    {
        BigInteger result = 1;

        foreach (var item in arr)
        {
            result *= item;
        }

        return result;
    }
}