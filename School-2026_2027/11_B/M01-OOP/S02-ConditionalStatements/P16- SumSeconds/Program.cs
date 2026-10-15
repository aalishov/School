using System;

    public class Program
    {
       public static void Main(string[] args)
        {
            int firsttime = int.Parse(Console.ReadLine());
            int secondtime = int.Parse(Console.ReadLine());
            int thirdtime = int.Parse(Console.ReadLine());

            int totaltime = firsttime + secondtime + thirdtime;
            int minutes = totaltime / 60;
            int seconds = totaltime % 60;

            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }

