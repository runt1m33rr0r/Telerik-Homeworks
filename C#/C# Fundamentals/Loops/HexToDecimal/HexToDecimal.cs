using System;
using System.Collections.Generic;

class HexToDec
{
    static void Main()
    {
        List<char> inputHex = new List<char>(Console.ReadLine().ToCharArray());
        double result = 0;

        inputHex.Reverse();

        double power = 0;

        foreach (char item in inputHex)
        {
            if (item == 'A')
            {
                result += 10 * Math.Pow(16.0, power);
            }
            else if (item == 'B')
            {
                result += 11 * Math.Pow(16.0, power);
            }
            else if (item == 'C')
            {
                result += 12 * Math.Pow(16.0, power);
            }
            else if (item == 'D')
            {
                result += 13 * Math.Pow(16.0, power);
            }
            else if (item == 'E')
            {
                result += 14 * Math.Pow(16.0, power);
            }
            else if (item == 'F')
            {
                result += 15 * Math.Pow(16.0, power);
            }
            else if (char.IsDigit(item))
            {
                result += int.Parse(item.ToString()) * Math.Pow(16.0, power);
            }

            power += 1;
        }

        Console.WriteLine(result);
    }
}