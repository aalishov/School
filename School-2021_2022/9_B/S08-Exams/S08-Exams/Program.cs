int days = int.Parse(Console.ReadLine());
int leftFood = int.Parse(Console.ReadLine());
double first = double.Parse(Console.ReadLine());
double second = double.Parse(Console.ReadLine());
double third = double.Parse(Console.ReadLine());

double foodNeeded = (first + second + third) * days;
if (foodNeeded > leftFood)
{
    double food = Math.Ceiling(foodNeeded - leftFood);
    Console.WriteLine($"{food} more kilos of food are needed.");
}
else
{
    double food = Math.Floor(leftFood - foodNeeded);
    Console.WriteLine($"{food} kilos of food left. ");
}



