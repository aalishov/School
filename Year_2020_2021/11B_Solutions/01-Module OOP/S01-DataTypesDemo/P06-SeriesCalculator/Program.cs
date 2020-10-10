namespace P06_SeriesCalculator
{
    using System;
    class Program
    {
        static void Main()
        {
            Console.Write("Въведи име на филма: ");
            string name = Console.ReadLine();
            Console.Write("Въведи брой сезони: ");
            int numOfSeason = int.Parse(Console.ReadLine());
            Console.Write("Въведи брой епизоди: ");
            int numOfEpisodes = int.Parse(Console.ReadLine());
            Console.Write("Въведи продължителност на епизод: ");
            double time = double.Parse(Console.ReadLine());

            double adTimePerEpisode = 0.2 * time;

            time += adTimePerEpisode;

            double specialEpisodeTime = 10 * numOfSeason;

            double totalTime = time * numOfEpisodes * numOfSeason + specialEpisodeTime;

            Console.WriteLine($"Total time needed to watch the {name} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}
