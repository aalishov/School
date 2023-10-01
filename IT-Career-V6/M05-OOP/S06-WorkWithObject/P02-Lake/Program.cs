namespace P02_Lake
{
    public class Program
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            Lake l = new Lake(nums);

            foreach (var n in l)
            {
               Console.Write(n+" ") ;
            }
            Console.WriteLine();
        }
    }
}