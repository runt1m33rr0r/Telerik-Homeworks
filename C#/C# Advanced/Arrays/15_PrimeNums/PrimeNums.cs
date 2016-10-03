using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class PrimeNums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var primes = Primes(n);

        Console.WriteLine(primes.Max());
    }

    private static IEnumerable<int> Primes(int bound)
    {
        if (bound < 2) yield break;

        yield return 2;

        BitArray notPrime = new BitArray((bound - 1) >> 1);
        int limit = ((int)(Math.Sqrt(bound)) - 1) >> 1;
        for (int i = 0; i < limit; i++)
        {
            if (notPrime[i]) continue;

            int prime = 2 * i + 3;
            yield return prime;

            for (int j = (prime * prime - 2) >> 1; j < notPrime.Count; j += prime)
            {
                notPrime[j] = true;
            }
        }

        for (int i = limit; i < notPrime.Count; i++)
        {
            if (!notPrime[i]) yield return 2 * i + 3;
        }
    }
}
