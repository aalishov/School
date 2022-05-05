string sector = Console.ReadLine();
int rows=int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());
int seets = rows * cols;
double profit = 0;
switch (sector)
{
    case "Sector A":
        profit = seets * 11.60;
        break;
    case "Sector B":
        profit = seets * 14.50;
        break;
    case "Sector C":
        profit = seets * 16.10;
        break;
    case "Sector D":
        profit = seets * 8.40;
        break;
    default:
        Console.Error.WriteLine("Error command!");
        Environment.Exit(-1);
        break;
}
Console.WriteLine($"{sector} profit is {profit} lv.");