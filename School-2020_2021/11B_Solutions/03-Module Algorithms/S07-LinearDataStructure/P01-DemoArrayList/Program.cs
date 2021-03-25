using System;
using System.Collections;
class Program
{
    static void Main()
    {
        //генерични колекции - държат еднотипни елементи
        //негенерични колекции - могат да съдържат елементи от различен тип
        ArrayList list = new ArrayList();
        int number = 15;
        string s = ".NET";
        decimal d = 156.20m;
        list.Add(number);
        list.Add(s);
        list.Add(d);
        list.Insert(1, DateTime.Now);
        Console.WriteLine($"list.Contains(\".NET\") => {list.Contains(".NET")}");

        foreach (var el in list)
        {
            Console.WriteLine($"{el} => {el.GetType()}");
        }
    }
}

