using System;
using System.Collections.Generic;

class FrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        var cnt = new Dictionary<int, int>();
        foreach (int value in numbers)
        {
            if (cnt.ContainsKey(value))
            {
                cnt[value]++;
            }
            else
            {
                cnt.Add(value, 1);
            }
        }

        int mostCommonValue = 0;
        int highestCount = 0;
        foreach (KeyValuePair<int, int> pair in cnt)
        {
            if (pair.Value > highestCount)
            {
                mostCommonValue = pair.Key;
                highestCount = pair.Value;
            }
        }

        Console.WriteLine("{0} ({1} times)", mostCommonValue, highestCount);
    }
}

