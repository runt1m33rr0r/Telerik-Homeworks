using System;

class Matrix
{
    static void Main()
    {
        PrintArray(Spiral(int.Parse(Console.ReadLine())));
    }

    public static int[,] Spiral(int n)
    {
        int[,] result = new int[n, n];

        int pos = 1;
        int count = n;
        int value = -n;
        int sum = -1;

        do
        {
            value = -1 * value / n;
            for (int i = 0; i < count; i++)
            {
                sum += value;
                result[sum / n, sum % n] = pos++;
            }
            value *= n;
            count--;
            for (int i = 0; i < count; i++)
            {
                sum += value;
                result[sum / n, sum % n] = pos++;
            }
        } while (count > 0);

        return result;
    }

    public static void PrintArray(int[,] array)
    {
        int n = (array.GetLength(0) * array.GetLength(1) - 1).ToString().Length + 1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j].ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}