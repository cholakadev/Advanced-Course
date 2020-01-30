using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantityPerDay = int.Parse(Console.ReadLine());
            int[] quantityOfOrders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>();

            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < quantityOfOrders.Length; i++)
            {
                var current = quantityOfOrders[i];
                queue.Enqueue(current);
                if (current > min)
                {
                    min = current;
                }
                else if (current > max)
                {
                    max = current;
                }
            }

            while (true)
            {
                if (queue.Count == 0 || queue.Peek() > foodQuantityPerDay)
                {
                    break;
                }
                else if (queue.Peek() < foodQuantityPerDay)
                {
                    var current = queue.Peek();
                    foodQuantityPerDay -= current;
                    queue.Dequeue();
                }
            }

            Console.WriteLine(max);

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else if (queue.Count != 0)
            {
                Console.WriteLine("Orders left: " + string.Join(" ", queue));
            }




            //int foodQuantityPerDay = int.Parse(Console.ReadLine());
            //int[] quantityOfOrders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //var queue = new Queue<int>(quantityOfOrders);
            //int max = queue.Max();

            //while (queue.Count > 0)
            //{
            //    if (queue.Peek() <= foodQuantityPerDay)
            //    {
            //        foodQuantityPerDay -= queue.Dequeue();
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(max);

            //if (queue.Count == 0)
            //{
            //    Console.WriteLine("Orders complete");
            //}
            //else if (queue.Count != 0)
            //{
            //    Console.WriteLine("Orders left: " + string.Join(" ", queue));
            //}
        }
    }
}
