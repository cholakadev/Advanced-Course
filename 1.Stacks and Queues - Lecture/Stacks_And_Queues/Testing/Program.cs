using System;
using System.Collections.Generic;
using System.Linq;
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Reverse a string using a stack.
            //string input = Console.ReadLine();  // Четем си стринг.
            //var stack = new Stack<char>(input); // Деклраираме стак и го пълним с симвовлите от инпута.

            //while (stack.Count > 0) // Въртим цикъл докато елементите в стака не станат 0.
            //{
            //    var @char = stack.Pop();   // взимаме всеки елемент от зад напред(както работи стака) и го присвояваме към променлива.
            //    Console.Write(@char);  // Печатаме всеки символ на същия ред.
            //}
            //Console.WriteLine();

            //    //Stack Sum.
            //    var numbers = Console.ReadLine().Split(' ').Select(int.Parse);
            //    var stack = new Stack<int>(numbers);

            //    while (true)
            //    {
            //        var command = Console.ReadLine().Trim().ToLower();
            //        var parts = command.Split(' ');
            //        var commandName = parts[0];

            //        if (commandName == "end")
            //        {
            //            break;
            //        }
            //        else if (commandName == "add")
            //        {
            //            stack.Push(int.Parse(parts[1]));
            //            stack.Push(int.Parse(parts[2]));
            //        }
            //        else if (commandName == "remove")
            //        {
            //            var itemsToRemove = int.Parse(parts[1]);
            //            if (stack.Count >= itemsToRemove)
            //            {
            //                for (int i = 0; i < itemsToRemove; i++)
            //                {
            //                    stack.Pop();
            //                }
            //            }
            //        }
            //    }

            //    var result = stack.Sum();
            //    Console.WriteLine("Sum: " + result);
        }
    }
}
