using System;

class Program
{
    //Ctrl+K+D - подравняване на кода
    static void Main()
    {
        string fName = Console.ReadLine();
        string lName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string town = Console.ReadLine();

        Console.WriteLine($"You are {fName} {lName}, a {age}-years old person from {town}.");
    }
}

