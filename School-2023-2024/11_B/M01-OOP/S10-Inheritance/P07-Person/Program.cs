public class Program
{
    public static void Main()
    {
        try
		{
            //int num = int.Parse("12as");
            Person p1 = new Person("John", -30);
            Person p2 = new Person("Maria", 28);
            Child p3 = new Child("Layla", 5, p2, p1);

            Console.WriteLine(p3);
        }
		catch (ArgumentException ex)
		{
            Console.WriteLine("Argument error....");
            Console.WriteLine(ex.Message);
		}
        catch (FormatException ex)
        {
            Console.WriteLine("Format error....");
            Console.WriteLine(ex.Message);
        }
    }
}
