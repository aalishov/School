namespace P00_SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rect = new Rectangle(4, 3);

            Console.WriteLine(rect.ExplainMyself());
        }
    }
}