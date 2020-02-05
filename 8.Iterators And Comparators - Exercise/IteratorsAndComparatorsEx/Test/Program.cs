using System;
using System.Linq;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var createList = Console.ReadLine()
                .Split()
                .Skip(1)
                .ToList();

            ListyIterator<string> list = new ListyIterator<string>(createList);

            var command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                if (command.ToLower() == "move")
                {
                    Console.WriteLine(list.Move());
                }

                else if (command.ToLower() == "hasnext")
                {
                    Console.WriteLine(list.HasNext());
                }

                else if (command.ToLower() == "print")
                {
                    try
                    {
                        list.Print();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
