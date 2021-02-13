using System;

class Program
{
    static void Main()
    {
        double wholeArea = double.Parse(Console.ReadLine());
        double grapeForOneMeter = double.Parse(Console.ReadLine());
        double litresWine = double.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double totalGrape = grapeForOneMeter * wholeArea;
        double wine = 0.4 * totalGrape / 2.5;


        if (wine >= litresWine)
        {
            double leftWine = wine - litresWine;
            Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
            Console.WriteLine($"{Math.Ceiling(leftWine)} liters left -> {Math.Ceiling(leftWine / workers)} liters per person.");
        }
        else 
        {
            double neededLiters = litresWine - wine;
            Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLiters)} liters wine needed.");
        }
    }
}