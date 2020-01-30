using System;
using System.Linq;

namespace MinerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            char[,] matrix = new char[size, size];
            //*, e for exit, c for coals, s for start
            int minerRow = 0;
            int minerCol = 0;
            int coals = 0;

            //"You collected all coals! ({minerRow}, {minerCol})"
            //"Game over! ({minerRow}, {minerCol})"
            //"{coals} coals left. ({minerRow}, {minerCol})"

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowInput[col];

                    if (matrix[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                    if (matrix[row, col] == 'c')
                    {
                        coals++;
                    }
                }
            }

            foreach (var command in commands)
            {
                switch (command)
                {
                    case "left":
                        minerCol = minerCol - 1;
                        break;
                    case "right":
                        minerCol = minerCol + 1;
                        break;
                    case "up":
                        minerRow = minerRow - 1;
                        break;
                    case "down":
                        minerRow = minerRow + 1;
                        break;
                }
            }
        }
    }
}
