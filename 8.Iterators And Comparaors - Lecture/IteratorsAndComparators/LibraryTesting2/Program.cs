using System;
using System.Collections.Generic;

namespace LibraryTesting2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();
            Library library2 = new Library();
            
            library.Add(new Book("Soldier", 1972, 19.99M, "Michael Piterson", "Piter Jackson"));
            library.Add(new Book("Man os steel", 1997, 12.99M, "Tomas Hanks", "Jeramih Thompson"));
            library.Add(new Book("Don Kihot", 1877, 17.48M, "Pencho Slaveikov"));

            library2.Add(new Book("Inferno", 2004, 9.70M, "Maligo Jacobs"));
            library2.Add(new Book("One man army", 2007, 13.28M, "T. Jolkin", "J.R. Milson", "M. Hopsin"));

            // IComparable (Library) - compare collection by given value.
            if (library.CompareTo(library2) > 0)
            {
                Console.WriteLine("library is bigger then library2");
            }
            else if (library.CompareTo(library2) < 0)
            {
                Console.WriteLine("library is less then library2");
            }
            else
            {
                Console.WriteLine("They are equals");
            }

            // IEnumerator - foreach collection.
            foreach (var book in library)
            {
                Console.WriteLine($"{book.Title} - {string.Join(", ", book.Authors)} ({book.Year})");
            }

            // IComparable (Book) - compare collection by given value.
            Book book1 = new Book("Soldier", 1972, 24.99M, "Michael Piterson", "Piter Jackson");
            Book book2 = new Book("Man os steel", 1997, 42.49M, "Tomas Hanks", "Jeramih Thompson");

            if (book1.Year.CompareTo(book2.Year) < 0)
            {
                Console.WriteLine($"{book1.Title} ({book1.Year}) have more value then {book2.Title} ({book2.Year})");
            }
            else if (book1.Year.CompareTo(book2.Year) > 0)
            {
                Console.WriteLine($"{book2.Title} ({book2.Year}) have more value then {book1.Title} ({book1.Year})");
            }
            else
            {
                Console.WriteLine("Both books got same value!");
            }


            //Compare by other value (price in this case)
            if (book1.CompareTo(book2) > 0)
            {
                Console.WriteLine($"{book1.Title}, ({book1.Price} BGN) is more expensive then {book2.Title}, ({book2.Price} BGN)");
            }
            else if(book1.CompareTo(book2) < 0)
            {
                Console.WriteLine($"{book2.Title}, ({book2.Price} BGN) is more expensive then {book1.Title}, ({book1.Price} BGN)");
            }
            else
            {
                Console.WriteLine("They got same prices.");
            }

            // IComparer class. Sorting collection by given value.
            library.Books.Sort(new ComparerByPrice());

            foreach (var book in library)   
            {
                Console.WriteLine($"Title: {book.Title} - Year: {book.Year} - Price: {book.Price}");
            }
        }
    }
}
