namespace P03_EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());    
            List<int> numbers = new List<int>();
            while (true) 
            {
              int num = int.Parse(Console.ReadLine());    

            }
        }

        public int ReadNumber(int start,int end)
        {
            
                int a = int.Parse(Console.ReadLine());
                if (a > start && a < end)
                {
                    return a;
                }
                else
                {
                    throw new Exception("Invalid Num");
                }
            
           
        }
    }
}
