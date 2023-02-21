using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        //List<string> strings = new List<string>() {"one","two","three"};
        //List<double> doubles = MyList.RandomList(20,-5d,5d);
        //Console.WriteLine(MyList.PrintList(doubles, " / "));
        List<int> ints = MyList.RandomList(10, -100, 100);
        Console.WriteLine(MyList.PrintList(ints));
        Console.WriteLine(MyList.GetMaxElement(ints));
        Console.WriteLine(MyList.GetMinElement(ints));
        //List<bool>bools=MyList.RandomBoolList(10) ;
        //Console.WriteLine(MyList.PrintList(bools));
    }
}

