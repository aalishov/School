using System;

public class Program
{
    public static void Main()
    {
        string s = "Hello World!";
        string result = s.Remove(0, 6);
        //result="World!"
        result = result.Remove(5);
        //result="World"
        Console.WriteLine(result);
    }
}

