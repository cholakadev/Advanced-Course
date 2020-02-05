using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Club_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallsMaxCapacity = int.Parse(Console.ReadLine());

            var primaryInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            // 1 2 3 4 5 <-- last to first

            var input = new Stack<string>(primaryInput);

            // store the input

            var hallsAndPeople = new Dictionary<string, List<int>>();

            // 60
            // 1 20 b 20 20 a

            var halls = new Queue<string>();

            while (input.Any())
            {
                var current = input.Peek();

                if (!char.IsDigit(current[0]))
                {
                    hallsAndPeople[current] = new List<int>();
                    halls.Enqueue(current);
                    input.Pop();
                    continue;
                }

                if (hallsAndPeople.Count == 0)
                {
                    input.Pop();
                    continue;
                }

                foreach (var hall in hallsAndPeople)
                {
                    if (hall.Value.Sum() + int.Parse(current) <= hallsMaxCapacity)
                    {
                        hallsAndPeople[hall.Key].Add(int.Parse(current));
                        input.Pop();
                        break;  
                    }

                    if (hall.Value.Sum() + int.Parse(current) >= hallsMaxCapacity && halls.Any())
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", hall.Value)}");
                        hallsAndPeople.Remove(hall.Key);
                    }

                    break;
                }
            }
        }
    }
}
