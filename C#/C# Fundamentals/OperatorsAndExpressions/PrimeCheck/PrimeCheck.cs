/* 
   Write a program that reads an integer N (which will always be less than 100 or equal) and uses 
   an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).

   Note: You should check if the number is positive
*/

using System;

class PrimeCheck
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        int i;
        for (i = 2; i <= number - 1; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine("false");
                return;
            }
        }
        if (i == number)
        {
            Console.WriteLine("true");
            return;
        }

        Console.WriteLine("false");
    }
}