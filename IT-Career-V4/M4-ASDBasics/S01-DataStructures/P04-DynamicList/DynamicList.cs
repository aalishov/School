namespace P04_DynamicList
{
    using System;

    public class DynamicList
    {
        private Node head;
        private Node tail;

        // Брой
        private int count;
        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        // Конструктор
        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        // Добавяне
        public void Add(object item)
        {
            if (this.head == null)
            {
                // Първи елемент
                Node next = new Node(item);
                this.head = next;
                this.tail = next;
            }
            else
            {
                // Всеки следващ елемент
                Node next = new Node(item, tail);
                this.tail = next;
            }
            this.count++;
        }

        //Връщане на индекс на елемент
        public int IndexOf(object item)
        {
            Node current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Element.Equals(item)) return index;
                index++;
                current = current.Next;
            }
            return -1; // Not Found
        }

        // Премахване
        public object Remove(int index)
        {
            Object item = null;
            Node current = head;
            Node previous = null;
            int i = 0;
            while (current != null)
            {
                if (index == i)
                {
                    item = current.Element;
                    previous.Next = current.Next;
                    break;
                }
                i++;
                previous = current;
                current = current.Next;
            }
            return item;
        }

        // Премахване
        public int Remove(object item)
        {
            int index = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Element.Equals(item))
                {
                    Remove(index);
                    return index;
                }
                index++;
                current = current.Next;
            }
            return -1; // Not Found
        }

        // Съдържа ли се
        public bool Contains(object item)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Element.Equals(item)) return true;
                current = current.Next;
            }
            return false;
        }

        // Достъпване до елементите
        public object this[int index]
        {
            get
            {
                Node current = head;
                int i = 0;
                while (current != null)
                {
                    if (i == index) return current.Element;
                    i++;
                    current = current.Next;
                }
                return null; // Not Found
            }
            set
            {
                Node current = head;
                int i = 0;
                while (current != null)
                {
                    if (i == index)
                    {
                        current.Element = value;
                        break;
                    }
                    i++;
                    current = current.Next;
                }
            }
        }

    }
}