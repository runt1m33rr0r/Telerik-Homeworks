using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrSize];

        numbers = Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Console.WriteLine(GetIndexOfFirstLargerThanNeighbours(numbers));
    }

    static int GetIndexOfFirstLargerThanNeighbours(int[] arr)
    {
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
            {
                return i;
            }
        }

        return -1;
    }
}