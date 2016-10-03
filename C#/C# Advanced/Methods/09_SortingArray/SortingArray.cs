using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrSize];

        numbers = Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Array.Sort(numbers);

        Console.WriteLine(string.Join(" ", numbers));
    }
}