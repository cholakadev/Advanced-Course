using System;
using System.Collections.Generic;
using System.Text;

namespace EqualityScale
{
    public class EqualityScale<T>
        where T : IComparable<T>
    {
        public EqualityScale(T first, T second)
        {
            this.First = first;
            this.Second = second;
        }

        public T First { get; }
        public T Second { get; }

        public bool AreEqual()
        {
            return this.First.Equals(this.Second);
        }

        public bool isFirstGreater()
        {
            return this.First.CompareTo(this.Second) > 0;
        }
    }
}
