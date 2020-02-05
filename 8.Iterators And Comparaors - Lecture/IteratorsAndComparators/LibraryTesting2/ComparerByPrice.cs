using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTesting2
{
    class ComparerByPrice : IComparer<Book>
    {
        public int Compare(Book book1, Book book2)
        {
            if (book1.Price > book2.Price)
            {
                return 1;
            }
            else if (book1.Price < book2.Price)
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
