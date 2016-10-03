namespace Matrix
{
    using System;
    using System.Text;
    using Interfaces;

    public static class Matrix
    {
        private const int DirectionsCount = 8;
        private const int DirectionDefaultValue = 0;
        private static int matrixSize;

        public static void Main()
        {
            Console.Write("n = ");

            ILogger<string> logger = new ConsoleLogger<string>();
            IReader reader = new ConsoleReader();

            var matrix = RotateMatrix(logger, reader);
            PrintMatrix(matrix, logger);
        }

        public static int[,] RotateMatrix(ILogger<string> logger, IReader reader)
        {
            matrixSize = int.Parse(reader.ReadInput());

            if (matrixSize < 0)
            {
                throw new ArgumentOutOfRangeException("Matrix size cannot be negative number!");
            }

            int[,] matrix = new int[matrixSize, matrixSize];
            int startRow = 0;
            int startColumn = 0;
            int directionRow = 1;
            int directionColumn = 1;

            FillMatrix(matrix, startRow, startColumn, directionRow, directionColumn);

            return matrix;
        }

        private static void FillMatrix(int[,] matrix, int row, int col, int directionRow, int directionCol)
        {
            int cellValue = 1;

            while (true)
            {
                matrix[row, col] = cellValue;

                if (!CheckDirections(matrix, row, col))
                {
                    break;
                }

                bool isInvalidNextDirection = IsInvalidNextDirection(row, directionRow, col, directionCol, matrix);

                if (isInvalidNextDirection)
                {
                    while (isInvalidNextDirection)
                    {
                        ChangeDirection(ref directionRow, ref directionCol);
                        isInvalidNextDirection = IsInvalidNextDirection(row, directionRow, col, directionCol, matrix);
                    }
                }

                row += directionRow;
                col += directionCol;
                cellValue++;
            }
        }

        private static void ChangeDirection(ref int colDirection, ref int rowDirection)
        {
            int[] directionsCol = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsRow = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int directionIndex = 0;

            for (int i = 0; i < DirectionsCount - 1; i++)
            {
                if (directionsCol[i] == colDirection && directionsRow[i] == rowDirection)
                {
                    directionIndex = i;
                    break;
                }
            }

            if (directionIndex == DirectionsCount)
            {
                colDirection = directionsCol[0];
                rowDirection = directionsRow[0];
                return;
            }

            colDirection = directionsCol[directionIndex + 1];
            rowDirection = directionsRow[directionIndex + 1];
        }

        private static void UnmarkDirections(int[] colDirections, int[] rowDirections, int col, int row)
        {
            for (int i = 0; i < DirectionsCount; i++)
            {
                int nextCol = col + colDirections[i];
                bool isInvalidNextCol = nextCol >= matrixSize || nextCol < 0;

                if (isInvalidNextCol)
                {
                    colDirections[i] = DirectionDefaultValue;
                }

                int nextRow = row + rowDirections[i];
                bool isInvalidNextRow = nextRow >= matrixSize || nextRow < 0;

                if (isInvalidNextRow)
                {
                    rowDirections[i] = DirectionDefaultValue;
                }
            }
        }

        private static bool CheckDirections(int[,] matrix, int col, int row)
        {
            int[] colDirections = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] rowDirections = { 1, 0, -1, -1, -1, 0, 1, 1 };

            UnmarkDirections(colDirections, rowDirections, col, row);

            for (int i = 0; i < DirectionsCount; i++)
            {
                int nextRow = row + rowDirections[i];
                int nextCol = col + colDirections[i];

                if (matrix[nextCol, nextRow] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsInvalidNextDirection(int row, int directionRow, int col, int directionCol, int[,] matrix)
        {
            bool isValidRow = (row + directionRow >= matrixSize) || (row + directionRow < 0);
            bool isValidCol = (col + directionCol >= matrixSize) || (col + directionCol < 0);
            bool isValidNextDirection = isValidCol || isValidRow || matrix[row + directionRow, col + directionCol] != 0;

            return isValidNextDirection;
        }

        private static void PrintMatrix(int[,] matrix, ILogger<string> logger)
        {
            var result = new StringBuilder();

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    result.Append($"{matrix[row, col],3}");
                }

                result.AppendLine();
            }

            logger.LogData(result.ToString());
        }
    }
}