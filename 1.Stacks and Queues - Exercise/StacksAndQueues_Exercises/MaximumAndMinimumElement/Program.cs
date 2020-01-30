using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            for (int i = 0; i < num; i++)
            {
                var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

                var typeCommand = commands[0];

                if (typeCommand == 1)
                {
                    var elementToAdd = commands[1];
                    stack.Push(elementToAdd);
                }
                else if (typeCommand == 2)
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                    }
                }
                else if (typeCommand == 3)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (typeCommand == 4)
                {
                    Console.WriteLine(stack.Min());
                }
                else if (typeCommand != 1 || typeCommand != 2 || typeCommand != 3 || typeCommand != 4)
                {
                    continue;
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
