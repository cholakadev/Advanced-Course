using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<string>> print = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            int wordMaxLength = int.Parse(Console.ReadLine());

            var text = Console.ReadLine()
                .Split()
                .ToList();

            Predicate<string> isInRange = x => x.Length <= wordMaxLength;

            var filteredText = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                if (isInRange(text[i]))
                {
                    filteredText.Add(text[i]);
                }
            }

            print(filteredText);
        }
    }
}
