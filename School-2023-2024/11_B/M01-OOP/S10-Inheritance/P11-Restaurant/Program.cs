namespace P11_Restaurant
{
    public class Program
    {
        private static double liquidQuantity = 0;
        private static double gramsFood = 0;
        private static double priceFinal = 0;
        private static double calories = 0;
        private static List<Product> products = new List<Product>();
        public static void Main()
        {
            CreateOrder();

            PrintOutput();
        }

        private static void CreateOrder()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                if (input[0] == "End")
                {
                    break;
                }
                string type = input[0];
                string name = input[1];
                Product product = null;
                switch (type)
                {
                    case nameof(Coffee):
                        double caffeine = double.Parse(input[2]);
                        product = new Coffee(name, caffeine);
                        liquidQuantity += ((Coffee)product).Mililitres;
                        break;
                    case nameof(Tea):
                        decimal price = decimal.Parse(input[2]);
                        double mililitres = double.Parse(input[3]);
                        product = new Tea(name, price, mililitres);
                        liquidQuantity += mililitres;
                        break;
                    case nameof(Cake):
                        product = new Cake(name);
                        gramsFood += ((Cake)product).Grams;
                        calories += ((Cake)product).Calories;
                        break;
                    case nameof(Fish):
                        price = decimal.Parse(input[2]);
                        product = new Fish(name, price);
                        gramsFood += ((Fish)product).Grams;
                        break;
                    case nameof(Soup):
                        price = decimal.Parse(input[2]);
                        double grams = double.Parse(input[3]);
                        product = new Soup(name, price, grams);
                        gramsFood += grams;
                        break;
                }
                products.Add(product);
            }
        }

        private static void PrintOutput()
        {
            Console.WriteLine($"Your order contains:");
            Console.WriteLine($"\tQuantity of liquids: {liquidQuantity}");
            Console.WriteLine($"\tGrams of food {gramsFood}");
            if (calories != 0)
            {
                Console.WriteLine($"\tCalories {calories}");
            }
            Console.WriteLine($"\tFinal amount {products.Sum(x => x.Price)}");
        }
    }

    public class CopyOfProgram
    {
        private static double liquidQuantity = 0;
        private static double gramsFood = 0;
        private static double priceFinal = 0;
        private static double calories = 0;
        private static List<Product> products = new List<Product>();
        public static void Main()
        {
            CreateOrder();

            PrintOutput();
        }

        private static void CreateOrder()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                if (input[0] == "End")
                {
                    break;
                }
                string type = input[0];
                string name = input[1];
                Product product = null;
                switch (type)
                {
                    case nameof(Coffee):
                        double caffeine = double.Parse(input[2]);
                        product = new Coffee(name, caffeine);
                        liquidQuantity += ((Coffee)product).Mililitres;
                        break;
                    case nameof(Tea):
                        decimal price = decimal.Parse(input[2]);
                        double mililitres = double.Parse(input[3]);
                        product = new Tea(name, price, mililitres);
                        liquidQuantity += mililitres;
                        break;
                    case nameof(Cake):
                        product = new Cake(name);
                        gramsFood += ((Cake)product).Grams;
                        calories += ((Cake)product).Calories;
                        break;
                    case nameof(Fish):
                        price = decimal.Parse(input[2]);
                        product = new Fish(name, price);
                        gramsFood += ((Fish)product).Grams;
                        break;
                    case nameof(Soup):
                        price = decimal.Parse(input[2]);
                        double grams = double.Parse(input[3]);
                        product = new Soup(name, price, grams);
                        gramsFood += grams;
                        break;
                }
                products.Add(product);
            }
        }

        private static void PrintOutput()
        {
            Console.WriteLine($"Your order contains:");
            Console.WriteLine($"\tQuantity of liquids: {liquidQuantity}");
            Console.WriteLine($"\tGrams of food {gramsFood}");
            if (calories != 0)
            {
                Console.WriteLine($"\tCalories {calories}");
            }
            Console.WriteLine($"\tFinal amount {products.Sum(x => x.Price)}");
        }
    }
}