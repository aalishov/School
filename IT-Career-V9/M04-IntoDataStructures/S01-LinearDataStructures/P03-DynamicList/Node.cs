using System;
using System.Collections.Generic;
using System.Text;

public class Node<T>
{
    private T element;
    private Node<T> next;

    public Node(T element)
    {
        Element = element;
        Next = null;
    }

    public Node(T element, Node<T> prevNode)
    {
        Element = element;
        prevNode.Next = this;
    }

    public T Element
    {
        get { return element; }
        set { element = value; }
    }

    public Node<T> Next
    {
        get { return next; }
        set { next = value; }
    }
}

