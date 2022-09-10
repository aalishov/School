using System;
using System.Collections.Generic;
using System.Text;

public class RandomList<T> : List<T>
{

    public string RandomString()
    {
        Random random = new Random();
        int index = random.Next(0, base.Count - 1);
        T item = base[index];
        base.RemoveAt(index);
        return item.ToString();
    }
}

