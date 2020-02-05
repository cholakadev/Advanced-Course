using System;

namespace EqualityScale
{
    class Program
    {
        public static void Main(string[] args)
        {
            var greater = new EqualityScale<int>(10, 4);
            Console.WriteLine(greater.isFirstGreater());

            var scale = new EqualityScale<string>("Georgi", "Georgi");
            Console.WriteLine(scale.AreEqual());
        }
    }
}
