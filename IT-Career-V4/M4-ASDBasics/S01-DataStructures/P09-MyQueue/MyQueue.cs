using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class MyQueue<T>
{
    private List<T> data;

    public MyQueue()
    {
        this.data = new List<T>();
    }

    public int Count { get => this.data.Count; }

    public void Enqueue(T item)
    {
        this.data.Add(item);
    }

    public T Dequeue()
    {
        if (!this.data.Any())
        {
            throw new InvalidOperationException("Stack is empty!");
        }
        T item = this.data[0];
        this.data.RemoveAt(0);
        return item;
    }

    public T Peek()
    {
        if (!this.data.Any())
        {
            throw new InvalidOperationException("Stack is empty!");
        }
        T item = this.data[0];
        return item;
    }

    public void Clear()
    {
        this.data.Clear();
    }

    public T[] ToArray()
    {
        return this.data.ToArray();
    }

    public bool Contains(T item)
    {
        return this.data.Contains(item);
    }
}

