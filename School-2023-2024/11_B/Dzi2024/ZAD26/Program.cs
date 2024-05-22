namespace ZAD26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();
            int a = int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            for (int num = a; num <=b; num++)
            {
                int temp = num;
                while (temp>0)
                {
                    int digit = temp % 10;
                    if (map.ContainsKey(digit))
                    {
                        map[digit]++;
                    }else
                    {
                        map.Add(digit,1);
                    }
                    temp /= 10;
                }
            }
            var mapresult=map.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).FirstOrDefault();
            Console.WriteLine($"Digit {mapresult.Key} - {mapresult.Value}");

        }
    }
}
