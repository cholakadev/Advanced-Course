using System;

namespace GenericCountString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            GenericCount<string> box = new GenericCount<string>();

            for (int i = 0; i < counter; i++)
            {
                var input = Console.ReadLine();
                box.Data.Add(input);
            }

            var targetItem = Console.ReadLine();

            int result = box.GreaterValuesThan(targetItem);

            Console.WriteLine(result);
        }
    }
}
