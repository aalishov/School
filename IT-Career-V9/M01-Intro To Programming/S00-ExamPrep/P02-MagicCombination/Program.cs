public class Program
{
    public static void Main()
    {
        int magic = int.Parse(Console.ReadLine());
        for (int i = 0; i <= 9; i++)
        {
            for (int j = 0; j <= 9; j++)
            {
                for (int k = 0; k <= 9; k++)
                {
                    for (int l = 0; l <= 9; l++)
                    {
                        for (int m = 0; m <= 9; m++)
                        {
                            for (int n = 0; n <= 9; n++)
                            {
                                if (i * j * k * l * m * n == magic)
                                {
                                    Console.WriteLine($"{i}{j}{k}{l}{m}{n}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

