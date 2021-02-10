using System;


class Program
{
    static void Main()
    {

        while (true)
        {
            try
            {
                int fNum = int.Parse(Console.ReadLine());
                int sNum = int.Parse(Console.ReadLine());
                Console.WriteLine($"=>{fNum / sNum}");
                if (fNum == sNum)
                {
                    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}

