using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string numbersInput = Console.ReadLine();
                var currentNumber = numbersInput.Split(' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(currentNumber[col]);
                }
            }

            var maxSum = int.MinValue;
            var sum = 0;
            var indexRow = 0;
            var indexCol = 0;
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (sum > maxSum)
                    {
                        indexRow = i;
                        indexCol = j;
                        maxSum = sum;
                    }
                }
            }

            Console.WriteLine($"Sum = " + maxSum);

            for (int k = indexRow; k <= indexRow + 2; k++)
            {
                for (int l = indexCol; l <= indexCol + 2; l++)
                {
                    Console.Write(matrix[k, l] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
