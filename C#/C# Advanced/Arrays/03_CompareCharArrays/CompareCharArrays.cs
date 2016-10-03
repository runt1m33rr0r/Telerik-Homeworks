using System;

class CompareCharArrays
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        if (string.CompareOrdinal(firstInput, secondInput) < 0)
        {
            Console.WriteLine("<");
        }
        else if (string.CompareOrdinal(firstInput, secondInput) > 0)
        {
            Console.WriteLine(">");
        }
        else
        {
            Console.WriteLine("=");
        }
    }
}

