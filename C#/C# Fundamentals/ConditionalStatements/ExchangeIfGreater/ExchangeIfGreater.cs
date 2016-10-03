/* 
   Write a program that reads two double values from the console A and B, stores them in 
   variables and exchanges their values if the first one is greater than the second one. 
   Use an if-statement. As a result print the values of the variables A and B, separated by a space.
*/

using System;

class Exchange
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());

        if (firstNum > secondNum)
        {
            double temp = firstNum;

            firstNum = secondNum;
            secondNum = temp;
        }

        Console.WriteLine("{0} {1}", firstNum, secondNum);
    }
}