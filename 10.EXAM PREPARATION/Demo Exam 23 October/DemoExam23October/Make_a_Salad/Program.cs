using System;
using System.Collections.Generic;
using System.Linq;

namespace Make_a_Salad
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetablesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var caloriesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            // collections
            var vegetables = new Queue<string>(vegetablesInput);

            var saladCalories = new Stack<int>(caloriesInput);

            var salads = new Stack<int>();

            while (vegetables.Any() && saladCalories.Any())
            {
                var currentVegetable = vegetables.Peek();
                var currentCalories = saladCalories.Peek();

                salads.Push(currentCalories);

                if (currentVegetable.ToLower() == "tomato")
                {
                    currentCalories -= 80;
                    vegetables.Dequeue();

                    if (currentCalories <= 0)
                    {
                        saladCalories.Pop();
                    }
                    else
                    {
                        salads.Pop();
                    }
                }

                else if (currentVegetable.ToLower() == "carrot")
                {
                    currentCalories -= 136;
                    vegetables.Dequeue();

                    if (currentCalories <= 0)
                    {
                        saladCalories.Pop();
                    }
                    else
                    {
                        salads.Pop();
                    }
                }

                else if (currentVegetable.ToLower() == "lettuce")
                {
                    currentCalories -= 109;
                    vegetables.Dequeue();

                    if (currentCalories <= 0)
                    {
                        saladCalories.Pop();
                    }
                    else
                    {
                        salads.Pop();
                    }
                }

                else if (currentVegetable.ToLower() == "potato")
                {
                    currentCalories -= 215;
                    vegetables.Dequeue();

                    if (currentCalories <= 0)
                    {
                        saladCalories.Pop();
                    }
                    else
                    {
                        salads.Pop();
                    }
                }
            }

            Console.WriteLine(string.Join(' ', salads.Reverse()));

            if (saladCalories.Any())
            {
                Console.WriteLine(string.Join(' ', saladCalories));
            }

            else if (vegetables.Any())
            {
                Console.WriteLine(string.Join(' ', vegetables));
            }
        }
    }
}
