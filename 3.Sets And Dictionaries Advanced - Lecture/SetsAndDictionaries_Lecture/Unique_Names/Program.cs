using System;
using System.Collections.Generic;

namespace Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();

            for (int i = 0; i < num; i++)
            {
                var name = Console.ReadLine();
                names.Add(name);
            }

            Console.WriteLine(string.Join("\n", names));
        }
    }
}
