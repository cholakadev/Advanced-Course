using System;
using System.Collections.Generic;
using System.Linq;

namespace Cocktails_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredientNums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var freshnessLevelNums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var ingredientValue = new Queue<int>(ingredientNums);

            var freshnessLevelValue = new Stack<int>(freshnessLevelNums);

            var cocktailsInfo = new Dictionary<string, int>();

            while (ingredientValue.Any() && freshnessLevelValue.Any())
            {
                var totalFreshnessLevel = 0;

                var currentIngredient = ingredientValue.Peek();
                var currentFreshness = freshnessLevelValue.Peek();

                if (currentIngredient == 0)
                {
                    ingredientValue.Dequeue();
                    continue;
                }

                totalFreshnessLevel = currentIngredient * currentFreshness;

                if (totalFreshnessLevel == 150)
                {
                    if (!cocktailsInfo.ContainsKey("Mimosa"))
                    {
                        cocktailsInfo.Add("Mimosa", 0);
                    }
                    cocktailsInfo["Mimosa"]++;

                    ingredientValue.Dequeue();
                    freshnessLevelValue.Pop();
                }

                else if (totalFreshnessLevel == 250)
                {
                    if (!cocktailsInfo.ContainsKey("Daiquiri"))
                    {
                        cocktailsInfo.Add("Daiquiri", 0);
                    }
                    cocktailsInfo["Daiquiri"]++;

                    ingredientValue.Dequeue();
                    freshnessLevelValue.Pop();
                }

                else if (totalFreshnessLevel == 300)
                {
                    if (!cocktailsInfo.ContainsKey("Sunshine"))
                    {
                        cocktailsInfo.Add("Sunshine", 0);
                    }
                    cocktailsInfo["Sunshine"]++;

                    ingredientValue.Dequeue();
                    freshnessLevelValue.Pop();
                }

                else if (totalFreshnessLevel == 400)
                {
                    if (!cocktailsInfo.ContainsKey("Mojito"))
                    {
                        cocktailsInfo.Add("Mojito", 0);
                    }
                    cocktailsInfo["Mojito"]++;

                    ingredientValue.Dequeue();
                    freshnessLevelValue.Pop();
                }

                else
                {
                    freshnessLevelValue.Pop();
                    var valueToReplace = ingredientValue.Peek() + 5;
                    ingredientValue.Dequeue();
                    ingredientValue.Enqueue(valueToReplace);
                }
            }

            var finalCocktailInfo = cocktailsInfo.OrderBy(x => x.Key);

            if (cocktailsInfo.Count == 4)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
                foreach (var cocktail in finalCocktailInfo)
                {
                    Console.WriteLine($" # {cocktail.Key} --> {cocktail.Value}");
                }
            }

            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
                Console.WriteLine($"Ingredients left: {ingredientValue.Sum()}");

                foreach (var cocktail in finalCocktailInfo)
                {
                    Console.WriteLine($" # {cocktail.Key} --> {cocktail.Value}");
                }
            }
        }
    }
}
