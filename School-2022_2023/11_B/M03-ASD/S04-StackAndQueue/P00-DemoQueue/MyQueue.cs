using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;


public class MyQueue<T>
{
    private List<T> elements;
    public MyQueue()
    {
        elements = new List<T>();
    }
    public void Enqueue(T item)
    {
        elements.Add(item);
    }
    public T Dequeue()
    {
        T element = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return element;
    }
    public T Peek()
    {
        T element = elements[elements.Count - 1];
        return element;
    }
    public bool Contains(T item)
    {
        return elements.Contains(item);
    }
}

