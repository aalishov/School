public class Program
{
    private const double Treadmill = 5899.00;
    private const double CrossTrainer = 1699.00;
    private const double ExerciseBike = 1789.00;
    private const double Dumbells = 579;
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        double price = 0.0;
        for (int i = 0; i < n; i++)
        {
            string equipment = Console.ReadLine()!;
            switch (equipment)
            {
                case "treadmill":
                    price += Treadmill;
                    break;
                case "cross trainer":
                    price += CrossTrainer;
                    break;
                case "exercise bike":
                    price += ExerciseBike;
                    break;
                case "dumbbells":
                    price += Dumbells;
                    break;
            }
        }
        Console.WriteLine($"{price:f2}");
    }
}