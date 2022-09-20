using System;

public class Program
{
    static void Main(string[] args)
    {
        int groupCount = int.Parse(Console.ReadLine());

        int musala = 0;
        int monblan = 0;
        int kilimandjaro = 0;
        int k2 = 0;
        int everest = 0;

        for (int i = 1; i <= groupCount; i++)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            if (peopleCount <= 5) { musala += peopleCount; }
            else if (peopleCount >= 6 && peopleCount <= 12) { monblan += peopleCount; }
            else if (peopleCount >= 13 && peopleCount <= 25) { kilimandjaro += peopleCount; }
            else if (peopleCount >= 26 && peopleCount <= 40) { k2 += peopleCount; }
            else { everest += peopleCount; }
        }

        double sum = musala + monblan + kilimandjaro + k2 + everest;

        Console.WriteLine($"{musala / sum * 100.0:f2}%");
        Console.WriteLine($"{monblan / sum * 100.0:f2}%");
        Console.WriteLine($"{kilimandjaro / sum * 100.0:f2}%");
        Console.WriteLine($"{k2 / sum * 100.0:f2}%");
        Console.WriteLine($"{everest / sum * 100.0:f2}%");
    }
}
