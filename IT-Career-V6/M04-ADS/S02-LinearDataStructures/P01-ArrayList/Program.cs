using System;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<string> words = new List<string>();
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(3);
        list.Add(1);
        //Console.WriteLine(list.Count);
        //Console.WriteLine(list.Capacity) ;

        MyList<int> myList = new MyList<int>();
        
        myList.Add(10);
        myList.Add(20);
        myList.Add(30);
        myList.Add(40);
        myList.Add(50);
        Console.WriteLine(myList.RemoveAt(4));
        

        Console.WriteLine(myList.Count);

        myList.Clear();
        Console.WriteLine(myList.Count);

        Console.WriteLine(string.Join(", ",myList));
    }
}

