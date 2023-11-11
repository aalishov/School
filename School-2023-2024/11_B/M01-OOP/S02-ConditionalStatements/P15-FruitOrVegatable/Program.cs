namespace P15_FruitOrVegatable
{
    using System;
    public class Program
    {
        public  static void Main(string[] args)
        {
           string food = Console.ReadLine();
            switch (food)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}