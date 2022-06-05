public class MyArrayList<T>
{
    private const int InitialCapacity = 2;

    private T[] data;

    public MyArrayList(int capacity = InitialCapacity)
    {
        this.Capacity = capacity;
        this.data = new T[this.Capacity];
    }
    public int Capacity { get; private set; }
    public int Count { get; private set; }

    public void Add(T item)
    {
        if (this.Count == this.Capacity)
        {
            //Увеличаване на капацитета
            this.Capacity *= 2;
            T[] newData = new T[this.Capacity];
            //Копиране на елементите в новия масив
            Array.Copy(this.data, newData, this.data.Length);
            //Смяна на референцията
            this.data = newData;
        }
        data[this.Count++] = item;
    }

    public T this[int index]
    {
        get
        {
            ThrowIndexOutOfRangeException(index);
            return data[index];
        }
        set
        {
            ThrowIndexOutOfRangeException(index);
            data[index] = value;
        }
    }

    public T RemoveAt(int index)
    {
        T item = this[index];

        T[] newData = new T[this.Capacity];
        if (index == 0)
        {
            for (int i = 1; i < this.Count; i++)
            {
                newData[i - 1] = this.data[i];
            }
        }
        else if (index == this.Count - 1)
        {
            for (int i = 0; i < this.Count - 1; i++)
            {
                newData[i] = this.data[i];
            }
        }
        else
        {
            for (int i = 0; i < index; i++)
            {
                newData[i] = this.data[i];
            }
            for (int i = index; i < this.Count-1; i++)
            {
                newData[i]=this.data[i+1];
            }
        }
        this.Count--;
        data = newData;
        return item;
    }

    private void ThrowIndexOutOfRangeException(int index)
    {
        if (index >= this.Count)
        {
            throw new IndexOutOfRangeException();
        }
    }

    public void Print()
    {
        Console.WriteLine(String.Join(", ", data));
    }
}


