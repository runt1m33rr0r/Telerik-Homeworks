using System;

class ReverseNumber
{
    static void Main()
    {
        decimal input = decimal.Parse(Console.ReadLine());

        Console.WriteLine(GetReversed(input));
    }

    static string GetReversed(decimal num)
    {
        string number = num.ToString();
        char[] charArray = number.ToCharArray();

        Array.Reverse(charArray);

        return new string(charArray);
    }
}