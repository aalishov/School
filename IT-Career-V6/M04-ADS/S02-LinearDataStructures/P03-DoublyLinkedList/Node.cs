using System;
using System.Collections.Generic;
using System.Text;

public class Node<T>
{
    public Node(T value)
    {
        Value = value;
        Previous = null;
        Next = null;
    }

    public T Value { get; set; }

    public Node<T> Previous { get; set; }

    public Node<T> Next { get; set; }
}