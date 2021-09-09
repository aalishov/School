namespace P01_Box
{
    using System.Collections.Generic;
    public class Box<T>
    {
        private readonly Stack<T> items;

        public Box()
        {
            this.items = new Stack<T>();
        }

        public int Count { get => this.items.Count; }

        public void Add(T item)
        {
            this.items.Push(item);
        }

        public T Remove()
        {
            return this.items.Pop();
        }
    }
}
