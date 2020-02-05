using System;
using System.Collections;
using System.Collections.Generic;

namespace LibraryTesting2
{
    public class Library : IEnumerable<Book>, IComparable<Library>
    {
        public Library()
        {
            this.Books = new List<Book>();
        }

        public List<Book> Books;

        public void Add(Book book)
        {
            Books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in Books)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int CompareTo(Library other)
        {
            if (this.Books.Count > other.Books.Count)
            {
                return 1;
            }
            else if (this.Books.Count < other.Books.Count)
            {
                return -1;
            }
            else // ==
            {
                return 0;
            }
        }
    }
}
