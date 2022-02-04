using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_ShoppingSpree
{
    public class Program
    {
        static List<Person> people = new List<Person>();
        static List<Product> products = new List<Product>();
        public static void Main()
        {
            try
            {
                CreatePeople();

                CreateProducts();

                Shoping();

                people.ForEach(x => Console.WriteLine(x));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void Shoping()
        {
            string cmd = string.Empty;

            while ((cmd = Console.ReadLine()) != "END")
            {
                string[] input = cmd.Split(' ');
                string personName = input[0];
                string productName = input[1];
                Person person = people.FirstOrDefault(x => x.Name == personName);
                Product product = products.FirstOrDefault(x => x.Name == productName);
                Console.WriteLine(person.Buy(product));
            }
        }

        private static void CreateProducts()
        {
            string[] producstInfo = Console.ReadLine().Split(';');

            for (int i = 0; i < producstInfo.Length; i++)
            {
                string[] productInfo = producstInfo[i].Split('=');
                string name = productInfo[0];
                double cost = double.Parse(productInfo[1]);
                products.Add(new Product(name, cost));
            }
        }

        private static void CreatePeople()
        {

            string[] peopleInfo = Console.ReadLine().Split(';');

            for (int i = 0; i < peopleInfo.Length; i++)
            {
                string[] personInfo = peopleInfo[i].Split('=');
                string name = personInfo[0];
                double money = double.Parse(personInfo[1]);
                people.Add(new Person(name, money));
            }
        }
    }
}
