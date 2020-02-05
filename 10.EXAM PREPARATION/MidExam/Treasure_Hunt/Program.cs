using System;
using System.Collections.Generic;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsMade = int.Parse(Console.ReadLine());
            double oneStepLength = double.Parse(Console.ReadLine()); // in centimeters!!!
            int distanceToTravel = int.Parse(Console.ReadLine()); // in meters!!!

            // Convert from meters to centimeters.
            var distanceToTravelCM = distanceToTravel / 0.01;
            double FifthStepLength = 0.0;
            // working with centimeters only.
            // every 5th step is 30% shorter.
            int counter = 0;
            var total = oneStepLength * stepsMade;
            for (int i = 0; i < stepsMade; i++)
            {
                if (i % 2 == 5)
                {
                    counter++;
                    FifthStepLength = oneStepLength - oneStepLength / 3;
                    total -= oneStepLength;
                    total += FifthStepLength;
                }
            }
            var percentage = total / distanceToTravel;
            Console.WriteLine($"{percentage:F2}");

        }
    }
}
