using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            var matrix = new char[sizeMatrix, sizeMatrix];

            for (int row = 0; row < sizeMatrix; row++)
            {
                char[] charArr = Console.ReadLine().ToCharArray();
                for (int col = 0; col < sizeMatrix; col++)
                {
                    matrix[row, col] = charArr[col];
                }
            }
            string symbol = Console.ReadLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j].ToString() == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        break;
                    }
                }
            }
        }
    }
}
