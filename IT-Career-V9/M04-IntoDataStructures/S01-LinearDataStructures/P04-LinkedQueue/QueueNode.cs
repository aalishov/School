using System;
using System.Collections.Generic;
using System.Text;

public class QueueNode<T>
{
    public T Value { get; private set; }

    public QueueNode<T> Next { get; set; }

    public QueueNode<T> Prev { get; set; }

    public QueueNode(T value)
    {
        this.Value = value;
    }
}

