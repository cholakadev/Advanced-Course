using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var num = int.Parse(Console.ReadLine());

            var filteredNums = new Stack<int>();

            Func<int, bool> isDivisible = x => x % num == 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!isDivisible(numbers[i]))
                {
                    filteredNums.Push(numbers[i]);
                }
            }


            Console.WriteLine(string.Join(" ", filteredNums));
        }
    }
}
