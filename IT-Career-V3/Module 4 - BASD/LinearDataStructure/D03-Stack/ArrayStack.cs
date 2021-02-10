namespace D03_Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayStack<T>
    {
        private readonly List<T> data;
        public ArrayStack()
        {
            this.data = new List<T>();
        }

        public int Count { get => data.Count; }

        public void Push(T element)
        {
            this.data.Add(element);
        }

        public T Pop()
        {
            if (data.Any())
            {
                T num = this.data[data.Count - 1];
                this.data.RemoveAt(data.Count - 1);
                return num;
            }
            throw new Exception("Stack is empty!");
        }

        public T Peek()
        {
            if (data.Any())
            {
                return this.data[data.Count - 1];
            }
            throw new Exception("Stack is empty!");
        }

        public T[] ToArray()
        {
            return data.ToArray();
        }
    }
}
