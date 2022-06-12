using System.Collections;

public class ReversedList<T> : IEnumerable<T>
{
    private const int InitialCapacity = 2;
    private T[] elements;

    public ReversedList(int capacity = InitialCapacity)
    {
        this.elements = new T[capacity];
    }
    public int Capacity { get { return this.elements.Length; } }
    public int Count { get; private set; }
    public void Add(T item)
    {
        if (this.Count == this.Capacity)
        {
            //Увеличаване на капацитета
            T[] newData = new T[this.Capacity * 2];
            //Копиране на елементите в новия масив
            for (int i = 0; i < elements.Length; i++)
            {
                newData[i] = elements[i];
            }
            //Смяна на референцията
            this.elements = newData;
        }
        elements[this.Count++] = item;
    }
    //Достъпване на елементите по индекс
    public T this[int index]
    {
        get
        {
            int reversedIndex = this.Count - 1 - index;
            ThrowIndexOutOfRangeException(reversedIndex);
            return elements[reversedIndex];
        }
        set
        {
            int reversedIndex = this.Count - 1 - index;
            ThrowIndexOutOfRangeException(reversedIndex);
            elements[reversedIndex] = value;
        }
    }
    //Премахване по индекс
    public T RemoveAt(int index)
    {
        index = this.Count - 1 - index;

        T item = this[index];

        T[] newData = new T[this.Capacity];
        if (index == 0)
        {
            for (int i = 1; i < this.Count; i++)
            {
                newData[i - 1] = this.elements[i];
            }
        }
        else if (index == this.Count - 1)
        {
            for (int i = 0; i < this.Count - 1; i++)
            {
                newData[i] = this.elements[i];
            }
        }
        else
        {
            for (int i = 0; i < index; i++)
            {
                newData[i] = this.elements[i];
            }
            for (int i = index; i < this.Count - 1; i++)
            {
                newData[i] = this.elements[i + 1];
            }
        }
        this.Count--;
        elements = newData;

        if (this.Count <= this.Capacity / 4)
        {
            T[] copy = new T[this.Capacity / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.elements[i];
            }
            this.elements = copy;
        }
        return item;
    }

    private void ThrowIndexOutOfRangeException(int index)
    {
        if (index >= this.Count)
        {
            throw new IndexOutOfRangeException();
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.Count-1; i >= 0; i--)
        {
            yield return elements[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

