
using System.Text;

public class Program
{
    private static List<Furniture> furnitures = new List<Furniture>();

    public static void Main()
    {
        CreateFurntitures();
        PrintFurnitures();
    }

    private static void PrintFurnitures()
    {
        StringBuilder table = new StringBuilder("All tables:\n\r");
        StringBuilder cabinet = new StringBuilder("All cabinets:\n\r");

        foreach (var item in furnitures)
        {
            if (item.TypeProduct == "table")
            {
                table.AppendLine(item.ToString());
            }
            else
            {
                cabinet.AppendLine(item.ToString());
            }
        }

        Console.WriteLine(table.ToString().TrimEnd());
        Console.WriteLine(cabinet.ToString().TrimEnd());
    }

    private static void CreateFurntitures()
    {
        while (true)
        {
            try
            {
                string[] cmd = Console.ReadLine().Split(" ");
                switch (cmd[0])
                {
                    case "END":
                        return;
                    case "table":
                        furnitures.Add(new Table(cmd[0], double.Parse(cmd[1])));
                        break;
                    case "cabinet":
                        furnitures.Add(new Cabinet(cmd[0], double.Parse(cmd[1]), int.Parse(cmd[2])));
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
