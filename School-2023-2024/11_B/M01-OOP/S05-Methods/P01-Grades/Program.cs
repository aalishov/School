namespace P01_Grades
{
    public class Program
    {
       public static void Main()
        {
            Grades(5);
        }
       public static void Grades(double grade)
        {
            if (grade >= 2 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3 && grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 5.50 && grade <= 6)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Invalid grade!");
            }
        }
        
    }
}