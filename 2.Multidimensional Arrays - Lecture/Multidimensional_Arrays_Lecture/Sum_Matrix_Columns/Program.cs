using System;

namespace Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(", ");
            var rows = int.Parse(matrixSize[0]);
            var cols = int.Parse(matrixSize[1]);
            var matrix = new int[rows, cols];
            var arr = new int[cols];

            for (int row = 0; row < rows; row++)
            {
                var rowAsString = Console.ReadLine();
                var element = rowAsString.Split(" ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(element[col]);
                    arr[col] += matrix[row, col];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
