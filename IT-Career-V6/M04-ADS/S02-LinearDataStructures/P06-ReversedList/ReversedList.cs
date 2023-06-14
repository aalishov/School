using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;


public class ReversedList<T>:IEnumerable<T>
{
    private List<T> items = new List<T>(2);

    public void Add(T item)
    {
        items.Add(item);
    }

    public int Count { get { return items.Count; } }

    public int Capacity { get { return items.Capacity; } }

    public T this[int index]
    {
        get { return items[Count-1-index]; }
        set { items[Count - 1 - index] = value; }
    }

    public T RemoveAt(int index)
    {
        T item= items[Count - 1 - index];
        items.RemoveAt(Count-1-index);
        return item;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = items.Count - 1; i >= 0; i--)
        {
            yield return items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

