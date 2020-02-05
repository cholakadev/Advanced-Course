using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var library = new Library();

            library.Add(new Book("1984", 1980, "Jorge Owell"));
            library.Add(new Book("The Godfather", 1981, "Mario Puzo"));
            library.Add(new Book("The Lord Of The Rings", 1954, "J. Tolkin"));

            // Искаме да итерираме през книгите и да направим следното:

            foreach (var book in library.Where(x => x.Year > 1960))
            {
                Console.WriteLine($"{string.Join(", ", book.Authors)} - {book.Title} ({book.Year})");
            }
        }
    }
}
