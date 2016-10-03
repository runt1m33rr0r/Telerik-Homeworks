/* 
   Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.
*/

using System;

class SumOfNums
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 1; i <= number; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}