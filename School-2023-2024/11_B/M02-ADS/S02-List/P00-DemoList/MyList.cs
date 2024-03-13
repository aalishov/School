using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace P00_Demo
{
    public class MyList<T>
    {
        private T[] items;

        public MyList()
        {
            items = new T[4];
        }

        public int Capacity { get { return items.Length; } }

        public int Count { get; private set; }

        public void Add(T item)
        {
            if (Count == Capacity)
            {
                T[] newItems = new T[items.Length * 2];
                Array.Copy(items, newItems, items.Length);
                items = newItems;
            }
            items[Count] = item;
            Count++;
        }
        
        public void Remove(T item) { }
    }
}
