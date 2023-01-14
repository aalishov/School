public class Program
{
    private static AppDbContext context = new AppDbContext();
    public static void Main()
    {
        if (!context.Manufacturers.Any())
        {
            var bmw = new Manufacturer() { Name = "BMW", EstablishedOn = new DateTime(1916, 03, 1) };
            var tesla = new Manufacturer() { Name = "Tesla", EstablishedOn = new DateTime(2003, 01, 1) };
            var lada = new Manufacturer() { Name = "Lada", EstablishedOn = new DateTime(1966, 05, 1) };
            context.Manufacturers.AddRange(bmw, lada, tesla);

            var x1 = new Model() { Name = "X1", Manufacturer = bmw };
            var i6 = new Model() { Name = "i6", Manufacturer = bmw };
            var mS = new Model() { Name = "Model S", Manufacturer = tesla };
            var mX = new Model() { Name = "Model X", Manufacturer = tesla };
            var m3 = new Model() { Name = "Model 3", Manufacturer = tesla };
            var nova = new Model() { Name = "Nova", Manufacturer = lada };
            context.Models.AddRange(x1, i6, mS, mX, m3, nova);
            context.SaveChanges();
        }

        foreach (var model in context.Models.ToList())
        {
            Console.WriteLine($"{model.Manufacturer.Name} {model.Name}");
        }
    }
}
