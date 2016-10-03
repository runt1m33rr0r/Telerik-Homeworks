using System;
using System.Collections.Generic;

class DecToBin
{
    static void Main()
    {
        long inputNum = long.Parse(Console.ReadLine());
        List<int> binList = new List<int>();

        while (inputNum >= 1)
        {
            if (inputNum % 2 == 0)
            {
                binList.Add(0);
            }
            else
            {
                binList.Add(1);
            }

            inputNum /= 2;
        }

        binList.Reverse();

        foreach (var bit in binList)
        {
            Console.Write(bit);
        }

        Console.WriteLine();
    }
}