/* 
   Write a program that reads 5 integer numbers from the console and prints their sum.
*/

using System;

class SumOfFiveNums
{
    static void Main()
    {
        double sum = 0;

        for (int i = 0; i < 5; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}