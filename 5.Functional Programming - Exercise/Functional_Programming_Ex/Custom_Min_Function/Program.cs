using System;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> minFunc = inputNumber => Min(inputNumber);

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var result = minFunc(numbers);

            Console.WriteLine(result);
        }

        static int Min(int[] inputNumber)
        {
            int minValue = int.MaxValue;
            foreach (var item in inputNumber)
            {
                if (item < minValue)
                {
                    minValue = item;
                }
            }
            return minValue;
        }
    }
}
