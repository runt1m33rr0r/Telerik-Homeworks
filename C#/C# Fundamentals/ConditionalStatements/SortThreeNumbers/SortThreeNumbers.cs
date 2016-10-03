using System;

class SortNums
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        int biggest = 0;
        int smallest = 0;
        int middle = 0;

        if (firstNum == secondNum && firstNum == thirdNum)
        {
            biggest = firstNum;
            middle = firstNum;
            smallest = firstNum;
        }
        else if (firstNum == secondNum && firstNum != thirdNum)
        {
            if (thirdNum > firstNum)
            {
                biggest = thirdNum;
                middle = firstNum;
                smallest = firstNum;
            }
            else
            {
                biggest = firstNum;
                middle = firstNum;
                smallest = thirdNum;
            }
        }
        else if (firstNum != secondNum && firstNum == thirdNum)
        {
            if (firstNum > secondNum)
            {
                biggest = firstNum;
                middle = firstNum;
                smallest = secondNum;
            }
            else
            {
                biggest = secondNum;
                middle = firstNum;
                smallest = firstNum;
            }
        }
        else if (firstNum > secondNum && firstNum > thirdNum)
        {
            biggest = firstNum;

            if (secondNum > thirdNum)
            {
                middle = secondNum;
                smallest = thirdNum;
            }
            else if (thirdNum > secondNum)
            {
                middle = thirdNum;
                smallest = secondNum;
            }
        }
        else if (secondNum > firstNum && secondNum > thirdNum)
        {
            biggest = secondNum;

            if (firstNum > thirdNum)
            {
                middle = firstNum;
                smallest = thirdNum;
            }
            else if (thirdNum > firstNum)
            {
                middle = thirdNum;
                smallest = firstNum;
            }
        }
        else if (thirdNum > firstNum && thirdNum > secondNum)
        {
            biggest = thirdNum;

            if (secondNum > firstNum)
            {
                middle = secondNum;
                smallest = firstNum;
            }
            else if (firstNum > secondNum)
            {
                middle = firstNum;
                smallest = secondNum;
            }
        }

        Console.WriteLine("{0} {1} {2}", biggest, middle, smallest);
    }
}