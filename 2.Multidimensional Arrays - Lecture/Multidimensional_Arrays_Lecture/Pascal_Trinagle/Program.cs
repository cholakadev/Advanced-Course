using System;

namespace Pascal_Trinagle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int[][] pascalTriangle = new int[numberOfRows][];

            for (int i = 0; i < numberOfRows; i++)
            {
                pascalTriangle[i] = new int[i + 1]; 
            }

            //pascalTriangle[0][0] = 1;

            for (int row = 0; row < numberOfRows; row++)
            {
                pascalTriangle[row][0] = 1;
                pascalTriangle[row][pascalTriangle[row].Length - 1] = 1;
                for (int i = 1; i < pascalTriangle[row].Length - 1; i++)
                {
                    pascalTriangle[row][i] = pascalTriangle[row - 1][i] + pascalTriangle[row - 1][i - 1];
                }
            }


            foreach (var array in pascalTriangle)
            {
                foreach (var number in array)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
