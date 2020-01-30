using System;
using System.Linq;

namespace Testing2x2MatrixSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            var count2x2Matrix = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j]
                        && matrix[i, j] == matrix[i, j + 1]
                        && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        count2x2Matrix++;
                    }
                }
            }
            Console.WriteLine(count2x2Matrix);
        }
    }
}
