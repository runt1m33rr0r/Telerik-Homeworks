using System;
using System.Numerics;

class BinToDec
{
    static void Main()
    {
        string inputNums = Console.ReadLine();
        char[] binVals = inputNums.ToCharArray();

        Array.Reverse(binVals);

        BigInteger decNumber = 0;
        int power = 0;

        foreach (var val in binVals)
        {
            if (val == '1')
            {
                decNumber += BigInteger.Pow(2, power);
            }

            power += 1;
        }

        Console.WriteLine(decNumber);
    }
}