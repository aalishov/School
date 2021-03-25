using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<object> list = new List<object>();

        int number = 15;
        string s = ".NET";
        decimal d = 156.20m;
        list.Add(number);
        list.Add(s);
        list.Add(d);


        Console.WriteLine(list.Sum(x=>(decimal)x));
    }
}

