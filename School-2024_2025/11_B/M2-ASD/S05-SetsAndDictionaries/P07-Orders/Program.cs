public class Program
{
    public static void Main()
    {
        Dictionary<string, double> prices = new Dictionary<string, double>();
        Dictionary<string, double> quantities = new Dictionary<string, double>();

        while (true)
        {
            string[] info = Console.ReadLine()
                .Split(" ")
                .ToArray();

            if (info[0] == "buy") { break; }

            string productName = info[0];
            double productPrice = double.Parse(info[1]);
            int productQuantity = int.Parse(info[2]);

            if (prices.ContainsKey(productName))
            {
                prices[productName] = productPrice;
                quantities[productName] += productQuantity;
            }
            else
            {
                prices.Add(productName, productPrice);
                quantities.Add(productName, productQuantity);
            }
        }

        foreach (var product in prices)
        {
            Console.WriteLine($"{product.Key} -> {product.Value * quantities[product.Key]:f2}");
        }

        //foreach (var item in quantities)
        //{
        //    foreach (var product in prices)
        //    {
        //        if (item.Key==product.Key)
        //        {
        //            Console.WriteLine($"{product.Key} -> {product.Value * item.Value:f2}");
        //        }
        //    }
        //}

    }
}