using System;
using System.Collections.Generic;
using System.Linq;

namespace Queues_PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var digit = numbers[i];
                if (digit % 2 == 0)
                {
                    queue.Enqueue(digit);
                }
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
