using System;
using System.Collections.Generic;

class DecToHex
{
    static void Main()
    {
        long inputNum = long.Parse(Console.ReadLine());
        List<string> hexList = new List<string>();

        for (long i = inputNum; i > 0; i /= 16)
        {
            long remainder = i % 16;

            if (remainder >= 0 && remainder <= 9)
            {
                hexList.Add(remainder.ToString());
            }
            else if (remainder == 10)
            {
                hexList.Add("A");
            }
            else if (remainder == 11)
            {
                hexList.Add("B");
            }
            else if (remainder == 12)
            {
                hexList.Add("C");
            }
            else if (remainder == 13)
            {
                hexList.Add("D");
            }
            else if (remainder == 14)
            {
                hexList.Add("E");
            }
            else if (remainder == 15)
            {
                hexList.Add("F");
            }
        }

        hexList.Reverse();

        foreach (var item in hexList)
        {
            Console.Write(item);
        }
    }
}