using System;
using System.Linq;

class Polynomials
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] firstArrayOfNumbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
        int[] secondArrayOfNumbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
        var resultArray = AddPolynomials(firstArrayOfNumbers, secondArrayOfNumbers, length);

        Console.WriteLine(String.Join(" ", resultArray));
    }

    public static int[] AddPolynomials(int[] firstArray, int[] secondArray, int length)
    {
        int[] resultArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            resultArray[i] = firstArray[i] + secondArray[i];
        }
        return resultArray;
    }
}