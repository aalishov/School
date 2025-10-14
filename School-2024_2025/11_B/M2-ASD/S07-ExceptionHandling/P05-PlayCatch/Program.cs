

public class Program
{
    public static void Main()
    {
        int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int exceptionCount = 0;
        while (exceptionCount < 3)
        {
            try
            {
                string[] cmd = Console.ReadLine().Split(" ");
                if (cmd[0] == "Replace")
                {
                    int index = int.Parse(cmd[1]);
                    int element = int.Parse(cmd[2]);
                    array[index] = element;
                }
                else if (cmd[0] == "Print")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        Console.Write(array[i] + ", ");
                    }
                    Console.WriteLine();
                }
                else if (cmd[0] == "Show")
                {
                    int index = int.Parse(cmd[1]);
                    Console.WriteLine(array[index]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The index does not exist!");
                exceptionCount++;
            }
            catch (FormatException)
            {
                Console.WriteLine("The variable is not in the correct format!");
                exceptionCount++;
            }
        }
        Console.WriteLine(string.Join(", ",array));
    }
}

