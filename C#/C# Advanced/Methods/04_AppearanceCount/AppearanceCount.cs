using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrSize];

        numbers = Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int numberToSearch = int.Parse(Console.ReadLine());

        Console.WriteLine(CountAppearances(numbers, numberToSearch));
    }

    static int CountAppearances(int[] arr, int numberForSearching)
    {
        int count = 0;

        foreach (var item in arr)
        {
            if (item == numberForSearching)
            {
                count++;
            }
        }

        return count;
    }
}