using System;
using System.Linq;

class IntSum
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int sum = 0;

        foreach (var item in numbers)
        {
            sum += item;
        }

        Console.WriteLine(sum);
    }
}