namespace LibraryTesting2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Book : IComparable<Book>
    {
        public Book(string title, int year, decimal price, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Price = price;
            this.Authors = authors.ToList();
        }
        public string Title { get; private set; }
        public int Year { get; private set; }
        public decimal Price { get; private set; }
        public List<string> Authors { get; private set; }

        public int CompareTo(Book other)
        {
            if (this.Year < other.Year)
            {
                return -1;
            }
            else if (this.Year > other.Year)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
