using System;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> print = x => Console.WriteLine(string.Join(" ", x));

            Func<int, int> add = num => ++num;
            Func<int, int> subtract = num => --num;
            Func<int, int> multiply = num => num *= 2;

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //add
            //add
            //print
            //end

            while (true)
            {
                var command = Console.ReadLine();

                if (command.ToLower() == "end")
                {
                    break;
                }

                if (command.ToLower() == "add")
                {
                    numbers = numbers.Select(add).ToArray();
                }
                else if (command.ToLower() == "subtract")
                {
                    numbers = numbers.Select(subtract).ToArray();
                }
                else if (command.ToLower() == "multiply")
                {
                    numbers = numbers.Select(multiply).ToArray();
                }
                else if (command.ToLower() == "print")
                {
                    print(numbers);
                }
            }
        }
    }
}
