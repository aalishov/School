using System;

class Program
{
    static void Main()
    {
        string product = Console.ReadLine();
        string town = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        double productPrice = 0.0; 

        switch (product)
        {
            case "coffee":
                if (town=="Sofia")
                {
                    productPrice = 0.5;
                }
                else if (town=="Plovdiv")
                {
                    productPrice = 0.4;
                }
                else if (town=="Varna")
                {
                    productPrice = 0.45;
                }
                break;
            case "water":
                switch (town)
                {
                    case "Sofia":
                        productPrice = 0.8;
                        break;
                    case "Plovdiv":
                    case "Varna":
                        productPrice = 0.7;
                        break;
                }
                break;
            case "beer":
                if (town == "Sofia")
                {
                    productPrice = 1.2;
                }
                else if (town == "Plovdiv")
                {
                    productPrice = 1.15;
                }
                else if (town == "Varna")
                {
                    productPrice =1.1;
                }
                break;
            case "sweets":
                if (town == "Sofia")
                {
                    productPrice = 1.45;
                }
                else if (town == "Plovdiv")
                {
                    productPrice = 1.30;
                }
                else if (town == "Varna")
                {
                    productPrice = 1.35;
                }
                break;
            case "peanuts":
                if (town == "Sofia")
                {
                    productPrice = 1.6;
                }
                else if (town == "Plovdiv")
                {
                    productPrice = 1.5;
                }
                else if (town == "Varna")
                {
                    productPrice = 1.55;
                }
                break;
            default:
                break;
        }

        double totalPrice = productPrice * quantity;
        Console.WriteLine(totalPrice);

    }
}

