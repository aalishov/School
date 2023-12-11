namespace P04_MultipleImplementation
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter id: ");
            string id=Console.ReadLine();
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter birthdate (dd-MM-yyyy): ");
            DateOnly birtdate = DateOnly.ParseExact(Console.ReadLine(), "dd-MM-yyyy");

            Citizen citizen= new Citizen(id,name,birtdate);
            Console.WriteLine($"Name: {citizen.Name} - age: {citizen.Age}");
        }
    }
}