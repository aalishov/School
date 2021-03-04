using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        //Подточка а)
        //PrintRandomOddNumbers();

        //Подточка б)
        //PrintGeometricМean();

        //Подточка в)
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        int result=Sss(Math.Abs(c-b))*Sss(a+c);
        Console.WriteLine(result);
    }
    //Подточка в)
    public static int Sss(int k)
    {
        Random random = new Random();

        int[] numbers = new int[k];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 1000);
        }
        int product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            //които са двуцифрени и завършват на 5
            bool isInProduct = numbers[i] >= 10 && numbers[i] <= 99 && numbers[i] % 10 == 5;
            if (isInProduct)
            {
                product *= numbers[i];
            }
        }
        return product;
    }

    //Подточка б)
    public static void PrintGeometricМean()
    {
        int[] nums = new int[5];

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($"Enter number [{i}]: ");
            nums[i] = int.Parse(Console.ReadLine());
        }
        int product = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
        }
        double result = Math.Pow((double)product, (double)1 / 5.0);
        Console.WriteLine($"Geometric mean: {result}");
    }

    //Подточка а)
    public static void PrintRandomOddNumbers()
    {
        Random random = new Random();

        int[] numbers = new int[132];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 150);
        }

        Console.WriteLine(string.Join(", ", numbers.Where(x => x % 2 != 0)));
    }
}



