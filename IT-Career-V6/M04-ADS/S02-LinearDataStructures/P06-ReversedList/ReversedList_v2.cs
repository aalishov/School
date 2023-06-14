using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class ReversedList_v2<T> : IEnumerable<T>
{
    private List<T> items = new List<T>(2);

    public void Add(T item)
    {
        items.Insert(0, item);
    }

    public int Count { get { return items.Count; } }

    public int Capacity { get { return items.Capacity; } }

    public T this[int index]
    {
        get { return items[index]; }
        set { items[index] = value; }
    }

    public T RemoveAt(int index)
    {
        T item = items[index];
        items.RemoveAt(index);
        return item;
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

