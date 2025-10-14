namespace VetClinic
{
    public class StartUp
    {
        public static void Main()
        {
            Clinic c = new Clinic(4);
            c.Add(new Pet("Tom", 55, "askdklajs"));
            c.Add(new Pet("Tom", 25, "askdklajs")); 
            c.Add(new Pet("Tom", 45, "askdklajs"));
            c.Add(new Pet("Tom", 12, "askdklajs"));


            Console.WriteLine(c.GetOldestPet());

            //Console.WriteLine(c.Remove("Tom"));
            //Console.WriteLine(c.Remove("Tom"));
        }
    }
}
