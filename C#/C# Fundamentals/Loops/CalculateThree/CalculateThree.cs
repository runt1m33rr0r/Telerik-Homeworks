using System;
using System.Numerics;

class CalculteThree
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

        BigInteger nkFact = 1;

        for (int i = 1; i <= n - k; i++)
        {
            nkFact *= i;
        }

        Console.WriteLine("{0}", nFact / (kFact * nkFact));
    }
}