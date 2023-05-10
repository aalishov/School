using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P00_IEnumerable
{
    public class MyStrangeCollection<T>:IEnumerable<T>
    {
        private readonly List<T> items;

        public MyStrangeCollection()
        {
            this.items = new List<T>();
        }

        public void Add(T item)
        {
            if (items.Count%2==0)
            {
                items.Add(item);
            }
            else
            {
                items.Insert(0,item);
            }
        }



        public T GetFirstItem()
        {
            if (!items.Any())
            {
                throw new InvalidOperationException(nameof(GetFirstItem));
            }
            return items[0];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
