/* 
   Write a program that reads a number N and prints on the console the first N members of the Fibonacci 
   sequence (at a single line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 
   89, 144, 233, ….
*/

using System;
using System.Collections.Generic;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        List<BigInteger> sequence = new List<BigInteger>();
        sequence.Add(0);
        sequence.Add(1);

        if (number == 1 || number == 0)
        {
            Console.WriteLine(0);
            return;
        }

        for (BigInteger i = 1; i < number - 1; i++)
        {
            sequence.Add(sequence[(int)i] + sequence[(int)i - 1]);
        }

        foreach (var item in sequence)
        {
            if (item == sequence[0])
            {
                Console.Write(item);
            }
            else
            {
                Console.Write(", " + item);
            }
        }
    }
}