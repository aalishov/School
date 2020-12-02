using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> idCards = new Dictionary<string, string>();
        idCards.Add("Pesho", "654512");
        idCards.Add("Ivan", "674512");
        idCards.Add("Gosho", "657512");

        bool isRemoved = idCards.Remove("Ivan"); //Премахва елемент по ключ
        Console.WriteLine(isRemoved);


        if (idCards.ContainsKey("Ivan")) //Проверява дали съществува ключ
        {
            Console.WriteLine(idCards["Ivan"]);
            string[] names = new string[] { "Ivan", "Pesho" };
        }
        else
        {
            Console.WriteLine("Ivan not found!");
        }

        Dictionary<string, List<string>> daysWithColor = new Dictionary<string, List<string>>();

        daysWithColor.Add("Monday", new List<string>() { "Red","Big Day", "Sunny Day" });
        daysWithColor.Add("Sunday", new List<string>() {  "Black","My Birthday"});

        foreach (var item in daysWithColor)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {string.Join(" - ", item.Value)}");
        }

    }
}

