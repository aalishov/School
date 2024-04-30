public class Program
{
    public static void Main()
    {
        double students = double.Parse(Console.ReadLine());
        double lectures = double.Parse(Console.ReadLine());
        double additionalBonus = double.Parse(Console.ReadLine());
        double maxBonus = 0;
        double maxLectures = 0;
        double totalBonus = 0;
        for (int i = 0; i < students; i++)
        {
            double attendance = double.Parse(Console.ReadLine());
            totalBonus += attendance / lectures * (5 + additionalBonus);
            if (totalBonus > maxBonus)
            {
                maxBonus = totalBonus;
            }
            if (attendance > maxLectures)
            {
                maxLectures = attendance;
            }
            totalBonus = 0;
        }
        Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
        Console.WriteLine($"The student has attended {maxLectures} lectures.");
    }
}
