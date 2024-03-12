public class Program
{
    static void Main()
    {

        IReader reader = new ConsoleReader();
        IWriter writer = new MyFileWriter();
        Engine engine = new Engine(reader,writer);
    }
}

