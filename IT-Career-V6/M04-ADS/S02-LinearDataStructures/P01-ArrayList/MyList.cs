using System;
using System.Collections;
using System.Collections.Generic;

public class MyList<T> : IEnumerable<T>
{
    private T[] items;

    public MyList()
    {
        Capacity = 4;
        items = new T[Capacity];
    }

    public int Count { get; private set; }

    public int Capacity { get; private set; }

    public T this[int index]
    {
        get
        {
            if (index >= Count)
            {
                throw new ArgumentOutOfRangeException("Invalid index!");
            }
            return items[index];
        }
        set
        {
            if (index >= Count)
            {
                throw new ArgumentOutOfRangeException("Invalid index!");
            }
            items[index] = value;
        }
    }

    public void Add(T item)
    {
        if (Count == Capacity)
        {
            Capacity *= 2;
            T[] newItems = new T[Capacity];

            for (int i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }
            items = newItems;
        }
        items[Count] = item;
        Count++;
    }

    public T RemoveAt(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new ArgumentOutOfRangeException();
        }
        T item = items[index];
        for (int i = index; i < Count - 1; i++)
        {
            items[i] = items[i + 1];
        }
        items[Count - 1] = default(T);
        Count--;
        return item;
    }

    public void Clear()
    {
        items = new T[Capacity];
        Count = 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

