public class Program
{
    public static void Main()
    {
        int relaxingDays = int.Parse(Console.ReadLine());
        int workingDays = 365 - relaxingDays;

        int workingDaysPlay = workingDays * 63;
        int relaxingDaysPlay = relaxingDays * 127;
        int totalPlay = workingDaysPlay + relaxingDaysPlay;

        int diff = Math.Abs(totalPlay - 30000);
        int hours = diff / 60;
        int minutes = diff % 60;

        if (totalPlay > 30000)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine($"{hours} hours and {minutes} more for play");
        }
        else
        {
            Console.WriteLine($"Tom sleeps well");
            Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
        }
    }
}
