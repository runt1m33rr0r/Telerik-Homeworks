using System;

class CorrectBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input[0] == ')')
        {
            Console.WriteLine("Incorrect");
            return;
        }

        int leftCount = 0;
        int rightCount = 0;

        foreach (var item in input)
        {
            if (item == ')')
            {
                rightCount++;
            }
            else if (item == '(')
            {
                leftCount++;
            }
        }

        if (leftCount == rightCount)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}