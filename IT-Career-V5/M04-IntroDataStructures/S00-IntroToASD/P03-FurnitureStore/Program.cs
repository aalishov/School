using System.Text;

public class Program
{
    static StringBuilder sb = new StringBuilder($"{new string('*', 20)}\n");
    static Dictionary<string, FurnitureStore> stores = new Dictionary<string, FurnitureStore>();
    static void Main(string[] args)
    {
        string input;

        while ((input = Console.ReadLine()) != "STOP")
        {
            string[] splittedInput = input.Split(' ');
            string command = splittedInput[0];

            switch (command)
            {
                case "AddFurniture":
                    AddFurniture(splittedInput[1], splittedInput[2], double.Parse(splittedInput[3]), splittedInput[4]);
                    break;
                case "SellFurniture":
                    SellFurniture(splittedInput[1], splittedInput[2], double.Parse(splittedInput[3]), splittedInput[4]);
                    break;
                case "CalculateTotalPrice":
                    CalculateTotalPrice(splittedInput[1]);
                    break;
                case "GetFurnitureWithHighestPrice":
                    GetFurnitureWithHighestPrice(splittedInput[1]);
                    break;
                case "GetFurnitureWithLowestPrice":
                    GetFurnitureWithLowestPrice(splittedInput[1]);
                    break;
                case "RenameFurnitureStore":
                    RenameFurnitureStore(splittedInput[1], splittedInput[2]);
                    break;
                case "SellAllFurnitures":
                    SellAllFurnitures(splittedInput[1]);
                    break;
                case "FurnitureStoreInfo":
                    FurnitureStoreInfo(splittedInput[1]);
                    break;
                case "CreateFurnitureStore":
                    CreateFurnitureStore(splittedInput[1]);
                    break;
                default:
                     Console.WriteLine("Invalid command!");
                    sb.AppendLine("Invalid command!");
                    break;
            }
        }
        //Console.Clear();
        Console.WriteLine(sb.ToString().TrimEnd());

        //string path = @"C:\Users\aalis\Desktop\result.txt";
        //using (StreamWriter w = new StreamWriter(path))
        //{
        //    w.Write(sb);
        //}
    }

    private static void AddFurniture(string type, string color, double price, string name)
    {
        try
        {
            Furniture furniture = new Furniture(type, color, price);
            if (!stores.ContainsKey(name))
            {
                 Console.WriteLine("Could not add this furniture to your store.");
                sb.AppendLine("Could not add this furniture to your store.");
                return;
            }
            FurnitureStore store = stores[name];
            store.AddFurniture(furniture);
             Console.WriteLine($"You added furniture {type} with color {color} to store {store.Name}.");
            sb.AppendLine($"You added furniture {type} with color {color} to store {store.Name}.");

        }
        catch (ArgumentException ex)
        {
             Console.WriteLine(ex.Message);
            sb.AppendLine(ex.Message);
        }
    }

    private static void SellFurniture(string type, string color, double price, string name)
    {
        try
        {
            if (!stores.ContainsKey(name))
            {
                 Console.WriteLine("Could not sell this furniture from your store.");
                sb.AppendLine("Could not sell this furniture from your store.");
                return;
            }

            Furniture furniture = new Furniture(type, color, price);
            FurnitureStore store = stores[name];
            if (store.SellFurniture(furniture))
            {
                 Console.WriteLine($"You sold furniture {type} with color {color} from furniture store {name}.");
                sb.AppendLine($"You sold furniture {type} with color {color} from furniture store {name}.");
            }
            else
            {
                Console.WriteLine($"Did not sell furniture {type} with color {color} from furniture store {name}.");
                sb.AppendLine($"Did not sell furniture {type} with color {color} from furniture store {name}.");
            }
        }
        catch (ArgumentException ex)
        {
             Console.WriteLine(ex.Message);
            sb.AppendLine(ex.Message);
        }
    }

    private static void CalculateTotalPrice(string name)
    {
        try
        {
            if (!stores.ContainsKey(name))
            {
                 Console.WriteLine("Could not calculate total price.");
                sb.AppendLine("Could not calculate total price.");
                return;
            }
            FurnitureStore store = stores[name];

             Console.WriteLine($"Total price: {store.CalculateTotalPrice():F2}");
            sb.AppendLine($"Total price: {store.CalculateTotalPrice():F2}");
        }
        catch (ArgumentException ex)
        {
             Console.WriteLine(ex.Message);
            sb.AppendLine(ex.Message);
        }
    }

    private static void RenameFurnitureStore(string name, string newName)
    {

        if (!stores.ContainsKey(name))
        {
             Console.WriteLine($"Could not rename the store {name}.");
            sb.AppendLine($"Could not rename the store {name}.");
            return;
        }
        FurnitureStore store = stores[name];

        try
        {
            store.RenameFurnitureStore(newName);
            stores.Remove(name);
            stores.Add(newName, store);
             Console.WriteLine($"You renamed your store from {name} to {newName}.");
            sb.AppendLine($"You renamed your store from {name} to {newName}.");
        }
        catch (ArgumentException ex)
        {
             Console.WriteLine(ex.Message);
            sb.AppendLine(ex.Message);
        }
    }

    private static void SellAllFurnitures(string name)
    {

        if (!stores.ContainsKey(name))
        {
             Console.WriteLine($"Could not sell all furnitures from store {name}.");
            sb.AppendLine($"Could not sell all furnitures from store {name}.");
            return;
        }
        FurnitureStore store = stores[name];

        store.SellAllFurnitures();
         Console.WriteLine($"You sold all furnitures from store {name}.");
        sb.AppendLine($"You sold all furnitures from store {name}.");
    }

    private static void FurnitureStoreInfo(string name)
    {
        if (!stores.ContainsKey(name))
        {
             Console.WriteLine($"Could not get store {name}.");
            sb.AppendLine($"Could not get store {name}.");
            return;
        }
        FurnitureStore store = stores[name];
         Console.WriteLine(store.ToString());
        sb.AppendLine(store.ToString());
    }

    private static void GetFurnitureWithLowestPrice(string name)
    {

        if (!stores.ContainsKey(name))
        {
             Console.WriteLine($"Could not get furniture with lowest price from store {name}.");
            sb.AppendLine($"Could not get furniture with lowest price from store {name}.");
            return;
        }
        FurnitureStore store = stores[name];

         Console.WriteLine($"Furniture from store {name} has lowest price: {store.GetFurnitureWithLowestPrice().Price:F2}");
        sb.AppendLine($"Furniture from store {name} has lowest price: {store.GetFurnitureWithLowestPrice().Price:F2}");
    }

    private static void GetFurnitureWithHighestPrice(string name)
    {

        if (!stores.ContainsKey(name))
        {
             Console.WriteLine($"Could not get furniture with highest price from store {name}.");
            sb.AppendLine($"Could not get furniture with highest price from store {name}.");
            return;
        }
        FurnitureStore store = stores[name];

         Console.WriteLine($"Furniture from store {name} has highest price: {store.GetFurnitureWithHighestPrice().Price:F2}");
        sb.AppendLine($"Furniture from store {name} has highest price: {store.GetFurnitureWithHighestPrice().Price:F2}");
    }


    private static void CreateFurnitureStore(string name)
    {

        try
        {
            FurnitureStore store = new FurnitureStore(name);
            stores.Add(name, store);
              Console.WriteLine($"You created furniture store {name}.");
            sb.AppendLine($"You created furniture store {name}.");
        }
        catch (ArgumentException ex)
        {
             Console.WriteLine(ex.Message);
            sb.AppendLine(ex.Message);
        }
    }
}
