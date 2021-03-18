using System;

class Program
{
    static void Main(string[] args)
    {
        string path = Console.ReadLine();
        int slashIndex = path.LastIndexOf(@"\");
        string[] fileInfo = path.Substring(slashIndex+1).Split('.');
        Console.WriteLine($"File name: {fileInfo[0]}");
        Console.WriteLine($"File extension: {fileInfo[1]}");
    }
}

