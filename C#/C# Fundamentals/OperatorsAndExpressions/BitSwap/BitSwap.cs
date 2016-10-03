/* 
   Write a program first reads 3 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1} 
   with bits {q, q+1, …, q+k-1} of n. Print the resulting integer on the console.
*/

using System;

class BitSwap
{
    static void Main()
    {

        uint n = uint.Parse(Console.ReadLine());
        byte p = byte.Parse(Console.ReadLine());
        byte q = byte.Parse(Console.ReadLine());
        byte k = byte.Parse(Console.ReadLine());

        for (int i = 0; i < k; i++)
        {
            uint mask = (uint)1 << p;
            uint bit = (n & mask) >> p;

            mask = (uint)1 << q;
            uint secondBit = (n & mask) >> q;

            if (bit == 0)
            {
                //put 0 in Zth position
                mask = ~((uint)1 << q);
                n = n & mask;
            }
            else if (bit == 1)
            {
                //put 1 in Zth position
                mask = (uint)1 << q;
                n = n | mask;
            }
            if (secondBit == 0)
            {
                //put 0 in Ith position
                mask = ~((uint)1 << p);
                n = n & mask;
            }
            else if (secondBit == 1)
            {
                //put 1 in Ith position
                mask = (uint)1 << p;
                n = n | mask;
            }

            p++;
            q++;
        }

        Console.WriteLine(n);
    }
}