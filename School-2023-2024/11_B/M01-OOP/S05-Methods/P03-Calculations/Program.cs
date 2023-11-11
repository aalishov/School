namespace P03_Calculations
{
    internal class Program
    {
        public static void Main()
        {

            Action();
        }

        public static void Add(int n, int m)
        {
            Console.WriteLine(n + m);
        }

        public static void Multiply(int n, int m)
        {
            Console.WriteLine(n * m);
        }

        public static void Substract(int n, int m)
        {
            Console.WriteLine(n - m);
        }

        public static void Divide(int n, int m)
        {
            Console.WriteLine(n / m);
        }

        public static void Action()
        {
            string cmd = Console.ReadLine();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (cmd == "Add")
            {
                Add(n1, n2);
            }
            else if (cmd == "Substract")
            {
                Substract(n1, n2);
            }
            else if (cmd == "Multiply")
            {
                Multiply(n1, n2);
            }
            else if (cmd == "Divide")
            {
                Divide(n1, n2);
            }
        }

    }
}