using System;
using System.Collections.Generic;
using System.Numerics;

class HexToDec
{
    static void Main()
    {
        List<char> inputHex = new List<char>(Console.ReadLine().ToCharArray());
        BigInteger result = 0;

        inputHex.Reverse();

        int power = 0;

        foreach (char item in inputHex)
        {
            if (item == 'A')
            {
                result += 10 * BigInteger.Pow(16, power);
            }
            else if (item == 'B')
            {
                result += 11 * BigInteger.Pow(16, power);
            }
            else if (item == 'C')
            {
                result += 12 * BigInteger.Pow(16, power);
            }
            else if (item == 'D')
            {
                result += 13 * BigInteger.Pow(16, power);
            }
            else if (item == 'E')
            {
                result += 14 * BigInteger.Pow(16, power);
            }
            else if (item == 'F')
            {
                result += 15 * BigInteger.Pow(16, power);
            }
            else if (char.IsDigit(item))
            {
                result += int.Parse(item.ToString()) * BigInteger.Pow(16, power);
            }

            power += 1;
        }

        Console.WriteLine(result);
    }
}