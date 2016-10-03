/* 
   Write a program that gets two numbers from the console and prints the greater of them.
*/

using System;

class NumberComparer
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("{0}", a > b ? a : b);
    }
}