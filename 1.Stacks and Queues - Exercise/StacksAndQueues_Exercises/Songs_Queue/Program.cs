using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songsQueue = new Queue<string>(Console.ReadLine().Split(", "));

            while (songsQueue.Count > 0)
            {
                string lines = Console.ReadLine();
                var commandParts = lines.Split();
                var command = commandParts[0];
                var songName = lines.Substring(4);

                switch (command)
                {
                    case "Play":
                        {
                            songsQueue.Dequeue();
                            if (songsQueue.Count == 0)
                            {
                                Console.WriteLine("No more songs!");
                            }
                        }
                        break;
                    case "Add":
                        {
                            if (!songsQueue.Contains(songName))
                            {
                                songsQueue.Enqueue(songName);
                            }
                            else
                            {
                                Console.WriteLine($"{songName} is already contained!");
                            }
                        }
                        break;
                    case "Show":
                        {
                            Console.WriteLine(string.Join(", ", songsQueue));
                        }
                        break;
                }
            }
        }
    }
}
