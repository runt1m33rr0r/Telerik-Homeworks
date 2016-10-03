using System;

class BinaryToDec
{
    static void Main()
    {
        string inputNums = Console.ReadLine();
        char[] binVals = inputNums.ToCharArray();

        Array.Reverse(binVals);

        double decNumber = 0;
        double power = 0;

        foreach (var val in binVals)
        {
            if (val == '1')
            {
                decNumber += Math.Pow(2, power);
            }

            power += 1;
        }

        Console.WriteLine(decNumber);
    }
}