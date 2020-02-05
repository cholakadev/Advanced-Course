using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            myCustomStack<int> myStack = new myCustomStack<int>();

            string command;

            while((command = Console.ReadLine()) != "END")
            {

                var tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Push")
                {
                    int[] elements = tokens.Skip(1)
                        .Select(i => i.Split(",", StringSplitOptions.RemoveEmptyEntries).First())
                        .Select(int.Parse)
                        .ToArray();

                    myStack.Push(elements);
                }

                else if(tokens[0] == "Pop")
                {
                    try
                    {
                        myStack.Pop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            foreach (var num in myStack)
            {
                Console.WriteLine(num);
            }
            foreach (var num in myStack)
            {
                Console.WriteLine(num);
            }
        }
    }
}
