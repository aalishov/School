namespace P01_StringType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "some text";
            string name = "John";
            string town = "Velingrad";

            Console.WriteLine(s1);
            Console.WriteLine(name);
            Console.WriteLine(town);

            char symbol = '@';
            char letter = 'A';
            char sign = '+';

            Console.WriteLine(symbol);
            Console.WriteLine(letter);
            Console.WriteLine(sign);

            //int

            //double
            double d1 = 5.23;
            double d2 = Math.PI;
            double d3 = 2.365 + 9.564 + Math.PI;

            //bool
            bool isTrue1 = true;
            bool isTrue2 = 5 > 9;
            bool isTrue3 = 5 > 8 || 1 != 12; ;
            Console.WriteLine(isTrue1);
            Console.WriteLine(isTrue2);
            Console.WriteLine(isTrue3);
        }
    }
}
