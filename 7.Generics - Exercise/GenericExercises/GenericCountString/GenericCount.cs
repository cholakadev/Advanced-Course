namespace GenericCountString
{
    using System;
    using System.Collections.Generic;
    public class GenericCount<T>
        where T : IComparable
    {
        public GenericCount()
        {
            this.Data = new List<T>();
        }

        public List<T> Data { get; set; }

        public int GreaterValuesThan(T targetItem)
        {
            int counter = 0;

            foreach (var value in Data)
            {
                if (value.CompareTo(targetItem) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
