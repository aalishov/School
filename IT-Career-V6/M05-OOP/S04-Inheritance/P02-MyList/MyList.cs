using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyList<T> : List<T>
{

    public string GetReversedElement()
    {
        List<T> list = this;
        list.Reverse();
        return string.Join(", ",list);
    }

    public T GetRandomItem()
    {
        Random random= new Random();
        int index=random.Next(0,this.Count);
        return this[index];
    }
}

