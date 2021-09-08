namespace P05_ReversedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class ReversedList<T> : IEnumerable<T>
    {
        private List<T> items;

        public ReversedList()
        {
            items = new List<T>(2);
        }

        public void Add(T item)
        {
            items.Insert(0, item);
        }

        public int Count { get=>items.Count; }

        public int Capacity { get=>items.Capacity;}

        public T this[int index]
        {
            get
            {
                return this.items[index];
            }
            set
            {
                this.items[index] = value;
            }
        }

        public void RemoveAt(int index)
        {
            this.items.RemoveAt(index);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
