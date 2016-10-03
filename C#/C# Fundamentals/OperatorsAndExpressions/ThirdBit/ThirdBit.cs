/* 
   Using bitwise operators, write a program that uses an expression to find the value of the bit 
   at index 3 of an unsigned integer read from the console.

   The bits are counted from right to left, starting from bit 0.
   The result of the expression should be either 1 or 0. Print it on the console.
*/

using System;

class ThirdBit
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        Console.WriteLine((number & (1 << 3)) >> 3);
    }
}