using System;
using System.Collections.Generic;

public class Program
{
    private static Dictionary<string, Person> people = new Dictionary<string, Person>();
    private static Dictionary<string, Product> products = new Dictionary<string, Product>();
    public static void Main()
    {
        ReadPeopleInfo();
        ReadProductsInfo();
        Shoping();
        Output();
    }

    private static void Output()
    {
        foreach (var person in people)
        {
            Console.WriteLine(person.Value);
        }
    }

    private static void Shoping()
    {
        while (true)
        {
            string[] cmd = Console.ReadLine().Split(' ');
            string name = cmd[0];
            if (name == "END")
            {
                break;
            }
            string product = cmd[1];
            if (people.ContainsKey(name) && products.ContainsKey(product))
            {
                string result = people[name].AddProduct(products[product]);
                Console.WriteLine(result);
            }
        }
    }

    private static void ReadProductsInfo()
    {
        string[] productsInfo = ReadInfo();
        foreach (var pInfo in productsInfo)
        {
            string[] productInfo = pInfo.Split('=', StringSplitOptions.RemoveEmptyEntries);
            string name = productInfo[0];
            double cost = double.Parse(productInfo[1]);
            if (!products.ContainsKey(name))
            {
                products.Add(name, new Product(name, cost));
            }
            else
            {
                products[name].Cost = cost;
            }
        }
    }

    private static void ReadPeopleInfo()
    {
        string[] peopleInfo = ReadInfo();
        foreach (var pInfo in peopleInfo)
        {
            string[] personInfo = pInfo.Split('=', StringSplitOptions.RemoveEmptyEntries);
            string name = personInfo[0];
            double money = double.Parse(personInfo[1]);
            if (!people.ContainsKey(name))
            {
                people.Add(name, new Person(name, money));
            }
            else
            {
                people[name].Money += money;
            }
        }
    }

    private static string[] ReadInfo()
    {
        return Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
    }
}

