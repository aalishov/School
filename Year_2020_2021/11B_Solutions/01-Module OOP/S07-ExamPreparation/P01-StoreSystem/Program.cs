namespace P01_StoreSystem
{
    using System;

    public class Program
    {
        public static void Main()
        {
            try
            {
                Store store = new Store("Lidl", "BigShop");

                Food food = new Food("Pizza", 15, 10, 10);
                Drink drink = new Drink("Fanta", 10, 1, 100);
                store.ReceiveProduct(drink);
                store.ReceiveProduct(food);
                store.SellProduct("Fanta", 2);
                store.SellProduct("Pizza", 6);
                store.SellProduct("Fanta", 1);
                Console.WriteLine(store);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
