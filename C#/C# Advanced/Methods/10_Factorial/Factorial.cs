using System;
using System.Numerics;

class Factorial
{
    static void Main(string[] args)
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger fact = 1;

        for (BigInteger i = 1; i <= n; i++)
        {
            fact *= i;
        }

        Console.WriteLine(fact);
    }
}