namespace Test
{
    using System;
    public interface IMovable
    {
        void SetEngine (double engineCapacity);
    }
    public class Vehicle : IMovable
    {
        public void SetEngine(double engineCapacity)
        {
            if (engineCapacity >= 3000)
            {
                Console.WriteLine("360 HP");
            }
            else
            {
                Console.WriteLine("220 HP");
            }

            Console.WriteLine($"Your car got engine capacity {engineCapacity} cc.");
        }
    }

    public class Car
    {
        public void Weight(int startWeight, int endWeight)
        {
            Console.WriteLine($"Your car weights between {startWeight} kg and {endWeight} kg.");
        }
    }

    public class Lamborghini : Vehicle
    {
        public void SetColor(string color)
        {
            Console.WriteLine($"Your lamborhini color is {color}.");
        }
    }
}
