class MyException : Exception { }
public class Program
{
    class MyException : Exception { }
    public static void Main()
    {
        Console.WriteLine(ack(2, 1));

    }
    static int ack(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return ack(m - 1, 1);

        return ack(m - 1, ack(m, n - 1));
    }

    public abstract class BaseClass
    {
        public abstract void Addition(double liters);
    }
    public class DeviseeClass : BaseClass
    {
        private string num;

        public  static int Count { get; set; }
        public double Quantity { get; set; }
        public override void Addition(double liters)
        {
            this.Quantity = liters * 0.20;
        }
    }
}
