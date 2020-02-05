using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;
        private int index;
        public ListyIterator(List<T> list)
        {
            this.collection = list;
            this.index = 0;
        }

        //public void PrintAll()
        //{
        //    for (int i = 0; i < collection.Count; i++)
        //    {
        //        Console.WriteLine(string.Join(", ", collection[]));
        //    }
        //}

        public bool Move()
        {
            if (this.index < collection.Count - 1)
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.index < collection.Count - 1)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (!collection.Any())
            {
                throw new InvalidOperationException("Invalid operation!");
            }

            Console.WriteLine(collection[index]);
        }

        //public T PrintAll(List<T> collection)
        //{

        //}

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in collection)
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
