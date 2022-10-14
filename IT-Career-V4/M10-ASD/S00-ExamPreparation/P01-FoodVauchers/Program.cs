using System;

public class Program
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int money = days * 20;
        int counter = 0;
        while (money > 0)
        {
            if (money >= 100) { money -= 100; }
            else { money -= 20; }
            counter++;
        }
        Console.WriteLine(counter);
    }
}

