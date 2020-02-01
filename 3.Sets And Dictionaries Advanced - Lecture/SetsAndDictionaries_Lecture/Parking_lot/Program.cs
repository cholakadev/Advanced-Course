using System;
using System.Collections.Generic;

namespace Parking_lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new HashSet<string>();

            while (true)
            {
                var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var command = input[0];

                if (command.ToLower() == "end")
                {
                    break;
                }

                var carNumber = input[1];

                if (command.ToLower() == "in")
                {
                    car.Add(carNumber);
                }

                if (command.ToLower() == "out")
                {
                    car.Remove(carNumber);
                }
            }

            if (car.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(string.Join("\n", car));
            }
        }
    }
}
