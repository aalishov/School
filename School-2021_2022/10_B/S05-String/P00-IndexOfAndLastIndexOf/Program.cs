using System;


class Program
{
    static void Main(string[] args)
    {
        string s = "Velingrad asdgradjaksdj grad";
        string search = "grad";

        int indexOf = s.IndexOf(search,6);
        int indexLastOf = s.LastIndexOf(search);

        Console.WriteLine(indexOf);
        Console.WriteLine(indexLastOf);
    }
}

