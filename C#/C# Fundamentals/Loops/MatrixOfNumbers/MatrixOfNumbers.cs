using System;

class Matrix
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        for (uint row = 1; row <= number; row++)
        {
            for (uint col = row; col <= row + number - 1; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}