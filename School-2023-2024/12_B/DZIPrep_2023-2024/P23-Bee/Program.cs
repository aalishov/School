
public class Program
{
    private static char[][] square;
    private static Position beePosition;
    private static int pollinatedFlowers = 0;
    public static void Main(string[] args)
    {
        ReadMatrix();
        try
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                square[beePosition.Row][beePosition.Col] = '.';
                Fly(command);
                if (square[beePosition.Row][beePosition.Col] == 'f')
                {
                    pollinatedFlowers++;
                }
                if (square[beePosition.Row][beePosition.Col] == 'O')
                {
                    square[beePosition.Row][beePosition.Col] = '.';
                    Fly(command);
                }
                square[beePosition.Row][beePosition.Col] = 'B';
            }
        }
        catch (Exception ex )
        {
            Console.WriteLine("The bee got lost!");
        }
        finally
        {
            if (pollinatedFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }
        }
        
    }

    private static void Fly(string command)
    {
        switch (command)
        {
            case "up":
                beePosition.Row--;
                break;
            case "down":
                beePosition.Row++;
                break;
            case "right":
                beePosition.Col++;
                break;
            case "left":
                beePosition.Col--;
                break;
            default:
                break;
        }
    }

    private static Position GetPosition(char symbol)
    {
        for (int i = 0; i < square.Length; i++)
        {
            for (int j = 0; j < square[i].Length; j++)
            {
                if (square[i][j] == symbol)
                {
                    return new Position(i, j);
                }
            }
        }
        return null;
    }
    private static void PrintMatrix()
    {
        for (int i = 0; i < square.GetLength(0); i++)
        {
            Console.WriteLine(string.Join(" ", square[i]));
        }
    }

    private static void ReadMatrix()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        square = new char[n][];
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            square[i] = line.ToCharArray();
        }
        beePosition = GetPosition('B');
    }
}
