namespace P01_ListIntro
{
    public class Program
    {
        public static void Main()
        {
            //int[] numsArray = { 5, 10, 15 };

            //List<int> list = new List<int>();
            //list.Add(10);
            //list.Add(15);
            //list.Insert(0, 5);
            //list.Insert(0, 5);
            //list.Insert(0, 5);
            ////list.AddRange(numsArray);

            //List<int> examNums = new List<int>() { 1, 2, 3, 4, 5 };
            //examNums[2] = 199;

            //Console.WriteLine(numsArray[2]);
            //Console.WriteLine(examNums[2]);

            //Console.WriteLine($"Aray: {string.Join(" ", numsArray)}");
            //Console.WriteLine($"Array length: {numsArray.Length}");
            //Console.WriteLine($"List: {string.Join(" ", examNums)}");
            //Console.WriteLine($"List length: {list.Count}");
            //Console.WriteLine($"List capacity: {list.Capacity}");

            //Console.WriteLine($"Sum = {examNums.Sum()}");
            //Console.WriteLine($"Max = {examNums.Max()}");
            //Console.WriteLine($"Min = {examNums.Min()}");
            //Console.WriteLine($"Average = {examNums.Average()}");

            List<double> nums = new List<double>() { -5, 12, 5, -2, 16, 18 };
            nums = nums.OrderByDescending(x => x).ToList();

            //Console.WriteLine(nums.IndexOf(2)); ;
            //Console.WriteLine(nums.LastIndexOf(2));

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
