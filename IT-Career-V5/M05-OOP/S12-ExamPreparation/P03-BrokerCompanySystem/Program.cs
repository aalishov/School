using System;

public class Program
{
    static void Main(string[] args)
    {
        string result = "Sun Hotel";
        int index = result.Length - ("Hotel").Length ;
        Console.WriteLine(result.IndexOf("Hotel",index));
    }
}

