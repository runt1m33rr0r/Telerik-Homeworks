using System;

static class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);
        Array.Reverse(numbers);

        int sum = 0;
        for (int i = 0; i < k; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine(sum);
    }
}

