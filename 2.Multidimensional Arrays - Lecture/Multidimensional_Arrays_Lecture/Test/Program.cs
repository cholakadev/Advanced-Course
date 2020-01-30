using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split(", ");
            var rows = int.Parse(size[0]);
            var cols = int.Parse(size[1]);

            var matrix = new int[rows, cols];

            int sum = 0;

            for (int row = 0; row < rows; row++)                              //  1 2 3 4 5
            {                                                                 //  5 4 3 2 1
                var rowAsString = Console.ReadLine();                         //  5 7 8 9 10
                var rowElement = rowAsString.Split(", ");                     //  10 9 8 7 6
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowElement[col]);
                    sum += int.Parse(rowElement[col]);
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
