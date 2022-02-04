namespace PersonsInfo
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            Person person = new Person("John", "Deen", 54);
            person.FirstName = "Alex";
            Console.WriteLine(person);
        }
    }
}
