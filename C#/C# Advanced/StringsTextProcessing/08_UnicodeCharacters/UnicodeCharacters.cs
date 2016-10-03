using System;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(@"\u{0:X4}", Convert.ToUInt16(input[i]));
        }
    }
}