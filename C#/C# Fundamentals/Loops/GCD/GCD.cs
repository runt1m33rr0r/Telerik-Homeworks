using System;

class GCD
{
    static void Main()
    {
        string[] strNums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] nums = new int[2];

        for (int i = 0; i < strNums.Length; i++)
        {
            nums[i] = int.Parse(strNums[i]);
        }

        Console.WriteLine(gcd(nums[0], nums[1]));
    }

    static int gcd(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return gcd(b, a % b);
        }
    }
}