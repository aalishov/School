namespace NeedForSpeed
{
    public class StartUp
    {
      public  static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle(150, 60);
            Vehicle v2 = new Car(250, 60);
            v1.Drive(10);
            v2.Drive(10);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }
    }
}