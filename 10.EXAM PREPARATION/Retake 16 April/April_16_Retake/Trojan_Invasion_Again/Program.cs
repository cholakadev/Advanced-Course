using System;
using System.Collections.Generic;
using System.Linq;

namespace Trojan_Invasion_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            int trojanWaves = int.Parse(Console.ReadLine());

            var spartanPlatesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var spartanPlates = new List<int>(spartanPlatesInput);
            var trojanWarriors = new Stack<int>();

            for (int i = 1; i <= trojanWaves; i++)
            {
                var trojanWarriorsInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Reverse()
                    .ToArray();

                if (i % 3 == 0)
                {
                    int newSpartanPlate = int.Parse(Console.ReadLine());
                    // add to the collection
                    spartanPlates.Add(newSpartanPlate);
                }

                // тук чета инпута по 1 ред на въртене и не мога да ги добавя на веднъж в стека с цикъл.
                for (int j = 0; j < trojanWarriorsInput.Length; j++)
                {
                    trojanWarriors.Push(trojanWarriorsInput[j]);
                }

                while (trojanWarriors.Any() && spartanPlates.Any())
                {
                    var currentWarrior = trojanWarriors.Peek();
                    for (int j = 0; j < spartanPlates.Count; j++)
                    {
                        var currentPlate = spartanPlates[j];
                        if (spartanPlates.Count == 0)
                        {
                            Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                            foreach (var plate in spartanPlates)
                            {
                                Console.WriteLine($"Plates left: {string.Join(", ", plate)}");
                            }
                        }

                        if (currentWarrior > currentPlate)
                        {
                            currentWarrior -= currentPlate;
                            spartanPlates.Remove(currentPlate);
                            continue;
                        }

                        else if (currentWarrior < currentPlate)
                        {
                            trojanWarriors.Pop();
                            var plateReplaced = currentPlate -= currentWarrior;

                            spartanPlates.Remove(currentPlate);
                            spartanPlates.Add(plateReplaced);
                        }

                        else
                        {
                            trojanWarriors.Pop();
                            spartanPlates.Remove(currentPlate);
                        }
                    }
                }
            }

            Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
            foreach (var warrior in trojanWarriors)
            {
                Console.WriteLine($"Warriors left: {string.Join(", ", warrior)}");
            }
        }
    }
}
