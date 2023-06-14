using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        HashSet<int> set = new HashSet<int>();

        set.Add(6);
        set.Add(2);
        set.Add(7);
        set.Add(7);
        set.Add(4);

        Console.WriteLine(string.Join(", ", set));
    }
}

