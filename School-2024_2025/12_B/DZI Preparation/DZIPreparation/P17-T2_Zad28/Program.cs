public class Program
{
    public static void Main(string[] args)
    {
        //23+3-2
        string input = Console.ReadLine();

        Queue<int> nums = new Queue<int>();
        Queue<char> operations = new Queue<char>();

        string stringNum = string.Empty;
        for (int i = 0; i < input.Length; i++)
        {

            if (char.IsDigit(input[i]))
            {
                stringNum += input[i];
            }
            else if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
            {
                nums.Enqueue(int.Parse(stringNum));
                operations.Enqueue(input[i]);
                stringNum = string.Empty;
            }
            if (i == (input.Length - 1))
            {
                nums.Enqueue(int.Parse(stringNum));
            }
        }


        int result = nums.Dequeue();
        while (nums.Count > 0)
        {
            int number = nums.Dequeue();
            char operation = operations.Dequeue();
            switch (operation)
            {
                case '+':
                    result += number;
                    break;
                case '-':
                    result -= number;
                    break;
                case '*':
                    result *= number;
                    break;
                case '/':
                    result /= number;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(result);
    }
}