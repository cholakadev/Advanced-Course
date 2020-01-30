using System;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var matrix = new int[matrixSize, matrixSize];
            var primaryDiagonal = 0;
            var secondaryDiagonal = 0;

            for (int row = 0; row < matrixSize; row++)
            {
                var rowAsString = Console.ReadLine();
                var currentElement = rowAsString.Split();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = int.Parse(currentElement[col]);
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
                primaryDiagonal += matrix[currentRow, currentCol];
                currentRow++;
                currentCol++;
            }

            var secondaryCurrRow = 0;
            var secondaryCurrCol = matrix.GetLength(1) - 1;
            while (true)
            {
                if (secondaryCurrRow >= matrix.GetLength(0) 
                    || secondaryCurrCol >= matrix.GetLength(1))
                {
                    break;
                }
                secondaryDiagonal += matrix[secondaryCurrRow, secondaryCurrCol];
                secondaryCurrRow++;
                secondaryCurrCol--;
            }


            var diagonalDifference = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(diagonalDifference);
        }
    }
}
