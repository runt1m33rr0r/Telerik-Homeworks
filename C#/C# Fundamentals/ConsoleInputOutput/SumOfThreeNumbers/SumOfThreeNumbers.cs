/* 
   Write a program that reads 3 real numbers from the console and prints their sum.
*/

using System;

class SumOfNums
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(a + b + c);
    }
}