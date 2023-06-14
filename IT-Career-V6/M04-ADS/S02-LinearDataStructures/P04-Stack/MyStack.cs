using System;
using System.Collections;
using System.Collections.Generic;

//LIFO
public class MyStack<T> : IEnumerable<T>
{
    private List<T> items = new List<T>();

    public int Count { get { return items.Count; } }

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        T item = items[Count - 1];
        items.RemoveAt(Count - 1);
        return item;
    }

    public T Peek()
    {
        return items[Count - 1];
    }

    public void Clear()
    {
        items.Clear();
    }

    public bool Contains(T item)
    {
        return items.Contains(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = items.Count - 1; i >= 0; i--)
        {
            yield return items[i];
        }
    }

    public T[] ToArray()
    {
        T[] array = items.ToArray();
        Array.Reverse(array);
        return array;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}