using System;
using System.Linq;

namespace Sort_EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(", ")
                .Select(int.Parse)
                .ToArray();

            var result = numbers.Where(x => x % 2 == 0).OrderBy(x => x);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
