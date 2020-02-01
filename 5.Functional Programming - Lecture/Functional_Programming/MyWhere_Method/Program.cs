using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyWhere_Method
{
    static class Program
    {
        static void Main(string[] args)
        {
            var input = new[] { 'g', 'L', 't', 'R', 'n', 'd', 'P' };

            var result = input.MyWhere(x => x == 'L');

            var result2 = input.MyWhere(x => x == 'g' || x == 'P');

            Console.WriteLine(string.Join(", ", result));

            Console.WriteLine(string.Join(" - ", result2));
        }

        static List<T> MyWhere<T>(this IEnumerable<T> input, Func<T, bool> filter)
        {
            var newList = new List<T>();
            foreach (var number in input)
            {
                if (filter(number))
                {
                    newList.Add(number);
                }
            }
            return newList;
        }
    }
}
