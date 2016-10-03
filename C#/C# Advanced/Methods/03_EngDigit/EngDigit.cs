using System;

class EngDigit
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine(GetDigit(input));
    }

    static string GetDigit(int someInt)
    {
        int lastDigit = someInt % 10;

        switch (lastDigit)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            default: return "nine";
        }
    }
}