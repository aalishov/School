namespace People
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person mother = new Person("Jane", 35);
            Person father = new Person("Alex", 35);
            Family family = new Family(mother, father);
            family.AddChildData("John", 5);
            Console.WriteLine(family);


        }
    }
}
