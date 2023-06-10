using System;
using System.Collections.Generic;
using System.Text;


public class LinkedList<T>
{
    public Node<T> Head { get; private set; }

    public Node<T> Tail { get; private set; }

    public int Count { get; private set; }

    public void AddLast(T item)
    {
        Node<T> newNode = new Node<T>(item);
        if (Count == 0)
        {
            
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }
        Count++;
    }

    public void AddFirst(T item)
    {
        Node<T> newNode = new Node<T>(item);

        if (Count == 0)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head.Previous = newNode;
            Head= newNode;
        }
        Count++;
    }
}

