using System;

public class Program
{
    //Ctrl+F5 - Start
    //Ctrl + K + D
    //https://judge.softuni.org/Contests/Practice/Index/2275#0
    public static void Main()
    {
        double rent = double.Parse(Console.ReadLine());
        double cake = rent * 0.2;
        double drinks = cake * 0.55;
        double animator = rent / 3.0;
        double total = rent + cake + drinks + animator;
        Console.WriteLine(total);
    }
}

