//Input
int x = int.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());
int workers = int.Parse(Console.ReadLine());

double totalGrapes = x * y;
double grapesWine = totalGrapes * 0.4;
double wine = grapesWine / 2.5;

double litersLeft = Math.Abs(Math.Ceiling(wine - z));
if (wine > z)
{
    double winePerWorker = litersLeft / workers;
    Console.WriteLine($"Good harvest this year! Total wine: {wine} liters. {litersLeft} liters left -> {winePerWorker} liters per person.");
}
else
{
    Console.WriteLine($"It will be a tough winter! More {litersLeft} liters wine needed.");
}