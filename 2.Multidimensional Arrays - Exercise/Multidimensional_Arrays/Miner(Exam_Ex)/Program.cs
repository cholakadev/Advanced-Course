using System;
using System.Linq;

namespace Miner_Exam_Ex_
{
    class Program
    {
        static char[,] matrixField;
        static int minorRow;
        static int minorCol;
        static int coals;
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            matrixField = new char[fieldSize, fieldSize];

            ReadMatrix();

            foreach (var command in commands)
            {
                switch (command)
                {
                    case "left":
                        Move(0, -1);
                        break;
                    case "right":
                        Move(0, 1);
                        break;
                    case "up":
                        Move(-1, 0);
                        break;
                    case "down":
                        Move(1, 0);
                        break;
                }
            }
            if (coals != 0)
            {
                Console.WriteLine($"{coals} coals left. ({minorRow}, {minorCol})");
            }
        }

        private static void Move(int row, int col)
        {
            if (isInside(minorRow + row, minorCol + col))
            {
                minorRow += row;
                minorCol += col;
                if (matrixField[minorRow, minorCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({minorRow}, {minorCol})");
                    Environment.Exit(0);
                }
                if (matrixField[minorRow, minorCol] == 'c')
                {
                    coals--;
                    matrixField[minorRow, minorCol] = '*';
                    if (coals == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({minorRow}, {minorCol})");
                    }
                }
            }
        }
        private static void ReadMatrix()
        {
            for (int row = 0; row < matrixField.GetLength(0); row++)
            {
                char[] rowInput = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int col = 0; col < matrixField.GetLength(1); col++)
                {
                    matrixField[row, col] = rowInput[col];
                    
                    if (matrixField[row, col] == 's')
                    {
                        minorRow = row;
                        minorCol = col;
                    }
                    if (matrixField[row, col] == 'c')
                    {
                        coals++;
                    }
                }
            }
        }

        private static bool isInside (int row, int col)
        {
            return row >= 0 && row < matrixField.GetLength(0) 
                && col >= 0 && col < matrixField.GetLength(1);
        }
    }
}
