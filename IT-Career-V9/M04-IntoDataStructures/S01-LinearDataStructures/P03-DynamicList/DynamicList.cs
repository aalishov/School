using System;
using System.Collections.Generic;
using System.Text;

public class DynamicList<T>
{
    private Node<T> head;
    private Node<T> tail;
    private int count;

    public int Count
    {
        get { return count; }
        private set { count = value; }
    }

    public DynamicList()
    {
        head = null;
        tail = null;
        Count = 0;
    }

    public void Add(T element)
    {
        if (head == null)
        {
            head = new Node<T>(element);
            tail = head;
        }
        else
        {
            tail.Next = new Node<T>(element);
            tail = tail.Next;
        }
        Count++;
    }

    public T Remove(int index)
    {
        T element = default(T);
        Node<T> current = head;
        Node<T> previous = null;
        int i = 0;
        while (current != null)
        {
            if (i == index)
            {
                element = current.Element;
                previous.Next = current.Next;
                break;
            }
            previous = current;
            current = current.Next;
            i++;
        }
        return element;
    }

    public int Remove(T element)
    {
        int index = 0;
        Node<T> current = head;
        while (current != null)
        {
            if (current.Element.Equals(element))
            {
                Remove(index);
                return index;
            }
            index++;
            current = current.Next;
        }
        return -1;
    }

    public bool Contains(T element)
    {
        Node<T> current = head;
        while (current != null)
        {
            if (current.Element.Equals(element))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public object this[int index]
    {
        get
        {
            Node<T> current = head;
            int i = 0;
            while (current != null)
            {
                if (i == index)
                {
                    return current.Element;
                }
                current = current.Next;
                i++;
            }
            throw new IndexOutOfRangeException();
        }
        set
        {
            Node<T> current = head;
            int i = 0;
            while (current != null)
            {
              if (i == index)
                {
                    current.Element = (T)value;
                    return;
                }
                current = current.Next;
                i++;
            }
            throw new IndexOutOfRangeException();
        }
    }

}