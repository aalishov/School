public class Program
{
    public static void Main()
    {
        Box<int> box1 = new Box<int>("red");
        Box<string> box2 = new Box<string>("black");
        Box<bool> box3 = new Box<bool>("black");

        box1.Add(5);
        box1.Add(6);
        box1.Add(7);

        Console.WriteLine(box3.Remove());
        Console.WriteLine(box1.GetItems());
        Console.WriteLine(box1);
    }
}
