using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        List<T> data;
        T element;
        public Box(T element)
        {
            this.element = Element;
            this.data = new List<T>();
        }

        T Element { get; set; }

        public int Count => this.data.Count;

        public void Add(T item)
        {
            // Adds and element on the top of the list.
            this.data.Add(item);
        }

        public T Remove()
        {
            var remove = this.data.Last();
            this.data.RemoveAt(this.data.Count - 1);
            return remove;
        }
    }
}
