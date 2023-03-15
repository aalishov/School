using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static Queue<int> coffee;
    private static Stack<int> milk;

    static Coffee cortado = new Coffee("Cortado", 0, 50);
    static Coffee espresso = new Coffee("Espresso", 0, 75);
    static Coffee capuccino = new Coffee("Capuccino", 0, 100);
    static Coffee americano = new Coffee("Americano", 0, 150);
    static Coffee latte = new Coffee("Latte", 0, 200);

    static void Main()
    {
        Input();
        MakeCoffee();
        Output();
    }

    private static void Output()
    {
        if (coffee.Count == 0 && milk.Count == 0)
        {
            Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
        }
        else
        {
            Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
        }

        Console.WriteLine(coffee.Any() ? $"Coffee left: {string.Join(", ", coffee)}" : "Coffee left: none");
        Console.WriteLine(milk.Any() ? $"Milk left: {string.Join(", ", milk)}" : "Milk left: none");

        List<Coffee> coffees = new List<Coffee>() { cortado, espresso, capuccino, americano, latte };

        coffees = coffees.OrderBy(x => x.Count).ThenByDescending(x => x.Name).ToList();
        coffees.Where(x => x.Count != 0).ToList().ForEach(x => Console.WriteLine($"{x.Name}: {x.Count}"));
    }

    private static void MakeCoffee()
    {
        while (coffee.Count != 0 && milk.Count != 0)
        {
            int coffeeElement = coffee.Dequeue();
            int milkElement = milk.Pop();

            int sum = coffeeElement + milkElement;

            if (cortado.Needed == sum) { cortado.Count++; }
            else if (espresso.Needed == sum) { espresso.Count++; }
            else if (capuccino.Needed == sum) { capuccino.Count++; }
            else if (americano.Needed == sum) { americano.Count++; }
            else if (latte.Needed == sum) { latte.Count++; }
            else
            {
                milkElement -= 5;
                milk.Push(milkElement);
            }
        }
    }

    private static void Input()
    {
        coffee = new Queue<int>(ReadArray());
        milk = new Stack<int>(ReadArray());
    }

    private static int[] ReadArray()
    {
        return Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    }
}

public class Coffee
{
    public Coffee(string name, int count, int needed)
    {
        Name = name;
        Count = count;
        Needed = needed;
    }

    public string Name { get; set; }
    public int Count { get; set; }
    public int Needed { get; private set; }

}

