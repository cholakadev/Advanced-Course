using System;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysOfPlunder = int.Parse(Console.ReadLine());
            var dailyPlunder = int.Parse(Console.ReadLine());
            var expectedPlunder = double.Parse(Console.ReadLine());

            double plunder = 0;
            for (int i = 0; i < daysOfPlunder; i++)
            {
                if (i % 2 == 0)
                {
                    plunder += dailyPlunder;
                }
                if (i % 2 == 1)
                {
                    plunder += dailyPlunder;
                    if (i == 3)
                    {
                        plunder += dailyPlunder / 2;
                    }
                    else if (i == 5)
                    {
                        plunder -= dailyPlunder * 0.3;
                    }
                }
            }
            double percentage = expectedPlunder / 100 * plunder;
            if (plunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {plunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
