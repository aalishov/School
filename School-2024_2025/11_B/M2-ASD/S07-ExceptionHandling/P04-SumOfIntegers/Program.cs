public class Program
{
    static void Main(string[] args)
    {
        List<string> list = Console.ReadLine().Split(' ').ToList();
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            try
            {
                int num = int.Parse(list[i]);
                sum += num;
                Console.WriteLine($"Element '{list[i]}' processed - current sum: {sum}");

            }
            catch (OverflowException)
            {
                Console.WriteLine($"The element '{list[i]}' is out of range!");
            }
            catch (FormatException)
            {
                Console.WriteLine($"The element '{list[i]}' is in wrong format!");
            }
            catch (Exception)
            {

                throw;
            }
        }
        Console.WriteLine($"The total sum of all integers is: {sum}");

    }
}

