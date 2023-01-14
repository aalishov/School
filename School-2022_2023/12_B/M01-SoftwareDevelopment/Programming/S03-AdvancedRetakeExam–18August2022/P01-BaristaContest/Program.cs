using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Queue<int> coffee = new Queue<int>(ReadList());
        Stack<int> milk = new Stack<int>(ReadList());
        Dictionary<string, int> coffeCollection = new Dictionary<string, int>();
        coffeCollection.Add("Cortado", 0);
        coffeCollection.Add("Espresso", 0);
        coffeCollection.Add("Capuccino", 0);
        coffeCollection.Add("Americano", 0);
        coffeCollection.Add("Latte", 0);

        while (coffee.Count > 0 && milk.Count > 0)
        {
            int peekCoffe = coffee.Dequeue();
            int peekMilk = milk.Pop();
            int sum = peekCoffe + peekMilk;
            if (sum == 50) { coffeCollection["Cortado"]++; }
            else if (sum == 75) { coffeCollection["Espresso"]++; }
            else if (sum == 100) { coffeCollection["Capuccino"]++; }
            else if (sum == 150) { coffeCollection["Americano"]++; }
            else if (sum == 200) { coffeCollection["Latte"]++; }
            else { milk.Push(peekMilk - 5); }

        }
        if (coffee.Count == 0 && milk.Count == 0)
        {
            Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
        }
        else
        {
            Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
        }
        if (coffee.Count == 0)
        {
            Console.WriteLine("Coffee left: none");
        }
        else
        {
            Console.WriteLine($"Coffee left: {string.Join(", ", coffee)}");
        }
        if (milk.Count == 0)
        {
            Console.WriteLine("Milk left: none");
        }
        else
        {
            Console.WriteLine($"Milk left: {string.Join(", ", milk)}");
        }
        coffeCollection = coffeCollection
            .Where(x => x.Value != 0)
            .OrderBy(x => x.Value)
            .ThenByDescending(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);
        foreach (var item in coffeCollection)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    private static List<int> ReadList()
    {
        return Console.ReadLine().Split(", ").Select(int.Parse).ToList();
    }
}

