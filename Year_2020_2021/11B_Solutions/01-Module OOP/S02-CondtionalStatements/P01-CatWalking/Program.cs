using System;

class Program
{
    static void Main()
    {
        const int CaloriesPerMinutes = 5;

        //Входни данни
        Console.Write("Enter minutes: ");
        int minutes = int.Parse(Console.ReadLine());
        Console.Write("Enter walks per day: ");
        int walksPerDay = int.Parse(Console.ReadLine());
        Console.Write("Enter calories: ");
        int calories = int.Parse(Console.ReadLine());

        //Изчисления
        int totalTime = minutes * walksPerDay;
        int burnedCalories = totalTime * CaloriesPerMinutes;
        double limit = calories * 0.5;

        //Проверка на условие
        bool isEnaugh = burnedCalories >= limit;

        //Разклонение
        if (isEnaugh)
        {
            //Изход
            Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
        }
        else
        {
            //Изход
            Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
        }
    }
}

