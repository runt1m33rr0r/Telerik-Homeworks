using System;

class LargestArea
{
    private static int count = 0;

    private static void Main()
    {
        int maxCount = 0;
        var dimensions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var rows = short.Parse(dimensions[0]);
        var cols = short.Parse(dimensions[1]);
        var matrix = new short[rows, cols];

        for (short row = 0; row < rows; row++)
        {
            var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (short col = 0; col < cols; col++)
            {
                matrix[row, col] = short.Parse(line[col]);
            }
        }

        for (short y = 0; y < rows; y++)
        {
            for (short x = 0; x < cols; x++)
            {
                FindEqualNeighbor(y, x, matrix[y, x], matrix);
                if (count > maxCount)
                {
                    maxCount = count;
                }

                count = 0;
            }
        }

        Console.WriteLine(maxCount);
    }

    private static void FindEqualNeighbor(short row, short col, short found, short[,] matrix)
    {
        if (matrix[row, col] == short.MinValue)
        {
            return;
        }

        count++;
        matrix[row, col] = short.MinValue;
        if (row - 1 >= 0 && row - 1 < matrix.GetLength(0) && matrix[row - 1, col] == found)
        {
            FindEqualNeighbor((short)(row - 1), col, found, matrix);
        }

        if (col + 1 >= 0 && col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == found)
        {
            FindEqualNeighbor(row, (short)(col + 1), found, matrix);
        }

        if (row + 1 >= 0 && row + 1 < matrix.GetLength(0) && matrix[row + 1, col] == found)
        {
            FindEqualNeighbor((short)(row + 1), col, found, matrix);
        }

        if (col - 1 >= 0 && col - 1 < matrix.GetLength(1) && matrix[row, col - 1] == found)
        {
            FindEqualNeighbor(row, (short)(col - 1), found, matrix);
        }

        return;
    }
}