namespace P23_FE_Lift
{
    public class Program
    {
        static void Main(string[] args)
        {
           int people = int.Parse(Console.ReadLine());
           int[] spots = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < spots.Length; i++)
            {
                int emptySpaces = spots[i];
                int freeSpace = 4 - emptySpaces;
                
                if (freeSpace > 0 && people>=4)
                {
                    people -= freeSpace;
                    spots[i] = 4;

                }
                
                else if (freeSpace >= people)
                {
                    spots[i] = people;
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(string.Join(" ",spots));
                    people = 0;
                    break;
                }

                
            
            }
            if (people > 0) 
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ",spots));
            
            }

        }
    }
}
