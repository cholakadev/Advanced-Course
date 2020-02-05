using System;
using System.Linq;

namespace Collection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var createCollection = Console.ReadLine()
                .Split()
                .Skip(1)
                .ToList();

            ListyIterator<string> myCollection = new ListyIterator<string>(createCollection);

            var command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                try
                {
                    if (command.ToLower() == "move")
                    {
                        Console.WriteLine(myCollection.Move());
                    }

                    else if (command.ToLower() == "hasnext")
                    {
                        Console.WriteLine(myCollection.HasNext());
                    }

                    else if (command.ToLower() == "print")
                    {
                        myCollection.Print();
                    }

                    else if (command.ToLower() == "printall")
                    {
                        Console.WriteLine(string.Join(" ", myCollection));
                        //foreach (var item in myCollection)
                        //{
                        //    Console.Write(item + " ");
                        //}
                        //Console.WriteLine();
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //try-catch - Докато юзъра не вкара правилното име или парола while цикъла се извиква отново.
                command = Console.ReadLine();
            }
        }
    }
}
