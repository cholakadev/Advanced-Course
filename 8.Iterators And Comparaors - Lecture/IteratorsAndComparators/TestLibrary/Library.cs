using System.Collections;
using System.Collections.Generic;

namespace TestLibrary
{
    public class Library : IEnumerable<Book>
    {
        public Library()
        {
            this.Authors = new List<Book>();
        }

        public List<Book> Authors = new List<Book>();

        public void Add(Book book)
        {
            this.Authors.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var item in Authors)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
