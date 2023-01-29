public class Program
{
    private static AppDbContext db = new AppDbContext();
    public static void Main()
    {
        InsertPassengers();
        PrintAllPassengers();
    }
    private static void PrintAllPassengers()
    {
        foreach (var item in db.Passengers.ToList())
        {
            Console.WriteLine($"{item.Id} - {item.FullName}");
        }
    }
    private static void InsertPassengers()
    {
        List<Pilot> pilots = db.Pilots.Where(x => x.Id >= 5 && x.Id <= 15).ToList();
        foreach (var p in pilots)
        {
            string fullName = p.FirstName + " " + p.LastName;
            string email = fullName + "@gmail.com";
            Passenger p1 = new Passenger {FullName = fullName, Email = email };
            db.Passengers.Add(p1);
        }
        db.SaveChanges();
    }
}
