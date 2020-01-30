using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculateTheSumInStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)); // Или само (int.Parse)
            var stack = new Stack<int>(numbers);

            while (true)
            {
                var command = Console.ReadLine().ToLower().Trim();
                var parts = command.Split(' ');
                var commandName = parts[0];

                if (commandName == "add")
                {
                    stack.Push(int.Parse(parts[1]));
                    stack.Push(int.Parse(parts[2]));
                }
                else if (commandName == "remove")
                {
                    var itemsToRemove = int.Parse(parts[1]);
                    if (stack.Count >= itemsToRemove)
                    {
                        for (int i = 0; i < itemsToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                else if (command == "end")
                {
                    break;
                }
            }

            var result = stack.Sum();
            Console.WriteLine("Sum: " + result);
        }
    }
}
