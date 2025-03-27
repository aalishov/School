public class Program
{
    public static void Main(string[] args)
    {
		try
		{
            string input = Console.ReadLine();
            string reversed = new string(input.Reverse().ToArray());

            int num = 0;
            bool isNumber = int.TryParse(input, out num);
            if (num < 0 || !isNumber) 
            { 
                throw new ArgumentException(); 
            }

            if (input.CompareTo(reversed) == 0 && isNumber)
            {
                Console.WriteLine($"{input} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{input} is NOT a palindrome");
            }
        }
		catch (Exception)
		{
            Console.WriteLine("Incorrectly entered number");
		}

    }
}