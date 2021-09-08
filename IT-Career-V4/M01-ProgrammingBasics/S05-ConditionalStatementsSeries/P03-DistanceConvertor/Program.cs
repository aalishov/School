using System;


class Program
{
    static void Main()
    {
        double distance = double.Parse(Console.ReadLine());
        string inputType = Console.ReadLine();
        string outputType = Console.ReadLine();
        double result = 0;

        if (inputType == "m" && outputType == "mm")
        {
            result = distance * 1000;
        }
        else if (inputType == "mm" && outputType == "m")
        {
            result = distance / 1000;
        }
        else if(inputType == "m" && outputType == "cm")
        {
            result = distance * 100;
        }
        else if (inputType == "m" && outputType == "cm")
        {
            result = distance / 100;
        }
        else if (inputType == "km" && outputType == "ft")
        {
            result = distance * 1000* 3.2808399;
        }
        //TODO: Да се довърши

        Console.WriteLine($"{result} {outputType}");
    }
}

