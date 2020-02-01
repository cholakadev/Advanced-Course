using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Func method
            Func<int, long> operation = Factorial;  // I can chage which method to use here.

            Console.WriteLine(operation(5));   // And print the result here.


            // Action method

            Action<int> action = PrintToConsoleWithLines;
            action += PrinToConsole;

            action(3777);
        }

        static long Factorial(int number)
        {
            long result = 1;
            for (int i = 1; i < number; i++)
            {
                result *= i;
            }

            return result;
        }

        static long Square(int number)
        {
            return number * number;
        }

        static void PrintToConsoleWithLines(int number)
        {
            Console.WriteLine("=========================");
            Console.WriteLine($"      Result: {number}");
            Console.WriteLine("=========================");
        }

        static void PrinToConsole(int number)
        {
            Console.WriteLine($"      --- {number} ---");
        }
    }
}
