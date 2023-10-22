namespace ShoppingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Controller
    {
        private readonly List<Receipt> receipts = new List<Receipt>();
        private readonly List<Product> products = new List<Product>();

        public string ProcessProductCommand(List<string> args)
        {
            Product p = new PhysicalProduct(args[0], double.Parse(args[1]), double.Parse(args[2]));
            products.Add(p);
            return $"The current customer has bought {args[0]}.";
        }

        public string ProcessServiceCommand(List<string> args)
        {
            Product p = new ServiceProduct(args[0], double.Parse(args[1]), double.Parse(args[2]));
            products.Add(p);
            return $"The current customer has applied for {args[0]} service.";
        }

        public string ProcessCheckoutCommand(List<string> args)
        {
            Receipt r = new Receipt(args[0]);
            products.ForEach(p => r.AddProduct(p));
            receipts.Add(r);
            double sumOfProductPrices = products.Sum(p => p.Price);
            products.Clear();
            return $"Customer checked out for a total of ${sumOfProductPrices:f2}.";
        }

        public string ProcessInfoCommand(List<string> args)
        {
            string result = args[0] == "Customer" ? CustomerInfo() : ShopInfo();

            return result ;
        }

        public string ProcessEndCommand()
        {
            return $"Total customers today: {receipts.Count}";
        }


        private string CustomerInfo()
        {
            return $"Products: {products.Count}{Environment.NewLine}Total Bill: ${products.Sum(x => x.Price):f2}";
        }

        private string ShopInfo()
        {
            if (!receipts.Any()) { return $"Receipts: No receipts"; }

            StringBuilder sb = new StringBuilder();
            receipts.ForEach(r=>sb.AppendLine(r.ToString()));
            return sb.ToString().TrimEnd();
        }

    }
}
