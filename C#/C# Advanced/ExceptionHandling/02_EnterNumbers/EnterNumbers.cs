using System;

class EnterNumbers
{
    static void Main()
    {
        int[] nums = new int[12];
        nums[0] = 1;
        nums[11] = 100;

        try
        {
            for (int i = 1; i < nums.Length - 1; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());

                if (nums[i] <= nums[i - 1] || nums[i] <= nums[0] || nums[i] >= nums[11])
                {
                    throw new FormatException();
                }
            }

            Console.WriteLine(string.Join(" < ", nums));
        }
        catch (FormatException)
        {
            Console.WriteLine("Exception");
        }
    }
}