using System;

class MatrixFill
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        char matrixType = char.Parse(Console.ReadLine());

        int[,] matrix = new int[number, number];

        if (matrixType == 'a')
        {
            PrintFirstMatrixType(matrix);
        }
        else if (matrixType == 'b')
        {
            PrintSecondMatrixType(matrix);
        }
        else if (matrixType == 'c')
        {
            PrintThirdMatrixType(matrix);
        }
        else if (matrixType == 'd')
        {
            PrintFourthMatrixType(matrix);
        }
    }

    static void PrintFirstMatrixType(int[,] someMatrix)
    {
        int rows = someMatrix.GetLength(0);
        int cols = someMatrix.GetLength(1);

        int counter = 0;

        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                counter++;
                someMatrix[col, row] = counter;
            }
        }

        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                if (row == 0)
                {
                    Console.Write(someMatrix[row, col]);
                }
                else
                {
                    Console.Write(" " + someMatrix[row, col]);
                }
            }
            Console.WriteLine();
        }
    }

    static void PrintSecondMatrixType(int[,] someMatrix)
    {
        int rows = someMatrix.GetLength(0);
        int cols = someMatrix.GetLength(1);

        int counter = 1;

        for (int col = 0; col < cols; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < rows; row++)
                {
                    someMatrix[row, col] = counter;
                    counter++;
                }
            }
            else
            {
                for (int row = rows - 1; row >= 0; row--)
                {
                    someMatrix[row, col] = counter;
                    counter++;
                }
            }
        }

        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                if (row == 0)
                {
                    Console.Write(someMatrix[col, row]);
                }
                else
                {
                    Console.Write(" " + someMatrix[col, row]);
                }
            }
            Console.WriteLine();
        }
    }

    static void PrintThirdMatrixType(int[,] someMatrix)
    {
        int n = someMatrix.GetLength(0);
        int[,] matrix = new int[n, n];
        int rows = 0;
        int cols = 0;
        int startCount = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            rows = i;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[rows++, cols++] = startCount++;
            }
        }

        for (int j = 1; j < n; j++)
        {
            rows = j;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[cols++, rows++] = startCount++;
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int p = 0; p < matrix.GetLength(1); p++)
            {
                if (p == 0)
                {
                    Console.Write(matrix[i, p]);
                }
                else
                {
                    Console.Write(" " + matrix[i, p]);
                }
            }
            Console.WriteLine();
        }
    }

    static void PrintFourthMatrixType(int[,] someMatrix)
    {
        int n = someMatrix.GetLength(0);
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

        n = (result.GetLength(0) * result.GetLength(1) - 1).ToString().Length + 1;

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                if (j == 0)
                {
                    Console.Write(result[j, i]);
                }
                else
                {
                    Console.Write(" " + result[j, i]);
                }
            }
            Console.WriteLine();
        }
    }
}

