using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(" -> ");

                var color = input[0];
                var dressArray = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var clothes in dressArray)
                {
                    if (!wardrobe[color].ContainsKey(clothes))
                    {
                        wardrobe[color].Add(clothes, 0);
                    }
                    wardrobe[color][clothes]++;
                }
            }

            var targetDress = Console.ReadLine()
                .Split(' ');
            var targetDressColor = targetDress[0];
            var dress = targetDress[1];

            foreach (var (color, clothes) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");
                foreach (var (clothing, count) in clothes)
                {
                    if (clothing == dress && color == targetDressColor)
                    {
                        Console.WriteLine($"* {clothing} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing} - {count}");
                    }
                }
            }
        }
    }
}
