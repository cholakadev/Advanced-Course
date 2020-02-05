using System;
using System.Collections.Generic;
using System.Linq;

namespace Trojan_Invasion
{
    class Program
    {
        static void Main(string[] args)
        {
            var trojanWarriorWaves = int.Parse(Console.ReadLine());

            // Shield
            var platesDeff = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            var shieldStack = new Stack<int>();

            for (int i = 0; i < platesDeff.Length; i++)
            {
                shieldStack.Push(platesDeff[i]);
            }

            var warriorPower = new Queue<int>();

            // --------
            for (int i = 0; i <= trojanWarriorWaves; i++)
            {
                if (i % 3 == 0 && i > 0)
                {
                    int newShieldField = int.Parse(Console.ReadLine());
                    shieldStack.Push(newShieldField);
                }

                if (shieldStack.Count == 0)
                {
                    Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                    Console.WriteLine($"Warriors left: {string.Join(", ", warriorPower.Reverse())}");
                    System.Environment.Exit(0);
                }

                var powerOfEachWarrior = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Reverse()
                    .ToArray();

                for (int j = 0; j < powerOfEachWarrior.Length; j++)
                {
                    var current = powerOfEachWarrior[j];
                    warriorPower.Enqueue(current);
                }

                while (warriorPower.Count > 0 && shieldStack.Count > 0)
                {

                    if (warriorPower.Peek() > shieldStack.Peek())
                    {
                        int currentWarrior = warriorPower.Peek() - shieldStack.Peek();
                        shieldStack.Pop();
                        warriorPower.Dequeue();
                        warriorPower.Enqueue(currentWarrior);
                    }

                    else if (warriorPower.Peek().Equals(shieldStack.Peek()))
                    {
                        shieldStack.Pop();
                        warriorPower.Dequeue();
                    }

                    else
                    {
                        int currentWarrior = shieldStack.Peek() - warriorPower.Peek();
                        warriorPower.Dequeue();
                        shieldStack.Pop();
                        shieldStack.Push(currentWarrior);
                    }
                }
            }
            Console.WriteLine($"The Spartans successfully repulsed the Trojan attack.\n{string.Join(" ", shieldStack)}");
        }
    }
}
