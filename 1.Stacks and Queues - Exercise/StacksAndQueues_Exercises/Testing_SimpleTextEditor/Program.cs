using System;
using System.Collections.Generic;

namespace Testing_SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfOperations = int.Parse(Console.ReadLine());

            var manipulations = new Stack<string>();

            string text = string.Empty;

            for (int i = 0; i < numOfOperations; i++)
            {
                string[] commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = commands[0];

                switch (command)
                {
                    case "1":
                        manipulations.Push(text);
                        text += commands[1];
                        break;
                    case "2":
                        manipulations.Push(text);
                        text = text.Substring(0, text.Length - int.Parse(commands[1]));
                        break;
                    case "3":
                        Console.WriteLine(text[int.Parse(commands[1])-1]);
                        break;
                    case "4":
                        text = manipulations.Pop();
                        break;
                }
            }
        }
    }
}
