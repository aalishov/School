namespace P06_RepeatString
{
    public class Program
    {
        public static void Main()
        {
            
            Console.WriteLine(RepeatString("ab", 3));

        }
        public static string RepeatString(string s, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result+= s;
            }
            return result;

        }
    }
}