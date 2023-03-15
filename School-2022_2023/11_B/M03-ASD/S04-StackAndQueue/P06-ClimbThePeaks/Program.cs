using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static Stack<int> foodPortions;
    private static Queue<int> dailyStamina;

    static int vihren = 80;
    static int kutelo = 90;
    static int banskiSuhodol = 100;
    static int polezhan = 60;
    static int kamenitza = 70;

    private static List<string> peeks = new List<string>();
    public static void Main()
    {
        Input();
        Climbing();
        Output();
    }

    private static void Climbing()
    {
        for (int i = 0; i < 7; i++)
        {
            int sum = foodPortions.Pop() + dailyStamina.Dequeue();
            if (sum >= vihren)
            {
                vihren = int.MaxValue;
                peeks.Add("Vihren");
            }
            else if (sum >= kutelo && peeks.Count == 1)
            {
                kutelo = int.MaxValue;
                peeks.Add("Kutelo");
            }
            else if (sum >= banskiSuhodol && peeks.Count == 2)
            {
                banskiSuhodol = int.MaxValue;
                peeks.Add("Banski Suhodol");
            }
            else if (sum >= polezhan && peeks.Count == 3)
            {
                polezhan = int.MaxValue;
                peeks.Add("Polezhan");
            }
            else if (sum >= kamenitza && peeks.Count == 4)
            {
                kamenitza = int.MaxValue;
                peeks.Add("Kamenitza");
            }
        }
    }
    private static void Output()
    {
        if (peeks.Count == 5)
        {
            Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");

        }
        else
        {
            Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
        }
        if (peeks.Any())
        {
            Console.WriteLine("Conquered peaks:");
            peeks.ForEach(x => Console.WriteLine(x));
        }
    }

    private static void Input()
    {
        foodPortions = new Stack<int>(ReadElements());
        dailyStamina = new Queue<int>(ReadElements());
    }

    private static int[] ReadElements()
    {
        return Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    }
}
