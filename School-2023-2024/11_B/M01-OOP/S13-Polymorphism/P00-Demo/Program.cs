namespace P00_Demo
{
    public class Program
    {
        public static void Main()
        {
            Animal a1 = new Person("John",26);
            IPrintable ip1 = new Person("Jane", 25);
            Person p1 = new Person("Jane", 25);
            Console.WriteLine(p1.Print());
        }
    }
}