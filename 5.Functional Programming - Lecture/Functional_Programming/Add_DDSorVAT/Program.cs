using System;
using System.Linq;

namespace Add_DDSorVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .ToArray();

            foreach (var price in prices)
            {
                var result = price * 1.20;
                Console.WriteLine($"{result:f2}");
            }
        }
    }
}
