using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static Queue<int> textiles;

    private static Stack<int> medicaments;

    private static Dictionary<string, int> items;

    public static void Main()
    {
        GetMaterials();

        CreateItemsCounter();

        CreateItems();

        Output();
    }

    private static void Output()
    {
        if (!textiles.Any() && !medicaments.Any())
        {
            Console.WriteLine($"Textiles and medicaments are both empty.");
        }
        else if (!textiles.Any())
        {
            Console.WriteLine($"Textiles are empty.");
        }
        else if (!medicaments.Any())
        {
            Console.WriteLine($"Medicaments are empty.");
        }

        foreach (var item in items.Where(x => x.Value != 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        if (medicaments.Any())
        {
            Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
        }

        if (textiles.Any())
        {
            Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
        }
    }

    private static void CreateItems()
    {
        while (textiles.Any() && medicaments.Any())
        {
            int textil = textiles.Dequeue();
            int medicament = medicaments.Pop();
            int sum = textil + medicament;

            if (sum == 30) { items["Patch"]++; }
            else if (sum == 40) { items["Bandage"]++; }
            else if (sum >= 100)
            {
                items["MedKit"]++;
                if (sum - 100 != 0)
                {
                    medicament = medicaments.Pop() + (sum - 100);
                    medicaments.Push(medicament);
                }
            }
            else
            {
                medicament += 10;
                medicaments.Push(medicament);
            }
        }
    }

    private static void GetMaterials()
    {
        textiles = new Queue<int>(ReadNumArray());
        medicaments = new Stack<int>(ReadNumArray());
    }

    private static int[] ReadNumArray()
    {
        return Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
    }

    private static void CreateItemsCounter()
    {
        items = new Dictionary<string, int>();
        items.Add("Patch", 0);
        items.Add("Bandage", 0);
        items.Add("MedKit", 0);
    }
}