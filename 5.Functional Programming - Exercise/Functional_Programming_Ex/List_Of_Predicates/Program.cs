using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var filteredNumbers = new List<int>();

            var numbersRange = new List<int>();
            for (int i = 1; i <= endOfRange; i++)
            {
                numbersRange.Add(i);
            }

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNumber = numbers[j];
            }

            Console.WriteLine(string.Join(" ", filteredNumbers));
        }
    }
}
