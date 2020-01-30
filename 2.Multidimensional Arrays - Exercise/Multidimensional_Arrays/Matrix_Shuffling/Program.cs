using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                // Да се поправи ако матрицата се попълни с масив от чарове или стрингове гърми.
                int[] rowNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (rowNumbers.Length > cols)
                {
                    throw new FormatException("Invalid input!");
                }
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowNumbers[col];
                }
            }

            while (true)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];

                if (command.ToLower() == "end")
                {
                    break;
                }

                if (command.ToLower() != "swap")
                {
                    Console.WriteLine("Invalid input!");
                }

                if (input.Length > 5)
                {
                    Console.WriteLine("Invalid input!");
                }

                var row1 = int.Parse(input[1]);
                var col1 = int.Parse(input[2]);
                var row2 = int.Parse(input[3]);
                var col2 = int.Parse(input[4]);

                if (row1 > rows || col1 > cols
                    || row2 > rows || col2 > cols
                    || row1 < 0 || col1 < 0
                    || row2 < 0 || col2 < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                var number = matrix[row1, col1];
                if (command.ToLower() == "swap")
                {
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = number;
                }

                for (int k = 0; k <= matrix.GetLength(0) - 1; k++)
                {
                    for (int l = 0; l <= matrix.GetLength(1) - 1; l++)
                    {
                        Console.Write(matrix[k, l] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
