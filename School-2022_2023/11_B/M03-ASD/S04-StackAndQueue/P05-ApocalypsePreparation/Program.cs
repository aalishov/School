using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

public class Program
{

    const int Patch = 30;
    const int Bandage = 40;
    const int MedKit = 100;
    static void Main()
    {
        List<int> queqeTextiles = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> stackMedicaments = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int patchCount = 0;
        int bandageCount = 0;
        int medKitCount = 0;

        Queue<int> textiles = new Queue<int>(queqeTextiles);
        Stack<int> medicaments = new Stack<int>(stackMedicaments);

        int sumOfRemoved = 0;

        while (textiles.Any() && medicaments.Any())
        {
            int removedTextile = textiles.Dequeue();
            int removedMedicament = medicaments.Pop();

            sumOfRemoved += removedTextile + removedMedicament;
            switch (sumOfRemoved)
            {
                case Patch:
                    patchCount++;
                    sumOfRemoved = 0;
                    break;
                case Bandage:
                    bandageCount++;
                    sumOfRemoved = 0;
                    break;
                case MedKit:
                    medKitCount++;
                    sumOfRemoved = 0;
                    break;
                default:
                    if (sumOfRemoved>100)
                    {
                        medKitCount++;
                        sumOfRemoved -= 100;
                    }
                    else
                    {
                        medicaments.Push(removedMedicament + 10);
                    }
                    break;
            }
            
        }

        if (!textiles.Any() &&medicaments.Any())
        {
            Console.WriteLine("Textiles are empty.");

        }

        if (!medicaments.Any()&&textiles.Any())
        {
            Console.WriteLine("Medicaments are empty.");
        }

        if (!textiles.Any() && !medicaments.Any())
        {
            Console.WriteLine("Textiles and medicaments are both empty.");
        }
        if (patchCount != 0)
        {
            Console.WriteLine($"Pachtes - {patchCount}");
        }
        if (bandageCount != 0)
        {
            Console.WriteLine($"Bandages - {bandageCount}");
        }
        if (medKitCount != 0)
        {
            Console.WriteLine($"MedKits - {medKitCount}");
        }
        if (medicaments.Any())
        {
            Console.WriteLine($"Medicaments left: {string.Join(",", medicaments)}");
        }
        if (textiles.Any())
        {
            Console.WriteLine($"Textiles left: {string.Join(",", textiles)}");
        }
    }
}

