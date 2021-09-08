using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine("*");
        }
        else
        {

            if (n % 2 == 1)
            {
                int rows = n / 2;
                //First rows
                //First row
                Console.Write(new string('-', rows));
                Console.Write("*");
                Console.WriteLine(new string('-', rows));

                for (int i = 0; i < rows - 1; i++)
                {
                    Console.Write(new string('-', rows - i - 1));
                    Console.Write("*");
                    Console.Write(new string('-', i * 2 + 1));
                    Console.Write("*");
                    Console.WriteLine(new string('-', rows - i - 1));
                }

                //Middle row

                Console.Write("*");
                Console.Write(new string('-', n - 2));
                Console.WriteLine("*");

                //Last rows

                for (int i = rows - 1; i > 0; i--)
                {
                    Console.Write(new string('-', rows - i));
                    Console.Write("*");
                    Console.Write(new string('-', i * 2 - 1));
                    Console.Write("*");
                    Console.WriteLine(new string('-', rows - i));
                }


                //Last row
                Console.Write(new string('-', rows));
                Console.Write("*");
                Console.WriteLine(new string('-', rows));
            }
            else
            {
                int rows = n / 2 - 1;
                //First rows
                for (int i = 0; i <= rows - 1; i++)
                {
                    Console.Write(new string('-', rows - i));
                    Console.Write("*");
                    Console.Write(new string('-', i * 2));
                    Console.Write("*");
                    Console.WriteLine(new string('-', rows - i));
                }

                //Middle row

                Console.Write("*");
                Console.Write(new string('-', n - 2));
                Console.WriteLine("*");

                //Last rows
                for (int i = rows - 1; i >= 0; i--)
                {
                    Console.Write(new string('-', rows - i));
                    Console.Write("*");
                    Console.Write(new string('-', i * 2));
                    Console.Write("*");
                    Console.WriteLine(new string('-', rows - i));
                }
            }
        }

    }
}

