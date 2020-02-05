using System;
using System.Collections.Generic;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.SetEngine(3198.7);

            Car car = new Car();
            car.Weight(1400, 1800);

            Lamborghini lamborghini = new Lamborghini();
            lamborghini.SetEngine(5000);
            lamborghini.SetColor("purple");

            // -------- ITERATOR -------------
            IEnumerable<int> list = new List<int> { 1, 2, 3, 4, 5 };

            IEnumerator<int> enumarator = list.GetEnumerator();
            while (enumarator.MoveNext())
            {
                Console.WriteLine(enumarator.Current);
            }

            // Ако искаме да итерираме през елементите отново трябва да използваме .Reset

            enumarator.Reset();

            while (enumarator.MoveNext())
            {
                Console.WriteLine(enumarator.Current);
            }
        }
    }
}
