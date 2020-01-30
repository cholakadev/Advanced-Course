using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Botique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rackCapacity = int.Parse(Console.ReadLine());

            var stack = new Stack<int>(clothes);

            int sum = 0;
            int racks = 1;

            while (stack.Count > 0)
            {
                sum += stack.Peek();
                if (sum <= rackCapacity)
                {
                    stack.Pop();
                }
                else
                {
                    racks++;
                    sum = 0;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
