using System;
using System.Collections.Generic;

namespace CitiesContinCountry
{
    class Program
    {
        static string continent;
        static string country;
        static string city;
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var world = new Dictionary<string, Dictionary<string, List<string>>>();


            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                continent = input[0];
                country = input[1];
                city = input[2];
                if (!world.ContainsKey(continent))
                {
                    world.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!world[continent].ContainsKey(country))
                {
                    world[continent].Add(country, new List<string>());
                }
                world[continent][country].Add(city);
            }

            foreach (var continent in world)
            {
                Console.WriteLine(continent.Key + ":");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
