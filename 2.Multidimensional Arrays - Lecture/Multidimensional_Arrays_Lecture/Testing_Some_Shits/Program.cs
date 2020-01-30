using System;
using System.Linq;

namespace Testing_Some_Shits
{
    class Program
    {
        static void Main(string[] args)
        {
            //var matrixSize = Console.ReadLine().Split(", ");
            //var rows = int.Parse(matrixSize[0]);
            //var cols = int.Parse(matrixSize[1]);

            //var matrix = new int[rows, cols];

            //for (int row = 0; row < rows; row++)
            //{
            //    var rowAsString = Console.ReadLine();
            //    var currentElement = rowAsString.Split(", ");
            //    for (int col = 0; col < cols; col++)
            //    {
            //        matrix[row, col] = int.Parse(currentElement[col]);
            //    }
            //}
            //Console.WriteLine(rows);
            //Console.WriteLine(cols);
            //Console.WriteLine(matrix.Cast<int>().Sum());


            var matrixSize = Console.ReadLine().Split(", ");
            var rows = int.Parse(matrixSize[0]);
            var cols = int.Parse(matrixSize[1]);

            var sumColumns = new int[cols];

            var matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var readRow = Console.ReadLine();
                var currentElement = readRow.Split(" ");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(currentElement[col]);
                    sumColumns[col] += int.Parse(currentElement[col]);
                }
            }

            for (int i = 0; i < sumColumns.Length; i++)
            {
                Console.WriteLine(sumColumns[i]);
            }
        }
    }
}
