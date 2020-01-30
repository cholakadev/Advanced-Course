using System;
using System.Collections.Generic;

namespace Solo_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>(input);

            while (stack.Count > 0)
            {
                char @char = stack.Pop();
                Console.Write(@char);
            }
            Console.WriteLine();
        }
    }
}
