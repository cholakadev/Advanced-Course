using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setsLength = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var firstSetLength = setsLength[0];
            var secondSetLength = setsLength[1];

            //var genericSet = new HashSet<int>();

            var totalLength = firstSetLength + secondSetLength;

            var firstSet = new HashSet<int>();
            for (int i = 0; i < firstSetLength; i++)
            {
                var firstSetNumber = int.Parse(Console.ReadLine());
                firstSet.Add(firstSetNumber);
            }

            var secondSet = new HashSet<int>();
            for (int j = 0; j < secondSetLength; j++)
            {
                var secondSetNumber = int.Parse(Console.ReadLine());
                secondSet.Add(secondSetNumber);
            }
            Console.WriteLine(string.Join(" ", firstSet.Intersect(secondSet))); // Намира къде двата сета се пресичат. В случая кои елементи са еднакви за двата сета.
        }
    }
}
