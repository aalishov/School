using System;

public class Program
{
    static void Main()
    {
        // тип име = стойност;
        char c1 = 'A';

        string name = "John";
        Console.Write("Enter town: ");
        string town = Console.ReadLine();
        Console.Write("Enter age: ");
        string age = Console.ReadLine();
        string output = $"Name: {name}, town: {town}, age: {age}";
        string output_2 = "Name: " + name + ", town: " + town + ", age: " + age;
        Console.WriteLine(output_2);


        int nameLength = name.Length;
        char nameFirstSymbol = name[0];
        char nameLastSymbol = name[name.Length - 1];
        //Console.WriteLine($"Name length: {nameLength}");
        //Console.WriteLine($"Name first symbol: {nameFirstSymbol}");
        //Console.WriteLine($"Name last symbol: {nameLastSymbol}");
        //Console.WriteLine($"Output length: {output.Length}");

    }
}

