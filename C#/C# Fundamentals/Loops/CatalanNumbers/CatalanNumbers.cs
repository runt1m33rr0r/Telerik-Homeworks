using System;
using System.Numerics;

class Catalan
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger nFact = 1;

        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
        }

        BigInteger twoNFact = 1;

        for (int i = 1; i <= 2 * n; i++)
        {
            twoNFact *= i;
        }

        BigInteger nPlusOneFact = 1;

        for (int i = 1; i <= n + 1; i++)
        {
            nPlusOneFact *= i;
        }

        Console.WriteLine("{0}", twoNFact / (nPlusOneFact * nFact));
    }
}