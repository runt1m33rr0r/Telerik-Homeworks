using System;

class OneToN
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        for (uint i = 1; i <= number; i++)
        {
            Console.Write(i + " ");
        }
    }
}