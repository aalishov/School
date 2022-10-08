using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Controller
{
    private List<Receipt> receipts = new List<Receipt>();
    private List<Product> currentProducts = new List<Product>();
    public string ProcessProductCommand(List<string> args)
    {
        string name = args[1];
        double price = double.Parse(args[2]);
        double weight = double.Parse(args[3]);
        currentProducts.Add(new PhysicalProduct(name, price, weight));
        return $"The current customer has bought {name}.";
    }
    public string ProcessServiceCommand(List<string> args)
    {
        string name = args[1];
        double price = double.Parse(args[2]);
        double time = double.Parse(args[3]);
        currentProducts.Add(new ServiceProduct(name, price, time));
        return $"The current customer has applied for {name} service.";
    }
    public string ProcessCheckoutCommand(List<string> args)
    {
        string customerName = args[1];
        Receipt receipt = new Receipt(customerName);
        this.currentProducts.ForEach(x => receipt.AddProduct(x));
        double sumOfProductPrices = this.currentProducts.Sum(x => x.Price);
        this.currentProducts.Clear();
        this.receipts.Add(receipt);
        return $"Customer checked out for a total of ${sumOfProductPrices:f2}.";
    }
    public string ProcessInfoCommand(List<string> args)
    {
        StringBuilder sb = new StringBuilder();
        string option = args[1];
        if (option == "Customer")
        {
            sb.AppendLine($"Current customer has:");
            sb.AppendLine($"Products: {this.currentProducts.Count}");
            sb.AppendLine($"Total Bill: ${this.currentProducts.Sum(x => x.Price):f2}");
        }
        else if (option == "Shop")
        {
            if (this.receipts.Count > 0)
            {
                sb.AppendLine($"Receipts:");
                this.receipts.ForEach(x => sb.AppendLine(x.ToString()));
            }
            else { sb.AppendLine("Receipts: No receipts"); }
        }
        return sb.ToString().TrimEnd();
    }
    public string ProcessEndCommand()
    {
        return $"Total customers today: {this.receipts.Count}";
    }
}

