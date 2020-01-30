using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "End")
                {
                    Console.WriteLine(queue.Count + " people remaining.");
                    break;
                }
                else if (name == "Paid")
                {
                    Console.WriteLine(string.Join("\n", queue));
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(name);
                }
            }
        }
    }
}
