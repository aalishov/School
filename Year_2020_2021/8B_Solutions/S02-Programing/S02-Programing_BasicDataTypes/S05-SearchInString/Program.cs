using System;

class Program
{
    //Търсене на низ в друг низ
    static void Main()
    {
        string line = "В практиката често се налага да извличаме подниз от даден низ.";
        Console.WriteLine($"Брой символи: {line.Length}");

        string find = "да";
        string find2 = "извличаме";
        string notFound = "monday";

        Console.WriteLine(line.IndexOf(find));
        Console.WriteLine(line.LastIndexOf(find));

        Console.WriteLine(line.IndexOf(notFound));
        Console.WriteLine(line.LastIndexOf(notFound));

        Console.WriteLine(line.IndexOf(find2));
        Console.WriteLine(line.LastIndexOf(find2));

    }
}
