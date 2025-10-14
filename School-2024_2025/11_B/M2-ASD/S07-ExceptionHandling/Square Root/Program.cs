public class Program
{
    public static void Main()
    {
		try
		{
			int num = int.Parse(Console.ReadLine());
			if (num < 0)
			{
				throw new Exception("Invalid number");
			}
			else
			{
				Console.WriteLine(Math.Sqrt(num));
			}
		}
		catch (Exception)
		{

            Console.WriteLine("Invalid number");
		}
		finally
		{
			Console.WriteLine("Good bye!");
		}
    }
}