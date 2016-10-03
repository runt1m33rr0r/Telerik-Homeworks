using System;

class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int x = int.Parse(Console.ReadLine());

        Console.WriteLine(BinSearch(numbers, x));
    }

    static int BinSearch(int[] list, int item)
    {
        int first = 0;
        int last = list.Length - 1;
        int index = -1;

        while (first <= last)
        {
            int midpoint = (first + last) / 2;

            if (list[midpoint] == item)
            {
                return midpoint;
            }
            else
            {
                if (item < list[midpoint])
                {
                    last = midpoint - 1;
                }
                else
                {
                    first = midpoint + 1;
                }
            }
        }

        return index;
    }
}

