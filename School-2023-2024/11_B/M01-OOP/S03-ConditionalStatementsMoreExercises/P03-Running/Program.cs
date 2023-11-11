namespace P03_Running
{
    using System;

    public class Program
    {
        
        static void Main()
        {
            int lightDays = int.Parse(Console.ReadLine());


            int timeLightDays = lightDays * 55;
            int timeHardDays = (365 - lightDays) * 115;
            int time = timeLightDays + timeHardDays;

            int leftTime = Math.Abs(time - 40000);
            int hours = leftTime / 60;
            int minutes = leftTime % 60;

            if (time > 40000)
            {
                Console.WriteLine("Too much running!");
                Console.WriteLine($"Too hard to run for another {hours} hours and {minutes} minutes.");  
            }
            else
            {
                Console.WriteLine("Great training!");
                Console.WriteLine($"She can run for { hours} hours and { minutes} minutes more.");
            }
        }
    }
}