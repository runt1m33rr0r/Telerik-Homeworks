using System;

class NotDivisible
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        for (uint i = 1; i <= number; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}