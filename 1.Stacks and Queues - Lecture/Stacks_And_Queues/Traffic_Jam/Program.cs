using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsToPass = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int counter = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    Console.WriteLine(counter + " cars passed the crossroads.");
                    break;
                }
                else if (command == "green")
                {
                    for (int i = 0; i < carsToPass; i++)
                    {
                        if (queue.Count > 0)
                        {
                            var current = queue.Peek();
                            Console.WriteLine(current + " passed!");
                            queue.Dequeue();
                            counter++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }

        }
    }
}
