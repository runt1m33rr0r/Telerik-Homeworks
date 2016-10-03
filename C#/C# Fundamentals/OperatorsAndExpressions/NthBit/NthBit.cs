/* 
   Write a program that reads from the console two integer numbers P and N and prints on the 
   console the value of P's N-th bit.
*/

using System;

class NthBit
{
    static void Main()
    {
        ulong p = ulong.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());

        if ((n < 55) && (p <= (ulong)Math.Pow(2, 55)))
        {
            Console.WriteLine((p >> n) & 1);
        }
    }
}