using System;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            var matrix = new int[matrixSize, matrixSize];

            var sum = 0;

            for (int col = 0; col < matrixSize; col++)
            {
                var readRow = Console.ReadLine();
                var currElement = readRow.Split(" ");
                for (int row = 0; row < matrixSize; row++)
                {
                    matrix[row, col] = int.Parse(currElement[row]);
                }
            }
            var currentRow = 0;
            var currentCol = 0;
            while (true)
            {
                if (currentRow >= matrix.GetLength(0)
                    || currentCol >= matrix.GetLength(1))
                {
                    break;
                }
                sum += matrix[currentRow, currentCol];
                currentRow++;
                currentCol++;
            }
            Console.WriteLine(sum);
        }
    }
}
