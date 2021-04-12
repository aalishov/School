using System;

public class Program
{
    static void Main(string[] args)
    {
        MyStack<int> numbers = new MyStack<int>();
        MyStack<string> words = new MyStack<string>();

        words.Push("C#");
        words.Push(".Net");
        words.Push("PHP");
        words.Push("JS");
        Console.WriteLine(words.Pop());
        Console.WriteLine(words.Pop());
        Console.WriteLine(words.Count);
    }
}

