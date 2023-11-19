namespace P00_Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("John", "Johnson");
            Student s2 = new Student("Alex", "Petrov", 15, "Vasil Levski", "Velingrad");
            Student s3 = new Student();
            Console.WriteLine(s3);
      
        }
    }

}