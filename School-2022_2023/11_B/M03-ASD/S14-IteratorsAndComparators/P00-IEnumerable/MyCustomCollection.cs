using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P00_IEnumerable
{
    public class MyCustomCollection<T>:IEnumerable<T>
    {
        private readonly List<T> items;

        public MyCustomCollection()
        {
            this.items = new List<T>();
        }

        public void Add(T item)
        {
            Random random= new Random();
            items.Insert(random.Next(0,items.Count),item);
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
