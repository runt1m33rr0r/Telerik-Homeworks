using System;

class BinShort
{
    static void Main(string[] args)
    {
        int decValue = int.Parse(Console.ReadLine());
        string result = string.Empty;
        if (decValue < 0)
        {
            result += "1";
            int temp = decValue + 1;
            result += DecimaToAnything(short.MaxValue + temp, 2).PadLeft(15, '0');
        }
        else
        {
            result += "0";
            result += DecimaToAnything(decValue, 2).PadLeft(15, '0');
        }
        Console.WriteLine(result);
    }

    static string DecimaToAnything(int decValue, int baseValue)
    {
        string result = "";

        do
        {
            int reminder = decValue % baseValue;
            result = reminder + result;
            decValue /= baseValue;
        } while (decValue > 0);
        return result;
    }
}