using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class MyCustomArray : IEnumerable<object>
{
    object[] items;

    public MyCustomArray()
    {
        Capacity = 4;
        items = new object[Capacity];
    }

    public int Count { get; private set; }

    public int Capacity { get; private set; }

    public object this[int index]
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

    public void Add(object item)
    {
        if (Count == Capacity)
        {
            Capacity *= 2;
            object[] newItems = new object[Capacity];

            for (int i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }
            items = newItems;
        }
        items[Count] = item;
        Count++;
    }

    public object RemoveAt(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new ArgumentOutOfRangeException();
        }
        object item = items[index];
        for (int i = index; i < Count - 1; i++)
        {
            items[i] = items[i + 1];
        }
        items[Count - 1] = default;
        Count--;
        return item;
    }

    public void Clear()
    {
        items = new object[Capacity];
        Count = 0;
    }

    public IEnumerator<object> GetEnumerator()
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

