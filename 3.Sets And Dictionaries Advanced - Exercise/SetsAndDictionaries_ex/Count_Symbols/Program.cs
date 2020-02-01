using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();

            //var set = new HashSet<char>();
            var dict = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!dict.ContainsKey(text[i]))
                {
                    dict.Add(text[i], 0);
                }
                dict[text[i]]++;
            }

            foreach (var @char in dict)
            {
                Console.WriteLine($"{@char.Key}: {@char.Value} time/s");
            }
        }
    }
}
