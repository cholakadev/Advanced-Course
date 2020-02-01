using System;
using System.Linq;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<int> print = PrintToConsoleWithLines;
            //print += PrintToConsole;
            //print += PrintToConsole;
            //print += PrintToConsole;

            //print(3777);


            // Result е крайният резултат от филтрацията, която сме приложили с .Where
            /*var Result = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
            .Where(x => x % 2 == 0);*/

            // Или с други думи :
            var input = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var Result = input.Where(x => x % 2 == 0);

            Console.WriteLine(string.Join(" - ", Result));
        }

        static void PrintToConsoleWithLines(int number)
        {
            Console.WriteLine("---------------");
            Console.WriteLine($"*{number}*");
            Console.WriteLine("---------------");
        }

        static void PrintToConsole(int number)
        {
            Console.WriteLine($"{number*2}{number}{number/2}");
        }
    }
}
