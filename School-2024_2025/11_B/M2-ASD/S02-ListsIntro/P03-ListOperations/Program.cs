public class Program
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToList();

        while (true)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();//["aDd", "5"]
            string cmd = input[0].ToLower(); //"add"

            if (cmd == "end")
            {
                break;
            }
            else if (cmd == "insert")
            {
                int num = int.Parse(input[1]);
                int index = int.Parse(input[2]);
                numbers.Insert(index, num);

            }
            else if (cmd == "add")
            {
                int num = int.Parse(input[1]);
                numbers.Add(num);
            }
            else if (cmd == "remove")
            {
                int index = int.Parse(input[1]);
                numbers.RemoveAt(index);
            }
            else if (cmd == "shift")
            {
                if (input[1] == "left")
                {
                    int count = int.Parse(input[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int firstNumber = numbers.First();
                        numbers.RemoveAt(0);
                        numbers.Add(firstNumber);
                    }
                }
                else if (input[1] == "right")
                {

                    int count = int.Parse(input[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int lastNumber = numbers.Last();
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, lastNumber);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}


