namespace Library
{
    using System.Collections;
    using System.Collections.Generic;
    public class Library : IEnumerable<Book>
    {
        public Library()
        {
            this.Books = new List<Book>();
        }

        public List<Book> Books { get; private set; }

        public void Add(Book book)
        {
            this.Books.Add(book);
        }

        /* Kогато имаме линейна структура данни, като лист, масив, стек и т.н. , можем да използваме съкратения запис за итерация и да
        избегнем класа LibraryEnumerators. Но когато имаме нелинейна структура данни, като дървета и графи, трабва да имаме този клас,
        за да си разпишем логикато, която искаме да следват.*/
        public IEnumerator<Book> GetEnumerator()
        {
            //for (int currentIndex = 0; currentIndex < this.Books.Count; currentIndex++)
            //{
            //    yield return this.Books[currentIndex];
            //}

            // Или още по-лесно :
            foreach (var item in this.Books)
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
