using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            var command = new Stack<string>();

            string text = string.Empty;

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var mainCommand = commands[0];

                switch (mainCommand)
                {
                    case "1":
                        {
                            command.Push(text);
                            text += commands[1];
                        }
                        break;
                    case "2":
                        {
                            command.Push(text);
                            text = text.Substring(0, text.Length - int.Parse(commands[1]));
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine(text[int.Parse(commands[1]) - 1]);
                        }
                        break;
                    case "4":
                        {
                            text = command.Pop();
                        }
                        break;
                }
            }
        }
    }
}
