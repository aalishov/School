using System.Data;

namespace P14_Success_1._3._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Book book = new Book("C# basic", "Svetlin Nakov", 10, "Horror");
                Book book1 = new Book("The 48 rules of power", "Robert Greene", 25, "Psychology");
                Book book2 = new Book("Rich dad, poor dad", "Robert Kiosaki", 19, "Psychology/finance");

                Console.WriteLine(book);
                Console.WriteLine(book1);
                Console.WriteLine(book2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine($"Have a good day!");
                
            }
        }
    }
}
