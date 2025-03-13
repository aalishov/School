using System.Text;

namespace P01_BallGame
{
    public class Program
    {
        private static Stack<int> strength = null;
        private static Queue<int> accuracy = null;
        private static int goals = 0;
        public static void Main()
        {
            Input();
            Action();
            Output();
        }

        private static void Input()
        {
            strength = new Stack<int>(Read());
            accuracy = new Queue<int>(Read());
        }

        private static void Output()
        {
            if (goals == 3)
            {
                Console.WriteLine("Paul scored a hat-trick!");
            }
            else if (goals == 0)
            {
                Console.WriteLine("Paul failed to score a single goal.");
            }
            else if (goals > 3)
            {
                Console.WriteLine("Paul performed remarkably well!");
            }
            else if (goals > 0 && goals < 3)
            {
                Console.WriteLine("Paul failed to make a hat-trick.");
            }
            if (goals > 0)
            {
                Console.WriteLine($"Goals scored: {goals}");
            }
            if (strength.Any())
            {
                Console.Write("Strength values left: ");
                Console.WriteLine(string.Join(", ", strength));
            }
            if (accuracy.Any())
            {
                Console.Write("Accuracy values left: ");
                Console.WriteLine(string.Join(", ", accuracy));
            }
        }

        private static void Action()
        {
            while (strength.Any() && accuracy.Any())
            {
                int strengthValue = strength.Peek();
                int accuracyValue = accuracy.Peek();
                int sum = strengthValue + accuracyValue;

                if (sum == 100)
                {
                    strength.Pop();
                    accuracy.Dequeue();
                    goals++;
                }
                else if (sum < 100)
                {
                    if (strengthValue < accuracyValue)
                    {
                        strength.Pop();
                    }
                    else if (strengthValue > accuracyValue)
                    {
                        accuracy.Dequeue();
                    }
                    else if (strengthValue == accuracyValue)
                    {
                        strength.Pop();
                        strength.Push(sum);
                        accuracy.Dequeue();
                    }
                }
                else if (sum > 100)
                {
                    strengthValue -= 10;
                    strength.Pop();
                    strength.Push(strengthValue);
                    accuracy.Dequeue();
                    accuracy.Enqueue(accuracyValue);
                }
            }
        }

        private static int[] Read()
        {
            return Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        }
    }
}
