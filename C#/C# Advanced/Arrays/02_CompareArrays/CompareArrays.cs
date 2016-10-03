using System;

class CompareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] firstArr = new int[n];
        int[] secondArr = new int[n];

        for (int i = 0; i < firstArr.Length; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < secondArr.Length; i++)
        {
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < firstArr.Length; i++)
        {
            if (firstArr[i] != secondArr[i])
            {
                Console.WriteLine("Not equal");
                return;
            }
        }
        Console.WriteLine("Equal");
    }
}

