using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
        MyCustomArray list = new MyCustomArray();
        list.Add(1);
        list.Add("one");
        list.Add(true);
        list.Add(DateTime.Now);

        Console.WriteLine(list[2]);
        Console.WriteLine(list[3]);
    }
}

