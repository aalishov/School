using System;
using System.Collections.Generic;
using System.Text;

namespace P05_MyQueue
{
    public class MyQueue<T>
    {
        private List<T> elements;
        public int Count { get { return this.elements.Count; } }
        public MyQueue()
        {
            elements = new List<T>();
        }
        public void Enqueue(T element)
        {
            this.elements.Add(element);
        }
        public T Dequeue()
        {
            if (elements.Count <= 0)
            {
                throw new InvalidOperationException("CircularQueue contains no elements");
            }
            T dequeue = elements[0];
            elements.RemoveAt(0);
            return dequeue;
        }
        public T Peek()
        {
            if (elements.Count <= 0)
            {
                throw new InvalidOperationException("CircularQueue contains no elements");
            }
            return elements[elements.Count - 1];
        }
        public T[] ToArray()
        {
            return this.elements.ToArray();
        }
    }
}
