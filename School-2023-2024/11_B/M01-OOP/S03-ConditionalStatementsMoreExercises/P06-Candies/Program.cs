namespace P06_Candies
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string candyColor = Console.ReadLine();
            string boxSize = Console.ReadLine();

            int numBoxes = int.Parse(Console.ReadLine());
            double price = 0;

            switch (candyColor)
            {
                case "Red":
                    switch (boxSize)
                    {
                        case "Small":
                            price = 1.50;
                                break;
                        case "Medium":
                            price = 2.20;
                            break;
                        case "Large":
                            price = 3.70;
                            break;
                    }
                    break;

                case "Blue":
                    switch (boxSize)
                    {
                        case "Small":
                            price = 1.30;
                            break;
                        case "Medium":
                            price = 1.80;
                            break;
                        case "Large":
                            price = 2.10;
                            break;
                    }
                    break;

                case "Green":
                    switch (boxSize)
                    {
                        case "Small":
                            price = 2.50;
                            break;
                        case "Medium":
                            price = 3.60;
                            break;
                        case "Large":
                            price = 5.20;
                            break;
                    }
                    break;

                    
            }
             if(boxSize == "Medium")
            {
                price *= 0.95;
            }
             else if(boxSize == "Large" && candyColor == "Green" && numBoxes >= 5)
            {
                price *= 0.75;
            }

             double totalPrice = price * numBoxes;
            if(totalPrice > 30)
            {
                totalPrice *= 0.90;
            }
            Console.WriteLine($"You bought {numBoxes} boxes of {candyColor} candy for {totalPrice:F2}lv.");
            
        }
    }
}