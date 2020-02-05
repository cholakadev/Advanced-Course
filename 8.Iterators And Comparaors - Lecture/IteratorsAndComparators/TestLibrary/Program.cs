using System;
using System.Collections.Generic;

namespace TestLibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var library = new Library();

            library.Add(new Book("Animal Kingdom", 2001, new List<string> { "George Michal" }));
            library.Add(new Book("Piter Pan", 1932, new List<string> { "J. Piterson" }));
            library.Add(new Book("Samuel Death", 1947, new List<string> { "Miniver Olivers", "Daniel Davis" }));

            foreach (var book in library)
            {
                Console.WriteLine($"{string.Join(" ", book.Authors)} - {book.Title} ({book.Year})");
            }
        }
    }
}
