using System;
using System.Linq;

class MaxSum
{
    static void Main()
    {
        string text = Console.ReadLine();
        var result = text
            .Split(' ')
            .Select(z => Convert.ToInt32(z))
            .ToArray();
        int lines = result[0];
        int members = result[1];
        var matrix = new int[lines][];
        for (int i = 0; i < lines; i++)
        {
            matrix[i] = new int[members];
        }
        for (int i = 0; i < lines; i++)
        {
            text = null;
            text = Console.ReadLine();
            matrix[i] = text
            .Split(' ')
            .Select(z => Convert.ToInt32(z))
            .ToArray();
        }
        int max = int.MinValue;
        for (int i = 0; i < lines - 2; i++)
        {
            for (int j = 0; j < members - 2; j++)
            {
                int curentSum = GetSum(matrix, i, j);
                if (curentSum > max)
                {
                    max = curentSum;
                }
            }
        }
        Console.WriteLine(max);
    }
    static int GetSum(int[][] matrix, int startRow, int startCol, int rows = 3, int cols = 3)
    {
        int Sum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Sum += matrix[startRow + i][startCol + j];
            }
        }
        return Sum;
    }
}