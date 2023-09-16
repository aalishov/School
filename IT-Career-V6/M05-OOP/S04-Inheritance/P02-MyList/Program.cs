public class Program
{
    public static void Main(string[] args)
    {
        MyList<string> list = new MyList<string>();
        list.Add("a");
        list.Add("b");
        list.Add("c");
        list.Add("d");
        list.Add("e");
        list.Add("f");


        Console.WriteLine(list.GetReversedElement());
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(list.GetRandomItem());
        }

    }

}
