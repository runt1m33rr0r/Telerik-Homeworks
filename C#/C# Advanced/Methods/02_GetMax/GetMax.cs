using System;
using System.Linq;

class GetMax
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] {' '}, 
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int largestFirstAndSecond = GetMaxNum(numbers[0], numbers[1]);

        Console.WriteLine(GetMaxNum(largestFirstAndSecond, numbers[2]));
    }

    static int GetMaxNum(int first, int second)
    {
        if (first > second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }
}