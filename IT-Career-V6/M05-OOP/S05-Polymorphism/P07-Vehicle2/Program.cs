namespace P07_Vehicle2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus v1 = new Bus(100, 50, 1);

            Console.WriteLine(v1.Drive(10));
            Console.WriteLine(v1);
            v1.HasPassengers = true;
            Console.WriteLine(v1.Drive(10));
            Console.WriteLine(v1);
            v1.HasPassengers = false;
            Console.WriteLine(v1.Drive(10));
            Console.WriteLine(v1);
        }
    }
}