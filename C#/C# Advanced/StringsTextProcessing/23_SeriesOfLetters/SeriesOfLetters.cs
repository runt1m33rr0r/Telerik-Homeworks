using System;
using System.Collections.Generic;

class SeriesOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<char> result = new List<char>();
        result.Add(input[0]);

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] != input[i + 1])
            {
                result.Add(input[i + 1]);
            }
        }

        Console.WriteLine(string.Join("", result));
    }
}