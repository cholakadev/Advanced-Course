namespace CustomStack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class myCustomStack<T> : IEnumerable<T>
    {
        private List<T> myStack;

        public myCustomStack()
        {
            this.myStack = new List<T>();
        }

        public void Push(params T[] elements)
        {
            foreach (var item in elements)
            {
                myStack.Add(item);
            }
        }

        public void Pop()
        {
            if (!myStack.Any())
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            myStack.RemoveAt(myStack.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = myStack.Count - 1; i >= 0; i--)
            {
                yield return myStack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
