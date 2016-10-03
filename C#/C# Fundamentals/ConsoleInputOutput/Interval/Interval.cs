/* 
   Write a program that reads two positive integer numbers N and M and prints how many numbers 
   exist between them such that the reminder of the division by 5 is 0.
*/

using System;

class Interval
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        int count = 0;

        if (firstNum != secondNum)
        {
            for (int i = firstNum + 1; i <= secondNum - 1; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}