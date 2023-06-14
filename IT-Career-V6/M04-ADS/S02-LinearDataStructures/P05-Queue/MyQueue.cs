using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

//FIFO
public class MyQueue<T>:IEnumerable<T>
{
    private List<T> items = new List<T>();

    public int Count { get { return items.Count; } }

    public void Enqueue(T item)
    {
        items.Add(item);
    }

    public T Dequeue()
    {
        T item = items[0];
        items.RemoveAt(0);
        return item;
    }

    public T Peek()
    {
        return items[0];
    }

    public void Clear()
    {
        items.Clear();
    }

    public T[] ToArray()
    {
        return items.ToArray();
    }

    public bool Contains(T item)
    {
        return items.Contains(item);
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