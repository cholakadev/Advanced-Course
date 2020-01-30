using System;

namespace SquareWith_MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(", ");
            var matrixRows = int.Parse(matrixSize[0]);
            var matrixCols = int.Parse(matrixSize[1]);
            var matrix = new int[matrixRows, matrixCols];

            var maxSum = int.MinValue;
            var sum = 0;

            var maxRow = -1;
            var maxCol = -1;

            for (int row = 0; row < matrixRows; row++)
            {
                var rowAsString = Console.ReadLine();
                var currentElement = rowAsString.Split(", ");
                for (int col = 0; col < matrixCols; col++)
                {
                    matrix[row, col] = int.Parse(currentElement[col]);
                }
            }

            for (int row = 0; row < matrixRows - 1; row++)
            {
                for (int col = 0; col < matrixCols - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];


                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
