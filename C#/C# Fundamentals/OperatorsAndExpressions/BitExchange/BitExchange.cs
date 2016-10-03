/* 
   Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned 
   integer(read from the console).
*/

using System;

class BitExchange
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        //--------------------------------------------------
        // 3
        int mask = 1 << 3;
        int thirdBit = (number & mask) >> 3;
        // 24
        mask = 1 << 24;
        int twentyFourthBit = (number & mask) >> 24;
        //--------------------------------------------------

        //--------------------------------------------------
        // 4
        mask = 1 << 4;
        int fourthBit = (number & mask) >> 4;
        // 25
        mask = 1 << 25;
        int twentyFifthBit = (number & mask) >> 25;
        //--------------------------------------------------

        //--------------------------------------------------
        // 5
        mask = 1 << 5;
        int fifthBit = (number & mask) >> 5;
        // 26
        mask = 1 << 26;
        int twentySixthBit = (number & mask) >> 26;
        //--------------------------------------------------

        // 3 - 24
        if (thirdBit == 0)
        {
            //put 0 in 24th position
            mask = ~(1 << 24);
            number = number & mask;
        }
        else if (thirdBit == 1)
        {
            //put 1 in 24th position
            mask = 1 << 24;
            number = number | mask;
        }
        if (twentyFourthBit == 0)
        {
            //put 0 in third position
            mask = ~(1 << 3);
            number = number & mask;
        }
        else if (twentyFourthBit == 1)
        {
            //put 1 in third position
            mask = 1 << 3;
            number = number | mask;
        }
        // 3 - 24

        // 4 - 25
        if (fourthBit == 0)
        {
            //put 0 in 25th position
            mask = ~(1 << 25);
            number = number & mask;
        }
        else if (fourthBit == 1)
        {
            //put 1 in 25th position
            mask = 1 << 25;
            number = number | mask;
        }
        if (twentyFifthBit == 0)
        {
            //put 0 in 4th position
            mask = ~(1 << 4);
            number = number & mask;
        }
        else if (twentyFourthBit == 1)
        {
            //put 1 in 4th position
            mask = 1 << 4;
            number = number | mask;
        }
        // 4 - 25

        // 5 - 26
        if (fifthBit == 0)
        {
            //put 0 in 26th position
            mask = ~(1 << 26);
            number = number & mask;
        }
        else if (fifthBit == 1)
        {
            //put 1 in 26th position
            mask = 1 << 26;
            number = number | mask;
        }
        if (twentySixthBit == 0)
        {
            //put 0 in 5th position
            mask = ~(1 << 5);
            number = number & mask;
        }
        else if (twentySixthBit == 1)
        {
            //put 1 in 5th position
            mask = 1 << 5;
            number = number | mask;
        }
        // 5 - 26

        Console.WriteLine(number);
    }
}