using System;

class OddEvenProduct
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        string[] inputNums = Console.ReadLine().Split();

        long oddProduct = 1;
        long evenProduct = 1;

        for (long i = 0; i < inputNums.Length; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                evenProduct *= long.Parse(inputNums[i]);
            }
            else if ((i + 1) % 2 != 0)
            {
                oddProduct *= long.Parse(inputNums[i]);
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }
    }
}