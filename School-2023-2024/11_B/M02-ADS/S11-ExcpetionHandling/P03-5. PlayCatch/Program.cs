using System.Xml;

public class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        int exCount = 0;
        while (exCount < 3)
        {
            try
            {
                string[] input = Console.ReadLine().Split(" ");
                string cmd = input[0];
                if (cmd == "Replace")
                {
                    int index = int.Parse(input[1]);
                    int element = int.Parse(input[2]);
                    nums[index] = element;
                }
                else if (cmd == "Show")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(nums[index]);
                }
                else if (cmd == "Print")
                {
                    int start = int.Parse(input[1]);
                    int end = int.Parse(input[2]);
                    List<int> range = new List<int>();
                    for (int i = start; i <= end; i++)
                    {
                        range.Add(nums[i]);
                    }
                    Console.WriteLine(string.Join(", ", range));
                }
            }
            catch(IndexOutOfRangeException) 
            {
                Console.WriteLine("The index does not exist!");
                exCount++;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The index does not exist!");
                exCount++;
            }
            catch (FormatException)
            {
                Console.WriteLine("The variable is not in the correct format!");
                exCount++;
            }
        }
    }
}
