namespace P06_CryptoMiningSystem
{
    public class Program
    {
        public static void Main()
        {
            VideoCard lp = new MineVideoCard("Nvidia",500,5,2);
            VideoCard hp = new GameVideoCard("Nvidia", 500, 5, 2);
            Console.WriteLine(lp.LifeWorkingHours);
            Console.WriteLine(hp.LifeWorkingHours);
        }
    }
}