using System;

public class Program
{
    static void Main()
    {
        RandomList<int> list = new RandomList<int>();
        list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        Console.WriteLine(list.RandomString());
        Console.WriteLine(list.RandomString());
        Console.WriteLine(list.RandomString());
        Console.WriteLine(String.Join(", ",list));
    }
}

