using System;
public class Program
{
    public static void Main()
    {
        int r1 = int.Parse(Console.ReadLine());
        int r2 = int.Parse(Console.ReadLine());
        int r3 = int.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        int hours = 0;
        int capacity = r1 + r2 + r3;
        int c = 0;
        while (students > 0)
        {
            students-=capacity;
            hours++;
            c++;
            if (c==3)
            {
                c = 0;
                hours++;
            }
        }
        Console.WriteLine($"Time needed: {hours}h.");
    }
}

