using System;
using System.Collections.Generic;

class HexToBin
{
    static void Main()
    {
        List<char> inputHex = new List<char>(Console.ReadLine().ToCharArray());
        List<string> result = new List<string>();

        foreach (char item in inputHex)
        {
            if (item == '0')
            {
                result.Add("0000");
            }
            else if (item == '1')
            {
                result.Add("0001");
            }
            else if (item == '2')
            {
                result.Add("0010");
            }
            else if (item == '3')
            {
                result.Add("0011");
            }
            else if (item == '4')
            {
                result.Add("0100");
            }
            else if (item == '5')
            {
                result.Add("0101");
            }
            else if (item == '6')
            {
                result.Add("0110");
            }
            else if (item == '7')
            {
                result.Add("0111");
            }
            else if (item == '8')
            {
                result.Add("1000");
            }
            else if (item == '9')
            {
                result.Add("1001");
            }
            else if (item == 'A')
            {
                result.Add("1010");
            }
            else if (item == 'B')
            {
                result.Add("1011");
            }
            else if (item == 'C')
            {
                result.Add("1100");
            }
            else if (item == 'D')
            {
                result.Add("1101");
            }
            else if (item == 'E')
            {
                result.Add("1110");
            }
            else if (item == 'F')
            {
                result.Add("1111");
            }
        }

        Console.WriteLine(string.Join("", result).TrimStart('0'));
    }
}