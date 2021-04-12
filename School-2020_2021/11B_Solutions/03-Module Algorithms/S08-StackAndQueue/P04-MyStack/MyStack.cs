using System;
using System.Collections.Generic;

public class MyStack<T>
{
    private List<T> elements;

    public int Count { get { return this.elements.Count; } }

    public MyStack()
    {
        elements = new List<T>();
    }

    public void Push(T element)
    {
        this.elements.Add(element);
    }
    public T Pop()
    {
        if (elements.Count <= 0)
        {
            throw new InvalidOperationException("MyStack contains no elements");
        }
        T pop = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return pop;
    }

    public T Peek()
    {
        if (elements.Count <= 0)
        {
            throw new InvalidOperationException("MyStack contains no elements");
        }
        return elements[elements.Count - 1];
    }
    public T[] ToArray()
    {
        return this.elements.ToArray();
    }
}

