public class Program
{
    public static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new String('*',i));
        }


        //for (int i = 100; i >= 0; i--)
        //{
        //    Console.WriteLine(i);
        //}

        //for (int i = 1; i < 10000; i *= 5)
        //{
        //    Console.WriteLine($"{i}");

        //}

        //Console.WriteLine($"Count: {count}");

        //int num = 0;
        //int count = 0;
        //while (num % 2 == 0)
        //{
        //    Console.Write("Enter num: ");
        //    string cmd = Console.ReadLine();//end
        //    count++;
        //    if (cmd == "end")
        //    {

        //        break;

        //    }
        //    num = int.Parse(cmd);
        //}
        //Console.WriteLine($"Count: {count}");


        //int a = 11;
        //int count=0;
        //do
        //{
        //    Console.Write($"Enter a: ");
        //    a = int.Parse(Console.ReadLine());
        //    count++;
        //} while (a < 10);

        //Console.WriteLine($"Count: {count}");



        //Console.Write("Enter a: ");
        //int a = int.Parse(Console.ReadLine());

        //int count = 0;
        //while (a < 10)
        //{
        //    Console.Write("Enter a: ");
        //    a = int.Parse(Console.ReadLine());
        //    count++;
        //}

        //Console.WriteLine($"Count: {count}");
    }
}
