using System;
using System.Linq;

namespace Knights_Of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = item => Console.WriteLine("Sir " + item);

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(action);
        }
    }
}
