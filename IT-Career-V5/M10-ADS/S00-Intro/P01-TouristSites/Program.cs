namespace P01_TouristSites
{
    using Data;
    using P01_TouristSites.Services;

    internal class Program
    {
        static void Main()
        {
            AppDbContext appDbContext= new AppDbContext();
            TouristsService touristsService = new TouristsService(appDbContext);

            string result = touristsService.DeleteTouristAsync("Mariya Petrova", 37, "+359887564235").GetAwaiter().GetResult();

            Console.WriteLine(result);

        }
    }
}