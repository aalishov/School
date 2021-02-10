using System;

public class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        bool isFruit = input == "banana" || input == "apple" || input == "kiwi" || input == "cherry" || input == "lemon" || input == "grapes";
        bool isVegetable = input == "tomato" || input == "cucumber" || input == "pepper" || input == "carrot";

        if (isFruit)
        {
            Console.WriteLine("fruit");
        }
        else if (isVegetable)
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }

        //switch (input)
        //{
        //    case "banana":
        //    case "apple":
        //    case "kiwi":
        //    case "cherry":
        //    case "lemon":
        //    case "grapes":
        //        Console.WriteLine("fruit");
        //        break;
        //    case "tomato":
        //    case "cucumber":
        //    case "pepper":
        //    case "carrot":
        //        Console.WriteLine("vegetable");
        //        break;
        //    default:
        //        Console.WriteLine("unknown");
        //        break;
        //}
    }
}

