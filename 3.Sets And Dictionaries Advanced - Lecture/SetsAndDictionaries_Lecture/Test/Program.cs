using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var dictionary = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];
                if (!dictionary.ContainsKey(numbers[i]))
                {
                    dictionary.Add(currentNumber, 1);
                }
                else
                {
                    dictionary[currentNumber]++;
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
