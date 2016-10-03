/* 
    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
*/

using System;

class Sign
{
    static void Main()
    {
        double[] numbers = new double[3];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }

        int minusCount = 0;

        foreach (var num in numbers)
        {
            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }
            else if (num < 0)
            {
                minusCount++;
            }
        }

        if (minusCount == 1 || minusCount == 3)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("+");
        }
    }
}