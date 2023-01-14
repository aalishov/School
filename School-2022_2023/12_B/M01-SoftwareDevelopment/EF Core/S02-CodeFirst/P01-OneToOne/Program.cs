public class Program
{
    private static AppDbContext db = new AppDbContext();
    public static void Main()
    {
        InsertData();

        foreach (var person in db.People.ToList())
        {
            Console.WriteLine($"{person.Id} {person.Name} {person.Salary} {person.Passport.Number}");
        }
    }

    private static void InsertData()
    {
        if (!db.Passports.Any())
        {
            db.Passports.AddRange
                (
                     new Passport() { Number = "N34FG21B" },
                     new Passport() { Number = "K65LO4R7" },
                     new Passport() { Number = "ZE657QP2" }
                );
            db.SaveChanges();
        }
        if (!db.People.Any())
        {
            db.People.AddRange
                (
                    new Person() { Name = "Roberto", Salary = 43300.00m, PassportId = 1 },
                    new Person() { Name = "Tom", Salary = 56100.00m, PassportId = 2 },
                    new Person() { Name = "Yana", Salary = 60200.00m, PassportId = 3 }
                );
            db.SaveChanges();
        }
    }
}
