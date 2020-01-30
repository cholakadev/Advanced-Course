using System;
using System.Linq;

namespace JaggedArray_Modify
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            var jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] eachRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[i] = eachRow;
            }

            while (true)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];

                if (command.ToLower() == "end")
                {
                    for (int i = 0; i < rows; i++)
                    {
                        Console.WriteLine(string.Join(" ", jaggedArray[i]));
                    }
                    break;
                }
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (row < 0 || row > jaggedArray.Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (col < 0 || col > jaggedArray[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (command.ToLower() == "add")
                {
                    jaggedArray[row][col] += value;
                }
                if (command.ToLower() == "subtract")
                {
                    jaggedArray[row][col] -= value;
                }
            }
        }
    }
}
