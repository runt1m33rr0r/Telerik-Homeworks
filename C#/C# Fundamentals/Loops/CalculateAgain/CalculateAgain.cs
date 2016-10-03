// Write a program that calculates N! / K! for given N and K.

using System;
using System.Numerics;

class CalculteAgain
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        BigInteger nFact = 1;
        BigInteger kFact = 1;

        BigInteger nCounter = 1;
        BigInteger kCounter = 1;

        while (nCounter <= n || kCounter <= k)
        {
            if (nCounter <= n)
            {
                nFact *= nCounter;
                nCounter++;
            }
            if (kCounter <= k)
            {
                kFact *= kCounter;
                kCounter++;
            }
        }

        Console.WriteLine("{0}", nFact / kFact);
    }
}