namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ListyIterator<T>
    {
        private List<T> collection;
        private int index;
        public ListyIterator(List<T> list)
        {
            this.collection = list;
            this.index = 0;
        }

        public bool Move()
        {
            if (this.index < collection.Count - 1)
            {
                index++;
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

            Console.WriteLine(this.collection[index]);
        }

        public bool HasNext()
        {
            if (this.index < collection.Count - 1)
            {
                return true;
            }

            return false;
        }
    }
}
