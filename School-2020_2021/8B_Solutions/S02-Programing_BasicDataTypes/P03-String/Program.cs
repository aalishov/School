using System;

class Program
{
    static void Main()
    {
        // string - низ, текст

        string model = "Samsung";

        //Достъп до символите
        char firstLetter = model[0];
        char afterFirstLetter = model[1];


        //име_на_променлива.Length - връща броя на симоволите
        Console.WriteLine($"Дължина(брой символи): {model.Length}");
        Console.WriteLine(firstLetter);
        Console.WriteLine(afterFirstLetter);


        string s1 = "first";
        string s2 = "number";

        // + конкатенация (сливане) - слепване на низове
        string result = s1 +' '+ s2;
        Console.WriteLine($"{result} - {result.Length}");
    }
}

