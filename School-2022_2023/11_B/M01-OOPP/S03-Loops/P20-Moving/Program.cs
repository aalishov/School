using System;

public class Program
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        string input=string.Empty;
        int apartmentSpace = width * length * height;
       
        while ((input=Console.ReadLine())!= "Done")
        {
            int boxes = int.Parse(input);

            if (boxes<apartmentSpace)
            {
                apartmentSpace -= boxes;
            }
            else
            {
                Console.WriteLine($"No more free space! You need {boxes-apartmentSpace} Cubic meters more.");
                break;
            }
        }
        if (input=="Done")
        {
            Console.WriteLine($"{apartmentSpace} Cubic meters left.");
        }

    }
}

