namespace P08_GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(5,16));
            Console.WriteLine(GetMax('a','b'));
            Console.WriteLine(GetMax("aa","bb"));
        }

        public static int GetMax(int a, int b)
        {
            if (a < b) { return b; }
            return a;
        }
        public static char GetMax(int a, char b)
        {
            if (a < b) { return b; }
            return a;
        }
        public static string GetMax(string a, string b)
        {
            if (a.CompareTo(b)>0) { return a; }
            return b;
        }
    }
}