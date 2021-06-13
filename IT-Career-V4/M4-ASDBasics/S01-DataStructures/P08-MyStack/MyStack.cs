using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MyStack<T>
{
    private List<T> data;

    public MyStack()
    {
        this.data = new List<T>();
    }

    public int Count { get=>this.data.Count; }

    public void Push(T item)
    {
        this.data.Add(item);
    }

    public T Pop()
    {
        if (!this.data.Any())
        {
            throw new InvalidOperationException("Stack is empty!");
        }
        T item = this.data[this.data.Count - 1];
        this.data.RemoveAt(this.data.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (!this.data.Any())
        {
            throw new InvalidOperationException("Stack is empty!");
        }
        T item = this.data[this.data.Count - 1];
        return item;
    }

    public void Clear()
    {
        this.data.Clear();
    }

    public T[] ToArray()
    {
       return this.data.ToArray().Reverse().ToArray();
    }

    public bool Contains(T item)
    {
        return this.data.Contains(item);
    }
}

