using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrSize];

        numbers = Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Console.WriteLine(CountLargerThanNeighbours(numbers));
    }

    static int CountLargerThanNeighbours(int[] arr)
    {
        int count = 0;

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
            {
                count++;
            }
        }

        return count;
    }
}