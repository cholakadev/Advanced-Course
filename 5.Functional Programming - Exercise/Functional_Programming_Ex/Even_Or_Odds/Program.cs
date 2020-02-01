using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = num => num % 2 == 0;

            var range = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var startNumber = range[0];
            var endNumber = range[1];

            var numbersInRange = new List<int>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                numbersInRange.Add(i);
            }

            var command = Console.ReadLine();

            if (command == "even")
            {
                numbersInRange.RemoveAll(x => !isEven(x));
            }
            else
            {
                numbersInRange.RemoveAll(x => isEven(x));
            }

            Console.WriteLine(string.Join(" ", numbersInRange));
        }
    }
}
