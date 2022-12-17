using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static void Main()
    {
        List<Food> food = new List<Food>();
        List<Beverage> beverages = new List<Beverage>();
        double calories = 0;
        bool containsCake=false;
        while (true)
        {
            string[] data = Console.ReadLine().Split(' ');
            if (data[0]=="End")
            {
                break;
            }
            Product p = null;
            switch (data[0])
            {
                
                case "Coffee":
                    Beverage b = new Coffee(data[1], double.Parse(data[2]));
                    beverages.Add(b);
                    break;
                case "Tea":
                    Tea t = new Tea(data[1], decimal.Parse(data[2]), double.Parse(data[3]));
                    beverages.Add(t);
                    break;
                case "Fish":
                    Fish f = new Fish(data[1], decimal.Parse(data[2]));
                    food.Add(f);
                    break;
                case "Soup":
                    Soup s  = new Soup(data[1], decimal.Parse(data[2]), double.Parse(data[3]));
                    food.Add(s);
                    break;
                case "Cake":
                    Cake c = new Cake(data[1]);
                    calories += c.Calories;
                    containsCake = true;
                    food.Add(c);
                    break;
            }
        }
        double bM = beverages.Sum(x => x.Milliliters);
        double fG = food.Sum(x => x.Grams);
        if (containsCake)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Your order contains:");
            sb.AppendLine($"\tQuantity of liquids: {bM}");
            sb.AppendLine($"\tGrams of food {fG}");
            sb.AppendLine($"\tCalories {calories}");
            sb.AppendLine($"\tFinal amount {bM+fG}");
        }
        else if(containsCake)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Your order contains:");
            sb.AppendLine($"\tQuantity of liquids: {bM}");
            sb.AppendLine($"\tGrams of food {fG}");
            sb.AppendLine($"\tFinal amount {bM + fG}");
        }
    }
}