namespace P03_IPerson
{
    public class Program
    {
        public static void Main()
        {
            string name=Console.ReadLine(); 
            int age=int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age);
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}