// Write a program that, for a given two integer numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.

using System;

class Calculte
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double sum = 1;
        double fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            sum += fact / Math.Pow(x, i);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}