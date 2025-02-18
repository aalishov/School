using System.Globalization;

namespace P03_PersonInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            DateTime dateTime = DateTime.ParseExact(birthdate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            IIdentifiable identifiable = new Citizen(name,id,dateTime);
            IPerson birthable = new Citizen(name, id,dateTime);
            //IPerson person = new Citizen(name, age);
            Console.WriteLine(identifiable.ID);
            Console.WriteLine(birthable.Age);
        }
    }
}
