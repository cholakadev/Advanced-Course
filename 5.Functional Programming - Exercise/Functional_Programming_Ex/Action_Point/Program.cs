using System;

namespace Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> action = items => Console.WriteLine(string.Join(Environment.NewLine, items));

            var input = Console.ReadLine().Split();

            action(input);
        }
    }
}
