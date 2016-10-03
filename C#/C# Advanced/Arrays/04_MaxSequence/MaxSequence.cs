using System;

class MaxSequence
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());

        ulong[] numbers = new ulong[n];

        for (ulong i = 0; i < (ulong)numbers.Length; i++)
        {
            numbers[i] = ulong.Parse(Console.ReadLine());
        }

        ulong previousSequence = 1;
        ulong currentSequence = 1;

        for (ulong i = 0; i < (ulong)numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                currentSequence++;
            }
            else
            {
                currentSequence = 1;
            }
            if (previousSequence <= currentSequence)
            {
                previousSequence = currentSequence;
            }
        }
        Console.WriteLine(previousSequence);
    }
}

