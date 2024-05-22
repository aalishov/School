using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Queue<int> liquids = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
        Stack<int> ingrediants = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
        int bread = 0;
        int cake = 0;
        int pastry = 0;
        int fruitPie = 0;
        while (liquids.Count > 0 && ingrediants.Count>0)
        {
            int liquid = liquids.Dequeue();
            int ingrediant = ingrediants.Pop();
            int sum = liquid + ingrediant;  
            if (sum == 25)
            {
                bread++;
            }
            else if (sum == 50)
            {
                cake++;
            }
            else if (sum ==75)
            {
                pastry++;
            }
            else if (sum ==100)
            {
                fruitPie++;
            }
            else
            {
                ingrediant += 3;
                ingrediants.Push(ingrediant);
            }
        }
        if (bread >0 && cake >0 && pastry>0 && fruitPie>0)
        {
            Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
        }
        else
        {
            Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
        }
        if(liquids.Count > 0)
        {
            Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
        }
        else { Console.WriteLine("Liquids left: none"); }
        if (ingrediants.Count >0)
        {
            Console.WriteLine($"Ingredients left: {string.Join(", ", ingrediants)}");
        }
        else
        {
            Console.WriteLine("Ingredients left: none");
        }
        Console.WriteLine($"Bread: {bread}");
        Console.WriteLine($"Cake: {cake}");
        Console.WriteLine($"Fruit Pie: {fruitPie}");
        Console.WriteLine($"Pastry: {pastry}");
    }
}

