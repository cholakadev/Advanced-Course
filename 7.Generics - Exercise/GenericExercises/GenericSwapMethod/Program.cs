using System;
using System.Linq;

namespace GenericSwapMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());

            GenericSwap<int> box = new GenericSwap<int>();

            for (int i = 0; i < counter; i++)
            {
                var input = int.Parse(Console.ReadLine());

                box.Data.Add(input);
            }

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int index1 = indexes[0];
            int index2 = indexes[1];

            box.Swap(index1, index2);

            Console.WriteLine(box);
        }
    }
}
