/* 
   We are given an integer number N (read from the console), a bit value v (read from the console as well) 
   (v = 0 or 1) and a position P (read from the console). Write a sequence of operators (a few lines of C# code) 
   that modifies N to hold the value v at the position P from the binary representation of N while preserving all
   other bits in N. Print the resulting number on the console.
*/

using System;

class BitMod
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        byte bitPos = byte.Parse(Console.ReadLine());
        byte bitVal = byte.Parse(Console.ReadLine());

        if (bitPos >= 0 && bitPos <= 64)
        {
            if (bitVal == 0)
            {
                ulong mask = ~((ulong)1 << bitPos);
                ulong result = number & mask;
                Console.WriteLine(result);
            }
            else if (bitVal == 1)
            {
                ulong mask = ((ulong)1 << bitPos);
                ulong result = number | mask;
                Console.WriteLine(result);
            }
        }
    }
}