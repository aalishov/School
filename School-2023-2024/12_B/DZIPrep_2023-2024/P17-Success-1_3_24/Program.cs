namespace P17_Success_1_3_24
{
    public class Program
    {
        static void Main()
        {
            Star star = new Star(200.0, 2500, "Six");
            Planet planet = new Planet(2000, 25000, star);
            Moon moon = new Moon(1500, 2000, planet);

            Console.WriteLine(star);
            Console.WriteLine(planet);
            Console.WriteLine(moon);
        }
    }
}
