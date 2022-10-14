using System;

public class Program
{
    public static void Main(string[] args)
    {
        Item first = new Item("Pen", 2);
        Item second = new Item("Pen", 10);

        Console.WriteLine(first.CompareTo(second));
    }
}

