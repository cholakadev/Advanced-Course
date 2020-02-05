using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceshipCrafting
{
    class Program
    {
        static void Main(string[] args)
        {
            var chemicalLiquidsInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var physicalItemsInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var chemicalLiquids = new Queue<int>(chemicalLiquidsInput);

            var physicalItems = new Stack<int>(physicalItemsInput);

            var materials = new Dictionary<string, int>();

            materials.Add("Glass", 0);
            materials.Add("Carbon fiber", 0);
            materials.Add("Lithium", 0);
            materials.Add("Aluminium", 0);

            int counter = 0;

            while (chemicalLiquids.Any() && physicalItems.Any())
            {
                var currentLiquid = chemicalLiquids.Peek();
                var currentPhysicalItem = physicalItems.Peek();

                var sum = currentLiquid + currentPhysicalItem;

                if (sum == 25)
                {
                    string item = "Glass";

                    Operation(materials, item, chemicalLiquids, physicalItems);

                    counter++;
                }

                else if (sum == 50)
                {
                    string item = "Aluminium";

                    Operation(materials, item, chemicalLiquids, physicalItems);

                    counter++;
                }

                else if (sum == 75)
                {
                    string item = "Lithium";

                    Operation(materials, item, chemicalLiquids, physicalItems);

                    counter++;
                }

                else if (sum == 100)
                {
                    string item = "Carbon fiber";

                    Operation(materials, item, chemicalLiquids, physicalItems);

                    counter++;
                }

                else
                {
                    chemicalLiquids.Dequeue();
                    int increasedItem = currentPhysicalItem + 3;
                    physicalItems.Pop();
                    physicalItems.Push(increasedItem);
                }
            }

            if (counter >= 4)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            printResult(chemicalLiquids, physicalItems);

            var orderedMaterials = materials.OrderBy(x => x.Key);
            foreach (var material in orderedMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }

        public static void printResult(Queue<int> chemicalLiquids, Stack<int> physicalItems)
        {
            if (chemicalLiquids.Any())
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", chemicalLiquids)}");
            }

            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (physicalItems.Any())
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", physicalItems)}");
            }

            else
            {
                Console.WriteLine("Physical items left: none");
            }

            return;
        }

        public static void Operation(Dictionary<string, int> materials, string item,
            Queue<int> chemicalLiquids, Stack<int> physicalItems)
        {
            materials[item]++;

            physicalItems.Pop();
            chemicalLiquids.Dequeue();
        }
    }
}
